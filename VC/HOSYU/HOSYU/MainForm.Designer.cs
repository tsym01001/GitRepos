namespace HOSYU
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlFill = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAccept = new System.Windows.Forms.TabPage();
            this.btnDownloadPost = new System.Windows.Forms.Button();
            this.btnUploadPost = new System.Windows.Forms.Button();
            this.btnDownloadArea = new System.Windows.Forms.Button();
            this.btnUploadArea = new System.Windows.Forms.Button();
            this.txtReceptNum2 = new System.Windows.Forms.DomainUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtSymptom = new System.Windows.Forms.TextBox();
            this.lblSYMPTOM = new System.Windows.Forms.Label();
            this.txtSystName = new System.Windows.Forms.TextBox();
            this.lblSYSTEM = new System.Windows.Forms.Label();
            this.txtRecvDay = new System.Windows.Forms.TextBox();
            this.lblACCEPTDAY = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.ComboBox();
            this.CmbMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyTsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPOST = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.ComboBox();
            this.lblAREA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReceptNum1 = new System.Windows.Forms.TextBox();
            this.lblACCEPTID = new System.Windows.Forms.Label();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabProcInfo = new System.Windows.Forms.TabPage();
            this.lblProcInfo = new System.Windows.Forms.Label();
            this.btnAddProc = new System.Windows.Forms.Button();
            this.btnCopy1 = new System.Windows.Forms.Button();
            this.txtInputsProc = new System.Windows.Forms.ComboBox();
            this.lblINPUTSPROC = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.lblREPORT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinuteProc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTimeProc = new System.Windows.Forms.TextBox();
            this.txtDayProc = new System.Windows.Forms.TextBox();
            this.lblDAYPROC = new System.Windows.Forms.Label();
            this.tabPdfInfo = new System.Windows.Forms.TabPage();
            this.btnRunAcrobat = new System.Windows.Forms.Button();
            this.lblPdfInfo = new System.Windows.Forms.Label();
            this.btnAddPdf = new System.Windows.Forms.Button();
            this.chkComplete = new System.Windows.Forms.CheckBox();
            this.btnCopy2 = new System.Windows.Forms.Button();
            this.txtProc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInputsPdf = new System.Windows.Forms.ComboBox();
            this.txtCause = new System.Windows.Forms.TextBox();
            this.txtCharger = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblINPUTSPDF = new System.Windows.Forms.Label();
            this.lblPROCPDF = new System.Windows.Forms.Label();
            this.lblCAUSEPDF = new System.Windows.Forms.Label();
            this.lblCHARGER = new System.Windows.Forms.Label();
            this.lblDAYPDF = new System.Windows.Forms.Label();
            this.tabDataBase = new System.Windows.Forms.TabPage();
            this.domainFilterID = new System.Windows.Forms.DomainUpDown();
            this.chkDomID = new System.Windows.Forms.CheckBox();
            this.chkFlgComp = new System.Windows.Forms.CheckBox();
            this.txtFilterInputs = new System.Windows.Forms.TextBox();
            this.chkInputs = new System.Windows.Forms.CheckBox();
            this.chkCharger = new System.Windows.Forms.CheckBox();
            this.txtFilterCharger = new System.Windows.Forms.TextBox();
            this.chkSymptom = new System.Windows.Forms.CheckBox();
            this.txtFilterSymptom = new System.Windows.Forms.TextBox();
            this.chkSysname = new System.Windows.Forms.CheckBox();
            this.txtFilterSysname = new System.Windows.Forms.TextBox();
            this.txtFilterPost = new System.Windows.Forms.TextBox();
            this.chkPost = new System.Windows.Forms.CheckBox();
            this.chkArea = new System.Windows.Forms.CheckBox();
            this.txtFilterArea = new System.Windows.Forms.TextBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.txtFilterDate = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.btnBrowseAccess = new System.Windows.Forms.Button();
            this.txtAccessDbf = new System.Windows.Forms.TextBox();
            this.lblAccLocation = new System.Windows.Forms.Label();
            this.lblOUTDATA = new System.Windows.Forms.Label();
            this.btnToClipboard = new System.Windows.Forms.Button();
            this.txtOutData = new System.Windows.Forms.TextBox();
            this.tabTemplate = new System.Windows.Forms.TabPage();
            this.btnLoadTmp = new System.Windows.Forms.Button();
            this.btnSaveTmp = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelTextControl14 = new HOSYU.LabelTextControl();
            this.labelTextControl13 = new HOSYU.LabelTextControl();
            this.labelTextControl12 = new HOSYU.LabelTextControl();
            this.labelTextControl11 = new HOSYU.LabelTextControl();
            this.labelTextControl10 = new HOSYU.LabelTextControl();
            this.labelTextControl9 = new HOSYU.LabelTextControl();
            this.labelTextControl8 = new HOSYU.LabelTextControl();
            this.labelTextControl7 = new HOSYU.LabelTextControl();
            this.labelTextControl6 = new HOSYU.LabelTextControl();
            this.labelTextControl5 = new HOSYU.LabelTextControl();
            this.labelTextControl4 = new HOSYU.LabelTextControl();
            this.labelTextControl3 = new HOSYU.LabelTextControl();
            this.labelTextControl2 = new HOSYU.LabelTextControl();
            this.labelTextControl1 = new HOSYU.LabelTextControl();
            this.pnlFill.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAccept.SuspendLayout();
            this.CmbMenuStrip.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabProcInfo.SuspendLayout();
            this.tabPdfInfo.SuspendLayout();
            this.tabDataBase.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabTemplate.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.AutoScroll = true;
            this.pnlFill.AutoSize = true;
            this.pnlFill.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlFill.Controls.Add(this.tabControl1);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(944, 727);
            this.pnlFill.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabAccept);
            this.tabControl1.Controls.Add(this.tabInput);
            this.tabControl1.Controls.Add(this.tabDataBase);
            this.tabControl1.Controls.Add(this.tabConfig);
            this.tabControl1.Controls.Add(this.tabTemplate);
            this.tabControl1.Location = new System.Drawing.Point(3, 74);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 627);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAccept
            // 
            this.tabAccept.BackColor = System.Drawing.Color.Lavender;
            this.tabAccept.Controls.Add(this.btnDownloadPost);
            this.tabAccept.Controls.Add(this.btnUploadPost);
            this.tabAccept.Controls.Add(this.btnDownloadArea);
            this.tabAccept.Controls.Add(this.btnUploadArea);
            this.tabAccept.Controls.Add(this.txtReceptNum2);
            this.tabAccept.Controls.Add(this.btnAccept);
            this.tabAccept.Controls.Add(this.txtSymptom);
            this.tabAccept.Controls.Add(this.lblSYMPTOM);
            this.tabAccept.Controls.Add(this.txtSystName);
            this.tabAccept.Controls.Add(this.lblSYSTEM);
            this.tabAccept.Controls.Add(this.txtRecvDay);
            this.tabAccept.Controls.Add(this.lblACCEPTDAY);
            this.tabAccept.Controls.Add(this.txtPost);
            this.tabAccept.Controls.Add(this.lblPOST);
            this.tabAccept.Controls.Add(this.txtArea);
            this.tabAccept.Controls.Add(this.lblAREA);
            this.tabAccept.Controls.Add(this.label11);
            this.tabAccept.Controls.Add(this.txtReceptNum1);
            this.tabAccept.Controls.Add(this.lblACCEPTID);
            this.tabAccept.Location = new System.Drawing.Point(4, 35);
            this.tabAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAccept.Name = "tabAccept";
            this.tabAccept.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabAccept.Size = new System.Drawing.Size(933, 588);
            this.tabAccept.TabIndex = 0;
            this.tabAccept.Text = "受付入力処理";
            // 
            // btnDownloadPost
            // 
            this.btnDownloadPost.BackColor = System.Drawing.Color.LightGreen;
            this.btnDownloadPost.Location = new System.Drawing.Point(793, 87);
            this.btnDownloadPost.Name = "btnDownloadPost";
            this.btnDownloadPost.Size = new System.Drawing.Size(25, 27);
            this.btnDownloadPost.TabIndex = 19;
            this.btnDownloadPost.Text = "↓";
            this.toolTip.SetToolTip(this.btnDownloadPost, "データベースからリストをダウンロードします");
            this.btnDownloadPost.UseVisualStyleBackColor = false;
            // 
            // btnUploadPost
            // 
            this.btnUploadPost.BackColor = System.Drawing.Color.Khaki;
            this.btnUploadPost.Location = new System.Drawing.Point(762, 87);
            this.btnUploadPost.Name = "btnUploadPost";
            this.btnUploadPost.Size = new System.Drawing.Size(25, 27);
            this.btnUploadPost.TabIndex = 18;
            this.btnUploadPost.Text = "↑";
            this.toolTip.SetToolTip(this.btnUploadPost, "データベースへリストをアップロードします");
            this.btnUploadPost.UseVisualStyleBackColor = false;
            // 
            // btnDownloadArea
            // 
            this.btnDownloadArea.BackColor = System.Drawing.Color.LightGreen;
            this.btnDownloadArea.Location = new System.Drawing.Point(364, 88);
            this.btnDownloadArea.Name = "btnDownloadArea";
            this.btnDownloadArea.Size = new System.Drawing.Size(25, 27);
            this.btnDownloadArea.TabIndex = 17;
            this.btnDownloadArea.Text = "↓";
            this.toolTip.SetToolTip(this.btnDownloadArea, "データベースからリストをダウンロードします");
            this.btnDownloadArea.UseVisualStyleBackColor = false;
            // 
            // btnUploadArea
            // 
            this.btnUploadArea.BackColor = System.Drawing.Color.Khaki;
            this.btnUploadArea.Location = new System.Drawing.Point(333, 88);
            this.btnUploadArea.Name = "btnUploadArea";
            this.btnUploadArea.Size = new System.Drawing.Size(25, 27);
            this.btnUploadArea.TabIndex = 16;
            this.btnUploadArea.Text = "↑";
            this.toolTip.SetToolTip(this.btnUploadArea, "データベースへリストをアップロードします");
            this.btnUploadArea.UseVisualStyleBackColor = false;
            // 
            // txtReceptNum2
            // 
            this.txtReceptNum2.Location = new System.Drawing.Point(419, 27);
            this.txtReceptNum2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceptNum2.Name = "txtReceptNum2";
            this.txtReceptNum2.Size = new System.Drawing.Size(55, 30);
            this.txtReceptNum2.TabIndex = 3;
            this.txtReceptNum2.Text = "00";
            this.txtReceptNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Moccasin;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccept.Location = new System.Drawing.Point(793, 19);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(64, 46);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "追加";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtSymptom
            // 
            this.txtSymptom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSymptom.Location = new System.Drawing.Point(110, 237);
            this.txtSymptom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSymptom.MaxLength = 5000;
            this.txtSymptom.Multiline = true;
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSymptom.Size = new System.Drawing.Size(747, 256);
            this.txtSymptom.TabIndex = 15;
            // 
            // lblSYMPTOM
            // 
            this.lblSYMPTOM.AutoSize = true;
            this.lblSYMPTOM.Location = new System.Drawing.Point(19, 237);
            this.lblSYMPTOM.Name = "lblSYMPTOM";
            this.lblSYMPTOM.Size = new System.Drawing.Size(55, 23);
            this.lblSYMPTOM.TabIndex = 14;
            this.lblSYMPTOM.Text = "症状：";
            this.lblSYMPTOM.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // txtSystName
            // 
            this.txtSystName.Location = new System.Drawing.Point(544, 148);
            this.txtSystName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSystName.MaxLength = 128;
            this.txtSystName.Name = "txtSystName";
            this.txtSystName.Size = new System.Drawing.Size(207, 30);
            this.txtSystName.TabIndex = 13;
            // 
            // lblSYSTEM
            // 
            this.lblSYSTEM.AutoSize = true;
            this.lblSYSTEM.Location = new System.Drawing.Point(438, 151);
            this.lblSYSTEM.Name = "lblSYSTEM";
            this.lblSYSTEM.Size = new System.Drawing.Size(100, 23);
            this.lblSYSTEM.TabIndex = 12;
            this.lblSYSTEM.Text = "システム名：";
            this.lblSYSTEM.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // txtRecvDay
            // 
            this.txtRecvDay.Location = new System.Drawing.Point(110, 148);
            this.txtRecvDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRecvDay.MaxLength = 8;
            this.txtRecvDay.Name = "txtRecvDay";
            this.txtRecvDay.Size = new System.Drawing.Size(129, 30);
            this.txtRecvDay.TabIndex = 11;
            this.txtRecvDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // lblACCEPTDAY
            // 
            this.lblACCEPTDAY.AutoSize = true;
            this.lblACCEPTDAY.Location = new System.Drawing.Point(19, 151);
            this.lblACCEPTDAY.Name = "lblACCEPTDAY";
            this.lblACCEPTDAY.Size = new System.Drawing.Size(85, 23);
            this.lblACCEPTDAY.TabIndex = 10;
            this.lblACCEPTDAY.Text = "受付日時：";
            this.lblACCEPTDAY.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // txtPost
            // 
            this.txtPost.ContextMenuStrip = this.CmbMenuStrip;
            this.txtPost.Location = new System.Drawing.Point(544, 86);
            this.txtPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPost.MaxLength = 128;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(207, 31);
            this.txtPost.TabIndex = 9;
            this.txtPost.SelectedIndexChanged += new System.EventHandler(this.OnnSelIndexChanged);
            this.txtPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCmbKeyPress);
            // 
            // CmbMenuStrip
            // 
            this.CmbMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTsMenuItem,
            this.DeleteTsMenuItem,
            this.ModifyTsMenuItem});
            this.CmbMenuStrip.Name = "CmbMenuStrip";
            this.CmbMenuStrip.Size = new System.Drawing.Size(101, 70);
            this.CmbMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.CmbMenuStrip_Opening);
            // 
            // AddTsMenuItem
            // 
            this.AddTsMenuItem.Name = "AddTsMenuItem";
            this.AddTsMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AddTsMenuItem.Text = "追加";
            this.AddTsMenuItem.Click += new System.EventHandler(this.OnContextAdd);
            // 
            // DeleteTsMenuItem
            // 
            this.DeleteTsMenuItem.Name = "DeleteTsMenuItem";
            this.DeleteTsMenuItem.Size = new System.Drawing.Size(100, 22);
            this.DeleteTsMenuItem.Text = "削除";
            this.DeleteTsMenuItem.Click += new System.EventHandler(this.OnContextDelete);
            // 
            // ModifyTsMenuItem
            // 
            this.ModifyTsMenuItem.Name = "ModifyTsMenuItem";
            this.ModifyTsMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ModifyTsMenuItem.Text = "変更";
            this.ModifyTsMenuItem.Click += new System.EventHandler(this.OnContextModify);
            // 
            // lblPOST
            // 
            this.lblPOST.AutoSize = true;
            this.lblPOST.Location = new System.Drawing.Point(438, 88);
            this.lblPOST.Name = "lblPOST";
            this.lblPOST.Size = new System.Drawing.Size(55, 23);
            this.lblPOST.TabIndex = 8;
            this.lblPOST.Text = "部署：";
            this.lblPOST.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // txtArea
            // 
            this.txtArea.ContextMenuStrip = this.CmbMenuStrip;
            this.txtArea.Location = new System.Drawing.Point(110, 85);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArea.MaxLength = 128;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(207, 31);
            this.txtArea.TabIndex = 7;
            this.txtArea.SelectedIndexChanged += new System.EventHandler(this.OnnSelIndexChanged);
            this.txtArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCmbKeyPress);
            // 
            // lblAREA
            // 
            this.lblAREA.AutoSize = true;
            this.lblAREA.Location = new System.Drawing.Point(19, 89);
            this.lblAREA.Name = "lblAREA";
            this.lblAREA.Size = new System.Drawing.Size(55, 23);
            this.lblAREA.TabIndex = 6;
            this.lblAREA.Text = "管轄：";
            this.lblAREA.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "-";
            // 
            // txtReceptNum1
            // 
            this.txtReceptNum1.Location = new System.Drawing.Point(232, 26);
            this.txtReceptNum1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceptNum1.MaxLength = 8;
            this.txtReceptNum1.Name = "txtReceptNum1";
            this.txtReceptNum1.Size = new System.Drawing.Size(126, 30);
            this.txtReceptNum1.TabIndex = 1;
            this.txtReceptNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            this.txtReceptNum1.Validated += new System.EventHandler(this.txtReceptNum1_Validated);
            // 
            // lblACCEPTID
            // 
            this.lblACCEPTID.AutoSize = true;
            this.lblACCEPTID.Location = new System.Drawing.Point(106, 29);
            this.lblACCEPTID.Name = "lblACCEPTID";
            this.lblACCEPTID.Size = new System.Drawing.Size(85, 23);
            this.lblACCEPTID.TabIndex = 0;
            this.lblACCEPTID.Text = "受付番号：";
            this.lblACCEPTID.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // tabInput
            // 
            this.tabInput.AutoScroll = true;
            this.tabInput.BackColor = System.Drawing.Color.Lavender;
            this.tabInput.Controls.Add(this.tabControl2);
            this.tabInput.Location = new System.Drawing.Point(4, 35);
            this.tabInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabInput.Size = new System.Drawing.Size(933, 588);
            this.tabInput.TabIndex = 1;
            this.tabInput.Text = "報告書入力処理";
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.ContextMenuStrip = this.CmbMenuStrip;
            this.tabControl2.Controls.Add(this.tabProcInfo);
            this.tabControl2.Controls.Add(this.tabPdfInfo);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl2.Location = new System.Drawing.Point(3, 4);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(927, 590);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabProcInfo
            // 
            this.tabProcInfo.BackColor = System.Drawing.Color.LightGray;
            this.tabProcInfo.Controls.Add(this.lblProcInfo);
            this.tabProcInfo.Controls.Add(this.btnAddProc);
            this.tabProcInfo.Controls.Add(this.btnCopy1);
            this.tabProcInfo.Controls.Add(this.txtInputsProc);
            this.tabProcInfo.Controls.Add(this.lblINPUTSPROC);
            this.tabProcInfo.Controls.Add(this.txtReport);
            this.tabProcInfo.Controls.Add(this.lblREPORT);
            this.tabProcInfo.Controls.Add(this.label6);
            this.tabProcInfo.Controls.Add(this.txtMinuteProc);
            this.tabProcInfo.Controls.Add(this.label15);
            this.tabProcInfo.Controls.Add(this.txtTimeProc);
            this.tabProcInfo.Controls.Add(this.txtDayProc);
            this.tabProcInfo.Controls.Add(this.lblDAYPROC);
            this.tabProcInfo.Location = new System.Drawing.Point(4, 32);
            this.tabProcInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProcInfo.Name = "tabProcInfo";
            this.tabProcInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProcInfo.Size = new System.Drawing.Size(919, 554);
            this.tabProcInfo.TabIndex = 0;
            this.tabProcInfo.Text = "経過報告";
            // 
            // lblProcInfo
            // 
            this.lblProcInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProcInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProcInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProcInfo.Location = new System.Drawing.Point(3, 4);
            this.lblProcInfo.Name = "lblProcInfo";
            this.lblProcInfo.Size = new System.Drawing.Size(913, 66);
            this.lblProcInfo.TabIndex = 13;
            this.lblProcInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddProc
            // 
            this.btnAddProc.BackColor = System.Drawing.Color.Moccasin;
            this.btnAddProc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProc.Location = new System.Drawing.Point(439, 459);
            this.btnAddProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProc.Name = "btnAddProc";
            this.btnAddProc.Size = new System.Drawing.Size(64, 46);
            this.btnAddProc.TabIndex = 10;
            this.btnAddProc.Text = "追加";
            this.btnAddProc.UseVisualStyleBackColor = false;
            this.btnAddProc.Click += new System.EventHandler(this.btnAddProc_Click);
            // 
            // btnCopy1
            // 
            this.btnCopy1.BackColor = System.Drawing.Color.Beige;
            this.btnCopy1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopy1.Location = new System.Drawing.Point(592, 459);
            this.btnCopy1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy1.Name = "btnCopy1";
            this.btnCopy1.Size = new System.Drawing.Size(88, 49);
            this.btnCopy1.TabIndex = 12;
            this.btnCopy1.Text = "設定";
            this.btnCopy1.UseVisualStyleBackColor = false;
            this.btnCopy1.Click += new System.EventHandler(this.btnCopy1_Click);
            // 
            // txtInputsProc
            // 
            this.txtInputsProc.ContextMenuStrip = this.CmbMenuStrip;
            this.txtInputsProc.Location = new System.Drawing.Point(168, 469);
            this.txtInputsProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputsProc.MaxLength = 30;
            this.txtInputsProc.Name = "txtInputsProc";
            this.txtInputsProc.Size = new System.Drawing.Size(135, 28);
            this.txtInputsProc.TabIndex = 9;
            this.txtInputsProc.SelectedIndexChanged += new System.EventHandler(this.OnnSelIndexChanged);
            this.txtInputsProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCmbKeyPress);
            // 
            // lblINPUTSPROC
            // 
            this.lblINPUTSPROC.AutoSize = true;
            this.lblINPUTSPROC.Location = new System.Drawing.Point(73, 473);
            this.lblINPUTSPROC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblINPUTSPROC.Name = "lblINPUTSPROC";
            this.lblINPUTSPROC.Size = new System.Drawing.Size(74, 20);
            this.lblINPUTSPROC.TabIndex = 8;
            this.lblINPUTSPROC.Text = "入力担当：";
            this.lblINPUTSPROC.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // txtReport
            // 
            this.txtReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReport.Location = new System.Drawing.Point(168, 200);
            this.txtReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReport.Size = new System.Drawing.Size(690, 201);
            this.txtReport.TabIndex = 7;
            // 
            // lblREPORT
            // 
            this.lblREPORT.AutoSize = true;
            this.lblREPORT.Location = new System.Drawing.Point(73, 200);
            this.lblREPORT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblREPORT.Name = "lblREPORT";
            this.lblREPORT.Size = new System.Drawing.Size(48, 20);
            this.lblREPORT.TabIndex = 6;
            this.lblREPORT.Text = "報告：";
            this.lblREPORT.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "分";
            // 
            // txtMinuteProc
            // 
            this.txtMinuteProc.Location = new System.Drawing.Point(439, 109);
            this.txtMinuteProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinuteProc.MaxLength = 2;
            this.txtMinuteProc.Name = "txtMinuteProc";
            this.txtMinuteProc.Size = new System.Drawing.Size(45, 27);
            this.txtMinuteProc.TabIndex = 4;
            this.txtMinuteProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(394, 112);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "時";
            // 
            // txtTimeProc
            // 
            this.txtTimeProc.Location = new System.Drawing.Point(326, 109);
            this.txtTimeProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimeProc.MaxLength = 2;
            this.txtTimeProc.Name = "txtTimeProc";
            this.txtTimeProc.Size = new System.Drawing.Size(45, 27);
            this.txtTimeProc.TabIndex = 2;
            this.txtTimeProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // txtDayProc
            // 
            this.txtDayProc.Location = new System.Drawing.Point(168, 109);
            this.txtDayProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDayProc.MaxLength = 8;
            this.txtDayProc.Name = "txtDayProc";
            this.txtDayProc.Size = new System.Drawing.Size(135, 27);
            this.txtDayProc.TabIndex = 1;
            this.txtDayProc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // lblDAYPROC
            // 
            this.lblDAYPROC.AutoSize = true;
            this.lblDAYPROC.Location = new System.Drawing.Point(73, 112);
            this.lblDAYPROC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDAYPROC.Name = "lblDAYPROC";
            this.lblDAYPROC.Size = new System.Drawing.Size(74, 20);
            this.lblDAYPROC.TabIndex = 0;
            this.lblDAYPROC.Text = "連絡日時：";
            this.lblDAYPROC.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // tabPdfInfo
            // 
            this.tabPdfInfo.BackColor = System.Drawing.Color.LightGray;
            this.tabPdfInfo.Controls.Add(this.btnRunAcrobat);
            this.tabPdfInfo.Controls.Add(this.lblPdfInfo);
            this.tabPdfInfo.Controls.Add(this.btnAddPdf);
            this.tabPdfInfo.Controls.Add(this.chkComplete);
            this.tabPdfInfo.Controls.Add(this.btnCopy2);
            this.tabPdfInfo.Controls.Add(this.txtProc);
            this.tabPdfInfo.Controls.Add(this.label9);
            this.tabPdfInfo.Controls.Add(this.txtInputsPdf);
            this.tabPdfInfo.Controls.Add(this.txtCause);
            this.tabPdfInfo.Controls.Add(this.txtCharger);
            this.tabPdfInfo.Controls.Add(this.label8);
            this.tabPdfInfo.Controls.Add(this.txtMinute);
            this.tabPdfInfo.Controls.Add(this.label7);
            this.tabPdfInfo.Controls.Add(this.txtTime);
            this.tabPdfInfo.Controls.Add(this.txtDay);
            this.tabPdfInfo.Controls.Add(this.lblINPUTSPDF);
            this.tabPdfInfo.Controls.Add(this.lblPROCPDF);
            this.tabPdfInfo.Controls.Add(this.lblCAUSEPDF);
            this.tabPdfInfo.Controls.Add(this.lblCHARGER);
            this.tabPdfInfo.Controls.Add(this.lblDAYPDF);
            this.tabPdfInfo.Location = new System.Drawing.Point(4, 32);
            this.tabPdfInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPdfInfo.Name = "tabPdfInfo";
            this.tabPdfInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPdfInfo.Size = new System.Drawing.Size(919, 554);
            this.tabPdfInfo.TabIndex = 1;
            this.tabPdfInfo.Text = "PDF文書";
            // 
            // btnRunAcrobat
            // 
            this.btnRunAcrobat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunAcrobat.Image = ((System.Drawing.Image)(resources.GetObject("btnRunAcrobat.Image")));
            this.btnRunAcrobat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunAcrobat.Location = new System.Drawing.Point(676, 91);
            this.btnRunAcrobat.Name = "btnRunAcrobat";
            this.btnRunAcrobat.Size = new System.Drawing.Size(182, 63);
            this.btnRunAcrobat.TabIndex = 20;
            this.btnRunAcrobat.Text = "PDFファイルを開く";
            this.btnRunAcrobat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunAcrobat.UseVisualStyleBackColor = true;
            this.btnRunAcrobat.Click += new System.EventHandler(this.btnRunAcrobat_Click);
            // 
            // lblPdfInfo
            // 
            this.lblPdfInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPdfInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPdfInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPdfInfo.Location = new System.Drawing.Point(3, 4);
            this.lblPdfInfo.Name = "lblPdfInfo";
            this.lblPdfInfo.Size = new System.Drawing.Size(913, 66);
            this.lblPdfInfo.TabIndex = 19;
            this.lblPdfInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddPdf
            // 
            this.btnAddPdf.BackColor = System.Drawing.Color.Moccasin;
            this.btnAddPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPdf.Location = new System.Drawing.Point(457, 488);
            this.btnAddPdf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPdf.Name = "btnAddPdf";
            this.btnAddPdf.Size = new System.Drawing.Size(64, 46);
            this.btnAddPdf.TabIndex = 16;
            this.btnAddPdf.Text = "追加";
            this.btnAddPdf.UseVisualStyleBackColor = false;
            this.btnAddPdf.Click += new System.EventHandler(this.btnAddPdf_Click);
            // 
            // chkComplete
            // 
            this.chkComplete.AutoSize = true;
            this.chkComplete.Location = new System.Drawing.Point(578, 110);
            this.chkComplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkComplete.Name = "chkComplete";
            this.chkComplete.Size = new System.Drawing.Size(54, 24);
            this.chkComplete.TabIndex = 6;
            this.chkComplete.Text = "継続";
            this.chkComplete.UseVisualStyleBackColor = true;
            this.chkComplete.CheckStateChanged += new System.EventHandler(this.chk_StateChanged);
            // 
            // btnCopy2
            // 
            this.btnCopy2.BackColor = System.Drawing.Color.Beige;
            this.btnCopy2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopy2.Location = new System.Drawing.Point(592, 487);
            this.btnCopy2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy2.Name = "btnCopy2";
            this.btnCopy2.Size = new System.Drawing.Size(88, 49);
            this.btnCopy2.TabIndex = 18;
            this.btnCopy2.Text = "設定";
            this.btnCopy2.UseVisualStyleBackColor = false;
            this.btnCopy2.Click += new System.EventHandler(this.btnCopy2_Click);
            // 
            // txtProc
            // 
            this.txtProc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProc.Location = new System.Drawing.Point(158, 358);
            this.txtProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProc.MaxLength = 32737;
            this.txtProc.Multiline = true;
            this.txtProc.Name = "txtProc";
            this.txtProc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProc.Size = new System.Drawing.Size(700, 109);
            this.txtProc.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "様";
            // 
            // txtInputsPdf
            // 
            this.txtInputsPdf.ContextMenuStrip = this.CmbMenuStrip;
            this.txtInputsPdf.Location = new System.Drawing.Point(158, 498);
            this.txtInputsPdf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputsPdf.MaxLength = 30;
            this.txtInputsPdf.Name = "txtInputsPdf";
            this.txtInputsPdf.Size = new System.Drawing.Size(135, 28);
            this.txtInputsPdf.TabIndex = 15;
            this.txtInputsPdf.SelectedIndexChanged += new System.EventHandler(this.OnnSelIndexChanged);
            this.txtInputsPdf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCmbKeyPress);
            // 
            // txtCause
            // 
            this.txtCause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCause.Location = new System.Drawing.Point(158, 228);
            this.txtCause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCause.Multiline = true;
            this.txtCause.Name = "txtCause";
            this.txtCause.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCause.Size = new System.Drawing.Size(700, 109);
            this.txtCause.TabIndex = 11;
            // 
            // txtCharger
            // 
            this.txtCharger.ContextMenuStrip = this.CmbMenuStrip;
            this.txtCharger.Location = new System.Drawing.Point(158, 177);
            this.txtCharger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCharger.MaxLength = 30;
            this.txtCharger.Name = "txtCharger";
            this.txtCharger.Size = new System.Drawing.Size(250, 28);
            this.txtCharger.TabIndex = 8;
            this.txtCharger.SelectedIndexChanged += new System.EventHandler(this.OnnSelIndexChanged);
            this.txtCharger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnCmbKeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "分";
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(457, 107);
            this.txtMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinute.MaxLength = 2;
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(45, 27);
            this.txtMinute.TabIndex = 4;
            this.txtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "時";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(336, 107);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTime.MaxLength = 2;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(45, 27);
            this.txtTime.TabIndex = 2;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(158, 107);
            this.txtDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDay.MaxLength = 8;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(135, 27);
            this.txtDay.TabIndex = 1;
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // lblINPUTSPDF
            // 
            this.lblINPUTSPDF.AutoSize = true;
            this.lblINPUTSPDF.Location = new System.Drawing.Point(73, 500);
            this.lblINPUTSPDF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblINPUTSPDF.Name = "lblINPUTSPDF";
            this.lblINPUTSPDF.Size = new System.Drawing.Size(74, 20);
            this.lblINPUTSPDF.TabIndex = 14;
            this.lblINPUTSPDF.Text = "入力担当：";
            this.lblINPUTSPDF.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // lblPROCPDF
            // 
            this.lblPROCPDF.AutoSize = true;
            this.lblPROCPDF.Location = new System.Drawing.Point(73, 358);
            this.lblPROCPDF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPROCPDF.Name = "lblPROCPDF";
            this.lblPROCPDF.Size = new System.Drawing.Size(48, 20);
            this.lblPROCPDF.TabIndex = 12;
            this.lblPROCPDF.Text = "処置：";
            this.lblPROCPDF.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // lblCAUSEPDF
            // 
            this.lblCAUSEPDF.AutoSize = true;
            this.lblCAUSEPDF.Location = new System.Drawing.Point(73, 228);
            this.lblCAUSEPDF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCAUSEPDF.Name = "lblCAUSEPDF";
            this.lblCAUSEPDF.Size = new System.Drawing.Size(48, 20);
            this.lblCAUSEPDF.TabIndex = 10;
            this.lblCAUSEPDF.Text = "原因：";
            this.lblCAUSEPDF.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // lblCHARGER
            // 
            this.lblCHARGER.AutoSize = true;
            this.lblCHARGER.Location = new System.Drawing.Point(73, 180);
            this.lblCHARGER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCHARGER.Name = "lblCHARGER";
            this.lblCHARGER.Size = new System.Drawing.Size(48, 20);
            this.lblCHARGER.TabIndex = 7;
            this.lblCHARGER.Text = "担当：";
            this.lblCHARGER.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // lblDAYPDF
            // 
            this.lblDAYPDF.AutoSize = true;
            this.lblDAYPDF.Location = new System.Drawing.Point(73, 112);
            this.lblDAYPDF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDAYPDF.Name = "lblDAYPDF";
            this.lblDAYPDF.Size = new System.Drawing.Size(74, 20);
            this.lblDAYPDF.TabIndex = 0;
            this.lblDAYPDF.Text = "完了日時：";
            this.lblDAYPDF.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // tabDataBase
            // 
            this.tabDataBase.BackColor = System.Drawing.Color.Moccasin;
            this.tabDataBase.Controls.Add(this.domainFilterID);
            this.tabDataBase.Controls.Add(this.chkDomID);
            this.tabDataBase.Controls.Add(this.chkFlgComp);
            this.tabDataBase.Controls.Add(this.txtFilterInputs);
            this.tabDataBase.Controls.Add(this.chkInputs);
            this.tabDataBase.Controls.Add(this.chkCharger);
            this.tabDataBase.Controls.Add(this.txtFilterCharger);
            this.tabDataBase.Controls.Add(this.chkSymptom);
            this.tabDataBase.Controls.Add(this.txtFilterSymptom);
            this.tabDataBase.Controls.Add(this.chkSysname);
            this.tabDataBase.Controls.Add(this.txtFilterSysname);
            this.tabDataBase.Controls.Add(this.txtFilterPost);
            this.tabDataBase.Controls.Add(this.chkPost);
            this.tabDataBase.Controls.Add(this.chkArea);
            this.tabDataBase.Controls.Add(this.txtFilterArea);
            this.tabDataBase.Controls.Add(this.chkDate);
            this.tabDataBase.Controls.Add(this.txtFilterDate);
            this.tabDataBase.Controls.Add(this.btnQuery);
            this.tabDataBase.Controls.Add(this.label16);
            this.tabDataBase.Location = new System.Drawing.Point(4, 35);
            this.tabDataBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabDataBase.Name = "tabDataBase";
            this.tabDataBase.Size = new System.Drawing.Size(933, 588);
            this.tabDataBase.TabIndex = 3;
            this.tabDataBase.Text = "データベース";
            // 
            // domainFilterID
            // 
            this.domainFilterID.Enabled = false;
            this.domainFilterID.Location = new System.Drawing.Point(609, 60);
            this.domainFilterID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.domainFilterID.Name = "domainFilterID";
            this.domainFilterID.Size = new System.Drawing.Size(55, 30);
            this.domainFilterID.TabIndex = 4;
            this.domainFilterID.Text = "00";
            // 
            // chkDomID
            // 
            this.chkDomID.AutoSize = true;
            this.chkDomID.Location = new System.Drawing.Point(474, 62);
            this.chkDomID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDomID.Name = "chkDomID";
            this.chkDomID.Size = new System.Drawing.Size(46, 27);
            this.chkDomID.TabIndex = 3;
            this.chkDomID.Text = "ID";
            this.chkDomID.UseVisualStyleBackColor = true;
            this.chkDomID.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // chkFlgComp
            // 
            this.chkFlgComp.AutoSize = true;
            this.chkFlgComp.Location = new System.Drawing.Point(474, 326);
            this.chkFlgComp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkFlgComp.Name = "chkFlgComp";
            this.chkFlgComp.Size = new System.Drawing.Size(151, 27);
            this.chkFlgComp.TabIndex = 15;
            this.chkFlgComp.Text = "継続/完了 :[継続]";
            this.chkFlgComp.UseVisualStyleBackColor = true;
            this.chkFlgComp.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // txtFilterInputs
            // 
            this.txtFilterInputs.Enabled = false;
            this.txtFilterInputs.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtFilterInputs.Location = new System.Drawing.Point(609, 236);
            this.txtFilterInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterInputs.MaxLength = 128;
            this.txtFilterInputs.Name = "txtFilterInputs";
            this.txtFilterInputs.Size = new System.Drawing.Size(271, 30);
            this.txtFilterInputs.TabIndex = 12;
            // 
            // chkInputs
            // 
            this.chkInputs.AutoSize = true;
            this.chkInputs.Location = new System.Drawing.Point(474, 238);
            this.chkInputs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkInputs.Name = "chkInputs";
            this.chkInputs.Size = new System.Drawing.Size(104, 27);
            this.chkInputs.TabIndex = 11;
            this.chkInputs.Text = "入力担当者";
            this.chkInputs.UseVisualStyleBackColor = true;
            this.chkInputs.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // chkCharger
            // 
            this.chkCharger.AutoSize = true;
            this.chkCharger.Location = new System.Drawing.Point(37, 238);
            this.chkCharger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCharger.Name = "chkCharger";
            this.chkCharger.Size = new System.Drawing.Size(104, 27);
            this.chkCharger.TabIndex = 9;
            this.chkCharger.Text = "作業担当者";
            this.chkCharger.UseVisualStyleBackColor = true;
            this.chkCharger.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // txtFilterCharger
            // 
            this.txtFilterCharger.Enabled = false;
            this.txtFilterCharger.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtFilterCharger.Location = new System.Drawing.Point(172, 236);
            this.txtFilterCharger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterCharger.MaxLength = 128;
            this.txtFilterCharger.Name = "txtFilterCharger";
            this.txtFilterCharger.Size = new System.Drawing.Size(271, 30);
            this.txtFilterCharger.TabIndex = 10;
            // 
            // chkSymptom
            // 
            this.chkSymptom.AutoSize = true;
            this.chkSymptom.Location = new System.Drawing.Point(37, 414);
            this.chkSymptom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSymptom.Name = "chkSymptom";
            this.chkSymptom.Size = new System.Drawing.Size(59, 27);
            this.chkSymptom.TabIndex = 16;
            this.chkSymptom.Text = "症状";
            this.chkSymptom.UseVisualStyleBackColor = true;
            this.chkSymptom.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // txtFilterSymptom
            // 
            this.txtFilterSymptom.Enabled = false;
            this.txtFilterSymptom.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtFilterSymptom.Location = new System.Drawing.Point(172, 414);
            this.txtFilterSymptom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterSymptom.MaxLength = 1024;
            this.txtFilterSymptom.Multiline = true;
            this.txtFilterSymptom.Name = "txtFilterSymptom";
            this.txtFilterSymptom.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilterSymptom.Size = new System.Drawing.Size(708, 88);
            this.txtFilterSymptom.TabIndex = 17;
            // 
            // chkSysname
            // 
            this.chkSysname.AutoSize = true;
            this.chkSysname.Location = new System.Drawing.Point(37, 326);
            this.chkSysname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSysname.Name = "chkSysname";
            this.chkSysname.Size = new System.Drawing.Size(104, 27);
            this.chkSysname.TabIndex = 13;
            this.chkSysname.Text = "システム名";
            this.chkSysname.UseVisualStyleBackColor = true;
            this.chkSysname.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // txtFilterSysname
            // 
            this.txtFilterSysname.Enabled = false;
            this.txtFilterSysname.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtFilterSysname.Location = new System.Drawing.Point(172, 324);
            this.txtFilterSysname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterSysname.MaxLength = 128;
            this.txtFilterSysname.Name = "txtFilterSysname";
            this.txtFilterSysname.Size = new System.Drawing.Size(271, 30);
            this.txtFilterSysname.TabIndex = 14;
            this.txtFilterSysname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFilterPost
            // 
            this.txtFilterPost.Enabled = false;
            this.txtFilterPost.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtFilterPost.Location = new System.Drawing.Point(609, 148);
            this.txtFilterPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterPost.MaxLength = 128;
            this.txtFilterPost.Name = "txtFilterPost";
            this.txtFilterPost.Size = new System.Drawing.Size(271, 30);
            this.txtFilterPost.TabIndex = 8;
            // 
            // chkPost
            // 
            this.chkPost.AutoSize = true;
            this.chkPost.Location = new System.Drawing.Point(474, 150);
            this.chkPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPost.Name = "chkPost";
            this.chkPost.Size = new System.Drawing.Size(59, 27);
            this.chkPost.TabIndex = 7;
            this.chkPost.Text = "部署";
            this.chkPost.UseVisualStyleBackColor = true;
            this.chkPost.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // chkArea
            // 
            this.chkArea.AutoSize = true;
            this.chkArea.Location = new System.Drawing.Point(37, 150);
            this.chkArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkArea.Name = "chkArea";
            this.chkArea.Size = new System.Drawing.Size(59, 27);
            this.chkArea.TabIndex = 5;
            this.chkArea.Text = "管轄";
            this.chkArea.UseVisualStyleBackColor = true;
            this.chkArea.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // txtFilterArea
            // 
            this.txtFilterArea.Enabled = false;
            this.txtFilterArea.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtFilterArea.Location = new System.Drawing.Point(172, 148);
            this.txtFilterArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterArea.MaxLength = 128;
            this.txtFilterArea.Name = "txtFilterArea";
            this.txtFilterArea.Size = new System.Drawing.Size(271, 30);
            this.txtFilterArea.TabIndex = 6;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(37, 62);
            this.chkDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(59, 27);
            this.chkDate.TabIndex = 1;
            this.chkDate.Text = "日付";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // txtFilterDate
            // 
            this.txtFilterDate.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "b",
            "c",
            "d",
            "e"});
            this.txtFilterDate.Location = new System.Drawing.Point(172, 60);
            this.txtFilterDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterDate.MaxLength = 8;
            this.txtFilterDate.Name = "txtFilterDate";
            this.txtFilterDate.Size = new System.Drawing.Size(271, 30);
            this.txtFilterDate.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuery.BackColor = System.Drawing.Color.Wheat;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuery.Location = new System.Drawing.Point(313, 521);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(307, 53);
            this.btnQuery.TabIndex = 18;
            this.btnQuery.Text = "条件指定検索  [結果項目の削除・変更]";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Wheat;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(933, 36);
            this.label16.TabIndex = 0;
            this.label16.Text = "検索対象";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.Color.Beige;
            this.tabConfig.Controls.Add(this.btnBrowseAccess);
            this.tabConfig.Controls.Add(this.txtAccessDbf);
            this.tabConfig.Controls.Add(this.lblAccLocation);
            this.tabConfig.Controls.Add(this.lblOUTDATA);
            this.tabConfig.Controls.Add(this.btnToClipboard);
            this.tabConfig.Controls.Add(this.txtOutData);
            this.tabConfig.Location = new System.Drawing.Point(4, 35);
            this.tabConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(933, 588);
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "設定ファイル";
            // 
            // btnBrowseAccess
            // 
            this.btnBrowseAccess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBrowseAccess.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBrowseAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseAccess.Location = new System.Drawing.Point(791, 24);
            this.btnBrowseAccess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowseAccess.Name = "btnBrowseAccess";
            this.btnBrowseAccess.Size = new System.Drawing.Size(81, 39);
            this.btnBrowseAccess.TabIndex = 2;
            this.btnBrowseAccess.Text = "参照..";
            this.btnBrowseAccess.UseVisualStyleBackColor = false;
            this.btnBrowseAccess.Click += new System.EventHandler(this.btnBrowseAccess_Click);
            // 
            // txtAccessDbf
            // 
            this.txtAccessDbf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccessDbf.Location = new System.Drawing.Point(249, 29);
            this.txtAccessDbf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccessDbf.MaxLength = 1024;
            this.txtAccessDbf.Name = "txtAccessDbf";
            this.txtAccessDbf.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAccessDbf.Size = new System.Drawing.Size(530, 30);
            this.txtAccessDbf.TabIndex = 1;
            // 
            // lblAccLocation
            // 
            this.lblAccLocation.AutoSize = true;
            this.lblAccLocation.Location = new System.Drawing.Point(33, 32);
            this.lblAccLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccLocation.Name = "lblAccLocation";
            this.lblAccLocation.Size = new System.Drawing.Size(209, 23);
            this.lblAccLocation.TabIndex = 0;
            this.lblAccLocation.Text = "Accessデータベースの場所：";
            this.lblAccLocation.DoubleClick += new System.EventHandler(this.lblAccLocation_DoubleClick);
            // 
            // lblOUTDATA
            // 
            this.lblOUTDATA.AutoSize = true;
            this.lblOUTDATA.Location = new System.Drawing.Point(33, 99);
            this.lblOUTDATA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOUTDATA.Name = "lblOUTDATA";
            this.lblOUTDATA.Size = new System.Drawing.Size(100, 23);
            this.lblOUTDATA.TabIndex = 5;
            this.lblOUTDATA.Text = "出力データ：";
            this.lblOUTDATA.DoubleClick += new System.EventHandler(this.OnLblDoubleclickMethod);
            // 
            // btnToClipboard
            // 
            this.btnToClipboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnToClipboard.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToClipboard.Location = new System.Drawing.Point(387, 487);
            this.btnToClipboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToClipboard.Name = "btnToClipboard";
            this.btnToClipboard.Size = new System.Drawing.Size(158, 50);
            this.btnToClipboard.TabIndex = 7;
            this.btnToClipboard.Text = "テキストをコピー";
            this.btnToClipboard.UseVisualStyleBackColor = false;
            this.btnToClipboard.Click += new System.EventHandler(this.btnToClipboard_Click);
            // 
            // txtOutData
            // 
            this.txtOutData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutData.Location = new System.Drawing.Point(140, 99);
            this.txtOutData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutData.Multiline = true;
            this.txtOutData.Name = "txtOutData";
            this.txtOutData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutData.Size = new System.Drawing.Size(732, 347);
            this.txtOutData.TabIndex = 6;
            // 
            // tabTemplate
            // 
            this.tabTemplate.BackColor = System.Drawing.Color.Lavender;
            this.tabTemplate.Controls.Add(this.btnLoadTmp);
            this.tabTemplate.Controls.Add(this.btnSaveTmp);
            this.tabTemplate.Controls.Add(this.labelTextControl14);
            this.tabTemplate.Controls.Add(this.labelTextControl13);
            this.tabTemplate.Controls.Add(this.labelTextControl12);
            this.tabTemplate.Controls.Add(this.labelTextControl11);
            this.tabTemplate.Controls.Add(this.labelTextControl10);
            this.tabTemplate.Controls.Add(this.labelTextControl9);
            this.tabTemplate.Controls.Add(this.labelTextControl8);
            this.tabTemplate.Controls.Add(this.labelTextControl7);
            this.tabTemplate.Controls.Add(this.labelTextControl6);
            this.tabTemplate.Controls.Add(this.labelTextControl5);
            this.tabTemplate.Controls.Add(this.labelTextControl4);
            this.tabTemplate.Controls.Add(this.labelTextControl3);
            this.tabTemplate.Controls.Add(this.labelTextControl2);
            this.tabTemplate.Controls.Add(this.labelTextControl1);
            this.tabTemplate.Location = new System.Drawing.Point(4, 35);
            this.tabTemplate.Name = "tabTemplate";
            this.tabTemplate.Size = new System.Drawing.Size(933, 588);
            this.tabTemplate.TabIndex = 4;
            this.tabTemplate.Text = "テンプレート設定";
            // 
            // btnLoadTmp
            // 
            this.btnLoadTmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadTmp.Location = new System.Drawing.Point(468, 550);
            this.btnLoadTmp.Name = "btnLoadTmp";
            this.btnLoadTmp.Size = new System.Drawing.Size(111, 34);
            this.btnLoadTmp.TabIndex = 15;
            this.btnLoadTmp.Text = "設定読込み";
            this.btnLoadTmp.UseVisualStyleBackColor = true;
            this.btnLoadTmp.Click += new System.EventHandler(this.btnLoadTmp_Click);
            // 
            // btnSaveTmp
            // 
            this.btnSaveTmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveTmp.Location = new System.Drawing.Point(355, 550);
            this.btnSaveTmp.Name = "btnSaveTmp";
            this.btnSaveTmp.Size = new System.Drawing.Size(90, 34);
            this.btnSaveTmp.TabIndex = 14;
            this.btnSaveTmp.Text = "設定保存";
            this.btnSaveTmp.UseVisualStyleBackColor = true;
            this.btnSaveTmp.Click += new System.EventHandler(this.btnSaveTmp_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlTop.Controls.Add(this.dateTimePicker1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(944, 66);
            this.pnlTop.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.CustomFormat = "★  yyyy年 MM月 dd日  ★";
            this.dateTimePicker1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(359, 11);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 30);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // labelTextControl14
            // 
            this.labelTextControl14.AutoSize = true;
            this.labelTextControl14.Location = new System.Drawing.Point(23, 505);
            this.labelTextControl14.Margin = new System.Windows.Forms.Padding(32, 148, 32, 148);
            this.labelTextControl14.Name = "labelTextControl14";
            this.labelTextControl14.Size = new System.Drawing.Size(885, 31);
            this.labelTextControl14.TabIndex = 13;
            // 
            // labelTextControl13
            // 
            this.labelTextControl13.AutoSize = true;
            this.labelTextControl13.Location = new System.Drawing.Point(23, 456);
            this.labelTextControl13.Margin = new System.Windows.Forms.Padding(32, 148, 32, 148);
            this.labelTextControl13.Name = "labelTextControl13";
            this.labelTextControl13.Size = new System.Drawing.Size(885, 31);
            this.labelTextControl13.TabIndex = 12;
            // 
            // labelTextControl12
            // 
            this.labelTextControl12.AutoSize = true;
            this.labelTextControl12.Location = new System.Drawing.Point(23, 407);
            this.labelTextControl12.Margin = new System.Windows.Forms.Padding(21, 77, 21, 77);
            this.labelTextControl12.Name = "labelTextControl12";
            this.labelTextControl12.Size = new System.Drawing.Size(885, 31);
            this.labelTextControl12.TabIndex = 11;
            // 
            // labelTextControl11
            // 
            this.labelTextControl11.AutoSize = true;
            this.labelTextControl11.Location = new System.Drawing.Point(23, 358);
            this.labelTextControl11.Margin = new System.Windows.Forms.Padding(21, 77, 21, 77);
            this.labelTextControl11.Name = "labelTextControl11";
            this.labelTextControl11.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl11.TabIndex = 10;
            // 
            // labelTextControl10
            // 
            this.labelTextControl10.AutoSize = true;
            this.labelTextControl10.Location = new System.Drawing.Point(399, 309);
            this.labelTextControl10.Margin = new System.Windows.Forms.Padding(14, 40, 14, 40);
            this.labelTextControl10.Name = "labelTextControl10";
            this.labelTextControl10.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl10.TabIndex = 9;
            this.labelTextControl10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // labelTextControl9
            // 
            this.labelTextControl9.AutoSize = true;
            this.labelTextControl9.Location = new System.Drawing.Point(23, 309);
            this.labelTextControl9.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.labelTextControl9.Name = "labelTextControl9";
            this.labelTextControl9.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl9.TabIndex = 8;
            // 
            // labelTextControl8
            // 
            this.labelTextControl8.AutoSize = true;
            this.labelTextControl8.Location = new System.Drawing.Point(23, 260);
            this.labelTextControl8.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.labelTextControl8.Name = "labelTextControl8";
            this.labelTextControl8.Size = new System.Drawing.Size(885, 31);
            this.labelTextControl8.TabIndex = 7;
            // 
            // labelTextControl7
            // 
            this.labelTextControl7.AutoSize = true;
            this.labelTextControl7.Location = new System.Drawing.Point(23, 211);
            this.labelTextControl7.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.labelTextControl7.Name = "labelTextControl7";
            this.labelTextControl7.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl7.TabIndex = 6;
            this.labelTextControl7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // labelTextControl6
            // 
            this.labelTextControl6.AutoSize = true;
            this.labelTextControl6.Location = new System.Drawing.Point(23, 162);
            this.labelTextControl6.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.labelTextControl6.Name = "labelTextControl6";
            this.labelTextControl6.Size = new System.Drawing.Size(885, 31);
            this.labelTextControl6.TabIndex = 5;
            // 
            // labelTextControl5
            // 
            this.labelTextControl5.AutoSize = true;
            this.labelTextControl5.Location = new System.Drawing.Point(399, 113);
            this.labelTextControl5.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.labelTextControl5.Name = "labelTextControl5";
            this.labelTextControl5.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl5.TabIndex = 4;
            // 
            // labelTextControl4
            // 
            this.labelTextControl4.AutoSize = true;
            this.labelTextControl4.Location = new System.Drawing.Point(23, 113);
            this.labelTextControl4.Margin = new System.Windows.Forms.Padding(9, 21, 9, 21);
            this.labelTextControl4.Name = "labelTextControl4";
            this.labelTextControl4.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl4.TabIndex = 3;
            this.labelTextControl4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // labelTextControl3
            // 
            this.labelTextControl3.AutoSize = true;
            this.labelTextControl3.Location = new System.Drawing.Point(399, 64);
            this.labelTextControl3.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.labelTextControl3.Name = "labelTextControl3";
            this.labelTextControl3.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl3.TabIndex = 2;
            // 
            // labelTextControl2
            // 
            this.labelTextControl2.AutoSize = true;
            this.labelTextControl2.Location = new System.Drawing.Point(23, 64);
            this.labelTextControl2.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.labelTextControl2.Name = "labelTextControl2";
            this.labelTextControl2.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl2.TabIndex = 1;
            // 
            // labelTextControl1
            // 
            this.labelTextControl1.AutoSize = true;
            this.labelTextControl1.Location = new System.Drawing.Point(23, 15);
            this.labelTextControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.labelTextControl1.Name = "labelTextControl1";
            this.labelTextControl1.Size = new System.Drawing.Size(353, 31);
            this.labelTextControl1.TabIndex = 0;
            this.labelTextControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 727);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlFill);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(960, 765);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "《保守サービス報告書》";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFill.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabAccept.ResumeLayout(false);
            this.tabAccept.PerformLayout();
            this.CmbMenuStrip.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabProcInfo.ResumeLayout(false);
            this.tabProcInfo.PerformLayout();
            this.tabPdfInfo.ResumeLayout(false);
            this.tabPdfInfo.PerformLayout();
            this.tabDataBase.ResumeLayout(false);
            this.tabDataBase.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.tabTemplate.ResumeLayout(false);
            this.tabTemplate.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAccept;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TextBox txtReceptNum1;
        private System.Windows.Forms.Label lblACCEPTID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRecvDay;
        private System.Windows.Forms.Label lblACCEPTDAY;
        private System.Windows.Forms.ComboBox txtPost;
        private System.Windows.Forms.Label lblPOST;
        private System.Windows.Forms.ComboBox txtArea;
        private System.Windows.Forms.Label lblAREA;
        private System.Windows.Forms.TextBox txtSymptom;
        private System.Windows.Forms.Label lblSYMPTOM;
        private System.Windows.Forms.TextBox txtSystName;
        private System.Windows.Forms.Label lblSYSTEM;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.Button btnToClipboard;
        private System.Windows.Forms.TextBox txtOutData;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
