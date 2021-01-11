namespace Bus_Mangement_system.SCR.Driver
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbSalary = new System.Windows.Forms.GroupBox();
            this.txtRestOfSalary = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.numMonth = new Guna.UI.WinForms.GunaNumeric();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDriver = new Guna.UI.WinForms.GunaComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalaryTaken = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddSalary = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBody.SuspendLayout();
            this.grbSalary.SuspendLayout();
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
            this.panelBody.Controls.Add(this.grbSalary);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
            // 
            // grbSalary
            // 
            this.grbSalary.Controls.Add(this.txtRestOfSalary);
            this.grbSalary.Controls.Add(this.label6);
            this.grbSalary.Controls.Add(this.btnSearch);
            this.grbSalary.Controls.Add(this.numMonth);
            this.grbSalary.Controls.Add(this.label3);
            this.grbSalary.Controls.Add(this.cmbDriver);
            this.grbSalary.Controls.Add(this.lblSalary);
            this.grbSalary.Controls.Add(this.txtSalary);
            this.grbSalary.Controls.Add(this.label5);
            this.grbSalary.Controls.Add(this.txtSalaryTaken);
            this.grbSalary.Controls.Add(this.btnAddSalary);
            this.grbSalary.Controls.Add(this.label1);
            this.grbSalary.Controls.Add(this.label2);
            this.grbSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalary.ForeColor = System.Drawing.Color.White;
            this.grbSalary.Location = new System.Drawing.Point(368, 30);
            this.grbSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbSalary.Name = "grbSalary";
            this.grbSalary.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbSalary.Size = new System.Drawing.Size(576, 833);
            this.grbSalary.TabIndex = 41;
            this.grbSalary.TabStop = false;
            this.grbSalary.Text = "Driver Salary";
            // 
            // txtRestOfSalary
            // 
            this.txtRestOfSalary.BackColor = System.Drawing.Color.Transparent;
            this.txtRestOfSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtRestOfSalary.BorderColor = System.Drawing.Color.Silver;
            this.txtRestOfSalary.BorderSize = 0;
            this.txtRestOfSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestOfSalary.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtRestOfSalary.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRestOfSalary.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtRestOfSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestOfSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtRestOfSalary.Location = new System.Drawing.Point(305, 397);
            this.txtRestOfSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRestOfSalary.MaxLength = 11;
            this.txtRestOfSalary.Name = "txtRestOfSalary";
            this.txtRestOfSalary.PasswordChar = '\0';
            this.txtRestOfSalary.Radius = 8;
            this.txtRestOfSalary.ReadOnly = true;
            this.txtRestOfSalary.SelectedText = "";
            this.txtRestOfSalary.Size = new System.Drawing.Size(218, 32);
            this.txtRestOfSalary.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(300, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 30);
            this.label6.TabIndex = 57;
            this.label6.Text = "Rest of salary";
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSearch.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.CheckedForeColor = System.Drawing.Color.White;
            this.btnSearch.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.CheckedImage")));
            this.btnSearch.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.LineBottom = 1;
            this.btnSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnSearch.Location = new System.Drawing.Point(306, 272);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 6;
            this.btnSearch.Size = new System.Drawing.Size(218, 31);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // numMonth
            // 
            this.numMonth.BackColor = System.Drawing.Color.Transparent;
            this.numMonth.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.numMonth.BorderColor = System.Drawing.Color.Silver;
            this.numMonth.BorderSize = 0;
            this.numMonth.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.numMonth.ButtonForeColor = System.Drawing.Color.White;
            this.numMonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.numMonth.Location = new System.Drawing.Point(63, 272);
            this.numMonth.Maximum = ((long)(12));
            this.numMonth.Minimum = ((long)(1));
            this.numMonth.Name = "numMonth";
            this.numMonth.Radius = 8;
            this.numMonth.Size = new System.Drawing.Size(218, 30);
            this.numMonth.TabIndex = 54;
            this.numMonth.Text = "numMonth";
            this.numMonth.Value = ((long)(1));
            this.numMonth.ValueChanged += new System.EventHandler(this.NumMonth_ValueChanged);
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
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Gray;
            this.lblSalary.Location = new System.Drawing.Point(69, 527);
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
            this.txtSalary.Location = new System.Drawing.Point(63, 520);
            this.txtSalary.MaxLength = 25;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.Radius = 8;
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(461, 32);
            this.txtSalary.TabIndex = 51;
            this.txtSalary.TextChanged += new System.EventHandler(this.TxtSalary_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 49;
            this.label5.Text = "Salary";
            // 
            // txtSalaryTaken
            // 
            this.txtSalaryTaken.BackColor = System.Drawing.Color.Transparent;
            this.txtSalaryTaken.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtSalaryTaken.BorderColor = System.Drawing.Color.Silver;
            this.txtSalaryTaken.BorderSize = 0;
            this.txtSalaryTaken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalaryTaken.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtSalaryTaken.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSalaryTaken.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtSalaryTaken.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtSalaryTaken.Location = new System.Drawing.Point(63, 396);
            this.txtSalaryTaken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalaryTaken.MaxLength = 11;
            this.txtSalaryTaken.Name = "txtSalaryTaken";
            this.txtSalaryTaken.PasswordChar = '\0';
            this.txtSalaryTaken.Radius = 8;
            this.txtSalaryTaken.ReadOnly = true;
            this.txtSalaryTaken.SelectedText = "";
            this.txtSalaryTaken.Size = new System.Drawing.Size(218, 32);
            this.txtSalaryTaken.TabIndex = 38;
            // 
            // btnAddSalary
            // 
            this.btnAddSalary.AnimationHoverSpeed = 0.07F;
            this.btnAddSalary.AnimationSpeed = 0.03F;
            this.btnAddSalary.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSalary.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddSalary.BorderColor = System.Drawing.Color.Black;
            this.btnAddSalary.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddSalary.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddSalary.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddSalary.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddSalary.CheckedImage")));
            this.btnAddSalary.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddSalary.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSalary.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSalary.ForeColor = System.Drawing.Color.White;
            this.btnAddSalary.Image = null;
            this.btnAddSalary.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddSalary.LineBottom = 1;
            this.btnAddSalary.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddSalary.Location = new System.Drawing.Point(59, 758);
            this.btnAddSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSalary.Name = "btnAddSalary";
            this.btnAddSalary.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnAddSalary.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddSalary.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddSalary.OnHoverImage = null;
            this.btnAddSalary.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddSalary.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddSalary.Radius = 10;
            this.btnAddSalary.Size = new System.Drawing.Size(461, 42);
            this.btnAddSalary.TabIndex = 25;
            this.btnAddSalary.Text = "Add";
            this.btnAddSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSalary.Click += new System.EventHandler(this.BtnAddSalary_Click);
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
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Month";
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
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Salary taken";
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
            this.btnClose.TabIndex = 40;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Salary
            // 
            this.AcceptButton = this.btnAddSalary;
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
            this.Name = "Salary";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panelBody.ResumeLayout(false);
            this.grbSalary.ResumeLayout(false);
            this.grbSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox grbSalary;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbDriver;
        private Guna.UI.WinForms.GunaTextBox txtSalary;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtSalaryTaken;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaNumeric numMonth;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private System.Windows.Forms.Label lblSalary;
        private Guna.UI.WinForms.GunaTextBox txtRestOfSalary;
        private System.Windows.Forms.Label label6;
    }
}