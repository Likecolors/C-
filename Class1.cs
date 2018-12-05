using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using  HFReader;
namespace HF

{
    public class ISO14443Reader
    {
        #region PrivateProperty
        private SerialPort serialport;
        private Int32 Device = 0;
        //private Socket socket;
        private Byte CurrNum = 0x00;
        //private Boolean isAutoRcv = false;             //用于AutoReceive
        //private Boolean isRegistedEvent = false;   //用于AutoReceive
        //private Int32 autoRcvdTagCount = 0;
        //private String[] autoRcvdTagNum = new String[] { };

        private Byte AllDone = 0x00;
        private Byte SerialPortErr = 0x01;
        private Byte SendTimeOut = 0x02;
        private Byte RcvTimeOut = 0x03;
        private Byte FrameFormatErr = 0x04;
        private Byte CRCERR = 0x05;
        private Byte DataLengthERR = 0x06;
        private Byte ReturnFrameNumErr = 0x07;
        private Byte ParameterErr = 0x08;
        private Byte EventErr = 0x09;   //用于AutoReceive
        private Byte RequestErr = 0x11;
        private Byte AntiCollErr = 0x12;
        private Byte SelectErr = 0x13;
        private Byte ResetToReadyErr = 0x14;
        private Byte AuthenticationErr = 0x15;
        private Byte ReadErr = 0x16;
        private Byte WriteErr = 0x17;
        private Byte InventoryErr = 0x18;

        const UInt16 vid = 0x10C4;// 0x064D; //
        const UInt16 pid = 0x8468;// 0xC045;// 
        const Int32 HID_READ_TIMEOUT = 100;
        const Int32 HID_WRITE_TIMEOUT = 1000;
        // HID Report Sizes
        const Int32 SIZE_IN_CONTROL = 5;
        const Int32 SIZE_OUT_CONTROL = 5;
        const Int32 SIZE_IN_DATA = 61;
        const Int32 SIZE_OUT_DATA = 61;
        const Int32 SIZE_MAX_WRITE = 59;
        const Int32 SIZE_MAX_READ = 59;
        // HID Report IDs
        const Byte ID_IN_CONTROL = 0xFE;
        const Byte ID_OUT_CONTROL = 0xFD;
        const Byte ID_IN_DATA = 0x01;
        const Byte ID_OUT_DATA = 0x02;

        #endregion

        #region PublicProperty
        public Byte ConnectType
        {
            get
            {
                if ((Device > 0) && HIDDevice.HidDevice_IsOpened(Device))
                { return 0x02; }
                else
                {
                    try { return (Byte)(serialport.IsOpen ? 0x01 : 0x00); }
                    catch { return 0x00; }
                }
            }
        }
        public Boolean IsOpen
        {
            get
            {
                return (ConnectType > 0);
            }
        }
        //public String ConnectType
        //{
        //        get
        //        {
        //                try { if (serialport.IsOpen) return "SerialPort"; }
        //                catch { }
        //                try { if (socket.Connected) return "Network"; }
        //                catch { }
        //                return "None";
        //        }
        //}
        //public String PortName
        //{
        //        get
        //        {
        //                try { return serialport.PortName; }
        //                catch { return null; }
        //        }
        //}
        //public Boolean IsAutoRcv
        //{
        //        get
        //        {
        //                return isAutoRcv;
        //        }
        //}                  //用于AutoReceive

        #endregion
        //#region PublicEvent
        //public delegate void FrameSendDel(String Frame);
        //public event FrameSendDel OnFrameSend;
        //public delegate void FrameReceiveDel(String Frame);
        //public event FrameReceiveDel OnFrameReceive;
        //public delegate void TagDetectedDel(Int32 TagNumber, String[] TagUIDs);
        //public event TagDetectedDel OnTagDetected;
        //#endregion

        #region PrivateMethod
        /// <summary>
        /// 将字节数组转换为十六进制的字符串
        /// </summary>
        /// <param name="array">字节数组</param>
        /// <returns>字符串</returns>
        private String ByteArrayToString(Byte[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Byte a in array) { sb = sb.Append(a.ToString("X2")); }
            return sb.ToString();
        }
        private String ByteArrayToString(Byte[] array, Int32 StartPos, Int32 Length)
        {
            StringBuilder sb = new StringBuilder();
            for (Int32 index = StartPos; index < StartPos + Length; index++)
            { sb = sb.Append(array[index].ToString("X2")); }
            return sb.ToString();
        }


