namespace medical
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.assistant_but = new System.Windows.Forms.Button();
            this.doctor_but = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 52);
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
            this.Close_Button.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.ForeColor = System.Drawing.Color.Goldenrod;
            this.Close_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_Button.Location = new System.Drawing.Point(733, -11);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(52, 64);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.Text = "x";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // assistant_but
            // 
            this.assistant_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assistant_but.BackColor = System.Drawing.Color.Transparent;
            this.assistant_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assistant_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assistant_but.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistant_but.ForeColor = System.Drawing.Color.Goldenrod;
            this.assistant_but.Location = new System.Drawing.Point(162, 226);
            this.assistant_but.Name = "assistant_but";
            this.assistant_but.Size = new System.Drawing.Size(216, 62);
            this.assistant_but.TabIndex = 1;
            this.assistant_but.Text = "ASSISTANT";
            this.assistant_but.UseVisualStyleBackColor = false;
            this.assistant_but.Click += new System.EventHandler(this.assistant_but_Click);
            // 
            // doctor_but
            // 
            this.doctor_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctor_but.BackColor = System.Drawing.Color.Transparent;
            this.doctor_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doctor_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor_but.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_but.ForeColor = System.Drawing.Color.Goldenrod;
            this.doctor_but.Location = new System.Drawing.Point(449, 226);
            this.doctor_but.Name = "doctor_but";
            this.doctor_but.Size = new System.Drawing.Size(212, 62);
            this.doctor_but.TabIndex = 2;
            this.doctor_but.Text = "DOCTOR";
            this.doctor_but.UseVisualStyleBackColor = false;
            this.doctor_but.Click += new System.EventHandler(this.doctor_but_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 134);
            this.panel4.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(611, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 134);
            this.panel2.TabIndex = 41;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.doctor_but);
            this.Controls.Add(this.assistant_but);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.Text = "mainPage";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button assistant_but;
        private System.Windows.Forms.Button doctor_but;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}