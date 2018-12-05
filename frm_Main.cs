using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.IO;
using DotNetSpeech;

namespace HFReader
{
        public partial class frm_Main : Form
        {
                public frm_Main()
                {
                        InitializeComponent();
                }

                //#region PrivateValues
                private ISO14443Reader iso14443Reader;
                private ISO15693Reader reader;
                private delegate void AddListCallback(String str);
                //private delegate void AddRowCallback(String framestr);
                private delegate void AddTagCallback();
                private delegate void AddResultCallback(String str);
                private List<String> CurrentTagNumbers;
                private Point theLocation = new Point(295, 6);
                private Point theLocation_1 = new Point(157, 6);
                //private SerialPort serialport;
                //private Boolean IsOpen = false;
                //private Thread threadRCV;
                private Thread threadAuto;
                private Thread threadMonitor;
                //private Byte CurrFrameNum = 0;
                //private Byte CurrCMD = 0x00;
                private String[] CurrUID = new String[0];
                private Boolean IsMonitor = false;
                private Boolean IsAutoRun = false;
                private Boolean IsRegistedEvent = false;
                private Boolean IsFastInventory = false;
                //#endregion
                SpeechVoiceSpeakFlags spFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
                SpVoice voice = new SpVoice();


                public void RefreshCom()
                {
                        List<String> ComList;
                        cmb_PortName.Items.Clear();
                        cmb_PortNum.Items.Clear();
                        cmb_PortName_Demo.Items.Clear();
                        cmb_PortNum_14443.Items.Clear();
                        cmb_PortNum_14443B.Items.Clear();
                        if (GetComList(out ComList) > 0)
                        {
                                foreach (String com in ComList)
                                {
                                        cmb_PortName.Items.Add(com);
                                        cmb_PortNum.Items.Add(com);
                                        cmb_PortName_Demo.Items.Add(com);
                                        cmb_PortNum_14443.Items.Add(com);
                                        cmb_PortNum_14443B.Items.Add(com);
                                }
                                cmb_PortName.SelectedIndex = 0;
                                cmb_PortNum.SelectedIndex = 0;
                                cmb_PortName_Demo.SelectedIndex = 0;
                                cmb_PortNum_14443.SelectedIndex = 0;
                                cmb_PortNum_14443B.SelectedIndex = 0;
                        }
                }

                public Int32 GetComList(out List<String> ComList)
                {
                        RegistryKey keyCom = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
                        if (keyCom != null)
                        {
                                string[] sSubKeys = keyCom.GetValueNames();
                                ComList = new List<string>();
                                foreach (string sName in sSubKeys)
                                {
                                        ComList.Add((string)keyCom.GetValue(sName));
                                }
                                return ComList.Count;
                        }
                        else
                        {
                                ComList = null;
                                return 0;
                        }
                }

                private void AddSysInfo(String str)
                {
                        if (txt_UID.InvokeRequired)
                        {
                                AddResultCallback d = new AddResultCallback(AddSysInfo);
                                this.Invoke(d, str);
                        }
                        else
                        {
                                txt_DSFID_2.Text = str.Substring(18, 2);
                                txt_AFI_2.Text = str.Substring(20, 2);
                                txt_UID.Text = cmb_UID_13.Text.Trim();
                                txt_VICC.Text = str.Substring(22, 4);
                                txt_ICRef.Text = str.Substring(26, 2);
                                txt_Info.Text = str.Substring(0, 2);
                        }
                }

                private void AddTag()
                {
                        if (lst_Info.InvokeRequired)
                        {
                                AddTagCallback d = new AddTagCallback(AddTag);
                                this.Invoke(d);
                        }
                        else
                        {
                                lst_InventoryResult.Items.Clear();
                                lst_InventoryResult.Items.AddRange(CurrUID);
                        }
                }

                private void AddResult1(String str)
                {
                        if (txt_Result_1.InvokeRequired)
                        {
                                AddListCallback d = new AddListCallback(AddResult1);
                                this.Invoke(d, str);
                        }
                        else
                        {
                                txt_Result_1.Text = "Result:" + str;
                        }
                }

                private void AddResult2(String str)
                {
                        if (lst_Result.InvokeRequired)
                        {
                                AddResultCallback d = new AddResultCallback(AddResult2);
                                this.Invoke(d, str);
                        }
                        else
                        {
                                Int32 blockcount = str.Length / 8;
                                for (Int32 i = 0; i < blockcount; i++)
                                {
                                        String split = ((i % 2) == 0) ? " " : "|";
                                        str = str.Insert(8 + 9 * i, split);
                                }
                                String[] substr = str.Split('|');
                                lst_Result.Items.Clear();
                                lst_Result.Items.Add("Result:");
                                lst_Result.Items.AddRange(substr);
                        }
                }

                private void AddResult3(String str)
                {
                        if (lst_Result2.InvokeRequired)
                        {
                                AddResultCallback d = new AddResultCallback(AddResult3);
                                this.Invoke(d, str);
                        }
                        else
                        {
                                Int32 blockcount = str.Length / 8;
                                for (Int32 i = 0; i < blockcount; i++)
                                {
                                        String split = ((i % 2) == 0) ? " " : "|";
                                        str = str.Insert(8 + 9 * i, split);
                                }
                                String[] substr = str.Split('|');
                                lst_Result2.Items.Clear();
                                lst_Result2.Items.Add("Result:");
                                lst_Result2.Items.AddRange(substr);
                        }
                }

                private void AddList(String str)
                {
                        if (lst_Info.InvokeRequired)
                        {
                                AddListCallback d = new AddListCallback(AddList);
                                this.Invoke(d, str);
                        }
                        else
                        {
                                lst_Info.Items.Add(str);
                                lst_Info.SelectedIndex = lst_Info.Items.Count - 1;
                                lst_Info.ClearSelected();
                        }
                }

                private void AddInfo(String str)
                {
                        if (lst_Info_Cfg.InvokeRequired)
                        {
                                AddListCallback d = new AddListCallback(AddInfo);
                                lst_Info_Cfg.Invoke(d, str);
                        }
                        else
                        {
                                lst_Info_Cfg.Items.Insert(0, String.Format("{0}:{1}", DateTime.Now.ToString(), str));
                        }
                }

                private void ShowInfo14443(String str)
                {
                        if (lsb_Info_14443 .InvokeRequired)
                        {
                                AddListCallback d = new AddListCallback(ShowInfo14443);
                                lsb_Info_14443.Invoke(d, str);
                        }
                        else
                        {
                                lsb_Info_14443.Items.Insert(0, String.Format("{0}:{1}", DateTime.Now.ToString(), str));
                        }

                }

                private void ShowInfo14443B(String str)
                {
                        if (lsb_Info_14443_B.InvokeRequired)
                        {
                                AddListCallback d = new AddListCallback(ShowInfo14443B);
                                lsb_Info_14443_B.Invoke(d, str);
                        }
                        else
                        {
                                lsb_Info_14443_B.Items.Insert(0, String.Format("{0}:{1}", DateTime.Now.ToString(), str));
                        }

                }

            private void ShowCount14443(String str)
            {
                if (txt_Count_14443.InvokeRequired)
                {
                    AddListCallback d = new AddListCallback(ShowCount14443);
                   txt_Count_14443.Invoke(d, str);
                }
                else
                {
                    txt_Count_14443.Text = str;
                }

            }

                private void AddInfoDemo(String str)
                {

                        if (lst_Info_Demo.InvokeRequired)
                        {
                                AddListCallback d = new AddListCallback(AddInfoDemo);
                                lst_Info_Demo.Invoke(d, str);
                        }
                        else
                        {
                                lst_Info_Demo.Items.Insert(0, String.Format("{0}:{1}", DateTime.Now.ToString(), str));
                        }
                }
                //private void AddRow(String framestr)
                //{
                //    if (dataGridView1.InvokeRequired)
                //    {
                //        AddRowCallback d = new AddRowCallback(AddRow);
                //        this.Invoke(d, framestr);
                //    }
                //    else
                //    {
                //        //AddList(framestr);
                //        String[] str = new String[7];
                //        System.DateTime dt = System.DateTime.Now;
                //        str[0] = framestr.Substring(0, 1);
                //        if (str[0] == ":") str[0] = "S";
                //        str[1] = String.Format("{0:D2}:{1:D2}:{2:D2}:{3:D3}", dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
                //        str[2] = framestr.Substring(1, 2);
                //        str[3] = framestr.Substring(3, 2);
                //        str[4] = framestr.Substring(5, 4);
                //        Byte LByte = Convert.ToByte(str[4].Substring(0, 2), 16);
                //        Byte HByte = Convert.ToByte(str[4].Substring(2, 2), 16);
                //        Int32 datalength = HByte * 256 + LByte;
                //        if (str[0] == "R") datalength*=2;
                //        str[5] = framestr.Substring(9, datalength);
                //        str[6] = framestr.Substring(datalength + 9, 4);
                //        dataGridView1.Rows.Insert(0, str[0], str[1], "3A",str[2], str[3], str[4], str[5], str[6],"0D0A");
                //    }
                //}

                private void HideAll()
                {
                        gb_OpenCloseComm.Visible = false;
                        gb_OpenCloseHID.Visible = false;
                        gb_Inventory.Visible = false;
                        gb_ReadSingleBlock.Visible = false;
                        gb_WriteSingleBlock.Visible = false;
                        gb_ReadMultiBlock.Visible = false;
                        gb_WriteMultiBlock.Visible = false;
                        gb_LockBlock.Visible = false;
                        gb_StayQuiet.Visible = false;
                        gb_Select.Visible = false;
                        gb_ResetToReady.Visible = false;
                        gb_WriteAFI.Visible = false;
                        gb_LockAFI.Visible = false;
                        gb_WriteDSFID.Visible = false;
                        gb_LockDSFID.Visible = false;
                        gb_GetSystemInfo.Visible = false;
                        gb_GetMulti.Visible = false;
                        gb_EnableBuzzer.Visible = false;
                        gb_GetAll.Visible = false;
                        gb_AutoRcv.Visible = false;
                }

                private void HideAll_1()
                {
                        gb_ReaderConfig.Visible = false;
                        gb_TimingConfig.Visible = false;
                        gb_TagItConfig.Visible = false;
                        gb_ICodeConfig.Visible = false;
                        gb_MultiplexConfig.Visible = false;
                }

                private void Main_Load(object sender, EventArgs e)
                {
                        //rb_Simple.Checked = true;
                        RefreshCom();
                        HideAll();
                        rb_OpenCloseComm.Checked = true;
                        gb_OpenCloseComm.Location = theLocation;
                        gb_OpenCloseComm.Visible = true;
                        cmb_BaudRate.SelectedIndex = 4;
                        cmb_BaudRate1.SelectedIndex = 4;
                        cmb_BaudRate_Demo.SelectedIndex = 4;
                        ///////////////////////////
                        HideAll_1();
                        rb_ReaderConfig.Checked = true;
                        gb_ReaderConfig.Location = theLocation_1;
                        gb_ReaderConfig.Visible = true;

                        ///////////////////////////

                        Int32[] Value = new Int32[] { 7200, 9600, 14400, 19200, 38400, 57600, 115200, 128000, 230400, 460800, 921600, 1228800 };
                        for (Byte i = 0; i < 12; i++)
                        {
                                cmb_BaudRate_14443.Items.Add(Value[i].ToString());
                                cmb_BaudRate_14443B.Items.Add(Value[i].ToString());
                        }
                        //cmb_PortNum.SelectedIndex = 0;

                        /////////////////////////
                        reader = new ISO15693Reader();
                        iso14443Reader = new ISO14443Reader();
                        iso14443Reader.TagDetected += new ISO14443Reader.TagDetectedEventHandler(iso14443Reader_TagDetected);
                }

                private void Main_FormClosing(object sender, FormClosingEventArgs e)
                {
                        IsAutoRun = false;
                        try
                        {
                                threadAuto.Abort();
                                reader.CloseSerialPort();
                        }
                        catch { }
                }

                private void btn_ClearListBox1_Click(object sender, EventArgs e)
                {
                        lst_Info.Items.Clear();
                }