        /// <summary>
        /// 将十六进制的字符串转换为字节数组
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>字节数组</returns>
        private Byte[] StringToByteArray(String str)
        {
            Byte[] data = new Byte[str.Length / 2];
            for (Int32 i = 0; i < data.Length; i++)
            {
                data[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
            }
            return data;
        }

        private Byte SendAFrame(Byte Command, Byte[] data)
        {
            //if (!IsOpen) { return SerialPortErr; }
            Byte[] frame = new Byte[data.Length + 6];
            frame[0] = CurrNum;
            frame[1] = Command;
            frame[2] = (Byte)(data.Length * 2 % 256);
            frame[3] = (Byte)(data.Length * 2 / 256);
            for (Int32 i = 0; i < data.Length; i++)
            {
                frame[4 + i] += data[i];
            }
            CalculateCRC(ref frame, 0, data.Length + 4);
            String strframe = ":";
            strframe += ByteArrayToString(frame);
            strframe += "\r\n";
            CurrNum++;
            switch (ConnectType)
            {
                case 0x01:
                    try
                    {
                        serialport.DiscardInBuffer();
                        serialport.WriteLine(strframe);
                        return AllDone;
                    }
                    catch
                    {
                        return SendTimeOut;
                    }
                case 0x02:
                    Byte result = WriteToHIDDevice(strframe + "\r\n");
                    if (result == 0x00)
                    { return AllDone; }
                    else
                    { return SendTimeOut; }
                default:
                    return 0x01;
            }
        }

        private Byte RcvAFrame(ref Byte ReturnFrameNum, ref Byte StateCode, ref Int32 DataLength, ref Byte[] FrameData)
        {
            if (ConnectType < 1) { return SerialPortErr; }
            String strFrame = "";
            switch (ConnectType)
            {
                case 0x01:
                    try
                    {
                        strFrame = serialport.ReadLine();
                        break;
                    }
                    catch
                    {
                        return RcvTimeOut;
                    }
                case 0x02:
                    String strdata;
                    Byte result;
                    int i = 70;
                    try
                    {
                        do
                        {
                            result = ReadFromHIDDevice(out strdata);
                            strFrame += strdata;
                            i--;
                        }
                        while (strFrame.IndexOf("\r\n") < 0 && i > 1);
                        if (strFrame.IndexOf("\r\n") >= 0)
                            strFrame = strFrame.Substring(0, strFrame.IndexOf("\r\n"));
                    }
                    catch (Exception err)
                    { }
                    break;
            }

            if (strFrame.IndexOf(":") != 0)
            {
                return FrameFormatErr; //需要改进改进
                                       //return RcvAFrame(ref StateCode, ref FrameData, ref DataLength);
            }
            strFrame = strFrame.Remove(0, 1);
            Byte[] Frame = new Byte[strFrame.Length / 2];
            for (int i = 0; i < Frame.Length; i++)
            { Frame[i] = Convert.ToByte(strFrame.Substring(i * 2, 2), 16); }
            if (CheckCRC(Frame))
            {
                ReturnFrameNum = Frame[0];
                if (ReturnFrameNum >= CurrNum) { return ReturnFrameNum; }
                if (ReturnFrameNum < (CurrNum - 1)) { return RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData); }
                StateCode = Frame[1];
                DataLength = Frame[3] * 256 + Frame[2];
                if (DataLength != (Frame.Length - 6))
                { return DataLengthERR; }
                if (DataLength > 0)
                {
                    FrameData = new Byte[DataLength];
                    for (Int32 i = 0; i < DataLength; i++)
                    {
                        FrameData[i] = Frame[4 + i];
                    }
                }
                return AllDone;
            }
            else
            { return CRCERR; }
        }

