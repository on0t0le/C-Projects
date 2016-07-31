namespace MelodyGuess
{
    partial class FGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGame));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.bNext = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.bContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbScore1 = new System.Windows.Forms.Label();
            this.lbScore2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbMusicTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(1, 498);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(184, 43);
            this.wmp.TabIndex = 0;
            this.wmp.Visible = false;
            this.wmp.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.wmp_OpenStateChange);
            // 
            // bNext
            // 
            this.bNext.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNext.Location = new System.Drawing.Point(10, 426);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(117, 47);
            this.bNext.TabIndex = 1;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPause
            // 
            this.bPause.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPause.Location = new System.Drawing.Point(145, 426);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(125, 47);
            this.bPause.TabIndex = 2;
            this.bPause.Text = "Pause";
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bContinue
            // 
            this.bContinue.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bContinue.Location = new System.Drawing.Point(293, 426);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(124, 47);
            this.bContinue.TabIndex = 3;
            this.bContinue.Text = "Continue";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(287, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player 2";
            // 
            // lbScore1
            // 
            this.lbScore1.AutoSize = true;
            this.lbScore1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore1.Location = new System.Drawing.Point(60, 84);
            this.lbScore1.Name = "lbScore1";
            this.lbScore1.Size = new System.Drawing.Size(35, 40);
            this.lbScore1.TabIndex = 6;
            this.lbScore1.Text = "0";
            this.lbScore1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbScore1_MouseClick);
            // 
            // lbScore2
            // 
            this.lbScore2.AutoSize = true;
            this.lbScore2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore2.Location = new System.Drawing.Point(338, 84);
            this.lbScore2.Name = "lbScore2";
            this.lbScore2.Size = new System.Drawing.Size(35, 40);
            this.lbScore2.TabIndex = 7;
            this.lbScore2.Text = "0";
            this.lbScore2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbScore1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(339, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "10";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 353);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 46);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbMusicTime
            // 
            this.lbMusicTime.AutoSize = true;
            this.lbMusicTime.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMusicTime.Location = new System.Drawing.Point(339, 258);
            this.lbMusicTime.Name = "lbMusicTime";
            this.lbMusicTime.Size = new System.Drawing.Size(42, 31);
            this.lbMusicTime.TabIndex = 10;
            this.lbMusicTime.Text = "10";
            this.lbMusicTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(62, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Songs remained";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(63, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Remained time";
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 546);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMusicTime);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbScore2);
            this.Controls.Add(this.lbScore1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.bPause);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.wmp);
            this.KeyPreview = true;
            this.Name = "FGame";
            this.Text = "FGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FGame_FormClosed);
            this.Load += new System.EventHandler(this.FGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbScore1;
        private System.Windows.Forms.Label lbScore2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbMusicTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}