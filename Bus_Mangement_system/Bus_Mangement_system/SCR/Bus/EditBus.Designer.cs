namespace Bus_Mangement_system.SCR.Bus
{
    partial class EditBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBus));
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbEditBus = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBus = new Guna.UI.WinForms.GunaComboBox();
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbCapacity = new Guna.UI.WinForms.GunaComboBox();
            this.txtLicenseNumber = new Guna.UI.WinForms.GunaTextBox();
            this.btnEditBus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBody.SuspendLayout();
            this.grbEditBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.panelBody.Controls.Add(this.grbEditBus);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
            // 
            // grbEditBus
            // 
            this.grbEditBus.Controls.Add(this.label3);
            this.grbEditBus.Controls.Add(this.cmbBus);
            this.grbEditBus.Controls.Add(this.lblLicenseNumber);
            this.grbEditBus.Controls.Add(this.lblName);
            this.grbEditBus.Controls.Add(this.cmbCapacity);
            this.grbEditBus.Controls.Add(this.txtLicenseNumber);
            this.grbEditBus.Controls.Add(this.btnEditBus);
            this.grbEditBus.Controls.Add(this.label4);
            this.grbEditBus.Controls.Add(this.label1);
            this.grbEditBus.Controls.Add(this.label2);
            this.grbEditBus.Controls.Add(this.txtName);
            this.grbEditBus.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditBus.ForeColor = System.Drawing.Color.White;
            this.grbEditBus.Location = new System.Drawing.Point(368, 30);
            this.grbEditBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEditBus.Name = "grbEditBus";
            this.grbEditBus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEditBus.Size = new System.Drawing.Size(576, 833);
            this.grbEditBus.TabIndex = 38;
            this.grbEditBus.TabStop = false;
            this.grbEditBus.Text = "Edit Bus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 30);
            this.label3.TabIndex = 48;
            this.label3.Text = "Choose Bus";
            // 
            // cmbBus
            // 
            this.cmbBus.BackColor = System.Drawing.Color.Transparent;
            this.cmbBus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbBus.BorderColor = System.Drawing.Color.Black;
            this.cmbBus.BorderSize = 0;
            this.cmbBus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.cmbBus.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Items.AddRange(new object[] {
            "Bus 1",
            "Bus 2",
            "Bus 3",
            "Bus 4"});
            this.cmbBus.Location = new System.Drawing.Point(63, 148);
            this.cmbBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBus.MaxDropDownItems = 10;
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbBus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBus.Radius = 8;
            this.cmbBus.Size = new System.Drawing.Size(461, 31);
            this.cmbBus.TabIndex = 47;
            this.cmbBus.SelectedIndexChanged += new System.EventHandler(this.CmbBus_SelectedIndexChanged);
            this.cmbBus.Validating += new System.ComponentModel.CancelEventHandler(this.CmbBus_Validating);
            // 
            // lblLicenseNumber
            // 
            this.lblLicenseNumber.AutoSize = true;
            this.lblLicenseNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblLicenseNumber.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblLicenseNumber.Location = new System.Drawing.Point(69, 403);
            this.lblLicenseNumber.Name = "lblLicenseNumber";
            this.lblLicenseNumber.Size = new System.Drawing.Size(78, 17);
            this.lblLicenseNumber.TabIndex = 46;
            this.lblLicenseNumber.Text = "ex: 1234 KFC";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(69, 279);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 17);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "ex: Hashim";
            // 
            // cmbCapacity
            // 
            this.cmbCapacity.BackColor = System.Drawing.Color.Transparent;
            this.cmbCapacity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbCapacity.BorderColor = System.Drawing.Color.Black;
            this.cmbCapacity.BorderSize = 0;
            this.cmbCapacity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCapacity.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.cmbCapacity.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cmbCapacity.FormattingEnabled = true;
            this.cmbCapacity.Items.AddRange(new object[] {
            "14",
            "32",
            "52"});
            this.cmbCapacity.Location = new System.Drawing.Point(63, 520);
            this.cmbCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCapacity.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCapacity.Radius = 8;
            this.cmbCapacity.Size = new System.Drawing.Size(461, 31);
            this.cmbCapacity.TabIndex = 44;
            this.cmbCapacity.Validating += new System.ComponentModel.CancelEventHandler(this.CmbCapacity_Validating);
            // 
            // txtLicenseNumber
            // 
            this.txtLicenseNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtLicenseNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtLicenseNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtLicenseNumber.BorderSize = 0;
            this.txtLicenseNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLicenseNumber.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtLicenseNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLicenseNumber.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtLicenseNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtLicenseNumber.Location = new System.Drawing.Point(63, 396);
            this.txtLicenseNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLicenseNumber.MaxLength = 9;
            this.txtLicenseNumber.Name = "txtLicenseNumber";
            this.txtLicenseNumber.PasswordChar = '\0';
            this.txtLicenseNumber.Radius = 8;
            this.txtLicenseNumber.SelectedText = "";
            this.txtLicenseNumber.Size = new System.Drawing.Size(461, 32);
            this.txtLicenseNumber.TabIndex = 38;
            this.txtLicenseNumber.TextChanged += new System.EventHandler(this.TxtLicenseNumber_TextChanged);
            this.txtLicenseNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLicenseNumber_Validating);
            // 
            // btnEditBus
            // 
            this.btnEditBus.AnimationHoverSpeed = 0.07F;
            this.btnEditBus.AnimationSpeed = 0.03F;
            this.btnEditBus.BackColor = System.Drawing.Color.Transparent;
            this.btnEditBus.BaseColor = System.Drawing.Color.Transparent;
            this.btnEditBus.BorderColor = System.Drawing.Color.Black;
            this.btnEditBus.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEditBus.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEditBus.CheckedForeColor = System.Drawing.Color.White;
            this.btnEditBus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEditBus.CheckedImage")));
            this.btnEditBus.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEditBus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditBus.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditBus.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBus.ForeColor = System.Drawing.Color.White;
            this.btnEditBus.Image = null;
            this.btnEditBus.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditBus.LineBottom = 1;
            this.btnEditBus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnEditBus.Location = new System.Drawing.Point(59, 758);
            this.btnEditBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditBus.Name = "btnEditBus";
            this.btnEditBus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnEditBus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditBus.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditBus.OnHoverImage = null;
            this.btnEditBus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnEditBus.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditBus.Radius = 10;
            this.btnEditBus.Size = new System.Drawing.Size(461, 42);
            this.btnEditBus.TabIndex = 25;
            this.btnEditBus.Text = "Edit";
            this.btnEditBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditBus.Click += new System.EventHandler(this.BtnEditBus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "License Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 474);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Capacity";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.BorderSize = 0;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtName.Location = new System.Drawing.Point(63, 272);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.Radius = 8;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(461, 32);
            this.txtName.TabIndex = 26;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
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
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 62);
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // EditBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1491, 881);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelDraft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditBus";
            this.Text = "EditBus";
            this.Load += new System.EventHandler(this.EditBus_Load);
            this.panelBody.ResumeLayout(false);
            this.grbEditBus.ResumeLayout(false);
            this.grbEditBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox grbEditBus;
        private System.Windows.Forms.Label lblLicenseNumber;
        private System.Windows.Forms.Label lblName;
        private Guna.UI.WinForms.GunaComboBox cmbCapacity;
        private Guna.UI.WinForms.GunaTextBox txtLicenseNumber;
        private Guna.UI.WinForms.GunaAdvenceButton btnEditBus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI.WinForms.GunaComboBox cmbBus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}