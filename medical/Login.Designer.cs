namespace medical
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Close_Button = new System.Windows.Forms.Button();
            this.username_but = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.password_but = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.login_but = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.checkConnection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 58);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.ForeColor = System.Drawing.Color.Silver;
            this.Close_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_Button.Location = new System.Drawing.Point(331, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(42, 58);
            this.Close_Button.TabIndex = 1;
            this.Close_Button.Text = "x";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // username_but
            // 
            this.username_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_but.BorderColor = System.Drawing.Color.Gray;
            this.username_but.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_but.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_but.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.username_but.Location = new System.Drawing.Point(59, 172);
            this.username_but.Multiline = true;
            this.username_but.Name = "username_but";
            this.username_but.Size = new System.Drawing.Size(289, 53);
            this.username_but.TabIndex = 1;
            // 
            // password_but
            // 
            this.password_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_but.BorderColor = System.Drawing.Color.Gray;
            this.password_but.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_but.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_but.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.password_but.Location = new System.Drawing.Point(59, 266);
            this.password_but.Multiline = true;
            this.password_but.Name = "password_but";
            this.password_but.PasswordChar = '*';
            this.password_but.Size = new System.Drawing.Size(289, 53);
            this.password_but.TabIndex = 2;
            this.password_but.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_but_KeyDown);
            this.password_but.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_but_KeyPress);
            // 
            // login_but
            // 
            this.login_but.ActiveBorderThickness = 1;
            this.login_but.ActiveCornerRadius = 20;
            this.login_but.ActiveFillColor = System.Drawing.Color.Transparent;
            this.login_but.ActiveForecolor = System.Drawing.SystemColors.HotTrack;
            this.login_but.ActiveLineColor = System.Drawing.SystemColors.Highlight;
            this.login_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_but.BackgroundImage")));
            this.login_but.ButtonText = "LOGIN";
            this.login_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_but.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_but.ForeColor = System.Drawing.Color.Gainsboro;
            this.login_but.IdleBorderThickness = 1;
            this.login_but.IdleCornerRadius = 20;
            this.login_but.IdleFillColor = System.Drawing.SystemColors.HotTrack;
            this.login_but.IdleForecolor = System.Drawing.Color.Silver;
            this.login_but.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.login_but.Location = new System.Drawing.Point(93, 337);
            this.login_but.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.login_but.Name = "login_but";
            this.login_but.Size = new System.Drawing.Size(189, 60);
            this.login_but.TabIndex = 3;
            this.login_but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_but.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            this.login_but.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bunifuThinButton21_KeyDown);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(20, 266);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(32, 53);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(21, 172);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(32, 53);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 5;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkConnection.Location = new System.Drawing.Point(17, 81);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 13);
            this.checkConnection.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "> Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "> Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(376, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.login_but);
            this.Controls.Add(this.password_but);
            this.Controls.Add(this.username_but);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.85D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox username_but;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox password_but;
        private Bunifu.Framework.UI.BunifuThinButton2 login_but;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}