//        private KenkeiHosyuDataSet kenkeiHosyuDataSet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabDataBase;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DomainUpDown txtReceptNum2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabProcInfo;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Label lblREPORT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinuteProc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTimeProc;
        private System.Windows.Forms.TextBox txtDayProc;
        private System.Windows.Forms.Label lblDAYPROC;
        private System.Windows.Forms.TabPage tabPdfInfo;
        private System.Windows.Forms.CheckBox chkComplete;
        private System.Windows.Forms.Button btnCopy2;
        private System.Windows.Forms.TextBox txtProc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtInputsPdf;
        private System.Windows.Forms.TextBox txtCause;
        private System.Windows.Forms.ComboBox txtCharger;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblINPUTSPDF;
        private System.Windows.Forms.Label lblPROCPDF;
        private System.Windows.Forms.Label lblCAUSEPDF;
        private System.Windows.Forms.Label lblCHARGER;
        private System.Windows.Forms.Label lblDAYPDF;
        private System.Windows.Forms.Button btnCopy1;
        private System.Windows.Forms.ComboBox txtInputsProc;
        private System.Windows.Forms.Label lblINPUTSPROC;
        private System.Windows.Forms.ContextMenuStrip CmbMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddTsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyTsMenuItem;
        private System.Windows.Forms.Button btnAddProc;
        private System.Windows.Forms.Button btnAddPdf;