        private void CalculateCRC(ref Byte[] frame, Int32 offset, Int32 datalength)
        {
            UInt16 crc16_preset = 0xFFFF;
            UInt16 RFCRC16_POLYNOM = 0x8408;
            UInt16 CRC16, m;
            Byte n;
            CRC16 = crc16_preset;
            for (m = 0; m < datalength; m++)
            {
                CRC16 ^= (UInt16)(frame[offset + m] & 0xff);
                //pointer++;

                for (n = 0; n < 8; n++)
                {
                    if ((CRC16 & 0x0001) > 0)
                        CRC16 = (UInt16)((CRC16 >> 1) ^ RFCRC16_POLYNOM);
                    else
                        CRC16 = (UInt16)(CRC16 >> 1);
                }
            }
            frame[offset + datalength] = (Byte)(CRC16 % 256);
            frame[offset + datalength + 1] = (Byte)(CRC16 / 256);
        }

        private Boolean CheckCRC(Byte[] frame)
        {
            Int32 length = frame.Length;
            Byte LowByte, UperByte;
            UperByte = frame[length - 1];
            LowByte = frame[length - 2];
            CalculateCRC(ref frame, 0, length - 2);
            if ((UperByte == frame[length - 1]) && (LowByte == frame[length - 2]))
            { return true; }
            else
            { return false; }
        }

        #endregion

        #region PublicMethod

        /// <summary>
        /// 打开串口,参数portName为串口号,如"COM1",参数BaudRate为波特率，默认的模特率为115200;
        /// 其它串口参数采用默认设置:数据位8;停止位1;奇偶校验无.
        /// </summary>
        public Byte OpenSerialPort(String portName, Int32 BaudRate)
        {
            return mOpenSerialPort(portName, BaudRate, 8, StopBits.One, Parity.None);
        }
        public Byte OpenSerialPort(String portName)
        {
            return mOpenSerialPort(portName, 115200, 8, StopBits.One, Parity.None);
        }
        private Byte mOpenSerialPort(String portName, Int32 BaudRate, Int32 DataBits, StopBits StopBits, Parity Parity)
        {
            try
            {
                serialport = new SerialPort(portName);
                serialport.BaudRate = BaudRate;
                serialport.DataBits = DataBits;
                serialport.StopBits = StopBits;
                serialport.Parity = Parity;
                serialport.NewLine = "\r\n";
                serialport.ReadTimeout = 3000;
                serialport.Open();
                if (serialport.IsOpen) return AllDone;  //打开成功
                return SerialPortErr;  //打开失败
            }
            catch
            {
                return SerialPortErr; //打开失败
            }
        }

        public Byte CloseSerialPort()
        {
            try
            {
                serialport.Close();
                if (!serialport.IsOpen)
                {
                    serialport = null;
                    return AllDone;
                }
                else
                {
                    return SerialPortErr;
                }
            }
            catch { return SerialPortErr; }
        }

        public Int32 GetHIDDeviceNum()
        { return HIDDevice.HidDevice_GetNumHidDevices(vid, pid); }

        public Byte OpenHIDDevice(Int32 DeviceIndex)
        {
            Int32 DeviceNum = HIDDevice.HidDevice_GetNumHidDevices(vid, pid);
            if (DeviceNum < 1)
            { return 0x01; }
            IntPtr pDevice = Marshal.AllocHGlobal(4);
            Byte status = HIDDevice.HidDevice_Open(pDevice, DeviceIndex, vid, pid, HIDDevice.MAX_REPORT_REQUEST_XP);
            Device = Marshal.ReadInt32(pDevice);
            //HIDDevice.HidDevice_SetTimeouts(Device, 500, 500);

            Marshal.FreeHGlobal(pDevice);
            if (status == HIDDevice.HID_DEVICE_SUCCESS)
            {
                return 0x00;
            }
            else
            { Device = 0; return 0x01; }
        }
        public Byte OpenHIDDevice()
        { return OpenHIDDevice(0); }

        public Byte CloseHIDDevice()
        {
            Byte status = HIDDevice.HidDevice_Close(Device);
            if (status == HIDDevice.HID_DEVICE_SUCCESS)
            {
                Device = 0;
                return 0x00;
            }
            else
            {
                return 0x01;
            }
        }

