
namespace Bus_Mangement_system.SCR.Bus
{
    partial class AddBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBus));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbAddBus = new System.Windows.Forms.GroupBox();
            this.lblLicenseNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbCapacity = new Guna.UI.WinForms.GunaComboBox();
            this.txtLicenseNumber = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddBus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelBody.SuspendLayout();
            this.grbAddBus.SuspendLayout();
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
            this.panelDraft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDraft.Name = "panelDraft";
            this.panelDraft.Size = new System.Drawing.Size(338, 1061);
            this.panelDraft.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grbAddBus);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1377, 1061);
            this.panelBody.TabIndex = 2;
            // 
            // grbAddBus
            // 
            this.grbAddBus.Controls.Add(this.lblLicenseNumber);
            this.grbAddBus.Controls.Add(this.lblName);
            this.grbAddBus.Controls.Add(this.cmbCapacity);
            this.grbAddBus.Controls.Add(this.txtLicenseNumber);
            this.grbAddBus.Controls.Add(this.btnAddBus);
            this.grbAddBus.Controls.Add(this.label4);
            this.grbAddBus.Controls.Add(this.label1);
            this.grbAddBus.Controls.Add(this.label2);
            this.grbAddBus.Controls.Add(this.txtName);
            this.grbAddBus.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddBus.ForeColor = System.Drawing.Color.White;
            this.grbAddBus.Location = new System.Drawing.Point(368, 30);
            this.grbAddBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAddBus.Name = "grbAddBus";
            this.grbAddBus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAddBus.Size = new System.Drawing.Size(576, 833);
            this.grbAddBus.TabIndex = 36;
            this.grbAddBus.TabStop = false;
            this.grbAddBus.Text = "Add Bus";
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
            this.lblName.Size = new System.Drawing.Size(58, 17);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "ex: Foton";
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
            "33",
            "50"});
            this.cmbCapacity.Location = new System.Drawing.Point(63, 520);
            this.cmbCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCapacity.Name = "cmbCapacity";
            this.cmbCapacity.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCapacity.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCapacity.Radius = 8;
            this.cmbCapacity.Size = new System.Drawing.Size(461, 31);
            this.cmbCapacity.TabIndex = 44;
            this.cmbCapacity.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCapacity_Validating);
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
            this.txtLicenseNumber.TextChanged += new System.EventHandler(this.txtLicenseNumber_TextChanged);
            this.txtLicenseNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseNumber_Validating);
            // 
            // btnAddBus
            // 
            this.btnAddBus.AnimationHoverSpeed = 0.07F;
            this.btnAddBus.AnimationSpeed = 0.03F;
            this.btnAddBus.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBus.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddBus.BorderColor = System.Drawing.Color.Black;
            this.btnAddBus.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddBus.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddBus.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddBus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddBus.CheckedImage")));
            this.btnAddBus.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddBus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddBus.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddBus.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBus.ForeColor = System.Drawing.Color.White;
            this.btnAddBus.Image = null;
            this.btnAddBus.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddBus.LineBottom = 1;
            this.btnAddBus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddBus.Location = new System.Drawing.Point(59, 758);
            this.btnAddBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnAddBus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddBus.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddBus.OnHoverImage = null;
            this.btnAddBus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddBus.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddBus.Radius = 10;
            this.btnAddBus.Size = new System.Drawing.Size(461, 42);
            this.btnAddBus.TabIndex = 25;
            this.btnAddBus.Text = "Add";
            this.btnAddBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
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
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
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
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 62);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddBus
            // 
            this.AcceptButton = this.btnAddBus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1715, 1061);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelDraft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddBus";
            this.Text = "AddBus";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.grbAddBus.ResumeLayout(false);
            this.grbAddBus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox grbAddBus;
        private Guna.UI.WinForms.GunaTextBox txtLicenseNumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI.WinForms.GunaComboBox cmbCapacity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLicenseNumber;
    }
}