namespace jasimProject
{
    partial class Manufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manufacturer));
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVManufacturer = new System.Windows.Forms.DataGridView();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtJoinDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoLogout = new System.Windows.Forms.PictureBox();
            this.GoSelling = new System.Windows.Forms.PictureBox();
            this.GoSellers = new System.Windows.Forms.PictureBox();
            this.GoCustomers = new System.Windows.Forms.PictureBox();
            this.GoManufacturer = new System.Windows.Forms.PictureBox();
            this.GoDashboard = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnManufacturer = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManufacturer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1229, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 27;
            this.btnClose.TabStop = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DGVManufacturer);
            this.panel2.Controls.Add(this.txtGender);
            this.panel2.Controls.Add(this.txtJoinDate);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtMobileNo);
            this.panel2.Controls.Add(this.txtManufacturerName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(292, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 672);
            this.panel2.TabIndex = 21;
            // 
            // DGVManufacturer
            // 
            this.DGVManufacturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVManufacturer.BackgroundColor = System.Drawing.Color.White;
            this.DGVManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManufacturer.GridColor = System.Drawing.Color.Black;
            this.DGVManufacturer.Location = new System.Drawing.Point(15, 284);
            this.DGVManufacturer.Name = "DGVManufacturer";
            this.DGVManufacturer.RowHeadersWidth = 51;
            this.DGVManufacturer.RowTemplate.Height = 24;
            this.DGVManufacturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVManufacturer.Size = new System.Drawing.Size(949, 385);
            this.DGVManufacturer.TabIndex = 20;
            this.DGVManufacturer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVManufacturer_CellContentClick);
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(16, 187);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(203, 31);
            this.txtGender.TabIndex = 19;
            // 
            // txtJoinDate
            // 
            this.txtJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtJoinDate.Location = new System.Drawing.Point(743, 87);
            this.txtJoinDate.Name = "txtJoinDate";
            this.txtJoinDate.Size = new System.Drawing.Size(171, 32);
            this.txtJoinDate.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(268, 85);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(237, 74);
            this.txtAddress.TabIndex = 17;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(514, 85);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(207, 32);
            this.txtMobileNo.TabIndex = 17;
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.Location = new System.Drawing.Point(16, 87);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(246, 32);
            this.txtManufacturerName.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(746, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Join Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(512, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mobile No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(267, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(12, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Manufacturer Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(383, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Manufacturer List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Manufacturer Details";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(587, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 40);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(426, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 40);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(268, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GoLogout);
            this.panel1.Controls.Add(this.GoSelling);
            this.panel1.Controls.Add(this.GoSellers);
            this.panel1.Controls.Add(this.GoCustomers);
            this.panel1.Controls.Add(this.GoManufacturer);
            this.panel1.Controls.Add(this.GoDashboard);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSelling);
            this.panel1.Controls.Add(this.btnSellers);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnManufacturer);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 768);
            this.panel1.TabIndex = 20;
            // 
            // GoLogout
            // 
            this.GoLogout.Image = ((System.Drawing.Image)(resources.GetObject("GoLogout.Image")));
            this.GoLogout.Location = new System.Drawing.Point(1, 707);
            this.GoLogout.Name = "GoLogout";
            this.GoLogout.Size = new System.Drawing.Size(56, 57);
            this.GoLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoLogout.TabIndex = 17;
            this.GoLogout.TabStop = false;
            this.GoLogout.Click += new System.EventHandler(this.GoLogout_Click);
            // 
            // GoSelling
            // 
            this.GoSelling.Image = ((System.Drawing.Image)(resources.GetObject("GoSelling.Image")));
            this.GoSelling.Location = new System.Drawing.Point(1, 509);
            this.GoSelling.Name = "GoSelling";
            this.GoSelling.Size = new System.Drawing.Size(56, 57);
            this.GoSelling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSelling.TabIndex = 17;
            this.GoSelling.TabStop = false;
            // 
            // GoSellers
            // 
            this.GoSellers.Image = ((System.Drawing.Image)(resources.GetObject("GoSellers.Image")));
            this.GoSellers.Location = new System.Drawing.Point(1, 441);
            this.GoSellers.Name = "GoSellers";
            this.GoSellers.Size = new System.Drawing.Size(56, 57);
            this.GoSellers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSellers.TabIndex = 17;
            this.GoSellers.TabStop = false;
            this.GoSellers.Click += new System.EventHandler(this.GoSellers_Click);
            // 
            // GoCustomers
            // 
            this.GoCustomers.Image = ((System.Drawing.Image)(resources.GetObject("GoCustomers.Image")));
            this.GoCustomers.Location = new System.Drawing.Point(1, 371);
            this.GoCustomers.Name = "GoCustomers";
            this.GoCustomers.Size = new System.Drawing.Size(56, 57);
            this.GoCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoCustomers.TabIndex = 17;
            this.GoCustomers.TabStop = false;
            this.GoCustomers.Click += new System.EventHandler(this.GoCustomers_Click);
            // 
            // GoManufacturer
            // 
            this.GoManufacturer.Image = ((System.Drawing.Image)(resources.GetObject("GoManufacturer.Image")));
            this.GoManufacturer.Location = new System.Drawing.Point(1, 234);
            this.GoManufacturer.Name = "GoManufacturer";
            this.GoManufacturer.Size = new System.Drawing.Size(56, 57);
            this.GoManufacturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoManufacturer.TabIndex = 17;
            this.GoManufacturer.TabStop = false;
            // 
            // GoDashboard
            // 
            this.GoDashboard.Image = ((System.Drawing.Image)(resources.GetObject("GoDashboard.Image")));
            this.GoDashboard.Location = new System.Drawing.Point(1, 167);
            this.GoDashboard.Name = "GoDashboard";
            this.GoDashboard.Size = new System.Drawing.Size(56, 57);
            this.GoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoDashboard.TabIndex = 17;
            this.GoDashboard.TabStop = false;
            this.GoDashboard.Click += new System.EventHandler(this.GoDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLogout.Location = new System.Drawing.Point(63, 714);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(202, 40);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.White;
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSelling.Location = new System.Drawing.Point(63, 516);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(202, 40);
            this.btnSelling.TabIndex = 16;
            this.btnSelling.UseVisualStyleBackColor = false;
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.Color.White;
            this.btnSellers.FlatAppearance.BorderSize = 0;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSellers.Location = new System.Drawing.Point(63, 448);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(202, 40);
            this.btnSellers.TabIndex = 16;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCustomers.Location = new System.Drawing.Point(63, 378);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(202, 40);
            this.btnCustomers.TabIndex = 16;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnManufacturer
            // 
            this.btnManufacturer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnManufacturer.FlatAppearance.BorderSize = 0;
            this.btnManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManufacturer.ForeColor = System.Drawing.Color.White;
            this.btnManufacturer.Location = new System.Drawing.Point(63, 241);
            this.btnManufacturer.Name = "btnManufacturer";
            this.btnManufacturer.Size = new System.Drawing.Size(202, 40);
            this.btnManufacturer.TabIndex = 16;
            this.btnManufacturer.Text = "Manufacturer";
            this.btnManufacturer.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnDashboard.Location = new System.Drawing.Point(63, 174);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(202, 40);
            this.btnDashboard.TabIndex = 16;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(109, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Health Care";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(747, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Version1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(607, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Medical Representative Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Manufacturer";
            // 
            // Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manufacturer";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManufacturer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GoLogout;
        private System.Windows.Forms.PictureBox GoSelling;
        private System.Windows.Forms.PictureBox GoSellers;
        private System.Windows.Forms.PictureBox GoCustomers;
        private System.Windows.Forms.PictureBox GoManufacturer;
        private System.Windows.Forms.PictureBox GoDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnManufacturer;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.DateTimePicker txtJoinDate;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DGVManufacturer;
    }
}