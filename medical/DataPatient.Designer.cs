namespace medical
{
    partial class DataPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.checkConnection = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Refresh_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Prescription_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.Close_Button.Location = new System.Drawing.Point(796, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(42, 40);
            this.Close_Button.TabIndex = 5;
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
            this.checkConnection.Location = new System.Drawing.Point(40, 491);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 17);
            this.checkConnection.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(173, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 390);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.Refresh_but.Location = new System.Drawing.Point(70, 71);
            this.Refresh_but.Name = "Refresh_but";
            this.Refresh_but.Size = new System.Drawing.Size(66, 49);
            this.Refresh_but.TabIndex = 6;
            this.Refresh_but.UseVisualStyleBackColor = false;
            this.Refresh_but.Click += new System.EventHandler(this.Refresh_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(66, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Refresh";
            // 
            // Prescription_label
            // 
            this.Prescription_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Prescription_label.AutoSize = true;
            this.Prescription_label.BackColor = System.Drawing.Color.Transparent;
            this.Prescription_label.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prescription_label.ForeColor = System.Drawing.Color.Peru;
            this.Prescription_label.Location = new System.Drawing.Point(183, 97);
            this.Prescription_label.Name = "Prescription_label";
            this.Prescription_label.Size = new System.Drawing.Size(282, 23);
            this.Prescription_label.TabIndex = 49;
            this.Prescription_label.Text = "All Medical Data Of Patients ";
            // 
            // DataPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 535);
            this.Controls.Add(this.Prescription_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh_but);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataPatient";
            this.Text = "DataPatient";
            this.Load += new System.EventHandler(this.DataPatient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Refresh_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prescription_label;
    }
}