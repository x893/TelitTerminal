namespace TelitTerminal
{
	partial class XTerminal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Python files", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Python compiled", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Other", System.Windows.Forms.HorizontalAlignment.Left);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XTerminal));
			this.cbPorts = new System.Windows.Forms.ComboBox();
			this.cbSpeed = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.FlowProtocol = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.folderSelected = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.filesHostCntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.filesDeviceCntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.setActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.compiler = new System.Windows.Forms.TextBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.linkEditor = new System.Windows.Forms.LinkLabel();
			this.DTR = new System.Windows.Forms.CheckBox();
			this.AutoLSCRIPT = new System.Windows.Forms.CheckBox();
			this.CRorCRLF = new System.Windows.Forms.CheckBox();
			this.RTS = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnOpen = new TelitTerminal.XButton();
			this.btnPortsRefresh = new TelitTerminal.XButton();
			this.btnCmd19 = new TelitTerminal.CmdButton();
			this.btnCmd18 = new TelitTerminal.CmdButton();
			this.btnCmd17 = new TelitTerminal.CmdButton();
			this.btnCmd16 = new TelitTerminal.CmdButton();
			this.btnCmd15 = new TelitTerminal.CmdButton();
			this.btnCmd14 = new TelitTerminal.CmdButton();
			this.btnCmd1 = new TelitTerminal.CmdButton();
			this.btnCmd5 = new TelitTerminal.CmdButton();
			this.btnCmd6 = new TelitTerminal.CmdButton();
			this.btnCmd13 = new TelitTerminal.CmdButton();
			this.btnCmd7 = new TelitTerminal.CmdButton();
			this.btnCmd12 = new TelitTerminal.CmdButton();
			this.btnCmd11 = new TelitTerminal.CmdButton();
			this.btnCmd4 = new TelitTerminal.CmdButton();
			this.btnCmd10 = new TelitTerminal.CmdButton();
			this.btnCmd2 = new TelitTerminal.CmdButton();
			this.btnCmd0 = new TelitTerminal.CmdButton();
			this.btnCmd8 = new TelitTerminal.CmdButton();
			this.btnCmd9 = new TelitTerminal.CmdButton();
			this.btnCmd3 = new TelitTerminal.CmdButton();
			this.label7 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnCmd41 = new TelitTerminal.CmdButton();
			this.GPSIFIX_UPDATE = new System.Windows.Forms.NumericUpDown();
			this.GPSIFIX_SGEE = new System.Windows.Forms.ComboBox();
			this.GPSIFIX_CGEE = new System.Windows.Forms.ComboBox();
			this.GPSIFIX_EN = new System.Windows.Forms.ComboBox();
			this.FTPGETIFIX_SIZE = new System.Windows.Forms.NumericUpDown();
			this.FTPGETIFIX_NAME = new System.Windows.Forms.TextBox();
			this.GPSCMODE = new System.Windows.Forms.ComboBox();
			this.GPSPS_PTF = new System.Windows.Forms.NumericUpDown();
			this.GPSPS = new System.Windows.Forms.ComboBox();
			this.GPSD = new System.Windows.Forms.ComboBox();
			this.btnCmd30 = new TelitTerminal.CmdButton();
			this.btnCmd40 = new TelitTerminal.CmdButton();
			this.btnCmd39 = new TelitTerminal.CmdButton();
			this.btnCmd38 = new TelitTerminal.CmdButton();
			this.btnCmd37 = new TelitTerminal.CmdButton();
			this.btnCmd36 = new TelitTerminal.CmdButton();
			this.btnCmd35 = new TelitTerminal.CmdButton();
			this.btnCmd21 = new TelitTerminal.CmdButton();
			this.btnCmd25 = new TelitTerminal.CmdButton();
			this.btnCmd26 = new TelitTerminal.CmdButton();
			this.btnCmd34 = new TelitTerminal.CmdButton();
			this.btnCmd27 = new TelitTerminal.CmdButton();
			this.btnCmd33 = new TelitTerminal.CmdButton();
			this.btnCmd32 = new TelitTerminal.CmdButton();
			this.btnCmd24 = new TelitTerminal.CmdButton();
			this.btnCmd31 = new TelitTerminal.CmdButton();
			this.btnCmd22 = new TelitTerminal.CmdButton();
			this.btnCmd20 = new TelitTerminal.CmdButton();
			this.btnCmd28 = new TelitTerminal.CmdButton();
			this.btnCmd29 = new TelitTerminal.CmdButton();
			this.btnCmd23 = new TelitTerminal.CmdButton();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnCmd71 = new TelitTerminal.CmdButton();
			this.btnCmd70 = new TelitTerminal.CmdButton();
			this.btnCmd69 = new TelitTerminal.CmdButton();
			this.btnCmd68 = new TelitTerminal.CmdButton();
			this.btnCmd67 = new TelitTerminal.CmdButton();
			this.btnCmd66 = new TelitTerminal.CmdButton();
			this.btnCmd65 = new TelitTerminal.CmdButton();
			this.btnCmd64 = new TelitTerminal.CmdButton();
			this.btnCmd63 = new TelitTerminal.CmdButton();
			this.btnCmd62 = new TelitTerminal.CmdButton();
			this.btnCmd60 = new TelitTerminal.CmdButton();
			this.btnCmd59 = new TelitTerminal.CmdButton();
			this.btnCmd58 = new TelitTerminal.CmdButton();
			this.btnCmd57 = new TelitTerminal.CmdButton();
			this.btnCmd56 = new TelitTerminal.CmdButton();
			this.btnCmd55 = new TelitTerminal.CmdButton();
			this.btnCmd54 = new TelitTerminal.CmdButton();
			this.btnCmd53 = new TelitTerminal.CmdButton();
			this.btnCmd61 = new TelitTerminal.CmdButton();
			this.btnCmd52 = new TelitTerminal.CmdButton();
			this.btnCmd51 = new TelitTerminal.CmdButton();
			this.CIBAUD = new System.Windows.Forms.ComboBox();
			this.btnCmd50 = new TelitTerminal.CmdButton();
			this.btnClearLog = new TelitTerminal.XButton();
			this.btnExecute = new TelitTerminal.XButton();
			this.btnStartMode = new TelitTerminal.XButton();
			this.btnSetActive = new TelitTerminal.XButton();
			this.btnDelete = new TelitTerminal.XButton();
			this.btnDownload = new TelitTerminal.XButton();
			this.btnRefreshDevice = new TelitTerminal.XButton();
			this.btnUpload = new TelitTerminal.XButton();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblCompiler = new System.Windows.Forms.LinkLabel();
			this.statusLine = new System.Windows.Forms.StatusStrip();
			this.Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.progress = new System.Windows.Forms.ToolStripProgressBar();
			this.cbHidden = new System.Windows.Forms.CheckBox();
			this.Echo = new System.Windows.Forms.CheckBox();
			this.editor = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.WordWrap = new System.Windows.Forms.CheckBox();
			this.btnSelectCompiler = new TelitTerminal.XButton();
			this.btnEdit = new TelitTerminal.XButton();
			this.btnSelectEditor = new TelitTerminal.XButton();
			this.btnExit = new TelitTerminal.XButton();
			this.log = new TelitTerminal.TextBoxEx();
			this.filesDevice = new TelitTerminal.ListViewEx();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.filesHost = new TelitTerminal.ListViewEx();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnCompile = new TelitTerminal.XButton();
			this.btnRefresh = new TelitTerminal.XButton();
			this.btnSelect = new TelitTerminal.XButton();
			this.filesHostCntxMenu.SuspendLayout();
			this.filesDeviceCntxMenu.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GPSIFIX_UPDATE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FTPGETIFIX_SIZE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GPSPS_PTF)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.statusLine.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbPorts
			// 
			this.cbPorts.FormattingEnabled = true;
			this.cbPorts.Location = new System.Drawing.Point(65, 18);
			this.cbPorts.Name = "cbPorts";
			this.cbPorts.Size = new System.Drawing.Size(100, 21);
			this.cbPorts.TabIndex = 0;
			// 
			// cbSpeed
			// 
			this.cbSpeed.FormattingEnabled = true;
			this.cbSpeed.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
			this.cbSpeed.Location = new System.Drawing.Point(65, 41);
			this.cbSpeed.Name = "cbSpeed";
			this.cbSpeed.Size = new System.Drawing.Size(100, 21);
			this.cbSpeed.TabIndex = 2;
			this.cbSpeed.SelectedIndexChanged += new System.EventHandler(this.cbSpeed_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(5, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Port";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(5, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Speed";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FlowProtocol
			// 
			this.FlowProtocol.FormattingEnabled = true;
			this.FlowProtocol.Items.AddRange(new object[] {
            "None",
            "Hardware"});
			this.FlowProtocol.Location = new System.Drawing.Point(65, 64);
			this.FlowProtocol.Name = "FlowProtocol";
			this.FlowProtocol.Size = new System.Drawing.Size(100, 21);
			this.FlowProtocol.TabIndex = 3;
			this.FlowProtocol.SelectedIndexChanged += new System.EventHandler(this.cbProtocol_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(5, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "Protocol";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// folderSelected
			// 
			this.folderSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.folderSelected.Location = new System.Drawing.Point(67, 559);
			this.folderSelected.Name = "folderSelected";
			this.folderSelected.Size = new System.Drawing.Size(392, 20);
			this.folderSelected.TabIndex = 11;
			this.folderSelected.Leave += new System.EventHandler(this.folderSelected_Leave);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(4, 558);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Folder";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// filesHostCntxMenu
			// 
			this.filesHostCntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.coToolStripMenuItem,
            this.mpToolStripMenuItem});
			this.filesHostCntxMenu.Name = "contextMenuStrip1";
			this.filesHostCntxMenu.Size = new System.Drawing.Size(125, 70);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// coToolStripMenuItem
			// 
			this.coToolStripMenuItem.Name = "coToolStripMenuItem";
			this.coToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.coToolStripMenuItem.Text = "&Compile";
			this.coToolStripMenuItem.Click += new System.EventHandler(this.btnCompile_Click);
			// 
			// mpToolStripMenuItem
			// 
			this.mpToolStripMenuItem.Name = "mpToolStripMenuItem";
			this.mpToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.mpToolStripMenuItem.Text = "&Upload";
			this.mpToolStripMenuItem.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// filesDeviceCntxMenu
			// 
			this.filesDeviceCntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setActiveToolStripMenuItem});
			this.filesDeviceCntxMenu.Name = "filesDeviceCntxMenu";
			this.filesDeviceCntxMenu.Size = new System.Drawing.Size(136, 76);
			// 
			// downloadToolStripMenuItem
			// 
			this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
			this.downloadToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.downloadToolStripMenuItem.Text = "&Download";
			this.downloadToolStripMenuItem.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
			// 
			// setActiveToolStripMenuItem
			// 
			this.setActiveToolStripMenuItem.Name = "setActiveToolStripMenuItem";
			this.setActiveToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.setActiveToolStripMenuItem.Text = "Set Active";
			this.setActiveToolStripMenuItem.Click += new System.EventHandler(this.btnSetActive_Click);
			// 
			// folderDialog
			// 
			this.folderDialog.Description = "Select folder";
			this.folderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// compiler
			// 
			this.compiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.compiler.Location = new System.Drawing.Point(67, 584);
			this.compiler.Name = "compiler";
			this.compiler.Size = new System.Drawing.Size(124, 20);
			this.compiler.TabIndex = 32;
			this.compiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// linkEditor
			// 
			this.linkEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkEditor.Location = new System.Drawing.Point(233, 584);
			this.linkEditor.Name = "linkEditor";
			this.linkEditor.Size = new System.Drawing.Size(55, 21);
			this.linkEditor.TabIndex = 34;
			this.linkEditor.TabStop = true;
			this.linkEditor.Tag = "";
			this.linkEditor.Text = "Editor";
			this.linkEditor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.linkEditor, "http://www.pnotepad.org/");
			this.linkEditor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditor_LinkClicked);
			// 
			// DTR
			// 
			this.DTR.AutoSize = true;
			this.DTR.Checked = true;
			this.DTR.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DTR.ForeColor = System.Drawing.SystemColors.Highlight;
			this.DTR.Location = new System.Drawing.Point(65, 97);
			this.DTR.Name = "DTR";
			this.DTR.Size = new System.Drawing.Size(85, 17);
			this.DTR.TabIndex = 40;
			this.DTR.Text = "DTR Enable";
			this.toolTip.SetToolTip(this.DTR, "Checked means DTR set to ON");
			this.DTR.UseVisualStyleBackColor = true;
			this.DTR.CheckedChanged += new System.EventHandler(this.cbDTR_CheckedChanged);
			// 
			// AutoLSCRIPT
			// 
			this.AutoLSCRIPT.AutoSize = true;
			this.AutoLSCRIPT.Checked = true;
			this.AutoLSCRIPT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoLSCRIPT.ForeColor = System.Drawing.SystemColors.Highlight;
			this.AutoLSCRIPT.Location = new System.Drawing.Point(65, 143);
			this.AutoLSCRIPT.Name = "AutoLSCRIPT";
			this.AutoLSCRIPT.Size = new System.Drawing.Size(96, 17);
			this.AutoLSCRIPT.TabIndex = 46;
			this.AutoLSCRIPT.Text = "Auto LSCRIPT";
			this.toolTip.SetToolTip(this.AutoLSCRIPT, "Make LSCRIPT on connect");
			this.AutoLSCRIPT.UseVisualStyleBackColor = true;
			// 
			// CRorCRLF
			// 
			this.CRorCRLF.AutoSize = true;
			this.CRorCRLF.Checked = true;
			this.CRorCRLF.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CRorCRLF.ForeColor = System.Drawing.SystemColors.Highlight;
			this.CRorCRLF.Location = new System.Drawing.Point(172, 97);
			this.CRorCRLF.Name = "CRorCRLF";
			this.CRorCRLF.Size = new System.Drawing.Size(80, 17);
			this.CRorCRLF.TabIndex = 47;
			this.CRorCRLF.Text = "CR=CR+LF";
			this.toolTip.SetToolTip(this.CRorCRLF, "Send CR+LF on CR");
			this.CRorCRLF.UseVisualStyleBackColor = true;
			// 
			// RTS
			// 
			this.RTS.AutoSize = true;
			this.RTS.Checked = true;
			this.RTS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.RTS.ForeColor = System.Drawing.SystemColors.Highlight;
			this.RTS.Location = new System.Drawing.Point(65, 120);
			this.RTS.Name = "RTS";
			this.RTS.Size = new System.Drawing.Size(84, 17);
			this.RTS.TabIndex = 48;
			this.RTS.Text = "RTS Enable";
			this.toolTip.SetToolTip(this.RTS, "Checked means DTR set to ON");
			this.RTS.UseVisualStyleBackColor = true;
			this.RTS.CheckedChanged += new System.EventHandler(this.cbRTS_CheckedChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(6, 10);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(489, 293);
			this.tabControl1.TabIndex = 53;
			this.toolTip.SetToolTip(this.tabControl1, "AT+CISTATUS");
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.btnCmd19);
			this.tabPage1.Controls.Add(this.btnCmd18);
			this.tabPage1.Controls.Add(this.btnCmd17);
			this.tabPage1.Controls.Add(this.btnCmd16);
			this.tabPage1.Controls.Add(this.btnCmd15);
			this.tabPage1.Controls.Add(this.btnCmd14);
			this.tabPage1.Controls.Add(this.btnCmd1);
			this.tabPage1.Controls.Add(this.btnCmd5);
			this.tabPage1.Controls.Add(this.btnCmd6);
			this.tabPage1.Controls.Add(this.btnCmd13);
			this.tabPage1.Controls.Add(this.btnCmd7);
			this.tabPage1.Controls.Add(this.btnCmd12);
			this.tabPage1.Controls.Add(this.btnCmd11);
			this.tabPage1.Controls.Add(this.btnCmd4);
			this.tabPage1.Controls.Add(this.btnCmd10);
			this.tabPage1.Controls.Add(this.btnCmd2);
			this.tabPage1.Controls.Add(this.btnCmd0);
			this.tabPage1.Controls.Add(this.btnCmd8);
			this.tabPage1.Controls.Add(this.btnCmd9);
			this.tabPage1.Controls.Add(this.btnCmd3);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(481, 267);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RTS);
			this.groupBox1.Controls.Add(this.CRorCRLF);
			this.groupBox1.Controls.Add(this.cbPorts);
			this.groupBox1.Controls.Add(this.DTR);
			this.groupBox1.Controls.Add(this.btnOpen);
			this.groupBox1.Controls.Add(this.cbSpeed);
			this.groupBox1.Controls.Add(this.AutoLSCRIPT);
			this.groupBox1.Controls.Add(this.btnPortsRefresh);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.FlowProtocol);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupBox1.Location = new System.Drawing.Point(4, 6);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(258, 253);
			this.groupBox1.TabIndex = 53;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Port Settings";
			// 
			// btnOpen
			// 
			this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnOpen.Location = new System.Drawing.Point(172, 62);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 4;
			this.btnOpen.Text = "F2 - &Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnPortsRefresh
			// 
			this.btnPortsRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPortsRefresh.Location = new System.Drawing.Point(172, 17);
			this.btnPortsRefresh.Name = "btnPortsRefresh";
			this.btnPortsRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnPortsRefresh.TabIndex = 1;
			this.btnPortsRefresh.Text = "&Refresh";
			this.btnPortsRefresh.UseVisualStyleBackColor = true;
			this.btnPortsRefresh.Click += new System.EventHandler(this.btnPortsRefresh_Click);
			// 
			// btnCmd19
			// 
			this.btnCmd19.AutoEllipsis = true;
			this.btnCmd19.Command = null;
			this.btnCmd19.Location = new System.Drawing.Point(374, 238);
			this.btnCmd19.Name = "btnCmd19";
			this.btnCmd19.Size = new System.Drawing.Size(100, 23);
			this.btnCmd19.TabIndex = 52;
			this.btnCmd19.Template = null;
			this.btnCmd19.Text = "AT#SHDN";
			this.btnCmd19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd19.UseVisualStyleBackColor = true;
			// 
			// btnCmd18
			// 
			this.btnCmd18.AutoEllipsis = true;
			this.btnCmd18.Command = null;
			this.btnCmd18.Location = new System.Drawing.Point(374, 215);
			this.btnCmd18.Name = "btnCmd18";
			this.btnCmd18.Size = new System.Drawing.Size(100, 23);
			this.btnCmd18.TabIndex = 51;
			this.btnCmd18.Template = null;
			this.btnCmd18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd18.UseVisualStyleBackColor = true;
			// 
			// btnCmd17
			// 
			this.btnCmd17.AutoEllipsis = true;
			this.btnCmd17.Command = null;
			this.btnCmd17.Location = new System.Drawing.Point(374, 192);
			this.btnCmd17.Name = "btnCmd17";
			this.btnCmd17.Size = new System.Drawing.Size(100, 23);
			this.btnCmd17.TabIndex = 50;
			this.btnCmd17.Template = null;
			this.btnCmd17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd17.UseVisualStyleBackColor = true;
			// 
			// btnCmd16
			// 
			this.btnCmd16.AutoEllipsis = true;
			this.btnCmd16.Command = null;
			this.btnCmd16.Location = new System.Drawing.Point(374, 169);
			this.btnCmd16.Name = "btnCmd16";
			this.btnCmd16.Size = new System.Drawing.Size(100, 23);
			this.btnCmd16.TabIndex = 49;
			this.btnCmd16.Template = null;
			this.btnCmd16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd16.UseVisualStyleBackColor = true;
			// 
			// btnCmd15
			// 
			this.btnCmd15.AutoEllipsis = true;
			this.btnCmd15.Command = null;
			this.btnCmd15.Location = new System.Drawing.Point(374, 146);
			this.btnCmd15.Name = "btnCmd15";
			this.btnCmd15.Size = new System.Drawing.Size(100, 23);
			this.btnCmd15.TabIndex = 48;
			this.btnCmd15.Template = null;
			this.btnCmd15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd15.UseVisualStyleBackColor = true;
			// 
			// btnCmd14
			// 
			this.btnCmd14.AutoEllipsis = true;
			this.btnCmd14.Command = null;
			this.btnCmd14.Location = new System.Drawing.Point(374, 123);
			this.btnCmd14.Name = "btnCmd14";
			this.btnCmd14.Size = new System.Drawing.Size(100, 23);
			this.btnCmd14.TabIndex = 47;
			this.btnCmd14.Template = null;
			this.btnCmd14.Text = "AT+CGATT?";
			this.btnCmd14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd14.UseVisualStyleBackColor = true;
			// 
			// btnCmd1
			// 
			this.btnCmd1.AutoEllipsis = true;
			this.btnCmd1.Command = null;
			this.btnCmd1.Location = new System.Drawing.Point(267, 54);
			this.btnCmd1.Name = "btnCmd1";
			this.btnCmd1.Size = new System.Drawing.Size(100, 23);
			this.btnCmd1.TabIndex = 21;
			this.btnCmd1.Template = null;
			this.btnCmd1.Text = "AT+CPIN?";
			this.btnCmd1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd1.UseVisualStyleBackColor = true;
			// 
			// btnCmd5
			// 
			this.btnCmd5.AutoEllipsis = true;
			this.btnCmd5.Command = null;
			this.btnCmd5.Location = new System.Drawing.Point(267, 146);
			this.btnCmd5.Name = "btnCmd5";
			this.btnCmd5.Size = new System.Drawing.Size(100, 23);
			this.btnCmd5.TabIndex = 25;
			this.btnCmd5.Template = null;
			this.btnCmd5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd5.UseVisualStyleBackColor = true;
			// 
			// btnCmd6
			// 
			this.btnCmd6.AutoEllipsis = true;
			this.btnCmd6.Command = null;
			this.btnCmd6.Location = new System.Drawing.Point(267, 169);
			this.btnCmd6.Name = "btnCmd6";
			this.btnCmd6.Size = new System.Drawing.Size(100, 23);
			this.btnCmd6.TabIndex = 26;
			this.btnCmd6.Template = null;
			this.btnCmd6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd6.UseVisualStyleBackColor = true;
			// 
			// btnCmd13
			// 
			this.btnCmd13.AutoEllipsis = true;
			this.btnCmd13.Command = null;
			this.btnCmd13.Location = new System.Drawing.Point(374, 100);
			this.btnCmd13.Name = "btnCmd13";
			this.btnCmd13.Size = new System.Drawing.Size(100, 23);
			this.btnCmd13.TabIndex = 33;
			this.btnCmd13.Template = null;
			this.btnCmd13.Text = "AT#MONI=7";
			this.btnCmd13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd13.UseVisualStyleBackColor = true;
			// 
			// btnCmd7
			// 
			this.btnCmd7.AutoEllipsis = true;
			this.btnCmd7.Command = null;
			this.btnCmd7.Location = new System.Drawing.Point(267, 192);
			this.btnCmd7.Name = "btnCmd7";
			this.btnCmd7.Size = new System.Drawing.Size(100, 23);
			this.btnCmd7.TabIndex = 27;
			this.btnCmd7.Template = null;
			this.btnCmd7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd7.UseVisualStyleBackColor = true;
			// 
			// btnCmd12
			// 
			this.btnCmd12.AutoEllipsis = true;
			this.btnCmd12.Command = null;
			this.btnCmd12.Location = new System.Drawing.Point(374, 77);
			this.btnCmd12.Name = "btnCmd12";
			this.btnCmd12.Size = new System.Drawing.Size(100, 23);
			this.btnCmd12.TabIndex = 32;
			this.btnCmd12.Template = null;
			this.btnCmd12.Text = "AT#MONI=0";
			this.btnCmd12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd12.UseVisualStyleBackColor = true;
			// 
			// btnCmd11
			// 
			this.btnCmd11.AutoEllipsis = true;
			this.btnCmd11.Command = null;
			this.btnCmd11.Location = new System.Drawing.Point(374, 54);
			this.btnCmd11.Name = "btnCmd11";
			this.btnCmd11.Size = new System.Drawing.Size(100, 23);
			this.btnCmd11.TabIndex = 31;
			this.btnCmd11.Template = null;
			this.btnCmd11.Text = "ATE1";
			this.btnCmd11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd11.UseVisualStyleBackColor = true;
			// 
			// btnCmd4
			// 
			this.btnCmd4.AutoEllipsis = true;
			this.btnCmd4.Command = null;
			this.btnCmd4.Location = new System.Drawing.Point(267, 123);
			this.btnCmd4.Name = "btnCmd4";
			this.btnCmd4.Size = new System.Drawing.Size(100, 23);
			this.btnCmd4.TabIndex = 24;
			this.btnCmd4.Template = null;
			this.btnCmd4.Text = "AT+CREG?";
			this.btnCmd4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd4.UseVisualStyleBackColor = true;
			// 
			// btnCmd10
			// 
			this.btnCmd10.AutoEllipsis = true;
			this.btnCmd10.Command = null;
			this.btnCmd10.Location = new System.Drawing.Point(374, 31);
			this.btnCmd10.Name = "btnCmd10";
			this.btnCmd10.Size = new System.Drawing.Size(100, 23);
			this.btnCmd10.TabIndex = 30;
			this.btnCmd10.Template = null;
			this.btnCmd10.Text = "ATE0";
			this.btnCmd10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd10.UseVisualStyleBackColor = true;
			// 
			// btnCmd2
			// 
			this.btnCmd2.AutoEllipsis = true;
			this.btnCmd2.Command = null;
			this.btnCmd2.Location = new System.Drawing.Point(267, 77);
			this.btnCmd2.Name = "btnCmd2";
			this.btnCmd2.Size = new System.Drawing.Size(100, 23);
			this.btnCmd2.TabIndex = 22;
			this.btnCmd2.Template = null;
			this.btnCmd2.Text = "AT#MONI";
			this.btnCmd2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd2.UseVisualStyleBackColor = true;
			// 
			// btnCmd0
			// 
			this.btnCmd0.AutoEllipsis = true;
			this.btnCmd0.Command = null;
			this.btnCmd0.Location = new System.Drawing.Point(267, 31);
			this.btnCmd0.Name = "btnCmd0";
			this.btnCmd0.Size = new System.Drawing.Size(100, 23);
			this.btnCmd0.TabIndex = 20;
			this.btnCmd0.Template = null;
			this.btnCmd0.Text = "AT";
			this.btnCmd0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd0.UseVisualStyleBackColor = true;
			// 
			// btnCmd8
			// 
			this.btnCmd8.AutoEllipsis = true;
			this.btnCmd8.Command = null;
			this.btnCmd8.Location = new System.Drawing.Point(267, 215);
			this.btnCmd8.Name = "btnCmd8";
			this.btnCmd8.Size = new System.Drawing.Size(100, 23);
			this.btnCmd8.TabIndex = 28;
			this.btnCmd8.Template = null;
			this.btnCmd8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd8.UseVisualStyleBackColor = true;
			// 
			// btnCmd9
			// 
			this.btnCmd9.AutoEllipsis = true;
			this.btnCmd9.Command = null;
			this.btnCmd9.Location = new System.Drawing.Point(267, 238);
			this.btnCmd9.Name = "btnCmd9";
			this.btnCmd9.Size = new System.Drawing.Size(100, 23);
			this.btnCmd9.TabIndex = 29;
			this.btnCmd9.Template = null;
			this.btnCmd9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd9.UseVisualStyleBackColor = true;
			// 
			// btnCmd3
			// 
			this.btnCmd3.AutoEllipsis = true;
			this.btnCmd3.Command = null;
			this.btnCmd3.Location = new System.Drawing.Point(267, 100);
			this.btnCmd3.Name = "btnCmd3";
			this.btnCmd3.Size = new System.Drawing.Size(100, 23);
			this.btnCmd3.TabIndex = 23;
			this.btnCmd3.Template = null;
			this.btnCmd3.Text = "AT+CMEE=2";
			this.btnCmd3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd3.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label7.Location = new System.Drawing.Point(267, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 21);
			this.label7.TabIndex = 41;
			this.label7.Text = "Alt+Number";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnCmd41);
			this.tabPage2.Controls.Add(this.GPSIFIX_UPDATE);
			this.tabPage2.Controls.Add(this.GPSIFIX_SGEE);
			this.tabPage2.Controls.Add(this.GPSIFIX_CGEE);
			this.tabPage2.Controls.Add(this.GPSIFIX_EN);
			this.tabPage2.Controls.Add(this.FTPGETIFIX_SIZE);
			this.tabPage2.Controls.Add(this.FTPGETIFIX_NAME);
			this.tabPage2.Controls.Add(this.GPSCMODE);
			this.tabPage2.Controls.Add(this.GPSPS_PTF);
			this.tabPage2.Controls.Add(this.GPSPS);
			this.tabPage2.Controls.Add(this.GPSD);
			this.tabPage2.Controls.Add(this.btnCmd30);
			this.tabPage2.Controls.Add(this.btnCmd40);
			this.tabPage2.Controls.Add(this.btnCmd39);
			this.tabPage2.Controls.Add(this.btnCmd38);
			this.tabPage2.Controls.Add(this.btnCmd37);
			this.tabPage2.Controls.Add(this.btnCmd36);
			this.tabPage2.Controls.Add(this.btnCmd35);
			this.tabPage2.Controls.Add(this.btnCmd21);
			this.tabPage2.Controls.Add(this.btnCmd25);
			this.tabPage2.Controls.Add(this.btnCmd26);
			this.tabPage2.Controls.Add(this.btnCmd34);
			this.tabPage2.Controls.Add(this.btnCmd27);
			this.tabPage2.Controls.Add(this.btnCmd33);
			this.tabPage2.Controls.Add(this.btnCmd32);
			this.tabPage2.Controls.Add(this.btnCmd24);
			this.tabPage2.Controls.Add(this.btnCmd31);
			this.tabPage2.Controls.Add(this.btnCmd22);
			this.tabPage2.Controls.Add(this.btnCmd20);
			this.tabPage2.Controls.Add(this.btnCmd28);
			this.tabPage2.Controls.Add(this.btnCmd29);
			this.tabPage2.Controls.Add(this.btnCmd23);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage2.Size = new System.Drawing.Size(481, 267);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "GPS";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnCmd41
			// 
			this.btnCmd41.AutoEllipsis = true;
			this.btnCmd41.Command = null;
			this.btnCmd41.Location = new System.Drawing.Point(279, 236);
			this.btnCmd41.Name = "btnCmd41";
			this.btnCmd41.Size = new System.Drawing.Size(120, 23);
			this.btnCmd41.TabIndex = 84;
			this.btnCmd41.Template = null;
			this.btnCmd41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd41.UseVisualStyleBackColor = true;
			// 
			// GPSIFIX_UPDATE
			// 
			this.GPSIFIX_UPDATE.Location = new System.Drawing.Point(236, 239);
			this.GPSIFIX_UPDATE.Margin = new System.Windows.Forms.Padding(2);
			this.GPSIFIX_UPDATE.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
			this.GPSIFIX_UPDATE.Name = "GPSIFIX_UPDATE";
			this.GPSIFIX_UPDATE.Size = new System.Drawing.Size(38, 20);
			this.GPSIFIX_UPDATE.TabIndex = 83;
			this.GPSIFIX_UPDATE.ValueChanged += new System.EventHandler(this.GPSIFIX_EN_SelectedIndexChanged);
			// 
			// GPSIFIX_SGEE
			// 
			this.GPSIFIX_SGEE.FormattingEnabled = true;
			this.GPSIFIX_SGEE.Items.AddRange(new object[] {
            "0",
            "1"});
			this.GPSIFIX_SGEE.Location = new System.Drawing.Point(201, 239);
			this.GPSIFIX_SGEE.Margin = new System.Windows.Forms.Padding(2);
			this.GPSIFIX_SGEE.Name = "GPSIFIX_SGEE";
			this.GPSIFIX_SGEE.Size = new System.Drawing.Size(32, 21);
			this.GPSIFIX_SGEE.TabIndex = 82;
			this.GPSIFIX_SGEE.Text = "0";
			this.GPSIFIX_SGEE.SelectedIndexChanged += new System.EventHandler(this.GPSIFIX_EN_SelectedIndexChanged);
			// 
			// GPSIFIX_CGEE
			// 
			this.GPSIFIX_CGEE.FormattingEnabled = true;
			this.GPSIFIX_CGEE.Items.AddRange(new object[] {
            "0",
            "1"});
			this.GPSIFIX_CGEE.Location = new System.Drawing.Point(166, 239);
			this.GPSIFIX_CGEE.Margin = new System.Windows.Forms.Padding(2);
			this.GPSIFIX_CGEE.Name = "GPSIFIX_CGEE";
			this.GPSIFIX_CGEE.Size = new System.Drawing.Size(32, 21);
			this.GPSIFIX_CGEE.TabIndex = 81;
			this.GPSIFIX_CGEE.Text = "0";
			this.GPSIFIX_CGEE.SelectedIndexChanged += new System.EventHandler(this.GPSIFIX_EN_SelectedIndexChanged);
			// 
			// GPSIFIX_EN
			// 
			this.GPSIFIX_EN.FormattingEnabled = true;
			this.GPSIFIX_EN.Items.AddRange(new object[] {
            "0",
            "1"});
			this.GPSIFIX_EN.Location = new System.Drawing.Point(130, 239);
			this.GPSIFIX_EN.Margin = new System.Windows.Forms.Padding(2);
			this.GPSIFIX_EN.Name = "GPSIFIX_EN";
			this.GPSIFIX_EN.Size = new System.Drawing.Size(32, 21);
			this.GPSIFIX_EN.TabIndex = 80;
			this.GPSIFIX_EN.Text = "0";
			this.GPSIFIX_EN.SelectedIndexChanged += new System.EventHandler(this.GPSIFIX_EN_SelectedIndexChanged);
			// 
			// FTPGETIFIX_SIZE
			// 
			this.FTPGETIFIX_SIZE.Location = new System.Drawing.Point(223, 190);
			this.FTPGETIFIX_SIZE.Margin = new System.Windows.Forms.Padding(2);
			this.FTPGETIFIX_SIZE.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.FTPGETIFIX_SIZE.Name = "FTPGETIFIX_SIZE";
			this.FTPGETIFIX_SIZE.Size = new System.Drawing.Size(38, 20);
			this.FTPGETIFIX_SIZE.TabIndex = 78;
			this.FTPGETIFIX_SIZE.ValueChanged += new System.EventHandler(this.FTPGETIFIX_NAME_TextChanged);
			// 
			// FTPGETIFIX_NAME
			// 
			this.FTPGETIFIX_NAME.Location = new System.Drawing.Point(130, 190);
			this.FTPGETIFIX_NAME.Margin = new System.Windows.Forms.Padding(2);
			this.FTPGETIFIX_NAME.Name = "FTPGETIFIX_NAME";
			this.FTPGETIFIX_NAME.Size = new System.Drawing.Size(89, 20);
			this.FTPGETIFIX_NAME.TabIndex = 77;
			this.FTPGETIFIX_NAME.TextChanged += new System.EventHandler(this.FTPGETIFIX_NAME_TextChanged);
			// 
			// GPSCMODE
			// 
			this.GPSCMODE.FormattingEnabled = true;
			this.GPSCMODE.Items.AddRange(new object[] {
            "0",
            "1"});
			this.GPSCMODE.Location = new System.Drawing.Point(404, 144);
			this.GPSCMODE.Margin = new System.Windows.Forms.Padding(2);
			this.GPSCMODE.Name = "GPSCMODE";
			this.GPSCMODE.Size = new System.Drawing.Size(32, 21);
			this.GPSCMODE.TabIndex = 76;
			this.GPSCMODE.Text = "0";
			this.GPSCMODE.SelectedIndexChanged += new System.EventHandler(this.GPSCMODE_SelectedIndexChanged);
			// 
			// GPSPS_PTF
			// 
			this.GPSPS_PTF.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.GPSPS_PTF.Location = new System.Drawing.Point(166, 98);
			this.GPSPS_PTF.Margin = new System.Windows.Forms.Padding(2);
			this.GPSPS_PTF.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
			this.GPSPS_PTF.Name = "GPSPS_PTF";
			this.GPSPS_PTF.Size = new System.Drawing.Size(52, 20);
			this.GPSPS_PTF.TabIndex = 75;
			this.GPSPS_PTF.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
			this.GPSPS_PTF.ValueChanged += new System.EventHandler(this.GPSPS_PTF_ValueChanged);
			// 
			// GPSPS
			// 
			this.GPSPS.FormattingEnabled = true;
			this.GPSPS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
			this.GPSPS.Location = new System.Drawing.Point(130, 98);
			this.GPSPS.Margin = new System.Windows.Forms.Padding(2);
			this.GPSPS.Name = "GPSPS";
			this.GPSPS.Size = new System.Drawing.Size(32, 21);
			this.GPSPS.TabIndex = 74;
			this.GPSPS.Text = "0";
			this.GPSPS.SelectedIndexChanged += new System.EventHandler(this.GPSPS_SelectedIndexChanged);
			// 
			// GPSD
			// 
			this.GPSD.FormattingEnabled = true;
			this.GPSD.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
			this.GPSD.Location = new System.Drawing.Point(130, 8);
			this.GPSD.Margin = new System.Windows.Forms.Padding(2);
			this.GPSD.Name = "GPSD";
			this.GPSD.Size = new System.Drawing.Size(32, 21);
			this.GPSD.TabIndex = 73;
			this.GPSD.Text = "0";
			this.GPSD.SelectedIndexChanged += new System.EventHandler(this.GPSD_SelectedIndexChanged);
			// 
			// btnCmd30
			// 
			this.btnCmd30.AutoEllipsis = true;
			this.btnCmd30.Command = "AT$GPSIFIX=0,0,0,0";
			this.btnCmd30.Location = new System.Drawing.Point(5, 236);
			this.btnCmd30.Name = "btnCmd30";
			this.btnCmd30.Size = new System.Drawing.Size(120, 23);
			this.btnCmd30.TabIndex = 79;
			this.btnCmd30.Template = "AT$GPSIFIX=#VALUE";
			this.btnCmd30.Text = "AT$GPSIFIX=";
			this.btnCmd30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd30.UseVisualStyleBackColor = true;
			// 
			// btnCmd40
			// 
			this.btnCmd40.AutoEllipsis = true;
			this.btnCmd40.Command = null;
			this.btnCmd40.Location = new System.Drawing.Point(279, 213);
			this.btnCmd40.Name = "btnCmd40";
			this.btnCmd40.Size = new System.Drawing.Size(120, 23);
			this.btnCmd40.TabIndex = 72;
			this.btnCmd40.Template = null;
			this.btnCmd40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd40.UseVisualStyleBackColor = true;
			// 
			// btnCmd39
			// 
			this.btnCmd39.AutoEllipsis = true;
			this.btnCmd39.Command = null;
			this.btnCmd39.Location = new System.Drawing.Point(279, 190);
			this.btnCmd39.Name = "btnCmd39";
			this.btnCmd39.Size = new System.Drawing.Size(120, 23);
			this.btnCmd39.TabIndex = 71;
			this.btnCmd39.Template = null;
			this.btnCmd39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd39.UseVisualStyleBackColor = true;
			// 
			// btnCmd38
			// 
			this.btnCmd38.AutoEllipsis = true;
			this.btnCmd38.Command = null;
			this.btnCmd38.Location = new System.Drawing.Point(279, 167);
			this.btnCmd38.Name = "btnCmd38";
			this.btnCmd38.Size = new System.Drawing.Size(120, 23);
			this.btnCmd38.TabIndex = 70;
			this.btnCmd38.Template = null;
			this.btnCmd38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd38.UseVisualStyleBackColor = true;
			// 
			// btnCmd37
			// 
			this.btnCmd37.AutoEllipsis = true;
			this.btnCmd37.Command = "AT$GPSCMODE=";
			this.btnCmd37.Location = new System.Drawing.Point(279, 144);
			this.btnCmd37.Name = "btnCmd37";
			this.btnCmd37.Size = new System.Drawing.Size(120, 23);
			this.btnCmd37.TabIndex = 69;
			this.btnCmd37.Template = "AT$GPSCMODE=#VALUE";
			this.btnCmd37.Text = "AT$GPSCMODE=0";
			this.btnCmd37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd37.UseVisualStyleBackColor = true;
			// 
			// btnCmd36
			// 
			this.btnCmd36.AutoEllipsis = true;
			this.btnCmd36.Command = null;
			this.btnCmd36.Location = new System.Drawing.Point(279, 121);
			this.btnCmd36.Name = "btnCmd36";
			this.btnCmd36.Size = new System.Drawing.Size(120, 23);
			this.btnCmd36.TabIndex = 68;
			this.btnCmd36.Template = null;
			this.btnCmd36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd36.UseVisualStyleBackColor = true;
			// 
			// btnCmd35
			// 
			this.btnCmd35.AutoEllipsis = true;
			this.btnCmd35.Command = null;
			this.btnCmd35.Location = new System.Drawing.Point(279, 98);
			this.btnCmd35.Name = "btnCmd35";
			this.btnCmd35.Size = new System.Drawing.Size(120, 23);
			this.btnCmd35.TabIndex = 67;
			this.btnCmd35.Template = null;
			this.btnCmd35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd35.UseVisualStyleBackColor = true;
			// 
			// btnCmd21
			// 
			this.btnCmd21.AutoEllipsis = true;
			this.btnCmd21.Command = null;
			this.btnCmd21.Location = new System.Drawing.Point(5, 29);
			this.btnCmd21.Name = "btnCmd21";
			this.btnCmd21.Size = new System.Drawing.Size(120, 23);
			this.btnCmd21.TabIndex = 54;
			this.btnCmd21.Template = null;
			this.btnCmd21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd21.UseVisualStyleBackColor = true;
			// 
			// btnCmd25
			// 
			this.btnCmd25.AutoEllipsis = true;
			this.btnCmd25.Command = null;
			this.btnCmd25.Location = new System.Drawing.Point(5, 121);
			this.btnCmd25.Name = "btnCmd25";
			this.btnCmd25.Size = new System.Drawing.Size(120, 23);
			this.btnCmd25.TabIndex = 58;
			this.btnCmd25.Template = null;
			this.btnCmd25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd25.UseVisualStyleBackColor = true;
			// 
			// btnCmd26
			// 
			this.btnCmd26.AutoEllipsis = true;
			this.btnCmd26.Command = null;
			this.btnCmd26.Location = new System.Drawing.Point(5, 144);
			this.btnCmd26.Name = "btnCmd26";
			this.btnCmd26.Size = new System.Drawing.Size(120, 23);
			this.btnCmd26.TabIndex = 59;
			this.btnCmd26.Template = null;
			this.btnCmd26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd26.UseVisualStyleBackColor = true;
			// 
			// btnCmd34
			// 
			this.btnCmd34.AutoEllipsis = true;
			this.btnCmd34.Command = null;
			this.btnCmd34.Location = new System.Drawing.Point(279, 75);
			this.btnCmd34.Name = "btnCmd34";
			this.btnCmd34.Size = new System.Drawing.Size(120, 23);
			this.btnCmd34.TabIndex = 66;
			this.btnCmd34.Template = null;
			this.btnCmd34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd34.UseVisualStyleBackColor = true;
			// 
			// btnCmd27
			// 
			this.btnCmd27.AutoEllipsis = true;
			this.btnCmd27.Command = null;
			this.btnCmd27.Location = new System.Drawing.Point(5, 167);
			this.btnCmd27.Name = "btnCmd27";
			this.btnCmd27.Size = new System.Drawing.Size(120, 23);
			this.btnCmd27.TabIndex = 60;
			this.btnCmd27.Template = null;
			this.btnCmd27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd27.UseVisualStyleBackColor = true;
			// 
			// btnCmd33
			// 
			this.btnCmd33.AutoEllipsis = true;
			this.btnCmd33.Command = null;
			this.btnCmd33.Location = new System.Drawing.Point(279, 52);
			this.btnCmd33.Name = "btnCmd33";
			this.btnCmd33.Size = new System.Drawing.Size(120, 23);
			this.btnCmd33.TabIndex = 65;
			this.btnCmd33.Template = null;
			this.btnCmd33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd33.UseVisualStyleBackColor = true;
			// 
			// btnCmd32
			// 
			this.btnCmd32.AutoEllipsis = true;
			this.btnCmd32.Command = null;
			this.btnCmd32.Location = new System.Drawing.Point(279, 29);
			this.btnCmd32.Name = "btnCmd32";
			this.btnCmd32.Size = new System.Drawing.Size(120, 23);
			this.btnCmd32.TabIndex = 64;
			this.btnCmd32.Template = null;
			this.btnCmd32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd32.UseVisualStyleBackColor = true;
			// 
			// btnCmd24
			// 
			this.btnCmd24.AutoEllipsis = true;
			this.btnCmd24.Command = "AT$GPSPS=0";
			this.btnCmd24.Location = new System.Drawing.Point(5, 98);
			this.btnCmd24.Name = "btnCmd24";
			this.btnCmd24.Size = new System.Drawing.Size(120, 23);
			this.btnCmd24.TabIndex = 57;
			this.btnCmd24.Template = "AT$GPSPS=#VALUE";
			this.btnCmd24.Text = "AT$GPSPS=";
			this.btnCmd24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd24.UseVisualStyleBackColor = true;
			// 
			// btnCmd31
			// 
			this.btnCmd31.AutoEllipsis = true;
			this.btnCmd31.Command = null;
			this.btnCmd31.Location = new System.Drawing.Point(279, 6);
			this.btnCmd31.Name = "btnCmd31";
			this.btnCmd31.Size = new System.Drawing.Size(120, 23);
			this.btnCmd31.TabIndex = 63;
			this.btnCmd31.Template = null;
			this.btnCmd31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd31.UseVisualStyleBackColor = true;
			// 
			// btnCmd22
			// 
			this.btnCmd22.AutoEllipsis = true;
			this.btnCmd22.Command = null;
			this.btnCmd22.Location = new System.Drawing.Point(5, 52);
			this.btnCmd22.Name = "btnCmd22";
			this.btnCmd22.Size = new System.Drawing.Size(120, 23);
			this.btnCmd22.TabIndex = 55;
			this.btnCmd22.Template = null;
			this.btnCmd22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd22.UseVisualStyleBackColor = true;
			// 
			// btnCmd20
			// 
			this.btnCmd20.AutoEllipsis = true;
			this.btnCmd20.Command = "AT$GPSD=0";
			this.btnCmd20.Location = new System.Drawing.Point(5, 6);
			this.btnCmd20.Name = "btnCmd20";
			this.btnCmd20.Size = new System.Drawing.Size(120, 23);
			this.btnCmd20.TabIndex = 53;
			this.btnCmd20.Template = "AT$GPSD=#VALUE";
			this.btnCmd20.Text = "AT$GPSD=";
			this.btnCmd20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd20.UseVisualStyleBackColor = true;
			// 
			// btnCmd28
			// 
			this.btnCmd28.AutoEllipsis = true;
			this.btnCmd28.Command = "AT$FTPGETIFIX=,0";
			this.btnCmd28.Location = new System.Drawing.Point(5, 190);
			this.btnCmd28.Name = "btnCmd28";
			this.btnCmd28.Size = new System.Drawing.Size(120, 23);
			this.btnCmd28.TabIndex = 61;
			this.btnCmd28.Template = "AT$FTPGETIFIX=#VALUE";
			this.btnCmd28.Text = "AT$FTPGETIFIX=";
			this.btnCmd28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd28.UseVisualStyleBackColor = true;
			// 
			// btnCmd29
			// 
			this.btnCmd29.AutoEllipsis = true;
			this.btnCmd29.Command = null;
			this.btnCmd29.Location = new System.Drawing.Point(5, 213);
			this.btnCmd29.Name = "btnCmd29";
			this.btnCmd29.Size = new System.Drawing.Size(120, 23);
			this.btnCmd29.TabIndex = 62;
			this.btnCmd29.Template = "";
			this.btnCmd29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd29.UseVisualStyleBackColor = true;
			// 
			// btnCmd23
			// 
			this.btnCmd23.AutoEllipsis = true;
			this.btnCmd23.Command = null;
			this.btnCmd23.Location = new System.Drawing.Point(5, 75);
			this.btnCmd23.Name = "btnCmd23";
			this.btnCmd23.Size = new System.Drawing.Size(120, 23);
			this.btnCmd23.TabIndex = 56;
			this.btnCmd23.Template = null;
			this.btnCmd23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd23.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnCmd71);
			this.tabPage3.Controls.Add(this.btnCmd70);
			this.tabPage3.Controls.Add(this.btnCmd69);
			this.tabPage3.Controls.Add(this.btnCmd68);
			this.tabPage3.Controls.Add(this.btnCmd67);
			this.tabPage3.Controls.Add(this.btnCmd66);
			this.tabPage3.Controls.Add(this.btnCmd65);
			this.tabPage3.Controls.Add(this.btnCmd64);
			this.tabPage3.Controls.Add(this.btnCmd63);
			this.tabPage3.Controls.Add(this.btnCmd62);
			this.tabPage3.Controls.Add(this.btnCmd60);
			this.tabPage3.Controls.Add(this.btnCmd59);
			this.tabPage3.Controls.Add(this.btnCmd58);
			this.tabPage3.Controls.Add(this.btnCmd57);
			this.tabPage3.Controls.Add(this.btnCmd56);
			this.tabPage3.Controls.Add(this.btnCmd55);
			this.tabPage3.Controls.Add(this.btnCmd54);
			this.tabPage3.Controls.Add(this.btnCmd53);
			this.tabPage3.Controls.Add(this.btnCmd61);
			this.tabPage3.Controls.Add(this.btnCmd52);
			this.tabPage3.Controls.Add(this.btnCmd51);
			this.tabPage3.Controls.Add(this.CIBAUD);
			this.tabPage3.Controls.Add(this.btnCmd50);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(481, 267);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "ESP8266";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btnCmd71
			// 
			this.btnCmd71.AutoEllipsis = true;
			this.btnCmd71.Command = null;
			this.btnCmd71.Location = new System.Drawing.Point(111, 235);
			this.btnCmd71.Name = "btnCmd71";
			this.btnCmd71.Size = new System.Drawing.Size(100, 23);
			this.btnCmd71.TabIndex = 21;
			this.btnCmd71.Template = null;
			this.btnCmd71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd71.UseVisualStyleBackColor = true;
			// 
			// btnCmd70
			// 
			this.btnCmd70.AutoEllipsis = true;
			this.btnCmd70.Command = null;
			this.btnCmd70.Location = new System.Drawing.Point(111, 212);
			this.btnCmd70.Name = "btnCmd70";
			this.btnCmd70.Size = new System.Drawing.Size(100, 23);
			this.btnCmd70.TabIndex = 20;
			this.btnCmd70.Template = null;
			this.btnCmd70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd70.UseVisualStyleBackColor = true;
			// 
			// btnCmd69
			// 
			this.btnCmd69.AutoEllipsis = true;
			this.btnCmd69.Command = null;
			this.btnCmd69.Location = new System.Drawing.Point(111, 189);
			this.btnCmd69.Name = "btnCmd69";
			this.btnCmd69.Size = new System.Drawing.Size(100, 23);
			this.btnCmd69.TabIndex = 19;
			this.btnCmd69.Template = null;
			this.btnCmd69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd69.UseVisualStyleBackColor = true;
			// 
			// btnCmd68
			// 
			this.btnCmd68.AutoEllipsis = true;
			this.btnCmd68.Command = null;
			this.btnCmd68.Location = new System.Drawing.Point(111, 166);
			this.btnCmd68.Name = "btnCmd68";
			this.btnCmd68.Size = new System.Drawing.Size(100, 23);
			this.btnCmd68.TabIndex = 18;
			this.btnCmd68.Template = null;
			this.btnCmd68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd68.UseVisualStyleBackColor = true;
			// 
			// btnCmd67
			// 
			this.btnCmd67.AutoEllipsis = true;
			this.btnCmd67.Command = null;
			this.btnCmd67.Location = new System.Drawing.Point(111, 143);
			this.btnCmd67.Name = "btnCmd67";
			this.btnCmd67.Size = new System.Drawing.Size(100, 23);
			this.btnCmd67.TabIndex = 16;
			this.btnCmd67.Template = null;
			this.btnCmd67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd67.UseVisualStyleBackColor = true;
			// 
			// btnCmd66
			// 
			this.btnCmd66.AutoEllipsis = true;
			this.btnCmd66.Command = null;
			this.btnCmd66.Location = new System.Drawing.Point(111, 120);
			this.btnCmd66.Name = "btnCmd66";
			this.btnCmd66.Size = new System.Drawing.Size(100, 23);
			this.btnCmd66.TabIndex = 17;
			this.btnCmd66.Template = null;
			this.btnCmd66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd66.UseVisualStyleBackColor = true;
			// 
			// btnCmd65
			// 
			this.btnCmd65.AutoEllipsis = true;
			this.btnCmd65.Command = null;
			this.btnCmd65.Location = new System.Drawing.Point(111, 97);
			this.btnCmd65.Name = "btnCmd65";
			this.btnCmd65.Size = new System.Drawing.Size(100, 23);
			this.btnCmd65.TabIndex = 15;
			this.btnCmd65.Template = null;
			this.btnCmd65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd65.UseVisualStyleBackColor = true;
			// 
			// btnCmd64
			// 
			this.btnCmd64.AutoEllipsis = true;
			this.btnCmd64.Command = null;
			this.btnCmd64.Location = new System.Drawing.Point(111, 74);
			this.btnCmd64.Name = "btnCmd64";
			this.btnCmd64.Size = new System.Drawing.Size(100, 23);
			this.btnCmd64.TabIndex = 14;
			this.btnCmd64.Template = null;
			this.btnCmd64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd64.UseVisualStyleBackColor = true;
			// 
			// btnCmd63
			// 
			this.btnCmd63.AutoEllipsis = true;
			this.btnCmd63.Command = null;
			this.btnCmd63.Location = new System.Drawing.Point(323, 6);
			this.btnCmd63.Name = "btnCmd63";
			this.btnCmd63.Size = new System.Drawing.Size(100, 23);
			this.btnCmd63.TabIndex = 3;
			this.btnCmd63.Template = null;
			this.btnCmd63.Text = "AT+CWMODE=2";
			this.btnCmd63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd63.UseVisualStyleBackColor = true;
			// 
			// btnCmd62
			// 
			this.btnCmd62.AutoEllipsis = true;
			this.btnCmd62.Command = null;
			this.btnCmd62.Location = new System.Drawing.Point(217, 6);
			this.btnCmd62.Name = "btnCmd62";
			this.btnCmd62.Size = new System.Drawing.Size(100, 23);
			this.btnCmd62.TabIndex = 2;
			this.btnCmd62.Template = null;
			this.btnCmd62.Text = "AT+CWMODE=1";
			this.btnCmd62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd62.UseVisualStyleBackColor = true;
			// 
			// btnCmd60
			// 
			this.btnCmd60.AutoEllipsis = true;
			this.btnCmd60.Command = null;
			this.btnCmd60.Location = new System.Drawing.Point(5, 235);
			this.btnCmd60.Name = "btnCmd60";
			this.btnCmd60.Size = new System.Drawing.Size(100, 23);
			this.btnCmd60.TabIndex = 13;
			this.btnCmd60.Template = null;
			this.btnCmd60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd60.UseVisualStyleBackColor = true;
			// 
			// btnCmd59
			// 
			this.btnCmd59.AutoEllipsis = true;
			this.btnCmd59.Command = null;
			this.btnCmd59.Location = new System.Drawing.Point(5, 212);
			this.btnCmd59.Name = "btnCmd59";
			this.btnCmd59.Size = new System.Drawing.Size(100, 23);
			this.btnCmd59.TabIndex = 12;
			this.btnCmd59.Template = null;
			this.btnCmd59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd59.UseVisualStyleBackColor = true;
			// 
			// btnCmd58
			// 
			this.btnCmd58.AutoEllipsis = true;
			this.btnCmd58.Command = null;
			this.btnCmd58.Location = new System.Drawing.Point(5, 189);
			this.btnCmd58.Name = "btnCmd58";
			this.btnCmd58.Size = new System.Drawing.Size(100, 23);
			this.btnCmd58.TabIndex = 11;
			this.btnCmd58.Template = null;
			this.btnCmd58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd58.UseVisualStyleBackColor = true;
			// 
			// btnCmd57
			// 
			this.btnCmd57.AutoEllipsis = true;
			this.btnCmd57.Command = null;
			this.btnCmd57.Location = new System.Drawing.Point(5, 166);
			this.btnCmd57.Name = "btnCmd57";
			this.btnCmd57.Size = new System.Drawing.Size(100, 23);
			this.btnCmd57.TabIndex = 10;
			this.btnCmd57.Template = null;
			this.btnCmd57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd57.UseVisualStyleBackColor = true;
			// 
			// btnCmd56
			// 
			this.btnCmd56.AutoEllipsis = true;
			this.btnCmd56.Command = null;
			this.btnCmd56.Location = new System.Drawing.Point(5, 143);
			this.btnCmd56.Name = "btnCmd56";
			this.btnCmd56.Size = new System.Drawing.Size(100, 23);
			this.btnCmd56.TabIndex = 9;
			this.btnCmd56.Template = null;
			this.btnCmd56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd56.UseVisualStyleBackColor = true;
			// 
			// btnCmd55
			// 
			this.btnCmd55.AutoEllipsis = true;
			this.btnCmd55.Command = null;
			this.btnCmd55.Location = new System.Drawing.Point(5, 120);
			this.btnCmd55.Name = "btnCmd55";
			this.btnCmd55.Size = new System.Drawing.Size(100, 23);
			this.btnCmd55.TabIndex = 9;
			this.btnCmd55.Template = null;
			this.btnCmd55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd55.UseVisualStyleBackColor = true;
			// 
			// btnCmd54
			// 
			this.btnCmd54.AutoEllipsis = true;
			this.btnCmd54.Command = null;
			this.btnCmd54.Location = new System.Drawing.Point(5, 97);
			this.btnCmd54.Name = "btnCmd54";
			this.btnCmd54.Size = new System.Drawing.Size(100, 23);
			this.btnCmd54.TabIndex = 8;
			this.btnCmd54.Template = null;
			this.btnCmd54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd54.UseVisualStyleBackColor = true;
			// 
			// btnCmd53
			// 
			this.btnCmd53.AutoEllipsis = true;
			this.btnCmd53.Command = null;
			this.btnCmd53.Location = new System.Drawing.Point(5, 74);
			this.btnCmd53.Name = "btnCmd53";
			this.btnCmd53.Size = new System.Drawing.Size(100, 23);
			this.btnCmd53.TabIndex = 7;
			this.btnCmd53.Template = null;
			this.btnCmd53.Text = "AT+GMR";
			this.btnCmd53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd53.UseVisualStyleBackColor = true;
			// 
			// btnCmd61
			// 
			this.btnCmd61.AutoEllipsis = true;
			this.btnCmd61.Command = null;
			this.btnCmd61.Location = new System.Drawing.Point(111, 6);
			this.btnCmd61.Name = "btnCmd61";
			this.btnCmd61.Size = new System.Drawing.Size(100, 23);
			this.btnCmd61.TabIndex = 1;
			this.btnCmd61.Template = null;
			this.btnCmd61.Text = "AT+CWMODE?";
			this.btnCmd61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd61.UseVisualStyleBackColor = true;
			// 
			// btnCmd52
			// 
			this.btnCmd52.AutoEllipsis = true;
			this.btnCmd52.Command = null;
			this.btnCmd52.Location = new System.Drawing.Point(5, 51);
			this.btnCmd52.Name = "btnCmd52";
			this.btnCmd52.Size = new System.Drawing.Size(100, 23);
			this.btnCmd52.TabIndex = 5;
			this.btnCmd52.Template = "AT+CIOBAUD=#VALUE";
			this.btnCmd52.Text = "AT+CIOBAUD=";
			this.btnCmd52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd52.UseVisualStyleBackColor = true;
			// 
			// btnCmd51
			// 
			this.btnCmd51.AutoEllipsis = true;
			this.btnCmd51.Command = null;
			this.btnCmd51.Location = new System.Drawing.Point(5, 28);
			this.btnCmd51.Name = "btnCmd51";
			this.btnCmd51.Size = new System.Drawing.Size(100, 23);
			this.btnCmd51.TabIndex = 4;
			this.btnCmd51.Template = null;
			this.btnCmd51.Text = "AT+RST";
			this.btnCmd51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd51.UseVisualStyleBackColor = true;
			// 
			// CIBAUD
			// 
			this.CIBAUD.FormattingEnabled = true;
			this.CIBAUD.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
			this.CIBAUD.Location = new System.Drawing.Point(111, 51);
			this.CIBAUD.Name = "CIBAUD";
			this.CIBAUD.Size = new System.Drawing.Size(100, 21);
			this.CIBAUD.TabIndex = 6;
			this.CIBAUD.SelectedIndexChanged += new System.EventHandler(this.CIBAUD_SelectedIndexChanged);
			// 
			// btnCmd50
			// 
			this.btnCmd50.AutoEllipsis = true;
			this.btnCmd50.Command = null;
			this.btnCmd50.Location = new System.Drawing.Point(5, 6);
			this.btnCmd50.Name = "btnCmd50";
			this.btnCmd50.Size = new System.Drawing.Size(100, 23);
			this.btnCmd50.TabIndex = 0;
			this.btnCmd50.Template = null;
			this.btnCmd50.Text = "AT+CWLAP";
			this.btnCmd50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd50.UseVisualStyleBackColor = true;
			// 
			// btnClearLog
			// 
			this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearLog.Location = new System.Drawing.Point(856, 4);
			this.btnClearLog.Name = "btnClearLog";
			this.btnClearLog.Size = new System.Drawing.Size(75, 23);
			this.btnClearLog.TabIndex = 29;
			this.btnClearLog.Text = "Clear &Log";
			this.toolTip.SetToolTip(this.btnClearLog, "AT#LSCRIPT");
			this.btnClearLog.UseVisualStyleBackColor = true;
			this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(208, 457);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(90, 23);
			this.btnExecute.TabIndex = 17;
			this.btnExecute.Text = "F8 - Execute";
			this.toolTip.SetToolTip(this.btnExecute, "AT#EXECSCR");
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// btnStartMode
			// 
			this.btnStartMode.Location = new System.Drawing.Point(208, 504);
			this.btnStartMode.Name = "btnStartMode";
			this.btnStartMode.Size = new System.Drawing.Size(90, 23);
			this.btnStartMode.TabIndex = 19;
			this.btnStartMode.Text = "Start Mode 1,10";
			this.toolTip.SetToolTip(this.btnStartMode, "AT#STARTMODESCR=1,10");
			this.btnStartMode.UseVisualStyleBackColor = true;
			this.btnStartMode.Click += new System.EventHandler(this.btnStartMode_Click);
			// 
			// btnSetActive
			// 
			this.btnSetActive.Location = new System.Drawing.Point(208, 480);
			this.btnSetActive.Name = "btnSetActive";
			this.btnSetActive.Size = new System.Drawing.Size(90, 23);
			this.btnSetActive.TabIndex = 18;
			this.btnSetActive.Text = "F7 -Set Active";
			this.toolTip.SetToolTip(this.btnSetActive, "AT#ESCRIPT");
			this.btnSetActive.UseVisualStyleBackColor = true;
			this.btnSetActive.Click += new System.EventHandler(this.btnSetActive_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(255, 352);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Delete";
			this.toolTip.SetToolTip(this.btnDelete, "AT#DSCRIPT ...");
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(255, 397);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(75, 23);
			this.btnDownload.TabIndex = 16;
			this.btnDownload.Text = "&Download <";
			this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.btnDownload, "AT#RSCRIPT ...");
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnRefreshDevice
			// 
			this.btnRefreshDevice.Location = new System.Drawing.Point(255, 328);
			this.btnRefreshDevice.Name = "btnRefreshDevice";
			this.btnRefreshDevice.Size = new System.Drawing.Size(75, 23);
			this.btnRefreshDevice.TabIndex = 14;
			this.btnRefreshDevice.Text = "Refresh";
			this.toolTip.SetToolTip(this.btnRefreshDevice, "AT#LSCRIPT");
			this.btnRefreshDevice.UseVisualStyleBackColor = true;
			this.btnRefreshDevice.Click += new System.EventHandler(this.btnRefreshDevice_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(174, 397);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(75, 23);
			this.btnUpload.TabIndex = 9;
			this.btnUpload.Text = "F6 - &Upload >";
			this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnUpload, "AT#WSCRIPT ...");
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// lblCompiler
			// 
			this.lblCompiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCompiler.Location = new System.Drawing.Point(4, 583);
			this.lblCompiler.Name = "lblCompiler";
			this.lblCompiler.Size = new System.Drawing.Size(57, 21);
			this.lblCompiler.TabIndex = 31;
			this.lblCompiler.TabStop = true;
			this.lblCompiler.Text = "Compiler";
			this.lblCompiler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblCompiler.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCompiler_LinkClicked);
			// 
			// statusLine
			// 
			this.statusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.progress});
			this.statusLine.Location = new System.Drawing.Point(0, 606);
			this.statusLine.Name = "statusLine";
			this.statusLine.Size = new System.Drawing.Size(937, 28);
			this.statusLine.TabIndex = 31;
			this.statusLine.Text = "statusStrip1";
			// 
			// Status
			// 
			this.Status.AutoSize = false;
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(820, 23);
			this.Status.Spring = true;
			this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// progress
			// 
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(100, 22);
			// 
			// cbHidden
			// 
			this.cbHidden.AutoSize = true;
			this.cbHidden.ForeColor = System.Drawing.SystemColors.Highlight;
			this.cbHidden.Location = new System.Drawing.Point(174, 427);
			this.cbHidden.Name = "cbHidden";
			this.cbHidden.Size = new System.Drawing.Size(60, 17);
			this.cbHidden.TabIndex = 10;
			this.cbHidden.Text = "Hidden";
			this.cbHidden.UseVisualStyleBackColor = true;
			// 
			// Echo
			// 
			this.Echo.AutoSize = true;
			this.Echo.ForeColor = System.Drawing.SystemColors.Highlight;
			this.Echo.Location = new System.Drawing.Point(501, 7);
			this.Echo.Name = "Echo";
			this.Echo.Size = new System.Drawing.Size(51, 17);
			this.Echo.TabIndex = 28;
			this.Echo.Text = "Echo";
			this.Echo.UseVisualStyleBackColor = true;
			// 
			// editor
			// 
			this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.editor.Location = new System.Drawing.Point(294, 584);
			this.editor.Name = "editor";
			this.editor.Size = new System.Drawing.Size(165, 20);
			this.editor.TabIndex = 35;
			this.editor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "exe";
			this.openFileDialog.Filter = "\"Executable|*.exe|All files|*.*\"";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label5.Location = new System.Drawing.Point(8, 305);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(157, 21);
			this.label5.TabIndex = 38;
			this.label5.Text = "F3 - Host Files";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label6.Location = new System.Drawing.Point(336, 306);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(159, 21);
			this.label6.TabIndex = 39;
			this.label6.Text = "Device Files";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WordWrap
			// 
			this.WordWrap.AutoSize = true;
			this.WordWrap.Checked = true;
			this.WordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
			this.WordWrap.ForeColor = System.Drawing.SystemColors.Highlight;
			this.WordWrap.Location = new System.Drawing.Point(558, 7);
			this.WordWrap.Name = "WordWrap";
			this.WordWrap.Size = new System.Drawing.Size(81, 17);
			this.WordWrap.TabIndex = 42;
			this.WordWrap.Text = "Word Wrap";
			this.WordWrap.UseVisualStyleBackColor = true;
			this.WordWrap.CheckedChanged += new System.EventHandler(this.cbWordWrap_CheckedChanged);
			// 
			// btnSelectCompiler
			// 
			this.btnSelectCompiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSelectCompiler.Location = new System.Drawing.Point(197, 582);
			this.btnSelectCompiler.Name = "btnSelectCompiler";
			this.btnSelectCompiler.Size = new System.Drawing.Size(30, 23);
			this.btnSelectCompiler.TabIndex = 33;
			this.btnSelectCompiler.Text = "...";
			this.btnSelectCompiler.UseVisualStyleBackColor = true;
			this.btnSelectCompiler.Click += new System.EventHandler(this.btnSelectCompiler_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(174, 352);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 7;
			this.btnEdit.Text = "F4 - &Edit";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSelectEditor
			// 
			this.btnSelectEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSelectEditor.Location = new System.Drawing.Point(465, 582);
			this.btnSelectEditor.Name = "btnSelectEditor";
			this.btnSelectEditor.Size = new System.Drawing.Size(30, 23);
			this.btnSelectEditor.TabIndex = 36;
			this.btnSelectEditor.Text = "...";
			this.btnSelectEditor.UseVisualStyleBackColor = true;
			this.btnSelectEditor.Click += new System.EventHandler(this.btnSelectEditor_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(208, 531);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(90, 23);
			this.btnExit.TabIndex = 37;
			this.btnExit.Text = "F10 - E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// log
			// 
			this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.log.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.log.Location = new System.Drawing.Point(501, 28);
			this.log.Multiline = true;
			this.log.Name = "log";
			this.log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.log.Size = new System.Drawing.Size(430, 574);
			this.log.TabIndex = 30;
			this.log.Text = "Right mouse click or <Insert> key on button to redefine.\r\n\r\n";
			this.log.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.log_KeyPress);
			// 
			// filesDevice
			// 
			this.filesDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.filesDevice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.filesDevice.ContextMenuStrip = this.filesDeviceCntxMenu;
			this.filesDevice.FullRowSelect = true;
			this.filesDevice.HideSelection = false;
			this.filesDevice.Location = new System.Drawing.Point(336, 328);
			this.filesDevice.MultiSelect = false;
			this.filesDevice.Name = "filesDevice";
			this.filesDevice.Size = new System.Drawing.Size(160, 225);
			this.filesDevice.TabIndex = 13;
			this.filesDevice.UseCompatibleStateImageBehavior = false;
			this.filesDevice.View = System.Windows.Forms.View.Details;
			this.filesDevice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox_KeyUp);
			this.filesDevice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseUp);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 120;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Size";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// filesHost
			// 
			this.filesHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.filesHost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.filesHost.ContextMenuStrip = this.filesHostCntxMenu;
			this.filesHost.FullRowSelect = true;
			listViewGroup1.Header = "Python files";
			listViewGroup1.Name = "leftGroup0";
			listViewGroup1.Tag = ".PY";
			listViewGroup2.Header = "Python compiled";
			listViewGroup2.Name = "leftGroup1";
			listViewGroup2.Tag = ".PYO";
			listViewGroup3.Header = "Other";
			listViewGroup3.Name = "leftGroup2";
			this.filesHost.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
			this.filesHost.HideSelection = false;
			this.filesHost.Location = new System.Drawing.Point(8, 328);
			this.filesHost.Name = "filesHost";
			this.filesHost.Size = new System.Drawing.Size(160, 225);
			this.filesHost.TabIndex = 5;
			this.filesHost.UseCompatibleStateImageBehavior = false;
			this.filesHost.View = System.Windows.Forms.View.Details;
			this.filesHost.DoubleClick += new System.EventHandler(this.files_DoubleClick);
			this.filesHost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox_KeyUp);
			this.filesHost.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseUp);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Name";
			this.columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Size";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCompile
			// 
			this.btnCompile.Location = new System.Drawing.Point(174, 375);
			this.btnCompile.Name = "btnCompile";
			this.btnCompile.Size = new System.Drawing.Size(75, 23);
			this.btnCompile.TabIndex = 8;
			this.btnCompile.Text = "F5 - &Compile";
			this.btnCompile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCompile.UseVisualStyleBackColor = true;
			this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(174, 328);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSelect.Location = new System.Drawing.Point(465, 557);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(30, 23);
			this.btnSelect.TabIndex = 12;
			this.btnSelect.Text = "...";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// XTerminal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 634);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.WordWrap);
			this.Controls.Add(this.Echo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSelectCompiler);
			this.Controls.Add(this.statusLine);
			this.Controls.Add(this.linkEditor);
			this.Controls.Add(this.btnClearLog);
			this.Controls.Add(this.cbHidden);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSelectEditor);
			this.Controls.Add(this.btnExecute);
			this.Controls.Add(this.btnStartMode);
			this.Controls.Add(this.btnSetActive);
			this.Controls.Add(this.editor);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.log);
			this.Controls.Add(this.lblCompiler);
			this.Controls.Add(this.filesDevice);
			this.Controls.Add(this.filesHost);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.btnRefreshDevice);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.btnCompile);
			this.Controls.Add(this.compiler);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.folderSelected);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(780, 669);
			this.Name = "XTerminal";
			this.Text = "Terminal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XTerminal_Closing);
			this.Load += new System.EventHandler(this.XTerminal_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.XTerminal_KeyUp);
			this.filesHostCntxMenu.ResumeLayout(false);
			this.filesDeviceCntxMenu.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GPSIFIX_UPDATE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FTPGETIFIX_SIZE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GPSPS_PTF)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.statusLine.ResumeLayout(false);
			this.statusLine.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbPorts;
		private System.Windows.Forms.ComboBox cbSpeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox FlowProtocol;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox folderSelected;
		private System.Windows.Forms.Label label4;
		private ListViewEx filesHost;
		private System.Windows.Forms.FolderBrowserDialog folderDialog;
		private System.Windows.Forms.TextBox compiler;
		private ListViewEx filesDevice;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private TextBoxEx log;
		private System.Windows.Forms.LinkLabel lblCompiler;
		private System.Windows.Forms.StatusStrip statusLine;
		private System.Windows.Forms.ToolStripStatusLabel Status;
		private System.Windows.Forms.ToolStripProgressBar progress;
		private System.Windows.Forms.CheckBox cbHidden;
		private System.Windows.Forms.CheckBox Echo;
		private System.Windows.Forms.TextBox editor;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private XButton btnSelect;
		private XButton btnRefresh;
		private XButton btnPortsRefresh;
		private XButton btnCompile;
		private XButton btnUpload;
		private XButton btnDownload;
		private XButton btnRefreshDevice;
		private XButton btnDelete;
		private XButton btnOpen;
		private CmdButton btnCmd1;
		private CmdButton btnCmd2;
		private CmdButton btnCmd3;
		private CmdButton btnCmd4;
		private CmdButton btnCmd5;
		private CmdButton btnCmd6;
		private CmdButton btnCmd7;
		private CmdButton btnCmd8;
		private CmdButton btnCmd9;
		private CmdButton btnCmd0;
		private CmdButton btnCmd10;
		private CmdButton btnCmd11;
		private CmdButton btnCmd12;
		private CmdButton btnCmd13;
		private CmdButton btnCmd14;
		private CmdButton btnCmd15;
		private CmdButton btnCmd16;
		private CmdButton btnCmd17;
		private CmdButton btnCmd18;
		private CmdButton btnCmd19;
		private XButton btnClearLog;
		private XButton btnEdit;
		private XButton btnSelectCompiler;
		private XButton btnSelectEditor;
		private XButton btnExecute;
		private XButton btnSetActive;
		private XButton btnStartMode;
		private XButton btnExit;
		private System.Windows.Forms.LinkLabel linkEditor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox DTR;
		private System.Windows.Forms.ContextMenuStrip filesHostCntxMenu;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem coToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mpToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip filesDeviceCntxMenu;
		private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox WordWrap;
		private System.Windows.Forms.CheckBox AutoLSCRIPT;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem setActiveToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ComboBox GPSD;
		private CmdButton btnCmd40;
		private CmdButton btnCmd39;
		private CmdButton btnCmd38;
		private CmdButton btnCmd37;
		private CmdButton btnCmd36;
		private CmdButton btnCmd35;
		private CmdButton btnCmd21;
		private CmdButton btnCmd25;
		private CmdButton btnCmd26;
		private CmdButton btnCmd34;
		private CmdButton btnCmd27;
		private CmdButton btnCmd33;
		private CmdButton btnCmd32;
		private CmdButton btnCmd24;
		private CmdButton btnCmd31;
		private CmdButton btnCmd22;
		private CmdButton btnCmd20;
		private CmdButton btnCmd28;
		private CmdButton btnCmd29;
		private CmdButton btnCmd23;
		private System.Windows.Forms.ComboBox GPSPS;
		private System.Windows.Forms.NumericUpDown GPSPS_PTF;
		private System.Windows.Forms.ComboBox GPSCMODE;
		private System.Windows.Forms.NumericUpDown FTPGETIFIX_SIZE;
		private System.Windows.Forms.TextBox FTPGETIFIX_NAME;
		private CmdButton btnCmd30;
		private System.Windows.Forms.NumericUpDown GPSIFIX_UPDATE;
		private System.Windows.Forms.ComboBox GPSIFIX_SGEE;
		private System.Windows.Forms.ComboBox GPSIFIX_CGEE;
		private System.Windows.Forms.ComboBox GPSIFIX_EN;
		private CmdButton btnCmd41;
		private System.Windows.Forms.CheckBox CRorCRLF;
		private System.Windows.Forms.CheckBox RTS;
		private System.Windows.Forms.TabPage tabPage3;
		private CmdButton btnCmd52;
		private CmdButton btnCmd51;
		private System.Windows.Forms.ComboBox CIBAUD;
		private CmdButton btnCmd50;
		private CmdButton btnCmd61;
		private CmdButton btnCmd60;
		private CmdButton btnCmd59;
		private CmdButton btnCmd58;
		private CmdButton btnCmd57;
		private CmdButton btnCmd56;
		private CmdButton btnCmd55;
		private CmdButton btnCmd54;
		private CmdButton btnCmd53;
		private CmdButton btnCmd63;
		private CmdButton btnCmd62;
		private CmdButton btnCmd71;
		private CmdButton btnCmd70;
		private CmdButton btnCmd69;
		private CmdButton btnCmd68;
		private CmdButton btnCmd67;
		private CmdButton btnCmd66;
		private CmdButton btnCmd65;
		private CmdButton btnCmd64;
	}
}

