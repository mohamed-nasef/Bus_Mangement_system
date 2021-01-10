namespace Bus_Mangement_system.SCR.Driver
{
    partial class EditDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDriver));
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbEditDriver = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDriver = new Guna.UI.WinForms.GunaComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.btnEditDriver = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDriverName = new Guna.UI.WinForms.GunaTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBody.SuspendLayout();
            this.grbEditDriver.SuspendLayout();
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
            this.panelBody.Controls.Add(this.grbEditDriver);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
            // 
            // grbEditDriver
            // 
            this.grbEditDriver.Controls.Add(this.label3);
            this.grbEditDriver.Controls.Add(this.cmbDriver);
            this.grbEditDriver.Controls.Add(this.lblSalary);
            this.grbEditDriver.Controls.Add(this.txtSalary);
            this.grbEditDriver.Controls.Add(this.label5);
            this.grbEditDriver.Controls.Add(this.lblAddress);
            this.grbEditDriver.Controls.Add(this.lblPhone);
            this.grbEditDriver.Controls.Add(this.txtAddress);
            this.grbEditDriver.Controls.Add(this.lblName);
            this.grbEditDriver.Controls.Add(this.txtPhone);
            this.grbEditDriver.Controls.Add(this.btnEditDriver);
            this.grbEditDriver.Controls.Add(this.label4);
            this.grbEditDriver.Controls.Add(this.label1);
            this.grbEditDriver.Controls.Add(this.label2);
            this.grbEditDriver.Controls.Add(this.txtDriverName);
            this.grbEditDriver.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditDriver.ForeColor = System.Drawing.Color.White;
            this.grbEditDriver.Location = new System.Drawing.Point(368, 30);
            this.grbEditDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEditDriver.Name = "grbEditDriver";
            this.grbEditDriver.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbEditDriver.Size = new System.Drawing.Size(576, 833);
            this.grbEditDriver.TabIndex = 39;
            this.grbEditDriver.TabStop = false;
            this.grbEditDriver.Text = "Edit Driver";
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
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 53;
            this.label3.Text = "Choose Driver";
            // 
            // cmbDriver
            // 
            this.cmbDriver.BackColor = System.Drawing.Color.Transparent;
            this.cmbDriver.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbDriver.BorderColor = System.Drawing.Color.Black;
            this.cmbDriver.BorderSize = 0;
            this.cmbDriver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDriver.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.cmbDriver.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(63, 148);
            this.cmbDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDriver.MaxDropDownItems = 10;
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbDriver.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbDriver.Radius = 8;
            this.cmbDriver.Size = new System.Drawing.Size(461, 31);
            this.cmbDriver.TabIndex = 52;
            this.cmbDriver.SelectedIndexChanged += new System.EventHandler(this.CmbDriver_SelectedIndexChanged);
            this.cmbDriver.Validating += new System.ComponentModel.CancelEventHandler(this.CmbDriver_Validating);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Gray;
            this.lblSalary.Location = new System.Drawing.Point(69, 651);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(55, 17);
            this.lblSalary.TabIndex = 50;
            this.lblSalary.Text = "ex: 5000";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Transparent;
            this.txtSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtSalary.BorderColor = System.Drawing.Color.Silver;
            this.txtSalary.BorderSize = 0;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtSalary.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSalary.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtSalary.Location = new System.Drawing.Point(63, 644);
            this.txtSalary.MaxLength = 25;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.Radius = 8;
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(461, 32);
            this.txtSalary.TabIndex = 51;
            this.txtSalary.TextChanged += new System.EventHandler(this.TxtSalary_TextChanged);
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSalary_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 598);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 49;
            this.label5.Text = "Salary";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(69, 527);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 17);
            this.lblAddress.TabIndex = 46;
            this.lblAddress.Text = "ex: Mansoura";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(69, 403);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(99, 17);
            this.lblPhone.TabIndex = 48;
            this.lblPhone.Text = "ex: 01021782433";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.BorderSize = 0;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtAddress.Location = new System.Drawing.Point(63, 520);
            this.txtAddress.MaxLength = 25;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.Radius = 8;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(461, 32);
            this.txtAddress.TabIndex = 47;
            this.txtAddress.TextChanged += new System.EventHandler(this.TxtAddress_TextChanged);
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAddress_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(69, 279);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 17);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "ex: Mohamed";
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
            this.txtPhone.Location = new System.Drawing.Point(63, 396);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 8;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(461, 32);
            this.txtPhone.TabIndex = 38;
            this.txtPhone.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPhone_Validating);
            // 
            // btnEditDriver
            // 
            this.btnEditDriver.AnimationHoverSpeed = 0.07F;
            this.btnEditDriver.AnimationSpeed = 0.03F;
            this.btnEditDriver.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDriver.BaseColor = System.Drawing.Color.Transparent;
            this.btnEditDriver.BorderColor = System.Drawing.Color.Black;
            this.btnEditDriver.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEditDriver.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEditDriver.CheckedForeColor = System.Drawing.Color.White;
            this.btnEditDriver.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEditDriver.CheckedImage")));
            this.btnEditDriver.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEditDriver.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditDriver.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditDriver.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDriver.ForeColor = System.Drawing.Color.White;
            this.btnEditDriver.Image = null;
            this.btnEditDriver.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditDriver.LineBottom = 1;
            this.btnEditDriver.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnEditDriver.Location = new System.Drawing.Point(59, 758);
            this.btnEditDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditDriver.Name = "btnEditDriver";
            this.btnEditDriver.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnEditDriver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditDriver.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditDriver.OnHoverImage = null;
            this.btnEditDriver.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnEditDriver.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditDriver.Radius = 10;
            this.btnEditDriver.Size = new System.Drawing.Size(461, 42);
            this.btnEditDriver.TabIndex = 25;
            this.btnEditDriver.Text = "Edit";
            this.btnEditDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditDriver.Click += new System.EventHandler(this.BtnEditDriver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 474);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Address";
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
            this.label2.Location = new System.Drawing.Point(58, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Phone";
            // 
            // txtDriverName
            // 
            this.txtDriverName.BackColor = System.Drawing.Color.Transparent;
            this.txtDriverName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtDriverName.BorderColor = System.Drawing.Color.Silver;
            this.txtDriverName.BorderSize = 0;
            this.txtDriverName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDriverName.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtDriverName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDriverName.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtDriverName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtDriverName.Location = new System.Drawing.Point(63, 272);
            this.txtDriverName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDriverName.MaxLength = 25;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.PasswordChar = '\0';
            this.txtDriverName.Radius = 8;
            this.txtDriverName.SelectedText = "";
            this.txtDriverName.Size = new System.Drawing.Size(461, 32);
            this.txtDriverName.TabIndex = 26;
            this.txtDriverName.TextChanged += new System.EventHandler(this.TxtDriverName_TextChanged);
            this.txtDriverName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDriverName_Validating);
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
            this.btnClose.TabIndex = 38;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // EditDriver
            // 
            this.AcceptButton = this.btnEditDriver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1491, 881);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelDraft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditDriver";
            this.Text = "EditDriver";
            this.Load += new System.EventHandler(this.EditDriver_Load);
            this.panelBody.ResumeLayout(false);
            this.grbEditDriver.ResumeLayout(false);
            this.grbEditDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox grbEditDriver;
        private System.Windows.Forms.Label lblSalary;
        private Guna.UI.WinForms.GunaTextBox txtSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private System.Windows.Forms.Label lblName;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaAdvenceButton btnEditDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtDriverName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbDriver;
    }
}