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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XTerminal));
			this.cbPorts = new System.Windows.Forms.ComboBox();
			this.cbSpeed = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbProtocol = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.folderSelected = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.filesHost = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.filesHostCntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.compiler = new System.Windows.Forms.TextBox();
			this.filesDevice = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.filesDeviceCntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.setActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.linkEditor = new System.Windows.Forms.LinkLabel();
			this.cbDTR = new System.Windows.Forms.CheckBox();
			this.cbLSCRIPT = new System.Windows.Forms.CheckBox();
			this.btnCmd1 = new TelitTerminal.CmdButton();
			this.btnCmd5 = new TelitTerminal.CmdButton();
			this.btnCmd6 = new TelitTerminal.CmdButton();
			this.btnCmd7 = new TelitTerminal.CmdButton();
			this.btnCmd4 = new TelitTerminal.CmdButton();
			this.btnCmd2 = new TelitTerminal.CmdButton();
			this.btnCmd0 = new TelitTerminal.CmdButton();
			this.btnCmd8 = new TelitTerminal.CmdButton();
			this.btnCmd9 = new TelitTerminal.CmdButton();
			this.btnCmd3 = new TelitTerminal.CmdButton();
			this.btnClearLog = new TelitTerminal.XButton();
			this.btnExecute = new TelitTerminal.XButton();
			this.btnStartMode = new TelitTerminal.XButton();
			this.btnSetActive = new TelitTerminal.XButton();
			this.btnDelete = new TelitTerminal.XButton();
			this.btnDownload = new TelitTerminal.XButton();
			this.btnRefreshDevice = new TelitTerminal.XButton();
			this.btnUpload = new TelitTerminal.XButton();
			this.btnCmd21 = new TelitTerminal.CmdButton();
			this.btnCmd25 = new TelitTerminal.CmdButton();
			this.btnCmd26 = new TelitTerminal.CmdButton();
			this.btnCmd27 = new TelitTerminal.CmdButton();
			this.btnCmd24 = new TelitTerminal.CmdButton();
			this.btnCmd22 = new TelitTerminal.CmdButton();
			this.btnCmd28 = new TelitTerminal.CmdButton();
			this.btnCmd29 = new TelitTerminal.CmdButton();
			this.btnCmd23 = new TelitTerminal.CmdButton();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblCompiler = new System.Windows.Forms.LinkLabel();
			this.statusLine = new System.Windows.Forms.StatusStrip();
			this.Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.progress = new System.Windows.Forms.ToolStripProgressBar();
			this.cbHidden = new System.Windows.Forms.CheckBox();
			this.cbEcho = new System.Windows.Forms.CheckBox();
			this.editor = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbWordWrap = new System.Windows.Forms.CheckBox();
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
			this.btnCmd13 = new TelitTerminal.CmdButton();
			this.btnCmd12 = new TelitTerminal.CmdButton();
			this.btnCmd11 = new TelitTerminal.CmdButton();
			this.btnCmd10 = new TelitTerminal.CmdButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.GPSIFIX_UPDATE = new System.Windows.Forms.NumericUpDown();
			this.GPSIFIX_SGEE = new System.Windows.Forms.ComboBox();
			this.GPSIFIX_CGEE = new System.Windows.Forms.ComboBox();
			this.GPSIFIX_EN = new System.Windows.Forms.ComboBox();
			this.btnCmd30 = new TelitTerminal.CmdButton();
			this.FTPGETIFIX_SIZE = new System.Windows.Forms.NumericUpDown();
			this.FTPGETIFIX_NAME = new System.Windows.Forms.TextBox();
			this.GPSCMODE = new System.Windows.Forms.ComboBox();
			this.GPSPS_PTF = new System.Windows.Forms.NumericUpDown();
			this.GPSPS = new System.Windows.Forms.ComboBox();
			this.GPSD = new System.Windows.Forms.ComboBox();
			this.btnCmd40 = new TelitTerminal.CmdButton();
			this.btnCmd39 = new TelitTerminal.CmdButton();
			this.btnCmd38 = new TelitTerminal.CmdButton();
			this.btnCmd37 = new TelitTerminal.CmdButton();
			this.btnCmd36 = new TelitTerminal.CmdButton();
			this.btnCmd35 = new TelitTerminal.CmdButton();
			this.btnCmd34 = new TelitTerminal.CmdButton();
			this.btnCmd33 = new TelitTerminal.CmdButton();
			this.btnCmd32 = new TelitTerminal.CmdButton();
			this.btnCmd31 = new TelitTerminal.CmdButton();
			this.btnCmd20 = new TelitTerminal.CmdButton();
			this.btnSelectCompiler = new TelitTerminal.XButton();
			this.btnEdit = new TelitTerminal.XButton();
			this.btnSelectEditor = new TelitTerminal.XButton();
			this.btnExit = new TelitTerminal.XButton();
			this.log = new TelitTerminal.TextBoxEx();
			this.btnCompile = new TelitTerminal.XButton();
			this.btnRefresh = new TelitTerminal.XButton();
			this.btnSelect = new TelitTerminal.XButton();
			this.btnCmd41 = new TelitTerminal.CmdButton();
			this.filesHostCntxMenu.SuspendLayout();
			this.filesDeviceCntxMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.statusLine.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GPSIFIX_UPDATE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FTPGETIFIX_SIZE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GPSPS_PTF)).BeginInit();
			this.SuspendLayout();
			// 
			// cbPorts
			// 
			this.cbPorts.FormattingEnabled = true;
			this.cbPorts.Location = new System.Drawing.Point(87, 22);
			this.cbPorts.Margin = new System.Windows.Forms.Padding(4);
			this.cbPorts.Name = "cbPorts";
			this.cbPorts.Size = new System.Drawing.Size(132, 24);
			this.cbPorts.TabIndex = 0;
			// 
			// cbSpeed
			// 
			this.cbSpeed.FormattingEnabled = true;
			this.cbSpeed.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
			this.cbSpeed.Location = new System.Drawing.Point(87, 50);
			this.cbSpeed.Margin = new System.Windows.Forms.Padding(4);
			this.cbSpeed.Name = "cbSpeed";
			this.cbSpeed.Size = new System.Drawing.Size(132, 24);
			this.cbSpeed.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(7, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Port";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(7, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 26);
			this.label2.TabIndex = 3;
			this.label2.Text = "Speed";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbProtocol
			// 
			this.cbProtocol.FormattingEnabled = true;
			this.cbProtocol.Items.AddRange(new object[] {
            "Hardware",
            "None"});
			this.cbProtocol.Location = new System.Drawing.Point(87, 79);
			this.cbProtocol.Margin = new System.Windows.Forms.Padding(4);
			this.cbProtocol.Name = "cbProtocol";
			this.cbProtocol.Size = new System.Drawing.Size(132, 24);
			this.cbProtocol.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label3.Location = new System.Drawing.Point(7, 78);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "Protocol";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// folderSelected
			// 
			this.folderSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.folderSelected.Location = new System.Drawing.Point(89, 688);
			this.folderSelected.Margin = new System.Windows.Forms.Padding(4);
			this.folderSelected.Name = "folderSelected";
			this.folderSelected.Size = new System.Drawing.Size(521, 22);
			this.folderSelected.TabIndex = 11;
			this.folderSelected.Leave += new System.EventHandler(this.folderSelected_Leave);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(5, 687);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 26);
			this.label4.TabIndex = 7;
			this.label4.Text = "Folder";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// filesHost
			// 
			this.filesHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.filesHost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.filesHost.ContextMenuStrip = this.filesHostCntxMenu;
			this.filesHost.Location = new System.Drawing.Point(10, 404);
			this.filesHost.Margin = new System.Windows.Forms.Padding(4);
			this.filesHost.Name = "filesHost";
			this.filesHost.Size = new System.Drawing.Size(212, 276);
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
			// 
			// filesHostCntxMenu
			// 
			this.filesHostCntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.coToolStripMenuItem,
            this.mpToolStripMenuItem});
			this.filesHostCntxMenu.Name = "contextMenuStrip1";
			this.filesHostCntxMenu.Size = new System.Drawing.Size(144, 88);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
			this.editToolStripMenuItem.Text = "&Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// coToolStripMenuItem
			// 
			this.coToolStripMenuItem.Name = "coToolStripMenuItem";
			this.coToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
			this.coToolStripMenuItem.Text = "&Compile";
			this.coToolStripMenuItem.Click += new System.EventHandler(this.btnCompile_Click);
			// 
			// mpToolStripMenuItem
			// 
			this.mpToolStripMenuItem.Name = "mpToolStripMenuItem";
			this.mpToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
			this.mpToolStripMenuItem.Text = "&Upload";
			this.mpToolStripMenuItem.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// folderDialog
			// 
			this.folderDialog.Description = "Select folder";
			this.folderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// compiler
			// 
			this.compiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.compiler.Location = new System.Drawing.Point(89, 719);
			this.compiler.Margin = new System.Windows.Forms.Padding(4);
			this.compiler.Name = "compiler";
			this.compiler.Size = new System.Drawing.Size(164, 22);
			this.compiler.TabIndex = 32;
			this.compiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// filesDevice
			// 
			this.filesDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.filesDevice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.filesDevice.ContextMenuStrip = this.filesDeviceCntxMenu;
			this.filesDevice.Location = new System.Drawing.Point(448, 404);
			this.filesDevice.Margin = new System.Windows.Forms.Padding(4);
			this.filesDevice.MultiSelect = false;
			this.filesDevice.Name = "filesDevice";
			this.filesDevice.Size = new System.Drawing.Size(212, 276);
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
			// 
			// filesDeviceCntxMenu
			// 
			this.filesDeviceCntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setActiveToolStripMenuItem});
			this.filesDeviceCntxMenu.Name = "filesDeviceCntxMenu";
			this.filesDeviceCntxMenu.Size = new System.Drawing.Size(158, 94);
			// 
			// downloadToolStripMenuItem
			// 
			this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
			this.downloadToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
			this.downloadToolStripMenuItem.Text = "&Download";
			this.downloadToolStripMenuItem.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
			// 
			// setActiveToolStripMenuItem
			// 
			this.setActiveToolStripMenuItem.Name = "setActiveToolStripMenuItem";
			this.setActiveToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
			this.setActiveToolStripMenuItem.Text = "Set Active";
			this.setActiveToolStripMenuItem.Click += new System.EventHandler(this.btnSetActive_Click);
			// 
			// linkEditor
			// 
			this.linkEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkEditor.Location = new System.Drawing.Point(311, 719);
			this.linkEditor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkEditor.Name = "linkEditor";
			this.linkEditor.Size = new System.Drawing.Size(73, 26);
			this.linkEditor.TabIndex = 34;
			this.linkEditor.TabStop = true;
			this.linkEditor.Tag = "";
			this.linkEditor.Text = "Editor";
			this.linkEditor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.linkEditor, "http://www.pnotepad.org/");
			this.linkEditor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditor_LinkClicked);
			// 
			// cbDTR
			// 
			this.cbDTR.AutoSize = true;
			this.cbDTR.Checked = true;
			this.cbDTR.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbDTR.ForeColor = System.Drawing.SystemColors.Highlight;
			this.cbDTR.Location = new System.Drawing.Point(87, 112);
			this.cbDTR.Margin = new System.Windows.Forms.Padding(4);
			this.cbDTR.Name = "cbDTR";
			this.cbDTR.Size = new System.Drawing.Size(107, 21);
			this.cbDTR.TabIndex = 40;
			this.cbDTR.Text = "DTR Enable";
			this.toolTip.SetToolTip(this.cbDTR, "Checked means DTR set to ON");
			this.cbDTR.UseVisualStyleBackColor = true;
			// 
			// cbLSCRIPT
			// 
			this.cbLSCRIPT.AutoSize = true;
			this.cbLSCRIPT.Checked = true;
			this.cbLSCRIPT.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbLSCRIPT.ForeColor = System.Drawing.SystemColors.Highlight;
			this.cbLSCRIPT.Location = new System.Drawing.Point(87, 132);
			this.cbLSCRIPT.Margin = new System.Windows.Forms.Padding(4);
			this.cbLSCRIPT.Name = "cbLSCRIPT";
			this.cbLSCRIPT.Size = new System.Drawing.Size(120, 21);
			this.cbLSCRIPT.TabIndex = 46;
			this.cbLSCRIPT.Text = "Auto LSCRIPT";
			this.toolTip.SetToolTip(this.cbLSCRIPT, "Make LSCRIPT on connect");
			this.cbLSCRIPT.UseVisualStyleBackColor = true;
			// 
			// btnCmd1
			// 
			this.btnCmd1.AutoEllipsis = true;
			this.btnCmd1.Command = null;
			this.btnCmd1.Location = new System.Drawing.Point(364, 66);
			this.btnCmd1.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd1.Name = "btnCmd1";
			this.btnCmd1.Size = new System.Drawing.Size(133, 28);
			this.btnCmd1.TabIndex = 21;
			this.btnCmd1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd1, "Alt+1 to execute, INS or Right Mouse Button to define");
			this.btnCmd1.UseVisualStyleBackColor = true;
			// 
			// btnCmd5
			// 
			this.btnCmd5.AutoEllipsis = true;
			this.btnCmd5.Command = null;
			this.btnCmd5.Location = new System.Drawing.Point(364, 178);
			this.btnCmd5.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd5.Name = "btnCmd5";
			this.btnCmd5.Size = new System.Drawing.Size(133, 28);
			this.btnCmd5.TabIndex = 25;
			this.btnCmd5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd5, "Alt+5 to execute, INS or Right Mouse Button to define");
			this.btnCmd5.UseVisualStyleBackColor = true;
			// 
			// btnCmd6
			// 
			this.btnCmd6.AutoEllipsis = true;
			this.btnCmd6.Command = null;
			this.btnCmd6.Location = new System.Drawing.Point(364, 206);
			this.btnCmd6.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd6.Name = "btnCmd6";
			this.btnCmd6.Size = new System.Drawing.Size(133, 28);
			this.btnCmd6.TabIndex = 26;
			this.btnCmd6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd6, "Alt+6 to execute, INS or Right Mouse Button to define");
			this.btnCmd6.UseVisualStyleBackColor = true;
			// 
			// btnCmd7
			// 
			this.btnCmd7.AutoEllipsis = true;
			this.btnCmd7.Command = null;
			this.btnCmd7.Location = new System.Drawing.Point(364, 234);
			this.btnCmd7.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd7.Name = "btnCmd7";
			this.btnCmd7.Size = new System.Drawing.Size(133, 28);
			this.btnCmd7.TabIndex = 27;
			this.btnCmd7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd7, "Alt+7 to execute, INS or Right Mouse Button to define");
			this.btnCmd7.UseVisualStyleBackColor = true;
			// 
			// btnCmd4
			// 
			this.btnCmd4.AutoEllipsis = true;
			this.btnCmd4.Command = null;
			this.btnCmd4.Location = new System.Drawing.Point(364, 150);
			this.btnCmd4.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd4.Name = "btnCmd4";
			this.btnCmd4.Size = new System.Drawing.Size(133, 28);
			this.btnCmd4.TabIndex = 24;
			this.btnCmd4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd4, "Alt+4 to execute, INS or Right Mouse Button to define");
			this.btnCmd4.UseVisualStyleBackColor = true;
			// 
			// btnCmd2
			// 
			this.btnCmd2.AutoEllipsis = true;
			this.btnCmd2.Command = null;
			this.btnCmd2.Location = new System.Drawing.Point(364, 94);
			this.btnCmd2.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd2.Name = "btnCmd2";
			this.btnCmd2.Size = new System.Drawing.Size(133, 28);
			this.btnCmd2.TabIndex = 22;
			this.btnCmd2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd2, "Alt+2 to execute, INS or Right Mouse Button to define");
			this.btnCmd2.UseVisualStyleBackColor = true;
			// 
			// btnCmd0
			// 
			this.btnCmd0.AutoEllipsis = true;
			this.btnCmd0.Command = null;
			this.btnCmd0.Location = new System.Drawing.Point(364, 38);
			this.btnCmd0.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd0.Name = "btnCmd0";
			this.btnCmd0.Size = new System.Drawing.Size(133, 28);
			this.btnCmd0.TabIndex = 20;
			this.btnCmd0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd0, "Alt+0 to execute, INS or Right Mouse Button to define");
			this.btnCmd0.UseVisualStyleBackColor = true;
			// 
			// btnCmd8
			// 
			this.btnCmd8.AutoEllipsis = true;
			this.btnCmd8.Command = null;
			this.btnCmd8.Location = new System.Drawing.Point(364, 262);
			this.btnCmd8.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd8.Name = "btnCmd8";
			this.btnCmd8.Size = new System.Drawing.Size(133, 28);
			this.btnCmd8.TabIndex = 28;
			this.btnCmd8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd8, "Alt+8 to execute, INS or Right Mouse Button to define");
			this.btnCmd8.UseVisualStyleBackColor = true;
			// 
			// btnCmd9
			// 
			this.btnCmd9.AutoEllipsis = true;
			this.btnCmd9.Command = null;
			this.btnCmd9.Location = new System.Drawing.Point(364, 290);
			this.btnCmd9.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd9.Name = "btnCmd9";
			this.btnCmd9.Size = new System.Drawing.Size(133, 28);
			this.btnCmd9.TabIndex = 29;
			this.btnCmd9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd9, "Alt+9 to execute, INS or Right Mouse Button to define");
			this.btnCmd9.UseVisualStyleBackColor = true;
			// 
			// btnCmd3
			// 
			this.btnCmd3.AutoEllipsis = true;
			this.btnCmd3.Command = null;
			this.btnCmd3.Location = new System.Drawing.Point(364, 122);
			this.btnCmd3.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd3.Name = "btnCmd3";
			this.btnCmd3.Size = new System.Drawing.Size(133, 28);
			this.btnCmd3.TabIndex = 23;
			this.btnCmd3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnCmd3, "Alt+3 to execute, INS or Right Mouse Button to define");
			this.btnCmd3.UseVisualStyleBackColor = true;
			// 
			// btnClearLog
			// 
			this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearLog.Location = new System.Drawing.Point(1141, 5);
			this.btnClearLog.Margin = new System.Windows.Forms.Padding(4);
			this.btnClearLog.Name = "btnClearLog";
			this.btnClearLog.Size = new System.Drawing.Size(100, 28);
			this.btnClearLog.TabIndex = 29;
			this.btnClearLog.Text = "Clear &Log";
			this.toolTip.SetToolTip(this.btnClearLog, "AT#LSCRIPT");
			this.btnClearLog.UseVisualStyleBackColor = true;
			this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(277, 563);
			this.btnExecute.Margin = new System.Windows.Forms.Padding(4);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(120, 28);
			this.btnExecute.TabIndex = 17;
			this.btnExecute.Text = "F8 - Execute";
			this.toolTip.SetToolTip(this.btnExecute, "AT#EXECSCR");
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// btnStartMode
			// 
			this.btnStartMode.Location = new System.Drawing.Point(277, 620);
			this.btnStartMode.Margin = new System.Windows.Forms.Padding(4);
			this.btnStartMode.Name = "btnStartMode";
			this.btnStartMode.Size = new System.Drawing.Size(120, 28);
			this.btnStartMode.TabIndex = 19;
			this.btnStartMode.Text = "Start Mode 1,10";
			this.toolTip.SetToolTip(this.btnStartMode, "AT#STARTMODESCR=1,10");
			this.btnStartMode.UseVisualStyleBackColor = true;
			this.btnStartMode.Click += new System.EventHandler(this.btnStartMode_Click);
			// 
			// btnSetActive
			// 
			this.btnSetActive.Location = new System.Drawing.Point(277, 591);
			this.btnSetActive.Margin = new System.Windows.Forms.Padding(4);
			this.btnSetActive.Name = "btnSetActive";
			this.btnSetActive.Size = new System.Drawing.Size(120, 28);
			this.btnSetActive.TabIndex = 18;
			this.btnSetActive.Text = "F7 -Set Active";
			this.toolTip.SetToolTip(this.btnSetActive, "AT#ESCRIPT");
			this.btnSetActive.UseVisualStyleBackColor = true;
			this.btnSetActive.Click += new System.EventHandler(this.btnSetActive_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(340, 433);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 28);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Delete";
			this.toolTip.SetToolTip(this.btnDelete, "AT#DSCRIPT ...");
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(340, 489);
			this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(100, 28);
			this.btnDownload.TabIndex = 16;
			this.btnDownload.Text = "&Download <";
			this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTip.SetToolTip(this.btnDownload, "AT#RSCRIPT ...");
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnRefreshDevice
			// 
			this.btnRefreshDevice.Location = new System.Drawing.Point(340, 404);
			this.btnRefreshDevice.Margin = new System.Windows.Forms.Padding(4);
			this.btnRefreshDevice.Name = "btnRefreshDevice";
			this.btnRefreshDevice.Size = new System.Drawing.Size(100, 28);
			this.btnRefreshDevice.TabIndex = 14;
			this.btnRefreshDevice.Text = "Refresh";
			this.toolTip.SetToolTip(this.btnRefreshDevice, "AT#LSCRIPT");
			this.btnRefreshDevice.UseVisualStyleBackColor = true;
			this.btnRefreshDevice.Click += new System.EventHandler(this.btnRefreshDevice_Click);
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(232, 489);
			this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(100, 28);
			this.btnUpload.TabIndex = 9;
			this.btnUpload.Text = "F6 - &Upload >";
			this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip.SetToolTip(this.btnUpload, "AT#WSCRIPT ...");
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// btnCmd21
			// 
			this.btnCmd21.AutoEllipsis = true;
			this.btnCmd21.Command = null;
			this.btnCmd21.Location = new System.Drawing.Point(7, 35);
			this.btnCmd21.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd21.Name = "btnCmd21";
			this.btnCmd21.Size = new System.Drawing.Size(160, 28);
			this.btnCmd21.TabIndex = 54;
			this.btnCmd21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd21.UseVisualStyleBackColor = true;
			// 
			// btnCmd25
			// 
			this.btnCmd25.AutoEllipsis = true;
			this.btnCmd25.Command = null;
			this.btnCmd25.Location = new System.Drawing.Point(7, 147);
			this.btnCmd25.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd25.Name = "btnCmd25";
			this.btnCmd25.Size = new System.Drawing.Size(160, 28);
			this.btnCmd25.TabIndex = 58;
			this.btnCmd25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd25.UseVisualStyleBackColor = true;
			// 
			// btnCmd26
			// 
			this.btnCmd26.AutoEllipsis = true;
			this.btnCmd26.Command = null;
			this.btnCmd26.Location = new System.Drawing.Point(7, 175);
			this.btnCmd26.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd26.Name = "btnCmd26";
			this.btnCmd26.Size = new System.Drawing.Size(160, 28);
			this.btnCmd26.TabIndex = 59;
			this.btnCmd26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd26.UseVisualStyleBackColor = true;
			// 
			// btnCmd27
			// 
			this.btnCmd27.AutoEllipsis = true;
			this.btnCmd27.Command = null;
			this.btnCmd27.Location = new System.Drawing.Point(7, 203);
			this.btnCmd27.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd27.Name = "btnCmd27";
			this.btnCmd27.Size = new System.Drawing.Size(160, 28);
			this.btnCmd27.TabIndex = 60;
			this.btnCmd27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd27.UseVisualStyleBackColor = true;
			// 
			// btnCmd24
			// 
			this.btnCmd24.AutoEllipsis = true;
			this.btnCmd24.Command = null;
			this.btnCmd24.Location = new System.Drawing.Point(7, 119);
			this.btnCmd24.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd24.Name = "btnCmd24";
			this.btnCmd24.Size = new System.Drawing.Size(160, 28);
			this.btnCmd24.TabIndex = 57;
			this.btnCmd24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd24.UseVisualStyleBackColor = true;
			// 
			// btnCmd22
			// 
			this.btnCmd22.AutoEllipsis = true;
			this.btnCmd22.Command = null;
			this.btnCmd22.Location = new System.Drawing.Point(7, 63);
			this.btnCmd22.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd22.Name = "btnCmd22";
			this.btnCmd22.Size = new System.Drawing.Size(160, 28);
			this.btnCmd22.TabIndex = 55;
			this.btnCmd22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd22.UseVisualStyleBackColor = true;
			// 
			// btnCmd28
			// 
			this.btnCmd28.AutoEllipsis = true;
			this.btnCmd28.Command = null;
			this.btnCmd28.Location = new System.Drawing.Point(7, 231);
			this.btnCmd28.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd28.Name = "btnCmd28";
			this.btnCmd28.Size = new System.Drawing.Size(160, 28);
			this.btnCmd28.TabIndex = 61;
			this.btnCmd28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd28.UseVisualStyleBackColor = true;
			// 
			// btnCmd29
			// 
			this.btnCmd29.AutoEllipsis = true;
			this.btnCmd29.Command = null;
			this.btnCmd29.Location = new System.Drawing.Point(7, 259);
			this.btnCmd29.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd29.Name = "btnCmd29";
			this.btnCmd29.Size = new System.Drawing.Size(160, 28);
			this.btnCmd29.TabIndex = 62;
			this.btnCmd29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd29.UseVisualStyleBackColor = true;
			// 
			// btnCmd23
			// 
			this.btnCmd23.AutoEllipsis = true;
			this.btnCmd23.Command = null;
			this.btnCmd23.Location = new System.Drawing.Point(7, 91);
			this.btnCmd23.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd23.Name = "btnCmd23";
			this.btnCmd23.Size = new System.Drawing.Size(160, 28);
			this.btnCmd23.TabIndex = 56;
			this.btnCmd23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd23.UseVisualStyleBackColor = true;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// lblCompiler
			// 
			this.lblCompiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCompiler.Location = new System.Drawing.Point(5, 718);
			this.lblCompiler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCompiler.Name = "lblCompiler";
			this.lblCompiler.Size = new System.Drawing.Size(76, 26);
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
			this.statusLine.Location = new System.Drawing.Point(0, 752);
			this.statusLine.Name = "statusLine";
			this.statusLine.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusLine.Size = new System.Drawing.Size(1249, 28);
			this.statusLine.TabIndex = 31;
			this.statusLine.Text = "statusStrip1";
			// 
			// Status
			// 
			this.Status.AutoSize = false;
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(1094, 23);
			this.Status.Spring = true;
			this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// progress
			// 
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(133, 22);
			// 
			// cbHidden
			// 
			this.cbHidden.AutoSize = true;
			this.cbHidden.ForeColor = System.Drawing.SystemColors.Highlight;
			this.cbHidden.Location = new System.Drawing.Point(232, 525);
			this.cbHidden.Margin = new System.Windows.Forms.Padding(4);
			this.cbHidden.Name = "cbHidden";
			this.cbHidden.Size = new System.Drawing.Size(75, 21);
			this.cbHidden.TabIndex = 10;
			this.cbHidden.Text = "Hidden";
			this.cbHidden.UseVisualStyleBackColor = true;
			// 
			// cbEcho
			// 
			this.cbEcho.AutoSize = true;
			this.cbEcho.ForeColor = System.Drawing.SystemColors.Highlight;
			this.cbEcho.Location = new System.Drawing.Point(668, 9);
			this.cbEcho.Margin = new System.Windows.Forms.Padding(4);
			this.cbEcho.Name = "cbEcho";
			this.cbEcho.Size = new System.Drawing.Size(62, 21);
			this.cbEcho.TabIndex = 28;
			this.cbEcho.Text = "Echo";
			this.cbEcho.UseVisualStyleBackColor = true;
			// 
			// editor
			// 
			this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.editor.Location = new System.Drawing.Point(392, 719);
			this.editor.Margin = new System.Windows.Forms.Padding(4);
			this.editor.Name = "editor";
			this.editor.Size = new System.Drawing.Size(219, 22);
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
			this.label5.Location = new System.Drawing.Point(10, 375);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(209, 26);
			this.label5.TabIndex = 38;
			this.label5.Text = "F3 - Host Files";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label6.Location = new System.Drawing.Point(448, 376);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(212, 26);
			this.label6.TabIndex = 39;
			this.label6.Text = "Device Files";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label7.Location = new System.Drawing.Point(364, 8);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 26);
			this.label7.TabIndex = 41;
			this.label7.Text = "Alt+Number";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbWordWrap
			// 
			this.cbWordWrap.AutoSize = true;
			this.cbWordWrap.Checked = true;
			this.cbWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbWordWrap.ForeColor = System.Drawing.SystemColors.Highlight;
			this.cbWordWrap.Location = new System.Drawing.Point(744, 9);
			this.cbWordWrap.Margin = new System.Windows.Forms.Padding(4);
			this.cbWordWrap.Name = "cbWordWrap";
			this.cbWordWrap.Size = new System.Drawing.Size(102, 21);
			this.cbWordWrap.TabIndex = 42;
			this.cbWordWrap.Text = "Word Wrap";
			this.cbWordWrap.UseVisualStyleBackColor = true;
			this.cbWordWrap.CheckedChanged += new System.EventHandler(this.cbWordWrap_CheckedChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(652, 361);
			this.tabControl1.TabIndex = 53;
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
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(644, 332);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbPorts);
			this.groupBox1.Controls.Add(this.cbDTR);
			this.groupBox1.Controls.Add(this.btnOpen);
			this.groupBox1.Controls.Add(this.cbSpeed);
			this.groupBox1.Controls.Add(this.cbLSCRIPT);
			this.groupBox1.Controls.Add(this.btnPortsRefresh);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbProtocol);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.groupBox1.Location = new System.Drawing.Point(6, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(351, 170);
			this.groupBox1.TabIndex = 53;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Port Settings";
			// 
			// btnOpen
			// 
			this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnOpen.Location = new System.Drawing.Point(229, 76);
			this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(100, 28);
			this.btnOpen.TabIndex = 4;
			this.btnOpen.Text = "F2 - &Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnPortsRefresh
			// 
			this.btnPortsRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPortsRefresh.Location = new System.Drawing.Point(229, 21);
			this.btnPortsRefresh.Margin = new System.Windows.Forms.Padding(4);
			this.btnPortsRefresh.Name = "btnPortsRefresh";
			this.btnPortsRefresh.Size = new System.Drawing.Size(100, 28);
			this.btnPortsRefresh.TabIndex = 1;
			this.btnPortsRefresh.Text = "&Refresh";
			this.btnPortsRefresh.UseVisualStyleBackColor = true;
			this.btnPortsRefresh.Click += new System.EventHandler(this.btnPortsRefresh_Click);
			// 
			// btnCmd19
			// 
			this.btnCmd19.AutoEllipsis = true;
			this.btnCmd19.Command = null;
			this.btnCmd19.Location = new System.Drawing.Point(506, 290);
			this.btnCmd19.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd19.Name = "btnCmd19";
			this.btnCmd19.Size = new System.Drawing.Size(133, 28);
			this.btnCmd19.TabIndex = 52;
			this.btnCmd19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd19.UseVisualStyleBackColor = true;
			// 
			// btnCmd18
			// 
			this.btnCmd18.AutoEllipsis = true;
			this.btnCmd18.Command = null;
			this.btnCmd18.Location = new System.Drawing.Point(506, 262);
			this.btnCmd18.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd18.Name = "btnCmd18";
			this.btnCmd18.Size = new System.Drawing.Size(133, 28);
			this.btnCmd18.TabIndex = 51;
			this.btnCmd18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd18.UseVisualStyleBackColor = true;
			// 
			// btnCmd17
			// 
			this.btnCmd17.AutoEllipsis = true;
			this.btnCmd17.Command = null;
			this.btnCmd17.Location = new System.Drawing.Point(506, 234);
			this.btnCmd17.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd17.Name = "btnCmd17";
			this.btnCmd17.Size = new System.Drawing.Size(133, 28);
			this.btnCmd17.TabIndex = 50;
			this.btnCmd17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd17.UseVisualStyleBackColor = true;
			// 
			// btnCmd16
			// 
			this.btnCmd16.AutoEllipsis = true;
			this.btnCmd16.Command = null;
			this.btnCmd16.Location = new System.Drawing.Point(506, 206);
			this.btnCmd16.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd16.Name = "btnCmd16";
			this.btnCmd16.Size = new System.Drawing.Size(133, 28);
			this.btnCmd16.TabIndex = 49;
			this.btnCmd16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd16.UseVisualStyleBackColor = true;
			// 
			// btnCmd15
			// 
			this.btnCmd15.AutoEllipsis = true;
			this.btnCmd15.Command = null;
			this.btnCmd15.Location = new System.Drawing.Point(506, 178);
			this.btnCmd15.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd15.Name = "btnCmd15";
			this.btnCmd15.Size = new System.Drawing.Size(133, 28);
			this.btnCmd15.TabIndex = 48;
			this.btnCmd15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd15.UseVisualStyleBackColor = true;
			// 
			// btnCmd14
			// 
			this.btnCmd14.AutoEllipsis = true;
			this.btnCmd14.Command = null;
			this.btnCmd14.Location = new System.Drawing.Point(506, 150);
			this.btnCmd14.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd14.Name = "btnCmd14";
			this.btnCmd14.Size = new System.Drawing.Size(133, 28);
			this.btnCmd14.TabIndex = 47;
			this.btnCmd14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd14.UseVisualStyleBackColor = true;
			// 
			// btnCmd13
			// 
			this.btnCmd13.AutoEllipsis = true;
			this.btnCmd13.Command = null;
			this.btnCmd13.Location = new System.Drawing.Point(506, 122);
			this.btnCmd13.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd13.Name = "btnCmd13";
			this.btnCmd13.Size = new System.Drawing.Size(133, 28);
			this.btnCmd13.TabIndex = 33;
			this.btnCmd13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd13.UseVisualStyleBackColor = true;
			// 
			// btnCmd12
			// 
			this.btnCmd12.AutoEllipsis = true;
			this.btnCmd12.Command = null;
			this.btnCmd12.Location = new System.Drawing.Point(506, 94);
			this.btnCmd12.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd12.Name = "btnCmd12";
			this.btnCmd12.Size = new System.Drawing.Size(133, 28);
			this.btnCmd12.TabIndex = 32;
			this.btnCmd12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd12.UseVisualStyleBackColor = true;
			// 
			// btnCmd11
			// 
			this.btnCmd11.AutoEllipsis = true;
			this.btnCmd11.Command = null;
			this.btnCmd11.Location = new System.Drawing.Point(506, 66);
			this.btnCmd11.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd11.Name = "btnCmd11";
			this.btnCmd11.Size = new System.Drawing.Size(133, 28);
			this.btnCmd11.TabIndex = 31;
			this.btnCmd11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd11.UseVisualStyleBackColor = true;
			// 
			// btnCmd10
			// 
			this.btnCmd10.AutoEllipsis = true;
			this.btnCmd10.Command = null;
			this.btnCmd10.Location = new System.Drawing.Point(506, 38);
			this.btnCmd10.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd10.Name = "btnCmd10";
			this.btnCmd10.Size = new System.Drawing.Size(133, 28);
			this.btnCmd10.TabIndex = 30;
			this.btnCmd10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd10.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnCmd41);
			this.tabPage2.Controls.Add(this.GPSIFIX_UPDATE);
			this.tabPage2.Controls.Add(this.GPSIFIX_SGEE);
			this.tabPage2.Controls.Add(this.GPSIFIX_CGEE);
			this.tabPage2.Controls.Add(this.GPSIFIX_EN);
			this.tabPage2.Controls.Add(this.btnCmd30);
			this.tabPage2.Controls.Add(this.FTPGETIFIX_SIZE);
			this.tabPage2.Controls.Add(this.FTPGETIFIX_NAME);
			this.tabPage2.Controls.Add(this.GPSCMODE);
			this.tabPage2.Controls.Add(this.GPSPS_PTF);
			this.tabPage2.Controls.Add(this.GPSPS);
			this.tabPage2.Controls.Add(this.GPSD);
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
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(644, 332);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "GPS";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// GPSIFIX_UPDATE
			// 
			this.GPSIFIX_UPDATE.Location = new System.Drawing.Point(315, 291);
			this.GPSIFIX_UPDATE.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
			this.GPSIFIX_UPDATE.Name = "GPSIFIX_UPDATE";
			this.GPSIFIX_UPDATE.Size = new System.Drawing.Size(50, 22);
			this.GPSIFIX_UPDATE.TabIndex = 83;
			this.GPSIFIX_UPDATE.ValueChanged += new System.EventHandler(this.GPSIFIX_EN_SelectedIndexChanged);
			// 
			// GPSIFIX_SGEE
			// 
			this.GPSIFIX_SGEE.FormattingEnabled = true;
			this.GPSIFIX_SGEE.Items.AddRange(new object[] {
            "0",
            "1"});
			this.GPSIFIX_SGEE.Location = new System.Drawing.Point(268, 290);
			this.GPSIFIX_SGEE.Name = "GPSIFIX_SGEE";
			this.GPSIFIX_SGEE.Size = new System.Drawing.Size(41, 24);
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
			this.GPSIFIX_CGEE.Location = new System.Drawing.Point(221, 290);
			this.GPSIFIX_CGEE.Name = "GPSIFIX_CGEE";
			this.GPSIFIX_CGEE.Size = new System.Drawing.Size(41, 24);
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
			this.GPSIFIX_EN.Location = new System.Drawing.Point(174, 290);
			this.GPSIFIX_EN.Name = "GPSIFIX_EN";
			this.GPSIFIX_EN.Size = new System.Drawing.Size(41, 24);
			this.GPSIFIX_EN.TabIndex = 80;
			this.GPSIFIX_EN.Text = "0";
			this.GPSIFIX_EN.SelectedIndexChanged += new System.EventHandler(this.GPSIFIX_EN_SelectedIndexChanged);
			// 
			// btnCmd30
			// 
			this.btnCmd30.AutoEllipsis = true;
			this.btnCmd30.Command = null;
			this.btnCmd30.Location = new System.Drawing.Point(7, 287);
			this.btnCmd30.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd30.Name = "btnCmd30";
			this.btnCmd30.Size = new System.Drawing.Size(160, 28);
			this.btnCmd30.TabIndex = 79;
			this.btnCmd30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd30.UseVisualStyleBackColor = true;
			// 
			// FTPGETIFIX_SIZE
			// 
			this.FTPGETIFIX_SIZE.Location = new System.Drawing.Point(241, 263);
			this.FTPGETIFIX_SIZE.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.FTPGETIFIX_SIZE.Name = "FTPGETIFIX_SIZE";
			this.FTPGETIFIX_SIZE.Size = new System.Drawing.Size(50, 22);
			this.FTPGETIFIX_SIZE.TabIndex = 78;
			this.FTPGETIFIX_SIZE.ValueChanged += new System.EventHandler(this.FTPGETIFIX_NAME_TextChanged);
			// 
			// FTPGETIFIX_NAME
			// 
			this.FTPGETIFIX_NAME.Location = new System.Drawing.Point(174, 234);
			this.FTPGETIFIX_NAME.Name = "FTPGETIFIX_NAME";
			this.FTPGETIFIX_NAME.Size = new System.Drawing.Size(117, 22);
			this.FTPGETIFIX_NAME.TabIndex = 77;
			this.FTPGETIFIX_NAME.TextChanged += new System.EventHandler(this.FTPGETIFIX_NAME_TextChanged);
			// 
			// GPSCMODE
			// 
			this.GPSCMODE.FormattingEnabled = true;
			this.GPSCMODE.Items.AddRange(new object[] {
            "0",
            "1"});
			this.GPSCMODE.Location = new System.Drawing.Point(539, 178);
			this.GPSCMODE.Name = "GPSCMODE";
			this.GPSCMODE.Size = new System.Drawing.Size(41, 24);
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
			this.GPSPS_PTF.Location = new System.Drawing.Point(221, 123);
			this.GPSPS_PTF.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
			this.GPSPS_PTF.Name = "GPSPS_PTF";
			this.GPSPS_PTF.Size = new System.Drawing.Size(70, 22);
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
			this.GPSPS.Location = new System.Drawing.Point(174, 122);
			this.GPSPS.Name = "GPSPS";
			this.GPSPS.Size = new System.Drawing.Size(41, 24);
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
			this.GPSD.Location = new System.Drawing.Point(174, 10);
			this.GPSD.Name = "GPSD";
			this.GPSD.Size = new System.Drawing.Size(41, 24);
			this.GPSD.TabIndex = 73;
			this.GPSD.Text = "0";
			this.GPSD.SelectedIndexChanged += new System.EventHandler(this.GPSD_SelectedIndexChanged);
			// 
			// btnCmd40
			// 
			this.btnCmd40.AutoEllipsis = true;
			this.btnCmd40.Command = null;
			this.btnCmd40.Location = new System.Drawing.Point(372, 259);
			this.btnCmd40.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd40.Name = "btnCmd40";
			this.btnCmd40.Size = new System.Drawing.Size(160, 28);
			this.btnCmd40.TabIndex = 72;
			this.btnCmd40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd40.UseVisualStyleBackColor = true;
			// 
			// btnCmd39
			// 
			this.btnCmd39.AutoEllipsis = true;
			this.btnCmd39.Command = null;
			this.btnCmd39.Location = new System.Drawing.Point(372, 231);
			this.btnCmd39.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd39.Name = "btnCmd39";
			this.btnCmd39.Size = new System.Drawing.Size(160, 28);
			this.btnCmd39.TabIndex = 71;
			this.btnCmd39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd39.UseVisualStyleBackColor = true;
			// 
			// btnCmd38
			// 
			this.btnCmd38.AutoEllipsis = true;
			this.btnCmd38.Command = null;
			this.btnCmd38.Location = new System.Drawing.Point(372, 203);
			this.btnCmd38.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd38.Name = "btnCmd38";
			this.btnCmd38.Size = new System.Drawing.Size(160, 28);
			this.btnCmd38.TabIndex = 70;
			this.btnCmd38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd38.UseVisualStyleBackColor = true;
			// 
			// btnCmd37
			// 
			this.btnCmd37.AutoEllipsis = true;
			this.btnCmd37.Command = null;
			this.btnCmd37.Location = new System.Drawing.Point(372, 175);
			this.btnCmd37.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd37.Name = "btnCmd37";
			this.btnCmd37.Size = new System.Drawing.Size(160, 28);
			this.btnCmd37.TabIndex = 69;
			this.btnCmd37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd37.UseVisualStyleBackColor = true;
			// 
			// btnCmd36
			// 
			this.btnCmd36.AutoEllipsis = true;
			this.btnCmd36.Command = null;
			this.btnCmd36.Location = new System.Drawing.Point(372, 147);
			this.btnCmd36.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd36.Name = "btnCmd36";
			this.btnCmd36.Size = new System.Drawing.Size(160, 28);
			this.btnCmd36.TabIndex = 68;
			this.btnCmd36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd36.UseVisualStyleBackColor = true;
			// 
			// btnCmd35
			// 
			this.btnCmd35.AutoEllipsis = true;
			this.btnCmd35.Command = null;
			this.btnCmd35.Location = new System.Drawing.Point(372, 119);
			this.btnCmd35.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd35.Name = "btnCmd35";
			this.btnCmd35.Size = new System.Drawing.Size(160, 28);
			this.btnCmd35.TabIndex = 67;
			this.btnCmd35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd35.UseVisualStyleBackColor = true;
			// 
			// btnCmd34
			// 
			this.btnCmd34.AutoEllipsis = true;
			this.btnCmd34.Command = null;
			this.btnCmd34.Location = new System.Drawing.Point(372, 91);
			this.btnCmd34.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd34.Name = "btnCmd34";
			this.btnCmd34.Size = new System.Drawing.Size(160, 28);
			this.btnCmd34.TabIndex = 66;
			this.btnCmd34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd34.UseVisualStyleBackColor = true;
			// 
			// btnCmd33
			// 
			this.btnCmd33.AutoEllipsis = true;
			this.btnCmd33.Command = null;
			this.btnCmd33.Location = new System.Drawing.Point(372, 63);
			this.btnCmd33.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd33.Name = "btnCmd33";
			this.btnCmd33.Size = new System.Drawing.Size(160, 28);
			this.btnCmd33.TabIndex = 65;
			this.btnCmd33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd33.UseVisualStyleBackColor = true;
			// 
			// btnCmd32
			// 
			this.btnCmd32.AutoEllipsis = true;
			this.btnCmd32.Command = null;
			this.btnCmd32.Location = new System.Drawing.Point(372, 35);
			this.btnCmd32.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd32.Name = "btnCmd32";
			this.btnCmd32.Size = new System.Drawing.Size(160, 28);
			this.btnCmd32.TabIndex = 64;
			this.btnCmd32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd32.UseVisualStyleBackColor = true;
			// 
			// btnCmd31
			// 
			this.btnCmd31.AutoEllipsis = true;
			this.btnCmd31.Command = null;
			this.btnCmd31.Location = new System.Drawing.Point(372, 7);
			this.btnCmd31.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd31.Name = "btnCmd31";
			this.btnCmd31.Size = new System.Drawing.Size(160, 28);
			this.btnCmd31.TabIndex = 63;
			this.btnCmd31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd31.UseVisualStyleBackColor = true;
			// 
			// btnCmd20
			// 
			this.btnCmd20.AutoEllipsis = true;
			this.btnCmd20.Command = null;
			this.btnCmd20.Location = new System.Drawing.Point(7, 7);
			this.btnCmd20.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd20.Name = "btnCmd20";
			this.btnCmd20.Size = new System.Drawing.Size(160, 28);
			this.btnCmd20.TabIndex = 53;
			this.btnCmd20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd20.UseVisualStyleBackColor = true;
			// 
			// btnSelectCompiler
			// 
			this.btnSelectCompiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSelectCompiler.Location = new System.Drawing.Point(263, 716);
			this.btnSelectCompiler.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelectCompiler.Name = "btnSelectCompiler";
			this.btnSelectCompiler.Size = new System.Drawing.Size(40, 28);
			this.btnSelectCompiler.TabIndex = 33;
			this.btnSelectCompiler.Text = "...";
			this.btnSelectCompiler.UseVisualStyleBackColor = true;
			this.btnSelectCompiler.Click += new System.EventHandler(this.btnSelectCompiler_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(232, 433);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(100, 28);
			this.btnEdit.TabIndex = 7;
			this.btnEdit.Text = "F4 - &Edit";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSelectEditor
			// 
			this.btnSelectEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSelectEditor.Location = new System.Drawing.Point(620, 716);
			this.btnSelectEditor.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelectEditor.Name = "btnSelectEditor";
			this.btnSelectEditor.Size = new System.Drawing.Size(40, 28);
			this.btnSelectEditor.TabIndex = 36;
			this.btnSelectEditor.Text = "...";
			this.btnSelectEditor.UseVisualStyleBackColor = true;
			this.btnSelectEditor.Click += new System.EventHandler(this.btnSelectEditor_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(277, 653);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(120, 28);
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
			this.log.Location = new System.Drawing.Point(668, 35);
			this.log.Margin = new System.Windows.Forms.Padding(4);
			this.log.Multiline = true;
			this.log.Name = "log";
			this.log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.log.Size = new System.Drawing.Size(572, 706);
			this.log.TabIndex = 30;
			this.log.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.log_KeyPress);
			// 
			// btnCompile
			// 
			this.btnCompile.Location = new System.Drawing.Point(232, 461);
			this.btnCompile.Margin = new System.Windows.Forms.Padding(4);
			this.btnCompile.Name = "btnCompile";
			this.btnCompile.Size = new System.Drawing.Size(100, 28);
			this.btnCompile.TabIndex = 8;
			this.btnCompile.Text = "F5 - &Compile";
			this.btnCompile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCompile.UseVisualStyleBackColor = true;
			this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(232, 404);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(100, 28);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSelect.Location = new System.Drawing.Point(620, 686);
			this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(40, 28);
			this.btnSelect.TabIndex = 12;
			this.btnSelect.Text = "...";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnCmd41
			// 
			this.btnCmd41.AutoEllipsis = true;
			this.btnCmd41.Command = null;
			this.btnCmd41.Location = new System.Drawing.Point(372, 287);
			this.btnCmd41.Margin = new System.Windows.Forms.Padding(4);
			this.btnCmd41.Name = "btnCmd41";
			this.btnCmd41.Size = new System.Drawing.Size(160, 28);
			this.btnCmd41.TabIndex = 84;
			this.btnCmd41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCmd41.UseVisualStyleBackColor = true;
			// 
			// XTerminal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1249, 780);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.cbWordWrap);
			this.Controls.Add(this.cbEcho);
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
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(1034, 815);
			this.Name = "XTerminal";
			this.Text = "Terminal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.form_KeyUp);
			this.filesHostCntxMenu.ResumeLayout(false);
			this.filesDeviceCntxMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.statusLine.ResumeLayout(false);
			this.statusLine.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GPSIFIX_UPDATE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FTPGETIFIX_SIZE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GPSPS_PTF)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbPorts;
		private System.Windows.Forms.ComboBox cbSpeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbProtocol;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox folderSelected;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView filesHost;
		private System.Windows.Forms.FolderBrowserDialog folderDialog;
		private System.Windows.Forms.TextBox compiler;
		private System.Windows.Forms.ListView filesDevice;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private TextBoxEx log;
		private System.Windows.Forms.LinkLabel lblCompiler;
		private System.Windows.Forms.StatusStrip statusLine;
		private System.Windows.Forms.ToolStripStatusLabel Status;
		private System.Windows.Forms.ToolStripProgressBar progress;
		private System.Windows.Forms.CheckBox cbHidden;
		private System.Windows.Forms.CheckBox cbEcho;
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
		private System.Windows.Forms.CheckBox cbDTR;
		private System.Windows.Forms.ContextMenuStrip filesHostCntxMenu;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem coToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mpToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip filesDeviceCntxMenu;
		private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox cbWordWrap;
		private System.Windows.Forms.CheckBox cbLSCRIPT;
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
	}
}

