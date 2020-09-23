
namespace medical

{
    partial class Start_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Login_but = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumBlue;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.ForeColor = System.Drawing.Color.Silver;
            this.Close_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_Button.Location = new System.Drawing.Point(730, -9);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(47, 78);
            this.Close_Button.TabIndex = 44;
            this.Close_Button.Text = "x";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Login_but
            // 
            this.Login_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_but.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_but.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Login_but.FlatAppearance.BorderSize = 2;
            this.Login_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Login_but.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Login_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_but.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_but.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_but.Location = new System.Drawing.Point(327, 216);
            this.Login_but.Name = "Login_but";
            this.Login_but.Size = new System.Drawing.Size(175, 156);
            this.Login_but.TabIndex = 1;
            this.Login_but.Text = "LOGIN";
            this.Login_but.UseVisualStyleBackColor = false;
            this.Login_but.Click += new System.EventHandler(this.Login_but_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcome_label.Location = new System.Drawing.Point(30, 434);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(183, 17);
            this.welcome_label.TabIndex = 2;
            this.welcome_label.Text = "Welcome in Medical Center ..";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(33, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 105);
            this.panel3.TabIndex = 43;
            // 
            // book
            // 
            this.book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book.BackColor = System.Drawing.Color.Transparent;
            this.book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("book.BackgroundImage")));
            this.book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.ForeColor = System.Drawing.Color.White;
            this.book.Location = new System.Drawing.Point(700, 421);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(51, 41);
            this.book.TabIndex = 44;
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(650, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 14);
            this.label1.TabIndex = 45;
            this.label1.Text = "Connect with Devleoper";
            // 
            // Start_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.Login_but);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start_page";
            this.Text = "main";
            this.Load += new System.EventHandler(this.Start_page_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton Login;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button Login_but;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Label label1;
    }
}