//        private KenkeiHosyuDataSetTableAdapters.AcceptTblTableAdapter acceptTblTableAdapter;
        private System.Windows.Forms.CheckBox chkFlgComp;
        private System.Windows.Forms.TextBox txtFilterInputs;
        private System.Windows.Forms.CheckBox chkInputs;
        private System.Windows.Forms.CheckBox chkCharger;
        private System.Windows.Forms.TextBox txtFilterCharger;
        private System.Windows.Forms.CheckBox chkSymptom;
        private System.Windows.Forms.TextBox txtFilterSymptom;
        private System.Windows.Forms.CheckBox chkSysname;
        private System.Windows.Forms.TextBox txtFilterSysname;
        private System.Windows.Forms.TextBox txtFilterPost;
        private System.Windows.Forms.CheckBox chkPost;
        private System.Windows.Forms.CheckBox chkArea;
        private System.Windows.Forms.TextBox txtFilterArea;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.TextBox txtFilterDate;
        private System.Windows.Forms.Label lblOUTDATA;
        private System.Windows.Forms.TabPage tabTemplate;
        private LabelTextControl labelTextControl12;
        private LabelTextControl labelTextControl11;
        private LabelTextControl labelTextControl10;
        private LabelTextControl labelTextControl9;
        private LabelTextControl labelTextControl8;
        private LabelTextControl labelTextControl7;
        private LabelTextControl labelTextControl6;
        private LabelTextControl labelTextControl5;
        private LabelTextControl labelTextControl4;
        private LabelTextControl labelTextControl3;
        private LabelTextControl labelTextControl2;
        private LabelTextControl labelTextControl1;
        private LabelTextControl labelTextControl13;
        private LabelTextControl labelTextControl14;
        private System.Windows.Forms.Button btnLoadTmp;
        private System.Windows.Forms.Button btnSaveTmp;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblProcInfo;
        private System.Windows.Forms.Label lblPdfInfo;
        private System.Windows.Forms.DomainUpDown domainFilterID;
        private System.Windows.Forms.CheckBox chkDomID;
        private System.Windows.Forms.Button btnRunAcrobat;
        private System.Windows.Forms.Button btnBrowseAccess;
        private System.Windows.Forms.TextBox txtAccessDbf;
        private System.Windows.Forms.Label lblAccLocation;
        private System.Windows.Forms.Button btnDownloadPost;
        private System.Windows.Forms.Button btnUploadPost;
        private System.Windows.Forms.Button btnDownloadArea;
        private System.Windows.Forms.Button btnUploadArea;
    }
}

