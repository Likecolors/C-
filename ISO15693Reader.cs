using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HFReader
{
        class ISO15693Reader
        {
                #region PrivateProperty
                private SerialPort serialport;
                private Int32 Device = 0;
                private Byte CurrNum = 0x00;
                //private Boolean isRegistedEvent = false;   //用于AutoReceive
                //private Boolean isAutoRcv = false;             //用于AutoReceive
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
                //private Byte EventErr = 0x09;   //用于AutoReceive
                private Byte InventoryErr = 0x11;
                private Byte StayQuietErr = 0x12;
                private Byte SelectErr = 0x13;
                private Byte ResetToReadyErr = 0x14;
                private Byte WriteAFIErr = 0x15;
                private Byte LockAFIErr = 0x16;
                private Byte ReadSingleBlockErr = 0x17;
                private Byte WriteSingleBlockErr = 0x18;
                private Byte LockSingleBlockErr = 0x19;
                private Byte ReadMultiBlockErr = 0x1A;
                private Byte WriteMultiBlockErr = 0x1B;
                private Byte WriteDSFIDErr = 0x1C;
                private Byte LockDSFIDErr = 0x1D;
                private Byte GetSystemInfoErr = 0x1E;
                private Byte GetMultiBlockSecErr = 0x1F;
                private Byte GetAllTagsNumErr = 0x21;
                private Byte ReaderConfigErr = 0x22;
                private Byte TimingConfigErr = 0x23;
                private Byte ICodeConfigErr = 0x24;
                private Byte TagItConfigErr = 0x25;
                private Byte MultiplexConfigErr = 0x26;
                private Byte SwitchChannelErr = 0x27;
                private Byte GetParametersErr = 0x28;

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
                //public String PortName
                //{
                //        get
                //        {
                //                try { return serialport.PortName; }
                //                catch { return ""; }
                //        }
                //}
                //public Boolean IsAutoRcv
                //{
                //        get
                //        {
                //                return isAutoRcv;
                //        }
                //}                  //用于AutoReceive
                //public Int32 AutoRcvdTagCount            //用于AutoReceive
                //{
                //        get
                //        { return autoRcvdTagCount; }
                //}
                //public String[] AutoRcvdTagNum          //用于AutoReceive
                //{
                //        get
                //        { return autoRcvdTagNum; }
                //}
                //public delegate void DataReceived();

                #endregion

                //public event DataReceived OnDataArrive;  //用于AutoReceive

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
                        if (ConnectType<1) { return SerialPortErr; }
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
                        for (Int32 i = 0; i < frame.Length; i++)
                        {
                                strframe += String.Format("{0:X2}", frame[i]);
                        }
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
                        String strFrame="";
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
                                        int i = 5;
                                       do
                                       {
                                               result=ReadFromHIDDevice(out strdata);
                                               strFrame += strdata;
                                               i--;
                                       }
                                       while (strFrame.IndexOf("\r\n")<0&&i>1);
                                       if (strFrame.IndexOf("\r\n") >= 0)
                                           strFrame = strFrame.Substring(0, strFrame.IndexOf("\r\n"));
                                       else {
                                           MessageBox.Show("请插入USB3.0接口！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                       }
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
                {return HIDDevice.HidDevice_GetNumHidDevices(vid, pid);}

                public Byte OpenHIDDevice(Int32 DeviceIndex)
                {
                        Int32 DeviceNum = HIDDevice.HidDevice_GetNumHidDevices(vid, pid);
                        if (DeviceNum < 1)
                        { return 0x01; }
                        IntPtr pDevice = Marshal.AllocHGlobal(4);
                        Byte status = HIDDevice.HidDevice_Open(pDevice, DeviceIndex, vid, pid, HIDDevice.MAX_REPORT_REQUEST_XP);
                        Device = Marshal.ReadInt32(pDevice);
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

                public Byte Inventory(ModulateMethod mm, InventoryModel im, ref Int32 TagCount, ref String[] TagNumber)
                {
                        if (ConnectType < 1) { return SerialPortErr; }
                        Byte command = 0x01;
                        Byte[] data = new Byte[1];
                        data[0] = (Byte)((Byte)mm + (Byte)im);
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return InventoryErr; }
                        if (DataLength == 0) { return InventoryErr; }
                        if (FrameData[0] != 0) { return InventoryErr; }
                        try
                        {
                                TagCount = DataLength / 10;
                                TagNumber = new String[TagCount];
                                for (int i = 0; i < TagCount; i++)
                                {
                                        TagNumber[i] = "";
                                        for (int j = 0; j < 8; j++)
                                        {
                                                TagNumber[i] += FrameData[((i + 1) * 10) - j - 1].ToString("X2");
                                        }
                                }
                                return AllDone;
                        }
                        catch
                        {
                                return InventoryErr;
                        }
                }

                public Byte StayQuiet(String TagNum)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x02;
                        Byte[] data = new Byte[9];
                        data[0] = 0x23;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[1 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return StayQuietErr; }
                        if (DataLength != 1) { return StayQuietErr; }
                        if (FrameData[0] != 0) { return StayQuietErr; }
                        return AllDone;
                }

                public Byte Select(String TagNum)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x03;
                        Byte[] data = new Byte[9];
                        data[0] = 0x23;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[1 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return SelectErr; }
                        if (DataLength != 1) { return SelectErr; }
                        if (FrameData[0] != 0) { return SelectErr; }
                        return AllDone;
                }

                public Byte ResetToReady(ResetMode rm)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x04;
                        Byte[] data = new Byte[1];
                        data[0] = (Byte)rm;
                        if (data[0] > 0x13) { return ParameterErr; }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return ResetToReadyErr; }
                        if (DataLength != 1) { return ResetToReadyErr; }
                        if (FrameData[0] != 0) { return ResetToReadyErr; }
                        return AllDone;
                }

                public Byte ResetToReady(ResetMode rm, String TagNum)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x04;
                        Byte[] data = new Byte[9];
                        data[0] = (Byte)rm;
                        if (data[0] < 0x23) { return ResetToReady(rm); }
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[1 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return ResetToReadyErr; }
                        if (DataLength != 1) { return ResetToReadyErr; }
                        if (FrameData[0] != 0) { return ResetToReadyErr; }
                        return AllDone;
                }

                public Byte WriteAFI(String TagNum, Byte AFI)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x05;
                        Byte[] data = new Byte[10];
                        data[0] = 0x23;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[1 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        data[9] = AFI;
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return WriteAFIErr; }
                        if (DataLength != 1) { return WriteAFIErr; }
                        if (FrameData[0] != 0x41) { return WriteAFIErr; }
                        return AllDone;
                }

                public Byte LockAFI(String TagNum)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x06;
                        Byte[] data = new Byte[9];
                        data[0] = 0x23;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[1 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return LockAFIErr; }
                        if (DataLength != 1) { return LockAFIErr; }
                        if (FrameData[0] != 0x23) { return LockAFIErr; }
                        return AllDone;
                }

                public Byte ReadSingleBlock(String TagNum, BlockLength bl, Byte BlockAddrss, ref Byte[] BlockData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x07;
                        Byte[] data = new Byte[11];
                        data[0] = (Byte)bl;
                        data[1] = 0x23;
                        data[2] = BlockAddrss;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[3 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return ReadSingleBlockErr; }
                        if (DataLength != ((Byte)bl + 1)) { return ReadSingleBlockErr; }
                        if (FrameData[0] != 0) { return ReadSingleBlockErr; }
                        BlockData = new Byte[(Byte)bl];
                        for (int i = 0; i < BlockData.Length; i++)
                        {
                                BlockData[i] = FrameData[1 + i];
                        }
                        return AllDone;
                }

                public Byte WriteSingleBlock(String TagNum, BlockLength bl, Byte BlockAddrss, Byte[] BlockData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x08;
                        Byte[] data = new Byte[11 + (Byte)bl];
                        data[0] = (Byte)bl;
                        data[1] = 0x23;
                        data[2] = BlockAddrss;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < ((Byte)bl); i++)
                                {
                                        data[3 + i] = BlockData[i];
                                }
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[3 + (Byte)bl + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if ((value == AllDone) && (FrameData[0] == 0x00)) { return AllDone; }
                        //if (StateCode != 0) { return WriteSingleBlockErr; }
                        //if (DataLength != 1) { return WriteSingleBlockErr; }
                        //if (FrameData[0] != 0x41) { return WriteSingleBlockErr; }
                        Byte[] rvsData = new Byte[0];
                        value = ReadSingleBlock(TagNum, bl, BlockAddrss, ref rvsData);
                        if ((value == 0x00) && (ByteArrayToString(BlockData).Equals(ByteArrayToString(rvsData))))
                        { return AllDone; }
                        else
                        { return WriteSingleBlockErr; }
                }

                public Byte LockSingleBlock(String TagNum, Byte BlockAddress)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x09;
                        Byte[] data = new Byte[10];
                        data[0] = 0x23;
                        data[1] = BlockAddress;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[2 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return LockSingleBlockErr; }
                        if (DataLength != 1) { return LockSingleBlockErr; }
                        if (FrameData[0] != 0x41) { return LockSingleBlockErr; }
                        return AllDone;
                }

                public Byte ReadMultiBlock(String TagNum, BlockLength bl, Byte BlockAddrss, Byte BlockCount, ref Byte[] BlockData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x0A;
                        Byte[] data = new Byte[12];
                        data[0] = (Byte)bl;
                        data[1] = 0x23;
                        data[2] = BlockAddrss;
                        data[3] = (BlockCount > 0) ? (Byte)(BlockCount - 1) : (BlockCount);
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[4 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return ReadMultiBlockErr; }
                        if (DataLength != (((Byte)bl * BlockCount) + 1)) { return ReadMultiBlockErr; }
                        if (FrameData[0] != 0) { return ReadMultiBlockErr; }
                        BlockData = new Byte[(Byte)bl * BlockCount];
                        for (int i = 0; i < BlockData.Length; i++)
                        {
                                BlockData[i] = FrameData[1 + i];
                        }
                        return AllDone;
                }

                public Byte WriteMultiBlock(String TagNum, BlockLength bl, Byte BlockAddrss, Byte BlockCount, Byte[] BlockData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x0B;
                        Int32 DataLength = (Byte)bl * BlockCount;
                        Byte[] data = new Byte[12 + DataLength];
                        data[0] = (Byte)bl;
                        data[1] = 0x23;
                        data[2] = BlockAddrss;
                        data[3] = (BlockCount > 0) ? (Byte)(BlockCount - 1) : (BlockCount);
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < DataLength; i++)
                                {
                                        data[4 + i] = BlockData[i];
                                }
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[4 + DataLength + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return WriteMultiBlockErr; }
                        if (DataLength != 1) { return WriteMultiBlockErr; }
                        if (FrameData[0] != 0) { return WriteMultiBlockErr; }//尚未确定在写入成功以后是不是返回0x00标识。
                        return AllDone;
                }

                public Byte WriteDSFID(String TagNum, Byte DSFID)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x0C;
                        Byte[] data = new Byte[10];
                        data[0] = 0x23;
                        data[1] = DSFID;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[2 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return WriteDSFIDErr; }
                        if (DataLength != 1) { return WriteDSFIDErr; }
                        if (FrameData[0] != 0x41) { return WriteDSFIDErr; }
                        return AllDone;
                }

                public Byte LockDSFID(String TagNum)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x0D;
                        Byte[] data = new Byte[9];
                        data[0] = 0x23;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[1 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return LockAFIErr; }
                        if (DataLength != 1) { return LockAFIErr; }
                        if (FrameData[0] != 0x41) { return LockAFIErr; }
                        return AllDone;
                }

                public Byte GetSystemInfo(String TagNum, ref Byte InfoFlag, ref Byte DSFID, ref Byte AFI, ref UInt16 VICCMemorySize, ref Byte ICReference)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x0E;
                        Byte[] data = new Byte[9];
                        data[0] = 0x23;
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[1 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return GetSystemInfoErr; }
                        if (DataLength != 0x0F) { return GetSystemInfoErr; }
                        if (FrameData[0] != 0x00) { return GetSystemInfoErr; }
                        InfoFlag = FrameData[1];
                        DSFID = FrameData[10];
                        AFI = FrameData[11];
                        VICCMemorySize = (UInt16)(FrameData[12] + FrameData[13] * 256);//返回0x1B03,也不知道是高字节在前还是在后，目前是按高字节在后设计的
                        ICReference = FrameData[14];
                        return AllDone;
                }

                public Byte GetMultiBlockSec(String TagNum, Byte BlockAddrss, Byte BlockCount, ref Byte[] SecStatus)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte command = 0x0F;
                        Byte[] data = new Byte[11];
                        data[0] = 0x23;
                        data[1] = BlockAddrss;
                        data[2] = (BlockCount > 0) ? (Byte)(BlockCount - 1) : (BlockCount);
                        TagNum = TagNum.Trim();
                        try
                        {
                                for (Byte i = 0; i < 8; i++)
                                {
                                        data[3 + i] = Convert.ToByte(TagNum.Substring((7 - i) * 2, 2), 16);
                                }
                        }
                        catch
                        {
                                return ParameterErr;
                        }
                        Byte value = SendAFrame(command, data);
                        if (value != AllDone) { return value; }
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return GetMultiBlockSecErr; }
                        if (DataLength != (BlockCount + 1)) { return GetMultiBlockSecErr; }
                        if (FrameData[0] != 0) { return GetMultiBlockSecErr; }
                        SecStatus = new Byte[BlockCount];
                        for (int i = 0; i < SecStatus.Length; i++)
                        {
                                SecStatus[i] = FrameData[1 + i];
                        }
                        return AllDone;
                }

                public Byte GetAllTagsNum(out Int32 TagCount, out String[] TagNumber)
                {
                        TagCount = 0x00;
                        TagNumber = new String[0];
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte value = SendAFrame(0xF1, new Byte[1] { 0x02 });
                        if (value != AllDone) { return value; }
                        Thread.Sleep(100);
                        ArrayList ar = new ArrayList();
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        //while (serialport.BytesToRead > 0)
                        //{
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return GetAllTagsNumErr; }
                        if (DataLength == 0) { return GetAllTagsNumErr; }
                        if (FrameData[0] != 0) { return GetAllTagsNumErr; }
                        try
                        {
                                TagCount = DataLength / 10;
                                //TagNumber = new String[TagCount];
                                for (int i = 0; i < TagCount; i++)
                                {
                                        String tagnumber = "";
                                        for (int j = 0; j < 8; j++)
                                        {
                                                tagnumber += FrameData[((i + 1) * 10) - j - 1].ToString("X2");
                                        }
                                        if (ar.IndexOf((Object)tagnumber) < 0)
                                                ar.Add(tagnumber);
                                }
                        }
                        catch (Exception ex)
                        {
                                return GetAllTagsNumErr;
                        }
                        //}
                        TagCount = ar.Count;
                        TagNumber = new String[TagCount];
                        for (Int32 i = 0; i < TagCount; i++)
                        {
                                TagNumber[i] = (String)ar[i];
                        }
                        return AllDone;
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //2011年2月18日,增加
                public Byte ReaderConfig(Byte[] ConfigData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte value = SendAFrame(0x9A, ConfigData);
                        if (value != AllDone) { return value; }
                        Thread.Sleep(100);
                        ArrayList ar = new ArrayList();
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return ReaderConfigErr; }
                        if (DataLength == 0) { return ReaderConfigErr; }
                        if (FrameData[0] != 0) { return ReaderConfigErr; }
                        return AllDone;
                }

                public Byte TimingConfig(Byte[] ConfigData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte value = SendAFrame(0x42, ConfigData);
                        if (value != AllDone) { return value; }
                        Thread.Sleep(100);
                        ArrayList ar = new ArrayList();
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return TimingConfigErr; }
                        if (DataLength == 0) { return TimingConfigErr; }
                        if (FrameData[0] != 0) { return TimingConfigErr; }
                        return AllDone;
                }

                public Byte ICodeConfig(Byte[] ConfigData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte value = SendAFrame(0x87, ConfigData);
                        if (value != AllDone) { return value; }
                        Thread.Sleep(100);
                        ArrayList ar = new ArrayList();
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return ICodeConfigErr; }
                        if (DataLength == 0) { return ICodeConfigErr; }
                        if (FrameData[0] != 0) { return ICodeConfigErr; }
                        return AllDone;
                }

                public Byte TagItConfig(Byte[] ConfigData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte value = SendAFrame(0x77, ConfigData);
                        if (value != AllDone) { return value; }
                        Thread.Sleep(100);
                        ArrayList ar = new ArrayList();
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return TagItConfigErr; }
                        if (DataLength == 0) { return TagItConfigErr; }
                        if (FrameData[0] != 0) { return TagItConfigErr; }
                        return AllDone;
                }

                public Byte MultiplexConfig(Byte[] ConfigData)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte value = SendAFrame(0x41, ConfigData);
                        if (value != AllDone) { return value; }
                        Thread.Sleep(100);
                        ArrayList ar = new ArrayList();
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return MultiplexConfigErr; }
                        if (DataLength == 0) { return MultiplexConfigErr; }
                        if (FrameData[0] != 0) { return MultiplexConfigErr; }
                        return AllDone;
                }

                public Byte SwitchChannel(Byte Channel)
                {
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte[] ConfigData = new Byte[] { Channel, 0x00, 0x00 };
                        Byte value = SendAFrame(0x40, ConfigData);
                        if (value != AllDone) { return value; }
                        Thread.Sleep(100);
                        ArrayList ar = new ArrayList();
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return SwitchChannelErr; }
                        if (DataLength == 0) { return SwitchChannelErr; }
                        if (FrameData[0] != 0) { return SwitchChannelErr; }
                        return AllDone;
                }

                public Byte GetParameters(out Byte[] Parameters)
                {
                        Parameters = new Byte[0];
                        if (ConnectType<1) { return SerialPortErr; }
                        Byte[] ConfigData = new Byte[0];
                        Byte value = SendAFrame(0x9B, ConfigData);
                        if (value != AllDone) { return value; }
                        Thread.Sleep(100);
                        ArrayList ar = new ArrayList();
                        Byte ReturnFrameNum = 0;
                        Byte StateCode = 0;
                        Int32 DataLength = 0;
                        Byte[] FrameData = new Byte[1];
                        value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                        if (value != AllDone) { return value; }
                        if (StateCode != 0) { return GetParametersErr; }
                        if (DataLength == 0) { return GetParametersErr; }
                        if (FrameData[0] != 0) { return GetParametersErr; }
                        Parameters = new Byte[FrameData.Length - 1];
                        for (Int32 i = 0; i < Parameters.Length; i++)
                        { Parameters[i] = FrameData[1 + i]; }
                        return AllDone;
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                public Byte EnableBuzzer(Boolean flag)
                {
                        if (ConnectType!=1) { return SerialPortErr; }
                        lock (serialport)
                        {
                                Byte data = (Byte)(flag ? 0x01 : 0x00);
                                Byte value = SendAFrame(0xF0, new Byte[1] { data });
                                if (value != AllDone) { return value; }
                                Thread.Sleep(50);
                                return AllDone;
                        }
                }

                //public Byte BeginAutoReceive()
                //{
                //        if (ConnectType<1) { return SerialPortErr; }
                //        if (!isRegistedEvent)
                //        {
                //                serialport.DataReceived += new SerialDataReceivedEventHandler(DataHandle);
                //                isRegistedEvent = true;
                //        }
                //        try
                //        {
                //                serialport.DiscardInBuffer();
                //                isAutoRcv = true;
                //                return AllDone;
                //        }
                //        catch
                //        { return EventErr; }
                //}   //用于AutoReceive

                //public Byte EndAutoReceive()        //用于AutoReceive
                //{
                //        if (ConnectType<1) { return SerialPortErr; }
                //        isAutoRcv = false;
                //        return AllDone;
                //}

                //private void DataHandle(Object sender, SerialDataReceivedEventArgs e)  //用于AutoReceive
                //{
                //        if (isAutoRcv)
                //        {
                //                ArrayList ar = new ArrayList();

                //                Byte ReturnFrameNum = 0;
                //                Byte StateCode = 0;
                //                Int32 DataLength = 0;
                //                Byte[] FrameData = new Byte[1];
                //                while (serialport.BytesToRead > 0)
                //                {
                //                        Byte value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
                //                        if (value != AllDone) { break; }
                //                        if (StateCode != 0) { break; }
                //                        if (DataLength == 0) { break; }
                //                        if (FrameData[0] != 0) { break; }
                //                        try
                //                        {
                //                                autoRcvdTagCount = DataLength / 10;
                //                                //TagNumber = new String[TagCount];
                //                                for (int i = 0; i < autoRcvdTagCount; i++)
                //                                {
                //                                        String tagnumber = "";
                //                                        for (int j = 0; j < 8; j++)
                //                                        {
                //                                                tagnumber += FrameData[((i + 1) * 10) - j - 1].ToString("X2");
                //                                        }
                //                                        if (ar.IndexOf((Object)tagnumber) < 0)
                //                                                ar.Add(tagnumber);
                //                                }
                //                        }
                //                        catch
                //                        {
                //                                break;
                //                        }
                //                }
                //                autoRcvdTagCount = ar.Count;
                //                autoRcvdTagNum = new String[autoRcvdTagCount];
                //                for (Int32 i = 0; i < autoRcvdTagCount; i++)
                //                {
                //                        autoRcvdTagNum[i] = (String)ar[i];
                //                }
                //                OnDataArrive();
                //        }
                //}

                #endregion
        }

        public enum ModulateMethod { ASK = 0x06, FSK = 0x07 }
        public enum InventoryModel { Single = 0x20, Multiple = 0x00 }
        public enum ResetMode { RstAllQuiet = 0x03, RstAllSelected = 0x13, RstSpecificQuiet = 0x23, RstSpecificSelected = 0x33 }
        public enum BlockLength { ShortBlock4Byte = 0x04, LongBlock8Byte = 0x08 }

        //public class StandAloneReader
        //{
        //    public event DataReceived OnDataArrive;
        //    private Boolean IsRegistedEvent = false;
        //    private Boolean IsReceive = false;

        //    private SerialPort serialport;
        //    private Byte CurrNum = 0x00;
        //    private Byte AllDone = 0x00;
        //    private Byte SerialPortErr = 0x01;
        //    private Byte SendTimeOut = 0x02;
        //    private Byte RcvTimeOut = 0x03;
        //    private Byte FrameFormatErr = 0x04;
        //    private Byte CRCERR = 0x05;
        //    private Byte DataLengthERR = 0x06;
        //    private Byte ReturnFrameNumErr = 0x07;
        //    private Byte ParameterErr = 0x08;
        //    private Byte EventErr = 0x09;
        //    private Byte InventoryErr = 0x11;

        //    //private Byte SeiralPortIsNullErr = 0x02;
        //    #region PublicProperty
        //    public Boolean IsOpen
        //    {
        //        get
        //        {
        //            try { return serialport.IsOpen; }
        //            catch { return false; }
        //        }
        //    }
        //    public String PortName
        //    {
        //        get
        //        {
        //            try { return serialport.PortName; }
        //            catch { return ""; }
        //        }
        //    }
        //    public String[] TagNumber;
        //    public Int32 TagCount;
        //    #endregion
        //    #region PrivateMethod

        //    private Byte SendAFrame(Byte Command, Byte[] data)
        //    {
        //        if (ConnectType<1) { return SerialPortErr; }
        //        Byte[] frame = new Byte[data.Length + 6];
        //        frame[0] = CurrNum;
        //        frame[1] = Command;
        //        frame[2] = (Byte)(data.Length * 2 % 256);
        //        frame[3] = (Byte)(data.Length * 2 / 256);
        //        for (Int32 i = 0; i < data.Length; i++)
        //        {
        //            frame[4 + i] += data[i];
        //        }
        //        CalculateCRC(ref frame, 0, data.Length + 4);
        //        String strframe = ":";
        //        for (Int32 i = 0; i < frame.Length; i++)
        //        {
        //            strframe += String.Format("{0:X2}", frame[i]);
        //        }
        //        CurrNum++;
        //        try
        //        {
        //            serialport.WriteLine(strframe);
        //            return AllDone;
        //        }
        //        catch
        //        {
        //            return SendTimeOut;
        //        }
        //    }

        //    private Byte RcvAFrame(ref Byte ReturnFrameNum, ref Byte StateCode, ref Int32 DataLength, ref Byte[] FrameData)
        //    {
        //        if (ConnectType<1) { return SerialPortErr; }
        //        String strFrame;
        //        try
        //        {
        //            strFrame = serialport.ReadLine();
        //        }
        //        catch
        //        {
        //            return RcvTimeOut;
        //        }
        //        if (strFrame.IndexOf(":") != 0)
        //        {
        //            return FrameFormatErr; //需要改进改进
        //            //return RcvAFrame(ref StateCode, ref FrameData, ref DataLength);
        //        }
        //        strFrame = strFrame.Remove(0, 1);
        //        Byte[] Frame = new Byte[strFrame.Length / 2];
        //        for (int i = 0; i < Frame.Length; i++)
        //        { Frame[i] = Convert.ToByte(strFrame.Substring(i * 2, 2), 16); }
        //        if (CheckCRC(Frame))
        //        {
        //            ReturnFrameNum = Frame[0];
        //            if (ReturnFrameNum >= CurrNum) { return ReturnFrameNum; }
        //            if (ReturnFrameNum < (CurrNum - 1)) { return RcvAFrame(ref ReturnFrameNum, ref StateCode, ref DataLength, ref FrameData); }
        //            StateCode = Frame[1];
        //            DataLength = Frame[3] * 256 + Frame[2];
        //            if (DataLength != (Frame.Length - 6))
        //            { return DataLengthERR; }
        //            if (DataLength > 0)
        //            {
        //                FrameData = new Byte[DataLength];
        //                for (Int32 i = 0; i < DataLength; i++)
        //                {
        //                    FrameData[i] = Frame[4 + i];
        //                }
        //            }
        //            return AllDone;
        //        }
        //        else
        //        { return CRCERR; }
        //    }

        //    private void CalculateCRC(ref Byte[] frame, Int32 offset, Int32 datalength)
        //    {
        //        UInt16 crc16_preset = 0xFFFF;
        //        UInt16 RFCRC16_POLYNOM = 0x8408;
        //        UInt16 CRC16, m;
        //        Byte n;
        //        CRC16 = crc16_preset;
        //        for (m = 0; m < datalength; m++)
        //        {
        //            CRC16 ^= (UInt16)(frame[offset + m] & 0xff);
        //            //pointer++;

        //            for (n = 0; n < 8; n++)
        //            {
        //                if ((CRC16 & 0x0001) > 0)
        //                    CRC16 = (UInt16)((CRC16 >> 1) ^ RFCRC16_POLYNOM);
        //                else
        //                    CRC16 = (UInt16)(CRC16 >> 1);
        //            }
        //        }
        //        frame[offset + datalength] = (Byte)(CRC16 % 256);
        //        frame[offset + datalength + 1] = (Byte)(CRC16 / 256);
        //    }

        //    private Boolean CheckCRC(Byte[] frame)
        //    {
        //        Int32 length = frame.Length;
        //        Byte LowByte, UperByte;
        //        UperByte = frame[length - 1];
        //        LowByte = frame[length - 2];
        //        CalculateCRC(ref frame, 0, length - 2);
        //        if ((UperByte == frame[length - 1]) && (LowByte == frame[length - 2]))
        //        { return true; }
        //        else
        //        { return false; }
        //    }

        //    #endregion
        //    #region PublicMethod
        //    /// <summary>
        //    /// 打开串口,参数portName为串口号,如"COM1",参数BaudRate为波特率，默认的模特率为115200;
        //    /// 其它串口参数采用默认设置:数据位8;停止位1;奇偶校验无.
        //    /// </summary>
        //    public Byte OpenSerialPort(String portName, Int32 BaudRate)
        //    {
        //        return mOpenSerialPort(portName, BaudRate, 8, StopBits.One, Parity.None);
        //    }
        //    public Byte OpenSerialPort(String portName)
        //    {
        //        return mOpenSerialPort(portName, 115200, 8, StopBits.One, Parity.None);
        //    }
        //    private Byte mOpenSerialPort(String portName, Int32 BaudRate, Int32 DataBits, StopBits StopBits, Parity Parity)
        //    {
        //        try
        //        {
        //            serialport = new SerialPort(portName);
        //            serialport.BaudRate = BaudRate;
        //            serialport.DataBits = DataBits;
        //            serialport.StopBits = StopBits;
        //            serialport.Parity = Parity;
        //            serialport.NewLine = "\r\n";
        //            serialport.ReadTimeout = 2000;
        //            serialport.Open();
        //            if (serialport.IsOpen) return AllDone;  //打开成功
        //            return SerialPortErr;  //打开失败
        //        }
        //        catch
        //        {
        //            return SerialPortErr; //打开失败
        //        }
        //    }

        //    public Byte CloseSerialPort()
        //    {
        //        try
        //        {
        //            serialport.Close();
        //            if (!serialport.IsOpen)
        //            {
        //                serialport = null;
        //                return AllDone;
        //            }
        //            else
        //            {
        //                return SerialPortErr;
        //            }
        //        }
        //        catch { return SerialPortErr; }
        //    }

        //    public Byte Inventory(ModulateMethod mm, InventoryModel im)
        //    {
        //        if (ConnectType<1) { return SerialPortErr; }
        //        Byte command = 0x01;
        //        Byte[] data = new Byte[1];
        //        data[0] = (Byte)((Byte)mm + (Byte)im);
        //        Byte value = SendAFrame(command, data);
        //        if (value != AllDone) { return value; }
        //        return AllDone;
        //        //Byte ReturnFrameNum = 0;
        //        //Byte StateCode = 0;
        //        //Int32 DataLength = 0;
        //        //Byte[] FrameData = new Byte[1];
        //        //value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
        //        //if (value != AllDone) { return value; }
        //        //if (StateCode != 0) { return InventoryErr; }
        //        //if (DataLength == 0) { return InventoryErr; }
        //        //if (FrameData[0] != 0) { return InventoryErr; }
        //        //try
        //        //{
        //        //    TagCount = DataLength / 10;
        //        //    TagNumber = new String[TagCount];
        //        //    for (int i = 0; i < TagCount; i++)
        //        //    {
        //        //        TagNumber[i] = "";
        //        //        for (int j = 0; j < 8; j++)
        //        //        {
        //        //            TagNumber[i] += FrameData[((i + 1) * 10) - j - 1].ToString("X2");
        //        //        }
        //        //    }
        //        //    return AllDone;
        //        //}
        //        //catch
        //        //{
        //        //    return InventoryErr;
        //        //}
        //    }

        //    public Byte BeginRcv()
        //    {
        //        if (ConnectType<1) { return SerialPortErr; }
        //        if (!IsRegistedEvent)
        //        {
        //            serialport.DataReceived += new SerialDataReceivedEventHandler(DataHandle);
        //            IsRegistedEvent = true;
        //        }
        //        try
        //        {
        //            serialport.DiscardInBuffer();
        //            IsReceive = true;
        //            return AllDone;
        //        }
        //        catch
        //        { return EventErr; }
        //    }

        //    public Byte EndRcv()
        //    {
        //        if (ConnectType<1) { return SerialPortErr; }
        //        IsReceive = false;
        //        return AllDone;
        //    }
        //    private void DataHandle(Object sender, SerialDataReceivedEventArgs e)
        //    {
        //        if (IsReceive)
        //        {
        //            ArrayList ar = new ArrayList();

        //            Byte ReturnFrameNum = 0;
        //            Byte StateCode = 0;
        //            Int32 DataLength = 0;
        //            Byte[] FrameData = new Byte[1];
        //            while (serialport.BytesToRead > 0)
        //            {
        //                Byte value = RcvAFrame(ref ReturnFrameNum, ref  StateCode, ref DataLength, ref FrameData);
        //                if (value != AllDone) { break; }
        //                if (StateCode != 0) { break; }
        //                if (DataLength == 0) { break; }
        //                if (FrameData[0] != 0) { break; }
        //                try
        //                {
        //                    TagCount = DataLength / 10;
        //                    //TagNumber = new String[TagCount];
        //                    for (int i = 0; i < TagCount; i++)
        //                    {
        //                        String tagnumber = "";
        //                        for (int j = 0; j < 8; j++)
        //                        {
        //                            tagnumber += FrameData[((i + 1) * 10) - j - 1].ToString("X2");
        //                        }
        //                        if (ar.IndexOf((Object)tagnumber) < 0)
        //                            ar.Add(tagnumber);
        //                    }
        //                }
        //                catch
        //                {
        //                    break;
        //                }
        //            }
        //            TagCount = ar.Count;
        //            TagNumber = new String[TagCount];
        //            for (Int32 i = 0; i < TagCount; i++)
        //            {
        //                TagNumber[i] = (String)ar[i];
        //            }
        //            OnDataArrive();
        //        }
        //    }
        //    #endregion

        //}
}


