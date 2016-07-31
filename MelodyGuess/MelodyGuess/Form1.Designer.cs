namespace MelodyGuess
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.bPlay = new System.Windows.Forms.Button();
            this.bSet = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPlay
            // 
            this.bPlay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPlay.Location = new System.Drawing.Point(64, 30);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(147, 51);
            this.bPlay.TabIndex = 0;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bSet
            // 
            this.bSet.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSet.Location = new System.Drawing.Point(64, 107);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(147, 51);
            this.bSet.TabIndex = 1;
            this.bSet.Text = "Settings";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(64, 187);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(147, 51);
            this.bExit.TabIndex = 2;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MelodyGuess.Properties.Resources.w514h5141380477220vynil;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.bPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Guess Melody!";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Button bExit;
    }
}