        private Byte WriteToHIDDevice(Byte[] data)
        {
            Int32 reportSize = HIDDevice.HidDevice_GetOutputReportBufferLength(Device);
            IntPtr pReport = Marshal.AllocHGlobal(reportSize);
            Byte[] reportData = new Byte[reportSize];
            reportData[0] = ID_OUT_DATA;
            Int32 bytesWritten, bytesToWrite;
            bytesToWrite = data.Length;
            bytesWritten = 0;
            while (bytesWritten < bytesToWrite)
            {
                Int32 transferSize = Math.Min(bytesToWrite - bytesWritten, SIZE_MAX_WRITE);
                reportData[1] = (Byte)transferSize;
                for (int i = 0; i < transferSize; i++)
                {
                    reportData[2 + i] = data[bytesWritten + i];
                }
                Marshal.Copy(reportData, 0, pReport, transferSize + 2);
                if (HIDDevice.HidDevice_SetOutputReport_Interrupt(Device, pReport, reportSize) != HIDDevice.HID_DEVICE_SUCCESS)
                {
                    // Stop transmitting if there was an error
                    break;
                }
                bytesWritten += transferSize;
            }
            Marshal.FreeHGlobal(pReport);
            if (bytesWritten == bytesToWrite)
            {
                return 0x00;
            }
            else
            { return 0x01; }

        }

        private Byte WriteToHIDDevice(String strdata)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(strdata);
            return WriteToHIDDevice(data);
        }

        private Byte ReadFromHIDDevice(out String strdata)
        {
            Byte status;
            Int32 bufferSize = HIDDevice.HidDevice_GetInputReportBufferLength(Device);
            IntPtr pBuffer = Marshal.AllocHGlobal(bufferSize);
            Byte[] data = new Byte[bufferSize];
            Int32 bytesRead = 0;
            // Receive as many input reports as possible
            // (resulting data bytes must be able to fit in the user buffer)
            status = HIDDevice.HidDevice_GetInputReport_Interrupt(Device, pBuffer, bufferSize, 1, ref bytesRead);

            // Success indicates that numReports were read
            // Transfer timeout may have returned less data
            if (status == HIDDevice.HID_DEVICE_SUCCESS)
            {
                Marshal.Copy(pBuffer, data, 0, bytesRead);
                strdata = System.Text.Encoding.ASCII.GetString(data, 2, data[1]);
                Marshal.FreeHGlobal(pBuffer);
                return 0x00;
            }
            else
            { strdata = ""; return 0x01; }

        }

