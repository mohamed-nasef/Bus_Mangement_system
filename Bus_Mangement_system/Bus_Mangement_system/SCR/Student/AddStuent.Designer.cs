
namespace Bus_Mangement_system.SCR.Student
{
    partial class AddStuent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStuent));
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbAddStudent = new System.Windows.Forms.GroupBox();
            this.cmbBookingType = new Guna.UI.WinForms.GunaComboBox();
            this.cmbUniversity = new Guna.UI.WinForms.GunaComboBox();
            this.cmbAddress = new Guna.UI.WinForms.GunaComboBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddStudent = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBody.SuspendLayout();
            this.grbAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraft
            // 
            this.panelDraft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDraft.Location = new System.Drawing.Point(0, 0);
            this.panelDraft.Name = "panelDraft";
            this.panelDraft.Size = new System.Drawing.Size(338, 896);
            this.panelDraft.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grbAddStudent);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 896);
            this.panelBody.TabIndex = 2;
            // 
            // grbAddStudent
            // 
            this.grbAddStudent.Controls.Add(this.cmbBookingType);
            this.grbAddStudent.Controls.Add(this.cmbUniversity);
            this.grbAddStudent.Controls.Add(this.cmbAddress);
            this.grbAddStudent.Controls.Add(this.txtPhone);
            this.grbAddStudent.Controls.Add(this.label5);
            this.grbAddStudent.Controls.Add(this.label4);
            this.grbAddStudent.Controls.Add(this.txtLastName);
            this.grbAddStudent.Controls.Add(this.btnAddStudent);
            this.grbAddStudent.Controls.Add(this.label1);
            this.grbAddStudent.Controls.Add(this.label2);
            this.grbAddStudent.Controls.Add(this.label6);
            this.grbAddStudent.Controls.Add(this.txtFirstName);
            this.grbAddStudent.Controls.Add(this.label3);
            this.grbAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddStudent.ForeColor = System.Drawing.Color.White;
            this.grbAddStudent.Location = new System.Drawing.Point(368, 30);
            this.grbAddStudent.Name = "grbAddStudent";
            this.grbAddStudent.Size = new System.Drawing.Size(576, 833);
            this.grbAddStudent.TabIndex = 36;
            this.grbAddStudent.TabStop = false;
            this.grbAddStudent.Text = "Add Student";
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
            this.cmbBookingType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBookingType_Validating);
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
            this.cmbUniversity.Validating += new System.ComponentModel.CancelEventHandler(this.cmbUniversity_Validating);
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
            this.cmbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.cmbAddress_Validating);
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
            this.txtPhone.Location = new System.Drawing.Point(59, 272);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 8;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(461, 32);
            this.txtPhone.TabIndex = 38;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
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
            this.label4.Location = new System.Drawing.Point(54, 226);
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
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.AnimationHoverSpeed = 0.07F;
            this.btnAddStudent.AnimationSpeed = 0.03F;
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.BorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddStudent.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddStudent.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.CheckedImage")));
            this.btnAddStudent.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddStudent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddStudent.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = null;
            this.btnAddStudent.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddStudent.LineBottom = 1;
            this.btnAddStudent.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddStudent.Location = new System.Drawing.Point(59, 758);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnAddStudent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddStudent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddStudent.OnHoverImage = null;
            this.btnAddStudent.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddStudent.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddStudent.Radius = 10;
            this.btnAddStudent.Size = new System.Drawing.Size(461, 42);
            this.btnAddStudent.TabIndex = 25;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
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
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
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
            this.btnClose.Image = global::Bus_Mangement_system.Properties.Resources.icons8_back_64px;
            this.btnClose.Location = new System.Drawing.Point(6, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // AddStuent
            // 
            this.AcceptButton = this.btnAddStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1491, 896);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelDraft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddStuent";
            this.Text = "AddStuent";
            this.panelBody.ResumeLayout(false);
            this.grbAddStudent.ResumeLayout(false);
            this.grbAddStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private Guna.UI.WinForms.GunaTextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtFirstName;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbAddStudent;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox cmbAddress;
        private Guna.UI.WinForms.GunaComboBox cmbBookingType;
        private Guna.UI.WinForms.GunaComboBox cmbUniversity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}