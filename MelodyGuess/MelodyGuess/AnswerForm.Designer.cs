namespace MelodyGuess
{
    partial class AnswerForm
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
            this.lMessage = new System.Windows.Forms.Label();
            this.bYes = new System.Windows.Forms.Button();
            this.bNo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lAnsTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Monotxt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.Location = new System.Drawing.Point(70, 19);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(135, 35);
            this.lMessage.TabIndex = 0;
            this.lMessage.Text = "label1";
            // 
            // bYes
            // 
            this.bYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bYes.Location = new System.Drawing.Point(12, 170);
            this.bYes.Name = "bYes";
            this.bYes.Size = new System.Drawing.Size(112, 55);
            this.bYes.TabIndex = 1;
            this.bYes.Text = "YES";
            this.bYes.UseVisualStyleBackColor = true;
            // 
            // bNo
            // 
            this.bNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bNo.Location = new System.Drawing.Point(160, 170);
            this.bNo.Name = "bNo";
            this.bNo.Size = new System.Drawing.Size(112, 55);
            this.bNo.TabIndex = 2;
            this.bNo.Text = "NO";
            this.bNo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lAnsTime
            // 
            this.lAnsTime.AutoSize = true;
            this.lAnsTime.Location = new System.Drawing.Point(134, 73);
            this.lAnsTime.Name = "lAnsTime";
            this.lAnsTime.Size = new System.Drawing.Size(13, 13);
            this.lAnsTime.TabIndex = 3;
            this.lAnsTime.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Show answer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lAnsTime);
            this.Controls.Add(this.bNo);
            this.Controls.Add(this.bYes);
            this.Controls.Add(this.lMessage);
            this.Name = "AnswerForm";
            this.Text = "AnswerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnswerForm_FormClosed);
            this.Load += new System.EventHandler(this.AnswerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bYes;
        private System.Windows.Forms.Button bNo;
        public System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lAnsTime;
        private System.Windows.Forms.Label label1;
    }
}