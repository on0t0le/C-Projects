namespace MelodyGuess
{
    partial class FSet
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bClrList = new System.Windows.Forms.Button();
            this.cbDirectories = new System.Windows.Forms.CheckBox();
            this.bOk = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPl2 = new System.Windows.Forms.ComboBox();
            this.cbPl1 = new System.Windows.Forms.ComboBox();
            this.cbRandStart = new System.Windows.Forms.CheckBox();
            this.cbMusicTime = new System.Windows.Forms.ComboBox();
            this.cbGameTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 160);
            this.listBox1.TabIndex = 0;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(12, 170);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Add file";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bClrList
            // 
            this.bClrList.Location = new System.Drawing.Point(105, 170);
            this.bClrList.Name = "bClrList";
            this.bClrList.Size = new System.Drawing.Size(75, 23);
            this.bClrList.TabIndex = 2;
            this.bClrList.Text = "Clear list";
            this.bClrList.UseVisualStyleBackColor = true;
            this.bClrList.Click += new System.EventHandler(this.bClrList_Click);
            // 
            // cbDirectories
            // 
            this.cbDirectories.AutoSize = true;
            this.cbDirectories.Location = new System.Drawing.Point(192, 174);
            this.cbDirectories.Name = "cbDirectories";
            this.cbDirectories.Size = new System.Drawing.Size(84, 17);
            this.cbDirectories.TabIndex = 3;
            this.cbDirectories.Text = "Inner folders";
            this.cbDirectories.UseVisualStyleBackColor = true;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(12, 345);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 4;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(197, 345);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbPl2);
            this.groupBox1.Controls.Add(this.cbPl1);
            this.groupBox1.Controls.Add(this.cbRandStart);
            this.groupBox1.Controls.Add(this.cbMusicTime);
            this.groupBox1.Controls.Add(this.cbGameTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player 1";
            // 
            // cbPl2
            // 
            this.cbPl2.FormattingEnabled = true;
            this.cbPl2.Items.AddRange(new object[] {
            "P",
            "L",
            "Q",
            "A"});
            this.cbPl2.Location = new System.Drawing.Point(200, 49);
            this.cbPl2.Name = "cbPl2";
            this.cbPl2.Size = new System.Drawing.Size(54, 21);
            this.cbPl2.TabIndex = 6;
            this.cbPl2.Text = "P";
            // 
            // cbPl1
            // 
            this.cbPl1.FormattingEnabled = true;
            this.cbPl1.Items.AddRange(new object[] {
            "Q",
            "A",
            "P",
            "L"});
            this.cbPl1.Location = new System.Drawing.Point(200, 19);
            this.cbPl1.Name = "cbPl1";
            this.cbPl1.Size = new System.Drawing.Size(54, 21);
            this.cbPl1.TabIndex = 5;
            this.cbPl1.Text = "A";
            // 
            // cbRandStart
            // 
            this.cbRandStart.AutoSize = true;
            this.cbRandStart.Location = new System.Drawing.Point(165, 91);
            this.cbRandStart.Name = "cbRandStart";
            this.cbRandStart.Size = new System.Drawing.Size(89, 17);
            this.cbRandStart.TabIndex = 4;
            this.cbRandStart.Text = "Random start";
            this.cbRandStart.UseVisualStyleBackColor = true;
            // 
            // cbMusicTime
            // 
            this.cbMusicTime.FormattingEnabled = true;
            this.cbMusicTime.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.cbMusicTime.Location = new System.Drawing.Point(69, 54);
            this.cbMusicTime.Name = "cbMusicTime";
            this.cbMusicTime.Size = new System.Drawing.Size(44, 21);
            this.cbMusicTime.TabIndex = 3;
            this.cbMusicTime.Text = "10";
            // 
            // cbGameTime
            // 
            this.cbGameTime.FormattingEnabled = true;
            this.cbGameTime.Items.AddRange(new object[] {
            "10",
            "60",
            "120",
            "180",
            "240"});
            this.cbGameTime.Location = new System.Drawing.Point(73, 19);
            this.cbGameTime.Name = "cbGameTime";
            this.cbGameTime.Size = new System.Drawing.Size(44, 21);
            this.cbGameTime.TabIndex = 2;
            this.cbGameTime.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Round time";
            // 
            // FSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.cbDirectories);
            this.Controls.Add(this.bClrList);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.listBox1);
            this.Name = "FSet";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClrList;
        private System.Windows.Forms.CheckBox cbDirectories;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMusicTime;
        private System.Windows.Forms.ComboBox cbGameTime;
        private System.Windows.Forms.CheckBox cbRandStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPl2;
        private System.Windows.Forms.ComboBox cbPl1;
    }
}