                private void rb_OpenCloseComm_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_OpenCloseComm.Checked)
                        {
                                HideAll();
                                gb_OpenCloseComm.Location = theLocation;
                                gb_OpenCloseComm.Visible = true;
                        }
                }

                private void rb_OpenCloseHID_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_OpenCloseHID.Checked)
                        {
                                HideAll();
                                gb_OpenCloseHID.Location = theLocation;
                                gb_OpenCloseHID.Visible = true;
                        }
                }

                private void btn_CloseComm_Click(object sender, EventArgs e)
                {
                        if (reader.ConnectType==1)
                        {
                                Byte value = reader.CloseSerialPort();
                                if (value == 0x00)
                                        AddList("串口关闭成功!");
                                else
                                        AddList("串口关闭失败!");
                        }
                        else
                        {
                                AddList(String.Format("错误：串口处于关闭状态！"));
                        }
                }

                private void btn_OpenComm_Click(object sender, EventArgs e)
                {
                        if (reader.ConnectType > 1)
                        {
                                AddList(" 您已经打开了USB接口！");
                                return;
                        }
                        if (reader.ConnectType > 0)
                        {
                                AddList(" 您已经打开了串口！");
                                return;
                        }
                        if (!reader.IsOpen)
                        {
                                if (cmb_PortNum.SelectedIndex < 0)
                                {
                                        AddList(String.Format("错误：请您选择要打开的串口！"));
                                        cmb_PortNum.Focus();
                                        return;
                                }
                                if (cmb_BaudRate.SelectedIndex < 0)
                                {
                                        AddList(String.Format("错误：请您选择要使用的波特率！"));
                                        cmb_BaudRate.Focus();
                                        return;
                                }
                                String PortName = cmb_PortNum.Text.Trim();
                                Int32 BaudRate = 115200;// Int32.Parse(cmb_BaudRate.Text.Trim());
                                Byte value = reader.OpenSerialPort(PortName, BaudRate);
                                if (value == 0x00)
                                {
                                        AddList(String.Format("串口{0}打开成功！", PortName));
                                        rb_Inventory.Checked = true;
                                }
                                else
                                { AddList(String.Format("错误：串口{0}打开失败！", PortName)); }
                        }
                        else
                        {
                                AddList(String.Format("错误：串口已经处于打开状态！"));
                        }
                }

                private void btn_Inventory_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddList(String.Format("错误：尚未打开串口！"));
                                rb_OpenCloseComm.Checked = true;
                                return;
                        }
                        ModulateMethod mm = ModulateMethod.ASK;
                        if (rb_FSK.Checked) mm = ModulateMethod.FSK;
                        InventoryModel im = InventoryModel.Multiple;
                        if (rb_Single.Checked) im = InventoryModel.Single;
                        Int32 TagCount = 0;
                        String[] TagNumber = new String[1];
                        Byte value = reader.Inventory(mm, im, ref TagCount, ref TagNumber);
                        if (value != 0x00)
                        {
                                AddList(String.Format("错误：Inventory命令执行失败，错误代码：0x{0:X2}！", value));
                                return;
                        }
                        AddList(String.Format("Inventory执行成功，找到了{0}个卡片：", TagCount));
                        for (Int32 i = 0; i < TagNumber.Length; i++)
                                AddList(TagNumber[i]);
                        CurrUID = TagNumber;
                        AddTag();
                }

                private void rb_Inventory_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_Inventory.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        HideAll();
                                        gb_Inventory.Location = theLocation;
                                        lst_InventoryResult.Items.Clear();
                                        rb_Single.Checked = true;
                                        rb_FSK.Checked = true;
                                        gb_Inventory.Visible = true;
                                }
                        }
                }

                private void btn_AutoRun_Click(object sender, EventArgs e)
                {
                        if (btn_AutoRun.Text == "AutoRun")
                        {
                                IsAutoRun = true;
                                threadAuto = new Thread(new ThreadStart(ThreadAutoRun));
                                threadAuto.IsBackground = true;
                                threadAuto.Start();
                                btn_AutoRun.Text = "StopRun";
                        }
                        else
                        {
                                IsAutoRun = false;
                                Thread.Sleep(500);
                                threadAuto = null;
                                btn_AutoRun.Text = "AutoRun";
                        }
                }

                private void ThreadAutoRun()
                {
                        Int32 TagCount = 0;
                        String[] TagNumber = new String[1];
                        ModulateMethod mm = ModulateMethod.ASK;
                        if (rb_FSK.Checked) mm = ModulateMethod.FSK;
                        InventoryModel im = InventoryModel.Multiple;
                        if (rb_Single.Checked) im = InventoryModel.Single;
                        while (IsAutoRun)
                        {
                                Byte value = reader.Inventory(mm, im, ref TagCount, ref TagNumber);
                                if (value != 0x00)
                                {
                                        AddList(String.Format("错误：Inventory命令执行失败，错误代码：0x{0:X2}！", value));
                                        Thread.Sleep(500);
                                        continue;
                                }
                                AddList(String.Format("Inventory执行成功，找到了{0}个卡片：", TagCount));
                                for (Int32 i = 0; i < TagNumber.Length; i++)
                                        AddList(TagNumber[i]);
                                CurrUID = TagNumber;
                                AddTag();
                                Thread.Sleep(500);
                        }
                }

                private void rb_ReadSingleBolock_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_ReadSingleBolock.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_ReadSingleBlock.Location = theLocation;
                                                cmb_UID_1.Items.Clear();
                                                cmb_UID_1.Items.AddRange(CurrUID);
                                                cmb_UID_1.SelectedIndex = 0;
                                                cmd_Length_1.SelectedIndex = 0;
                                                txt_Result_1.Text = "Result";
                                                gb_ReadSingleBlock.Visible = true;
                                        }
                                }
                        }
                }

                private void txt_Address_1_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Address_1.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Address_1.SelectAll();
                                txt_Address_1.Focus();
                        }
                }

                private void btn_ReadSingleBlock_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_1.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要读取的卡片！");
                                cmb_UID_1.Focus();
                                return;
                        }
                        if (cmd_Length_1.SelectedIndex < 0)
                        {
                                AddList("错误：请选择正确的数据块长度！");
                                cmd_Length_1.Focus();
                                return;
                        }
                        if (!reader.IsOpen)
                        {
                                AddList(String.Format("错误：尚未打开串口！"));
                                rb_OpenCloseComm.Checked = true;
                                return;
                        }
                        String TagNum = cmb_UID_1.Text.Trim();
                        BlockLength bl = (BlockLength)Byte.Parse(cmd_Length_1.Text.Trim());
                        Byte BlockAddrss = Convert.ToByte(txt_Address_1.Text.Trim(),16);
                        Byte[] BlockData = new Byte[1];
                        Byte value = reader.ReadSingleBlock(TagNum, bl, BlockAddrss, ref BlockData);
                        if (value == 0x00)
                        {
                                AddList(String.Format("ReadSingleBlock命令执行成功！"));
                                String data = "";
                                for (Int32 i = 0; i < BlockData.Length; i++)
                                {
                                        data += BlockData[i].ToString("X2");
                                }
                                AddList(String.Format("返回的数据为{0}。", data));
                                AddResult1(data);
                        }
                        else
                        { AddList(String.Format("ReadSingleBlock命令执行失败，错误代码0x{0:X2}！", value)); }
                }

                private void rb_WriteSingleBlock_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_WriteSingleBlock.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_WriteSingleBlock.Location = theLocation;
                                                cmb_UID_2.Items.Clear();
                                                cmb_UID_2.Items.AddRange(CurrUID);
                                                cmb_UID_2.SelectedIndex = 0;
                                                cmd_Length_2.SelectedIndex = 0;
                                                gb_WriteSingleBlock.Visible = true;
                                        }
                                }
                        }

                }

                private void txt_Address_2_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Address_2.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Address_2.SelectAll();
                                txt_Address_2.Focus();
                        }
                }
                //zoo
                private void btn_WriteSingleBlock_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_2.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要写入的卡片！");
                                cmb_UID_2.Focus();
                                return;
                        }
                        if (cmd_Length_2.SelectedIndex < 0)
                        {
                                AddList("错误：请选择正确的数据块长度！");
                                cmd_Length_2.Focus();
                                return;
                        }
                        BlockLength bl = (BlockLength)Byte.Parse(cmd_Length_2.Text.Trim());
                        Byte[] DataForWrite = new Byte[(Byte)bl];
                        String strForWrite = txt_WriteData_2.Text.Trim();
                        try
                        {
                                for (Byte i = 0; i < DataForWrite.Length; i++)
                                {
                                        DataForWrite[i] = Convert.ToByte(strForWrite.Substring(i * 2, 2), 16);
                                }
                        }
                        catch (System.ArgumentOutOfRangeException ex)
                        {
                                AddList(String.Format("错误：写入的数据长度不够{0}Byte！", (Byte)bl));
                                txt_WriteData_2.SelectAll();
                                txt_WriteData_2.Focus();
                                return;
                        }
                        catch (System.Exception ex)
                        {
                                AddList(String.Format("错误：请填写{0}Byte的16进制数据！", (Byte)bl));
                                txt_WriteData_2.SelectAll();
                                txt_WriteData_2.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_2.Text.Trim();
                        Byte BlockAddress = Convert.ToByte(txt_Address_2.Text.Trim(),16);
                        Byte value = reader.WriteSingleBlock(TagNum, bl, BlockAddress, DataForWrite);
                        if (value == 0x00)
                        {
                                AddList(String.Format("WriteSingleBlock命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("WriteSingleBlock命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_ReadMultiBlock_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_ReadMultiBlock.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_ReadMultiBlock.Location = theLocation;
                                                cmb_UID_3.Items.Clear();
                                                cmb_UID_3.Items.AddRange(CurrUID);
                                                cmb_UID_3.SelectedIndex = 0;
                                                cmd_Length_3.SelectedIndex = 0;
                                                lst_Result.Items.Clear();
                                                lst_Result.Items.Add("Result:");
                                                gb_ReadMultiBlock.Visible = true;
                                        }
                                }
                        }
                }

                private void txt_Address_3_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Address_3.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Address_3.SelectAll();
                                txt_Address_3.Focus();
                        }
                }

                private void txt_Number_3_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Number_3.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Number_3.SelectAll();
                                txt_Number_3.Focus();
                        }
                }

                private void btn_ReadMultiBlock_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_3.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要读取的卡片！");
                                cmb_UID_3.Focus();
                                return;
                        }
                        if (cmd_Length_3.SelectedIndex < 0)
                        {
                                AddList("错误：请选择正确的数据块长度！");
                                cmd_Length_3.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_3.Text.Trim();
                        BlockLength bl = (BlockLength)Byte.Parse(cmd_Length_3.Text.Trim());
                        Byte BlockAddress = Convert.ToByte(txt_Address_3.Text.Trim(),16);
                        Byte BlockCount = Byte.Parse(txt_Number_3.Text.Trim());
                        Byte[] BlockData = new Byte[1];
                        Byte value = reader.ReadMultiBlock(TagNum, bl, BlockAddress, BlockCount, ref BlockData);
                        if (value == 0x00)
                        {
                                AddList(String.Format("ReadMultiBlock命令执行成功！"));
                                String data = "";
                                for (Int32 i = 0; i < BlockData.Length; i++)
                                {
                                        data += BlockData[i].ToString("X2");
                                }

                                AddList(String.Format("返回的数据为{0}。", data));
                                AddResult2(data);
                        }
                        else
                        {
                                AddList(String.Format("ReadMultiBlock命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_WriteMultiBlock_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_WriteMultiBlock.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_WriteMultiBlock.Location = theLocation;
                                                cmb_UID_4.Items.Clear();
                                                cmb_UID_4.Items.AddRange(CurrUID);
                                                cmb_UID_4.SelectedIndex = 0;
                                                cmd_Length_4.SelectedIndex = 0;
                                                gb_WriteMultiBlock.Visible = true;
                                        }
                                }
                        }
                }

                private void txt_Address_4_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Address_4.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Address_4.SelectAll();
                                txt_Address_4.Focus();
                        }
                }

                private void txt_Number_4_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Number_4.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Number_4.SelectAll();
                                txt_Number_4.Focus();
                        }
                }

                private void btn_WriteMultiBlock_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_4.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要写入的卡片！");
                                cmb_UID_4.Focus();
                                return;
                        }
                        if (cmd_Length_4.SelectedIndex < 0)
                        {
                                AddList("错误：请选择正确的数据块长度！");
                                cmd_Length_4.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_4.Text.Trim();
                        BlockLength bl = (BlockLength)Byte.Parse(cmd_Length_4.Text.Trim());
                        Byte BlockAddress = Byte.Parse(txt_Address_4.Text.Trim());
                        Byte BlockCount = Byte.Parse(txt_Number_4.Text.Trim());
                        Byte[] DataForWrite = new Byte[((Byte)bl) * BlockCount];
                        String strForWrite = txt_WriteData_4.Text.Trim();
                        try
                        {
                                for (Byte i = 0; i < DataForWrite.Length; i++)
                                {
                                        DataForWrite[i] = Convert.ToByte(strForWrite.Substring(i * 2, 2), 16);
                                }
                        }
                        catch (System.ArgumentOutOfRangeException ex)
                        {
                                AddList(String.Format("错误：写入的数据长度不够{0}*{1}={2}Byte！", (Byte)bl, BlockCount, ((Byte)bl) * BlockCount));
                                txt_WriteData_4.SelectAll();
                                txt_WriteData_4.Focus();
                                return;
                        }
                        catch (System.Exception ex)
                        {
                                AddList(String.Format("错误：请填写{0}*{1}={2}Byte的16进制数据！", (Byte)bl, BlockCount, ((Byte)bl) * BlockCount));
                                txt_WriteData_4.SelectAll();
                                txt_WriteData_4.Focus();
                                return;
                        }
                        Byte value = reader.WriteMultiBlock(TagNum, bl, BlockAddress, BlockCount, DataForWrite);
                        if (value == 0x00)
                        {
                                AddList(String.Format("WriteMultiBlock命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("WriteMultiBlock命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void txt_Address_5_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Address_5.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Address_5.SelectAll();
                                txt_Address_5.Focus();
                        }
                }

                private void rb_LockBlock_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_LockBlock.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_LockBlock.Location = theLocation;
                                                cmb_UID_5.Items.Clear();
                                                cmb_UID_5.Items.AddRange(CurrUID);
                                                cmb_UID_5.SelectedIndex = 0;
                                                gb_LockBlock.Visible = true;
                                        }
                                }
                        }
                }

                private void btn_LockSingleBlock_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_5.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要操作的卡片！");
                                cmb_UID_5.Focus();
                                return;
                        }
                        if (MessageBox.Show("Block锁定是不可逆的！\r\n锁定后您将永远无法修改该Block的数据。\r\n您确认要锁定吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                                return;
                        Byte BlockAddress = Byte.Parse(txt_Address_5.Text.Trim());
                        String TagNum = cmb_UID_5.Text.Trim();
                        Byte value = reader.LockSingleBlock(TagNum, BlockAddress);
                        if (value == 0x00)
                        {
                                AddList(String.Format("LockSingleBlock命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("LockSingleBlock命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_StayQuiet_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_StayQuiet.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_StayQuiet.Location = theLocation;
                                                cmb_UID_6.Items.Clear();
                                                cmb_UID_6.Items.AddRange(CurrUID);
                                                cmb_UID_6.SelectedIndex = 0;
                                                gb_StayQuiet.Visible = true;
                                        }
                                }
                        }
                }

                private void btn_StayQuiet_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_6.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要操作的卡片！");
                                cmb_UID_6.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_6.Text.Trim();
                        Byte value = reader.StayQuiet(TagNum);
                        if (value == 0x00)
                        {
                                AddList(String.Format("StayQuiet命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("StayQuiet命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_Select_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_Select.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_Select.Location = theLocation;
                                                cmb_UID_7.Items.Clear();
                                                cmb_UID_7.Items.AddRange(CurrUID);
                                                cmb_UID_7.SelectedIndex = 0;
                                                gb_Select.Visible = true;
                                        }
                                }
                        }
                }

                private void btn_Select_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_7.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要操作的卡片！");
                                cmb_UID_7.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_7.Text.Trim();
                        Byte value = reader.Select(TagNum);
                        if (value == 0x00)
                        {
                                AddList(String.Format("Select命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("Select命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_ResetToReady_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_ResetToReady.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_ResetToReady.Location = theLocation;
                                                cmb_Mode.Text = "Please Select A Mode";
                                                cmb_UID_8.Visible = false;
                                                lbl_UID.Visible = false;
                                                cmb_UID_8.Items.Clear();
                                                cmb_UID_8.Items.AddRange(CurrUID);
                                                cmb_UID_8.SelectedIndex = 0;
                                                gb_ResetToReady.Visible = true;
                                        }
                                }
                        }
                }

                private void cmb_Mode_SelectedIndexChanged(object sender, EventArgs e)
                {
                        if (cmb_Mode.SelectedIndex > 1)
                        {
                                lbl_UID.Visible = true;
                                cmb_UID_8.Visible = true;
                        }
                        else
                        {
                                lbl_UID.Visible = false;
                                cmb_UID_8.Visible = false;
                        }
                }

                private void btn_ResetToReady_Click(object sender, EventArgs e)
                {
                        ResetMode rm;
                        switch (cmb_Mode.SelectedIndex)
                        {
                                case 0x00:
                                        rm = ResetMode.RstAllQuiet;
                                        break;
                                case 0x01:
                                        rm = ResetMode.RstAllSelected;
                                        break;
                                case 0x02:
                                        rm = ResetMode.RstSpecificQuiet;
                                        break;
                                case 0x03:
                                        rm = ResetMode.RstSpecificSelected;
                                        break;
                                default:
                                        AddList("错误：请选择您要采用的Reset模式！");
                                        cmb_Mode.Focus();
                                        return;
                        }
                        Byte value;
                        if (((Byte)rm) > 0x13)
                        {
                                if (cmb_UID_8.SelectedIndex < 0)
                                {
                                        AddList("错误：请选择您要Reset的TagUID！");
                                        cmb_UID_8.Focus();
                                        return;
                                }
                                String TagNum = cmb_UID_8.Text.Trim();
                                value = reader.ResetToReady(rm, TagNum);
                        }
                        else
                        {
                                value = reader.ResetToReady(rm);
                        }
                        if (value == 0x00)
                        {
                                AddList(String.Format("ResetToReady命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("ResetToReady命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void txt_AFI_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Convert.ToByte(txt_AFI.Text.Trim(), 16); }
                        catch
                        {
                                AddList("错误：AFI值为一个字节的十六进制数！");
                                txt_AFI.SelectAll();
                                txt_AFI.Focus();
                        }
                }

                private void rb_WriteAFI_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_WriteAFI.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_WriteAFI.Location = theLocation;
                                                cmb_UID_9.Items.Clear();
                                                cmb_UID_9.Items.AddRange(CurrUID);
                                                cmb_UID_9.SelectedIndex = 0;
                                                txt_AFI.Text = "00";
                                                gb_WriteAFI.Visible = true;
                                        }
                                }
                        }
                }

                private void btn_WriteAFI_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_9.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要操作的卡片！");
                                cmb_UID_9.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_9.Text.Trim();
                        Byte AFI = Convert.ToByte(txt_AFI.Text.Trim(), 16);
                        Byte value = reader.WriteAFI(TagNum, AFI);
                        if (value == 0x00)
                        {
                                AddList(String.Format("WriteAFI命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("WriteAFI命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void btn_LockAFI_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_10.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要操作的卡片！");
                                cmb_UID_10.Focus();
                                return;
                        }
                        if (MessageBox.Show("AFI锁定是不可逆的，您确认要锁定吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                                return;
                        String TagNum = cmb_UID_10.Text.Trim();
                        Byte value = reader.LockAFI(TagNum);
                        if (value == 0x00)
                        {
                                AddList(String.Format("LockAFI命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("LockAFI命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_LockAFI_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_LockAFI.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_LockAFI.Location = theLocation;
                                                cmb_UID_10.Items.Clear();
                                                cmb_UID_10.Items.AddRange(CurrUID);
                                                cmb_UID_10.SelectedIndex = 0;
                                                gb_LockAFI.Visible = true;
                                        }
                                }
                        }
                }

                private void rb_WriteDSFID_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_WriteDSFID.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_WriteDSFID.Location = theLocation;
                                                cmb_UID_11.Items.Clear();
                                                cmb_UID_11.Items.AddRange(CurrUID);
                                                cmb_UID_11.SelectedIndex = 0;
                                                txt_DSFID.Text = "00";
                                                gb_WriteDSFID.Visible = true;
                                        }
                                }
                        }
                }

                private void txt_DSFID_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Convert.ToByte(txt_DSFID.Text.Trim(), 16); }
                        catch
                        {
                                AddList("错误：DSFID值为一个字节的十六进制数！");
                                txt_DSFID.SelectAll();
                                txt_DSFID.Focus();
                        }
                }

                private void btn_WriteDSFID_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_11.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要操作的卡片！");
                                cmb_UID_11.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_11.Text.Trim();
                        Byte DSFID = Convert.ToByte(txt_DSFID.Text.Trim(), 16);
                        Byte value = reader.WriteDSFID(TagNum, DSFID);
                        if (value == 0x00)
                        {
                                AddList(String.Format("WriteDSFID命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("WriteDSFID命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void btn_LockDSFID_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_12.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要操作的卡片！");
                                cmb_UID_12.Focus();
                                return;
                        }
                        if (MessageBox.Show("DSFID锁定是不可逆的，您确认要锁定吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                                return;
                        String TagNum = cmb_UID_12.Text.Trim();
                        Byte value = reader.LockDSFID(TagNum);
                        if (value == 0x00)
                        {
                                AddList(String.Format("LockDSFID命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("LockDSFID命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_LockDSFID_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_LockDSFID.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_LockDSFID.Location = theLocation;
                                                cmb_UID_12.Items.Clear();
                                                cmb_UID_12.Items.AddRange(CurrUID);
                                                cmb_UID_12.SelectedIndex = 0;
                                                gb_LockDSFID.Visible = true;
                                        }
                                }
                        }
                }

                private void btn_GetSystemInfo_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_13.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要操作的卡片！");
                                cmb_UID_13.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_13.Text.Trim();
                        Byte InfoFlag = 0x00;
                        Byte DSFID = 0x00;
                        Byte AFI = 0x00;
                        UInt16 VICCMemorySize = 0;
                        Byte ICReference = 0x00;
                        Byte value = reader.GetSystemInfo(TagNum, ref InfoFlag, ref DSFID, ref AFI, ref VICCMemorySize, ref ICReference);
                        if (value == 0x00)
                        {
                                AddList(String.Format("GetSystemInfo命令执行成功！"));
                                String data = "";
                                data += InfoFlag.ToString("X2");
                                data += TagNum;
                                data += DSFID.ToString("X2");
                                data += AFI.ToString("X2");
                                data += ((Byte)(VICCMemorySize % 256)).ToString("X2");
                                data += ((Byte)(VICCMemorySize / 256)).ToString("X2");
                                data += ICReference.ToString("X2");
                                AddSysInfo(data);
                        }
                        else
                        {
                                AddList(String.Format("GetSystemInfo命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_GetSystemInfo_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_GetSystemInfo.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_GetSystemInfo.Location = theLocation;
                                                cmb_UID_13.Items.Clear();
                                                cmb_UID_13.Items.AddRange(CurrUID);
                                                cmb_UID_13.SelectedIndex = 0;
                                                gb_GetSystemInfo.Visible = true;
                                        }
                                }
                        }
                }

                private void txt_Number_14_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Number_14.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Number_14.SelectAll();
                                txt_Number_14.Focus();
                        }
                }

                private void txt_Address_14_TextChanged(object sender, EventArgs e)
                {
                        try
                        { Byte.Parse(txt_Address_14.Text.Trim()); }
                        catch
                        {
                                AddList("错误：地址应该是大于等于0小于256的整数！");
                                txt_Address_14.SelectAll();
                                txt_Address_14.Focus();
                        }
                }

                private void rb_GetMultiBlockSec_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_GetMultiBlockSec.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        if (CurrUID.Length < 1)
                                        {
                                                AddList(String.Format("请先使用Inventory命令寻找卡片！"));
                                                rb_Inventory.Checked = true;
                                        }
                                        else
                                        {
                                                HideAll();
                                                gb_GetMulti.Location = theLocation;
                                                cmb_UID_14.Items.Clear();
                                                cmb_UID_14.Items.AddRange(CurrUID);
                                                cmb_UID_14.SelectedIndex = 0;
                                                gb_GetMulti.Visible = true;
                                        }
                                }
                        }
                }

                private void btn_GetMulti_Click(object sender, EventArgs e)
                {
                        if (cmb_UID_14.SelectedIndex < 0)
                        {
                                AddList("错误：请选择您要读取的卡片！");
                                cmb_UID_14.Focus();
                                return;
                        }
                        String TagNum = cmb_UID_14.Text.Trim();
                        Byte BlockAddress = Byte.Parse(txt_Address_14.Text.Trim());
                        Byte BlockCount = Byte.Parse(txt_Number_14.Text.Trim());
                        Byte[] SecStatus = new Byte[1];
                        Byte value = reader.GetMultiBlockSec(TagNum, BlockAddress, BlockCount, ref SecStatus);
                        if (value == 0x00)
                        {
                                AddList(String.Format("GetMultiBlockSec命令执行成功！"));
                                String data = "";
                                for (Int32 i = 0; i < SecStatus.Length; i++)
                                        data += SecStatus[i].ToString("X2");
                                AddResult3(data);
                        }
                        else
                        {
                                AddList(String.Format("GetMultiBlockSec命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_EnableBuzzer_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_EnableBuzzer.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        HideAll();
                                        gb_EnableBuzzer.Location = theLocation;
                                        rb_Flag_True.Checked = true;
                                        gb_EnableBuzzer.Visible = true;
                                }
                        }
                }

                private void btn_EnableBuzzer_Click(object sender, EventArgs e)
                {
                        Boolean Flag = (rb_Flag_True.Checked) ? true : false;
                        Byte value = reader.EnableBuzzer(Flag);
                        if (value == 0x00)
                        {
                                AddList(String.Format("EnableBuzzer命令执行成功！"));
                        }
                        else
                        {
                                AddList(String.Format("EnableBuzzer命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_GetAll_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_GetAll.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        HideAll();
                                        gb_GetAll.Location = theLocation;
                                        txt_GetAllResult.Clear();
                                        lst_GetAllResult.Items.Clear();
                                        gb_GetAll.Visible = true;
                                }
                        }
                }

                private void btn_GetAll_Click(object sender, EventArgs e)
                {
                        Int32 TagCount;
                        String[] TagNum;
                        Byte value = reader.GetAllTagsNum(out TagCount, out TagNum);
                        if (value == 0x00)
                        {
                                AddList(String.Format("GetAllTagsNum命令执行成功！"));
                                txt_GetAllResult.Text = TagCount.ToString();
                                lst_GetAllResult.Items.Clear();
                                lst_GetAllResult.Items.AddRange(TagNum);
                        }
                        else
                        {
                                AddList(String.Format("GetAllTagsNum命令执行失败！错误代码：0x{0:X2}", value));
                        }
                }

                private void rb_AutoRcv_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_AutoRcv.Checked)
                        {
                                if (!reader.IsOpen)
                                {
                                        AddList(String.Format("错误：尚未打开串口！"));
                                        rb_OpenCloseComm.Checked = true;
                                        return;
                                }
                                else
                                {
                                        HideAll();
                                        gb_AutoRcv.Location = theLocation;
                                        gb_AutoRcv.Visible = true;
                                }
                        }
                }

                private void btn_AutoRcv_Click(object sender, EventArgs e)
                {
                        //if (btn_AutoRcv.Text == "BeginAutoRcv")
                        //{
                        //        if (!IsRegistedEvent)
                        //        {
                        //                reader.OnDataArrive += new  ISO15693Reader.DataReceived (ShowData);
                        //                IsRegistedEvent = true;
                        //        }
                        //        Byte value = reader.BeginAutoReceive();
                        //        if (value == 0x00)
                        //        {
                        //                AddList(String.Format("BeginAutoReceive命令执行成功，您开始了自动接收！"));
                        //                btn_AutoRcv.Text = "EndAutoRcv";
                        //        }
                        //        else
                        //                AddList(String.Format("BeginAutoReceive命令执行失败！错误代码：0x{0:X2}", value));
                        //}
                        //else
                        //{
                        //        Byte value = reader.EndAutoReceive();
                        //        if (value == 0x00)
                        //        {
                        //                AddList(String.Format("EndAutoReceive命令执行成功，您结束了自动接收！"));
                        //                btn_AutoRcv.Text = "BeginAutoRcv";
                        //        }
                        //        else
                        //                AddList(String.Format("EndAutoReceive命令执行失败！错误代码：0x{0:X2}", value));
                        //}
                }

                //private void ShowData()
                //{
                //        String[] TagNumber = (String[])reader.AutoRcvdTagNum.Clone();
                //        String TagCount = reader.AutoRcvdTagCount.ToString();
                //        AddList(String.Format("{1} 寻到{0}张卡片：", TagCount, DateTime.Now.ToString("T")));
                //        for (Int32 i = 0; i < TagNumber.Length; i++)
                //                AddList(String.Format("{0}:{1}", i + 1, TagNumber[i]));
                //}

                private void btn_ClearAutoGetAllResult_Click(object sender, EventArgs e)
                {
                        lst_GetAllResult.Items.Clear();
                        txt_GetAllResult.Clear();
                }

                private void btn_AutoGetAll_Click(object sender, EventArgs e)
                {
                        if (btn_AutoGetAll.Text == "AutoGetAll")
                        { timer1.Enabled = true; btn_AutoGetAll.Text = "StopGetAll"; }
                        else
                        { timer1.Enabled = false; btn_AutoGetAll.Text = "AutoGetAll"; }
                }

                private void timer1_Tick(object sender, EventArgs e)
                {
                        btn_GetAll_Click(sender, e);
                }

                private void rb_ReaderConfig_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_ReaderConfig.Checked)
                        {
                                HideAll_1();
                                gb_ReaderConfig.Location = theLocation_1;
                                gb_ReaderConfig.Visible = true;
                        }
                }

                private void rb_TimingConfig_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_TimingConfig.Checked)
                        {
                                HideAll_1();
                                gb_TimingConfig.Location = theLocation_1;
                                gb_TimingConfig.Visible = true;
                        }
                }

                private void rb_ICodeConfig_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_ICodeConfig.Checked)
                        {
                                HideAll_1();
                                gb_ICodeConfig.Location = theLocation_1;
                                gb_ICodeConfig.Visible = true;
                        }
                }

                private void rb_TagItConfig_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_TagItConfig.Checked)
                        {
                                HideAll_1();
                                gb_TagItConfig.Location = theLocation_1;
                                gb_TagItConfig.Visible = true;
                        }
                }

                private void rb_MultiplexConfig_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_MultiplexConfig.Checked)
                        {
                                HideAll_1();
                                gb_MultiplexConfig.Location = theLocation_1;
                                gb_MultiplexConfig.Visible = true;
                        }
                }

                private void rb_ChannelConfig_CheckedChanged(object sender, EventArgs e)
                {
                        if (rb_ChannelConfig.Checked)
                        {
                                HideAll_1();
                                gb_MultiplexConfig.Location = theLocation_1;
                                gb_MultiplexConfig.Visible = true;
                        }
                }

                private void btn_LoadReader_Click(object sender, EventArgs e)
                {
                        txt_TempAlarm.Text = "60";
                        txt_TempReset.Text = "50";
                        txt_Energy.Text = "1";
                        txt_Index.Text = "1E";
                        txt_RealTimeClock.Text = "10";
                        txt_ISOFSK.Text = "19";
                        txt_ISOASK.Text = "1F";
                        txt_SOFEOF.Text = "30";
                        txt_SOFFSK_1.Text = "01";
                        txt_SOFFSK_2.Text = "60";
                        txt_EOFASK_1.Text = "02";
                        txt_EOFASK_2.Text = "60";
                        txt_SOFASK_1.Text = "00";
                        txt_SOFASK_2.Text = "80";
                        txt_EOFASK_1.Text = "01";
                        txt_EOFASK_2.Text = "80";
                }

                private void btn_GetReader_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口。");
                                return;
                        }
                        Byte[] Parameters;
                        Byte result = reader.GetParameters(out Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("获取当前参数配置(Reader Config)失败，失败代码{0}。", result));
                                return;
                        }
                        AddInfo(String.Format("获取当前参数配置成功，Parameters:0x{0}。", ByteArrayToString(Parameters)));

                        txt_TempAlarm.Text = Parameters[8].ToString();
                        AddInfo(String.Format("Temp. Alarm Value:{0}", Parameters[8].ToString()));
                        txt_TempReset.Text = Parameters[9].ToString();
                        AddInfo(String.Format("Temp. Reset Value:{0}", Parameters[9].ToString()));
                        txt_Energy.Text = (0.5 * Parameters[16]).ToString("0.0");
                        AddInfo(String.Format("Energy:{0}Watt", (0.5 * Parameters[16]).ToString("0.0")));
                        txt_Index.Text = Parameters[17].ToString("X2");
                        AddInfo(String.Format("Index:{0}", Parameters[17].ToString("X2")));
                        txt_RealTimeClock.Text = Parameters[12].ToString("X2");
                        AddInfo(String.Format("Real Time Clock:{0}", Parameters[12].ToString("X2")));
                        txt_ISOFSK.Text = Parameters[7].ToString("X2");  //有待确认
                        AddInfo(String.Format("ISO FSK Collision:{0}", Parameters[7].ToString("X2")));
                        txt_ISOASK.Text = Parameters[13].ToString("X2");//有待确认
                        AddInfo(String.Format("ISO ASK Collision:{0}", Parameters[13].ToString("X2")));
                        txt_SOFEOF.Text = Parameters[37].ToString("X2");
                        AddInfo(String.Format("SOF EOF Margin:{0}", Parameters[37].ToString("X2")));
                        txt_SOFFSK_1.Text = Parameters[28].ToString("X2");
                        txt_SOFFSK_2.Text = Parameters[29].ToString("X2");
                        AddInfo(String.Format("SOF FSK Thresh:{0}-{1}", Parameters[28].ToString("X2"), Parameters[29].ToString("X2")));
                        txt_EOFFSK_1.Text = Parameters[30].ToString("X2");
                        txt_EOFFSK_2.Text = Parameters[31].ToString("X2");
                        AddInfo(String.Format("EOF FSK Thresh:{0}-{1}", Parameters[30].ToString("X2"), Parameters[31].ToString("X2")));
                        txt_SOFASK_1.Text = Parameters[32].ToString("X2");
                        txt_SOFASK_2.Text = Parameters[33].ToString("X2");
                        AddInfo(String.Format("SOF ASK Thresh:{0}-{1}", Parameters[32].ToString("X2"), Parameters[33].ToString("X2")));
                        txt_EOFASK_1.Text = Parameters[34].ToString("X2");
                        txt_EOFASK_2.Text = Parameters[35].ToString("X2");
                        AddInfo(String.Format("EOF ASK Thresh:{0}-{1}", Parameters[34].ToString("X2"), Parameters[35].ToString("X2")));
                }


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

                private void btn_SetReader_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口");
                                return;
                        }
                        Byte[] Parameters = new Byte[16];
                        try { Parameters[0] = Byte.Parse(txt_TempAlarm.Text); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_TempAlarm.Focus();
                                return;
                        }
                        try { Parameters[1] = Byte.Parse(txt_TempReset.Text); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_TempReset.Focus();
                                return;
                        }
                        try { Parameters[2] = (Byte)(Double.Parse(txt_Energy.Text) / 0.5); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_Energy.Focus();
                                return;
                        }
                        try { Parameters[3] = Convert.ToByte(txt_Index.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_Index.Focus();
                                return;
                        }
                        try { Parameters[4] = Convert.ToByte(txt_RealTimeClock.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_RealTimeClock.Focus();
                                return;
                        }
                        try { Parameters[5] = Convert.ToByte(txt_ISOFSK.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_ISOFSK.Focus();
                                return;
                        }
                        try { Parameters[6] = Convert.ToByte(txt_ISOASK.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_ISOASK.Focus();
                                return;
                        }
                        try { Parameters[7] = Convert.ToByte(txt_SOFEOF.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_SOFEOF.Focus();
                                return;
                        }
                        try { Parameters[8] = Convert.ToByte(txt_SOFFSK_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_SOFFSK_1.Focus();
                                return;
                        }
                        try { Parameters[9] = Convert.ToByte(txt_SOFFSK_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_SOFFSK_2.Focus();
                                return;
                        }
                        try { Parameters[10] = Convert.ToByte(txt_EOFFSK_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_EOFFSK_1.Focus();
                                return;
                        }
                        try { Parameters[11] = Convert.ToByte(txt_EOFFSK_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_EOFFSK_2.Focus();
                                return;
                        }
                        try { Parameters[12] = Convert.ToByte(txt_SOFASK_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_SOFASK_1.Focus();
                                return;
                        }
                        try { Parameters[13] = Convert.ToByte(txt_SOFASK_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_SOFASK_2.Focus();
                                return;
                        }
                        try { Parameters[14] = Convert.ToByte(txt_EOFASK_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_EOFASK_1.Focus();
                                return;
                        }
                        try { Parameters[15] = Convert.ToByte(txt_EOFASK_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_EOFASK_2.Focus();
                                return;
                        }

                        Byte result = reader.ReaderConfig(Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("参数设置(Reader Config)失败，失败代码{0}。", result));
                                return;
                        }
                        else
                        {
                                AddInfo(String.Format("参数设置(Reader Config)成功。"));
                        }
                }

                private void btn_RefreshComm_Click(object sender, EventArgs e)
                {
                        Refresh();
                }

                private void btn_Open_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                if (cmb_PortName.SelectedIndex < 0)
                                {
                                        AddInfo(String.Format("错误：请您选择要打开的串口！"));
                                        cmb_PortName.Focus();
                                        return;
                                }
                                if (cmb_BaudRate1.SelectedIndex < 0)
                                {
                                        AddInfo(String.Format("错误：请您选择要使用的波特率！"));
                                        cmb_BaudRate1.Focus();
                                        return;
                                }
                                String PortName = cmb_PortName.SelectedItem.ToString();
                                Int32 BaudRate = 115200;// Int32.Parse(cmb_BaudRate.Text.Trim());
                                Byte value = reader.OpenSerialPort(PortName, BaudRate);
                                if (value == 0x00)
                                {
                                        AddInfo(String.Format("串口{0}打开成功！", PortName));
                                }
                                else
                                { AddInfo(String.Format("错误：串口{0}打开失败！", PortName)); }
                        }
                        else
                        {
                                AddInfo(String.Format("错误：串口已经处于打开状态！"));
                        }

                }

                private void btn_Close_Click(object sender, EventArgs e)
                {
                        if (reader.IsOpen)
                        {
                                Byte value = reader.CloseSerialPort();
                                if (value == 0x00)
                                        AddInfo("串口关闭成功!");
                                else
                                        AddInfo("串口关闭失败!");
                        }
                        else
                        {
                                AddInfo(String.Format("错误：串口已经处于关闭状态！"));
                        }
                }

                private void btn_Refresh_Click(object sender, EventArgs e)
                {
                        Refresh();
                }

                private void btn_LoadTiming_Click(object sender, EventArgs e)
                {
                        txt_FSKTiming_1.Text = "29";
                        txt_FSKTiming_2.Text = "28";
                        txt_ASKTiming_1.Text = "1E";
                        txt_ASKTiming_2.Text = "1D";
                        txt_ASKRef_1.Text = "00";
                        txt_ASKRef_2.Text = "B0";
                        cmb_EASTagType.SelectedIndex = 2;

                        //if (!reader.IsOpen)
                        //{
                        //        AddInfo("请先打开串口。");
                        //        return;
                        //}
                        //Byte result =reader.TimingConfig( new Byte[8]);
                        //if (result != 0x00)
                        //{
                        //        AddInfo(String.Format("加载默认配置失败，失败代码{0}。", result));
                        //        return;
                        //}
                        //AddInfo(String.Format("加载默认配置成功。"));
                        //btn_GetTiming_Click(sender, e);
                }

                private void btn_GetTiming_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口。");
                                return;
                        }
                        Byte[] Parameters;
                        Byte result = reader.GetParameters(out Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("获取当前参数配置(Timing Config)失败，失败代码{0}。", result));
                                return;
                        }
                        AddInfo(String.Format("获取当前参数配置成功，Parameters:0x{0}。", ByteArrayToString(Parameters)));

                        txt_FSKTiming_1.Text = Parameters[18].ToString("X2");
                        txt_FSKTiming_2.Text = Parameters[20].ToString("X2");
                        AddInfo(String.Format("FSK Timing:{0}-{1}", Parameters[18].ToString("X2"), Parameters[20].ToString("X2")));
                        txt_ASKTiming_1.Text = Parameters[19].ToString("X2");
                        txt_ASKTiming_2.Text = Parameters[21].ToString("X2");
                        AddInfo(String.Format("ASK Timing:{0}-{1}", Parameters[19].ToString("X2"), Parameters[21].ToString("X2")));
                        txt_ASKRef_1.Text = Parameters[38].ToString("X2");
                        txt_ASKRef_2.Text = Parameters[39].ToString("X2");
                        AddInfo(String.Format("ASK Reference:{0}-{1}", Parameters[38].ToString("X2"), Parameters[39].ToString("X2")));
                        switch (Parameters[48])
                        {
                                case 0x91:
                                        cmb_EASTagType.SelectedIndex = 0;
                                        break;
                                case 0x11:
                                        cmb_EASTagType.SelectedIndex = 1;
                                        break;
                                default:
                                        cmb_EASTagType.SelectedIndex = 2;
                                        break;
                        }
                        AddInfo(String.Format("EAS Tag Type:{0}({1})", cmb_EASTagType.SelectedItem.ToString(), Parameters[48].ToString("X2")));
                }

                private void btn_SetTiming_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口");
                                return;
                        }
                        Byte[] Parameters = new Byte[8];
                        try { Parameters[0] = Convert.ToByte(txt_FSKTiming_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_FSKTiming_1.Focus();
                                return;
                        }
                        try { Parameters[1] = Convert.ToByte(txt_ASKTiming_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_ASKTiming_1.Focus();
                                return;
                        }
                        try { Parameters[2] = Convert.ToByte(txt_FSKTiming_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_FSKTiming_2.Focus();
                                return;
                        }
                        try { Parameters[3] = Convert.ToByte(txt_ASKTiming_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_ASKTiming_2.Focus();
                                return;
                        }
                        try { Parameters[4] = Convert.ToByte(txt_ASKRef_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_RealTimeClock.Focus();
                                return;
                        }
                        try { Parameters[5] = Convert.ToByte(txt_ASKRef_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_ISOFSK.Focus();
                                return;
                        }
                        if (cmb_EASTagType.SelectedIndex < 0)
                        {
                                AddInfo("请选择EAS Tag Type。");
                                cmb_EASTagType.Focus();
                                return;
                        }
                        switch (cmb_EASTagType.SelectedIndex)
                        {
                                case 0:
                                        Parameters[6] = 0x91;
                                        break;
                                case 1:
                                        Parameters[6] = 0x11;
                                        break;
                                default:
                                        Parameters[6] = 0x90;
                                        break;
                        }

                        Byte result = reader.TimingConfig(Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("参数设置(Timing Config)失败，失败代码{0}。", result));
                                return;
                        }
                        else
                        {
                                AddInfo(String.Format("参数设置(Timing Config)成功。"));
                        }
                }

                private void btn_LoadICode_Click(object sender, EventArgs e)
                {
                        txt_NoiseMargin.Text = "18";
                        txt_CollisionMarginICode.Text = "3E";
                        txt_Tuning.Text = "15";
                }

                private void btn_GetICode_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口。");
                                return;
                        }
                        Byte[] Parameters;
                        Byte result = reader.GetParameters(out Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("获取当前参数配置(I-Code Config)失败，失败代码{0}。", result));
                                return;
                        }
                        AddInfo(String.Format("获取当前参数配置成功，Parameters:0x{0}。", ByteArrayToString(Parameters)));

                        txt_NoiseMargin.Text = Parameters[0].ToString("X2");
                        AddInfo(String.Format("I-Code Noise Margin:{0}", Parameters[0].ToString("X2")));
                        txt_CollisionMarginICode.Text = Parameters[1].ToString("X2");
                        AddInfo(String.Format("I-Code Collision Margin:{0}", Parameters[1].ToString("X2")));
                        //txt_Tuning  .Text = Parameters[1].ToString("X2");
                        //AddInfo(String.Format("Tuning Calibration:{0}", "未知"));
                }

                private void btn_SetICode_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口");
                                return;
                        }
                        Byte[] Parameters = new Byte[8];
                        try { Parameters[0] = Convert.ToByte(txt_NoiseMargin.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_NoiseMargin.Focus();
                                return;
                        }
                        try { Parameters[1] = Convert.ToByte(txt_CollisionMarginICode.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_CollisionMarginICode.Focus();
                                return;
                        }
                        try { Parameters[2] = Convert.ToByte(txt_Tuning.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_Tuning.Focus();
                                return;
                        }
                        Byte result = reader.ICodeConfig(Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("参数设置(I-Code Config)失败，失败代码{0}。", result));
                                return;
                        }
                        else
                        {
                                AddInfo(String.Format("参数设置(I-Code Config)成功。"));
                        }
                }

                private void btn_LoadTagIt_Click(object sender, EventArgs e)
                {
                        txt_CollisionMarginTagIt.Text = "20";
                        txt_StartOfFrame_1.Text = "01";
                        txt_StartOfFrame_2.Text = "80";
                        txt_EndOfFrame_1.Text = "01";
                        txt_EndOfFrame_2.Text = "20";
                }

                private void btn_GetTagIt_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口。");
                                return;
                        }
                        Byte[] Parameters;
                        Byte result = reader.GetParameters(out Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("获取当前参数配置(Tag-It Config)失败，失败代码{0}。", result));
                                return;
                        }
                        AddInfo(String.Format("获取当前参数配置成功，Parameters:0x{0}。", ByteArrayToString(Parameters)));
                        txt_CollisionMarginTagIt.Text = Parameters[2].ToString("X2");
                        AddInfo(String.Format("Tag-It Collision Margin:{0}", Parameters[2].ToString("X2")));
                        txt_StartOfFrame_1.Text = Parameters[3].ToString("X2");
                        txt_StartOfFrame_2.Text = Parameters[4].ToString("X2");
                        AddInfo(String.Format("Tag-It Start Of Frame:{0}-{1}", Parameters[3].ToString("X2"), Parameters[4].ToString("X2")));
                        txt_EndOfFrame_1.Text = Parameters[5].ToString("X2");
                        txt_EndOfFrame_2.Text = Parameters[6].ToString("X2");
                        AddInfo(String.Format("Tag-It End Of Frame:{0}-{1}", Parameters[5].ToString("X2"), Parameters[6].ToString("X2")));

                }

                private void btn_SetTagIt_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口");
                                return;
                        }
                        Byte[] Parameters = new Byte[8];
                        try { Parameters[0] = Convert.ToByte(txt_CollisionMarginTagIt.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_CollisionMarginTagIt.Focus();
                                return;
                        }
                        try { Parameters[1] = Convert.ToByte(txt_StartOfFrame_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_StartOfFrame_1.Focus();
                                return;
                        }
                        try { Parameters[2] = Convert.ToByte(txt_StartOfFrame_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_StartOfFrame_2.Focus();
                                return;
                        }
                        try { Parameters[3] = Convert.ToByte(txt_EndOfFrame_1.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_EndOfFrame_1.Focus();
                                return;
                        }
                        try { Parameters[4] = Convert.ToByte(txt_EndOfFrame_2.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_EndOfFrame_2.Focus();
                                return;
                        }
                        Byte result = reader.TagItConfig(Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("参数设置(Tag-It Config)失败，失败代码{0}。", result));
                                return;
                        }
                        else
                        {
                                AddInfo(String.Format("参数设置(Tag-It Config)成功。"));
                        }
                }

                private void btn_Switch_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口");
                                return;
                        }
                        Byte Antenna = 0x00;
                        try { Antenna = Convert.ToByte(txt_Antenna.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_Antenna.Focus();
                                return;
                        }
                        Byte result = reader.SwitchChannel(Antenna);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("Switch Channel失败，失败代码{0}。", result));
                                return;
                        }
                        else
                        {
                                AddInfo(String.Format("Switch Channel成功。"));
                        }
                }

                private void btn_LoadMultiplex_Click(object sender, EventArgs e)
                {
                        rb_SingleAntenna.Checked = true;
                        txt_AntennaCount.Text = "04";
                        txt_AntennaTries.Text = "0A";
                        chk_PhaseShift.Checked = false;
                }

                private void btn_GetMultiplex_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口。");
                                return;
                        }
                        Byte[] Parameters;
                        Byte result = reader.GetParameters(out Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("获取当前参数配置(Tag-It Config)失败，失败代码{0}。", result));
                                return;
                        }
                        AddInfo(String.Format("获取当前参数配置成功，Parameters:0x{0}。", ByteArrayToString(Parameters)));
                        txt_AntennaCount.Text = Parameters[48].ToString("X2");
                        AddInfo(String.Format("Antenna Count:{0}", Parameters[48].ToString("X2")));
                        txt_AntennaTries.Text = Parameters[50].ToString("X2");
                        AddInfo(String.Format("Antenna Tries:{0}", Parameters[50].ToString("X2")));
                        txt_AntennaTries.Text = Parameters[50].ToString("X2");
                        AddInfo(String.Format("Antenna Tries:{0}", Parameters[50].ToString("X2")));
                        if ((Parameters[49] & 0x01) > 0)
                        {
                                rb_SingleAntenna.Checked = true;
                        }
                        else
                        {
                                if (Parameters[50] > 0)
                                { rb_MultiplexGates.Checked = true; }
                                else
                                { rb_SingleAxisGate.Checked = true; }
                        }
                        if ((Parameters[49] & 0x02) > 0)
                        {
                                chk_PhaseShift.Checked = true;
                        }
                        else
                        { chk_PhaseShift.Checked = false; }
                        //txt_CollisionMarginTagIt.Text = Parameters[1].ToString("X2");
                        //AddInfo(String.Format("Collision Margin:{0}", Parameters[1].ToString("X2")));
                        //txt_StartOfFrame_1.Text = Parameters[1].ToString("X2");
                        //txt_StartOfFrame_2.Text = Parameters[1].ToString("X2");
                        //AddInfo(String.Format("Start Of Frame:{0}-{1}", Parameters[1].ToString("X2"), Parameters[1].ToString("X2")));

                        //txt_EndOfFrame_1.Text = Parameters[1].ToString("X2");
                        //txt_EndOfFrame_2.Text = Parameters[1].ToString("X2");
                        //AddInfo(String.Format("End Of Frame:{0}-{1}", Parameters[1].ToString("X2"), Parameters[1].ToString("X2")));


                }

                private void btn_SetMultiplex_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfo("请先打开串口");
                                return;
                        }
                        Byte[] Parameters = new Byte[8];
                        try { Parameters[0] = Convert.ToByte(txt_AntennaCount.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_AntennaCount.Focus();
                                return;
                        }
                        if (rb_SingleAntenna.Checked)
                        {
                                Parameters[1] ^= 0x01;
                        }
                        if (chk_PhaseShift.Checked)
                        {
                                Parameters[1] ^= 0x02;
                        }
                        try { Parameters[2] = Convert.ToByte(txt_AntennaTries.Text, 16); }
                        catch
                        {
                                AddInfo("请填写正确的参数。");
                                txt_AntennaTries.Focus();
                                return;
                        }

                        Byte result = reader.MultiplexConfig(Parameters);
                        if (result != 0x00)
                        {
                                AddInfo(String.Format("参数设置(Multiplex Config)失败，失败代码{0}。", result));
                                return;
                        }
                        else
                        {
                                AddInfo(String.Format("参数设置(Multiplex Config)成功。"));
                        }
                }

                private void btn_Clear_Click(object sender, EventArgs e)
                {
                        lst_Info_Cfg.Items.Clear();
                }

                private void btn_InventoryDemo_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                AddInfoDemo("请先打开串口。");
                                return;
                        }
                        Int32 TagCount = 0x00;
                        String[] TagNumbers=new String[0];
                        Byte result=reader.Inventory(ModulateMethod.FSK, InventoryModel.Multiple, ref TagCount, ref TagNumbers);
                        //Byte result = reader.GetAllTagsNum(out TagCount, out TagNumbers);
                        if (result == 0x00)
                        {
                                AddInfoDemo(String.Format("Inventory命令执行成功，读取到的卡片数量为：{0}。", TagCount));
                        }
                        else
                        {
                                AddInfoDemo(String.Format("Inventory命令执行失败，失败代码{0}。", result));
                                return;
                        }
                        if (TagCount > 0)
                        {
                                cmb_TagNumbers.Items.Clear();
                                for (Int32 i = 0; i < TagNumbers.Length; i++)
                                {
                                        cmb_TagNumbers.Items.Add(TagNumbers[i]);
                                }
                                cmb_TagNumbers.SelectedIndex = 0;
                        }
                }

                private void btn_Open_Demo_Click(object sender, EventArgs e)
                {
                        if (!reader.IsOpen)
                        {
                                if (cmb_PortName_Demo.SelectedIndex < 0)
                                {
                                        AddInfoDemo(String.Format("错误：请您选择要打开的串口！"));
                                        cmb_PortName_Demo.Focus();
                                        return;
                                }
                                if (cmb_PortName_Demo.SelectedIndex < 0)
                                {
                                        AddInfoDemo(String.Format("错误：请您选择要使用的波特率！"));
                                        cmb_PortName_Demo.Focus();
                                        return;
                                }
                                String PortName = cmb_PortName_Demo.SelectedItem.ToString();
                                Int32 BaudRate = 115200;// Int32.Parse(cmb_BaudRate.Text.Trim());
                                Byte value = reader.OpenSerialPort(PortName, BaudRate);
                                if (value == 0x00)
                                {
                                        AddInfoDemo(String.Format("串口{0}打开成功！", PortName));
                                }
                                else
                                { AddInfoDemo(String.Format("错误：串口{0}打开失败！", PortName)); }
                        }
                        else
                        {
                                AddInfoDemo(String.Format("错误：串口已经处于打开状态！"));
                        }
                }

                private void btn_Clear_Demo_Click(object sender, EventArgs e)
                {
                        lst_Info_Demo.Items.Clear();
                }

                private void btn_Close_Demo_Click(object sender, EventArgs e)
                {
                        if (reader.IsOpen)
                        {
                                Byte value = reader.CloseSerialPort();
                                if (value == 0x00)
                                        AddInfoDemo("串口关闭成功!");
                                else
                                        AddInfoDemo("串口关闭失败!");
                        }
                        else
                        {
                                AddInfoDemo(String.Format("错误：串口已经处于关闭状态！"));
                        }
                }

                private void btn_Refresh_Demo_Click(object sender, EventArgs e)
                {
                        RefreshCom();
                }

                private void cmb_TagNumbers_SelectedIndexChanged(object sender, EventArgs e)
                {
                        if (cmb_TagNumbers.SelectedIndex >= 0)
                        {
                                SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.CONSTRING, CommandType.Text, String.Format("Select * From tbl_UserInfo Where TagNumber='{0}'", cmb_TagNumbers.SelectedItem.ToString()));
                                if (dr.Read())
                                {
                                        txt_UserName.Text = dr["UserName"].ToString();
                                        txt_UserCompany.Text = dr["UserName"].ToString();
                                        txt_UserTelephone.Text = dr["UserTelephone"].ToString();
                                        txt_Appellative.Text = dr["UserAppellative"].ToString();
                                        //if (dr["UserSex"].ToString().Trim().Equals("先生"))
                                        //{ rb_Male.Checked = true; }
                                        //else
                                        //{ rb_Female.Checked = true; }
                                        if (dr["UserPhoto"] != null)
                                        {
                                                try
                                                {
                                                        Byte[] photo = (Byte[])dr[7];
                                                        if (photo.Length > 0)
                                                        {
                                                                System.IO.MemoryStream ms = new System.IO.MemoryStream(photo);
                                                                Bitmap bmp = new Bitmap(ms);
                                                                pic_UserPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                                                pic_UserPhoto.Image = bmp;
                                                        }
                                                        else
                                                        {
                                                                pic_UserPhoto.Image = null;
                                                        }
                                                }
                                                catch { pic_UserPhoto.Image = null; }
                                        }
                                        else
                                        {
                                                pic_UserPhoto.Image = null;
                                        }
                                        btn_Add.Enabled = false;
                                        btn_Modify.Enabled = true;
                                        btn_Delete.Enabled = true;
                                }
                                else
                                {
                                        txt_UserName.Clear();
                                        txt_UserCompany.Clear();
                                        txt_UserTelephone.Clear();
                                        txt_Appellative.Clear();
                                        //rb_Male.Checked = true;
                                        pic_UserPhoto.Image = null;
                                        pic_UserPhoto.ImageLocation = null;
                                        btn_Add.Enabled = true;
                                        btn_Modify.Enabled = false;
                                        btn_Delete.Enabled = false;
                                        txt_UserName.Focus();
                                }
                                dr.Close();
                        }
                        else
                        {
                                btn_Add.Enabled = false;
                                btn_Modify.Enabled = false;
                                btn_Delete.Enabled = false;
                        }
                }

                private void btn_Add_Click(object sender, EventArgs e)
                {
                        if (txt_UserName.Text.Trim().Length < 1)
                        {
                                AddInfoDemo("请填写用户姓名。");
                                txt_UserName.Focus();
                        }
                        if (txt_UserCompany.Text.Trim().Length < 1)
                        {
                                AddInfoDemo("请填写公司名称。");
                                txt_UserCompany.Focus();
                        }
                        if (txt_UserTelephone.Text.Trim().Length < 1)
                        {
                                AddInfoDemo("请填写联系电话。");
                                txt_UserTelephone.Focus();
                        }
                        if (txt_Appellative.Text.Trim().Length < 1)
                        {
                                AddInfoDemo("请填写习惯称谓。");
                                txt_Appellative.Focus();
                        }
                        SqlParameter[] sp;
                        if (pic_UserPhoto.ImageLocation == null)
                        {
                                sp = new SqlParameter[]
                                { new SqlParameter("@TagNumber", SqlDbType.NVarChar, 50), 
                                  new SqlParameter("@UserName", SqlDbType.NVarChar,50),
                                  new SqlParameter("@UserCompany",SqlDbType.NVarChar,50),
                                  new SqlParameter("@UserTelephone", SqlDbType.NVarChar, 50),
                                  new SqlParameter("@UserAppellative", SqlDbType.NVarChar, 50)
                                    };
                        }
                        else
                        {
                                sp = new SqlParameter[]
                                { new SqlParameter("@TagNumber", SqlDbType.NVarChar, 50), 
                                  new SqlParameter("@UserName", SqlDbType.NVarChar,50),
                                  new SqlParameter("@UserCompany",SqlDbType.NVarChar,50),
                                  new SqlParameter("@UserTelephone", SqlDbType.NVarChar, 50),
                                  new SqlParameter("@UserAppellative", SqlDbType.NVarChar, 50),
                                  new SqlParameter("@UserPhoto", SqlDbType.Image)
                                    };
                        }
                        sp[0].Value = cmb_TagNumbers.SelectedItem.ToString().Trim();
                        sp[1].Value = txt_UserName.Text.Trim();
                        sp[2].Value = txt_UserCompany.Text.Trim();
                        sp[3].Value = txt_UserTelephone.Text.Trim();
                        sp[4].Value = txt_Appellative.Text.Trim();// rb_Male.Checked ? "先生" : "女士";
                        if (pic_UserPhoto.ImageLocation != null)
                        {
                                Byte[] imagedata;
                                using (FileStream fs = new FileStream(pic_UserPhoto.ImageLocation, FileMode.Open))
                                {
                                        imagedata = new Byte[fs.Length];
                                        fs.Read(imagedata, 0, imagedata.Length);
                                        fs.Close();
                                }
                                sp[5].Value = imagedata;
                        }

                        Int32 count;
                        if (pic_UserPhoto.ImageLocation == null)
                        {
                                count = SqlHelper.ExecuteNonQuery(SqlHelper.CONSTRING, CommandType.Text,
                                        "Insert Into tbl_UserInfo (TagNumber,UserName,UserCompany,UserTelephone,UserAppellative) Values(@TagNumber,@UserName,@UserCompany,@UserTelephone,@UserAppellative)", sp);
                        }
                        else
                        {
                                count = SqlHelper.ExecuteNonQuery(SqlHelper.CONSTRING, CommandType.Text,
               "Insert Into tbl_UserInfo (TagNumber,UserName,UserCompany,UserTelephone,UserAppellative,UserPhoto) Values(@TagNumber,@UserName,@UserCompany,@UserTelephone,@UserAppellative,@UserPhoto)", sp);
                        }
                        if (count > 0)
                        {
                                AddInfoDemo("添加成功。");
                                btn_InventoryDemo_Click(sender, e);
                        }
                        else
                        {
                                AddInfoDemo("添加失败。");
                        }

                }

                private void btn_Modify_Click(object sender, EventArgs e)
                {
                        if (cmb_TagNumbers.SelectedIndex < 0)
                        { AddInfoDemo("请选择要修改的用户"); cmb_TagNumbers.Focus(); return; }
                        if (txt_UserName.Text.Trim().Length < 1)
                        {
                                AddInfoDemo("请填写用户姓名。");
                                txt_UserName.Focus();
                        }
                        if (txt_UserCompany.Text.Trim().Length < 1)
                        {
                                AddInfoDemo("请填写公司名称。");
                                txt_UserCompany.Focus();
                        }
                        if (txt_UserTelephone.Text.Trim().Length < 1)
                        {
                                AddInfoDemo("请填写联系电话。");
                                txt_UserTelephone.Focus();
                        }
                        if (txt_Appellative.Text.Trim().Length < 1)
                        {
                                AddInfoDemo("请填写习惯称谓。");
                                txt_Appellative.Focus();
                        }
                        SqlParameter[] sp;

                        if (pic_UserPhoto.ImageLocation == null)
                        {
                                sp = new SqlParameter[]
                                { new SqlParameter("@TagNumber", SqlDbType.NVarChar, 50), 
                                  new SqlParameter("@UserName", SqlDbType.NVarChar,50),
                                  new SqlParameter("@UserCompany",SqlDbType.NVarChar,50),
                                  new SqlParameter("@UserTelephone", SqlDbType.NVarChar, 50),
                                  new SqlParameter("@UserAppellative", SqlDbType.NVarChar, 50)
                                    };
                        }
                        else
                        {
                                sp = new SqlParameter[]
                                { new SqlParameter("@TagNumber", SqlDbType.NVarChar, 50), 
                                  new SqlParameter("@UserName", SqlDbType.NVarChar,50),
                                  new SqlParameter("@UserCompany",SqlDbType.NVarChar,50),
                                  new SqlParameter("@UserTelephone", SqlDbType.NVarChar, 50),
                                  new SqlParameter("@UserAppellative", SqlDbType.NVarChar, 50),
                                  new SqlParameter("@UserPhoto", SqlDbType.Image)
                                    };
                        }
                        sp[0].Value = cmb_TagNumbers.SelectedItem.ToString().Trim();
                        sp[1].Value = txt_UserName.Text.Trim();
                        sp[2].Value = txt_UserCompany.Text.Trim();
                        sp[3].Value = txt_UserTelephone.Text.Trim();
                        sp[4].Value = txt_Appellative.Text.Trim();// rb_Male.Checked ? "先生" : "女士";
                        if (pic_UserPhoto.ImageLocation != null)
                        {
                                Byte[] imagedata;
                                using (FileStream fs = new FileStream(pic_UserPhoto.ImageLocation, FileMode.Open))
                                {
                                        imagedata = new Byte[fs.Length];
                                        fs.Read(imagedata, 0, imagedata.Length);
                                        fs.Close();
                                }
                                sp[5].Value = imagedata;
                        }

                        Int32 count;
                        if (pic_UserPhoto.ImageLocation == null)
                        {
                                count = SqlHelper.ExecuteNonQuery(SqlHelper.CONSTRING, CommandType.Text,
                                        "Update tbl_UserInfo Set UserName=@UserName,UserCompany=@UserCompany,UserTelephone=@UserTelephone,UserAppellative=@UserAppellative Where TagNumber=@TagNumber", sp);
                        }
                        else
                        {
                                count = SqlHelper.ExecuteNonQuery(SqlHelper.CONSTRING, CommandType.Text,
                                        "Update tbl_UserInfo Set UserName=@UserName,UserCompany=@UserCompany,UserTelephone=@UserTelephone,UserAppellative=@UserAppellative,UserPhoto=@UserPhoto Where TagNumber=@TagNumber", sp);
                        }
                        if (count > 0)
                        {
                                AddInfoDemo("修改成功。");
                                btn_InventoryDemo_Click(sender, e);
                        }
                        else
                        {
                                AddInfoDemo("修改失败。");
                        }
                }

                private void btn_Delete_Click(object sender, EventArgs e)
                {
                        if (cmb_TagNumbers.SelectedIndex < 0)
                        { AddInfoDemo("请选择要删除的用户"); cmb_TagNumbers.Focus(); return; }
                        SqlParameter[] sp ={ new SqlParameter("@TagNumber", SqlDbType.NVarChar, 50) };
                        sp[0].Value = cmb_TagNumbers.SelectedItem.ToString().Trim();

                        Int32 count;
                        count = SqlHelper.ExecuteNonQuery(SqlHelper.CONSTRING, CommandType.Text,
                                "Delete From tbl_UserInfo Where TagNumber=@TagNumber", sp);
                        if (count > 0)
                        {
                                AddInfoDemo("删除成功。");
                                btn_InventoryDemo_Click(sender, e);
                        }
                        else
                        {
                                AddInfoDemo("删除失败。");
                        }
                }

                private void btn_Browser_Click(object sender, EventArgs e)
                {
                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.RestoreDirectory = true;
                        //ofd.InitialDirectory = "|DataDirectory|";
                        ofd.Filter = "*.jpg|*.jpg|*.gif|*.gif|*.bmp|*.bmp|*.png|*.png";
                        ofd.CheckFileExists = true;
                        ofd.Multiselect = false;
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                                pic_UserPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                                pic_UserPhoto.ImageLocation = ofd.FileName;
                        }
                }

                private void btn_Monitor_Click(object sender, EventArgs e)
                {
                        if (btn_Monitor.Text.Trim().Equals("Start Monitor"))
                        {
                                if (!reader.IsOpen)
                                {
                                        AddInfoDemo("请先打开串口。");
                                        return;
                                }
                                if (IsMonitor)
                                        return;
                                IsMonitor = true;
                                btn_Clear_Info_Click(sender, e);
                                groupBox5.Enabled = false;
                                threadMonitor = new Thread(new ThreadStart(Monitor));
                                threadMonitor.IsBackground = true;
                                threadMonitor.Start();
                                btn_Monitor.Text = "Stop Monitor";
                                AddInfoDemo("您启动了自动监控。");
                        }
                        else
                        {
                                IsMonitor = false;
                                btn_Monitor.Text = "Start Monitor";
                                groupBox5.Enabled = true;
                                btn_Add.Enabled = false;
                                btn_Modify.Enabled = false;
                                btn_Delete.Enabled = false;
                        }
                }

                private void Monitor()
                {
                        Int32 TagCount = 0x00;
                        String[] TagNumbers=new String[0];
                        Byte result;
                        CurrentTagNumbers = new List<string>();
                        while (IsMonitor)
                        {
                                Thread.Sleep(500);
                                result = reader.Inventory(ModulateMethod.FSK, InventoryModel.Multiple, ref TagCount, ref TagNumbers);
                                //result = reader.GetAllTagsNum(out TagCount, out TagNumbers);
                                if (result != 0x00)
                                {
                                        ClearInfo();
                                        CurrentTagNumbers.Clear();
                                        //AddInfoDemo(String.Format("GetAllTagsNum命令执行失败，失败代码{0}。", result));
                                        continue;
                                }
                                if ((TagCount > 0) && (TagNumbers.Length > 0))
                                {
                                        foreach (String TagNumber in TagNumbers)
                                        {
                                                if (CurrentTagNumbers.IndexOf(TagNumber) < 0)
                                                {
                                                        ShowInfo(TagNumber);
                                                }
                                        }
                                        CurrentTagNumbers.Clear();
                                        foreach (String TagNumber in TagNumbers)
                                        {
                                                CurrentTagNumbers.Add(TagNumber);
                                        }
                                }
                                else
                                {
                                        ClearInfo();
                                        CurrentTagNumbers.Clear();
                                }
                        }
                        AddInfoDemo("您停止了自动监控。");
                }

                private void ClearInfo()
                {
                        if (lst_Info_Demo.InvokeRequired)
                        {
                                AddTagCallback d = new AddTagCallback(ClearInfo);
                                lst_Info_Demo.Invoke(d);
                        }
                        else
                        {
                                txt_UserName_Monitor.Clear();
                                txt_TagNumber_Monitor.Clear();
                                txt_Telephone_Monitor.Clear();
                                txt_Company_Monitor.Clear();
                                pic_Photo_Monitor.Image = null;
                        }
                }

                private void ShowInfo(String TagNumber)
                {

                        if (lst_Info_Demo.InvokeRequired)
                        {
                                AddListCallback d = new AddListCallback(ShowInfo);
                                lst_Info_Demo.Invoke(d, TagNumber);
                        }
                        else
                        {
                                SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.CONSTRING, CommandType.Text, String.Format("Select * From tbl_UserInfo Where TagNumber='{0}'", TagNumber));
                                if (dr.Read())
                                {
                                        txt_TagNumber_Monitor.Text = TagNumber;
                                        txt_Telephone_Monitor.Text = dr["UserTelephone"].ToString();
                                        txt_UserName_Monitor.Text = dr["UserName"].ToString();
                                        txt_Company_Monitor.Text = dr["UserCompany"].ToString();
                                        lst_Info_Demo.Items.Insert(0, String.Format("{0}:{2}({1}) 进入监控区域。", DateTime.Now.ToString(), TagNumber, dr["UserName"].ToString()));
                                        if (chk_Voice.Checked)
                                        {
                                                voice.Speak(String.Format("欢迎您，{0}。", dr["UserAppellative"].ToString().Trim()), spFlags);
                                        }
                                        if (dr["UserPhoto"] != null)
                                        {
                                                try
                                                {
                                                        Byte[] photo = (Byte[])dr[7];
                                                        if (photo.Length > 0)
                                                        {
                                                                System.IO.MemoryStream ms = new System.IO.MemoryStream(photo);
                                                                Bitmap bmp = new Bitmap(ms);
                                                                pic_Photo_Monitor.SizeMode = PictureBoxSizeMode.Zoom;
                                                                pic_Photo_Monitor.Image = bmp;
                                                        }
                                                        else
                                                        {
                                                                pic_Photo_Monitor.SizeMode = PictureBoxSizeMode.Zoom;
                                                                pic_Photo_Monitor.ImageLocation = "nonephoto.jpg";
                                                        }
                                                }
                                                catch
                                                {
                                                        pic_Photo_Monitor.SizeMode = PictureBoxSizeMode.Zoom;
                                                        pic_Photo_Monitor.ImageLocation = "nonephoto.jpg";
                                                }
                                        }
                                        else
                                        {
                                                pic_Photo_Monitor.SizeMode = PictureBoxSizeMode.Zoom;
                                                pic_Photo_Monitor.ImageLocation = "nonephoto.jpg";
                                        }
                                }
                                else
                                {
                                        txt_TagNumber_Monitor.Text = TagNumber;
                                        txt_Company_Monitor.Text = "无效卡";
                                        txt_UserName_Monitor.Text = "无效卡";
                                        txt_Telephone_Monitor.Text = "无效卡";
                                        if (chk_Voice.Checked)
                                        {
                                                voice.Speak("请您出示有效证件。", spFlags);
                                        }
                                        pic_Photo_Monitor.SizeMode = PictureBoxSizeMode.Zoom;
                                        pic_Photo_Monitor.ImageLocation = "invalid.jpg";
                                        lst_Info_Demo.Items.Insert(0, String.Format("{0}:陌生人({1}) 进入监控区域。", DateTime.Now.ToString(), TagNumber));
                                }
                        }
                }

                private void btn_Clear_Info_Click(object sender, EventArgs e)
                {
                        cmb_TagNumbers.Items.Clear();
                        cmb_TagNumbers.Text = "";
                        txt_UserName.Clear();
                        txt_UserTelephone.Clear();
                        txt_UserCompany.Clear();
                        txt_Appellative.Clear();
                        pic_UserPhoto.Image = null;
                        pic_UserPhoto.ImageLocation = null;
                        //rb_Male.Checked = true;
                }

                private void btn_Clear_14443_Click(object sender, EventArgs e)
                {
                        lsb_Info_14443.Items.Clear();
                        lsb_Info_14443.Refresh();
                }

                private void btn_Open_14443_Click(object sender, EventArgs e)
                {
                        if (iso14443Reader.ConnectType > 1)
                        {
                                ShowInfo14443(" 您已经打开了USB接口！");
                                return;
                        }
                        if (iso14443Reader.ConnectType > 0)
                        {
                                ShowInfo14443(" 您已经打开了串口！");
                                return;
                        }
                        if (cmb_PortNum_14443.SelectedIndex < 0)
                        {
                                ShowInfo14443("请选择串口");
                                cmb_PortNum_14443.Focus();
                                return;
                        }
                        if (cmb_BaudRate_14443.SelectedIndex < 0)
                        {
                                ShowInfo14443("请选择波特率");
                                cmb_BaudRate_14443.Focus();
                                return;
                        }
                        Byte result = iso14443Reader.OpenSerialPort(cmb_PortNum_14443.SelectedItem.ToString().Trim(), Int32.Parse(cmb_BaudRate_14443.SelectedItem.ToString()));
                        if (result == 0x00)
                        { ShowInfo14443("串口打开成功"); }
                        else
                        { ShowInfo14443("串口打开失败"); }
                }

                private void btn_Close_14443_Click(object sender, EventArgs e)
                {
                        if (iso14443Reader.ConnectType!=1)
                        {
                                ShowInfo14443("错误：串口尚未打开，无需关闭");
                                return;
                        }
                        Byte result = iso14443Reader.CloseSerialPort();
                        if (result == 0x00)
                        { ShowInfo14443("串口关闭成功"); }
                        else
                        { ShowInfo14443("串口关闭失败"); }
                }

                private void btn_ReqeustAll_14443_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443("错误：请先打开串口");
                                btn_Open_14443.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        Byte result = iso14443Reader.Request(0x00);
                        if (result == 0x00)
                        { ShowInfo14443("Request命令执行成功"); }
                        else
                        { ShowInfo14443("Request命令执行失败"); }
                }

                private void btn_RequestNotSleep_14443_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443("错误：请先打开串口");
                                btn_Open_14443.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        Byte result = iso14443Reader.Request(0x01);
                        if (result == 0x00)
                        { ShowInfo14443("Request命令执行成功"); }
                        else
                        { ShowInfo14443("Request命令执行失败"); }
                }

                private void btn_AntiColl_14443_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443("错误：请先打开串口");
                                btn_Open_14443.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        txt_Snr_14443.Clear();
                        Byte[] TagUID;
                        Byte result = iso14443Reader.AntiColl(0x00, out TagUID);
                        if (result == 0x00)
                        {
                                txt_Snr_14443.Text = ByteArrayToString(TagUID);
                                ShowInfo14443(String.Format("AntiColl命令执行成功，返回的UID为：{0}", txt_Snr_14443.Text));
                        }
                        else
                        { ShowInfo14443("AntiColl命令执行失败"); }
                }

                private void btn_Select_14443_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443("错误：请先打开串口");
                                btn_Open_14443.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        if (txt_Snr_14443.Text.Trim().Length < 1)
                        {
                                ShowInfo14443("错误：请使用Request命令和AntiColl命令寻卡");
                                btn_ReqeustAll_14443.Focus();
                                return;
                        }
                        Byte[] TagUID = StringToByteArray(txt_Snr_14443.Text.Trim());
                        Byte result = iso14443Reader.Select(TagUID);
                        if (result == 0x00)
                        {
                                ShowInfo14443(String.Format("Select命令执行成功"));
                        }
                        else
                        { ShowInfo14443("Select命令执行失败"); }
                }

                private void btn_AuthA_14443_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443("错误：请先打开串口");
                                btn_Open_14443.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        if (txt_Snr_14443.Text.Trim().Length < 1)
                        {
                                ShowInfo14443("错误：请使用Request命令和AntiColl命令寻卡");
                                btn_ReqeustAll_14443.Focus();
                                return;
                        }
                        Byte[] TagUID = StringToByteArray(txt_Snr_14443.Text.Trim());
                        Byte Address = 0x00;
                        try
                        { Address=Byte.Parse(txt_Addr_14443.Text.Trim()); }
                        catch
                        {
                                ShowInfo14443("错误：请写入正确的块地址(0~255)");
                                txt_Addr_14443.Focus();
                                return;
                        }
                        Byte[] Password = new Byte[0];
                        try
                        { Password = StringToByteArray(txt_KeyA_14443.Text.Trim()); }
                        catch
                        {
                                ShowInfo14443("错误：请写入正确密钥(十六进制形式的六个字节)");
                                txt_KeyA_14443.Focus();
                                return;
                        }
                        Byte result = iso14443Reader.Authentication(TagUID,Address, Password);
                        if (result == 0x00)
                        {
                                ShowInfo14443(String.Format("Authentication命令执行成功"));
                        }
                        else
                        { ShowInfo14443("Authentication命令执行失败"); }
                }

                private void btn_Read_14443_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443("错误：请先打开串口");
                                btn_Open_14443.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        if (txt_Snr_14443.Text.Trim().Length < 1)
                        {
                                ShowInfo14443("错误：请使用Request命令和AntiColl命令寻卡");
                                btn_ReqeustAll_14443.Focus();
                                return;
                        }
                        Byte[] TagUID = StringToByteArray(txt_Snr_14443.Text.Trim());
                        Byte Address = 0x00;
                        try
                        { Address = Byte.Parse(txt_Addr_14443.Text.Trim()); }
                        catch
                        {
                                ShowInfo14443("错误：请写入正确的块地址(0~255)");
                                txt_Addr_14443.Focus();
                                return;
                        }
                        //Byte[] Password = new Byte[0];
                        //try
                        //{ Password = StringToByteArray(txt_KeyA_14443.Text.Trim()); }
                        //catch
                        //{
                        //        ShowInfo14443("错误：请写入正确密钥(十六进制形式的六个字节)");
                        //        txt_KeyA_14443.Focus();
                        //        return;
                        //}
                        Byte[] ReadData;
                        Byte result = iso14443Reader.Read(Address,out ReadData);
                        if (result == 0x00)
                        {
                                txt_DataOut_14443.Text=ByteArrayToString(ReadData);
                                ShowInfo14443(String.Format("Read命令执行成功，读取到的数据为:{0}", txt_DataOut_14443.Text));
                        }
                        else
                        { ShowInfo14443("Read命令执行失败"); }
                }

                private void btn_Write_14443_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443("错误：请先打开串口");
                                btn_Open_14443.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        if (txt_Snr_14443.Text.Trim().Length < 1)
                        {
                                ShowInfo14443("错误：请使用Request命令和AntiColl命令寻卡");
                                btn_ReqeustAll_14443.Focus();
                                return;
                        }
                        Byte[] TagUID = StringToByteArray(txt_Snr_14443.Text.Trim());
                        Byte Address = 0x00;
                        try
                        { Address = Byte.Parse(txt_Addr_14443.Text.Trim()); }
                        catch
                        {
                                ShowInfo14443("错误：请写入正确的块地址(0~255)");
                                txt_Addr_14443.Focus();
                                return;
                        }
                        if (Address == 0) 
                        {
                                ShowInfo14443("错误：0块的数据是不能被改写的。");
                                txt_Addr_14443.Focus();
                                return;
                        }
                        if  ((Address % 4) == 3)
                        {
                                if (MessageBox.Show("每个扇区的最后一个数据块是密钥和存取控制。\r\n错误的修改可能会导致该扇区的报废。\r\n您确认要对这个块的数据进行修改吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                                {
                                        return;
                                }
                        }
                        Byte[] WriteData = new Byte[0];
                        try
                        { WriteData = StringToByteArray(txt_DataIn_14443 .Text.Trim()); }
                        catch
                        {
                                ShowInfo14443("错误：请填写正确的数据(十六进制形式的十六个字节)");
                                txt_DataIn_14443.Focus();
                                return;
                        }
                        Byte result = iso14443Reader.Write(Address, WriteData);
                        if (result == 0x00)
                        {
                                ShowInfo14443(String.Format("Write命令执行成功"));
                        }
                        else
                        { ShowInfo14443("Write命令执行失败"); }
                }

                private void btn_Refresh_14443_Click(object sender, EventArgs e)
                {
                        RefreshCom();
                }

                private void btn_OpenHIDDevice_Click(object sender, EventArgs e)
                {
                        if (reader.ConnectType > 1)
                        {
                                AddList(" 您已经打开了USB接口！");
                                return;
                        }
                        if (reader.ConnectType > 0)
                        {
                                AddList(" 您已经打开了串口！");
                                return;
                        }
                        if (reader.OpenHIDDevice() == 0x00)
                        {
                                AddList("USB 接口打开成功！");
                                rb_Inventory.Checked = true;
                        }
                        else
                        {
                                AddList("USB 接口打开失败！");
                        }
                }

                private void btn_CloseHIDDevice_Click(object sender, EventArgs e)
                {
                        if (reader.ConnectType != 2)
                        {
                                AddList(" 您并未打开USB接口！");
                                return;
                        }
                        if (reader.CloseHIDDevice() == 0x00)
                        {
                                AddList("USB 接口关闭成功！");
                        }
                        else
                        {
                                AddList("USB 接口关闭失败！");
                        }
                }

                private void btn_OpenUSB_Click(object sender, EventArgs e)
                {
                        if (iso14443Reader.ConnectType > 1)
                        {
                                ShowInfo14443(" 您已经打开了USB接口！");
                                return;
                        }
                        if (iso14443Reader.ConnectType > 0)
                        {
                                ShowInfo14443(" 您已经打开了串口！");
                                return;
                        }
                        if (iso14443Reader.OpenHIDDevice() == 0x00)
                        {
                                ShowInfo14443("USB 接口打开成功！");
                                rb_Inventory.Checked = true;
                        }
                        else
                        {
                                ShowInfo14443("USB 接口打开失败！");
                        }
                }

                private void btn_CloseUSB_Click(object sender, EventArgs e)
                {
                        if (iso14443Reader.ConnectType != 2)
                        {
                                ShowInfo14443(" 您并未打开USB接口！");
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        } 
                        if (iso14443Reader.CloseHIDDevice() == 0x00)
                        {
                                ShowInfo14443("USB 接口关闭成功！");
                        }
                        else
                        {
                                ShowInfo14443("USB 接口关闭失败！");
                        }

                }

                private void btn_Inventory_14443_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443("错误：请先打开串口");
                                btn_Open_14443.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        txt_Snr_14443.Clear();
                        Byte[] TagUID;
                        Byte result = iso14443Reader.Inventory(0x00, out TagUID);
                        if (result == 0x00)
                        {
                                txt_Snr_14443.Text = ByteArrayToString(TagUID);
                                ShowInfo14443(String.Format("Inventory命令执行成功，返回的UID为：{0}", txt_Snr_14443.Text));
                        }
                        else
                        { ShowInfo14443("Inventory命令执行失败"); }
                }

                private void btn_FastInventory_Click(object sender, EventArgs e)
                {
                        if (btn_FastInventory.Text.Equals("开始快速寻卡"))
                        {
                                if (!iso14443Reader.IsOpen)
                                {
                                        ShowInfo14443("错误：请先打开串口");
                                        btn_Open_14443.Focus();
                                        return;
                                }
                                if (iso14443Reader.IsAutoInventory)
                                {
                                        ShowInfo14443("错误：已经处于快速寻卡状态");
                                        return;
                                }
                                if (strTagUIDs == null)
                                { strTagUIDs = new List<string>(); }
                                else
                                { strTagUIDs.Clear(); }
                                if (intReadCount == null)
                                { intReadCount = new List<int>(); }
                                else
                                { intReadCount.Clear(); }
                                SucceedCount = 0;
                                FailedCount = 0;
                                iso14443Reader.StartAutoInventory();
                                btn_FastInventory.Text = "停止快速寻卡";
                                StartTime = DateTime.Now;
                                ShowInfo14443(String.Format("您启动了快速寻卡"));
                        }
                        else
                        {
                                if (!iso14443Reader.IsAutoInventory)
                                {
                                        ShowInfo14443("错误：尚未进入快速寻卡状态");
                                        return;
                                }
                                iso14443Reader.EndAutoInventory();

                                EndTime = DateTime.Now;
                                btn_FastInventory.Text = "开始快速寻卡";
                                ShowInfo14443(String.Format("您停止了快速寻卡"));
                                TimeSpan ts = EndTime.Subtract(StartTime);
                                ShowInfo14443(String.Format("累计读卡时间{0}ms，成功读取{1}次，失败{2}次，平均读卡时间{3}ms.", ts.TotalMilliseconds, SucceedCount, FailedCount, ts.TotalMilliseconds / (SucceedCount + FailedCount)));
                                ShowInfo14443(String.Format("成功读取到卡片{0}张，详细信息如下：", strTagUIDs.Count));
                                for (int i = 0; i < strTagUIDs.Count; i++)
                                {
                                        ShowInfo14443(String.Format("卡片{2}:({0})被成功读取{1}次", strTagUIDs[i], intReadCount[i], i));
                                }
                                txt_Count_14443.Text = strTagUIDs.Count.ToString();
                                if (strTagUIDs.Count > 0)
                                        txt_Snr_14443.Text = strTagUIDs[0];
                        }
                }

                Int32 SucceedCount = 0, FailedCount = 0;
                DateTime StartTime,EndTime;
                List<String> strTagUIDs;
                List<Int32> intReadCount;

                void iso14443Reader_TagDetected(string TagUID, byte StateCode)
                {
                        switch (StateCode)
                        {
                                case 0x00:
                                    if (TagUID.Length > 0)
                                    {
                                        ShowInfo14443(String.Format("成功读取到标签:{0}", TagUID));
                                        int index = strTagUIDs.IndexOf(TagUID);
                                        if (index < 0)
                                        {
                                                lock (strTagUIDs)
                                                {
                                                        strTagUIDs.Add(TagUID);
                                                        intReadCount.Add(1);
                                                        ShowCount14443(strTagUIDs.Count.ToString());
                                                }
                                        }
                                        else
                                        { intReadCount[index]++; }
                                        SucceedCount++;
                                    }
                                        break;
                                case 0x01:
                                        ShowInfo14443(String.Format("读卡失败，原因是请求卡失败"));
                                        FailedCount++;
                                        break;
                                case 0x02:
                                        ShowInfo14443(String.Format("读卡失败，原因是寻卡失败"));
                                        FailedCount++; 
                                        break;
                                default:
                                        ShowInfo14443(String.Format("读卡失败，原因是指令执行失败"));
                                        FailedCount++; 
                                        break;
                        }
                }

                private void btn_RemoveAll_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsAutoInventory)
                                return;
                        StartTime = DateTime.Now;
                        lock (strTagUIDs)
                        {
                                SucceedCount = 0;
                                FailedCount = 0;

                                strTagUIDs.Clear();
                                intReadCount.Clear();
                        }
                }

                private void btn_Clear_14443_B_Click(object sender, EventArgs e)
                {
                        lsb_Info_14443_B.Items.Clear();
                        lsb_Info_14443_B.Refresh();
                }

                private void btn_Open_14443B_Click(object sender, EventArgs e)
                {
                        if (iso14443Reader.ConnectType > 1)
                        {
                                ShowInfo14443B(" 您已经打开了USB接口！");
                                return;
                        }
                        if (iso14443Reader.ConnectType > 0)
                        {
                                ShowInfo14443B(" 您已经打开了串口！");
                                return;
                        }
                        if (cmb_PortNum_14443B.SelectedIndex < 0)
                        {
                                ShowInfo14443B("请选择串口");
                                cmb_PortNum_14443B.Focus();
                                return;
                        }
                        if (cmb_BaudRate_14443B.SelectedIndex < 0)
                        {
                                ShowInfo14443B("请选择波特率");
                                cmb_BaudRate_14443B.Focus();
                                return;
                        }
                        Byte result = iso14443Reader.OpenSerialPort(cmb_PortNum_14443B.SelectedItem.ToString().Trim(), Int32.Parse(cmb_BaudRate_14443B.SelectedItem.ToString()));
                        if (result == 0x00)
                        { ShowInfo14443B("串口打开成功"); }
                        else
                        { ShowInfo14443B("串口打开失败"); }
                }

                private void btn_Close_14443B_Click(object sender, EventArgs e)
                {
                        if (iso14443Reader.ConnectType != 1)
                        {
                                ShowInfo14443B("错误：串口尚未打开，无需关闭");
                                return;
                        }
                        Byte result = iso14443Reader.CloseSerialPort();
                        if (result == 0x00)
                        { ShowInfo14443B("串口关闭成功"); }
                        else
                        { ShowInfo14443B("串口关闭失败"); }
                }

                private void btn_Refresh_14443B_Click(object sender, EventArgs e)
                {
                        RefreshCom();
                }

                private void btn_OpenUSBB_Click(object sender, EventArgs e)
                {
                        if (iso14443Reader.ConnectType > 1)
                        {
                                ShowInfo14443B(" 您已经打开了USB接口！");
                                return;
                        }
                        if (iso14443Reader.ConnectType > 0)
                        {
                                ShowInfo14443B(" 您已经打开了串口！");
                                return;
                        }
                        if (iso14443Reader.OpenHIDDevice() == 0x00)
                        {
                                ShowInfo14443B("USB 接口打开成功！");
                                rb_Inventory.Checked = true;
                        }
                        else
                        {
                                ShowInfo14443B("USB 接口打开失败！");
                        }
                }

                private void btn_CloseUSBB_Click(object sender, EventArgs e)
                {
                        if (iso14443Reader.ConnectType != 2)
                        {
                                ShowInfo14443B(" 您并未打开USB接口！");
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443B(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        if (iso14443Reader.CloseHIDDevice() == 0x00)
                        {
                                ShowInfo14443B("USB 接口关闭成功！");
                        }
                        else
                        {
                                ShowInfo14443B("USB 接口关闭失败！");
                        }
                }

                private void btn_ReqestB_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443B("错误：请先打开串口");
                                btn_Open_14443B.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443B(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        Byte[] TagUID;
                        Byte result = iso14443Reader.B_Inventory(0x01, out TagUID);
                        if (result == 0x00)
                        {
                                txt_UIDB.Text = ByteArrayToString(TagUID);
                                ShowInfo14443B(String.Format("寻卡命令执行成功，返回的UID为：{0}", txt_UIDB.Text));
                        }
                        else
                        { ShowInfo14443B("寻卡命令执行失败"); }
                }

                private void btn_AttribB_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443B("错误：请先打开串口");
                                btn_Open_14443B.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443B(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        if (txt_UIDB.Text.Trim().Length < 1)
                        {
                                ShowInfo14443B("错误：请先使用寻卡命令寻卡");
                                return;
                        }
                        Byte[] TagUID = StringToByteArray(txt_UIDB.Text.Trim());
                        Byte result = iso14443Reader.B_Select(TagUID);
                        if (result == 0x00)
                        {
                                ShowInfo14443B(String.Format("选择命令执行成功"));
                        }
                        else
                        { ShowInfo14443B("选择命令执行失败"); }
                }

                private void btn_HaltB_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443B("错误：请先打开串口");
                                btn_Open_14443B.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443B(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        if (txt_UIDB.Text.Trim().Length < 1)
                        {
                                ShowInfo14443B("错误：请先使用寻卡命令寻卡");
                                return;
                        }
                        Byte[] TagUID = StringToByteArray(txt_UIDB.Text.Trim());
                        Byte result = iso14443Reader.B_Halt(TagUID);
                        if (result == 0x00)
                        {
                                ShowInfo14443B(String.Format("挂起命令执行成功"));
                        }
                        else
                        { ShowInfo14443B("挂起命令执行失败"); }
                }

                private void btn_WakeUpB_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443B("错误：请先打开串口");
                                btn_Open_14443B.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443B(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        Byte[] TagUID;
                        Byte result = iso14443Reader.B_WakeUp(0x00, out TagUID);
                        if (result == 0x00)
                        {
                                txt_UIDB.Text = ByteArrayToString(TagUID);
                                ShowInfo14443B(String.Format("唤醒命令执行成功，返回的UID为：{0}", txt_UIDB.Text));
                        }
                        else
                        { ShowInfo14443B("唤醒命令执行失败"); }
                }

                private void btn_ReqestAllB_Click(object sender, EventArgs e)
                {
                        if (!iso14443Reader.IsOpen)
                        {
                                ShowInfo14443B("错误：请先打开串口");
                                btn_Open_14443B.Focus();
                                return;
                        }
                        if (iso14443Reader.IsAutoInventory)
                        {
                                ShowInfo14443B(" 请先停止快速读卡以后在操作！");
                                return;
                        }
                        Byte[] TagUID;
                        Byte result = iso14443Reader.B_Inventory(0x00, out TagUID);
                        if (result == 0x00)
                        {
                                txt_UIDB.Text = ByteArrayToString(TagUID);
                                ShowInfo14443B(String.Format("寻卡命令执行成功，返回的UID为：{0}", txt_UIDB.Text));
                        }
                        else
                        { ShowInfo14443B("寻卡命令执行失败"); }
                }






                //private void btn_FastInventory_Click(object sender, EventArgs e)
                //{
                //        if (btn_FastInventory.Text.Equals("开始快速寻卡"))
                //        {
                //                if (!iso14443Reader.IsOpen)
                //                {
                //                        ShowInfo14443("错误：请先打开串口");
                //                        btn_Open_14443.Focus();
                //                        return;
                //                }
                //                Thread thread;
                //                if (rb_Simple.Checked)
                //                { thread = new Thread(new ThreadStart(threadSimple)); }
                //                else
                //                { thread = new Thread(new ThreadStart(threadDetailed)); }
                //                IsFastInventory = true;
                //                thread.IsBackground = true;
                //                thread.Start();
                //                btn_FastInventory.Text = "停止快速寻卡";
                //                rb_Simple.Enabled = false;
                //                rb_Detailed.Enabled = false;
                //        }
                //        else
                //        {
                //                IsFastInventory = false;
                //                btn_FastInventory.Text = "开始快速寻卡";
                //                rb_Simple.Enabled = true;
                //                rb_Detailed.Enabled = true;
                //        }
                //}


                //private void threadSimple()
                //{
                //        //try
                //        //{
                //                Int32 SucceedCount=0, FailedCount=0;
                //                Byte[] TagUID;
                //                Byte result;
                //                DateTime StartTime = DateTime.Now ;
                //                ShowInfo14443(String.Format("{0}:您启动了快速寻卡", StartTime.ToLongTimeString()));
                //                while (IsFastInventory)
                //                {
                //                        result = iso14443Reader.Inventory(0x00, out TagUID);
                //                        if (result == 0x00)
                //                        {
                //                                //txt_Snr_14443.Text = ByteArrayToString(TagUID);
                //                                ShowInfo14443(String.Format("Inventory命令执行成功，返回的UID为：{0}", ByteArrayToString(TagUID)));
                //                                SucceedCount++;
                //                        }
                //                        else
                //                        { ShowInfo14443("Inventory命令执行失败，请检查天线厂区内是否有卡"); FailedCount++;}
                //                }
                //                DateTime EndTime = DateTime.Now;
                //                ShowInfo14443(String.Format("{0}:您停止了快速寻卡", EndTime.ToLongTimeString()));
                //                TimeSpan ts = EndTime.Subtract(StartTime);
                //                ShowInfo14443(String.Format("累计读卡时间{0}ms，成功读取{1}次，失败{2}次，平均读卡时间{3}ms", ts.TotalMilliseconds,SucceedCount,FailedCount,ts.TotalMilliseconds/(SucceedCount+FailedCount)));                                
                //                //}
                //        //catch { }
                //}

                //private void threadDetailed()
                //{
                //        Int32 SucceedCount = 0, FailedCount = 0;
                //        Byte[] TagUID;
                //        Byte result;
                //        DateTime StartTime = DateTime.Now;
                //        List<String> strTagUIDs = new List<string>();
                //        List<Int32> intReadCount = new List<int>();
                //        String strTagUID;
                //        Int32 index;
                //        ShowInfo14443(String.Format("{0}:您启动了快速寻卡", StartTime.ToLongTimeString()));
                //        while (IsFastInventory)
                //        {
                //                result = iso14443Reader.Inventory(0x00, out TagUID);
                //                if (result == 0x00)
                //                {
                //                       strTagUID=ByteArrayToString(TagUID);
                //                       ShowInfo14443(String.Format("Inventory命令执行成功，返回的UID为：{0}", strTagUID));
                //                       index = strTagUIDs.IndexOf(strTagUID);
                //                       if (index < 0)
                //                       { strTagUIDs.Add(strTagUID); intReadCount.Add(1); }
                //                       else
                //                       { intReadCount[index]++; }
                //                        SucceedCount++;
                //                }
                //                else
                //                { ShowInfo14443("Inventory命令执行失败，请检查天线厂区内是否有卡"); FailedCount++; }
                //        }
                //        DateTime EndTime = DateTime.Now;
                //        ShowInfo14443(String.Format("{0}:您停止了快速寻卡", EndTime.ToLongTimeString()));
                //        TimeSpan ts = EndTime.Subtract(StartTime);
                //        ShowInfo14443(String.Format("累计读卡时间{0}ms，成功读取{1}次，失败{2}次，平均读卡时间{3}ms，详细信息如下：", ts.TotalMilliseconds, SucceedCount, FailedCount, ts.TotalMilliseconds / (SucceedCount + FailedCount)));
                //        for (int i = 0; i < strTagUIDs.Count; i++)
                //        {
                //                ShowInfo14443(String.Format("卡片({0})被成功读取{1}次", strTagUIDs[i],intReadCount[i]));
                //        }
                //}



        }
}