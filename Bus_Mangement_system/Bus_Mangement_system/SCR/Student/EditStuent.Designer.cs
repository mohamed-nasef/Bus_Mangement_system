namespace Bus_Mangement_system.SCR.Student
{
    partial class EditStuent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStuent));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbEditStudent = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbBookingType = new Guna.UI.WinForms.GunaComboBox();
            this.cmbUniversity = new Guna.UI.WinForms.GunaComboBox();
            this.cmbAddress = new Guna.UI.WinForms.GunaComboBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI.WinForms.GunaTextBox();
            this.btnEditStudent = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelBody.SuspendLayout();
            this.grbEditStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // panelDraft
            // 
            this.panelDraft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDraft.Location = new System.Drawing.Point(0, 0);
            this.panelDraft.Name = "panelDraft";
            this.panelDraft.Size = new System.Drawing.Size(338, 881);
            this.panelDraft.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grbEditStudent);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
            // 
            // grbEditStudent
            // 
            this.grbEditStudent.Controls.Add(this.lblID);
            this.grbEditStudent.Controls.Add(this.lblPhone);
            this.grbEditStudent.Controls.Add(this.lblLastName);
            this.grbEditStudent.Controls.Add(this.lblFirstName);
            this.grbEditStudent.Controls.Add(this.cmbBookingType);
            this.grbEditStudent.Controls.Add(this.cmbUniversity);
            this.grbEditStudent.Controls.Add(this.cmbAddress);
            this.grbEditStudent.Controls.Add(this.txtPhone);
            this.grbEditStudent.Controls.Add(this.label5);
            this.grbEditStudent.Controls.Add(this.label4);
            this.grbEditStudent.Controls.Add(this.txtLastName);
            this.grbEditStudent.Controls.Add(this.btnEditStudent);
            this.grbEditStudent.Controls.Add(this.label1);
            this.grbEditStudent.Controls.Add(this.label2);
            this.grbEditStudent.Controls.Add(this.label6);
            this.grbEditStudent.Controls.Add(this.txtFirstName);
            this.grbEditStudent.Controls.Add(this.label3);
            this.grbEditStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditStudent.ForeColor = System.Drawing.Color.White;
            this.grbEditStudent.Location = new System.Drawing.Point(368, 30);
            this.grbEditStudent.Name = "grbEditStudent";
            this.grbEditStudent.Size = new System.Drawing.Size(576, 833);
            this.grbEditStudent.TabIndex = 37;
            this.grbEditStudent.TabStop = false;
            this.grbEditStudent.Text = "Edit Student";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(69, 279);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 17);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "ex: 01021782433";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Gray;
            this.lblLastName.Location = new System.Drawing.Point(308, 155);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 17);
            this.lblLastName.TabIndex = 42;
            this.lblLastName.Text = "ex: Nasef";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Gray;
            this.lblFirstName.Location = new System.Drawing.Point(69, 155);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 17);
            this.lblFirstName.TabIndex = 38;
            this.lblFirstName.Text = "ex: Mohamed";
            // 
            // cmbBookingType
            // 
            this.cmbBookingType.BackColor = System.Drawing.Color.Transparent;
            this.cmbBookingType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbBookingType.BorderColor = System.Drawing.Color.Black;
            this.cmbBookingType.BorderSize = 0;
            this.cmbBookingType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBookingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBookingType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.cmbBookingType.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBookingType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cmbBookingType.FormattingEnabled = true;
            this.cmbBookingType.Items.AddRange(new object[] {
            "Monthly",
            "Daily",
            "Term"});
            this.cmbBookingType.Location = new System.Drawing.Point(63, 644);
            this.cmbBookingType.Name = "cmbBookingType";
            this.cmbBookingType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbBookingType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBookingType.Radius = 8;
            this.cmbBookingType.Size = new System.Drawing.Size(461, 31);
            this.cmbBookingType.TabIndex = 41;
            // 
            // cmbUniversity
            // 
            this.cmbUniversity.BackColor = System.Drawing.Color.Transparent;
            this.cmbUniversity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbUniversity.BorderColor = System.Drawing.Color.Black;
            this.cmbUniversity.BorderSize = 0;
            this.cmbUniversity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUniversity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.cmbUniversity.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUniversity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cmbUniversity.FormattingEnabled = true;
            this.cmbUniversity.Items.AddRange(new object[] {
            "Mansoura",
            "MET",
            "Nile",
            "Delta"});
            this.cmbUniversity.Location = new System.Drawing.Point(63, 520);
            this.cmbUniversity.Name = "cmbUniversity";
            this.cmbUniversity.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbUniversity.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbUniversity.Radius = 8;
            this.cmbUniversity.Size = new System.Drawing.Size(461, 31);
            this.cmbUniversity.TabIndex = 40;
            // 
            // cmbAddress
            // 
            this.cmbAddress.BackColor = System.Drawing.Color.Transparent;
            this.cmbAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbAddress.BorderColor = System.Drawing.Color.Black;
            this.cmbAddress.BorderSize = 0;
            this.cmbAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.cmbAddress.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Items.AddRange(new object[] {
            "Dikirnis",
            "Menyet El-Nasr",
            "Eldraksa",
            "Mit Taher",
            "Mit Temamah",
            "Al Baglat"});
            this.cmbAddress.Location = new System.Drawing.Point(63, 396);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAddress.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAddress.Radius = 8;
            this.cmbAddress.Size = new System.Drawing.Size(461, 31);
            this.cmbAddress.TabIndex = 39;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.BorderSize = 0;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtPhone.Location = new System.Drawing.Point(63, 272);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 8;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(461, 32);
            this.txtPhone.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(297, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtLastName.BorderColor = System.Drawing.Color.Silver;
            this.txtLastName.BorderSize = 0;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtLastName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtLastName.Location = new System.Drawing.Point(302, 148);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.Radius = 8;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(218, 32);
            this.txtLastName.TabIndex = 30;
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.AnimationHoverSpeed = 0.07F;
            this.btnEditStudent.AnimationSpeed = 0.03F;
            this.btnEditStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnEditStudent.BaseColor = System.Drawing.Color.Transparent;
            this.btnEditStudent.BorderColor = System.Drawing.Color.Black;
            this.btnEditStudent.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEditStudent.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEditStudent.CheckedForeColor = System.Drawing.Color.White;
            this.btnEditStudent.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEditStudent.CheckedImage")));
            this.btnEditStudent.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEditStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudent.ForeColor = System.Drawing.Color.White;
            this.btnEditStudent.Image = null;
            this.btnEditStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditStudent.LineBottom = 1;
            this.btnEditStudent.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnEditStudent.Location = new System.Drawing.Point(59, 758);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnEditStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditStudent.OnHoverImage = null;
            this.btnEditStudent.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnEditStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditStudent.Radius = 10;
            this.btnEditStudent.Size = new System.Drawing.Size(461, 42);
            this.btnEditStudent.TabIndex = 25;
            this.btnEditStudent.Text = "Edit";
            this.btnEditStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditStudent.Click += new System.EventHandler(this.BtnEditStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(58, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 30);
            this.label6.TabIndex = 33;
            this.label6.Text = "Booking Type";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtFirstName.BorderColor = System.Drawing.Color.Silver;
            this.txtFirstName.BorderSize = 0;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtFirstName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtFirstName.Location = new System.Drawing.Point(63, 148);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.Radius = 8;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(218, 32);
            this.txtFirstName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "University";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Bus_Mangement_system.Properties.Resources.icons8_back_64_final1;
            this.btnClose.Location = new System.Drawing.Point(6, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 62);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(186, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(117, 30);
            this.lblID.TabIndex = 44;
            this.lblID.Text = "First Name";
            // 
            // EditStuent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1491, 881);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelDraft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditStuent";
            this.Text = "EditStuent";
            this.Load += new System.EventHandler(this.EditStuent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.grbEditStudent.ResumeLayout(false);
            this.grbEditStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbEditStudent;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI.WinForms.GunaComboBox cmbBookingType;
        private Guna.UI.WinForms.GunaComboBox cmbUniversity;
        private Guna.UI.WinForms.GunaComboBox cmbAddress;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtLastName;
        private Guna.UI.WinForms.GunaAdvenceButton btnEditStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
    }
}