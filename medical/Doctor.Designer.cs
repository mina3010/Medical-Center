namespace medical
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Refresh_but = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.checkConnection = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.Button();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.statue_text = new System.Windows.Forms.TextBox();
            this.phoneNumber_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.statue_lab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.DeletePatient_but = new System.Windows.Forms.Button();
            this.ShowDataPatient_but = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Prescription_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Update_but = new System.Windows.Forms.Button();
            this.AmountOfMedicine_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ADD_NEW = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Refresh_but);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Refresh_but
            // 
            this.Refresh_but.BackColor = System.Drawing.Color.Transparent;
            this.Refresh_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh_but.BackgroundImage")));
            this.Refresh_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Refresh_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_but.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Refresh_but.FlatAppearance.BorderSize = 0;
            this.Refresh_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Refresh_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Refresh_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_but.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_but.ForeColor = System.Drawing.Color.LightGray;
            this.Refresh_but.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Refresh_but.Location = new System.Drawing.Point(742, 10);
            this.Refresh_but.Name = "Refresh_but";
            this.Refresh_but.Size = new System.Drawing.Size(26, 26);
            this.Refresh_but.TabIndex = 5;
            this.Refresh_but.UseVisualStyleBackColor = false;
            this.Refresh_but.Click += new System.EventHandler(this.button4_Click);
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
            this.Close_Button.ForeColor = System.Drawing.Color.LightGray;
            this.Close_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_Button.Location = new System.Drawing.Point(774, -3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(42, 52);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Text = "x";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // checkConnection
            // 
            this.checkConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkConnection.AutoSize = true;
            this.checkConnection.BackColor = System.Drawing.Color.Transparent;
            this.checkConnection.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkConnection.ForeColor = System.Drawing.Color.Tan;
            this.checkConnection.Location = new System.Drawing.Point(32, 64);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 17);
            this.checkConnection.TabIndex = 1;
            // 
            // book
            // 
            this.book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book.BackColor = System.Drawing.Color.Transparent;
            this.book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.ForeColor = System.Drawing.Color.White;
            this.book.Location = new System.Drawing.Point(424, 439);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(144, 45);
            this.book.TabIndex = 6;
            this.book.Text = "ADD";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // ID_text
            // 
            this.ID_text.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ID_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_text.ForeColor = System.Drawing.Color.Olive;
            this.ID_text.Location = new System.Drawing.Point(183, 115);
            this.ID_text.Multiline = true;
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(371, 30);
            this.ID_text.TabIndex = 1;
            this.ID_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_text_KeyPress);
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ID.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Goldenrod;
            this.ID.Location = new System.Drawing.Point(51, 121);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(83, 24);
            this.ID.TabIndex = 30;
            this.ID.Text = "Patient ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statue_text
            // 
            this.statue_text.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.statue_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statue_text.ForeColor = System.Drawing.Color.Olive;
            this.statue_text.Location = new System.Drawing.Point(183, 189);
            this.statue_text.Multiline = true;
            this.statue_text.Name = "statue_text";
            this.statue_text.Size = new System.Drawing.Size(371, 123);
            this.statue_text.TabIndex = 3;
            // 
            // phoneNumber_text
            // 
            this.phoneNumber_text.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.phoneNumber_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber_text.ForeColor = System.Drawing.Color.Olive;
            this.phoneNumber_text.Location = new System.Drawing.Point(183, 380);
            this.phoneNumber_text.Multiline = true;
            this.phoneNumber_text.Name = "phoneNumber_text";
            this.phoneNumber_text.Size = new System.Drawing.Size(371, 30);
            this.phoneNumber_text.TabIndex = 5;
            this.phoneNumber_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber_text_KeyPress);
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.name_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.ForeColor = System.Drawing.Color.Olive;
            this.name_text.Location = new System.Drawing.Point(183, 151);
            this.name_text.Multiline = true;
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(371, 30);
            this.name_text.TabIndex = 2;
            // 
            // statue_lab
            // 
            this.statue_lab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statue_lab.AutoSize = true;
            this.statue_lab.BackColor = System.Drawing.Color.Transparent;
            this.statue_lab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statue_lab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statue_lab.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statue_lab.ForeColor = System.Drawing.Color.Goldenrod;
            this.statue_lab.Location = new System.Drawing.Point(51, 203);
            this.statue_lab.Name = "statue_lab";
            this.statue_lab.Size = new System.Drawing.Size(117, 24);
            this.statue_lab.TabIndex = 26;
            this.statue_lab.Text = "Patient Statue ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(35, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Phone Number  ";
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.name_label.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.Goldenrod;
            this.name_label.Location = new System.Drawing.Point(51, 157);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(119, 24);
            this.name_label.TabIndex = 24;
            this.name_label.Text = "Name             ";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeletePatient_but
            // 
            this.DeletePatient_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeletePatient_but.BackColor = System.Drawing.Color.Transparent;
            this.DeletePatient_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePatient_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePatient_but.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePatient_but.ForeColor = System.Drawing.Color.White;
            this.DeletePatient_but.Location = new System.Drawing.Point(584, 439);
            this.DeletePatient_but.Name = "DeletePatient_but";
            this.DeletePatient_but.Size = new System.Drawing.Size(171, 45);
            this.DeletePatient_but.TabIndex = 77;
            this.DeletePatient_but.Text = "DELETE PATIENT";
            this.DeletePatient_but.UseVisualStyleBackColor = false;
            this.DeletePatient_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowDataPatient_but
            // 
            this.ShowDataPatient_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowDataPatient_but.BackColor = System.Drawing.Color.Transparent;
            this.ShowDataPatient_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowDataPatient_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDataPatient_but.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDataPatient_but.ForeColor = System.Drawing.Color.White;
            this.ShowDataPatient_but.Location = new System.Drawing.Point(90, 439);
            this.ShowDataPatient_but.Name = "ShowDataPatient_but";
            this.ShowDataPatient_but.Size = new System.Drawing.Size(171, 45);
            this.ShowDataPatient_but.TabIndex = 7;
            this.ShowDataPatient_but.Text = "DATA PATIENT";
            this.ShowDataPatient_but.UseVisualStyleBackColor = false;
            this.ShowDataPatient_but.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(643, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = " Re-Revealed";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Prescription_label
            // 
            this.Prescription_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Prescription_label.AutoSize = true;
            this.Prescription_label.BackColor = System.Drawing.Color.Transparent;
            this.Prescription_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prescription_label.ForeColor = System.Drawing.Color.Bisque;
            this.Prescription_label.Location = new System.Drawing.Point(339, 76);
            this.Prescription_label.Name = "Prescription_label";
            this.Prescription_label.Size = new System.Drawing.Size(125, 23);
            this.Prescription_label.TabIndex = 36;
            this.Prescription_label.Text = "Prescription";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(643, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 97);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(266, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(67, 42);
            this.panel3.TabIndex = 39;
            // 
            // Update_but
            // 
            this.Update_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update_but.BackColor = System.Drawing.Color.Transparent;
            this.Update_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_but.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_but.ForeColor = System.Drawing.Color.White;
            this.Update_but.Location = new System.Drawing.Point(279, 439);
            this.Update_but.Name = "Update_but";
            this.Update_but.Size = new System.Drawing.Size(132, 45);
            this.Update_but.TabIndex = 40;
            this.Update_but.Text = "UPDATE";
            this.Update_but.UseVisualStyleBackColor = false;
            this.Update_but.Click += new System.EventHandler(this.button3_Click);
            // 
            // AmountOfMedicine_txt
            // 
            this.AmountOfMedicine_txt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AmountOfMedicine_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOfMedicine_txt.ForeColor = System.Drawing.Color.Olive;
            this.AmountOfMedicine_txt.Location = new System.Drawing.Point(183, 318);
            this.AmountOfMedicine_txt.Multiline = true;
            this.AmountOfMedicine_txt.Name = "AmountOfMedicine_txt";
            this.AmountOfMedicine_txt.Size = new System.Drawing.Size(371, 56);
            this.AmountOfMedicine_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(35, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Amount Of Medicine";
            // 
            // ADD_NEW
            // 
            this.ADD_NEW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ADD_NEW.BackColor = System.Drawing.Color.Transparent;
            this.ADD_NEW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_NEW.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_NEW.ForeColor = System.Drawing.Color.Orange;
            this.ADD_NEW.Location = new System.Drawing.Point(593, 76);
            this.ADD_NEW.Name = "ADD_NEW";
            this.ADD_NEW.Size = new System.Drawing.Size(35, 43);
            this.ADD_NEW.TabIndex = 43;
            this.ADD_NEW.Text = "+";
            this.ADD_NEW.UseVisualStyleBackColor = false;
            this.ADD_NEW.Click += new System.EventHandler(this.ADD_NEW_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(683, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = " Re-Revealed";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(653, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 27);
            this.panel4.TabIndex = 40;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 505);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ADD_NEW);
            this.Controls.Add(this.AmountOfMedicine_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_but);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Prescription_label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ShowDataPatient_but);
            this.Controls.Add(this.DeletePatient_but);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.statue_text);
            this.Controls.Add(this.phoneNumber_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.statue_lab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.book);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox statue_text;
        private System.Windows.Forms.TextBox phoneNumber_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label statue_lab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button DeletePatient_but;
        private System.Windows.Forms.Button ShowDataPatient_but;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Prescription_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Update_but;
        private System.Windows.Forms.TextBox AmountOfMedicine_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ADD_NEW;
        private System.Windows.Forms.Button Refresh_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
    }
}