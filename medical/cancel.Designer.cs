namespace medical
{
    partial class cancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cancel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.number_text = new System.Windows.Forms.TextBox();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.cancel2_button = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(373, 50);
            this.panel1.TabIndex = 0;
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
            this.Close_Button.ForeColor = System.Drawing.Color.DimGray;
            this.Close_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_Button.Location = new System.Drawing.Point(309, -7);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(42, 52);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Text = "x";
            this.Close_Button.UseVisualStyleBackColor = false;
            // 
            // number_text
            // 
            this.number_text.BackColor = System.Drawing.Color.Black;
            this.number_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_text.ForeColor = System.Drawing.Color.White;
            this.number_text.Location = new System.Drawing.Point(43, 148);
            this.number_text.Multiline = true;
            this.number_text.Name = "number_text";
            this.number_text.Size = new System.Drawing.Size(287, 43);
            this.number_text.TabIndex = 14;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumber_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneNumber_label.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.phoneNumber_label.Location = new System.Drawing.Point(112, 99);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(147, 30);
            this.phoneNumber_label.TabIndex = 13;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // cancel2_button
            // 
            this.cancel2_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel2_button.BackColor = System.Drawing.Color.Transparent;
            this.cancel2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel2_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel2_button.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel2_button.ForeColor = System.Drawing.Color.Black;
            this.cancel2_button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cancel2_button.Location = new System.Drawing.Point(51, 341);
            this.cancel2_button.Name = "cancel2_button";
            this.cancel2_button.Size = new System.Drawing.Size(154, 41);
            this.cancel2_button.TabIndex = 19;
            this.cancel2_button.Text = "CANCEL";
            this.cancel2_button.UseVisualStyleBackColor = false;
            this.cancel2_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.BackColor = System.Drawing.Color.Transparent;
            this.checkConnection.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConnection.ForeColor = System.Drawing.Color.Gold;
            this.checkConnection.Location = new System.Drawing.Point(48, 438);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 16);
            this.checkConnection.TabIndex = 20;
            // 
            // cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 488);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.cancel2_button);
            this.Controls.Add(this.number_text);
            this.Controls.Add(this.phoneNumber_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cancel";
            this.Opacity = 0.8D;
            this.Text = "cancel";
            this.Load += new System.EventHandler(this.cancel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.TextBox number_text;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.Button cancel2_button;
        private System.Windows.Forms.Label checkConnection;
    }
}