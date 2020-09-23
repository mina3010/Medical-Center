namespace medical
{
    partial class DeleteDataPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDataPatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.number1_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkConnection = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.ForeColor = System.Drawing.Color.Silver;
            this.Close_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_Button.Location = new System.Drawing.Point(405, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(42, 52);
            this.Close_Button.TabIndex = 3;
            this.Close_Button.Text = "x";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(33, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 108);
            this.panel3.TabIndex = 44;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(253, 340);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(194, 57);
            this.cancel.TabIndex = 47;
            this.cancel.Text = "DELETE";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // number1_text
            // 
            this.number1_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.number1_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number1_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number1_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1_text.ForeColor = System.Drawing.Color.Snow;
            this.number1_text.Location = new System.Drawing.Point(80, 117);
            this.number1_text.Multiline = true;
            this.number1_text.Name = "number1_text";
            this.number1_text.Size = new System.Drawing.Size(351, 48);
            this.number1_text.TabIndex = 46;
            this.number1_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number1_text_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(169, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 30);
            this.label3.TabIndex = 45;
            this.label3.Text = "Phone Number";
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.BackColor = System.Drawing.Color.Transparent;
            this.checkConnection.Font = new System.Drawing.Font("Tahoma", 8F);
            this.checkConnection.ForeColor = System.Drawing.Color.LemonChiffon;
            this.checkConnection.Location = new System.Drawing.Point(316, 496);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 13);
            this.checkConnection.TabIndex = 48;
            // 
            // DeleteDataPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 563);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.number1_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteDataPatient";
            this.Text = "DeleteDataPatient";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox number1_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label checkConnection;
    }
}