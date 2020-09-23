using System.IO;
namespace medical
{
    partial class assistantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assistantForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Refresh_but = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.checkConnection = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.address_text = new System.Windows.Forms.TextBox();
            this.number_text = new System.Windows.Forms.TextBox();
            this.age_text = new System.Windows.Forms.TextBox();
            this.date_text = new System.Windows.Forms.DateTimePicker();
            this.book_but = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.ID_text = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.box1 = new System.Windows.Forms.ComboBox();
            this.ADD_NEW = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Prescription_label = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(937, 51);
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
            this.Refresh_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Refresh_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Refresh_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_but.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_but.ForeColor = System.Drawing.Color.LightGray;
            this.Refresh_but.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Refresh_but.Location = new System.Drawing.Point(851, 12);
            this.Refresh_but.Name = "Refresh_but";
            this.Refresh_but.Size = new System.Drawing.Size(26, 26);
            this.Refresh_but.TabIndex = 43;
            this.Refresh_but.UseVisualStyleBackColor = false;
            this.Refresh_but.Click += new System.EventHandler(this.Refresh_but_Click);
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
            this.Close_Button.ForeColor = System.Drawing.Color.DarkGray;
            this.Close_Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_Button.Location = new System.Drawing.Point(883, -4);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(42, 52);
            this.Close_Button.TabIndex = 3;
            this.Close_Button.Text = "x";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.BackColor = System.Drawing.Color.Transparent;
            this.checkConnection.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConnection.ForeColor = System.Drawing.Color.Gold;
            this.checkConnection.Location = new System.Drawing.Point(31, 511);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 16);
            this.checkConnection.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.name_label.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.name_label.Location = new System.Drawing.Point(26, 144);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(119, 24);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name             ";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(26, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email             ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(26, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address          ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(26, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age                ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(26, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Booking_Date";
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.Color.SeaShell;
            this.name_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.ForeColor = System.Drawing.Color.Brown;
            this.name_text.Location = new System.Drawing.Point(175, 137);
            this.name_text.Multiline = true;
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(422, 32);
            this.name_text.TabIndex = 1;
            // 
            // email_text
            // 
            this.email_text.BackColor = System.Drawing.Color.SeaShell;
            this.email_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.ForeColor = System.Drawing.Color.Brown;
            this.email_text.Location = new System.Drawing.Point(175, 300);
            this.email_text.Multiline = true;
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(422, 32);
            this.email_text.TabIndex = 5;
            // 
            // address_text
            // 
            this.address_text.BackColor = System.Drawing.Color.SeaShell;
            this.address_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_text.ForeColor = System.Drawing.Color.Brown;
            this.address_text.Location = new System.Drawing.Point(175, 257);
            this.address_text.Multiline = true;
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(422, 32);
            this.address_text.TabIndex = 4;
            // 
            // number_text
            // 
            this.number_text.BackColor = System.Drawing.Color.SeaShell;
            this.number_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_text.ForeColor = System.Drawing.Color.Brown;
            this.number_text.Location = new System.Drawing.Point(175, 216);
            this.number_text.Multiline = true;
            this.number_text.Name = "number_text";
            this.number_text.Size = new System.Drawing.Size(422, 32);
            this.number_text.TabIndex = 3;
            this.number_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_text_KeyPress);
            // 
            // age_text
            // 
            this.age_text.BackColor = System.Drawing.Color.SeaShell;
            this.age_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_text.ForeColor = System.Drawing.Color.Brown;
            this.age_text.Location = new System.Drawing.Point(175, 178);
            this.age_text.Multiline = true;
            this.age_text.Name = "age_text";
            this.age_text.Size = new System.Drawing.Size(422, 32);
            this.age_text.TabIndex = 2;
            this.age_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_text_KeyPress);
            // 
            // date_text
            // 
            this.date_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_text.CalendarFont = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_text.CalendarForeColor = System.Drawing.Color.Goldenrod;
            this.date_text.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.date_text.Font = new System.Drawing.Font("Tahoma", 13F);
            this.date_text.Location = new System.Drawing.Point(175, 342);
            this.date_text.Name = "date_text";
            this.date_text.Size = new System.Drawing.Size(422, 28);
            this.date_text.TabIndex = 6;
            // 
            // book_but
            // 
            this.book_but.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_but.BackColor = System.Drawing.Color.Transparent;
            this.book_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_but.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_but.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.book_but.Location = new System.Drawing.Point(223, 467);
            this.book_but.Name = "book_but";
            this.book_but.Size = new System.Drawing.Size(219, 45);
            this.book_but.TabIndex = 7;
            this.book_but.Text = "BOOK";
            this.book_but.UseVisualStyleBackColor = false;
            this.book_but.Click += new System.EventHandler(this.book_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel.Location = new System.Drawing.Point(491, 467);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(225, 45);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ID_text
            // 
            this.ID_text.BackColor = System.Drawing.Color.SeaShell;
            this.ID_text.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_text.ForeColor = System.Drawing.Color.Brown;
            this.ID_text.Location = new System.Drawing.Point(175, 97);
            this.ID_text.Multiline = true;
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(422, 32);
            this.ID_text.TabIndex = 23;
            this.ID_text.ReadOnlyChanged += new System.EventHandler(this.assistantForm_Load);
            this.ID_text.TextChanged += new System.EventHandler(this.ID_text_TextChanged);
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ID.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ID.Location = new System.Drawing.Point(28, 104);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(113, 24);
            this.ID.TabIndex = 22;
            this.ID.Text = "Patient ID      ";
            this.ID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(729, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 108);
            this.panel2.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(157, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 45);
            this.panel4.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(738, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 45);
            this.panel3.TabIndex = 40;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.Goldenrod;
            this.box1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.box1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.box1.FormattingEnabled = true;
            this.box1.Location = new System.Drawing.Point(695, 85);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(213, 24);
            this.box1.TabIndex = 41;
            this.box1.Text = "All booken";
            this.box1.SelectedIndexChanged += new System.EventHandler(this.box1_SelectedIndexChanged_1);
            // 
            // ADD_NEW
            // 
            this.ADD_NEW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ADD_NEW.BackColor = System.Drawing.Color.Transparent;
            this.ADD_NEW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ADD_NEW.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_NEW.ForeColor = System.Drawing.Color.Orange;
            this.ADD_NEW.Location = new System.Drawing.Point(636, 70);
            this.ADD_NEW.Name = "ADD_NEW";
            this.ADD_NEW.Size = new System.Drawing.Size(40, 43);
            this.ADD_NEW.TabIndex = 42;
            this.ADD_NEW.Text = "+";
            this.ADD_NEW.UseVisualStyleBackColor = false;
            this.ADD_NEW.Click += new System.EventHandler(this.ADD_NEW_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(272, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(67, 34);
            this.panel5.TabIndex = 49;
            // 
            // Prescription_label
            // 
            this.Prescription_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Prescription_label.AutoSize = true;
            this.Prescription_label.BackColor = System.Drawing.Color.Transparent;
            this.Prescription_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prescription_label.ForeColor = System.Drawing.Color.Bisque;
            this.Prescription_label.Location = new System.Drawing.Point(344, 66);
            this.Prescription_label.Name = "Prescription_label";
            this.Prescription_label.Size = new System.Drawing.Size(128, 23);
            this.Prescription_label.TabIndex = 48;
            this.Prescription_label.Text = "Patient Data";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(695, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(36, 24);
            this.panel6.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(737, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "All Booken";
            // 
            // assistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 537);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Prescription_label);
            this.Controls.Add(this.ADD_NEW);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ID_text);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.book_but);
            this.Controls.Add(this.date_text);
            this.Controls.Add(this.age_text);
            this.Controls.Add(this.number_text);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "assistantForm";
            this.Text = "assistantForm";
            this.Load += new System.EventHandler(this.assistantForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label checkConnection;
        //private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox age_tex;
        //private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox name_tex;
        //private Bunifu.Framework.UI.BunifuFlatButton book_but;
        //private Bunifu.Framework.UI.BunifuFlatButton cancel_but;
        //private Bunifu.Framework.UI.BunifuFlatButton addNew_but;
        //private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox address_tex;
        //private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox email_tex;
        //private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox number_tex;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.TextBox number_text;
        private System.Windows.Forms.TextBox age_text;
        private System.Windows.Forms.DateTimePicker date_text;
        private System.Windows.Forms.Button book_but;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox box1;
        private System.Windows.Forms.Button ADD_NEW;
        private System.Windows.Forms.Button Refresh_but;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Prescription_label;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
    }
}