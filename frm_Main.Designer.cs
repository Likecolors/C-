namespace HFReader
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_OpenCloseComm = new System.Windows.Forms.GroupBox();
            this.btn_RefreshComm = new System.Windows.Forms.Button();
            this.btn_CloseComm = new System.Windows.Forms.Button();
            this.btn_OpenComm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Parity = new System.Windows.Forms.TextBox();
            this.txt_StopBits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DataBits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_PortNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_OpenCloseHID = new System.Windows.Forms.GroupBox();
            this.btn_CloseHIDDevice = new System.Windows.Forms.Button();
            this.btn_OpenHIDDevice = new System.Windows.Forms.Button();
            this.gb_AutoRcv = new System.Windows.Forms.GroupBox();
            this.btn_AutoRcv = new System.Windows.Forms.Button();
            this.gb_Inventory = new System.Windows.Forms.GroupBox();
            this.btn_AutoRun = new System.Windows.Forms.Button();
            this.lst_InventoryResult = new System.Windows.Forms.ListBox();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_ASK = new System.Windows.Forms.RadioButton();
            this.rb_FSK = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_Multi = new System.Windows.Forms.RadioButton();
            this.rb_Single = new System.Windows.Forms.RadioButton();
            this.gb_WriteSingleBlock = new System.Windows.Forms.GroupBox();
            this.cmd_Length_2 = new System.Windows.Forms.ComboBox();
            this.btn_WriteSingleBlock = new System.Windows.Forms.Button();
            this.txt_WriteData_2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_UID_2 = new System.Windows.Forms.ComboBox();
            this.txt_Address_2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gb_GetAll = new System.Windows.Forms.GroupBox();
            this.btn_ClearAutoGetAllResult = new System.Windows.Forms.Button();
            this.btn_AutoGetAll = new System.Windows.Forms.Button();
            this.txt_GetAllResult = new System.Windows.Forms.TextBox();
            this.lst_GetAllResult = new System.Windows.Forms.ListBox();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.gb_EnableBuzzer = new System.Windows.Forms.GroupBox();
            this.label44 = new System.Windows.Forms.Label();
            this.rb_Flag_False = new System.Windows.Forms.RadioButton();
            this.rb_Flag_True = new System.Windows.Forms.RadioButton();
            this.btn_EnableBuzzer = new System.Windows.Forms.Button();
            this.gb_GetMulti = new System.Windows.Forms.GroupBox();
            this.txt_Address_14 = new System.Windows.Forms.TextBox();
            this.lst_Result2 = new System.Windows.Forms.ListBox();
            this.btn_GetMulti = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.cmb_UID_14 = new System.Windows.Forms.ComboBox();
            this.txt_Number_14 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.gb_GetSystemInfo = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txt_UID = new System.Windows.Forms.TextBox();
            this.txt_VICC = new System.Windows.Forms.TextBox();
            this.txt_DSFID_2 = new System.Windows.Forms.TextBox();
            this.txt_AFI_2 = new System.Windows.Forms.TextBox();
            this.txt_ICRef = new System.Windows.Forms.TextBox();
            this.txt_Info = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.btn_GetSystemInfo = new System.Windows.Forms.Button();
            this.cmb_UID_13 = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.gb_LockDSFID = new System.Windows.Forms.GroupBox();
            this.btn_LockDSFID = new System.Windows.Forms.Button();
            this.cmb_UID_12 = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.gb_WriteDSFID = new System.Windows.Forms.GroupBox();
            this.btn_WriteDSFID = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_DSFID = new System.Windows.Forms.TextBox();
            this.cmb_UID_11 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.gb_LockAFI = new System.Windows.Forms.GroupBox();
            this.btn_LockAFI = new System.Windows.Forms.Button();
            this.cmb_UID_10 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.gb_WriteAFI = new System.Windows.Forms.GroupBox();
            this.btn_WriteAFI = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_AFI = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cmb_UID_9 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.gb_ResetToReady = new System.Windows.Forms.GroupBox();
            this.btn_ResetToReady = new System.Windows.Forms.Button();
            this.cmb_Mode = new System.Windows.Forms.ComboBox();
            this.cmb_UID_8 = new System.Windows.Forms.ComboBox();
            this.lbl_UID = new System.Windows.Forms.Label();
            this.gb_Select = new System.Windows.Forms.GroupBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.cmb_UID_7 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.gb_StayQuiet = new System.Windows.Forms.GroupBox();
            this.btn_StayQuiet = new System.Windows.Forms.Button();
            this.cmb_UID_6 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.gb_LockBlock = new System.Windows.Forms.GroupBox();
            this.btn_LockSingleBlock = new System.Windows.Forms.Button();
            this.cmb_UID_5 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Address_5 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.gb_WriteMultiBlock = new System.Windows.Forms.GroupBox();
            this.txt_WriteData_4 = new System.Windows.Forms.RichTextBox();
            this.btn_WriteMultiBlock = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_Number_4 = new System.Windows.Forms.TextBox();
            this.txt_Address_4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmd_Length_4 = new System.Windows.Forms.ComboBox();
            this.cmb_UID_4 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gb_ReadMultiBlock = new System.Windows.Forms.GroupBox();
            this.lst_Result = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Number_3 = new System.Windows.Forms.TextBox();
            this.btn_ReadMultiBlock = new System.Windows.Forms.Button();
            this.cmd_Length_3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_UID_3 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Address_3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gb_ReadSingleBlock = new System.Windows.Forms.GroupBox();
            this.txt_Result_1 = new System.Windows.Forms.TextBox();
            this.cmd_Length_1 = new System.Windows.Forms.ComboBox();
            this.btn_ReadSingleBlock = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Address_1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_UID_1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_OpenCloseHID = new System.Windows.Forms.RadioButton();
            this.rb_AutoRcv = new System.Windows.Forms.RadioButton();
            this.rb_EnableBuzzer = new System.Windows.Forms.RadioButton();
            this.rb_GetAll = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_ReadMultiBlock = new System.Windows.Forms.RadioButton();
            this.rb_WriteSingleBlock = new System.Windows.Forms.RadioButton();
            this.rb_GetMultiBlockSec = new System.Windows.Forms.RadioButton();
            this.rb_GetSystemInfo = new System.Windows.Forms.RadioButton();
            this.rb_LockDSFID = new System.Windows.Forms.RadioButton();
            this.rb_WriteDSFID = new System.Windows.Forms.RadioButton();
            this.rb_LockAFI = new System.Windows.Forms.RadioButton();
            this.rb_WriteAFI = new System.Windows.Forms.RadioButton();
            this.rb_ResetToReady = new System.Windows.Forms.RadioButton();
            this.rb_Select = new System.Windows.Forms.RadioButton();
            this.rb_StayQuiet = new System.Windows.Forms.RadioButton();
            this.rb_LockBlock = new System.Windows.Forms.RadioButton();
            this.rb_WriteMultiBlock = new System.Windows.Forms.RadioButton();
            this.rb_ReadSingleBolock = new System.Windows.Forms.RadioButton();
            this.rb_Inventory = new System.Windows.Forms.RadioButton();
            this.rb_OpenCloseComm = new System.Windows.Forms.RadioButton();
            this.btn_ClearListBox1 = new System.Windows.Forms.Button();
            this.lst_Info = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.cmb_BaudRate1 = new System.Windows.Forms.ComboBox();
            this.label76 = new System.Windows.Forms.Label();
            this.cmb_PortName = new System.Windows.Forms.ComboBox();
            this.label75 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_ChannelConfig = new System.Windows.Forms.RadioButton();
            this.rb_MultiplexConfig = new System.Windows.Forms.RadioButton();
            this.rb_TagItConfig = new System.Windows.Forms.RadioButton();
            this.rb_ICodeConfig = new System.Windows.Forms.RadioButton();
            this.rb_TimingConfig = new System.Windows.Forms.RadioButton();
            this.rb_ReaderConfig = new System.Windows.Forms.RadioButton();
            this.lst_Info_Cfg = new System.Windows.Forms.ListBox();
            this.gb_ReaderConfig = new System.Windows.Forms.GroupBox();
            this.btn_SetReader = new System.Windows.Forms.Button();
            this.btn_GetReader = new System.Windows.Forms.Button();
            this.btn_LoadReader = new System.Windows.Forms.Button();
            this.txt_EOFASK_2 = new System.Windows.Forms.TextBox();
            this.txt_SOFASK_2 = new System.Windows.Forms.TextBox();
            this.txt_EOFFSK_2 = new System.Windows.Forms.TextBox();
            this.txt_SOFFSK_2 = new System.Windows.Forms.TextBox();
            this.txt_EOFASK_1 = new System.Windows.Forms.TextBox();
            this.txt_SOFASK_1 = new System.Windows.Forms.TextBox();
            this.txt_EOFFSK_1 = new System.Windows.Forms.TextBox();
            this.txt_SOFFSK_1 = new System.Windows.Forms.TextBox();
            this.txt_SOFEOF = new System.Windows.Forms.TextBox();
            this.txt_ISOASK = new System.Windows.Forms.TextBox();
            this.txt_ISOFSK = new System.Windows.Forms.TextBox();
            this.txt_RealTimeClock = new System.Windows.Forms.TextBox();
            this.txt_Index = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.txt_Energy = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.txt_TempReset = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txt_TempAlarm = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.gb_MultiplexConfig = new System.Windows.Forms.GroupBox();
            this.btn_Switch = new System.Windows.Forms.Button();
            this.txt_Antenna = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.chk_PhaseShift = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_MultiplexGates = new System.Windows.Forms.RadioButton();
            this.rb_SingleAxisGate = new System.Windows.Forms.RadioButton();
            this.rb_SingleAntenna = new System.Windows.Forms.RadioButton();
            this.label72 = new System.Windows.Forms.Label();
            this.btn_SetMultiplex = new System.Windows.Forms.Button();
            this.btn_GetMultiplex = new System.Windows.Forms.Button();
            this.btn_LoadMultiplex = new System.Windows.Forms.Button();
            this.txt_AntennaTries = new System.Windows.Forms.TextBox();
            this.txt_AntennaCount = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.gb_TagItConfig = new System.Windows.Forms.GroupBox();
            this.txt_EndOfFrame_2 = new System.Windows.Forms.TextBox();
            this.txt_StartOfFrame_2 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.btn_SetTagIt = new System.Windows.Forms.Button();
            this.btn_GetTagIt = new System.Windows.Forms.Button();
            this.btn_LoadTagIt = new System.Windows.Forms.Button();
            this.txt_EndOfFrame_1 = new System.Windows.Forms.TextBox();
            this.txt_StartOfFrame_1 = new System.Windows.Forms.TextBox();
            this.txt_CollisionMarginTagIt = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.gb_ICodeConfig = new System.Windows.Forms.GroupBox();
            this.label63 = new System.Windows.Forms.Label();
            this.btn_SetICode = new System.Windows.Forms.Button();
            this.btn_GetICode = new System.Windows.Forms.Button();
            this.btn_LoadICode = new System.Windows.Forms.Button();
            this.txt_Tuning = new System.Windows.Forms.TextBox();
            this.txt_CollisionMarginICode = new System.Windows.Forms.TextBox();
            this.txt_NoiseMargin = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.gb_TimingConfig = new System.Windows.Forms.GroupBox();
            this.cmb_EASTagType = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.btn_SetTiming = new System.Windows.Forms.Button();
            this.btn_GetTiming = new System.Windows.Forms.Button();
            this.btn_LoadTiming = new System.Windows.Forms.Button();
            this.txt_ASKRef_2 = new System.Windows.Forms.TextBox();
            this.txt_ASKTiming_2 = new System.Windows.Forms.TextBox();
            this.txt_FSKTiming_2 = new System.Windows.Forms.TextBox();
            this.txt_ASKRef_1 = new System.Windows.Forms.TextBox();
            this.txt_ASKTiming_1 = new System.Windows.Forms.TextBox();
            this.txt_FSKTiming_1 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Clear_Demo = new System.Windows.Forms.Button();
            this.lst_Info_Demo = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chk_Voice = new System.Windows.Forms.CheckBox();
            this.txt_TagNumber_Monitor = new System.Windows.Forms.TextBox();
            this.pic_Photo_Monitor = new System.Windows.Forms.PictureBox();
            this.btn_Monitor = new System.Windows.Forms.Button();
            this.txt_Company_Monitor = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.txt_Telephone_Monitor = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.txt_UserName_Monitor = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_Appellative = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.btn_Clear_Info = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Browser = new System.Windows.Forms.Button();
            this.pic_UserPhoto = new System.Windows.Forms.PictureBox();
            this.txt_UserTelephone = new System.Windows.Forms.TextBox();
            this.txt_UserCompany = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.btn_InventoryDemo = new System.Windows.Forms.Button();
            this.cmb_TagNumbers = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Refresh_Demo = new System.Windows.Forms.Button();
            this.btn_Close_Demo = new System.Windows.Forms.Button();
            this.btn_Open_Demo = new System.Windows.Forms.Button();
            this.cmb_BaudRate_Demo = new System.Windows.Forms.ComboBox();
            this.label80 = new System.Windows.Forms.Label();
            this.cmb_PortName_Demo = new System.Windows.Forms.ComboBox();
            this.label81 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Clear_14443 = new System.Windows.Forms.Button();
            this.lsb_Info_14443 = new System.Windows.Forms.ListBox();
            this.groupBox4_14443 = new System.Windows.Forms.GroupBox();
            this.txt_DataOut_14443 = new System.Windows.Forms.TextBox();
            this.btn_Read_14443 = new System.Windows.Forms.Button();
            this.btn_Write_14443 = new System.Windows.Forms.Button();
            this.txt_DataIn_14443 = new System.Windows.Forms.TextBox();
            this.groupBox3_14443 = new System.Windows.Forms.GroupBox();
            this.label92 = new System.Windows.Forms.Label();
            this.txt_Addr_14443 = new System.Windows.Forms.TextBox();
            this.txt_KeyA_14443 = new System.Windows.Forms.TextBox();
            this.label91 = new System.Windows.Forms.Label();
            this.btn_AuthA_14443 = new System.Windows.Forms.Button();
            this.groupBox2_14443 = new System.Windows.Forms.GroupBox();
            this.btn_RemoveAll = new System.Windows.Forms.Button();
            this.btn_FastInventory = new System.Windows.Forms.Button();
            this.btn_Inventory_14443 = new System.Windows.Forms.Button();
            this.btn_Select_14443 = new System.Windows.Forms.Button();
            this.label93 = new System.Windows.Forms.Label();
            this.btn_ReqeustAll_14443 = new System.Windows.Forms.Button();
            this.btn_RequestNotSleep_14443 = new System.Windows.Forms.Button();
            this.btn_AntiColl_14443 = new System.Windows.Forms.Button();
            this.txt_Count_14443 = new System.Windows.Forms.TextBox();
            this.txt_Snr_14443 = new System.Windows.Forms.TextBox();
            this.groupBox1_14443 = new System.Windows.Forms.GroupBox();
            this.btn_CloseUSB = new System.Windows.Forms.Button();
            this.btn_OpenUSB = new System.Windows.Forms.Button();
            this.btn_Refresh_14443 = new System.Windows.Forms.Button();
            this.cmb_BaudRate_14443 = new System.Windows.Forms.ComboBox();
            this.btn_Close_14443 = new System.Windows.Forms.Button();
            this.btn_Open_14443 = new System.Windows.Forms.Button();
            this.cmb_PortNum_14443 = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_ReqestB = new System.Windows.Forms.Button();
            this.label94 = new System.Windows.Forms.Label();
            this.btn_WakeUpB = new System.Windows.Forms.Button();
            this.btn_HaltB = new System.Windows.Forms.Button();
            this.btn_AttribB = new System.Windows.Forms.Button();
            this.btn_ReqestAllB = new System.Windows.Forms.Button();
            this.txt_UIDB = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btn_CloseUSBB = new System.Windows.Forms.Button();
            this.btn_OpenUSBB = new System.Windows.Forms.Button();
            this.btn_Refresh_14443B = new System.Windows.Forms.Button();
            this.cmb_BaudRate_14443B = new System.Windows.Forms.ComboBox();
            this.btn_Close_14443B = new System.Windows.Forms.Button();
            this.btn_Open_14443B = new System.Windows.Forms.Button();
            this.cmb_PortNum_14443B = new System.Windows.Forms.ComboBox();
            this.btn_Clear_14443_B = new System.Windows.Forms.Button();
            this.lsb_Info_14443_B = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label78 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label79 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_OpenCloseComm.SuspendLayout();
            this.gb_OpenCloseHID.SuspendLayout();
            this.gb_AutoRcv.SuspendLayout();
            this.gb_Inventory.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_WriteSingleBlock.SuspendLayout();
            this.gb_GetAll.SuspendLayout();
            this.gb_EnableBuzzer.SuspendLayout();
            this.gb_GetMulti.SuspendLayout();
            this.gb_GetSystemInfo.SuspendLayout();
            this.gb_LockDSFID.SuspendLayout();
            this.gb_WriteDSFID.SuspendLayout();
            this.gb_LockAFI.SuspendLayout();
            this.gb_WriteAFI.SuspendLayout();
            this.gb_ResetToReady.SuspendLayout();
            this.gb_Select.SuspendLayout();
            this.gb_StayQuiet.SuspendLayout();
            this.gb_LockBlock.SuspendLayout();
            this.gb_WriteMultiBlock.SuspendLayout();
            this.gb_ReadMultiBlock.SuspendLayout();
            this.gb_ReadSingleBlock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_ReaderConfig.SuspendLayout();
            this.gb_MultiplexConfig.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_TagItConfig.SuspendLayout();
            this.gb_ICodeConfig.SuspendLayout();
            this.gb_TimingConfig.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Photo_Monitor)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserPhoto)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4_14443.SuspendLayout();
            this.groupBox3_14443.SuspendLayout();
            this.groupBox2_14443.SuspendLayout();
            this.groupBox1_14443.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 381);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_OpenCloseComm);
            this.tabPage1.Controls.Add(this.gb_OpenCloseHID);
            this.tabPage1.Controls.Add(this.gb_AutoRcv);
            this.tabPage1.Controls.Add(this.gb_Inventory);
            this.tabPage1.Controls.Add(this.gb_WriteSingleBlock);
            this.tabPage1.Controls.Add(this.gb_GetAll);
            this.tabPage1.Controls.Add(this.gb_EnableBuzzer);
            this.tabPage1.Controls.Add(this.gb_GetMulti);
            this.tabPage1.Controls.Add(this.gb_GetSystemInfo);
            this.tabPage1.Controls.Add(this.gb_LockDSFID);
            this.tabPage1.Controls.Add(this.gb_WriteDSFID);
            this.tabPage1.Controls.Add(this.gb_LockAFI);
            this.tabPage1.Controls.Add(this.gb_WriteAFI);
            this.tabPage1.Controls.Add(this.gb_ResetToReady);
            this.tabPage1.Controls.Add(this.gb_Select);
            this.tabPage1.Controls.Add(this.gb_StayQuiet);
            this.tabPage1.Controls.Add(this.gb_LockBlock);
            this.tabPage1.Controls.Add(this.gb_WriteMultiBlock);
            this.tabPage1.Controls.Add(this.gb_ReadMultiBlock);
            this.tabPage1.Controls.Add(this.gb_ReadSingleBlock);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_ClearListBox1);
            this.tabPage1.Controls.Add(this.lst_Info);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HF-ISO15693-Reader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_OpenCloseComm
            // 
            this.gb_OpenCloseComm.Controls.Add(this.btn_RefreshComm);
            this.gb_OpenCloseComm.Controls.Add(this.btn_CloseComm);
            this.gb_OpenCloseComm.Controls.Add(this.btn_OpenComm);
            this.gb_OpenCloseComm.Controls.Add(this.label5);
            this.gb_OpenCloseComm.Controls.Add(this.txt_Parity);
            this.gb_OpenCloseComm.Controls.Add(this.txt_StopBits);
            this.gb_OpenCloseComm.Controls.Add(this.label4);
            this.gb_OpenCloseComm.Controls.Add(this.txt_DataBits);
            this.gb_OpenCloseComm.Controls.Add(this.label3);
            this.gb_OpenCloseComm.Controls.Add(this.cmb_BaudRate);
            this.gb_OpenCloseComm.Controls.Add(this.label2);
            this.gb_OpenCloseComm.Controls.Add(this.cmb_PortNum);
            this.gb_OpenCloseComm.Controls.Add(this.label1);
            this.gb_OpenCloseComm.Location = new System.Drawing.Point(485, 154);
            this.gb_OpenCloseComm.Name = "gb_OpenCloseComm";
            this.gb_OpenCloseComm.Size = new System.Drawing.Size(184, 190);
            this.gb_OpenCloseComm.TabIndex = 6;
            this.gb_OpenCloseComm.TabStop = false;
            this.gb_OpenCloseComm.Text = "OpenCloseComm";
            // 
            // btn_RefreshComm
            // 
            this.btn_RefreshComm.Location = new System.Drawing.Point(116, 149);
            this.btn_RefreshComm.Name = "btn_RefreshComm";
            this.btn_RefreshComm.Size = new System.Drawing.Size(57, 23);
            this.btn_RefreshComm.TabIndex = 12;
            this.btn_RefreshComm.Text = "Refresh";
            this.btn_RefreshComm.UseVisualStyleBackColor = true;
            this.btn_RefreshComm.Click += new System.EventHandler(this.btn_RefreshComm_Click);
            // 
            // btn_CloseComm
            // 
            this.btn_CloseComm.Location = new System.Drawing.Point(59, 149);
            this.btn_CloseComm.Name = "btn_CloseComm";
            this.btn_CloseComm.Size = new System.Drawing.Size(57, 23);
            this.btn_CloseComm.TabIndex = 11;
            this.btn_CloseComm.Text = "Close";
            this.btn_CloseComm.UseVisualStyleBackColor = true;
            this.btn_CloseComm.Click += new System.EventHandler(this.btn_CloseComm_Click);
            // 
            // btn_OpenComm
            // 
            this.btn_OpenComm.Location = new System.Drawing.Point(14, 149);
            this.btn_OpenComm.Name = "btn_OpenComm";
            this.btn_OpenComm.Size = new System.Drawing.Size(45, 23);
            this.btn_OpenComm.TabIndex = 10;
            this.btn_OpenComm.Text = "Open";
            this.btn_OpenComm.UseVisualStyleBackColor = true;
            this.btn_OpenComm.Click += new System.EventHandler(this.btn_OpenComm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity:";
            // 
            // txt_Parity
            // 
            this.txt_Parity.Location = new System.Drawing.Point(81, 120);
            this.txt_Parity.Name = "txt_Parity";
            this.txt_Parity.ReadOnly = true;
            this.txt_Parity.Size = new System.Drawing.Size(90, 21);
            this.txt_Parity.TabIndex = 8;
            this.txt_Parity.Text = "None";
            // 
            // txt_StopBits
            // 
            this.txt_StopBits.Location = new System.Drawing.Point(81, 93);
            this.txt_StopBits.Name = "txt_StopBits";
            this.txt_StopBits.ReadOnly = true;
            this.txt_StopBits.Size = new System.Drawing.Size(90, 21);
            this.txt_StopBits.TabIndex = 7;
            this.txt_StopBits.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "StopBits:";
            // 
            // txt_DataBits
            // 
            this.txt_DataBits.Location = new System.Drawing.Point(81, 66);
            this.txt_DataBits.Name = "txt_DataBits";
            this.txt_DataBits.ReadOnly = true;
            this.txt_DataBits.Size = new System.Drawing.Size(90, 21);
            this.txt_DataBits.TabIndex = 5;
            this.txt_DataBits.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "DataBits:";
            // 
            // cmb_BaudRate
            // 
            this.cmb_BaudRate.FormattingEnabled = true;
            this.cmb_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmb_BaudRate.Location = new System.Drawing.Point(81, 40);
            this.cmb_BaudRate.Name = "cmb_BaudRate";
            this.cmb_BaudRate.Size = new System.Drawing.Size(90, 20);
            this.cmb_BaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate:";
            // 
            // cmb_PortNum
            // 
            this.cmb_PortNum.FormattingEnabled = true;
            this.cmb_PortNum.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.cmb_PortNum.Location = new System.Drawing.Point(81, 14);
            this.cmb_PortNum.Name = "cmb_PortNum";
            this.cmb_PortNum.Size = new System.Drawing.Size(90, 20);
            this.cmb_PortNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "CommPort:";
            // 
            // gb_OpenCloseHID
            // 
            this.gb_OpenCloseHID.Controls.Add(this.btn_CloseHIDDevice);
            this.gb_OpenCloseHID.Controls.Add(this.btn_OpenHIDDevice);
            this.gb_OpenCloseHID.Location = new System.Drawing.Point(295, 6);
            this.gb_OpenCloseHID.Name = "gb_OpenCloseHID";
            this.gb_OpenCloseHID.Size = new System.Drawing.Size(184, 190);
            this.gb_OpenCloseHID.TabIndex = 11;
            this.gb_OpenCloseHID.TabStop = false;
            this.gb_OpenCloseHID.Text = "OpenCloseUSB";
            // 
            // btn_CloseHIDDevice
            // 
            this.btn_CloseHIDDevice.Location = new System.Drawing.Point(37, 84);
            this.btn_CloseHIDDevice.Name = "btn_CloseHIDDevice";
            this.btn_CloseHIDDevice.Size = new System.Drawing.Size(110, 23);
            this.btn_CloseHIDDevice.TabIndex = 4;
            this.btn_CloseHIDDevice.Text = "Close USB";
            this.btn_CloseHIDDevice.UseVisualStyleBackColor = true;
            this.btn_CloseHIDDevice.Click += new System.EventHandler(this.btn_CloseHIDDevice_Click);
            // 
            // btn_OpenHIDDevice
            // 
            this.btn_OpenHIDDevice.Location = new System.Drawing.Point(37, 44);
            this.btn_OpenHIDDevice.Name = "btn_OpenHIDDevice";
            this.btn_OpenHIDDevice.Size = new System.Drawing.Size(110, 23);
            this.btn_OpenHIDDevice.TabIndex = 3;
            this.btn_OpenHIDDevice.Text = "Open USB";
            this.btn_OpenHIDDevice.UseVisualStyleBackColor = true;
            this.btn_OpenHIDDevice.Click += new System.EventHandler(this.btn_OpenHIDDevice_Click);
            // 
            // gb_AutoRcv
            // 
            this.gb_AutoRcv.Controls.Add(this.btn_AutoRcv);
            this.gb_AutoRcv.Location = new System.Drawing.Point(485, 154);
            this.gb_AutoRcv.Name = "gb_AutoRcv";
            this.gb_AutoRcv.Size = new System.Drawing.Size(184, 190);
            this.gb_AutoRcv.TabIndex = 11;
            this.gb_AutoRcv.TabStop = false;
            this.gb_AutoRcv.Text = "AutoReceive";
            // 
            // btn_AutoRcv
            // 
            this.btn_AutoRcv.Location = new System.Drawing.Point(37, 44);
            this.btn_AutoRcv.Name = "btn_AutoRcv";
            this.btn_AutoRcv.Size = new System.Drawing.Size(110, 23);
            this.btn_AutoRcv.TabIndex = 3;
            this.btn_AutoRcv.Text = "BeginAutoRcv";
            this.btn_AutoRcv.UseVisualStyleBackColor = true;
            this.btn_AutoRcv.Click += new System.EventHandler(this.btn_AutoRcv_Click);
            // 
            // gb_Inventory
            // 
            this.gb_Inventory.Controls.Add(this.btn_AutoRun);
            this.gb_Inventory.Controls.Add(this.lst_InventoryResult);
            this.gb_Inventory.Controls.Add(this.btn_Inventory);
            this.gb_Inventory.Controls.Add(this.panel2);
            this.gb_Inventory.Controls.Add(this.panel1);
            this.gb_Inventory.Location = new System.Drawing.Point(485, 154);
            this.gb_Inventory.Name = "gb_Inventory";
            this.gb_Inventory.Size = new System.Drawing.Size(184, 190);
            this.gb_Inventory.TabIndex = 7;
            this.gb_Inventory.TabStop = false;
            this.gb_Inventory.Text = "Inventory";
            // 
            // btn_AutoRun
            // 
            this.btn_AutoRun.Location = new System.Drawing.Point(96, 71);
            this.btn_AutoRun.Name = "btn_AutoRun";
            this.btn_AutoRun.Size = new System.Drawing.Size(75, 23);
            this.btn_AutoRun.TabIndex = 5;
            this.btn_AutoRun.Text = "AutoRun";
            this.btn_AutoRun.UseVisualStyleBackColor = true;
            this.btn_AutoRun.Click += new System.EventHandler(this.btn_AutoRun_Click);
            // 
            // lst_InventoryResult
            // 
            this.lst_InventoryResult.FormattingEnabled = true;
            this.lst_InventoryResult.ItemHeight = 12;
            this.lst_InventoryResult.Location = new System.Drawing.Point(18, 101);
            this.lst_InventoryResult.Name = "lst_InventoryResult";
            this.lst_InventoryResult.Size = new System.Drawing.Size(153, 76);
            this.lst_InventoryResult.TabIndex = 4;
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.Location = new System.Drawing.Point(18, 72);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(75, 23);
            this.btn_Inventory.TabIndex = 3;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.UseVisualStyleBackColor = true;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_ASK);
            this.panel2.Controls.Add(this.rb_FSK);
            this.panel2.Location = new System.Drawing.Point(18, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 20);
            this.panel2.TabIndex = 2;
            // 
            // rb_ASK
            // 
            this.rb_ASK.AutoSize = true;
            this.rb_ASK.Location = new System.Drawing.Point(78, 3);
            this.rb_ASK.Name = "rb_ASK";
            this.rb_ASK.Size = new System.Drawing.Size(41, 16);
            this.rb_ASK.TabIndex = 1;
            this.rb_ASK.TabStop = true;
            this.rb_ASK.Text = "ASK";
            this.rb_ASK.UseVisualStyleBackColor = true;
            // 
            // rb_FSK
            // 
            this.rb_FSK.AutoSize = true;
            this.rb_FSK.Location = new System.Drawing.Point(3, 3);
            this.rb_FSK.Name = "rb_FSK";
            this.rb_FSK.Size = new System.Drawing.Size(41, 16);
            this.rb_FSK.TabIndex = 0;
            this.rb_FSK.TabStop = true;
            this.rb_FSK.Text = "FSK";
            this.rb_FSK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_Multi);
            this.panel1.Controls.Add(this.rb_Single);
            this.panel1.Location = new System.Drawing.Point(18, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 20);
            this.panel1.TabIndex = 0;
            // 
            // rb_Multi
            // 
            this.rb_Multi.AutoSize = true;
            this.rb_Multi.Location = new System.Drawing.Point(78, 3);
            this.rb_Multi.Name = "rb_Multi";
            this.rb_Multi.Size = new System.Drawing.Size(71, 16);
            this.rb_Multi.TabIndex = 1;
            this.rb_Multi.TabStop = true;
            this.rb_Multi.Text = "Multiple";
            this.rb_Multi.UseVisualStyleBackColor = true;
            // 
            // rb_Single
            // 
            this.rb_Single.AutoSize = true;
            this.rb_Single.Location = new System.Drawing.Point(3, 3);
            this.rb_Single.Name = "rb_Single";
            this.rb_Single.Size = new System.Drawing.Size(59, 16);
            this.rb_Single.TabIndex = 0;
            this.rb_Single.TabStop = true;
            this.rb_Single.Text = "Single";
            this.rb_Single.UseVisualStyleBackColor = true;
            // 
            // gb_WriteSingleBlock
            // 
            this.gb_WriteSingleBlock.Controls.Add(this.cmd_Length_2);
            this.gb_WriteSingleBlock.Controls.Add(this.btn_WriteSingleBlock);
            this.gb_WriteSingleBlock.Controls.Add(this.txt_WriteData_2);
            this.gb_WriteSingleBlock.Controls.Add(this.label14);
            this.gb_WriteSingleBlock.Controls.Add(this.label13);
            this.gb_WriteSingleBlock.Controls.Add(this.label11);
            this.gb_WriteSingleBlock.Controls.Add(this.cmb_UID_2);
            this.gb_WriteSingleBlock.Controls.Add(this.txt_Address_2);
            this.gb_WriteSingleBlock.Controls.Add(this.label12);
            this.gb_WriteSingleBlock.Location = new System.Drawing.Point(485, 154);
            this.gb_WriteSingleBlock.Name = "gb_WriteSingleBlock";
            this.gb_WriteSingleBlock.Size = new System.Drawing.Size(184, 190);
            this.gb_WriteSingleBlock.TabIndex = 9;
            this.gb_WriteSingleBlock.TabStop = false;
            this.gb_WriteSingleBlock.Text = "WriteSingleBlock";
            this.gb_WriteSingleBlock.Visible = false;
            // 
            // cmd_Length_2
            // 
            this.cmd_Length_2.FormattingEnabled = true;
            this.cmd_Length_2.Items.AddRange(new object[] {
            "4",
            "8"});
            this.cmd_Length_2.Location = new System.Drawing.Point(135, 44);
            this.cmd_Length_2.Name = "cmd_Length_2";
            this.cmd_Length_2.Size = new System.Drawing.Size(36, 20);
            this.cmd_Length_2.TabIndex = 8;
            // 
            // btn_WriteSingleBlock
            // 
            this.btn_WriteSingleBlock.Location = new System.Drawing.Point(25, 101);
            this.btn_WriteSingleBlock.Name = "btn_WriteSingleBlock";
            this.btn_WriteSingleBlock.Size = new System.Drawing.Size(135, 23);
            this.btn_WriteSingleBlock.TabIndex = 6;
            this.btn_WriteSingleBlock.Text = "Write Single Block";
            this.btn_WriteSingleBlock.UseVisualStyleBackColor = true;
            this.btn_WriteSingleBlock.Click += new System.EventHandler(this.btn_WriteSingleBlock_Click);
            // 
            // txt_WriteData_2
            // 
            this.txt_WriteData_2.Location = new System.Drawing.Point(50, 72);
            this.txt_WriteData_2.MaxLength = 16;
            this.txt_WriteData_2.Name = "txt_WriteData_2";
            this.txt_WriteData_2.Size = new System.Drawing.Size(121, 21);
            this.txt_WriteData_2.TabIndex = 7;
            this.txt_WriteData_2.Text = "FFFFFFFF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "Data:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "Length:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "UID:";
            // 
            // cmb_UID_2
            // 
            this.cmb_UID_2.FormattingEnabled = true;
            this.cmb_UID_2.Location = new System.Drawing.Point(50, 18);
            this.cmb_UID_2.Name = "cmb_UID_2";
            this.cmb_UID_2.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_2.TabIndex = 1;
            // 
            // txt_Address_2
            // 
            this.txt_Address_2.Location = new System.Drawing.Point(50, 44);
            this.txt_Address_2.MaxLength = 3;
            this.txt_Address_2.Name = "txt_Address_2";
            this.txt_Address_2.Size = new System.Drawing.Size(25, 21);
            this.txt_Address_2.TabIndex = 3;
            this.txt_Address_2.Text = "0";
            this.txt_Address_2.TextChanged += new System.EventHandler(this.txt_Address_2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "Addr:";
            // 
            // gb_GetAll
            // 
            this.gb_GetAll.Controls.Add(this.btn_ClearAutoGetAllResult);
            this.gb_GetAll.Controls.Add(this.btn_AutoGetAll);
            this.gb_GetAll.Controls.Add(this.txt_GetAllResult);
            this.gb_GetAll.Controls.Add(this.lst_GetAllResult);
            this.gb_GetAll.Controls.Add(this.btn_GetAll);
            this.gb_GetAll.Controls.Add(this.label45);
            this.gb_GetAll.Location = new System.Drawing.Point(485, 154);
            this.gb_GetAll.Name = "gb_GetAll";
            this.gb_GetAll.Size = new System.Drawing.Size(184, 190);
            this.gb_GetAll.TabIndex = 8;
            this.gb_GetAll.TabStop = false;
            this.gb_GetAll.Text = "GetAllTagNum";
            // 
            // btn_ClearAutoGetAllResult
            // 
            this.btn_ClearAutoGetAllResult.Location = new System.Drawing.Point(114, 161);
            this.btn_ClearAutoGetAllResult.Name = "btn_ClearAutoGetAllResult";
            this.btn_ClearAutoGetAllResult.Size = new System.Drawing.Size(56, 23);
            this.btn_ClearAutoGetAllResult.TabIndex = 12;
            this.btn_ClearAutoGetAllResult.Text = "Clear";
            this.btn_ClearAutoGetAllResult.UseVisualStyleBackColor = true;
            this.btn_ClearAutoGetAllResult.Click += new System.EventHandler(this.btn_ClearAutoGetAllResult_Click);
            // 
            // btn_AutoGetAll
            // 
            this.btn_AutoGetAll.Location = new System.Drawing.Point(19, 161);
            this.btn_AutoGetAll.Name = "btn_AutoGetAll";
            this.btn_AutoGetAll.Size = new System.Drawing.Size(74, 23);
            this.btn_AutoGetAll.TabIndex = 11;
            this.btn_AutoGetAll.Text = "AutoGetAll";
            this.btn_AutoGetAll.UseVisualStyleBackColor = true;
            this.btn_AutoGetAll.Click += new System.EventHandler(this.btn_AutoGetAll_Click);
            // 
            // txt_GetAllResult
            // 
            this.txt_GetAllResult.Location = new System.Drawing.Point(135, 24);
            this.txt_GetAllResult.Name = "txt_GetAllResult";
            this.txt_GetAllResult.ReadOnly = true;
            this.txt_GetAllResult.Size = new System.Drawing.Size(36, 21);
            this.txt_GetAllResult.TabIndex = 10;
            // 
            // lst_GetAllResult
            // 
            this.lst_GetAllResult.FormattingEnabled = true;
            this.lst_GetAllResult.ItemHeight = 12;
            this.lst_GetAllResult.Location = new System.Drawing.Point(18, 53);
            this.lst_GetAllResult.Name = "lst_GetAllResult";
            this.lst_GetAllResult.Size = new System.Drawing.Size(153, 100);
            this.lst_GetAllResult.TabIndex = 4;
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(19, 24);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(56, 23);
            this.btn_GetAll.TabIndex = 3;
            this.btn_GetAll.Text = "GetAll";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(75, 31);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(59, 12);
            this.label45.TabIndex = 9;
            this.label45.Text = "TagCount:";
            // 
            // gb_EnableBuzzer
            // 
            this.gb_EnableBuzzer.Controls.Add(this.label44);
            this.gb_EnableBuzzer.Controls.Add(this.rb_Flag_False);
            this.gb_EnableBuzzer.Controls.Add(this.rb_Flag_True);
            this.gb_EnableBuzzer.Controls.Add(this.btn_EnableBuzzer);
            this.gb_EnableBuzzer.Location = new System.Drawing.Point(485, 155);
            this.gb_EnableBuzzer.Name = "gb_EnableBuzzer";
            this.gb_EnableBuzzer.Size = new System.Drawing.Size(184, 190);
            this.gb_EnableBuzzer.TabIndex = 19;
            this.gb_EnableBuzzer.TabStop = false;
            this.gb_EnableBuzzer.Text = "EnableBuzzer";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(17, 36);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 3;
            this.label44.Text = "Flag:";
            // 
            // rb_Flag_False
            // 
            this.rb_Flag_False.AutoSize = true;
            this.rb_Flag_False.Location = new System.Drawing.Point(114, 32);
            this.rb_Flag_False.Name = "rb_Flag_False";
            this.rb_Flag_False.Size = new System.Drawing.Size(53, 16);
            this.rb_Flag_False.TabIndex = 2;
            this.rb_Flag_False.TabStop = true;
            this.rb_Flag_False.Text = "False";
            this.rb_Flag_False.UseVisualStyleBackColor = true;
            // 
            // rb_Flag_True
            // 
            this.rb_Flag_True.AutoSize = true;
            this.rb_Flag_True.Location = new System.Drawing.Point(58, 32);
            this.rb_Flag_True.Name = "rb_Flag_True";
            this.rb_Flag_True.Size = new System.Drawing.Size(47, 16);
            this.rb_Flag_True.TabIndex = 1;
            this.rb_Flag_True.TabStop = true;
            this.rb_Flag_True.Text = "True";
            this.rb_Flag_True.UseVisualStyleBackColor = true;
            // 
            // btn_EnableBuzzer
            // 
            this.btn_EnableBuzzer.Location = new System.Drawing.Point(44, 70);
            this.btn_EnableBuzzer.Name = "btn_EnableBuzzer";
            this.btn_EnableBuzzer.Size = new System.Drawing.Size(97, 23);
            this.btn_EnableBuzzer.TabIndex = 0;
            this.btn_EnableBuzzer.Text = "EnableBuzzer";
            this.btn_EnableBuzzer.UseVisualStyleBackColor = true;
            this.btn_EnableBuzzer.Click += new System.EventHandler(this.btn_EnableBuzzer_Click);
            // 
            // gb_GetMulti
            // 
            this.gb_GetMulti.Controls.Add(this.txt_Address_14);
            this.gb_GetMulti.Controls.Add(this.lst_Result2);
            this.gb_GetMulti.Controls.Add(this.btn_GetMulti);
            this.gb_GetMulti.Controls.Add(this.label43);
            this.gb_GetMulti.Controls.Add(this.cmb_UID_14);
            this.gb_GetMulti.Controls.Add(this.txt_Number_14);
            this.gb_GetMulti.Controls.Add(this.label48);
            this.gb_GetMulti.Controls.Add(this.label42);
            this.gb_GetMulti.Location = new System.Drawing.Point(485, 155);
            this.gb_GetMulti.Name = "gb_GetMulti";
            this.gb_GetMulti.Size = new System.Drawing.Size(184, 190);
            this.gb_GetMulti.TabIndex = 18;
            this.gb_GetMulti.TabStop = false;
            this.gb_GetMulti.Text = "GetMultiBlockSec.Status";
            // 
            // txt_Address_14
            // 
            this.txt_Address_14.Location = new System.Drawing.Point(50, 46);
            this.txt_Address_14.MaxLength = 3;
            this.txt_Address_14.Name = "txt_Address_14";
            this.txt_Address_14.Size = new System.Drawing.Size(25, 21);
            this.txt_Address_14.TabIndex = 3;
            this.txt_Address_14.Text = "0";
            this.txt_Address_14.TextChanged += new System.EventHandler(this.txt_Address_14_TextChanged);
            // 
            // lst_Result2
            // 
            this.lst_Result2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lst_Result2.FormattingEnabled = true;
            this.lst_Result2.ItemHeight = 12;
            this.lst_Result2.Items.AddRange(new object[] {
            "Result:"});
            this.lst_Result2.Location = new System.Drawing.Point(18, 122);
            this.lst_Result2.Name = "lst_Result2";
            this.lst_Result2.Size = new System.Drawing.Size(153, 52);
            this.lst_Result2.TabIndex = 11;
            // 
            // btn_GetMulti
            // 
            this.btn_GetMulti.Location = new System.Drawing.Point(18, 74);
            this.btn_GetMulti.Name = "btn_GetMulti";
            this.btn_GetMulti.Size = new System.Drawing.Size(153, 42);
            this.btn_GetMulti.TabIndex = 5;
            this.btn_GetMulti.Text = "Get Multiple Blocks Security Status";
            this.btn_GetMulti.UseVisualStyleBackColor = true;
            this.btn_GetMulti.Click += new System.EventHandler(this.btn_GetMulti_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(112, 56);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(29, 12);
            this.label43.TabIndex = 9;
            this.label43.Text = "Num:";
            // 
            // cmb_UID_14
            // 
            this.cmb_UID_14.FormattingEnabled = true;
            this.cmb_UID_14.Location = new System.Drawing.Point(50, 20);
            this.cmb_UID_14.Name = "cmb_UID_14";
            this.cmb_UID_14.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_14.TabIndex = 1;
            // 
            // txt_Number_14
            // 
            this.txt_Number_14.Location = new System.Drawing.Point(146, 46);
            this.txt_Number_14.MaxLength = 3;
            this.txt_Number_14.Name = "txt_Number_14";
            this.txt_Number_14.Size = new System.Drawing.Size(25, 21);
            this.txt_Number_14.TabIndex = 10;
            this.txt_Number_14.Text = "2";
            this.txt_Number_14.TextChanged += new System.EventHandler(this.txt_Number_14_TextChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(16, 29);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(29, 12);
            this.label48.TabIndex = 0;
            this.label48.Text = "UID:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(16, 56);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(35, 12);
            this.label42.TabIndex = 2;
            this.label42.Text = "Addr:";
            // 
            // gb_GetSystemInfo
            // 
            this.gb_GetSystemInfo.Controls.Add(this.label40);
            this.gb_GetSystemInfo.Controls.Add(this.label39);
            this.gb_GetSystemInfo.Controls.Add(this.label38);
            this.gb_GetSystemInfo.Controls.Add(this.label37);
            this.gb_GetSystemInfo.Controls.Add(this.txt_UID);
            this.gb_GetSystemInfo.Controls.Add(this.txt_VICC);
            this.gb_GetSystemInfo.Controls.Add(this.txt_DSFID_2);
            this.gb_GetSystemInfo.Controls.Add(this.txt_AFI_2);
            this.gb_GetSystemInfo.Controls.Add(this.txt_ICRef);
            this.gb_GetSystemInfo.Controls.Add(this.txt_Info);
            this.gb_GetSystemInfo.Controls.Add(this.label41);
            this.gb_GetSystemInfo.Controls.Add(this.label36);
            this.gb_GetSystemInfo.Controls.Add(this.btn_GetSystemInfo);
            this.gb_GetSystemInfo.Controls.Add(this.cmb_UID_13);
            this.gb_GetSystemInfo.Controls.Add(this.label35);
            this.gb_GetSystemInfo.Location = new System.Drawing.Point(485, 154);
            this.gb_GetSystemInfo.Name = "gb_GetSystemInfo";
            this.gb_GetSystemInfo.Size = new System.Drawing.Size(184, 190);
            this.gb_GetSystemInfo.TabIndex = 18;
            this.gb_GetSystemInfo.TabStop = false;
            this.gb_GetSystemInfo.Text = "GetSystemInfo";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 172);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(107, 12);
            this.label40.TabIndex = 10;
            this.label40.Text = "VICC Memory Size:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(99, 145);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 12);
            this.label39.TabIndex = 9;
            this.label39.Text = "DSFID:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(16, 145);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(29, 12);
            this.label38.TabIndex = 9;
            this.label38.Text = "AFI:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(16, 86);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 12);
            this.label37.TabIndex = 8;
            this.label37.Text = "UID:";
            // 
            // txt_UID
            // 
            this.txt_UID.Location = new System.Drawing.Point(57, 79);
            this.txt_UID.Name = "txt_UID";
            this.txt_UID.ReadOnly = true;
            this.txt_UID.Size = new System.Drawing.Size(113, 21);
            this.txt_UID.TabIndex = 7;
            // 
            // txt_VICC
            // 
            this.txt_VICC.Location = new System.Drawing.Point(129, 164);
            this.txt_VICC.Name = "txt_VICC";
            this.txt_VICC.ReadOnly = true;
            this.txt_VICC.Size = new System.Drawing.Size(41, 21);
            this.txt_VICC.TabIndex = 7;
            // 
            // txt_DSFID_2
            // 
            this.txt_DSFID_2.Location = new System.Drawing.Point(143, 136);
            this.txt_DSFID_2.Name = "txt_DSFID_2";
            this.txt_DSFID_2.ReadOnly = true;
            this.txt_DSFID_2.Size = new System.Drawing.Size(27, 21);
            this.txt_DSFID_2.TabIndex = 7;
            // 
            // txt_AFI_2
            // 
            this.txt_AFI_2.Location = new System.Drawing.Point(57, 136);
            this.txt_AFI_2.Name = "txt_AFI_2";
            this.txt_AFI_2.ReadOnly = true;
            this.txt_AFI_2.Size = new System.Drawing.Size(27, 21);
            this.txt_AFI_2.TabIndex = 7;
            // 
            // txt_ICRef
            // 
            this.txt_ICRef.Location = new System.Drawing.Point(143, 109);
            this.txt_ICRef.Name = "txt_ICRef";
            this.txt_ICRef.ReadOnly = true;
            this.txt_ICRef.Size = new System.Drawing.Size(27, 21);
            this.txt_ICRef.TabIndex = 7;
            // 
            // txt_Info
            // 
            this.txt_Info.Location = new System.Drawing.Point(57, 109);
            this.txt_Info.Name = "txt_Info";
            this.txt_Info.ReadOnly = true;
            this.txt_Info.Size = new System.Drawing.Size(27, 21);
            this.txt_Info.TabIndex = 7;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(99, 118);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 12);
            this.label41.TabIndex = 6;
            this.label41.Text = "ICRef:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(16, 118);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(35, 12);
            this.label36.TabIndex = 6;
            this.label36.Text = "Info:";
            // 
            // btn_GetSystemInfo
            // 
            this.btn_GetSystemInfo.Location = new System.Drawing.Point(18, 50);
            this.btn_GetSystemInfo.Name = "btn_GetSystemInfo";
            this.btn_GetSystemInfo.Size = new System.Drawing.Size(153, 23);
            this.btn_GetSystemInfo.TabIndex = 5;
            this.btn_GetSystemInfo.Text = "Get System Information";
            this.btn_GetSystemInfo.UseVisualStyleBackColor = true;
            this.btn_GetSystemInfo.Click += new System.EventHandler(this.btn_GetSystemInfo_Click);
            // 
            // cmb_UID_13
            // 
            this.cmb_UID_13.FormattingEnabled = true;
            this.cmb_UID_13.Location = new System.Drawing.Point(50, 20);
            this.cmb_UID_13.Name = "cmb_UID_13";
            this.cmb_UID_13.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_13.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(16, 29);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(29, 12);
            this.label35.TabIndex = 0;
            this.label35.Text = "UID:";
            // 
            // gb_LockDSFID
            // 
            this.gb_LockDSFID.Controls.Add(this.btn_LockDSFID);
            this.gb_LockDSFID.Controls.Add(this.cmb_UID_12);
            this.gb_LockDSFID.Controls.Add(this.label34);
            this.gb_LockDSFID.Location = new System.Drawing.Point(485, 154);
            this.gb_LockDSFID.Name = "gb_LockDSFID";
            this.gb_LockDSFID.Size = new System.Drawing.Size(184, 190);
            this.gb_LockDSFID.TabIndex = 17;
            this.gb_LockDSFID.TabStop = false;
            this.gb_LockDSFID.Text = "LockDSFID";
            // 
            // btn_LockDSFID
            // 
            this.btn_LockDSFID.Location = new System.Drawing.Point(55, 50);
            this.btn_LockDSFID.Name = "btn_LockDSFID";
            this.btn_LockDSFID.Size = new System.Drawing.Size(75, 23);
            this.btn_LockDSFID.TabIndex = 5;
            this.btn_LockDSFID.Text = "Lock DSFID";
            this.btn_LockDSFID.UseVisualStyleBackColor = true;
            this.btn_LockDSFID.Click += new System.EventHandler(this.btn_LockDSFID_Click);
            // 
            // cmb_UID_12
            // 
            this.cmb_UID_12.FormattingEnabled = true;
            this.cmb_UID_12.Location = new System.Drawing.Point(50, 20);
            this.cmb_UID_12.Name = "cmb_UID_12";
            this.cmb_UID_12.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_12.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(16, 29);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 12);
            this.label34.TabIndex = 0;
            this.label34.Text = "UID:";
            // 
            // gb_WriteDSFID
            // 
            this.gb_WriteDSFID.Controls.Add(this.btn_WriteDSFID);
            this.gb_WriteDSFID.Controls.Add(this.label33);
            this.gb_WriteDSFID.Controls.Add(this.label31);
            this.gb_WriteDSFID.Controls.Add(this.txt_DSFID);
            this.gb_WriteDSFID.Controls.Add(this.cmb_UID_11);
            this.gb_WriteDSFID.Controls.Add(this.label32);
            this.gb_WriteDSFID.Location = new System.Drawing.Point(485, 155);
            this.gb_WriteDSFID.Name = "gb_WriteDSFID";
            this.gb_WriteDSFID.Size = new System.Drawing.Size(184, 190);
            this.gb_WriteDSFID.TabIndex = 18;
            this.gb_WriteDSFID.TabStop = false;
            this.gb_WriteDSFID.Text = "WriteDSFID";
            // 
            // btn_WriteDSFID
            // 
            this.btn_WriteDSFID.Location = new System.Drawing.Point(43, 81);
            this.btn_WriteDSFID.Name = "btn_WriteDSFID";
            this.btn_WriteDSFID.Size = new System.Drawing.Size(98, 23);
            this.btn_WriteDSFID.TabIndex = 5;
            this.btn_WriteDSFID.Text = "Write DSFID";
            this.btn_WriteDSFID.UseVisualStyleBackColor = true;
            this.btn_WriteDSFID.Click += new System.EventHandler(this.btn_WriteDSFID_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(97, 58);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 12);
            this.label33.TabIndex = 4;
            this.label33.Text = "Hex";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 29);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 12);
            this.label31.TabIndex = 0;
            this.label31.Text = "UID:";
            // 
            // txt_DSFID
            // 
            this.txt_DSFID.Location = new System.Drawing.Point(51, 49);
            this.txt_DSFID.MaxLength = 2;
            this.txt_DSFID.Name = "txt_DSFID";
            this.txt_DSFID.Size = new System.Drawing.Size(40, 21);
            this.txt_DSFID.TabIndex = 3;
            this.txt_DSFID.Text = "00";
            this.txt_DSFID.TextChanged += new System.EventHandler(this.txt_DSFID_TextChanged);
            // 
            // cmb_UID_11
            // 
            this.cmb_UID_11.FormattingEnabled = true;
            this.cmb_UID_11.Location = new System.Drawing.Point(51, 20);
            this.cmb_UID_11.Name = "cmb_UID_11";
            this.cmb_UID_11.Size = new System.Drawing.Size(120, 20);
            this.cmb_UID_11.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 58);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 12);
            this.label32.TabIndex = 2;
            this.label32.Text = "DSFID:";
            // 
            // gb_LockAFI
            // 
            this.gb_LockAFI.Controls.Add(this.btn_LockAFI);
            this.gb_LockAFI.Controls.Add(this.cmb_UID_10);
            this.gb_LockAFI.Controls.Add(this.label30);
            this.gb_LockAFI.Location = new System.Drawing.Point(485, 155);
            this.gb_LockAFI.Name = "gb_LockAFI";
            this.gb_LockAFI.Size = new System.Drawing.Size(184, 190);
            this.gb_LockAFI.TabIndex = 17;
            this.gb_LockAFI.TabStop = false;
            this.gb_LockAFI.Text = "LockAFI";
            // 
            // btn_LockAFI
            // 
            this.btn_LockAFI.Location = new System.Drawing.Point(55, 50);
            this.btn_LockAFI.Name = "btn_LockAFI";
            this.btn_LockAFI.Size = new System.Drawing.Size(75, 23);
            this.btn_LockAFI.TabIndex = 5;
            this.btn_LockAFI.Text = "Lock AFI";
            this.btn_LockAFI.UseVisualStyleBackColor = true;
            this.btn_LockAFI.Click += new System.EventHandler(this.btn_LockAFI_Click);
            // 
            // cmb_UID_10
            // 
            this.cmb_UID_10.FormattingEnabled = true;
            this.cmb_UID_10.Location = new System.Drawing.Point(50, 20);
            this.cmb_UID_10.Name = "cmb_UID_10";
            this.cmb_UID_10.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_10.TabIndex = 1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(16, 29);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 0;
            this.label30.Text = "UID:";
            // 
            // gb_WriteAFI
            // 
            this.gb_WriteAFI.Controls.Add(this.btn_WriteAFI);
            this.gb_WriteAFI.Controls.Add(this.label29);
            this.gb_WriteAFI.Controls.Add(this.txt_AFI);
            this.gb_WriteAFI.Controls.Add(this.label28);
            this.gb_WriteAFI.Controls.Add(this.cmb_UID_9);
            this.gb_WriteAFI.Controls.Add(this.label27);
            this.gb_WriteAFI.Location = new System.Drawing.Point(485, 155);
            this.gb_WriteAFI.Name = "gb_WriteAFI";
            this.gb_WriteAFI.Size = new System.Drawing.Size(184, 190);
            this.gb_WriteAFI.TabIndex = 16;
            this.gb_WriteAFI.TabStop = false;
            this.gb_WriteAFI.Text = "WriteAFI";
            // 
            // btn_WriteAFI
            // 
            this.btn_WriteAFI.Location = new System.Drawing.Point(55, 85);
            this.btn_WriteAFI.Name = "btn_WriteAFI";
            this.btn_WriteAFI.Size = new System.Drawing.Size(75, 23);
            this.btn_WriteAFI.TabIndex = 5;
            this.btn_WriteAFI.Text = "Write AFI";
            this.btn_WriteAFI.UseVisualStyleBackColor = true;
            this.btn_WriteAFI.Click += new System.EventHandler(this.btn_WriteAFI_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(96, 65);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 12);
            this.label29.TabIndex = 4;
            this.label29.Text = "Hex";
            // 
            // txt_AFI
            // 
            this.txt_AFI.Location = new System.Drawing.Point(50, 55);
            this.txt_AFI.MaxLength = 2;
            this.txt_AFI.Name = "txt_AFI";
            this.txt_AFI.Size = new System.Drawing.Size(40, 21);
            this.txt_AFI.TabIndex = 3;
            this.txt_AFI.Text = "00";
            this.txt_AFI.TextChanged += new System.EventHandler(this.txt_AFI_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 65);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "AFI:";
            // 
            // cmb_UID_9
            // 
            this.cmb_UID_9.FormattingEnabled = true;
            this.cmb_UID_9.Location = new System.Drawing.Point(50, 26);
            this.cmb_UID_9.Name = "cmb_UID_9";
            this.cmb_UID_9.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_9.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 35);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "UID:";
            // 
            // gb_ResetToReady
            // 
            this.gb_ResetToReady.Controls.Add(this.btn_ResetToReady);
            this.gb_ResetToReady.Controls.Add(this.cmb_Mode);
            this.gb_ResetToReady.Controls.Add(this.cmb_UID_8);
            this.gb_ResetToReady.Controls.Add(this.lbl_UID);
            this.gb_ResetToReady.Location = new System.Drawing.Point(485, 155);
            this.gb_ResetToReady.Name = "gb_ResetToReady";
            this.gb_ResetToReady.Size = new System.Drawing.Size(184, 190);
            this.gb_ResetToReady.TabIndex = 15;
            this.gb_ResetToReady.TabStop = false;
            this.gb_ResetToReady.Text = "ResetToReady";
            // 
            // btn_ResetToReady
            // 
            this.btn_ResetToReady.Location = new System.Drawing.Point(33, 85);
            this.btn_ResetToReady.Name = "btn_ResetToReady";
            this.btn_ResetToReady.Size = new System.Drawing.Size(120, 23);
            this.btn_ResetToReady.TabIndex = 2;
            this.btn_ResetToReady.Text = "Reset To Ready";
            this.btn_ResetToReady.UseVisualStyleBackColor = true;
            this.btn_ResetToReady.Click += new System.EventHandler(this.btn_ResetToReady_Click);
            // 
            // cmb_Mode
            // 
            this.cmb_Mode.FormattingEnabled = true;
            this.cmb_Mode.Items.AddRange(new object[] {
            "All Quiet Tags",
            "All Selected Tags",
            "Specific Quiet Tag",
            "Specific Selected Tag"});
            this.cmb_Mode.Location = new System.Drawing.Point(18, 26);
            this.cmb_Mode.Name = "cmb_Mode";
            this.cmb_Mode.Size = new System.Drawing.Size(153, 20);
            this.cmb_Mode.TabIndex = 1;
            this.cmb_Mode.Text = "Please Select A Mode";
            this.cmb_Mode.SelectedIndexChanged += new System.EventHandler(this.cmb_Mode_SelectedIndexChanged);
            // 
            // cmb_UID_8
            // 
            this.cmb_UID_8.FormattingEnabled = true;
            this.cmb_UID_8.Location = new System.Drawing.Point(50, 56);
            this.cmb_UID_8.Name = "cmb_UID_8";
            this.cmb_UID_8.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_8.TabIndex = 1;
            // 
            // lbl_UID
            // 
            this.lbl_UID.AutoSize = true;
            this.lbl_UID.Location = new System.Drawing.Point(16, 61);
            this.lbl_UID.Name = "lbl_UID";
            this.lbl_UID.Size = new System.Drawing.Size(29, 12);
            this.lbl_UID.TabIndex = 0;
            this.lbl_UID.Text = "UID:";
            // 
            // gb_Select
            // 
            this.gb_Select.Controls.Add(this.btn_Select);
            this.gb_Select.Controls.Add(this.cmb_UID_7);
            this.gb_Select.Controls.Add(this.label26);
            this.gb_Select.Location = new System.Drawing.Point(485, 154);
            this.gb_Select.Name = "gb_Select";
            this.gb_Select.Size = new System.Drawing.Size(184, 190);
            this.gb_Select.TabIndex = 14;
            this.gb_Select.TabStop = false;
            this.gb_Select.Text = "Select";
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(51, 57);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(83, 23);
            this.btn_Select.TabIndex = 4;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // cmb_UID_7
            // 
            this.cmb_UID_7.FormattingEnabled = true;
            this.cmb_UID_7.Location = new System.Drawing.Point(50, 26);
            this.cmb_UID_7.Name = "cmb_UID_7";
            this.cmb_UID_7.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_7.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 32);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "UID:";
            // 
            // gb_StayQuiet
            // 
            this.gb_StayQuiet.Controls.Add(this.btn_StayQuiet);
            this.gb_StayQuiet.Controls.Add(this.cmb_UID_6);
            this.gb_StayQuiet.Controls.Add(this.label25);
            this.gb_StayQuiet.Location = new System.Drawing.Point(485, 154);
            this.gb_StayQuiet.Name = "gb_StayQuiet";
            this.gb_StayQuiet.Size = new System.Drawing.Size(184, 190);
            this.gb_StayQuiet.TabIndex = 13;
            this.gb_StayQuiet.TabStop = false;
            this.gb_StayQuiet.Text = "StayQuiet";
            // 
            // btn_StayQuiet
            // 
            this.btn_StayQuiet.Location = new System.Drawing.Point(51, 53);
            this.btn_StayQuiet.Name = "btn_StayQuiet";
            this.btn_StayQuiet.Size = new System.Drawing.Size(83, 23);
            this.btn_StayQuiet.TabIndex = 4;
            this.btn_StayQuiet.Text = "Stay Quiet";
            this.btn_StayQuiet.UseVisualStyleBackColor = true;
            this.btn_StayQuiet.Click += new System.EventHandler(this.btn_StayQuiet_Click);
            // 
            // cmb_UID_6
            // 
            this.cmb_UID_6.FormattingEnabled = true;
            this.cmb_UID_6.Location = new System.Drawing.Point(50, 20);
            this.cmb_UID_6.Name = "cmb_UID_6";
            this.cmb_UID_6.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_6.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(16, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "UID:";
            // 
            // gb_LockBlock
            // 
            this.gb_LockBlock.Controls.Add(this.btn_LockSingleBlock);
            this.gb_LockBlock.Controls.Add(this.cmb_UID_5);
            this.gb_LockBlock.Controls.Add(this.label23);
            this.gb_LockBlock.Controls.Add(this.txt_Address_5);
            this.gb_LockBlock.Controls.Add(this.label24);
            this.gb_LockBlock.Location = new System.Drawing.Point(485, 154);
            this.gb_LockBlock.Name = "gb_LockBlock";
            this.gb_LockBlock.Size = new System.Drawing.Size(184, 190);
            this.gb_LockBlock.TabIndex = 12;
            this.gb_LockBlock.TabStop = false;
            this.gb_LockBlock.Text = "LockBlock";
            this.gb_LockBlock.Visible = false;
            // 
            // btn_LockSingleBlock
            // 
            this.btn_LockSingleBlock.Location = new System.Drawing.Point(34, 78);
            this.btn_LockSingleBlock.Name = "btn_LockSingleBlock";
            this.btn_LockSingleBlock.Size = new System.Drawing.Size(116, 23);
            this.btn_LockSingleBlock.TabIndex = 4;
            this.btn_LockSingleBlock.Text = "Lock Single Block";
            this.btn_LockSingleBlock.UseVisualStyleBackColor = true;
            this.btn_LockSingleBlock.Click += new System.EventHandler(this.btn_LockSingleBlock_Click);
            // 
            // cmb_UID_5
            // 
            this.cmb_UID_5.FormattingEnabled = true;
            this.cmb_UID_5.Location = new System.Drawing.Point(50, 20);
            this.cmb_UID_5.Name = "cmb_UID_5";
            this.cmb_UID_5.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_5.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "UID:";
            // 
            // txt_Address_5
            // 
            this.txt_Address_5.Location = new System.Drawing.Point(50, 48);
            this.txt_Address_5.MaxLength = 3;
            this.txt_Address_5.Name = "txt_Address_5";
            this.txt_Address_5.Size = new System.Drawing.Size(25, 21);
            this.txt_Address_5.TabIndex = 3;
            this.txt_Address_5.Text = "0";
            this.txt_Address_5.TextChanged += new System.EventHandler(this.txt_Address_5_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "Addr:";
            // 
            // gb_WriteMultiBlock
            // 
            this.gb_WriteMultiBlock.Controls.Add(this.txt_WriteData_4);
            this.gb_WriteMultiBlock.Controls.Add(this.btn_WriteMultiBlock);
            this.gb_WriteMultiBlock.Controls.Add(this.label22);
            this.gb_WriteMultiBlock.Controls.Add(this.txt_Number_4);
            this.gb_WriteMultiBlock.Controls.Add(this.txt_Address_4);
            this.gb_WriteMultiBlock.Controls.Add(this.label20);
            this.gb_WriteMultiBlock.Controls.Add(this.cmd_Length_4);
            this.gb_WriteMultiBlock.Controls.Add(this.cmb_UID_4);
            this.gb_WriteMultiBlock.Controls.Add(this.label21);
            this.gb_WriteMultiBlock.Controls.Add(this.label19);
            this.gb_WriteMultiBlock.Location = new System.Drawing.Point(485, 154);
            this.gb_WriteMultiBlock.Name = "gb_WriteMultiBlock";
            this.gb_WriteMultiBlock.Size = new System.Drawing.Size(184, 190);
            this.gb_WriteMultiBlock.TabIndex = 11;
            this.gb_WriteMultiBlock.TabStop = false;
            this.gb_WriteMultiBlock.Text = "WriteMultiBlock";
            // 
            // txt_WriteData_4
            // 
            this.txt_WriteData_4.Location = new System.Drawing.Point(33, 105);
            this.txt_WriteData_4.Name = "txt_WriteData_4";
            this.txt_WriteData_4.Size = new System.Drawing.Size(135, 52);
            this.txt_WriteData_4.TabIndex = 11;
            this.txt_WriteData_4.Text = "00000000";
            // 
            // btn_WriteMultiBlock
            // 
            this.btn_WriteMultiBlock.Location = new System.Drawing.Point(33, 162);
            this.btn_WriteMultiBlock.Name = "btn_WriteMultiBlock";
            this.btn_WriteMultiBlock.Size = new System.Drawing.Size(135, 23);
            this.btn_WriteMultiBlock.TabIndex = 6;
            this.btn_WriteMultiBlock.Text = "Write Multiple Block";
            this.btn_WriteMultiBlock.UseVisualStyleBackColor = true;
            this.btn_WriteMultiBlock.Click += new System.EventHandler(this.btn_WriteMultiBlock_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 9;
            this.label22.Text = "Num:";
            // 
            // txt_Number_4
            // 
            this.txt_Number_4.Location = new System.Drawing.Point(50, 76);
            this.txt_Number_4.MaxLength = 3;
            this.txt_Number_4.Name = "txt_Number_4";
            this.txt_Number_4.Size = new System.Drawing.Size(25, 21);
            this.txt_Number_4.TabIndex = 10;
            this.txt_Number_4.Text = "2";
            this.txt_Number_4.TextChanged += new System.EventHandler(this.txt_Number_4_TextChanged);
            // 
            // txt_Address_4
            // 
            this.txt_Address_4.Location = new System.Drawing.Point(50, 47);
            this.txt_Address_4.MaxLength = 3;
            this.txt_Address_4.Name = "txt_Address_4";
            this.txt_Address_4.Size = new System.Drawing.Size(25, 21);
            this.txt_Address_4.TabIndex = 3;
            this.txt_Address_4.Text = "0";
            this.txt_Address_4.TextChanged += new System.EventHandler(this.txt_Address_4_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(81, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 12);
            this.label20.TabIndex = 4;
            this.label20.Text = "Length:";
            // 
            // cmd_Length_4
            // 
            this.cmd_Length_4.FormattingEnabled = true;
            this.cmd_Length_4.Items.AddRange(new object[] {
            "4",
            "8"});
            this.cmd_Length_4.Location = new System.Drawing.Point(134, 48);
            this.cmd_Length_4.Name = "cmd_Length_4";
            this.cmd_Length_4.Size = new System.Drawing.Size(36, 20);
            this.cmd_Length_4.TabIndex = 8;
            // 
            // cmb_UID_4
            // 
            this.cmb_UID_4.FormattingEnabled = true;
            this.cmb_UID_4.Location = new System.Drawing.Point(50, 19);
            this.cmb_UID_4.Name = "cmb_UID_4";
            this.cmb_UID_4.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_4.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "UID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "Addr:";
            // 
            // gb_ReadMultiBlock
            // 
            this.gb_ReadMultiBlock.Controls.Add(this.lst_Result);
            this.gb_ReadMultiBlock.Controls.Add(this.label18);
            this.gb_ReadMultiBlock.Controls.Add(this.txt_Number_3);
            this.gb_ReadMultiBlock.Controls.Add(this.btn_ReadMultiBlock);
            this.gb_ReadMultiBlock.Controls.Add(this.cmd_Length_3);
            this.gb_ReadMultiBlock.Controls.Add(this.label15);
            this.gb_ReadMultiBlock.Controls.Add(this.cmb_UID_3);
            this.gb_ReadMultiBlock.Controls.Add(this.label17);
            this.gb_ReadMultiBlock.Controls.Add(this.txt_Address_3);
            this.gb_ReadMultiBlock.Controls.Add(this.label16);
            this.gb_ReadMultiBlock.Location = new System.Drawing.Point(485, 154);
            this.gb_ReadMultiBlock.Name = "gb_ReadMultiBlock";
            this.gb_ReadMultiBlock.Size = new System.Drawing.Size(184, 190);
            this.gb_ReadMultiBlock.TabIndex = 10;
            this.gb_ReadMultiBlock.TabStop = false;
            this.gb_ReadMultiBlock.Text = "ReadMultiBlock";
            // 
            // lst_Result
            // 
            this.lst_Result.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lst_Result.FormattingEnabled = true;
            this.lst_Result.ItemHeight = 12;
            this.lst_Result.Items.AddRange(new object[] {
            "Result:"});
            this.lst_Result.Location = new System.Drawing.Point(25, 135);
            this.lst_Result.Name = "lst_Result";
            this.lst_Result.Size = new System.Drawing.Size(135, 52);
            this.lst_Result.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 9;
            this.label18.Text = "Num:";
            // 
            // txt_Number_3
            // 
            this.txt_Number_3.Location = new System.Drawing.Point(50, 76);
            this.txt_Number_3.MaxLength = 3;
            this.txt_Number_3.Name = "txt_Number_3";
            this.txt_Number_3.Size = new System.Drawing.Size(25, 21);
            this.txt_Number_3.TabIndex = 10;
            this.txt_Number_3.Text = "2";
            this.txt_Number_3.TextChanged += new System.EventHandler(this.txt_Number_3_TextChanged);
            // 
            // btn_ReadMultiBlock
            // 
            this.btn_ReadMultiBlock.Location = new System.Drawing.Point(25, 105);
            this.btn_ReadMultiBlock.Name = "btn_ReadMultiBlock";
            this.btn_ReadMultiBlock.Size = new System.Drawing.Size(135, 23);
            this.btn_ReadMultiBlock.TabIndex = 6;
            this.btn_ReadMultiBlock.Text = "Read Multiple Block";
            this.btn_ReadMultiBlock.UseVisualStyleBackColor = true;
            this.btn_ReadMultiBlock.Click += new System.EventHandler(this.btn_ReadMultiBlock_Click);
            // 
            // cmd_Length_3
            // 
            this.cmd_Length_3.FormattingEnabled = true;
            this.cmd_Length_3.Items.AddRange(new object[] {
            "4",
            "8"});
            this.cmd_Length_3.Location = new System.Drawing.Point(134, 48);
            this.cmd_Length_3.Name = "cmd_Length_3";
            this.cmd_Length_3.Size = new System.Drawing.Size(36, 20);
            this.cmd_Length_3.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "UID:";
            // 
            // cmb_UID_3
            // 
            this.cmb_UID_3.FormattingEnabled = true;
            this.cmb_UID_3.Location = new System.Drawing.Point(50, 19);
            this.cmb_UID_3.Name = "cmb_UID_3";
            this.cmb_UID_3.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_3.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(81, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "Length:";
            // 
            // txt_Address_3
            // 
            this.txt_Address_3.Location = new System.Drawing.Point(50, 47);
            this.txt_Address_3.MaxLength = 3;
            this.txt_Address_3.Name = "txt_Address_3";
            this.txt_Address_3.Size = new System.Drawing.Size(25, 21);
            this.txt_Address_3.TabIndex = 3;
            this.txt_Address_3.Text = "0";
            this.txt_Address_3.TextChanged += new System.EventHandler(this.txt_Address_3_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "Addr:";
            // 
            // gb_ReadSingleBlock
            // 
            this.gb_ReadSingleBlock.Controls.Add(this.txt_Result_1);
            this.gb_ReadSingleBlock.Controls.Add(this.cmd_Length_1);
            this.gb_ReadSingleBlock.Controls.Add(this.btn_ReadSingleBlock);
            this.gb_ReadSingleBlock.Controls.Add(this.label10);
            this.gb_ReadSingleBlock.Controls.Add(this.txt_Address_1);
            this.gb_ReadSingleBlock.Controls.Add(this.label9);
            this.gb_ReadSingleBlock.Controls.Add(this.cmb_UID_1);
            this.gb_ReadSingleBlock.Controls.Add(this.label8);
            this.gb_ReadSingleBlock.Location = new System.Drawing.Point(485, 152);
            this.gb_ReadSingleBlock.Name = "gb_ReadSingleBlock";
            this.gb_ReadSingleBlock.Size = new System.Drawing.Size(184, 190);
            this.gb_ReadSingleBlock.TabIndex = 8;
            this.gb_ReadSingleBlock.TabStop = false;
            this.gb_ReadSingleBlock.Text = "ReadSingleBlock";
            this.gb_ReadSingleBlock.Visible = false;
            // 
            // txt_Result_1
            // 
            this.txt_Result_1.Location = new System.Drawing.Point(25, 107);
            this.txt_Result_1.Name = "txt_Result_1";
            this.txt_Result_1.ReadOnly = true;
            this.txt_Result_1.Size = new System.Drawing.Size(135, 21);
            this.txt_Result_1.TabIndex = 9;
            this.txt_Result_1.Text = "Result";
            // 
            // cmd_Length_1
            // 
            this.cmd_Length_1.FormattingEnabled = true;
            this.cmd_Length_1.Items.AddRange(new object[] {
            "4",
            "8"});
            this.cmd_Length_1.Location = new System.Drawing.Point(134, 47);
            this.cmd_Length_1.Name = "cmd_Length_1";
            this.cmd_Length_1.Size = new System.Drawing.Size(36, 20);
            this.cmd_Length_1.TabIndex = 8;
            // 
            // btn_ReadSingleBlock
            // 
            this.btn_ReadSingleBlock.Location = new System.Drawing.Point(25, 77);
            this.btn_ReadSingleBlock.Name = "btn_ReadSingleBlock";
            this.btn_ReadSingleBlock.Size = new System.Drawing.Size(135, 23);
            this.btn_ReadSingleBlock.TabIndex = 6;
            this.btn_ReadSingleBlock.Text = "Read Single Block";
            this.btn_ReadSingleBlock.UseVisualStyleBackColor = true;
            this.btn_ReadSingleBlock.Click += new System.EventHandler(this.btn_ReadSingleBlock_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "Length:";
            // 
            // txt_Address_1
            // 
            this.txt_Address_1.Location = new System.Drawing.Point(50, 46);
            this.txt_Address_1.Name = "txt_Address_1";
            this.txt_Address_1.Size = new System.Drawing.Size(25, 21);
            this.txt_Address_1.TabIndex = 3;
            this.txt_Address_1.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "Addr:";
            // 
            // cmb_UID_1
            // 
            this.cmb_UID_1.FormattingEnabled = true;
            this.cmb_UID_1.Location = new System.Drawing.Point(50, 18);
            this.cmb_UID_1.Name = "cmb_UID_1";
            this.cmb_UID_1.Size = new System.Drawing.Size(121, 20);
            this.cmb_UID_1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "UID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_OpenCloseHID);
            this.groupBox1.Controls.Add(this.rb_AutoRcv);
            this.groupBox1.Controls.Add(this.rb_EnableBuzzer);
            this.groupBox1.Controls.Add(this.rb_GetAll);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rb_ReadMultiBlock);
            this.groupBox1.Controls.Add(this.rb_WriteSingleBlock);
            this.groupBox1.Controls.Add(this.rb_GetMultiBlockSec);
            this.groupBox1.Controls.Add(this.rb_GetSystemInfo);
            this.groupBox1.Controls.Add(this.rb_LockDSFID);
            this.groupBox1.Controls.Add(this.rb_WriteDSFID);
            this.groupBox1.Controls.Add(this.rb_LockAFI);
            this.groupBox1.Controls.Add(this.rb_WriteAFI);
            this.groupBox1.Controls.Add(this.rb_ResetToReady);
            this.groupBox1.Controls.Add(this.rb_Select);
            this.groupBox1.Controls.Add(this.rb_StayQuiet);
            this.groupBox1.Controls.Add(this.rb_LockBlock);
            this.groupBox1.Controls.Add(this.rb_WriteMultiBlock);
            this.groupBox1.Controls.Add(this.rb_ReadSingleBolock);
            this.groupBox1.Controls.Add(this.rb_Inventory);
            this.groupBox1.Controls.Add(this.rb_OpenCloseComm);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 340);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command";
            // 
            // rb_OpenCloseHID
            // 
            this.rb_OpenCloseHID.AutoSize = true;
            this.rb_OpenCloseHID.Location = new System.Drawing.Point(142, 20);
            this.rb_OpenCloseHID.Name = "rb_OpenCloseHID";
            this.rb_OpenCloseHID.Size = new System.Drawing.Size(95, 16);
            this.rb_OpenCloseHID.TabIndex = 24;
            this.rb_OpenCloseHID.TabStop = true;
            this.rb_OpenCloseHID.Text = "OpenCloseUSB";
            this.rb_OpenCloseHID.UseVisualStyleBackColor = true;
            this.rb_OpenCloseHID.CheckedChanged += new System.EventHandler(this.rb_OpenCloseHID_CheckedChanged);
            // 
            // rb_AutoRcv
            // 
            this.rb_AutoRcv.AutoSize = true;
            this.rb_AutoRcv.Location = new System.Drawing.Point(11, 309);
            this.rb_AutoRcv.Name = "rb_AutoRcv";
            this.rb_AutoRcv.Size = new System.Drawing.Size(89, 16);
            this.rb_AutoRcv.TabIndex = 23;
            this.rb_AutoRcv.TabStop = true;
            this.rb_AutoRcv.Text = "AutoReceive";
            this.rb_AutoRcv.UseVisualStyleBackColor = true;
            this.rb_AutoRcv.CheckedChanged += new System.EventHandler(this.rb_AutoRcv_CheckedChanged);
            // 
            // rb_EnableBuzzer
            // 
            this.rb_EnableBuzzer.AutoSize = true;
            this.rb_EnableBuzzer.Location = new System.Drawing.Point(142, 231);
            this.rb_EnableBuzzer.Name = "rb_EnableBuzzer";
            this.rb_EnableBuzzer.Size = new System.Drawing.Size(95, 16);
            this.rb_EnableBuzzer.TabIndex = 22;
            this.rb_EnableBuzzer.TabStop = true;
            this.rb_EnableBuzzer.Text = "EnableBuzzer";
            this.rb_EnableBuzzer.UseVisualStyleBackColor = true;
            this.rb_EnableBuzzer.CheckedChanged += new System.EventHandler(this.rb_EnableBuzzer_CheckedChanged);
            // 
            // rb_GetAll
            // 
            this.rb_GetAll.AutoSize = true;
            this.rb_GetAll.Location = new System.Drawing.Point(11, 287);
            this.rb_GetAll.Name = "rb_GetAll";
            this.rb_GetAll.Size = new System.Drawing.Size(95, 16);
            this.rb_GetAll.TabIndex = 21;
            this.rb_GetAll.TabStop = true;
            this.rb_GetAll.Text = "GetAllTagNum";
            this.rb_GetAll.UseVisualStyleBackColor = true;
            this.rb_GetAll.CheckedChanged += new System.EventHandler(this.rb_GetAll_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(11, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "Special Command";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(11, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "ISO 15693 Command";
            // 
            // rb_ReadMultiBlock
            // 
            this.rb_ReadMultiBlock.AutoSize = true;
            this.rb_ReadMultiBlock.Location = new System.Drawing.Point(11, 143);
            this.rb_ReadMultiBlock.Name = "rb_ReadMultiBlock";
            this.rb_ReadMultiBlock.Size = new System.Drawing.Size(107, 16);
            this.rb_ReadMultiBlock.TabIndex = 15;
            this.rb_ReadMultiBlock.TabStop = true;
            this.rb_ReadMultiBlock.Text = "ReadMultiBlock";
            this.rb_ReadMultiBlock.UseVisualStyleBackColor = true;
            this.rb_ReadMultiBlock.CheckedChanged += new System.EventHandler(this.rb_ReadMultiBlock_CheckedChanged);
            // 
            // rb_WriteSingleBlock
            // 
            this.rb_WriteSingleBlock.AutoSize = true;
            this.rb_WriteSingleBlock.Location = new System.Drawing.Point(11, 121);
            this.rb_WriteSingleBlock.Name = "rb_WriteSingleBlock";
            this.rb_WriteSingleBlock.Size = new System.Drawing.Size(119, 16);
            this.rb_WriteSingleBlock.TabIndex = 14;
            this.rb_WriteSingleBlock.TabStop = true;
            this.rb_WriteSingleBlock.Text = "WriteSingleBlock";
            this.rb_WriteSingleBlock.UseVisualStyleBackColor = true;
            this.rb_WriteSingleBlock.CheckedChanged += new System.EventHandler(this.rb_WriteSingleBlock_CheckedChanged);
            // 
            // rb_GetMultiBlockSec
            // 
            this.rb_GetMultiBlockSec.AutoSize = true;
            this.rb_GetMultiBlockSec.Location = new System.Drawing.Point(142, 209);
            this.rb_GetMultiBlockSec.Name = "rb_GetMultiBlockSec";
            this.rb_GetMultiBlockSec.Size = new System.Drawing.Size(119, 16);
            this.rb_GetMultiBlockSec.TabIndex = 13;
            this.rb_GetMultiBlockSec.TabStop = true;
            this.rb_GetMultiBlockSec.Text = "GetMultiBlockSec";
            this.rb_GetMultiBlockSec.UseVisualStyleBackColor = true;
            this.rb_GetMultiBlockSec.CheckedChanged += new System.EventHandler(this.rb_GetMultiBlockSec_CheckedChanged);
            // 
            // rb_GetSystemInfo
            // 
            this.rb_GetSystemInfo.AutoSize = true;
            this.rb_GetSystemInfo.Location = new System.Drawing.Point(142, 187);
            this.rb_GetSystemInfo.Name = "rb_GetSystemInfo";
            this.rb_GetSystemInfo.Size = new System.Drawing.Size(101, 16);
            this.rb_GetSystemInfo.TabIndex = 12;
            this.rb_GetSystemInfo.TabStop = true;
            this.rb_GetSystemInfo.Text = "GetSystemInfo";
            this.rb_GetSystemInfo.UseVisualStyleBackColor = true;
            this.rb_GetSystemInfo.CheckedChanged += new System.EventHandler(this.rb_GetSystemInfo_CheckedChanged);
            // 
            // rb_LockDSFID
            // 
            this.rb_LockDSFID.AutoSize = true;
            this.rb_LockDSFID.Location = new System.Drawing.Point(142, 165);
            this.rb_LockDSFID.Name = "rb_LockDSFID";
            this.rb_LockDSFID.Size = new System.Drawing.Size(77, 16);
            this.rb_LockDSFID.TabIndex = 11;
            this.rb_LockDSFID.TabStop = true;
            this.rb_LockDSFID.Text = "LockDSFID";
            this.rb_LockDSFID.UseVisualStyleBackColor = true;
            this.rb_LockDSFID.CheckedChanged += new System.EventHandler(this.rb_LockDSFID_CheckedChanged);
            // 
            // rb_WriteDSFID
            // 
            this.rb_WriteDSFID.AutoSize = true;
            this.rb_WriteDSFID.Location = new System.Drawing.Point(142, 143);
            this.rb_WriteDSFID.Name = "rb_WriteDSFID";
            this.rb_WriteDSFID.Size = new System.Drawing.Size(83, 16);
            this.rb_WriteDSFID.TabIndex = 10;
            this.rb_WriteDSFID.TabStop = true;
            this.rb_WriteDSFID.Text = "WriteDSFID";
            this.rb_WriteDSFID.UseVisualStyleBackColor = true;
            this.rb_WriteDSFID.CheckedChanged += new System.EventHandler(this.rb_WriteDSFID_CheckedChanged);
            // 
            // rb_LockAFI
            // 
            this.rb_LockAFI.AutoSize = true;
            this.rb_LockAFI.Location = new System.Drawing.Point(142, 121);
            this.rb_LockAFI.Name = "rb_LockAFI";
            this.rb_LockAFI.Size = new System.Drawing.Size(65, 16);
            this.rb_LockAFI.TabIndex = 9;
            this.rb_LockAFI.TabStop = true;
            this.rb_LockAFI.Text = "LockAFI";
            this.rb_LockAFI.UseVisualStyleBackColor = true;
            this.rb_LockAFI.CheckedChanged += new System.EventHandler(this.rb_LockAFI_CheckedChanged);
            // 
            // rb_WriteAFI
            // 
            this.rb_WriteAFI.AutoSize = true;
            this.rb_WriteAFI.Location = new System.Drawing.Point(142, 99);
            this.rb_WriteAFI.Name = "rb_WriteAFI";
            this.rb_WriteAFI.Size = new System.Drawing.Size(71, 16);
            this.rb_WriteAFI.TabIndex = 8;
            this.rb_WriteAFI.TabStop = true;
            this.rb_WriteAFI.Text = "WriteAFI";
            this.rb_WriteAFI.UseVisualStyleBackColor = true;
            this.rb_WriteAFI.CheckedChanged += new System.EventHandler(this.rb_WriteAFI_CheckedChanged);
            // 
            // rb_ResetToReady
            // 
            this.rb_ResetToReady.AutoSize = true;
            this.rb_ResetToReady.Location = new System.Drawing.Point(142, 77);
            this.rb_ResetToReady.Name = "rb_ResetToReady";
            this.rb_ResetToReady.Size = new System.Drawing.Size(95, 16);
            this.rb_ResetToReady.TabIndex = 7;
            this.rb_ResetToReady.TabStop = true;
            this.rb_ResetToReady.Text = "ResetToReady";
            this.rb_ResetToReady.UseVisualStyleBackColor = true;
            this.rb_ResetToReady.CheckedChanged += new System.EventHandler(this.rb_ResetToReady_CheckedChanged);
            // 
            // rb_Select
            // 
            this.rb_Select.AutoSize = true;
            this.rb_Select.Location = new System.Drawing.Point(11, 231);
            this.rb_Select.Name = "rb_Select";
            this.rb_Select.Size = new System.Drawing.Size(59, 16);
            this.rb_Select.TabIndex = 6;
            this.rb_Select.TabStop = true;
            this.rb_Select.Text = "Select";
            this.rb_Select.UseVisualStyleBackColor = true;
            this.rb_Select.CheckedChanged += new System.EventHandler(this.rb_Select_CheckedChanged);
            // 
            // rb_StayQuiet
            // 
            this.rb_StayQuiet.AutoSize = true;
            this.rb_StayQuiet.Location = new System.Drawing.Point(11, 209);
            this.rb_StayQuiet.Name = "rb_StayQuiet";
            this.rb_StayQuiet.Size = new System.Drawing.Size(77, 16);
            this.rb_StayQuiet.TabIndex = 5;
            this.rb_StayQuiet.TabStop = true;
            this.rb_StayQuiet.Text = "StayQuiet";
            this.rb_StayQuiet.UseVisualStyleBackColor = true;
            this.rb_StayQuiet.CheckedChanged += new System.EventHandler(this.rb_StayQuiet_CheckedChanged);
            // 
            // rb_LockBlock
            // 
            this.rb_LockBlock.AutoSize = true;
            this.rb_LockBlock.Location = new System.Drawing.Point(11, 187);
            this.rb_LockBlock.Name = "rb_LockBlock";
            this.rb_LockBlock.Size = new System.Drawing.Size(77, 16);
            this.rb_LockBlock.TabIndex = 4;
            this.rb_LockBlock.TabStop = true;
            this.rb_LockBlock.Text = "LockBlock";
            this.rb_LockBlock.UseVisualStyleBackColor = true;
            this.rb_LockBlock.CheckedChanged += new System.EventHandler(this.rb_LockBlock_CheckedChanged);
            // 
            // rb_WriteMultiBlock
            // 
            this.rb_WriteMultiBlock.AutoSize = true;
            this.rb_WriteMultiBlock.Location = new System.Drawing.Point(11, 165);
            this.rb_WriteMultiBlock.Name = "rb_WriteMultiBlock";
            this.rb_WriteMultiBlock.Size = new System.Drawing.Size(113, 16);
            this.rb_WriteMultiBlock.TabIndex = 3;
            this.rb_WriteMultiBlock.TabStop = true;
            this.rb_WriteMultiBlock.Text = "WriteMultiBlock";
            this.rb_WriteMultiBlock.UseVisualStyleBackColor = true;
            this.rb_WriteMultiBlock.CheckedChanged += new System.EventHandler(this.rb_WriteMultiBlock_CheckedChanged);
            // 
            // rb_ReadSingleBolock
            // 
            this.rb_ReadSingleBolock.AutoSize = true;
            this.rb_ReadSingleBolock.Location = new System.Drawing.Point(11, 99);
            this.rb_ReadSingleBolock.Name = "rb_ReadSingleBolock";
            this.rb_ReadSingleBolock.Size = new System.Drawing.Size(119, 16);
            this.rb_ReadSingleBolock.TabIndex = 2;
            this.rb_ReadSingleBolock.TabStop = true;
            this.rb_ReadSingleBolock.Text = "ReadSingleBolock";
            this.rb_ReadSingleBolock.UseVisualStyleBackColor = true;
            this.rb_ReadSingleBolock.CheckedChanged += new System.EventHandler(this.rb_ReadSingleBolock_CheckedChanged);
            // 
            // rb_Inventory
            // 
            this.rb_Inventory.AutoSize = true;
            this.rb_Inventory.Location = new System.Drawing.Point(11, 77);
            this.rb_Inventory.Name = "rb_Inventory";
            this.rb_Inventory.Size = new System.Drawing.Size(77, 16);
            this.rb_Inventory.TabIndex = 1;
            this.rb_Inventory.TabStop = true;
            this.rb_Inventory.Text = "Inventory";
            this.rb_Inventory.UseVisualStyleBackColor = true;
            this.rb_Inventory.CheckedChanged += new System.EventHandler(this.rb_Inventory_CheckedChanged);
            // 
            // rb_OpenCloseComm
            // 
            this.rb_OpenCloseComm.AutoSize = true;
            this.rb_OpenCloseComm.Location = new System.Drawing.Point(11, 20);
            this.rb_OpenCloseComm.Name = "rb_OpenCloseComm";
            this.rb_OpenCloseComm.Size = new System.Drawing.Size(101, 16);
            this.rb_OpenCloseComm.TabIndex = 0;
            this.rb_OpenCloseComm.TabStop = true;
            this.rb_OpenCloseComm.Text = "OpenCloseComm";
            this.rb_OpenCloseComm.UseVisualStyleBackColor = true;
            this.rb_OpenCloseComm.CheckedChanged += new System.EventHandler(this.rb_OpenCloseComm_CheckedChanged);
            // 
            // btn_ClearListBox1
            // 
            this.btn_ClearListBox1.Location = new System.Drawing.Point(436, 322);
            this.btn_ClearListBox1.Name = "btn_ClearListBox1";
            this.btn_ClearListBox1.Size = new System.Drawing.Size(43, 23);
            this.btn_ClearListBox1.TabIndex = 3;
            this.btn_ClearListBox1.Text = "Clear";
            this.btn_ClearListBox1.UseVisualStyleBackColor = true;
            this.btn_ClearListBox1.Click += new System.EventHandler(this.btn_ClearListBox1_Click);
            // 
            // lst_Info
            // 
            this.lst_Info.FormattingEnabled = true;
            this.lst_Info.ItemHeight = 12;
            this.lst_Info.Location = new System.Drawing.Point(485, 6);
            this.lst_Info.Name = "lst_Info";
            this.lst_Info.Size = new System.Drawing.Size(290, 340);
            this.lst_Info.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Clear);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lst_Info_Cfg);
            this.tabPage2.Controls.Add(this.gb_ReaderConfig);
            this.tabPage2.Controls.Add(this.gb_MultiplexConfig);
            this.tabPage2.Controls.Add(this.gb_TagItConfig);
            this.tabPage2.Controls.Add(this.gb_ICodeConfig);
            this.tabPage2.Controls.Add(this.gb_TimingConfig);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(721, 323);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(53, 23);
            this.btn_Clear.TabIndex = 43;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Refresh);
            this.groupBox3.Controls.Add(this.btn_Close);
            this.groupBox3.Controls.Add(this.btn_Open);
            this.groupBox3.Controls.Add(this.cmb_BaudRate1);
            this.groupBox3.Controls.Add(this.label76);
            this.groupBox3.Controls.Add(this.cmb_PortName);
            this.groupBox3.Controls.Add(this.label75);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 140);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SerialPort";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(66, 107);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(60, 23);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(66, 77);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(60, 23);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(7, 77);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(53, 23);
            this.btn_Open.TabIndex = 5;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // cmb_BaudRate1
            // 
            this.cmb_BaudRate1.FormattingEnabled = true;
            this.cmb_BaudRate1.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmb_BaudRate1.Location = new System.Drawing.Point(61, 49);
            this.cmb_BaudRate1.Name = "cmb_BaudRate1";
            this.cmb_BaudRate1.Size = new System.Drawing.Size(65, 20);
            this.cmb_BaudRate1.TabIndex = 4;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(5, 57);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(53, 12);
            this.label76.TabIndex = 3;
            this.label76.Text = "BaudRate";
            // 
            // cmb_PortName
            // 
            this.cmb_PortName.FormattingEnabled = true;
            this.cmb_PortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.cmb_PortName.Location = new System.Drawing.Point(61, 21);
            this.cmb_PortName.Name = "cmb_PortName";
            this.cmb_PortName.Size = new System.Drawing.Size(65, 20);
            this.cmb_PortName.TabIndex = 2;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(5, 29);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(53, 12);
            this.label75.TabIndex = 0;
            this.label75.Text = "PortName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_ChannelConfig);
            this.groupBox2.Controls.Add(this.rb_MultiplexConfig);
            this.groupBox2.Controls.Add(this.rb_TagItConfig);
            this.groupBox2.Controls.Add(this.rb_ICodeConfig);
            this.groupBox2.Controls.Add(this.rb_TimingConfig);
            this.groupBox2.Controls.Add(this.rb_ReaderConfig);
            this.groupBox2.Location = new System.Drawing.Point(6, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation List";
            // 
            // rb_ChannelConfig
            // 
            this.rb_ChannelConfig.AutoSize = true;
            this.rb_ChannelConfig.Location = new System.Drawing.Point(6, 160);
            this.rb_ChannelConfig.Name = "rb_ChannelConfig";
            this.rb_ChannelConfig.Size = new System.Drawing.Size(107, 16);
            this.rb_ChannelConfig.TabIndex = 5;
            this.rb_ChannelConfig.Text = "Channel Config";
            this.rb_ChannelConfig.UseVisualStyleBackColor = true;
            this.rb_ChannelConfig.CheckedChanged += new System.EventHandler(this.rb_ChannelConfig_CheckedChanged);
            // 
            // rb_MultiplexConfig
            // 
            this.rb_MultiplexConfig.AutoSize = true;
            this.rb_MultiplexConfig.Location = new System.Drawing.Point(6, 133);
            this.rb_MultiplexConfig.Name = "rb_MultiplexConfig";
            this.rb_MultiplexConfig.Size = new System.Drawing.Size(119, 16);
            this.rb_MultiplexConfig.TabIndex = 4;
            this.rb_MultiplexConfig.Text = "Multiplex Config";
            this.rb_MultiplexConfig.UseVisualStyleBackColor = true;
            this.rb_MultiplexConfig.CheckedChanged += new System.EventHandler(this.rb_MultiplexConfig_CheckedChanged);
            // 
            // rb_TagItConfig
            // 
            this.rb_TagItConfig.AutoSize = true;
            this.rb_TagItConfig.Location = new System.Drawing.Point(7, 104);
            this.rb_TagItConfig.Name = "rb_TagItConfig";
            this.rb_TagItConfig.Size = new System.Drawing.Size(101, 16);
            this.rb_TagItConfig.TabIndex = 3;
            this.rb_TagItConfig.Text = "Tag-It Config";
            this.rb_TagItConfig.UseVisualStyleBackColor = true;
            this.rb_TagItConfig.CheckedChanged += new System.EventHandler(this.rb_TagItConfig_CheckedChanged);
            // 
            // rb_ICodeConfig
            // 
            this.rb_ICodeConfig.AutoSize = true;
            this.rb_ICodeConfig.Location = new System.Drawing.Point(6, 77);
            this.rb_ICodeConfig.Name = "rb_ICodeConfig";
            this.rb_ICodeConfig.Size = new System.Drawing.Size(101, 16);
            this.rb_ICodeConfig.TabIndex = 2;
            this.rb_ICodeConfig.Text = "I-Code Config";
            this.rb_ICodeConfig.UseVisualStyleBackColor = true;
            this.rb_ICodeConfig.CheckedChanged += new System.EventHandler(this.rb_ICodeConfig_CheckedChanged);
            // 
            // rb_TimingConfig
            // 
            this.rb_TimingConfig.AutoSize = true;
            this.rb_TimingConfig.Location = new System.Drawing.Point(6, 50);
            this.rb_TimingConfig.Name = "rb_TimingConfig";
            this.rb_TimingConfig.Size = new System.Drawing.Size(101, 16);
            this.rb_TimingConfig.TabIndex = 1;
            this.rb_TimingConfig.Text = "Timing Config";
            this.rb_TimingConfig.UseVisualStyleBackColor = true;
            this.rb_TimingConfig.CheckedChanged += new System.EventHandler(this.rb_TimingConfig_CheckedChanged);
            // 
            // rb_ReaderConfig
            // 
            this.rb_ReaderConfig.AutoSize = true;
            this.rb_ReaderConfig.Checked = true;
            this.rb_ReaderConfig.Location = new System.Drawing.Point(7, 25);
            this.rb_ReaderConfig.Name = "rb_ReaderConfig";
            this.rb_ReaderConfig.Size = new System.Drawing.Size(101, 16);
            this.rb_ReaderConfig.TabIndex = 0;
            this.rb_ReaderConfig.TabStop = true;
            this.rb_ReaderConfig.Text = "Reader Config";
            this.rb_ReaderConfig.UseVisualStyleBackColor = true;
            this.rb_ReaderConfig.CheckedChanged += new System.EventHandler(this.rb_ReaderConfig_CheckedChanged);
            // 
            // lst_Info_Cfg
            // 
            this.lst_Info_Cfg.FormattingEnabled = true;
            this.lst_Info_Cfg.HorizontalScrollbar = true;
            this.lst_Info_Cfg.ItemHeight = 12;
            this.lst_Info_Cfg.Location = new System.Drawing.Point(485, 6);
            this.lst_Info_Cfg.Name = "lst_Info_Cfg";
            this.lst_Info_Cfg.Size = new System.Drawing.Size(290, 340);
            this.lst_Info_Cfg.TabIndex = 0;
            // 
            // gb_ReaderConfig
            // 
            this.gb_ReaderConfig.Controls.Add(this.btn_SetReader);
            this.gb_ReaderConfig.Controls.Add(this.btn_GetReader);
            this.gb_ReaderConfig.Controls.Add(this.btn_LoadReader);
            this.gb_ReaderConfig.Controls.Add(this.txt_EOFASK_2);
            this.gb_ReaderConfig.Controls.Add(this.txt_SOFASK_2);
            this.gb_ReaderConfig.Controls.Add(this.txt_EOFFSK_2);
            this.gb_ReaderConfig.Controls.Add(this.txt_SOFFSK_2);
            this.gb_ReaderConfig.Controls.Add(this.txt_EOFASK_1);
            this.gb_ReaderConfig.Controls.Add(this.txt_SOFASK_1);
            this.gb_ReaderConfig.Controls.Add(this.txt_EOFFSK_1);
            this.gb_ReaderConfig.Controls.Add(this.txt_SOFFSK_1);
            this.gb_ReaderConfig.Controls.Add(this.txt_SOFEOF);
            this.gb_ReaderConfig.Controls.Add(this.txt_ISOASK);
            this.gb_ReaderConfig.Controls.Add(this.txt_ISOFSK);
            this.gb_ReaderConfig.Controls.Add(this.txt_RealTimeClock);
            this.gb_ReaderConfig.Controls.Add(this.txt_Index);
            this.gb_ReaderConfig.Controls.Add(this.label61);
            this.gb_ReaderConfig.Controls.Add(this.txt_Energy);
            this.gb_ReaderConfig.Controls.Add(this.label60);
            this.gb_ReaderConfig.Controls.Add(this.txt_TempReset);
            this.gb_ReaderConfig.Controls.Add(this.label59);
            this.gb_ReaderConfig.Controls.Add(this.txt_TempAlarm);
            this.gb_ReaderConfig.Controls.Add(this.label58);
            this.gb_ReaderConfig.Controls.Add(this.label57);
            this.gb_ReaderConfig.Controls.Add(this.label56);
            this.gb_ReaderConfig.Controls.Add(this.label55);
            this.gb_ReaderConfig.Controls.Add(this.label54);
            this.gb_ReaderConfig.Controls.Add(this.label53);
            this.gb_ReaderConfig.Controls.Add(this.label52);
            this.gb_ReaderConfig.Controls.Add(this.label51);
            this.gb_ReaderConfig.Controls.Add(this.label50);
            this.gb_ReaderConfig.Controls.Add(this.label49);
            this.gb_ReaderConfig.Controls.Add(this.label47);
            this.gb_ReaderConfig.Controls.Add(this.label46);
            this.gb_ReaderConfig.Location = new System.Drawing.Point(157, 6);
            this.gb_ReaderConfig.Name = "gb_ReaderConfig";
            this.gb_ReaderConfig.Size = new System.Drawing.Size(322, 340);
            this.gb_ReaderConfig.TabIndex = 2;
            this.gb_ReaderConfig.TabStop = false;
            this.gb_ReaderConfig.Text = "Reader Config";
            // 
            // btn_SetReader
            // 
            this.btn_SetReader.Location = new System.Drawing.Point(225, 306);
            this.btn_SetReader.Name = "btn_SetReader";
            this.btn_SetReader.Size = new System.Drawing.Size(87, 23);
            this.btn_SetReader.TabIndex = 36;
            this.btn_SetReader.Text = "Set Config";
            this.btn_SetReader.UseVisualStyleBackColor = true;
            this.btn_SetReader.Click += new System.EventHandler(this.btn_SetReader_Click);
            // 
            // btn_GetReader
            // 
            this.btn_GetReader.Location = new System.Drawing.Point(225, 279);
            this.btn_GetReader.Name = "btn_GetReader";
            this.btn_GetReader.Size = new System.Drawing.Size(87, 23);
            this.btn_GetReader.TabIndex = 35;
            this.btn_GetReader.Text = "Get Config";
            this.btn_GetReader.UseVisualStyleBackColor = true;
            this.btn_GetReader.Click += new System.EventHandler(this.btn_GetReader_Click);
            // 
            // btn_LoadReader
            // 
            this.btn_LoadReader.Location = new System.Drawing.Point(225, 252);
            this.btn_LoadReader.Name = "btn_LoadReader";
            this.btn_LoadReader.Size = new System.Drawing.Size(87, 23);
            this.btn_LoadReader.TabIndex = 34;
            this.btn_LoadReader.Text = "Load Default";
            this.btn_LoadReader.UseVisualStyleBackColor = true;
            this.btn_LoadReader.Click += new System.EventHandler(this.btn_LoadReader_Click);
            // 
            // txt_EOFASK_2
            // 
            this.txt_EOFASK_2.Location = new System.Drawing.Point(170, 308);
            this.txt_EOFASK_2.Name = "txt_EOFASK_2";
            this.txt_EOFASK_2.Size = new System.Drawing.Size(43, 21);
            this.txt_EOFASK_2.TabIndex = 33;
            this.txt_EOFASK_2.Text = "80";
            // 
            // txt_SOFASK_2
            // 
            this.txt_SOFASK_2.Location = new System.Drawing.Point(170, 281);
            this.txt_SOFASK_2.Name = "txt_SOFASK_2";
            this.txt_SOFASK_2.Size = new System.Drawing.Size(43, 21);
            this.txt_SOFASK_2.TabIndex = 32;
            this.txt_SOFASK_2.Text = "80";
            // 
            // txt_EOFFSK_2
            // 
            this.txt_EOFFSK_2.Location = new System.Drawing.Point(170, 254);
            this.txt_EOFFSK_2.Name = "txt_EOFFSK_2";
            this.txt_EOFFSK_2.Size = new System.Drawing.Size(43, 21);
            this.txt_EOFFSK_2.TabIndex = 31;
            this.txt_EOFFSK_2.Text = "60";
            // 
            // txt_SOFFSK_2
            // 
            this.txt_SOFFSK_2.Location = new System.Drawing.Point(170, 227);
            this.txt_SOFFSK_2.Name = "txt_SOFFSK_2";
            this.txt_SOFFSK_2.Size = new System.Drawing.Size(43, 21);
            this.txt_SOFFSK_2.TabIndex = 30;
            this.txt_SOFFSK_2.Text = "60";
            // 
            // txt_EOFASK_1
            // 
            this.txt_EOFASK_1.Location = new System.Drawing.Point(119, 308);
            this.txt_EOFASK_1.Name = "txt_EOFASK_1";
            this.txt_EOFASK_1.Size = new System.Drawing.Size(43, 21);
            this.txt_EOFASK_1.TabIndex = 29;
            this.txt_EOFASK_1.Text = "01";
            // 
            // txt_SOFASK_1
            // 
            this.txt_SOFASK_1.Location = new System.Drawing.Point(119, 281);
            this.txt_SOFASK_1.Name = "txt_SOFASK_1";
            this.txt_SOFASK_1.Size = new System.Drawing.Size(43, 21);
            this.txt_SOFASK_1.TabIndex = 28;
            this.txt_SOFASK_1.Text = "00";
            // 
            // txt_EOFFSK_1
            // 
            this.txt_EOFFSK_1.Location = new System.Drawing.Point(119, 254);
            this.txt_EOFFSK_1.Name = "txt_EOFFSK_1";
            this.txt_EOFFSK_1.Size = new System.Drawing.Size(43, 21);
            this.txt_EOFFSK_1.TabIndex = 27;
            this.txt_EOFFSK_1.Text = "02";
            // 
            // txt_SOFFSK_1
            // 
            this.txt_SOFFSK_1.Location = new System.Drawing.Point(119, 227);
            this.txt_SOFFSK_1.Name = "txt_SOFFSK_1";
            this.txt_SOFFSK_1.Size = new System.Drawing.Size(43, 21);
            this.txt_SOFFSK_1.TabIndex = 26;
            this.txt_SOFFSK_1.Text = "01";
            // 
            // txt_SOFEOF
            // 
            this.txt_SOFEOF.Location = new System.Drawing.Point(119, 200);
            this.txt_SOFEOF.Name = "txt_SOFEOF";
            this.txt_SOFEOF.Size = new System.Drawing.Size(43, 21);
            this.txt_SOFEOF.TabIndex = 25;
            this.txt_SOFEOF.Text = "30";
            // 
            // txt_ISOASK
            // 
            this.txt_ISOASK.Location = new System.Drawing.Point(119, 173);
            this.txt_ISOASK.Name = "txt_ISOASK";
            this.txt_ISOASK.Size = new System.Drawing.Size(43, 21);
            this.txt_ISOASK.TabIndex = 24;
            this.txt_ISOASK.Text = "1F";
            // 
            // txt_ISOFSK
            // 
            this.txt_ISOFSK.Location = new System.Drawing.Point(119, 146);
            this.txt_ISOFSK.Name = "txt_ISOFSK";
            this.txt_ISOFSK.Size = new System.Drawing.Size(43, 21);
            this.txt_ISOFSK.TabIndex = 23;
            this.txt_ISOFSK.Text = "19";
            // 
            // txt_RealTimeClock
            // 
            this.txt_RealTimeClock.Location = new System.Drawing.Point(119, 119);
            this.txt_RealTimeClock.Name = "txt_RealTimeClock";
            this.txt_RealTimeClock.Size = new System.Drawing.Size(43, 21);
            this.txt_RealTimeClock.TabIndex = 22;
            this.txt_RealTimeClock.Text = "10";
            // 
            // txt_Index
            // 
            this.txt_Index.Location = new System.Drawing.Point(119, 92);
            this.txt_Index.Name = "txt_Index";
            this.txt_Index.Size = new System.Drawing.Size(43, 21);
            this.txt_Index.TabIndex = 21;
            this.txt_Index.Text = "1E";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(168, 74);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(29, 12);
            this.label61.TabIndex = 20;
            this.label61.Text = "Watt";
            // 
            // txt_Energy
            // 
            this.txt_Energy.Location = new System.Drawing.Point(119, 65);
            this.txt_Energy.Name = "txt_Energy";
            this.txt_Energy.Size = new System.Drawing.Size(43, 21);
            this.txt_Energy.TabIndex = 19;
            this.txt_Energy.Text = "1.5";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(168, 47);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(41, 12);
            this.label60.TabIndex = 18;
            this.label60.Text = "Deg. C";
            // 
            // txt_TempReset
            // 
            this.txt_TempReset.Location = new System.Drawing.Point(119, 38);
            this.txt_TempReset.Name = "txt_TempReset";
            this.txt_TempReset.Size = new System.Drawing.Size(43, 21);
            this.txt_TempReset.TabIndex = 17;
            this.txt_TempReset.Text = "50";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(168, 20);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(41, 12);
            this.label59.TabIndex = 16;
            this.label59.Text = "Deg. C";
            // 
            // txt_TempAlarm
            // 
            this.txt_TempAlarm.Location = new System.Drawing.Point(119, 11);
            this.txt_TempAlarm.Name = "txt_TempAlarm";
            this.txt_TempAlarm.Size = new System.Drawing.Size(43, 21);
            this.txt_TempAlarm.TabIndex = 15;
            this.txt_TempAlarm.Text = "60";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 317);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(89, 12);
            this.label58.TabIndex = 14;
            this.label58.Text = "EOF ASK Thresh";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 290);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(89, 12);
            this.label57.TabIndex = 13;
            this.label57.Text = "SOF ASK Thresh";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 263);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(89, 12);
            this.label56.TabIndex = 12;
            this.label56.Text = "EOF FSK Thresh";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 236);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(89, 12);
            this.label55.TabIndex = 11;
            this.label55.Text = "SOF FSK Thresh";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 209);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(89, 12);
            this.label54.TabIndex = 10;
            this.label54.Text = "SOF EOF Margin";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 182);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(107, 12);
            this.label53.TabIndex = 9;
            this.label53.Text = "ISO ASK Collision";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 155);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(107, 12);
            this.label52.TabIndex = 8;
            this.label52.Text = "ISO FSK Collision";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 128);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(95, 12);
            this.label51.TabIndex = 7;
            this.label51.Text = "Real Time Clock";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 101);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(35, 12);
            this.label50.TabIndex = 6;
            this.label50.Text = "Index";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 74);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 12);
            this.label49.TabIndex = 5;
            this.label49.Text = "Energy";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 47);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(107, 12);
            this.label47.TabIndex = 1;
            this.label47.Text = "Temp. Reset Value";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 20);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(107, 12);
            this.label46.TabIndex = 0;
            this.label46.Text = "Temp. Alarm Value";
            // 
            // gb_MultiplexConfig
            // 
            this.gb_MultiplexConfig.Controls.Add(this.btn_Switch);
            this.gb_MultiplexConfig.Controls.Add(this.txt_Antenna);
            this.gb_MultiplexConfig.Controls.Add(this.label77);
            this.gb_MultiplexConfig.Controls.Add(this.chk_PhaseShift);
            this.gb_MultiplexConfig.Controls.Add(this.panel3);
            this.gb_MultiplexConfig.Controls.Add(this.label72);
            this.gb_MultiplexConfig.Controls.Add(this.btn_SetMultiplex);
            this.gb_MultiplexConfig.Controls.Add(this.btn_GetMultiplex);
            this.gb_MultiplexConfig.Controls.Add(this.btn_LoadMultiplex);
            this.gb_MultiplexConfig.Controls.Add(this.txt_AntennaTries);
            this.gb_MultiplexConfig.Controls.Add(this.txt_AntennaCount);
            this.gb_MultiplexConfig.Controls.Add(this.label73);
            this.gb_MultiplexConfig.Controls.Add(this.label74);
            this.gb_MultiplexConfig.Location = new System.Drawing.Point(157, 6);
            this.gb_MultiplexConfig.Name = "gb_MultiplexConfig";
            this.gb_MultiplexConfig.Size = new System.Drawing.Size(322, 340);
            this.gb_MultiplexConfig.TabIndex = 41;
            this.gb_MultiplexConfig.TabStop = false;
            this.gb_MultiplexConfig.Text = "Multiplex Config";
            // 
            // btn_Switch
            // 
            this.btn_Switch.Location = new System.Drawing.Point(162, 252);
            this.btn_Switch.Name = "btn_Switch";
            this.btn_Switch.Size = new System.Drawing.Size(131, 23);
            this.btn_Switch.TabIndex = 44;
            this.btn_Switch.Text = "Switch Antenna";
            this.btn_Switch.UseVisualStyleBackColor = true;
            this.btn_Switch.Click += new System.EventHandler(this.btn_Switch_Click);
            // 
            // txt_Antenna
            // 
            this.txt_Antenna.Location = new System.Drawing.Point(113, 252);
            this.txt_Antenna.Name = "txt_Antenna";
            this.txt_Antenna.Size = new System.Drawing.Size(43, 21);
            this.txt_Antenna.TabIndex = 43;
            this.txt_Antenna.Text = "01";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(18, 261);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(89, 12);
            this.label77.TabIndex = 42;
            this.label77.Text = "Antenna Number";
            // 
            // chk_PhaseShift
            // 
            this.chk_PhaseShift.AutoSize = true;
            this.chk_PhaseShift.Location = new System.Drawing.Point(107, 169);
            this.chk_PhaseShift.Name = "chk_PhaseShift";
            this.chk_PhaseShift.Size = new System.Drawing.Size(15, 14);
            this.chk_PhaseShift.TabIndex = 41;
            this.chk_PhaseShift.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rb_MultiplexGates);
            this.panel3.Controls.Add(this.rb_SingleAxisGate);
            this.panel3.Controls.Add(this.rb_SingleAntenna);
            this.panel3.Location = new System.Drawing.Point(15, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 80);
            this.panel3.TabIndex = 40;
            // 
            // rb_MultiplexGates
            // 
            this.rb_MultiplexGates.AutoSize = true;
            this.rb_MultiplexGates.Location = new System.Drawing.Point(11, 53);
            this.rb_MultiplexGates.Name = "rb_MultiplexGates";
            this.rb_MultiplexGates.Size = new System.Drawing.Size(113, 16);
            this.rb_MultiplexGates.TabIndex = 2;
            this.rb_MultiplexGates.TabStop = true;
            this.rb_MultiplexGates.Text = "Multiplex Gates";
            this.rb_MultiplexGates.UseVisualStyleBackColor = true;
            // 
            // rb_SingleAxisGate
            // 
            this.rb_SingleAxisGate.AutoSize = true;
            this.rb_SingleAxisGate.Location = new System.Drawing.Point(10, 31);
            this.rb_SingleAxisGate.Name = "rb_SingleAxisGate";
            this.rb_SingleAxisGate.Size = new System.Drawing.Size(119, 16);
            this.rb_SingleAxisGate.TabIndex = 1;
            this.rb_SingleAxisGate.TabStop = true;
            this.rb_SingleAxisGate.Text = "Single Axis Gate";
            this.rb_SingleAxisGate.UseVisualStyleBackColor = true;
            // 
            // rb_SingleAntenna
            // 
            this.rb_SingleAntenna.AutoSize = true;
            this.rb_SingleAntenna.Checked = true;
            this.rb_SingleAntenna.Location = new System.Drawing.Point(10, 9);
            this.rb_SingleAntenna.Name = "rb_SingleAntenna";
            this.rb_SingleAntenna.Size = new System.Drawing.Size(107, 16);
            this.rb_SingleAntenna.TabIndex = 0;
            this.rb_SingleAntenna.TabStop = true;
            this.rb_SingleAntenna.Text = "Single Antenna";
            this.rb_SingleAntenna.UseVisualStyleBackColor = true;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(18, 118);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(83, 12);
            this.label72.TabIndex = 37;
            this.label72.Text = "Antenna Count";
            // 
            // btn_SetMultiplex
            // 
            this.btn_SetMultiplex.Location = new System.Drawing.Point(206, 193);
            this.btn_SetMultiplex.Name = "btn_SetMultiplex";
            this.btn_SetMultiplex.Size = new System.Drawing.Size(87, 23);
            this.btn_SetMultiplex.TabIndex = 36;
            this.btn_SetMultiplex.Text = "Set Config";
            this.btn_SetMultiplex.UseVisualStyleBackColor = true;
            this.btn_SetMultiplex.Click += new System.EventHandler(this.btn_SetMultiplex_Click);
            // 
            // btn_GetMultiplex
            // 
            this.btn_GetMultiplex.Location = new System.Drawing.Point(113, 193);
            this.btn_GetMultiplex.Name = "btn_GetMultiplex";
            this.btn_GetMultiplex.Size = new System.Drawing.Size(87, 23);
            this.btn_GetMultiplex.TabIndex = 35;
            this.btn_GetMultiplex.Text = "Get Config";
            this.btn_GetMultiplex.UseVisualStyleBackColor = true;
            this.btn_GetMultiplex.Click += new System.EventHandler(this.btn_GetMultiplex_Click);
            // 
            // btn_LoadMultiplex
            // 
            this.btn_LoadMultiplex.Location = new System.Drawing.Point(20, 193);
            this.btn_LoadMultiplex.Name = "btn_LoadMultiplex";
            this.btn_LoadMultiplex.Size = new System.Drawing.Size(87, 23);
            this.btn_LoadMultiplex.TabIndex = 34;
            this.btn_LoadMultiplex.Text = "Load Default";
            this.btn_LoadMultiplex.UseVisualStyleBackColor = true;
            this.btn_LoadMultiplex.Click += new System.EventHandler(this.btn_LoadMultiplex_Click);
            // 
            // txt_AntennaTries
            // 
            this.txt_AntennaTries.Location = new System.Drawing.Point(107, 136);
            this.txt_AntennaTries.Name = "txt_AntennaTries";
            this.txt_AntennaTries.Size = new System.Drawing.Size(43, 21);
            this.txt_AntennaTries.TabIndex = 27;
            this.txt_AntennaTries.Text = "0A";
            // 
            // txt_AntennaCount
            // 
            this.txt_AntennaCount.Location = new System.Drawing.Point(107, 109);
            this.txt_AntennaCount.Name = "txt_AntennaCount";
            this.txt_AntennaCount.Size = new System.Drawing.Size(43, 21);
            this.txt_AntennaCount.TabIndex = 26;
            this.txt_AntennaCount.Text = "04";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(18, 172);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(77, 12);
            this.label73.TabIndex = 13;
            this.label73.Text = "Phase Shift?";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(18, 145);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(83, 12);
            this.label74.TabIndex = 11;
            this.label74.Text = "Antenna Tries";
            // 
            // gb_TagItConfig
            // 
            this.gb_TagItConfig.Controls.Add(this.txt_EndOfFrame_2);
            this.gb_TagItConfig.Controls.Add(this.txt_StartOfFrame_2);
            this.gb_TagItConfig.Controls.Add(this.label64);
            this.gb_TagItConfig.Controls.Add(this.btn_SetTagIt);
            this.gb_TagItConfig.Controls.Add(this.btn_GetTagIt);
            this.gb_TagItConfig.Controls.Add(this.btn_LoadTagIt);
            this.gb_TagItConfig.Controls.Add(this.txt_EndOfFrame_1);
            this.gb_TagItConfig.Controls.Add(this.txt_StartOfFrame_1);
            this.gb_TagItConfig.Controls.Add(this.txt_CollisionMarginTagIt);
            this.gb_TagItConfig.Controls.Add(this.label70);
            this.gb_TagItConfig.Controls.Add(this.label71);
            this.gb_TagItConfig.Location = new System.Drawing.Point(157, 6);
            this.gb_TagItConfig.Name = "gb_TagItConfig";
            this.gb_TagItConfig.Size = new System.Drawing.Size(322, 340);
            this.gb_TagItConfig.TabIndex = 40;
            this.gb_TagItConfig.TabStop = false;
            this.gb_TagItConfig.Text = "Tag-It Config";
            // 
            // txt_EndOfFrame_2
            // 
            this.txt_EndOfFrame_2.Location = new System.Drawing.Point(181, 74);
            this.txt_EndOfFrame_2.Name = "txt_EndOfFrame_2";
            this.txt_EndOfFrame_2.Size = new System.Drawing.Size(43, 21);
            this.txt_EndOfFrame_2.TabIndex = 39;
            this.txt_EndOfFrame_2.Text = "20";
            // 
            // txt_StartOfFrame_2
            // 
            this.txt_StartOfFrame_2.Location = new System.Drawing.Point(181, 47);
            this.txt_StartOfFrame_2.Name = "txt_StartOfFrame_2";
            this.txt_StartOfFrame_2.Size = new System.Drawing.Size(43, 21);
            this.txt_StartOfFrame_2.TabIndex = 38;
            this.txt_StartOfFrame_2.Text = "80";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(13, 29);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(101, 12);
            this.label64.TabIndex = 37;
            this.label64.Text = "Collision Margin";
            // 
            // btn_SetTagIt
            // 
            this.btn_SetTagIt.Location = new System.Drawing.Point(211, 144);
            this.btn_SetTagIt.Name = "btn_SetTagIt";
            this.btn_SetTagIt.Size = new System.Drawing.Size(87, 23);
            this.btn_SetTagIt.TabIndex = 36;
            this.btn_SetTagIt.Text = "Set Config";
            this.btn_SetTagIt.UseVisualStyleBackColor = true;
            this.btn_SetTagIt.Click += new System.EventHandler(this.btn_SetTagIt_Click);
            // 
            // btn_GetTagIt
            // 
            this.btn_GetTagIt.Location = new System.Drawing.Point(118, 144);
            this.btn_GetTagIt.Name = "btn_GetTagIt";
            this.btn_GetTagIt.Size = new System.Drawing.Size(87, 23);
            this.btn_GetTagIt.TabIndex = 35;
            this.btn_GetTagIt.Text = "Get Config";
            this.btn_GetTagIt.UseVisualStyleBackColor = true;
            this.btn_GetTagIt.Click += new System.EventHandler(this.btn_GetTagIt_Click);
            // 
            // btn_LoadTagIt
            // 
            this.btn_LoadTagIt.Location = new System.Drawing.Point(25, 144);
            this.btn_LoadTagIt.Name = "btn_LoadTagIt";
            this.btn_LoadTagIt.Size = new System.Drawing.Size(87, 23);
            this.btn_LoadTagIt.TabIndex = 34;
            this.btn_LoadTagIt.Text = "Load Default";
            this.btn_LoadTagIt.UseVisualStyleBackColor = true;
            this.btn_LoadTagIt.Click += new System.EventHandler(this.btn_LoadTagIt_Click);
            // 
            // txt_EndOfFrame_1
            // 
            this.txt_EndOfFrame_1.Location = new System.Drawing.Point(132, 74);
            this.txt_EndOfFrame_1.Name = "txt_EndOfFrame_1";
            this.txt_EndOfFrame_1.Size = new System.Drawing.Size(43, 21);
            this.txt_EndOfFrame_1.TabIndex = 28;
            this.txt_EndOfFrame_1.Text = "01";
            // 
            // txt_StartOfFrame_1
            // 
            this.txt_StartOfFrame_1.Location = new System.Drawing.Point(132, 47);
            this.txt_StartOfFrame_1.Name = "txt_StartOfFrame_1";
            this.txt_StartOfFrame_1.Size = new System.Drawing.Size(43, 21);
            this.txt_StartOfFrame_1.TabIndex = 27;
            this.txt_StartOfFrame_1.Text = "01";
            // 
            // txt_CollisionMarginTagIt
            // 
            this.txt_CollisionMarginTagIt.Location = new System.Drawing.Point(132, 20);
            this.txt_CollisionMarginTagIt.Name = "txt_CollisionMarginTagIt";
            this.txt_CollisionMarginTagIt.Size = new System.Drawing.Size(43, 21);
            this.txt_CollisionMarginTagIt.TabIndex = 26;
            this.txt_CollisionMarginTagIt.Text = "20";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(13, 83);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(77, 12);
            this.label70.TabIndex = 13;
            this.label70.Text = "End Of Frame";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(13, 56);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(89, 12);
            this.label71.TabIndex = 11;
            this.label71.Text = "Start Of Frame";
            // 
            // gb_ICodeConfig
            // 
            this.gb_ICodeConfig.Controls.Add(this.label63);
            this.gb_ICodeConfig.Controls.Add(this.btn_SetICode);
            this.gb_ICodeConfig.Controls.Add(this.btn_GetICode);
            this.gb_ICodeConfig.Controls.Add(this.btn_LoadICode);
            this.gb_ICodeConfig.Controls.Add(this.txt_Tuning);
            this.gb_ICodeConfig.Controls.Add(this.txt_CollisionMarginICode);
            this.gb_ICodeConfig.Controls.Add(this.txt_NoiseMargin);
            this.gb_ICodeConfig.Controls.Add(this.label67);
            this.gb_ICodeConfig.Controls.Add(this.label69);
            this.gb_ICodeConfig.Location = new System.Drawing.Point(157, 6);
            this.gb_ICodeConfig.Name = "gb_ICodeConfig";
            this.gb_ICodeConfig.Size = new System.Drawing.Size(322, 340);
            this.gb_ICodeConfig.TabIndex = 39;
            this.gb_ICodeConfig.TabStop = false;
            this.gb_ICodeConfig.Text = "I-Code Config";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(13, 56);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(101, 12);
            this.label63.TabIndex = 37;
            this.label63.Text = "Collision Margin";
            // 
            // btn_SetICode
            // 
            this.btn_SetICode.Location = new System.Drawing.Point(211, 144);
            this.btn_SetICode.Name = "btn_SetICode";
            this.btn_SetICode.Size = new System.Drawing.Size(87, 23);
            this.btn_SetICode.TabIndex = 36;
            this.btn_SetICode.Text = "Set Config";
            this.btn_SetICode.UseVisualStyleBackColor = true;
            this.btn_SetICode.Click += new System.EventHandler(this.btn_SetICode_Click);
            // 
            // btn_GetICode
            // 
            this.btn_GetICode.Location = new System.Drawing.Point(118, 144);
            this.btn_GetICode.Name = "btn_GetICode";
            this.btn_GetICode.Size = new System.Drawing.Size(87, 23);
            this.btn_GetICode.TabIndex = 35;
            this.btn_GetICode.Text = "Get Config";
            this.btn_GetICode.UseVisualStyleBackColor = true;
            this.btn_GetICode.Click += new System.EventHandler(this.btn_GetICode_Click);
            // 
            // btn_LoadICode
            // 
            this.btn_LoadICode.Location = new System.Drawing.Point(25, 144);
            this.btn_LoadICode.Name = "btn_LoadICode";
            this.btn_LoadICode.Size = new System.Drawing.Size(87, 23);
            this.btn_LoadICode.TabIndex = 34;
            this.btn_LoadICode.Text = "Load Default";
            this.btn_LoadICode.UseVisualStyleBackColor = true;
            this.btn_LoadICode.Click += new System.EventHandler(this.btn_LoadICode_Click);
            // 
            // txt_Tuning
            // 
            this.txt_Tuning.Location = new System.Drawing.Point(132, 74);
            this.txt_Tuning.Name = "txt_Tuning";
            this.txt_Tuning.Size = new System.Drawing.Size(43, 21);
            this.txt_Tuning.TabIndex = 28;
            this.txt_Tuning.Text = "15";
            // 
            // txt_CollisionMarginICode
            // 
            this.txt_CollisionMarginICode.Location = new System.Drawing.Point(132, 47);
            this.txt_CollisionMarginICode.Name = "txt_CollisionMarginICode";
            this.txt_CollisionMarginICode.Size = new System.Drawing.Size(43, 21);
            this.txt_CollisionMarginICode.TabIndex = 27;
            this.txt_CollisionMarginICode.Text = "3E";
            // 
            // txt_NoiseMargin
            // 
            this.txt_NoiseMargin.Location = new System.Drawing.Point(132, 20);
            this.txt_NoiseMargin.Name = "txt_NoiseMargin";
            this.txt_NoiseMargin.Size = new System.Drawing.Size(43, 21);
            this.txt_NoiseMargin.TabIndex = 26;
            this.txt_NoiseMargin.Text = "18";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(13, 83);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(113, 12);
            this.label67.TabIndex = 13;
            this.label67.Text = "Tuning Calibration";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(13, 29);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(77, 12);
            this.label69.TabIndex = 11;
            this.label69.Text = "Noise Margin";
            // 
            // gb_TimingConfig
            // 
            this.gb_TimingConfig.Controls.Add(this.cmb_EASTagType);
            this.gb_TimingConfig.Controls.Add(this.label62);
            this.gb_TimingConfig.Controls.Add(this.btn_SetTiming);
            this.gb_TimingConfig.Controls.Add(this.btn_GetTiming);
            this.gb_TimingConfig.Controls.Add(this.btn_LoadTiming);
            this.gb_TimingConfig.Controls.Add(this.txt_ASKRef_2);
            this.gb_TimingConfig.Controls.Add(this.txt_ASKTiming_2);
            this.gb_TimingConfig.Controls.Add(this.txt_FSKTiming_2);
            this.gb_TimingConfig.Controls.Add(this.txt_ASKRef_1);
            this.gb_TimingConfig.Controls.Add(this.txt_ASKTiming_1);
            this.gb_TimingConfig.Controls.Add(this.txt_FSKTiming_1);
            this.gb_TimingConfig.Controls.Add(this.label65);
            this.gb_TimingConfig.Controls.Add(this.label66);
            this.gb_TimingConfig.Controls.Add(this.label68);
            this.gb_TimingConfig.Location = new System.Drawing.Point(157, 6);
            this.gb_TimingConfig.Name = "gb_TimingConfig";
            this.gb_TimingConfig.Size = new System.Drawing.Size(322, 340);
            this.gb_TimingConfig.TabIndex = 37;
            this.gb_TimingConfig.TabStop = false;
            this.gb_TimingConfig.Text = "Timing Config";
            // 
            // cmb_EASTagType
            // 
            this.cmb_EASTagType.FormattingEnabled = true;
            this.cmb_EASTagType.Items.AddRange(new object[] {
            "I-CODE SLI",
            "I-CODE",
            "None"});
            this.cmb_EASTagType.Location = new System.Drawing.Point(108, 101);
            this.cmb_EASTagType.Name = "cmb_EASTagType";
            this.cmb_EASTagType.Size = new System.Drawing.Size(94, 20);
            this.cmb_EASTagType.TabIndex = 38;
            this.cmb_EASTagType.Text = "I_CODE SLI";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(13, 56);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(65, 12);
            this.label62.TabIndex = 37;
            this.label62.Text = "ASK Timing";
            // 
            // btn_SetTiming
            // 
            this.btn_SetTiming.Location = new System.Drawing.Point(211, 144);
            this.btn_SetTiming.Name = "btn_SetTiming";
            this.btn_SetTiming.Size = new System.Drawing.Size(87, 23);
            this.btn_SetTiming.TabIndex = 36;
            this.btn_SetTiming.Text = "Set Config";
            this.btn_SetTiming.UseVisualStyleBackColor = true;
            this.btn_SetTiming.Click += new System.EventHandler(this.btn_SetTiming_Click);
            // 
            // btn_GetTiming
            // 
            this.btn_GetTiming.Location = new System.Drawing.Point(118, 144);
            this.btn_GetTiming.Name = "btn_GetTiming";
            this.btn_GetTiming.Size = new System.Drawing.Size(87, 23);
            this.btn_GetTiming.TabIndex = 35;
            this.btn_GetTiming.Text = "Get Config";
            this.btn_GetTiming.UseVisualStyleBackColor = true;
            this.btn_GetTiming.Click += new System.EventHandler(this.btn_GetTiming_Click);
            // 
            // btn_LoadTiming
            // 
            this.btn_LoadTiming.Location = new System.Drawing.Point(25, 144);
            this.btn_LoadTiming.Name = "btn_LoadTiming";
            this.btn_LoadTiming.Size = new System.Drawing.Size(87, 23);
            this.btn_LoadTiming.TabIndex = 34;
            this.btn_LoadTiming.Text = "Load Default";
            this.btn_LoadTiming.UseVisualStyleBackColor = true;
            this.btn_LoadTiming.Click += new System.EventHandler(this.btn_LoadTiming_Click);
            // 
            // txt_ASKRef_2
            // 
            this.txt_ASKRef_2.Location = new System.Drawing.Point(159, 74);
            this.txt_ASKRef_2.Name = "txt_ASKRef_2";
            this.txt_ASKRef_2.Size = new System.Drawing.Size(43, 21);
            this.txt_ASKRef_2.TabIndex = 32;
            this.txt_ASKRef_2.Text = "B0";
            // 
            // txt_ASKTiming_2
            // 
            this.txt_ASKTiming_2.Location = new System.Drawing.Point(159, 47);
            this.txt_ASKTiming_2.Name = "txt_ASKTiming_2";
            this.txt_ASKTiming_2.Size = new System.Drawing.Size(43, 21);
            this.txt_ASKTiming_2.TabIndex = 31;
            this.txt_ASKTiming_2.Text = "1D";
            // 
            // txt_FSKTiming_2
            // 
            this.txt_FSKTiming_2.Location = new System.Drawing.Point(159, 20);
            this.txt_FSKTiming_2.Name = "txt_FSKTiming_2";
            this.txt_FSKTiming_2.Size = new System.Drawing.Size(43, 21);
            this.txt_FSKTiming_2.TabIndex = 30;
            this.txt_FSKTiming_2.Text = "28";
            // 
            // txt_ASKRef_1
            // 
            this.txt_ASKRef_1.Location = new System.Drawing.Point(108, 74);
            this.txt_ASKRef_1.Name = "txt_ASKRef_1";
            this.txt_ASKRef_1.Size = new System.Drawing.Size(43, 21);
            this.txt_ASKRef_1.TabIndex = 28;
            this.txt_ASKRef_1.Text = "00";
            // 
            // txt_ASKTiming_1
            // 
            this.txt_ASKTiming_1.Location = new System.Drawing.Point(108, 47);
            this.txt_ASKTiming_1.Name = "txt_ASKTiming_1";
            this.txt_ASKTiming_1.Size = new System.Drawing.Size(43, 21);
            this.txt_ASKTiming_1.TabIndex = 27;
            this.txt_ASKTiming_1.Text = "1E";
            // 
            // txt_FSKTiming_1
            // 
            this.txt_FSKTiming_1.Location = new System.Drawing.Point(108, 20);
            this.txt_FSKTiming_1.Name = "txt_FSKTiming_1";
            this.txt_FSKTiming_1.Size = new System.Drawing.Size(43, 21);
            this.txt_FSKTiming_1.TabIndex = 26;
            this.txt_FSKTiming_1.Text = "29";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(13, 110);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(77, 12);
            this.label65.TabIndex = 14;
            this.label65.Text = "EAS Tag Type";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(13, 83);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(83, 12);
            this.label66.TabIndex = 13;
            this.label66.Text = "ASK Reference";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(13, 29);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(65, 12);
            this.label68.TabIndex = 11;
            this.label68.Text = "FSK Timing";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Clear_Demo);
            this.tabPage3.Controls.Add(this.lst_Info_Demo);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gates-Channel-Reader";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Clear_Demo
            // 
            this.btn_Clear_Demo.Location = new System.Drawing.Point(706, 326);
            this.btn_Clear_Demo.Name = "btn_Clear_Demo";
            this.btn_Clear_Demo.Size = new System.Drawing.Size(65, 23);
            this.btn_Clear_Demo.TabIndex = 8;
            this.btn_Clear_Demo.Text = "Clear";
            this.btn_Clear_Demo.UseVisualStyleBackColor = true;
            this.btn_Clear_Demo.Click += new System.EventHandler(this.btn_Clear_Demo_Click);
            // 
            // lst_Info_Demo
            // 
            this.lst_Info_Demo.FormattingEnabled = true;
            this.lst_Info_Demo.ItemHeight = 12;
            this.lst_Info_Demo.Location = new System.Drawing.Point(6, 214);
            this.lst_Info_Demo.Name = "lst_Info_Demo";
            this.lst_Info_Demo.Size = new System.Drawing.Size(766, 136);
            this.lst_Info_Demo.TabIndex = 45;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chk_Voice);
            this.groupBox6.Controls.Add(this.txt_TagNumber_Monitor);
            this.groupBox6.Controls.Add(this.pic_Photo_Monitor);
            this.groupBox6.Controls.Add(this.btn_Monitor);
            this.groupBox6.Controls.Add(this.txt_Company_Monitor);
            this.groupBox6.Controls.Add(this.label84);
            this.groupBox6.Controls.Add(this.label85);
            this.groupBox6.Controls.Add(this.txt_Telephone_Monitor);
            this.groupBox6.Controls.Add(this.label86);
            this.groupBox6.Controls.Add(this.label90);
            this.groupBox6.Controls.Add(this.txt_UserName_Monitor);
            this.groupBox6.Location = new System.Drawing.Point(463, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(309, 202);
            this.groupBox6.TabIndex = 44;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gateway Monitor";
            // 
            // chk_Voice
            // 
            this.chk_Voice.AutoSize = true;
            this.chk_Voice.Location = new System.Drawing.Point(119, 20);
            this.chk_Voice.Name = "chk_Voice";
            this.chk_Voice.Size = new System.Drawing.Size(54, 16);
            this.chk_Voice.TabIndex = 23;
            this.chk_Voice.Text = "Voice";
            this.chk_Voice.UseVisualStyleBackColor = true;
            // 
            // txt_TagNumber_Monitor
            // 
            this.txt_TagNumber_Monitor.Location = new System.Drawing.Point(72, 46);
            this.txt_TagNumber_Monitor.Name = "txt_TagNumber_Monitor";
            this.txt_TagNumber_Monitor.ReadOnly = true;
            this.txt_TagNumber_Monitor.Size = new System.Drawing.Size(125, 21);
            this.txt_TagNumber_Monitor.TabIndex = 22;
            // 
            // pic_Photo_Monitor
            // 
            this.pic_Photo_Monitor.Location = new System.Drawing.Point(203, 45);
            this.pic_Photo_Monitor.Name = "pic_Photo_Monitor";
            this.pic_Photo_Monitor.Size = new System.Drawing.Size(100, 121);
            this.pic_Photo_Monitor.TabIndex = 21;
            this.pic_Photo_Monitor.TabStop = false;
            // 
            // btn_Monitor
            // 
            this.btn_Monitor.Location = new System.Drawing.Point(13, 17);
            this.btn_Monitor.Name = "btn_Monitor";
            this.btn_Monitor.Size = new System.Drawing.Size(100, 23);
            this.btn_Monitor.TabIndex = 21;
            this.btn_Monitor.Text = "Start Monitor";
            this.btn_Monitor.UseVisualStyleBackColor = true;
            this.btn_Monitor.Click += new System.EventHandler(this.btn_Monitor_Click);
            // 
            // txt_Company_Monitor
            // 
            this.txt_Company_Monitor.Location = new System.Drawing.Point(72, 113);
            this.txt_Company_Monitor.Name = "txt_Company_Monitor";
            this.txt_Company_Monitor.ReadOnly = true;
            this.txt_Company_Monitor.Size = new System.Drawing.Size(125, 21);
            this.txt_Company_Monitor.TabIndex = 11;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(13, 55);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(53, 12);
            this.label84.TabIndex = 0;
            this.label84.Text = "标签序号";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(13, 89);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(53, 12);
            this.label85.TabIndex = 3;
            this.label85.Text = "用户姓名";
            // 
            // txt_Telephone_Monitor
            // 
            this.txt_Telephone_Monitor.Location = new System.Drawing.Point(72, 146);
            this.txt_Telephone_Monitor.Name = "txt_Telephone_Monitor";
            this.txt_Telephone_Monitor.ReadOnly = true;
            this.txt_Telephone_Monitor.Size = new System.Drawing.Size(125, 21);
            this.txt_Telephone_Monitor.TabIndex = 15;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(13, 155);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(53, 12);
            this.label86.TabIndex = 7;
            this.label86.Text = "联系电话";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(13, 122);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(53, 12);
            this.label90.TabIndex = 8;
            this.label90.Text = "公司名称";
            // 
            // txt_UserName_Monitor
            // 
            this.txt_UserName_Monitor.Location = new System.Drawing.Point(72, 80);
            this.txt_UserName_Monitor.Name = "txt_UserName_Monitor";
            this.txt_UserName_Monitor.ReadOnly = true;
            this.txt_UserName_Monitor.Size = new System.Drawing.Size(125, 21);
            this.txt_UserName_Monitor.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_Appellative);
            this.groupBox5.Controls.Add(this.label89);
            this.groupBox5.Controls.Add(this.btn_Clear_Info);
            this.groupBox5.Controls.Add(this.btn_Delete);
            this.groupBox5.Controls.Add(this.btn_Add);
            this.groupBox5.Controls.Add(this.btn_Modify);
            this.groupBox5.Controls.Add(this.btn_Browser);
            this.groupBox5.Controls.Add(this.pic_UserPhoto);
            this.groupBox5.Controls.Add(this.txt_UserTelephone);
            this.groupBox5.Controls.Add(this.txt_UserCompany);
            this.groupBox5.Controls.Add(this.txt_UserName);
            this.groupBox5.Controls.Add(this.label88);
            this.groupBox5.Controls.Add(this.label87);
            this.groupBox5.Controls.Add(this.label83);
            this.groupBox5.Controls.Add(this.btn_InventoryDemo);
            this.groupBox5.Controls.Add(this.cmb_TagNumbers);
            this.groupBox5.Controls.Add(this.label82);
            this.groupBox5.Location = new System.Drawing.Point(148, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 202);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Initialize Card";
            // 
            // txt_Appellative
            // 
            this.txt_Appellative.Location = new System.Drawing.Point(65, 126);
            this.txt_Appellative.Name = "txt_Appellative";
            this.txt_Appellative.Size = new System.Drawing.Size(125, 21);
            this.txt_Appellative.TabIndex = 23;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(6, 133);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(53, 12);
            this.label89.TabIndex = 22;
            this.label89.Text = "习惯称谓";
            // 
            // btn_Clear_Info
            // 
            this.btn_Clear_Info.Location = new System.Drawing.Point(186, 172);
            this.btn_Clear_Info.Name = "btn_Clear_Info";
            this.btn_Clear_Info.Size = new System.Drawing.Size(51, 23);
            this.btn_Clear_Info.TabIndex = 21;
            this.btn_Clear_Info.Text = "Clear";
            this.btn_Clear_Info.UseVisualStyleBackColor = true;
            this.btn_Clear_Info.Click += new System.EventHandler(this.btn_Clear_Info_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(118, 172);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(62, 23);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(6, 172);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(43, 23);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Enabled = false;
            this.btn_Modify.Location = new System.Drawing.Point(55, 172);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(57, 23);
            this.btn_Modify.TabIndex = 18;
            this.btn_Modify.Text = "Modify";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Browser
            // 
            this.btn_Browser.Location = new System.Drawing.Point(243, 172);
            this.btn_Browser.Name = "btn_Browser";
            this.btn_Browser.Size = new System.Drawing.Size(54, 23);
            this.btn_Browser.TabIndex = 17;
            this.btn_Browser.Text = "Brower";
            this.btn_Browser.UseVisualStyleBackColor = true;
            this.btn_Browser.Click += new System.EventHandler(this.btn_Browser_Click);
            // 
            // pic_UserPhoto
            // 
            this.pic_UserPhoto.Location = new System.Drawing.Point(197, 45);
            this.pic_UserPhoto.Name = "pic_UserPhoto";
            this.pic_UserPhoto.Size = new System.Drawing.Size(100, 121);
            this.pic_UserPhoto.TabIndex = 16;
            this.pic_UserPhoto.TabStop = false;
            // 
            // txt_UserTelephone
            // 
            this.txt_UserTelephone.Location = new System.Drawing.Point(65, 99);
            this.txt_UserTelephone.Name = "txt_UserTelephone";
            this.txt_UserTelephone.Size = new System.Drawing.Size(125, 21);
            this.txt_UserTelephone.TabIndex = 15;
            // 
            // txt_UserCompany
            // 
            this.txt_UserCompany.Location = new System.Drawing.Point(65, 72);
            this.txt_UserCompany.Name = "txt_UserCompany";
            this.txt_UserCompany.Size = new System.Drawing.Size(125, 21);
            this.txt_UserCompany.TabIndex = 11;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(65, 45);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(125, 21);
            this.txt_UserName.TabIndex = 10;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(6, 80);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(53, 12);
            this.label88.TabIndex = 8;
            this.label88.Text = "公司名称";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(6, 108);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(53, 12);
            this.label87.TabIndex = 7;
            this.label87.Text = "联系电话";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(6, 54);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(53, 12);
            this.label83.TabIndex = 3;
            this.label83.Text = "用户姓名";
            // 
            // btn_InventoryDemo
            // 
            this.btn_InventoryDemo.Location = new System.Drawing.Point(209, 17);
            this.btn_InventoryDemo.Name = "btn_InventoryDemo";
            this.btn_InventoryDemo.Size = new System.Drawing.Size(75, 23);
            this.btn_InventoryDemo.TabIndex = 2;
            this.btn_InventoryDemo.Text = "Inventory";
            this.btn_InventoryDemo.UseVisualStyleBackColor = true;
            this.btn_InventoryDemo.Click += new System.EventHandler(this.btn_InventoryDemo_Click);
            // 
            // cmb_TagNumbers
            // 
            this.cmb_TagNumbers.FormattingEnabled = true;
            this.cmb_TagNumbers.Location = new System.Drawing.Point(65, 19);
            this.cmb_TagNumbers.Name = "cmb_TagNumbers";
            this.cmb_TagNumbers.Size = new System.Drawing.Size(138, 20);
            this.cmb_TagNumbers.TabIndex = 1;
            this.cmb_TagNumbers.SelectedIndexChanged += new System.EventHandler(this.cmb_TagNumbers_SelectedIndexChanged);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(6, 27);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(53, 12);
            this.label82.TabIndex = 0;
            this.label82.Text = "标签序号";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Refresh_Demo);
            this.groupBox4.Controls.Add(this.btn_Close_Demo);
            this.groupBox4.Controls.Add(this.btn_Open_Demo);
            this.groupBox4.Controls.Add(this.cmb_BaudRate_Demo);
            this.groupBox4.Controls.Add(this.label80);
            this.groupBox4.Controls.Add(this.cmb_PortName_Demo);
            this.groupBox4.Controls.Add(this.label81);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 202);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SerialPort";
            // 
            // btn_Refresh_Demo
            // 
            this.btn_Refresh_Demo.Location = new System.Drawing.Point(61, 133);
            this.btn_Refresh_Demo.Name = "btn_Refresh_Demo";
            this.btn_Refresh_Demo.Size = new System.Drawing.Size(65, 23);
            this.btn_Refresh_Demo.TabIndex = 7;
            this.btn_Refresh_Demo.Text = "Refresh";
            this.btn_Refresh_Demo.UseVisualStyleBackColor = true;
            this.btn_Refresh_Demo.Click += new System.EventHandler(this.btn_Refresh_Demo_Click);
            // 
            // btn_Close_Demo
            // 
            this.btn_Close_Demo.Location = new System.Drawing.Point(61, 104);
            this.btn_Close_Demo.Name = "btn_Close_Demo";
            this.btn_Close_Demo.Size = new System.Drawing.Size(65, 23);
            this.btn_Close_Demo.TabIndex = 6;
            this.btn_Close_Demo.Text = "Close";
            this.btn_Close_Demo.UseVisualStyleBackColor = true;
            this.btn_Close_Demo.Click += new System.EventHandler(this.btn_Close_Demo_Click);
            // 
            // btn_Open_Demo
            // 
            this.btn_Open_Demo.Location = new System.Drawing.Point(61, 75);
            this.btn_Open_Demo.Name = "btn_Open_Demo";
            this.btn_Open_Demo.Size = new System.Drawing.Size(65, 23);
            this.btn_Open_Demo.TabIndex = 5;
            this.btn_Open_Demo.Text = "Open";
            this.btn_Open_Demo.UseVisualStyleBackColor = true;
            this.btn_Open_Demo.Click += new System.EventHandler(this.btn_Open_Demo_Click);
            // 
            // cmb_BaudRate_Demo
            // 
            this.cmb_BaudRate_Demo.FormattingEnabled = true;
            this.cmb_BaudRate_Demo.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmb_BaudRate_Demo.Location = new System.Drawing.Point(61, 49);
            this.cmb_BaudRate_Demo.Name = "cmb_BaudRate_Demo";
            this.cmb_BaudRate_Demo.Size = new System.Drawing.Size(65, 20);
            this.cmb_BaudRate_Demo.TabIndex = 4;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(5, 57);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(53, 12);
            this.label80.TabIndex = 3;
            this.label80.Text = "BaudRate";
            // 
            // cmb_PortName_Demo
            // 
            this.cmb_PortName_Demo.FormattingEnabled = true;
            this.cmb_PortName_Demo.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.cmb_PortName_Demo.Location = new System.Drawing.Point(61, 21);
            this.cmb_PortName_Demo.Name = "cmb_PortName_Demo";
            this.cmb_PortName_Demo.Size = new System.Drawing.Size(65, 20);
            this.cmb_PortName_Demo.TabIndex = 2;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(5, 29);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(53, 12);
            this.label81.TabIndex = 0;
            this.label81.Text = "PortName";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_Clear_14443);
            this.tabPage4.Controls.Add(this.lsb_Info_14443);
            this.tabPage4.Controls.Add(this.groupBox4_14443);
            this.tabPage4.Controls.Add(this.groupBox3_14443);
            this.tabPage4.Controls.Add(this.groupBox2_14443);
            this.tabPage4.Controls.Add(this.groupBox1_14443);
            this.tabPage4.Location = new System.Drawing.Point(4, 21);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(780, 356);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "HF-ISO14443-Reader-A";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Clear_14443
            // 
            this.btn_Clear_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Clear_14443.Location = new System.Drawing.Point(721, 324);
            this.btn_Clear_14443.Name = "btn_Clear_14443";
            this.btn_Clear_14443.Size = new System.Drawing.Size(50, 25);
            this.btn_Clear_14443.TabIndex = 26;
            this.btn_Clear_14443.Text = "清空";
            this.btn_Clear_14443.UseVisualStyleBackColor = true;
            this.btn_Clear_14443.Click += new System.EventHandler(this.btn_Clear_14443_Click);
            // 
            // lsb_Info_14443
            // 
            this.lsb_Info_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.lsb_Info_14443.FormattingEnabled = true;
            this.lsb_Info_14443.HorizontalScrollbar = true;
            this.lsb_Info_14443.ItemHeight = 12;
            this.lsb_Info_14443.Location = new System.Drawing.Point(301, 10);
            this.lsb_Info_14443.Name = "lsb_Info_14443";
            this.lsb_Info_14443.Size = new System.Drawing.Size(471, 340);
            this.lsb_Info_14443.TabIndex = 25;
            // 
            // groupBox4_14443
            // 
            this.groupBox4_14443.Controls.Add(this.txt_DataOut_14443);
            this.groupBox4_14443.Controls.Add(this.btn_Read_14443);
            this.groupBox4_14443.Controls.Add(this.btn_Write_14443);
            this.groupBox4_14443.Controls.Add(this.txt_DataIn_14443);
            this.groupBox4_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox4_14443.Location = new System.Drawing.Point(6, 264);
            this.groupBox4_14443.Name = "groupBox4_14443";
            this.groupBox4_14443.Size = new System.Drawing.Size(289, 86);
            this.groupBox4_14443.TabIndex = 24;
            this.groupBox4_14443.TabStop = false;
            this.groupBox4_14443.Text = "读写操作";
            // 
            // txt_DataOut_14443
            // 
            this.txt_DataOut_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_DataOut_14443.Location = new System.Drawing.Point(68, 21);
            this.txt_DataOut_14443.MaxLength = 32;
            this.txt_DataOut_14443.Name = "txt_DataOut_14443";
            this.txt_DataOut_14443.ReadOnly = true;
            this.txt_DataOut_14443.Size = new System.Drawing.Size(211, 21);
            this.txt_DataOut_14443.TabIndex = 21;
            // 
            // btn_Read_14443
            // 
            this.btn_Read_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Read_14443.Location = new System.Drawing.Point(9, 23);
            this.btn_Read_14443.Name = "btn_Read_14443";
            this.btn_Read_14443.Size = new System.Drawing.Size(50, 25);
            this.btn_Read_14443.TabIndex = 15;
            this.btn_Read_14443.Text = "读取";
            this.btn_Read_14443.UseVisualStyleBackColor = true;
            this.btn_Read_14443.Click += new System.EventHandler(this.btn_Read_14443_Click);
            // 
            // btn_Write_14443
            // 
            this.btn_Write_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Write_14443.Location = new System.Drawing.Point(9, 54);
            this.btn_Write_14443.Name = "btn_Write_14443";
            this.btn_Write_14443.Size = new System.Drawing.Size(50, 25);
            this.btn_Write_14443.TabIndex = 20;
            this.btn_Write_14443.Text = "写入";
            this.btn_Write_14443.UseVisualStyleBackColor = true;
            this.btn_Write_14443.Click += new System.EventHandler(this.btn_Write_14443_Click);
            // 
            // txt_DataIn_14443
            // 
            this.txt_DataIn_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_DataIn_14443.Location = new System.Drawing.Point(68, 53);
            this.txt_DataIn_14443.MaxLength = 32;
            this.txt_DataIn_14443.Name = "txt_DataIn_14443";
            this.txt_DataIn_14443.Size = new System.Drawing.Size(211, 21);
            this.txt_DataIn_14443.TabIndex = 19;
            this.txt_DataIn_14443.Text = "000102030405060708090A0B0C0D0E0F";
            // 
            // groupBox3_14443
            // 
            this.groupBox3_14443.Controls.Add(this.label92);
            this.groupBox3_14443.Controls.Add(this.txt_Addr_14443);
            this.groupBox3_14443.Controls.Add(this.txt_KeyA_14443);
            this.groupBox3_14443.Controls.Add(this.label91);
            this.groupBox3_14443.Controls.Add(this.btn_AuthA_14443);
            this.groupBox3_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox3_14443.Location = new System.Drawing.Point(6, 208);
            this.groupBox3_14443.Name = "groupBox3_14443";
            this.groupBox3_14443.Size = new System.Drawing.Size(289, 50);
            this.groupBox3_14443.TabIndex = 23;
            this.groupBox3_14443.TabStop = false;
            this.groupBox3_14443.Text = "认证操作";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("宋体", 9F);
            this.label92.Location = new System.Drawing.Point(153, 28);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(29, 12);
            this.label92.TabIndex = 12;
            this.label92.Text = "密钥";
            // 
            // txt_Addr_14443
            // 
            this.txt_Addr_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_Addr_14443.Location = new System.Drawing.Point(124, 19);
            this.txt_Addr_14443.MaxLength = 3;
            this.txt_Addr_14443.Name = "txt_Addr_14443";
            this.txt_Addr_14443.Size = new System.Drawing.Size(23, 21);
            this.txt_Addr_14443.TabIndex = 11;
            this.txt_Addr_14443.Text = "2";
            // 
            // txt_KeyA_14443
            // 
            this.txt_KeyA_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_KeyA_14443.Location = new System.Drawing.Point(188, 20);
            this.txt_KeyA_14443.MaxLength = 12;
            this.txt_KeyA_14443.Name = "txt_KeyA_14443";
            this.txt_KeyA_14443.Size = new System.Drawing.Size(86, 21);
            this.txt_KeyA_14443.TabIndex = 5;
            this.txt_KeyA_14443.Text = "FFFFFFFFFFFF";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("宋体", 9F);
            this.label91.Location = new System.Drawing.Point(77, 28);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(41, 12);
            this.label91.TabIndex = 4;
            this.label91.Text = "块地址";
            // 
            // btn_AuthA_14443
            // 
            this.btn_AuthA_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_AuthA_14443.Location = new System.Drawing.Point(6, 20);
            this.btn_AuthA_14443.Name = "btn_AuthA_14443";
            this.btn_AuthA_14443.Size = new System.Drawing.Size(64, 25);
            this.btn_AuthA_14443.TabIndex = 0;
            this.btn_AuthA_14443.Text = "认证密钥";
            this.btn_AuthA_14443.UseVisualStyleBackColor = true;
            this.btn_AuthA_14443.Click += new System.EventHandler(this.btn_AuthA_14443_Click);
            // 
            // groupBox2_14443
            // 
            this.groupBox2_14443.Controls.Add(this.btn_RemoveAll);
            this.groupBox2_14443.Controls.Add(this.btn_FastInventory);
            this.groupBox2_14443.Controls.Add(this.btn_Inventory_14443);
            this.groupBox2_14443.Controls.Add(this.btn_Select_14443);
            this.groupBox2_14443.Controls.Add(this.label93);
            this.groupBox2_14443.Controls.Add(this.btn_ReqeustAll_14443);
            this.groupBox2_14443.Controls.Add(this.btn_RequestNotSleep_14443);
            this.groupBox2_14443.Controls.Add(this.btn_AntiColl_14443);
            this.groupBox2_14443.Controls.Add(this.txt_Count_14443);
            this.groupBox2_14443.Controls.Add(this.txt_Snr_14443);
            this.groupBox2_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox2_14443.Location = new System.Drawing.Point(6, 84);
            this.groupBox2_14443.Name = "groupBox2_14443";
            this.groupBox2_14443.Size = new System.Drawing.Size(289, 118);
            this.groupBox2_14443.TabIndex = 22;
            this.groupBox2_14443.TabStop = false;
            this.groupBox2_14443.Text = "寻卡操作";
            // 
            // btn_RemoveAll
            // 
            this.btn_RemoveAll.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_RemoveAll.Location = new System.Drawing.Point(243, 84);
            this.btn_RemoveAll.Name = "btn_RemoveAll";
            this.btn_RemoveAll.Size = new System.Drawing.Size(40, 25);
            this.btn_RemoveAll.TabIndex = 7;
            this.btn_RemoveAll.Text = "清零";
            this.btn_RemoveAll.UseVisualStyleBackColor = true;
            this.btn_RemoveAll.Click += new System.EventHandler(this.btn_RemoveAll_Click);
            // 
            // btn_FastInventory
            // 
            this.btn_FastInventory.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_FastInventory.Location = new System.Drawing.Point(9, 85);
            this.btn_FastInventory.Name = "btn_FastInventory";
            this.btn_FastInventory.Size = new System.Drawing.Size(86, 25);
            this.btn_FastInventory.TabIndex = 6;
            this.btn_FastInventory.Text = "开始快速寻卡";
            this.btn_FastInventory.UseVisualStyleBackColor = true;
            this.btn_FastInventory.Click += new System.EventHandler(this.btn_FastInventory_Click);
            // 
            // btn_Inventory_14443
            // 
            this.btn_Inventory_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Inventory_14443.Location = new System.Drawing.Point(197, 25);
            this.btn_Inventory_14443.Name = "btn_Inventory_14443";
            this.btn_Inventory_14443.Size = new System.Drawing.Size(86, 23);
            this.btn_Inventory_14443.TabIndex = 5;
            this.btn_Inventory_14443.Text = "直接寻卡";
            this.btn_Inventory_14443.UseVisualStyleBackColor = true;
            this.btn_Inventory_14443.Click += new System.EventHandler(this.btn_Inventory_14443_Click);
            // 
            // btn_Select_14443
            // 
            this.btn_Select_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Select_14443.Location = new System.Drawing.Point(243, 54);
            this.btn_Select_14443.Name = "btn_Select_14443";
            this.btn_Select_14443.Size = new System.Drawing.Size(40, 25);
            this.btn_Select_14443.TabIndex = 4;
            this.btn_Select_14443.Text = "选择";
            this.btn_Select_14443.UseVisualStyleBackColor = true;
            this.btn_Select_14443.Click += new System.EventHandler(this.btn_Select_14443_Click);
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("宋体", 9F);
            this.label93.Location = new System.Drawing.Point(99, 97);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(53, 12);
            this.label93.TabIndex = 4;
            this.label93.Text = "标签数量";
            // 
            // btn_ReqeustAll_14443
            // 
            this.btn_ReqeustAll_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_ReqeustAll_14443.Location = new System.Drawing.Point(9, 25);
            this.btn_ReqeustAll_14443.Name = "btn_ReqeustAll_14443";
            this.btn_ReqeustAll_14443.Size = new System.Drawing.Size(86, 23);
            this.btn_ReqeustAll_14443.TabIndex = 3;
            this.btn_ReqeustAll_14443.Text = "请求所有";
            this.btn_ReqeustAll_14443.UseVisualStyleBackColor = true;
            this.btn_ReqeustAll_14443.Click += new System.EventHandler(this.btn_ReqeustAll_14443_Click);
            // 
            // btn_RequestNotSleep_14443
            // 
            this.btn_RequestNotSleep_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_RequestNotSleep_14443.Location = new System.Drawing.Point(101, 25);
            this.btn_RequestNotSleep_14443.Name = "btn_RequestNotSleep_14443";
            this.btn_RequestNotSleep_14443.Size = new System.Drawing.Size(90, 23);
            this.btn_RequestNotSleep_14443.TabIndex = 2;
            this.btn_RequestNotSleep_14443.Text = "请求未休眠";
            this.btn_RequestNotSleep_14443.UseVisualStyleBackColor = true;
            this.btn_RequestNotSleep_14443.Click += new System.EventHandler(this.btn_RequestNotSleep_14443_Click);
            // 
            // btn_AntiColl_14443
            // 
            this.btn_AntiColl_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_AntiColl_14443.Location = new System.Drawing.Point(9, 54);
            this.btn_AntiColl_14443.Name = "btn_AntiColl_14443";
            this.btn_AntiColl_14443.Size = new System.Drawing.Size(86, 25);
            this.btn_AntiColl_14443.TabIndex = 0;
            this.btn_AntiColl_14443.Text = "寻 卡";
            this.btn_AntiColl_14443.UseVisualStyleBackColor = true;
            this.btn_AntiColl_14443.Click += new System.EventHandler(this.btn_AntiColl_14443_Click);
            // 
            // txt_Count_14443
            // 
            this.txt_Count_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_Count_14443.Location = new System.Drawing.Point(158, 88);
            this.txt_Count_14443.Name = "txt_Count_14443";
            this.txt_Count_14443.ReadOnly = true;
            this.txt_Count_14443.Size = new System.Drawing.Size(79, 21);
            this.txt_Count_14443.TabIndex = 3;
            // 
            // txt_Snr_14443
            // 
            this.txt_Snr_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_Snr_14443.Location = new System.Drawing.Point(101, 56);
            this.txt_Snr_14443.Name = "txt_Snr_14443";
            this.txt_Snr_14443.ReadOnly = true;
            this.txt_Snr_14443.Size = new System.Drawing.Size(136, 21);
            this.txt_Snr_14443.TabIndex = 3;
            // 
            // groupBox1_14443
            // 
            this.groupBox1_14443.Controls.Add(this.btn_CloseUSB);
            this.groupBox1_14443.Controls.Add(this.btn_OpenUSB);
            this.groupBox1_14443.Controls.Add(this.btn_Refresh_14443);
            this.groupBox1_14443.Controls.Add(this.cmb_BaudRate_14443);
            this.groupBox1_14443.Controls.Add(this.btn_Close_14443);
            this.groupBox1_14443.Controls.Add(this.btn_Open_14443);
            this.groupBox1_14443.Controls.Add(this.cmb_PortNum_14443);
            this.groupBox1_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox1_14443.Location = new System.Drawing.Point(6, 6);
            this.groupBox1_14443.Name = "groupBox1_14443";
            this.groupBox1_14443.Size = new System.Drawing.Size(289, 72);
            this.groupBox1_14443.TabIndex = 21;
            this.groupBox1_14443.TabStop = false;
            this.groupBox1_14443.Text = "接口操作";
            // 
            // btn_CloseUSB
            // 
            this.btn_CloseUSB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_CloseUSB.Location = new System.Drawing.Point(128, 40);
            this.btn_CloseUSB.Name = "btn_CloseUSB";
            this.btn_CloseUSB.Size = new System.Drawing.Size(109, 25);
            this.btn_CloseUSB.TabIndex = 7;
            this.btn_CloseUSB.Text = "关闭USB接口";
            this.btn_CloseUSB.UseVisualStyleBackColor = true;
            this.btn_CloseUSB.Click += new System.EventHandler(this.btn_CloseUSB_Click);
            // 
            // btn_OpenUSB
            // 
            this.btn_OpenUSB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_OpenUSB.Location = new System.Drawing.Point(9, 40);
            this.btn_OpenUSB.Name = "btn_OpenUSB";
            this.btn_OpenUSB.Size = new System.Drawing.Size(109, 25);
            this.btn_OpenUSB.TabIndex = 6;
            this.btn_OpenUSB.Text = "打开USB接口";
            this.btn_OpenUSB.UseVisualStyleBackColor = true;
            this.btn_OpenUSB.Click += new System.EventHandler(this.btn_OpenUSB_Click);
            // 
            // btn_Refresh_14443
            // 
            this.btn_Refresh_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Refresh_14443.Location = new System.Drawing.Point(243, 11);
            this.btn_Refresh_14443.Name = "btn_Refresh_14443";
            this.btn_Refresh_14443.Size = new System.Drawing.Size(40, 25);
            this.btn_Refresh_14443.TabIndex = 5;
            this.btn_Refresh_14443.Text = "刷新";
            this.btn_Refresh_14443.UseVisualStyleBackColor = true;
            this.btn_Refresh_14443.Click += new System.EventHandler(this.btn_Refresh_14443_Click);
            // 
            // cmb_BaudRate_14443
            // 
            this.cmb_BaudRate_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.cmb_BaudRate_14443.FormattingEnabled = true;
            this.cmb_BaudRate_14443.Location = new System.Drawing.Point(76, 14);
            this.cmb_BaudRate_14443.Name = "cmb_BaudRate_14443";
            this.cmb_BaudRate_14443.Size = new System.Drawing.Size(70, 20);
            this.cmb_BaudRate_14443.TabIndex = 4;
            this.cmb_BaudRate_14443.Text = "波特率";
            // 
            // btn_Close_14443
            // 
            this.btn_Close_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Close_14443.Location = new System.Drawing.Point(197, 11);
            this.btn_Close_14443.Name = "btn_Close_14443";
            this.btn_Close_14443.Size = new System.Drawing.Size(40, 25);
            this.btn_Close_14443.TabIndex = 3;
            this.btn_Close_14443.Text = "关闭";
            this.btn_Close_14443.UseVisualStyleBackColor = true;
            this.btn_Close_14443.Click += new System.EventHandler(this.btn_Close_14443_Click);
            // 
            // btn_Open_14443
            // 
            this.btn_Open_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Open_14443.Location = new System.Drawing.Point(152, 11);
            this.btn_Open_14443.Name = "btn_Open_14443";
            this.btn_Open_14443.Size = new System.Drawing.Size(39, 25);
            this.btn_Open_14443.TabIndex = 2;
            this.btn_Open_14443.Text = "打开";
            this.btn_Open_14443.UseVisualStyleBackColor = true;
            this.btn_Open_14443.Click += new System.EventHandler(this.btn_Open_14443_Click);
            // 
            // cmb_PortNum_14443
            // 
            this.cmb_PortNum_14443.Font = new System.Drawing.Font("宋体", 9F);
            this.cmb_PortNum_14443.FormattingEnabled = true;
            this.cmb_PortNum_14443.Location = new System.Drawing.Point(9, 14);
            this.cmb_PortNum_14443.Name = "cmb_PortNum_14443";
            this.cmb_PortNum_14443.Size = new System.Drawing.Size(61, 20);
            this.cmb_PortNum_14443.TabIndex = 1;
            this.cmb_PortNum_14443.Text = "串口号";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Controls.Add(this.btn_Clear_14443_B);
            this.tabPage5.Controls.Add(this.lsb_Info_14443_B);
            this.tabPage5.Location = new System.Drawing.Point(4, 21);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(780, 356);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "HF-ISO14443-Reader-B";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btn_ReqestB);
            this.groupBox9.Controls.Add(this.label94);
            this.groupBox9.Controls.Add(this.btn_WakeUpB);
            this.groupBox9.Controls.Add(this.btn_HaltB);
            this.groupBox9.Controls.Add(this.btn_AttribB);
            this.groupBox9.Controls.Add(this.btn_ReqestAllB);
            this.groupBox9.Controls.Add(this.txt_UIDB);
            this.groupBox9.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox9.Location = new System.Drawing.Point(8, 84);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(289, 90);
            this.groupBox9.TabIndex = 31;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "寻卡操作";
            // 
            // btn_ReqestB
            // 
            this.btn_ReqestB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_ReqestB.Location = new System.Drawing.Point(76, 20);
            this.btn_ReqestB.Name = "btn_ReqestB";
            this.btn_ReqestB.Size = new System.Drawing.Size(61, 23);
            this.btn_ReqestB.TabIndex = 6;
            this.btn_ReqestB.Text = "寻未休眠";
            this.btn_ReqestB.UseVisualStyleBackColor = true;
            this.btn_ReqestB.Click += new System.EventHandler(this.btn_ReqestB_Click);
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(20, 60);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(29, 12);
            this.label94.TabIndex = 5;
            this.label94.Text = "卡号";
            // 
            // btn_WakeUpB
            // 
            this.btn_WakeUpB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_WakeUpB.Location = new System.Drawing.Point(243, 19);
            this.btn_WakeUpB.Name = "btn_WakeUpB";
            this.btn_WakeUpB.Size = new System.Drawing.Size(40, 25);
            this.btn_WakeUpB.TabIndex = 4;
            this.btn_WakeUpB.Text = "唤醒";
            this.btn_WakeUpB.UseVisualStyleBackColor = true;
            this.btn_WakeUpB.Click += new System.EventHandler(this.btn_WakeUpB_Click);
            // 
            // btn_HaltB
            // 
            this.btn_HaltB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_HaltB.Location = new System.Drawing.Point(197, 19);
            this.btn_HaltB.Name = "btn_HaltB";
            this.btn_HaltB.Size = new System.Drawing.Size(40, 25);
            this.btn_HaltB.TabIndex = 4;
            this.btn_HaltB.Text = "挂起";
            this.btn_HaltB.UseVisualStyleBackColor = true;
            this.btn_HaltB.Click += new System.EventHandler(this.btn_HaltB_Click);
            // 
            // btn_AttribB
            // 
            this.btn_AttribB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_AttribB.Location = new System.Drawing.Point(151, 19);
            this.btn_AttribB.Name = "btn_AttribB";
            this.btn_AttribB.Size = new System.Drawing.Size(40, 25);
            this.btn_AttribB.TabIndex = 4;
            this.btn_AttribB.Text = "选择";
            this.btn_AttribB.UseVisualStyleBackColor = true;
            this.btn_AttribB.Click += new System.EventHandler(this.btn_AttribB_Click);
            // 
            // btn_ReqestAllB
            // 
            this.btn_ReqestAllB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_ReqestAllB.Location = new System.Drawing.Point(9, 20);
            this.btn_ReqestAllB.Name = "btn_ReqestAllB";
            this.btn_ReqestAllB.Size = new System.Drawing.Size(61, 23);
            this.btn_ReqestAllB.TabIndex = 3;
            this.btn_ReqestAllB.Text = "寻所有卡";
            this.btn_ReqestAllB.UseVisualStyleBackColor = true;
            this.btn_ReqestAllB.Click += new System.EventHandler(this.btn_ReqestAllB_Click);
            // 
            // txt_UIDB
            // 
            this.txt_UIDB.Font = new System.Drawing.Font("宋体", 9F);
            this.txt_UIDB.Location = new System.Drawing.Point(55, 51);
            this.txt_UIDB.Name = "txt_UIDB";
            this.txt_UIDB.ReadOnly = true;
            this.txt_UIDB.Size = new System.Drawing.Size(132, 21);
            this.txt_UIDB.TabIndex = 3;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btn_CloseUSBB);
            this.groupBox10.Controls.Add(this.btn_OpenUSBB);
            this.groupBox10.Controls.Add(this.btn_Refresh_14443B);
            this.groupBox10.Controls.Add(this.cmb_BaudRate_14443B);
            this.groupBox10.Controls.Add(this.btn_Close_14443B);
            this.groupBox10.Controls.Add(this.btn_Open_14443B);
            this.groupBox10.Controls.Add(this.cmb_PortNum_14443B);
            this.groupBox10.Font = new System.Drawing.Font("宋体", 9F);
            this.groupBox10.Location = new System.Drawing.Point(8, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(289, 72);
            this.groupBox10.TabIndex = 30;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "接口操作";
            // 
            // btn_CloseUSBB
            // 
            this.btn_CloseUSBB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_CloseUSBB.Location = new System.Drawing.Point(128, 40);
            this.btn_CloseUSBB.Name = "btn_CloseUSBB";
            this.btn_CloseUSBB.Size = new System.Drawing.Size(109, 25);
            this.btn_CloseUSBB.TabIndex = 7;
            this.btn_CloseUSBB.Text = "关闭USB接口";
            this.btn_CloseUSBB.UseVisualStyleBackColor = true;
            this.btn_CloseUSBB.Click += new System.EventHandler(this.btn_CloseUSBB_Click);
            // 
            // btn_OpenUSBB
            // 
            this.btn_OpenUSBB.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_OpenUSBB.Location = new System.Drawing.Point(9, 40);
            this.btn_OpenUSBB.Name = "btn_OpenUSBB";
            this.btn_OpenUSBB.Size = new System.Drawing.Size(109, 25);
            this.btn_OpenUSBB.TabIndex = 6;
            this.btn_OpenUSBB.Text = "打开USB接口";
            this.btn_OpenUSBB.UseVisualStyleBackColor = true;
            this.btn_OpenUSBB.Click += new System.EventHandler(this.btn_OpenUSBB_Click);
            // 
            // btn_Refresh_14443B
            // 
            this.btn_Refresh_14443B.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Refresh_14443B.Location = new System.Drawing.Point(243, 11);
            this.btn_Refresh_14443B.Name = "btn_Refresh_14443B";
            this.btn_Refresh_14443B.Size = new System.Drawing.Size(40, 25);
            this.btn_Refresh_14443B.TabIndex = 5;
            this.btn_Refresh_14443B.Text = "刷新";
            this.btn_Refresh_14443B.UseVisualStyleBackColor = true;
            this.btn_Refresh_14443B.Click += new System.EventHandler(this.btn_Refresh_14443B_Click);
            // 
            // cmb_BaudRate_14443B
            // 
            this.cmb_BaudRate_14443B.Font = new System.Drawing.Font("宋体", 9F);
            this.cmb_BaudRate_14443B.FormattingEnabled = true;
            this.cmb_BaudRate_14443B.Location = new System.Drawing.Point(76, 14);
            this.cmb_BaudRate_14443B.Name = "cmb_BaudRate_14443B";
            this.cmb_BaudRate_14443B.Size = new System.Drawing.Size(70, 20);
            this.cmb_BaudRate_14443B.TabIndex = 4;
            this.cmb_BaudRate_14443B.Text = "波特率";
            // 
            // btn_Close_14443B
            // 
            this.btn_Close_14443B.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Close_14443B.Location = new System.Drawing.Point(197, 11);
            this.btn_Close_14443B.Name = "btn_Close_14443B";
            this.btn_Close_14443B.Size = new System.Drawing.Size(40, 25);
            this.btn_Close_14443B.TabIndex = 3;
            this.btn_Close_14443B.Text = "关闭";
            this.btn_Close_14443B.UseVisualStyleBackColor = true;
            this.btn_Close_14443B.Click += new System.EventHandler(this.btn_Close_14443B_Click);
            // 
            // btn_Open_14443B
            // 
            this.btn_Open_14443B.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Open_14443B.Location = new System.Drawing.Point(152, 11);
            this.btn_Open_14443B.Name = "btn_Open_14443B";
            this.btn_Open_14443B.Size = new System.Drawing.Size(39, 25);
            this.btn_Open_14443B.TabIndex = 2;
            this.btn_Open_14443B.Text = "打开";
            this.btn_Open_14443B.UseVisualStyleBackColor = true;
            this.btn_Open_14443B.Click += new System.EventHandler(this.btn_Open_14443B_Click);
            // 
            // cmb_PortNum_14443B
            // 
            this.cmb_PortNum_14443B.Font = new System.Drawing.Font("宋体", 9F);
            this.cmb_PortNum_14443B.FormattingEnabled = true;
            this.cmb_PortNum_14443B.Location = new System.Drawing.Point(9, 14);
            this.cmb_PortNum_14443B.Name = "cmb_PortNum_14443B";
            this.cmb_PortNum_14443B.Size = new System.Drawing.Size(61, 20);
            this.cmb_PortNum_14443B.TabIndex = 1;
            this.cmb_PortNum_14443B.Text = "串口号";
            // 
            // btn_Clear_14443_B
            // 
            this.btn_Clear_14443_B.Font = new System.Drawing.Font("宋体", 9F);
            this.btn_Clear_14443_B.Location = new System.Drawing.Point(723, 320);
            this.btn_Clear_14443_B.Name = "btn_Clear_14443_B";
            this.btn_Clear_14443_B.Size = new System.Drawing.Size(50, 25);
            this.btn_Clear_14443_B.TabIndex = 28;
            this.btn_Clear_14443_B.Text = "清空";
            this.btn_Clear_14443_B.UseVisualStyleBackColor = true;
            this.btn_Clear_14443_B.Click += new System.EventHandler(this.btn_Clear_14443_B_Click);
            // 
            // lsb_Info_14443_B
            // 
            this.lsb_Info_14443_B.Font = new System.Drawing.Font("宋体", 9F);
            this.lsb_Info_14443_B.FormattingEnabled = true;
            this.lsb_Info_14443_B.HorizontalScrollbar = true;
            this.lsb_Info_14443_B.ItemHeight = 12;
            this.lsb_Info_14443_B.Location = new System.Drawing.Point(303, 6);
            this.lsb_Info_14443_B.Name = "lsb_Info_14443_B";
            this.lsb_Info_14443_B.Size = new System.Drawing.Size(471, 340);
            this.lsb_Info_14443_B.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox1.Location = new System.Drawing.Point(61, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(5, 57);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(53, 12);
            this.label78.TabIndex = 3;
            this.label78.Text = "BaudRate";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.comboBox2.Location = new System.Drawing.Point(61, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(5, 29);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(53, 12);
            this.label79.TabIndex = 0;
            this.label79.Text = "PortName";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 393);
            this.Controls.Add(this.tabControl);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HF Reader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_OpenCloseComm.ResumeLayout(false);
            this.gb_OpenCloseComm.PerformLayout();
            this.gb_OpenCloseHID.ResumeLayout(false);
            this.gb_AutoRcv.ResumeLayout(false);
            this.gb_Inventory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_WriteSingleBlock.ResumeLayout(false);
            this.gb_WriteSingleBlock.PerformLayout();
            this.gb_GetAll.ResumeLayout(false);
            this.gb_GetAll.PerformLayout();
            this.gb_EnableBuzzer.ResumeLayout(false);
            this.gb_EnableBuzzer.PerformLayout();
            this.gb_GetMulti.ResumeLayout(false);
            this.gb_GetMulti.PerformLayout();
            this.gb_GetSystemInfo.ResumeLayout(false);
            this.gb_GetSystemInfo.PerformLayout();
            this.gb_LockDSFID.ResumeLayout(false);
            this.gb_LockDSFID.PerformLayout();
            this.gb_WriteDSFID.ResumeLayout(false);
            this.gb_WriteDSFID.PerformLayout();
            this.gb_LockAFI.ResumeLayout(false);
            this.gb_LockAFI.PerformLayout();
            this.gb_WriteAFI.ResumeLayout(false);
            this.gb_WriteAFI.PerformLayout();
            this.gb_ResetToReady.ResumeLayout(false);
            this.gb_ResetToReady.PerformLayout();
            this.gb_Select.ResumeLayout(false);
            this.gb_Select.PerformLayout();
            this.gb_StayQuiet.ResumeLayout(false);
            this.gb_StayQuiet.PerformLayout();
            this.gb_LockBlock.ResumeLayout(false);
            this.gb_LockBlock.PerformLayout();
            this.gb_WriteMultiBlock.ResumeLayout(false);
            this.gb_WriteMultiBlock.PerformLayout();
            this.gb_ReadMultiBlock.ResumeLayout(false);
            this.gb_ReadMultiBlock.PerformLayout();
            this.gb_ReadSingleBlock.ResumeLayout(false);
            this.gb_ReadSingleBlock.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_ReaderConfig.ResumeLayout(false);
            this.gb_ReaderConfig.PerformLayout();
            this.gb_MultiplexConfig.ResumeLayout(false);
            this.gb_MultiplexConfig.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gb_TagItConfig.ResumeLayout(false);
            this.gb_TagItConfig.PerformLayout();
            this.gb_ICodeConfig.ResumeLayout(false);
            this.gb_ICodeConfig.PerformLayout();
            this.gb_TimingConfig.ResumeLayout(false);
            this.gb_TimingConfig.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Photo_Monitor)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserPhoto)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4_14443.ResumeLayout(false);
            this.groupBox4_14443.PerformLayout();
            this.groupBox3_14443.ResumeLayout(false);
            this.groupBox3_14443.PerformLayout();
            this.groupBox2_14443.ResumeLayout(false);
            this.groupBox2_14443.PerformLayout();
            this.groupBox1_14443.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lst_Info;
        private System.Windows.Forms.Button btn_ClearListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_OpenCloseComm;
        private System.Windows.Forms.RadioButton rb_GetMultiBlockSec;
        private System.Windows.Forms.RadioButton rb_GetSystemInfo;
        private System.Windows.Forms.RadioButton rb_LockDSFID;
        private System.Windows.Forms.RadioButton rb_WriteDSFID;
        private System.Windows.Forms.RadioButton rb_LockAFI;
        private System.Windows.Forms.RadioButton rb_WriteAFI;
        private System.Windows.Forms.RadioButton rb_ResetToReady;
        private System.Windows.Forms.RadioButton rb_Select;
        private System.Windows.Forms.RadioButton rb_StayQuiet;
        private System.Windows.Forms.RadioButton rb_LockBlock;
        private System.Windows.Forms.RadioButton rb_WriteMultiBlock;
        private System.Windows.Forms.RadioButton rb_ReadSingleBolock;
        private System.Windows.Forms.RadioButton rb_Inventory;
        private System.Windows.Forms.RadioButton rb_WriteSingleBlock;
        private System.Windows.Forms.RadioButton rb_ReadMultiBlock;
        private System.Windows.Forms.GroupBox gb_OpenCloseComm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_PortNum;
        private System.Windows.Forms.ComboBox cmb_BaudRate;
        private System.Windows.Forms.TextBox txt_DataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Parity;
        private System.Windows.Forms.TextBox txt_StopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_CloseComm;
        private System.Windows.Forms.Button btn_OpenComm;
        private System.Windows.Forms.GroupBox gb_Inventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_ASK;
        private System.Windows.Forms.RadioButton rb_FSK;
        private System.Windows.Forms.RadioButton rb_Multi;
        private System.Windows.Forms.RadioButton rb_Single;
        private System.Windows.Forms.ListBox lst_InventoryResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_ReadSingleBlock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Address_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_UID_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ReadSingleBlock;
        private System.Windows.Forms.GroupBox gb_WriteSingleBlock;
        private System.Windows.Forms.TextBox txt_WriteData_2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_UID_2;
        private System.Windows.Forms.TextBox txt_Address_2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_WriteSingleBlock;
        private System.Windows.Forms.ComboBox cmd_Length_2;
        private System.Windows.Forms.ComboBox cmd_Length_1;
        private System.Windows.Forms.TextBox txt_Result_1;
        private System.Windows.Forms.GroupBox gb_ReadMultiBlock;
        private System.Windows.Forms.Button btn_ReadMultiBlock;
        private System.Windows.Forms.ComboBox cmd_Length_3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_UID_3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Address_3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Number_3;
        private System.Windows.Forms.ListBox lst_Result;
        private System.Windows.Forms.GroupBox gb_WriteMultiBlock;
        private System.Windows.Forms.RichTextBox txt_WriteData_4;
        private System.Windows.Forms.Button btn_WriteMultiBlock;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_Number_4;
        private System.Windows.Forms.TextBox txt_Address_4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmd_Length_4;
        private System.Windows.Forms.ComboBox cmb_UID_4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gb_LockBlock;
        private System.Windows.Forms.ComboBox cmb_UID_5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_Address_5;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btn_LockSingleBlock;
        private System.Windows.Forms.GroupBox gb_StayQuiet;
        private System.Windows.Forms.ComboBox cmb_UID_6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn_StayQuiet;
        private System.Windows.Forms.GroupBox gb_Select;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ComboBox cmb_UID_7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox gb_ResetToReady;
        private System.Windows.Forms.ComboBox cmb_Mode;
        private System.Windows.Forms.Button btn_ResetToReady;
        private System.Windows.Forms.ComboBox cmb_UID_8;
        private System.Windows.Forms.Label lbl_UID;
        private System.Windows.Forms.GroupBox gb_WriteAFI;
        private System.Windows.Forms.ComboBox cmb_UID_9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_WriteAFI;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_AFI;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox gb_LockAFI;
        private System.Windows.Forms.Button btn_LockAFI;
        private System.Windows.Forms.ComboBox cmb_UID_10;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox gb_WriteDSFID;
        private System.Windows.Forms.Button btn_WriteDSFID;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_DSFID;
        private System.Windows.Forms.ComboBox cmb_UID_11;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox gb_LockDSFID;
        private System.Windows.Forms.Button btn_LockDSFID;
        private System.Windows.Forms.ComboBox cmb_UID_12;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox gb_GetSystemInfo;
        private System.Windows.Forms.Button btn_GetSystemInfo;
        private System.Windows.Forms.ComboBox cmb_UID_13;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txt_Info;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txt_UID;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txt_VICC;
        private System.Windows.Forms.TextBox txt_DSFID_2;
        private System.Windows.Forms.TextBox txt_AFI_2;
        private System.Windows.Forms.TextBox txt_ICRef;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox gb_GetMulti;
        private System.Windows.Forms.Button btn_GetMulti;
        private System.Windows.Forms.ComboBox cmb_UID_14;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ListBox lst_Result2;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txt_Number_14;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txt_Address_14;
        private System.Windows.Forms.RadioButton rb_AutoRcv;
        private System.Windows.Forms.RadioButton rb_EnableBuzzer;
        private System.Windows.Forms.RadioButton rb_GetAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb_EnableBuzzer;
        private System.Windows.Forms.Button btn_EnableBuzzer;
        private System.Windows.Forms.Button btn_AutoRun;
        private System.Windows.Forms.RadioButton rb_Flag_False;
        private System.Windows.Forms.RadioButton rb_Flag_True;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox gb_GetAll;
        private System.Windows.Forms.ListBox lst_GetAllResult;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txt_GetAllResult;
        private System.Windows.Forms.GroupBox gb_AutoRcv;
        private System.Windows.Forms.Button btn_AutoRcv;
        private System.Windows.Forms.Button btn_AutoGetAll;
        private System.Windows.Forms.Button btn_ClearAutoGetAllResult;
        private System.Windows.Forms.Timer timer1;
            private System.Windows.Forms.TabPage tabPage2;
            private System.Windows.Forms.ListBox lst_Info_Cfg;
            private System.Windows.Forms.GroupBox groupBox2;
            private System.Windows.Forms.RadioButton rb_ChannelConfig;
            private System.Windows.Forms.RadioButton rb_MultiplexConfig;
            private System.Windows.Forms.RadioButton rb_TagItConfig;
            private System.Windows.Forms.RadioButton rb_ICodeConfig;
            private System.Windows.Forms.RadioButton rb_TimingConfig;
            private System.Windows.Forms.RadioButton rb_ReaderConfig;
            private System.Windows.Forms.GroupBox gb_ReaderConfig;
            private System.Windows.Forms.Label label47;
            private System.Windows.Forms.Label label46;
            private System.Windows.Forms.Label label49;
            private System.Windows.Forms.Label label51;
            private System.Windows.Forms.Label label50;
            private System.Windows.Forms.Label label56;
            private System.Windows.Forms.Label label55;
            private System.Windows.Forms.Label label54;
            private System.Windows.Forms.Label label53;
            private System.Windows.Forms.Label label52;
            private System.Windows.Forms.Label label58;
            private System.Windows.Forms.Label label57;
            private System.Windows.Forms.TextBox txt_Index;
            private System.Windows.Forms.Label label61;
            private System.Windows.Forms.TextBox txt_Energy;
            private System.Windows.Forms.Label label60;
            private System.Windows.Forms.TextBox txt_TempReset;
            private System.Windows.Forms.Label label59;
            private System.Windows.Forms.TextBox txt_TempAlarm;
            private System.Windows.Forms.TextBox txt_EOFASK_2;
            private System.Windows.Forms.TextBox txt_SOFASK_2;
            private System.Windows.Forms.TextBox txt_EOFFSK_2;
            private System.Windows.Forms.TextBox txt_SOFFSK_2;
            private System.Windows.Forms.TextBox txt_EOFASK_1;
            private System.Windows.Forms.TextBox txt_SOFASK_1;
            private System.Windows.Forms.TextBox txt_EOFFSK_1;
            private System.Windows.Forms.TextBox txt_SOFFSK_1;
            private System.Windows.Forms.TextBox txt_SOFEOF;
            private System.Windows.Forms.TextBox txt_ISOASK;
            private System.Windows.Forms.TextBox txt_ISOFSK;
            private System.Windows.Forms.TextBox txt_RealTimeClock;
            private System.Windows.Forms.Button btn_SetReader;
            private System.Windows.Forms.Button btn_GetReader;
            private System.Windows.Forms.Button btn_LoadReader;
            private System.Windows.Forms.GroupBox gb_TimingConfig;
            private System.Windows.Forms.Button btn_SetTiming;
            private System.Windows.Forms.Button btn_GetTiming;
            private System.Windows.Forms.Button btn_LoadTiming;
            private System.Windows.Forms.TextBox txt_ASKRef_2;
            private System.Windows.Forms.TextBox txt_ASKTiming_2;
            private System.Windows.Forms.TextBox txt_FSKTiming_2;
            private System.Windows.Forms.TextBox txt_ASKRef_1;
            private System.Windows.Forms.TextBox txt_ASKTiming_1;
            private System.Windows.Forms.TextBox txt_FSKTiming_1;
            private System.Windows.Forms.Label label65;
            private System.Windows.Forms.Label label66;
            private System.Windows.Forms.Label label68;
            private System.Windows.Forms.ComboBox cmb_EASTagType;
            private System.Windows.Forms.Label label62;
            private System.Windows.Forms.GroupBox gb_ICodeConfig;
            private System.Windows.Forms.Label label63;
            private System.Windows.Forms.Button btn_SetICode;
            private System.Windows.Forms.Button btn_GetICode;
            private System.Windows.Forms.Button btn_LoadICode;
            private System.Windows.Forms.TextBox txt_Tuning;
            private System.Windows.Forms.TextBox txt_CollisionMarginICode;
            private System.Windows.Forms.TextBox txt_NoiseMargin;
            private System.Windows.Forms.Label label67;
            private System.Windows.Forms.Label label69;
            private System.Windows.Forms.GroupBox gb_TagItConfig;
            private System.Windows.Forms.Label label64;
            private System.Windows.Forms.Button btn_SetTagIt;
            private System.Windows.Forms.Button btn_GetTagIt;
            private System.Windows.Forms.Button btn_LoadTagIt;
            private System.Windows.Forms.TextBox txt_EndOfFrame_1;
            private System.Windows.Forms.TextBox txt_StartOfFrame_1;
            private System.Windows.Forms.TextBox txt_CollisionMarginTagIt;
            private System.Windows.Forms.Label label70;
            private System.Windows.Forms.Label label71;
            private System.Windows.Forms.TextBox txt_EndOfFrame_2;
            private System.Windows.Forms.TextBox txt_StartOfFrame_2;
            private System.Windows.Forms.GroupBox gb_MultiplexConfig;
            private System.Windows.Forms.Label label72;
            private System.Windows.Forms.Button btn_SetMultiplex;
            private System.Windows.Forms.Button btn_GetMultiplex;
            private System.Windows.Forms.Button btn_LoadMultiplex;
            private System.Windows.Forms.TextBox txt_AntennaTries;
            private System.Windows.Forms.TextBox txt_AntennaCount;
            private System.Windows.Forms.Label label73;
            private System.Windows.Forms.Label label74;
            private System.Windows.Forms.GroupBox groupBox3;
            private System.Windows.Forms.Label label75;
            private System.Windows.Forms.ComboBox cmb_BaudRate1;
            private System.Windows.Forms.Label label76;
            private System.Windows.Forms.ComboBox cmb_PortName;
            private System.Windows.Forms.Button btn_Refresh;
            private System.Windows.Forms.Button btn_Close;
            private System.Windows.Forms.Button btn_Open;
            private System.Windows.Forms.Button btn_RefreshComm;
            private System.Windows.Forms.Panel panel3;
            private System.Windows.Forms.RadioButton rb_SingleAntenna;
            private System.Windows.Forms.CheckBox chk_PhaseShift;
            private System.Windows.Forms.RadioButton rb_MultiplexGates;
            private System.Windows.Forms.RadioButton rb_SingleAxisGate;
            private System.Windows.Forms.TextBox txt_Antenna;
            private System.Windows.Forms.Label label77;
            private System.Windows.Forms.Button btn_Switch;
            private System.Windows.Forms.TabPage tabPage3;
            private System.Windows.Forms.GroupBox groupBox4;
            private System.Windows.Forms.Button btn_Refresh_Demo;
            private System.Windows.Forms.Button btn_Close_Demo;
            private System.Windows.Forms.Button btn_Open_Demo;
            private System.Windows.Forms.ComboBox cmb_BaudRate_Demo;
            private System.Windows.Forms.Label label80;
            private System.Windows.Forms.ComboBox cmb_PortName_Demo;
            private System.Windows.Forms.Label label81;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.Button button3;
            private System.Windows.Forms.ComboBox comboBox1;
            private System.Windows.Forms.Label label78;
            private System.Windows.Forms.ComboBox comboBox2;
            private System.Windows.Forms.Label label79;
            private System.Windows.Forms.GroupBox groupBox6;
            private System.Windows.Forms.GroupBox groupBox5;
            private System.Windows.Forms.Button btn_Clear;
            private System.Windows.Forms.ComboBox cmb_TagNumbers;
            private System.Windows.Forms.Label label82;
            private System.Windows.Forms.Button btn_InventoryDemo;
            private System.Windows.Forms.Label label83;
            private System.Windows.Forms.Label label87;
            private System.Windows.Forms.Label label88;
            private System.Windows.Forms.TextBox txt_UserTelephone;
            private System.Windows.Forms.TextBox txt_UserCompany;
            private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button btn_Browser;
        private System.Windows.Forms.PictureBox pic_UserPhoto;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
            private System.Windows.Forms.Button btn_Modify;
            private System.Windows.Forms.ListBox lst_Info_Demo;
            private System.Windows.Forms.Button btn_Clear_Demo;
            private System.Windows.Forms.Button btn_Monitor;
            private System.Windows.Forms.PictureBox pic_Photo_Monitor;
            private System.Windows.Forms.TextBox txt_TagNumber_Monitor;
            private System.Windows.Forms.TextBox txt_Company_Monitor;
            private System.Windows.Forms.Label label84;
            private System.Windows.Forms.Label label85;
            private System.Windows.Forms.TextBox txt_Telephone_Monitor;
            private System.Windows.Forms.Label label86;
            private System.Windows.Forms.Label label90;
            private System.Windows.Forms.TextBox txt_UserName_Monitor;
            private System.Windows.Forms.Button btn_Clear_Info;
            private System.Windows.Forms.Label label89;
            private System.Windows.Forms.TextBox txt_Appellative;
            private System.Windows.Forms.CheckBox chk_Voice;
            private System.Windows.Forms.TabPage tabPage4;
            private System.Windows.Forms.ListBox lsb_Info_14443;
            private System.Windows.Forms.GroupBox groupBox4_14443;
            private System.Windows.Forms.Button btn_Clear_14443;
            private System.Windows.Forms.TextBox txt_DataOut_14443;
            private System.Windows.Forms.Button btn_Read_14443;
            private System.Windows.Forms.Button btn_Write_14443;
            private System.Windows.Forms.TextBox txt_DataIn_14443;
            private System.Windows.Forms.GroupBox groupBox3_14443;
            private System.Windows.Forms.Label label92;
            private System.Windows.Forms.TextBox txt_Addr_14443;
            private System.Windows.Forms.TextBox txt_KeyA_14443;
            private System.Windows.Forms.Label label91;
            private System.Windows.Forms.Button btn_AuthA_14443;
            private System.Windows.Forms.GroupBox groupBox2_14443;
            private System.Windows.Forms.Button btn_Select_14443;
            private System.Windows.Forms.Button btn_ReqeustAll_14443;
            private System.Windows.Forms.Button btn_RequestNotSleep_14443;
            private System.Windows.Forms.Button btn_AntiColl_14443;
            private System.Windows.Forms.TextBox txt_Snr_14443;
            private System.Windows.Forms.GroupBox groupBox1_14443;
            private System.Windows.Forms.ComboBox cmb_BaudRate_14443;
            private System.Windows.Forms.Button btn_Close_14443;
            private System.Windows.Forms.Button btn_Open_14443;
            private System.Windows.Forms.ComboBox cmb_PortNum_14443;
            private System.Windows.Forms.Button btn_Refresh_14443;
            private System.Windows.Forms.GroupBox gb_OpenCloseHID;
            private System.Windows.Forms.Button btn_OpenHIDDevice;
            private System.Windows.Forms.RadioButton rb_OpenCloseHID;
            private System.Windows.Forms.Button btn_CloseHIDDevice;
            private System.Windows.Forms.Button btn_CloseUSB;
            private System.Windows.Forms.Button btn_OpenUSB;
            private System.Windows.Forms.Button btn_Inventory_14443;
            private System.Windows.Forms.Button btn_FastInventory;
            private System.Windows.Forms.Label label93;
            private System.Windows.Forms.TextBox txt_Count_14443;
            private System.Windows.Forms.Button btn_RemoveAll;
            private System.Windows.Forms.TabPage tabPage5;
            private System.Windows.Forms.Button btn_Clear_14443_B;
            private System.Windows.Forms.ListBox lsb_Info_14443_B;
            private System.Windows.Forms.GroupBox groupBox9;
            private System.Windows.Forms.Button btn_AttribB;
            private System.Windows.Forms.Button btn_ReqestAllB;
            private System.Windows.Forms.TextBox txt_UIDB;
            private System.Windows.Forms.GroupBox groupBox10;
            private System.Windows.Forms.Button btn_CloseUSBB;
            private System.Windows.Forms.Button btn_OpenUSBB;
            private System.Windows.Forms.Button btn_Refresh_14443B;
            private System.Windows.Forms.ComboBox cmb_BaudRate_14443B;
            private System.Windows.Forms.Button btn_Close_14443B;
            private System.Windows.Forms.Button btn_Open_14443B;
            private System.Windows.Forms.ComboBox cmb_PortNum_14443B;
            private System.Windows.Forms.Label label94;
            private System.Windows.Forms.Button btn_WakeUpB;
            private System.Windows.Forms.Button btn_HaltB;
            private System.Windows.Forms.Button btn_ReqestB;

    }
}

