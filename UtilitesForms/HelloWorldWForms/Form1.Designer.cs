namespace HelloWorldWForms
{
    partial class MainForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMetric = new System.Windows.Forms.ComboBox();
            this.bChange = new System.Windows.Forms.Button();
            this.valTo = new System.Windows.Forms.TextBox();
            this.valFrom = new System.Windows.Forms.TextBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.bConvert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bClrPass = new System.Windows.Forms.Button();
            this.bCopyPass = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.bGenPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passLenth = new System.Windows.Forms.NumericUpDown();
            this.clbPass = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lCounter = new System.Windows.Forms.Label();
            this.bReset = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.bCopy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lRandom = new System.Windows.Forms.Label();
            this.bGenerate = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passLenth)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.noteToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(298, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(92, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsDate,
            this.tsmiInsTime,
            this.toolStripMenuItem2,
            this.tsmiSave,
            this.tsmiOpen});
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.noteToolStripMenuItem.Text = "Note";
            // 
            // tsmiInsDate
            // 
            this.tsmiInsDate.Name = "tsmiInsDate";
            this.tsmiInsDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsDate.Size = new System.Drawing.Size(200, 22);
            this.tsmiInsDate.Text = "Type date";
            this.tsmiInsDate.Click += new System.EventHandler(this.tsmiInsDate_Click);
            // 
            // tsmiInsTime
            // 
            this.tsmiInsTime.Name = "tsmiInsTime";
            this.tsmiInsTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsTime.Size = new System.Drawing.Size(200, 22);
            this.tsmiInsTime.Text = "Type time";
            this.tsmiInsTime.Click += new System.EventHandler(this.tsmiInsTime_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(197, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(200, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(200, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(298, 238);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.cbMetric);
            this.tabPage5.Controls.Add(this.bChange);
            this.tabPage5.Controls.Add(this.valTo);
            this.tabPage5.Controls.Add(this.valFrom);
            this.tabPage5.Controls.Add(this.cbTo);
            this.tabPage5.Controls.Add(this.cbFrom);
            this.tabPage5.Controls.Add(this.bConvert);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(290, 212);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Converter";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Choose type";
            // 
            // cbMetric
            // 
            this.cbMetric.FormattingEnabled = true;
            this.cbMetric.Items.AddRange(new object[] {
            "Length",
            "Weight"});
            this.cbMetric.Location = new System.Drawing.Point(104, 37);
            this.cbMetric.Name = "cbMetric";
            this.cbMetric.Size = new System.Drawing.Size(75, 21);
            this.cbMetric.TabIndex = 5;
            this.cbMetric.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(104, 84);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(75, 23);
            this.bChange.TabIndex = 4;
            this.bChange.Text = "<------>";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // valTo
            // 
            this.valTo.Location = new System.Drawing.Point(202, 139);
            this.valTo.Name = "valTo";
            this.valTo.ReadOnly = true;
            this.valTo.Size = new System.Drawing.Size(80, 20);
            this.valTo.TabIndex = 3;
            // 
            // valFrom
            // 
            this.valFrom.Location = new System.Drawing.Point(3, 139);
            this.valFrom.Name = "valFrom";
            this.valFrom.Size = new System.Drawing.Size(79, 20);
            this.valFrom.TabIndex = 3;
            this.valFrom.Text = "1";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(202, 86);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(80, 21);
            this.cbTo.TabIndex = 2;
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(3, 86);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(79, 21);
            this.cbFrom.TabIndex = 2;
            // 
            // bConvert
            // 
            this.bConvert.Location = new System.Drawing.Point(104, 136);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(75, 23);
            this.bConvert.TabIndex = 1;
            this.bConvert.Text = "Convert";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "From";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bClrPass);
            this.tabPage4.Controls.Add(this.bCopyPass);
            this.tabPage4.Controls.Add(this.tbPass);
            this.tabPage4.Controls.Add(this.bGenPass);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.passLenth);
            this.tabPage4.Controls.Add(this.clbPass);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(290, 212);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PassGenerator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bClrPass
            // 
            this.bClrPass.Location = new System.Drawing.Point(193, 102);
            this.bClrPass.Name = "bClrPass";
            this.bClrPass.Size = new System.Drawing.Size(75, 23);
            this.bClrPass.TabIndex = 6;
            this.bClrPass.Text = "Clear";
            this.bClrPass.UseVisualStyleBackColor = true;
            this.bClrPass.Click += new System.EventHandler(this.bClrPass_Click);
            // 
            // bCopyPass
            // 
            this.bCopyPass.Location = new System.Drawing.Point(101, 102);
            this.bCopyPass.Name = "bCopyPass";
            this.bCopyPass.Size = new System.Drawing.Size(75, 23);
            this.bCopyPass.TabIndex = 5;
            this.bCopyPass.Text = "Copy";
            this.bCopyPass.UseVisualStyleBackColor = true;
            this.bCopyPass.Click += new System.EventHandler(this.bCopyPass_Click);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(9, 151);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(259, 20);
            this.tbPass.TabIndex = 4;
            // 
            // bGenPass
            // 
            this.bGenPass.Location = new System.Drawing.Point(9, 102);
            this.bGenPass.Name = "bGenPass";
            this.bGenPass.Size = new System.Drawing.Size(75, 23);
            this.bGenPass.TabIndex = 3;
            this.bGenPass.Text = "Generate";
            this.bGenPass.UseVisualStyleBackColor = true;
            this.bGenPass.Click += new System.EventHandler(this.bGenPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password length(char)";
            // 
            // passLenth
            // 
            this.passLenth.Location = new System.Drawing.Point(193, 32);
            this.passLenth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.passLenth.Name = "passLenth";
            this.passLenth.Size = new System.Drawing.Size(34, 20);
            this.passLenth.TabIndex = 1;
            this.passLenth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // clbPass
            // 
            this.clbPass.CheckOnClick = true;
            this.clbPass.FormattingEnabled = true;
            this.clbPass.Items.AddRange(new object[] {
            "Numbers",
            "Leters",
            "Big leters",
            "Special symbols % # $"});
            this.clbPass.Location = new System.Drawing.Point(9, 4);
            this.clbPass.Name = "clbPass";
            this.clbPass.Size = new System.Drawing.Size(132, 79);
            this.clbPass.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNote);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(290, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Note";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNote
            // 
            this.rtbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNote.Location = new System.Drawing.Point(0, 0);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(290, 212);
            this.rtbNote.TabIndex = 0;
            this.rtbNote.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lCounter);
            this.tabPage1.Controls.Add(this.bReset);
            this.tabPage1.Controls.Add(this.bMinus);
            this.tabPage1.Controls.Add(this.bPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(290, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Counter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lCounter
            // 
            this.lCounter.AutoSize = true;
            this.lCounter.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCounter.Location = new System.Drawing.Point(129, 42);
            this.lCounter.Name = "lCounter";
            this.lCounter.Size = new System.Drawing.Size(21, 24);
            this.lCounter.TabIndex = 3;
            this.lCounter.Text = "0";
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReset.Location = new System.Drawing.Point(101, 136);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 35);
            this.bReset.TabIndex = 2;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bMinus
            // 
            this.bMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMinus.Location = new System.Drawing.Point(175, 82);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(75, 35);
            this.bMinus.TabIndex = 1;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPlus.Location = new System.Drawing.Point(27, 82);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(75, 35);
            this.bPlus.TabIndex = 0;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbRandom);
            this.tabPage2.Controls.Add(this.bCopy);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tbRandom);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.lRandom);
            this.tabPage2.Controls.Add(this.bGenerate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(290, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(188, 27);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(78, 17);
            this.cbRandom.TabIndex = 9;
            this.cbRandom.Text = "No Repeat";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // bCopy
            // 
            this.bCopy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCopy.Location = new System.Drawing.Point(188, 61);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(82, 23);
            this.bCopy.TabIndex = 8;
            this.bCopy.Text = "Copy";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(106, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRandom.Location = new System.Drawing.Point(18, 86);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(82, 90);
            this.tbRandom.TabIndex = 6;
            this.tbRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(56, 59);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(56, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // lRandom
            // 
            this.lRandom.AutoSize = true;
            this.lRandom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRandom.Location = new System.Drawing.Point(161, 120);
            this.lRandom.Name = "lRandom";
            this.lRandom.Size = new System.Drawing.Size(21, 24);
            this.lRandom.TabIndex = 1;
            this.lRandom.Text = "0";
            this.lRandom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bGenerate
            // 
            this.bGenerate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bGenerate.Location = new System.Drawing.Point(106, 24);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(76, 20);
            this.bGenerate.TabIndex = 0;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "My utilits";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passLenth)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lCounter;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lRandom;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox clbPass;
        private System.Windows.Forms.Button bGenPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown passLenth;
        private System.Windows.Forms.Button bClrPass;
        private System.Windows.Forms.Button bCopyPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valTo;
        private System.Windows.Forms.TextBox valFrom;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.ComboBox cbMetric;
        private System.Windows.Forms.Label label8;
    }
}

