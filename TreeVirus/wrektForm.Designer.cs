namespace TreeVirus
{
    partial class wrektForm
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
            this.imgDisplay = new System.Windows.Forms.PictureBox();
            this.timerBlowUp = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDisplay
            // 
            this.imgDisplay.Location = new System.Drawing.Point(0, -1);
            this.imgDisplay.Name = "imgDisplay";
            this.imgDisplay.Size = new System.Drawing.Size(134, 114);
            this.imgDisplay.TabIndex = 0;
            this.imgDisplay.TabStop = false;
            // 
            // timerBlowUp
            // 
            this.timerBlowUp.Enabled = true;
            this.timerBlowUp.Interval = 1;
            this.timerBlowUp.Tick += new System.EventHandler(this.timerBlowUp_Tick);
            // 
            // wrektForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 111);
            this.Controls.Add(this.imgDisplay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(150, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(150, 150);
            this.Name = "wrektForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDisplay;
        private System.Windows.Forms.Timer timerBlowUp;
    }
}