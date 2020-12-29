namespace Bus_Mangement_system.SCR.Bus
{
    partial class BusReport
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
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbBusReport = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBus = new Guna.UI.WinForms.GunaComboBox();
            this.txtLicenseNumber = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.txtCapacity = new Guna.UI.WinForms.GunaTextBox();
            this.panelBody.SuspendLayout();
            this.grbBusReport.SuspendLayout();
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
            this.panelBody.Controls.Add(this.grbBusReport);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
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
            this.btnClose.TabIndex = 38;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // grbBusReport
            // 
            this.grbBusReport.Controls.Add(this.txtCapacity);
            this.grbBusReport.Controls.Add(this.label3);
            this.grbBusReport.Controls.Add(this.cmbBus);
            this.grbBusReport.Controls.Add(this.txtLicenseNumber);
            this.grbBusReport.Controls.Add(this.label4);
            this.grbBusReport.Controls.Add(this.label1);
            this.grbBusReport.Controls.Add(this.label2);
            this.grbBusReport.Controls.Add(this.txtName);
            this.grbBusReport.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusReport.ForeColor = System.Drawing.Color.White;
            this.grbBusReport.Location = new System.Drawing.Point(368, 30);
            this.grbBusReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBusReport.Name = "grbBusReport";
            this.grbBusReport.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbBusReport.Size = new System.Drawing.Size(576, 833);
            this.grbBusReport.TabIndex = 39;
            this.grbBusReport.TabStop = false;
            this.grbBusReport.Text = "Bus Report";
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
            this.txtLicenseNumber.ReadOnly = true;
            this.txtLicenseNumber.SelectedText = "";
            this.txtLicenseNumber.Size = new System.Drawing.Size(461, 32);
            this.txtLicenseNumber.TabIndex = 38;
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
            this.txtName.ReadOnly = true;
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(461, 32);
            this.txtName.TabIndex = 26;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BackColor = System.Drawing.Color.Transparent;
            this.txtCapacity.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtCapacity.BorderColor = System.Drawing.Color.Silver;
            this.txtCapacity.BorderSize = 0;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtCapacity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCapacity.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtCapacity.Location = new System.Drawing.Point(63, 520);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCapacity.MaxLength = 9;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.Radius = 8;
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.SelectedText = "";
            this.txtCapacity.Size = new System.Drawing.Size(461, 32);
            this.txtCapacity.TabIndex = 49;
            // 
            // BusReport
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
            this.Name = "BusReport";
            this.Text = "BusReport";
            this.Load += new System.EventHandler(this.BusReport_Load);
            this.panelBody.ResumeLayout(false);
            this.grbBusReport.ResumeLayout(false);
            this.grbBusReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbBusReport;
        private Guna.UI.WinForms.GunaTextBox txtCapacity;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbBus;
        private Guna.UI.WinForms.GunaTextBox txtLicenseNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtName;
    }
}