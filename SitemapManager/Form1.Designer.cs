namespace SitemapManager
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvResults = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnApplyFiltered = new System.Windows.Forms.Button();
            this.btnApplyAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPriority = new System.Windows.Forms.TrackBar();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.dtpLastModified = new System.Windows.Forms.DateTimePicker();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpFiltering = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkFilterPriorityAt = new System.Windows.Forms.CheckBox();
            this.rdbFilterPriorityHigherThan = new System.Windows.Forms.RadioButton();
            this.rdbFilterPriorityLowerThan = new System.Windows.Forms.RadioButton();
            this.rdbFilterPriorityExactValue = new System.Windows.Forms.RadioButton();
            this.tbFilterPriority = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFilterPriority = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbFilterChangeFrequency = new System.Windows.Forms.ComboBox();
            this.rdbFilterChangeFrequencyEverythingButThis = new System.Windows.Forms.RadioButton();
            this.rdbFilterChangeFrequencyOnlyThis = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFilterModificationDateAt = new System.Windows.Forms.CheckBox();
            this.dtpFilterModificationDate = new System.Windows.Forms.DateTimePicker();
            this.rdbFilterModificationDateAfter = new System.Windows.Forms.RadioButton();
            this.rdbFilterModificationDateBefore = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbFilterModificationDateExact = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbFilterUrlEndsWith = new System.Windows.Forms.RadioButton();
            this.rdbFilterUrlContains = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbFilterUrlStartsWith = new System.Windows.Forms.RadioButton();
            this.txtFilterUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFilterPriority = new System.Windows.Forms.CheckBox();
            this.chkFilterFrequency = new System.Windows.Forms.CheckBox();
            this.chkFilterModificationDate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFilterUrl = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSitemapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityhighLowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prioritylowHighToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityhighLowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPriority)).BeginInit();
            this.tpFiltering.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFilterPriority)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 360);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvResults);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 360);
            this.panel2.TabIndex = 2;
            // 
            // tvResults
            // 
            this.tvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvResults.Location = new System.Drawing.Point(0, 0);
            this.tvResults.Name = "tvResults";
            this.tvResults.Size = new System.Drawing.Size(405, 360);
            this.tvResults.TabIndex = 3;
            this.tvResults.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvResults_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpFiltering);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(408, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 360);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnApplyFiltered);
            this.tabPage1.Controls.Add(this.btnApplyAll);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.tbPriority);
            this.tabPage1.Controls.Add(this.cmbFrequency);
            this.tabPage1.Controls.Add(this.dtpLastModified);
            this.tabPage1.Controls.Add(this.txtUrl);
            this.tabPage1.Controls.Add(this.lblPriority);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnApplyFiltered
            // 
            this.btnApplyFiltered.Enabled = false;
            this.btnApplyFiltered.Location = new System.Drawing.Point(239, 198);
            this.btnApplyFiltered.Name = "btnApplyFiltered";
            this.btnApplyFiltered.Size = new System.Drawing.Size(117, 30);
            this.btnApplyFiltered.TabIndex = 25;
            this.btnApplyFiltered.Text = "Apply to &Filtered";
            this.btnApplyFiltered.UseVisualStyleBackColor = true;
            // 
            // btnApplyAll
            // 
            this.btnApplyAll.Location = new System.Drawing.Point(117, 198);
            this.btnApplyAll.Name = "btnApplyAll";
            this.btnApplyAll.Size = new System.Drawing.Size(116, 30);
            this.btnApplyAll.TabIndex = 24;
            this.btnApplyAll.Text = "A&pply to all";
            this.btnApplyAll.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 33);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(198, 160);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 32);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "&Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPriority
            // 
            this.tbPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPriority.Location = new System.Drawing.Point(117, 108);
            this.tbPriority.Minimum = 1;
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(244, 45);
            this.tbPriority.TabIndex = 20;
            this.tbPriority.Value = 1;
            this.tbPriority.ValueChanged += new System.EventHandler(this.tbPriority_ValueChanged_1);
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Location = new System.Drawing.Point(117, 81);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(244, 21);
            this.cmbFrequency.TabIndex = 19;
            // 
            // dtpLastModified
            // 
            this.dtpLastModified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpLastModified.Location = new System.Drawing.Point(117, 51);
            this.dtpLastModified.Name = "dtpLastModified";
            this.dtpLastModified.Size = new System.Drawing.Size(244, 20);
            this.dtpLastModified.TabIndex = 18;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(117, 24);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(244, 20);
            this.txtUrl.TabIndex = 17;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(3, 118);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(53, 13);
            this.lblPriority.TabIndex = 16;
            this.lblPriority.Text = "Priority (0)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Change frequency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Last Modified";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Url";
            // 
            // tpFiltering
            // 
            this.tpFiltering.AutoScroll = true;
            this.tpFiltering.Controls.Add(this.groupBox5);
            this.tpFiltering.Controls.Add(this.groupBox4);
            this.tpFiltering.Controls.Add(this.groupBox3);
            this.tpFiltering.Controls.Add(this.groupBox2);
            this.tpFiltering.Controls.Add(this.groupBox1);
            this.tpFiltering.Location = new System.Drawing.Point(4, 22);
            this.tpFiltering.Name = "tpFiltering";
            this.tpFiltering.Size = new System.Drawing.Size(362, 334);
            this.tpFiltering.TabIndex = 1;
            this.tpFiltering.Text = "Filtering";
            this.tpFiltering.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkFilterPriorityAt);
            this.groupBox5.Controls.Add(this.rdbFilterPriorityHigherThan);
            this.groupBox5.Controls.Add(this.rdbFilterPriorityLowerThan);
            this.groupBox5.Controls.Add(this.rdbFilterPriorityExactValue);
            this.groupBox5.Controls.Add(this.tbFilterPriority);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.lblFilterPriority);
            this.groupBox5.Location = new System.Drawing.Point(4, 356);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 117);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Priority filtering";
            // 
            // chkFilterPriorityAt
            // 
            this.chkFilterPriorityAt.AutoSize = true;
            this.chkFilterPriorityAt.Location = new System.Drawing.Point(272, 66);
            this.chkFilterPriorityAt.Name = "chkFilterPriorityAt";
            this.chkFilterPriorityAt.Size = new System.Drawing.Size(36, 17);
            this.chkFilterPriorityAt.TabIndex = 25;
            this.chkFilterPriorityAt.Text = "At";
            this.chkFilterPriorityAt.UseVisualStyleBackColor = true;
            this.chkFilterPriorityAt.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // rdbFilterPriorityHigherThan
            // 
            this.rdbFilterPriorityHigherThan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFilterPriorityHigherThan.AutoSize = true;
            this.rdbFilterPriorityHigherThan.Location = new System.Drawing.Point(159, 66);
            this.rdbFilterPriorityHigherThan.Name = "rdbFilterPriorityHigherThan";
            this.rdbFilterPriorityHigherThan.Size = new System.Drawing.Size(80, 17);
            this.rdbFilterPriorityHigherThan.TabIndex = 24;
            this.rdbFilterPriorityHigherThan.TabStop = true;
            this.rdbFilterPriorityHigherThan.Text = "Higher than";
            this.rdbFilterPriorityHigherThan.UseVisualStyleBackColor = true;
            this.rdbFilterPriorityHigherThan.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // rdbFilterPriorityLowerThan
            // 
            this.rdbFilterPriorityLowerThan.AutoSize = true;
            this.rdbFilterPriorityLowerThan.Location = new System.Drawing.Point(75, 66);
            this.rdbFilterPriorityLowerThan.Name = "rdbFilterPriorityLowerThan";
            this.rdbFilterPriorityLowerThan.Size = new System.Drawing.Size(78, 17);
            this.rdbFilterPriorityLowerThan.TabIndex = 23;
            this.rdbFilterPriorityLowerThan.TabStop = true;
            this.rdbFilterPriorityLowerThan.Text = "Lower than";
            this.rdbFilterPriorityLowerThan.UseVisualStyleBackColor = true;
            this.rdbFilterPriorityLowerThan.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // rdbFilterPriorityExactValue
            // 
            this.rdbFilterPriorityExactValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFilterPriorityExactValue.AutoSize = true;
            this.rdbFilterPriorityExactValue.Location = new System.Drawing.Point(75, 89);
            this.rdbFilterPriorityExactValue.Name = "rdbFilterPriorityExactValue";
            this.rdbFilterPriorityExactValue.Size = new System.Drawing.Size(65, 17);
            this.rdbFilterPriorityExactValue.TabIndex = 22;
            this.rdbFilterPriorityExactValue.TabStop = true;
            this.rdbFilterPriorityExactValue.Text = "Only this";
            this.rdbFilterPriorityExactValue.UseVisualStyleBackColor = true;
            this.rdbFilterPriorityExactValue.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // tbFilterPriority
            // 
            this.tbFilterPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterPriority.Location = new System.Drawing.Point(75, 15);
            this.tbFilterPriority.Minimum = 1;
            this.tbFilterPriority.Name = "tbFilterPriority";
            this.tbFilterPriority.Size = new System.Drawing.Size(233, 45);
            this.tbFilterPriority.TabIndex = 21;
            this.tbFilterPriority.Value = 1;
            this.tbFilterPriority.ValueChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Rules";
            // 
            // lblFilterPriority
            // 
            this.lblFilterPriority.AutoSize = true;
            this.lblFilterPriority.Location = new System.Drawing.Point(6, 32);
            this.lblFilterPriority.Name = "lblFilterPriority";
            this.lblFilterPriority.Size = new System.Drawing.Size(38, 13);
            this.lblFilterPriority.TabIndex = 0;
            this.lblFilterPriority.Text = "Priority";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbFilterChangeFrequency);
            this.groupBox4.Controls.Add(this.rdbFilterChangeFrequencyEverythingButThis);
            this.groupBox4.Controls.Add(this.rdbFilterChangeFrequencyOnlyThis);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(4, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 77);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Change frequency filtering";
            // 
            // cmbFilterChangeFrequency
            // 
            this.cmbFilterChangeFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterChangeFrequency.FormattingEnabled = true;
            this.cmbFilterChangeFrequency.Location = new System.Drawing.Point(75, 17);
            this.cmbFilterChangeFrequency.Name = "cmbFilterChangeFrequency";
            this.cmbFilterChangeFrequency.Size = new System.Drawing.Size(233, 21);
            this.cmbFilterChangeFrequency.TabIndex = 20;
            this.cmbFilterChangeFrequency.SelectedValueChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // rdbFilterChangeFrequencyEverythingButThis
            // 
            this.rdbFilterChangeFrequencyEverythingButThis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFilterChangeFrequencyEverythingButThis.AutoSize = true;
            this.rdbFilterChangeFrequencyEverythingButThis.Location = new System.Drawing.Point(196, 43);
            this.rdbFilterChangeFrequencyEverythingButThis.Name = "rdbFilterChangeFrequencyEverythingButThis";
            this.rdbFilterChangeFrequencyEverythingButThis.Size = new System.Drawing.Size(112, 17);
            this.rdbFilterChangeFrequencyEverythingButThis.TabIndex = 4;
            this.rdbFilterChangeFrequencyEverythingButThis.TabStop = true;
            this.rdbFilterChangeFrequencyEverythingButThis.Text = "Everything but this";
            this.rdbFilterChangeFrequencyEverythingButThis.UseVisualStyleBackColor = true;
            this.rdbFilterChangeFrequencyEverythingButThis.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // rdbFilterChangeFrequencyOnlyThis
            // 
            this.rdbFilterChangeFrequencyOnlyThis.AutoSize = true;
            this.rdbFilterChangeFrequencyOnlyThis.Location = new System.Drawing.Point(75, 43);
            this.rdbFilterChangeFrequencyOnlyThis.Name = "rdbFilterChangeFrequencyOnlyThis";
            this.rdbFilterChangeFrequencyOnlyThis.Size = new System.Drawing.Size(65, 17);
            this.rdbFilterChangeFrequencyOnlyThis.TabIndex = 3;
            this.rdbFilterChangeFrequencyOnlyThis.TabStop = true;
            this.rdbFilterChangeFrequencyOnlyThis.Text = "Only this";
            this.rdbFilterChangeFrequencyOnlyThis.UseVisualStyleBackColor = true;
            this.rdbFilterChangeFrequencyOnlyThis.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Rules:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Frequency";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFilterModificationDateAt);
            this.groupBox3.Controls.Add(this.dtpFilterModificationDate);
            this.groupBox3.Controls.Add(this.rdbFilterModificationDateAfter);
            this.groupBox3.Controls.Add(this.rdbFilterModificationDateBefore);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rdbFilterModificationDateExact);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(4, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 94);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modification date filtering";
            // 
            // chkFilterModificationDateAt
            // 
            this.chkFilterModificationDateAt.AutoSize = true;
            this.chkFilterModificationDateAt.Location = new System.Drawing.Point(272, 41);
            this.chkFilterModificationDateAt.Name = "chkFilterModificationDateAt";
            this.chkFilterModificationDateAt.Size = new System.Drawing.Size(36, 17);
            this.chkFilterModificationDateAt.TabIndex = 6;
            this.chkFilterModificationDateAt.Text = "At";
            this.chkFilterModificationDateAt.UseVisualStyleBackColor = true;
            this.chkFilterModificationDateAt.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // dtpFilterModificationDate
            // 
            this.dtpFilterModificationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterModificationDate.Location = new System.Drawing.Point(75, 17);
            this.dtpFilterModificationDate.Name = "dtpFilterModificationDate";
            this.dtpFilterModificationDate.Size = new System.Drawing.Size(233, 20);
            this.dtpFilterModificationDate.TabIndex = 5;
            this.dtpFilterModificationDate.ValueChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // rdbFilterModificationDateAfter
            // 
            this.rdbFilterModificationDateAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFilterModificationDateAfter.AutoSize = true;
            this.rdbFilterModificationDateAfter.Location = new System.Drawing.Point(151, 43);
            this.rdbFilterModificationDateAfter.Name = "rdbFilterModificationDateAfter";
            this.rdbFilterModificationDateAfter.Size = new System.Drawing.Size(47, 17);
            this.rdbFilterModificationDateAfter.TabIndex = 4;
            this.rdbFilterModificationDateAfter.Text = "After";
            this.rdbFilterModificationDateAfter.UseVisualStyleBackColor = true;
            this.rdbFilterModificationDateAfter.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // rdbFilterModificationDateBefore
            // 
            this.rdbFilterModificationDateBefore.AutoSize = true;
            this.rdbFilterModificationDateBefore.Location = new System.Drawing.Point(75, 43);
            this.rdbFilterModificationDateBefore.Name = "rdbFilterModificationDateBefore";
            this.rdbFilterModificationDateBefore.Size = new System.Drawing.Size(56, 17);
            this.rdbFilterModificationDateBefore.TabIndex = 3;
            this.rdbFilterModificationDateBefore.Text = "Before";
            this.rdbFilterModificationDateBefore.UseVisualStyleBackColor = true;
            this.rdbFilterModificationDateBefore.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rules";
            // 
            // rdbFilterModificationDateExact
            // 
            this.rdbFilterModificationDateExact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFilterModificationDateExact.AutoSize = true;
            this.rdbFilterModificationDateExact.Location = new System.Drawing.Point(75, 66);
            this.rdbFilterModificationDateExact.Name = "rdbFilterModificationDateExact";
            this.rdbFilterModificationDateExact.Size = new System.Drawing.Size(65, 17);
            this.rdbFilterModificationDateExact.TabIndex = 2;
            this.rdbFilterModificationDateExact.Text = "Only this";
            this.rdbFilterModificationDateExact.UseVisualStyleBackColor = true;
            this.rdbFilterModificationDateExact.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbFilterUrlEndsWith);
            this.groupBox2.Controls.Add(this.rdbFilterUrlContains);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdbFilterUrlStartsWith);
            this.groupBox2.Controls.Add(this.txtFilterUrl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Url filtering";
            // 
            // rdbFilterUrlEndsWith
            // 
            this.rdbFilterUrlEndsWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFilterUrlEndsWith.AutoSize = true;
            this.rdbFilterUrlEndsWith.Location = new System.Drawing.Point(237, 43);
            this.rdbFilterUrlEndsWith.Name = "rdbFilterUrlEndsWith";
            this.rdbFilterUrlEndsWith.Size = new System.Drawing.Size(71, 17);
            this.rdbFilterUrlEndsWith.TabIndex = 4;
            this.rdbFilterUrlEndsWith.Text = "Ends with";
            this.rdbFilterUrlEndsWith.UseVisualStyleBackColor = true;
            this.rdbFilterUrlEndsWith.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // rdbFilterUrlContains
            // 
            this.rdbFilterUrlContains.AutoSize = true;
            this.rdbFilterUrlContains.Checked = true;
            this.rdbFilterUrlContains.Location = new System.Drawing.Point(75, 43);
            this.rdbFilterUrlContains.Name = "rdbFilterUrlContains";
            this.rdbFilterUrlContains.Size = new System.Drawing.Size(66, 17);
            this.rdbFilterUrlContains.TabIndex = 3;
            this.rdbFilterUrlContains.TabStop = true;
            this.rdbFilterUrlContains.Text = "Contains";
            this.rdbFilterUrlContains.UseVisualStyleBackColor = true;
            this.rdbFilterUrlContains.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rules";
            // 
            // rdbFilterUrlStartsWith
            // 
            this.rdbFilterUrlStartsWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbFilterUrlStartsWith.AutoSize = true;
            this.rdbFilterUrlStartsWith.Location = new System.Drawing.Point(151, 43);
            this.rdbFilterUrlStartsWith.Name = "rdbFilterUrlStartsWith";
            this.rdbFilterUrlStartsWith.Size = new System.Drawing.Size(74, 17);
            this.rdbFilterUrlStartsWith.TabIndex = 2;
            this.rdbFilterUrlStartsWith.Text = "Starts with";
            this.rdbFilterUrlStartsWith.UseVisualStyleBackColor = true;
            this.rdbFilterUrlStartsWith.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // txtFilterUrl
            // 
            this.txtFilterUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterUrl.Location = new System.Drawing.Point(75, 17);
            this.txtFilterUrl.Name = "txtFilterUrl";
            this.txtFilterUrl.Size = new System.Drawing.Size(233, 20);
            this.txtFilterUrl.TabIndex = 1;
            this.txtFilterUrl.TextChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search for";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFilterPriority);
            this.groupBox1.Controls.Add(this.chkFilterFrequency);
            this.groupBox1.Controls.Add(this.chkFilterModificationDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkFilterUrl);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering";
            // 
            // chkFilterPriority
            // 
            this.chkFilterPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilterPriority.AutoSize = true;
            this.chkFilterPriority.Location = new System.Drawing.Point(201, 56);
            this.chkFilterPriority.Name = "chkFilterPriority";
            this.chkFilterPriority.Size = new System.Drawing.Size(57, 17);
            this.chkFilterPriority.TabIndex = 4;
            this.chkFilterPriority.Text = "Priority";
            this.chkFilterPriority.UseVisualStyleBackColor = true;
            this.chkFilterPriority.Click += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // chkFilterFrequency
            // 
            this.chkFilterFrequency.AutoSize = true;
            this.chkFilterFrequency.Location = new System.Drawing.Point(6, 56);
            this.chkFilterFrequency.Name = "chkFilterFrequency";
            this.chkFilterFrequency.Size = new System.Drawing.Size(113, 17);
            this.chkFilterFrequency.TabIndex = 3;
            this.chkFilterFrequency.Text = "Change frequency";
            this.chkFilterFrequency.UseVisualStyleBackColor = true;
            this.chkFilterFrequency.Click += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // chkFilterModificationDate
            // 
            this.chkFilterModificationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFilterModificationDate.AutoSize = true;
            this.chkFilterModificationDate.Location = new System.Drawing.Point(201, 35);
            this.chkFilterModificationDate.Name = "chkFilterModificationDate";
            this.chkFilterModificationDate.Size = new System.Drawing.Size(107, 17);
            this.chkFilterModificationDate.TabIndex = 2;
            this.chkFilterModificationDate.Text = "Modification date";
            this.chkFilterModificationDate.UseVisualStyleBackColor = true;
            this.chkFilterModificationDate.Click += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose what to apply the filtering rules to...";
            // 
            // chkFilterUrl
            // 
            this.chkFilterUrl.AutoSize = true;
            this.chkFilterUrl.Location = new System.Drawing.Point(6, 35);
            this.chkFilterUrl.Name = "chkFilterUrl";
            this.chkFilterUrl.Size = new System.Drawing.Size(66, 17);
            this.chkFilterUrl.TabIndex = 0;
            this.chkFilterUrl.Text = "Url (Loc)";
            this.chkFilterUrl.UseVisualStyleBackColor = true;
            this.chkFilterUrl.CheckedChanged += new System.EventHandler(this.chkFilterUrl_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 360);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSitemapToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadSitemapToolStripMenuItem
            // 
            this.loadSitemapToolStripMenuItem.Name = "loadSitemapToolStripMenuItem";
            this.loadSitemapToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loadSitemapToolStripMenuItem.Text = "&Load Sitemap";
            this.loadSitemapToolStripMenuItem.Click += new System.EventHandler(this.loadSitemapToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderByToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urlToolStripMenuItem,
            this.priorityhighLowToolStripMenuItem});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.orderByToolStripMenuItem.Text = "Order by";
            // 
            // urlToolStripMenuItem
            // 
            this.urlToolStripMenuItem.Name = "urlToolStripMenuItem";
            this.urlToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.urlToolStripMenuItem.Text = "Url";
            this.urlToolStripMenuItem.Click += new System.EventHandler(this.urlToolStripMenuItem_Click);
            // 
            // priorityhighLowToolStripMenuItem
            // 
            this.priorityhighLowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prioritylowHighToolStripMenuItem,
            this.priorityhighLowToolStripMenuItem1});
            this.priorityhighLowToolStripMenuItem.Name = "priorityhighLowToolStripMenuItem";
            this.priorityhighLowToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.priorityhighLowToolStripMenuItem.Text = "Priority";
            // 
            // prioritylowHighToolStripMenuItem
            // 
            this.prioritylowHighToolStripMenuItem.Name = "prioritylowHighToolStripMenuItem";
            this.prioritylowHighToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prioritylowHighToolStripMenuItem.Text = "Priority (low > high)";
            this.prioritylowHighToolStripMenuItem.Click += new System.EventHandler(this.prioritylowHighToolStripMenuItem_Click);
            // 
            // priorityhighLowToolStripMenuItem1
            // 
            this.priorityhighLowToolStripMenuItem1.Name = "priorityhighLowToolStripMenuItem1";
            this.priorityhighLowToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.priorityhighLowToolStripMenuItem1.Text = "Priority (high > low)";
            this.priorityhighLowToolStripMenuItem1.Click += new System.EventHandler(this.priorityhighLowToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPriority)).EndInit();
            this.tpFiltering.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFilterPriority)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar tbPriority;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.DateTimePicker dtpLastModified;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSitemapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priorityhighLowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prioritylowHighToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priorityhighLowToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnApplyFiltered;
        private System.Windows.Forms.Button btnApplyAll;
        private System.Windows.Forms.TabPage tpFiltering;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbFilterUrlEndsWith;
        private System.Windows.Forms.RadioButton rdbFilterUrlContains;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbFilterUrlStartsWith;
        private System.Windows.Forms.TextBox txtFilterUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkFilterPriority;
        private System.Windows.Forms.CheckBox chkFilterFrequency;
        private System.Windows.Forms.CheckBox chkFilterModificationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFilterUrl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFilterModificationDate;
        private System.Windows.Forms.RadioButton rdbFilterModificationDateAfter;
        private System.Windows.Forms.RadioButton rdbFilterModificationDateBefore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbFilterModificationDateExact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbFilterChangeFrequency;
        private System.Windows.Forms.RadioButton rdbFilterChangeFrequencyEverythingButThis;
        private System.Windows.Forms.RadioButton rdbFilterChangeFrequencyOnlyThis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdbFilterPriorityHigherThan;
        private System.Windows.Forms.RadioButton rdbFilterPriorityLowerThan;
        private System.Windows.Forms.RadioButton rdbFilterPriorityExactValue;
        private System.Windows.Forms.TrackBar tbFilterPriority;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFilterPriority;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvResults;
        private System.Windows.Forms.CheckBox chkFilterPriorityAt;
        private System.Windows.Forms.CheckBox chkFilterModificationDateAt;
    }
}