        public Byte Request(Byte RequestFlag)
        {
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x81;
            Byte[] data = new Byte[1];
            data[0] = RequestFlag;
            Byte value = SendAFrame(command, data);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return RequestErr; }
            if (DataLength == 0) { return RequestErr; }
            if (FrameData[0] != 0) { return RequestErr; }
            return AllDone;
        }

        public Byte AntiColl(Byte AntiCollFlag, out Byte[] TagUID)
        {
            TagUID = new Byte[0];
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x82;
            Byte[] data = new Byte[1];
            data[0] = AntiCollFlag;
            Byte value = SendAFrame(command, data);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return AntiCollErr; }
            if (DataLength == 0) { return AntiCollErr; }
            if (FrameData[0] != 0) { return AntiCollErr; }
            try
            {

                TagUID = new Byte[5];
                for (Int32 i = 0; i < TagUID.Length; i++)
                { TagUID[i] = FrameData[1 + i]; }
                return AllDone;
            }
            catch
            {
                return AntiCollErr;
            }
        }

        public Byte Select(Byte[] TagUID)
        {
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x83;
            //Byte[] data = new Byte[1];
            //data[0] = AntiCollFlag;
            Byte value = SendAFrame(command, TagUID);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return SelectErr; }
            if (DataLength == 0) { return SelectErr; }
            if (FrameData[0] != 0) { return SelectErr; }
            return AllDone;
            //try
            //{

            //        TagUID = new Byte[5];
            //        for (Int32 i = 0; i < TagUID.Length; i++)
            //        { TagUID[i] = FrameData[1 + i]; }
            //        return AllDone;
            //}
            //catch
            //{
            //        return InventoryErr;
            //}
        }

        public Byte Authentication(Byte[] TagUID, Byte BlockAddr, Byte[] Password)
        {
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x84;
            Byte[] data = new Byte[12];
            try
            {
                for (Int32 i = 0; i < 5; i++)
                {
                    data[i] = TagUID[i];
                }
                data[5] = BlockAddr;
                for (Int32 i = 0; i < 6; i++)
                {
                    data[6 + i] = Password[i];
                }
            }
            catch
            { return AuthenticationErr; }
            //data[0] = AntiCollFlag;
            Byte value = SendAFrame(command, data);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return AuthenticationErr; }
            if (DataLength == 0) { return AuthenticationErr; }
            if (FrameData[0] != 0) { return AuthenticationErr; }
            return AllDone;
            //try
            //{

            //        TagUID = new Byte[5];
            //        for (Int32 i = 0; i < TagUID.Length; i++)
            //        { TagUID[i] = FrameData[1 + i]; }
            //        return AllDone;
            //}
            //catch
            //{
            //        return InventoryErr;
            //}
        }

        public Byte Read(Byte BlockAddr, out Byte[] ReadData)
        {
            ReadData = new Byte[0];
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x85;
            Byte[] data = new Byte[1];
            data[0] = BlockAddr;
            Byte value = SendAFrame(command, data);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return ReadErr; }
            if (DataLength == 0) { return ReadErr; }
            if (FrameData[0] != 0) { return ReadErr; }
            try
            {

                ReadData = new Byte[16];
                for (Int32 i = 0; i < ReadData.Length; i++)
                { ReadData[i] = FrameData[1 + i]; }
                return AllDone;
            }
            catch
            {
                return ReadErr;
            }
        }

        public Byte Write(Byte BlockAddr, Byte[] WriteData)
        {
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x86;
            Byte[] data = new Byte[1 + WriteData.Length];
            data[0] = BlockAddr;
            for (Int32 i = 0; i < WriteData.Length; i++)
            {
                data[1 + i] = WriteData[i];
            }
            //data[0] = AntiCollFlag;
            Byte value = SendAFrame(command, data);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return WriteErr; }
            if (DataLength == 0) { return WriteErr; }
            if (FrameData[0] != 0) { return WriteErr; }
            return AllDone;
            //try
            //{

            //        TagUID = new Byte[5];
            //        for (Int32 i = 0; i < TagUID.Length; i++)
            //        { TagUID[i] = FrameData[1 + i]; }
            //        return AllDone;
            //}
            //catch
            //{
            //        return InventoryErr;
            //}
        }

        public Byte Inventory(Byte InventoryFlag, out Byte[] TagUID)
        {
            TagUID = new Byte[0];
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x87;
            Byte[] data = new Byte[1];
            data[0] = InventoryFlag;
            Byte value = SendAFrame(command, data);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return InventoryErr; }
            if (DataLength == 0) { return InventoryErr; }
            if (FrameData[0] != 0) { return InventoryErr; }
            try
            {
                TagUID = new Byte[5];
                for (Int32 i = 0; i < TagUID.Length; i++)
                { TagUID[i] = FrameData[1 + i]; }
                return AllDone;
            }
            catch
            {
                return InventoryErr;
            }
        }

        //public event 
        public delegate void TagDetectedEventHandler(String TagUID, Byte StateCode);
        public event TagDetectedEventHandler TagDetected;
        private Thread threadAutoInventory;
        public Boolean IsAutoInventory = false;
        public void StartAutoInventory()
        {
            if (IsAutoInventory) return;
            if (threadAutoInventory != null)
            {
                if (threadAutoInventory.IsAlive)
                {
                    threadAutoInventory.Abort();
                    threadAutoInventory.Join(500);
                }
                threadAutoInventory = null;
            }
            Byte command = 0x88;
            Byte[] data = new Byte[1] { 0x00 };
            Byte value = SendAFrame(command, data);
            IsAutoInventory = true;
            threadAutoInventory = new Thread(new ThreadStart(threadForAutoInventory));
            threadAutoInventory.IsBackground = true;
            threadAutoInventory.Start();
        }

        public void EndAutoInventory()
        {
            if (!IsAutoInventory) return;
            Byte command = 0xFF;
            Byte[] data = new Byte[0];
            Byte value = SendAFrame(command, data);
            IsAutoInventory = false;
            Thread.Sleep(500);
            if (threadAutoInventory != null)
            {
                if (threadAutoInventory.IsAlive)
                {
                    threadAutoInventory.Abort();
                    threadAutoInventory.Join(500);
                }
                threadAutoInventory = null;
            }
        }

        private void threadForAutoInventory()
        {
            Byte value;
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[0];
            while (IsAutoInventory)
            {
                value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
                if (value == AllDone)
                {
                    if ((StateCode == 0x00) && (DataLength == 0x06))
                    { TagDetected(ByteArrayToString(FrameData, 1, 5), StateCode); }
                    else
                    { TagDetected("", FrameData[0]); }
                }
                else
                {
                    continue;
                }
            }

            HIDDevice.HidDevice_FlushBuffers(Device);
            //if (value != AllDone) { return value; }
            //if (StateCode != 0) { return InventoryErr; }
            //if (DataLength == 0) { return InventoryErr; }
            //if (FrameData[0] != 0) { return InventoryErr; }
        }



        ////////////////////////// 2011.12.11,添加type B功能
        /// <summary>
        /// TypeB寻卡
        /// </summary>
        /// <param name="RequestFlag">0x00表示请求所有，0x01表示请求未休眠</param>
        /// <param name="TagUID">返回的卡号</param>
        /// <returns></returns>
        public Byte B_Inventory(Byte RequestFlag, out Byte[] TagUID)
        {
            TagUID = new byte[0];
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x90;
            Byte[] data = new Byte[1];
            data[0] = RequestFlag;
            Byte value = SendAFrame(command, data);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return RequestErr; }
            if (DataLength == 0) { return RequestErr; }
            if (FrameData[0] != 0) { return RequestErr; }
            try
            {
                TagUID = new Byte[4];
                for (Int32 i = 0; i < TagUID.Length; i++)
                { TagUID[i] = FrameData[1 + i]; }
                return AllDone;
            }
            catch
            {
                return RequestErr;
            }
        }

        /// <summary>
        /// 选择
        /// </summary>
        /// <param name="TagUID">要选择的卡号</param>
        /// <returns></returns>
        public Byte B_Select(Byte[] TagUID)
        {
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x91;
            //Byte[] data = new Byte[1];
            //data[0] = AntiCollFlag;
            Byte value = SendAFrame(command, TagUID);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return SelectErr; }
            if (DataLength == 0) { return SelectErr; }
            if (FrameData[0] != 0) { return SelectErr; }
            return AllDone;
        }

        /// <summary>
        /// 休眠
        /// </summary>
        /// <param name="TagUID">要休眠的卡号</param>
        /// <returns></returns>
        public Byte B_Halt(Byte[] TagUID)
        {
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x92;
            //Byte[] data = new Byte[1];
            //data[0] = AntiCollFlag;
            Byte value = SendAFrame(command, TagUID);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return SelectErr; }
            if (DataLength == 0) { return SelectErr; }
            if (FrameData[0] != 0) { return SelectErr; }
            return AllDone;
        }

        /// <summary>
        /// 唤醒
        /// </summary>
        /// <param name="WakeUpFlag">保留，未使用，任意值</param>
        /// <param name="TagUID">返回的卡号</param>
        /// <returns></returns>
        public Byte B_WakeUp(Byte WakeUpFlag, out Byte[] TagUID)
        {
            TagUID = new byte[0];
            if (!IsOpen) { return SerialPortErr; }
            Byte command = 0x93;
            Byte[] data = new Byte[1];
            data[0] = WakeUpFlag;
            Byte value = SendAFrame(command, data);
            if (value != AllDone) { return value; }
            Byte ReturnFrameNum = 0;
            Byte StateCode = 0;
            Int32 DataLength = 0;
            Byte[] FrameData = new Byte[1];
            value = RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData);
            if (value != AllDone) { return value; }
            if (StateCode != 0) { return RequestErr; }
            if (DataLength == 0) { return RequestErr; }
            if (FrameData[0] != 0) { return RequestErr; }
            try
            {
                TagUID = new Byte[4];
                for (Int32 i = 0; i < TagUID.Length; i++)
                { TagUID[i] = FrameData[1 + i]; }
                return AllDone;
            }
            catch
            {
                return RequestErr;
            }
        }
        #endregion
    }
}
