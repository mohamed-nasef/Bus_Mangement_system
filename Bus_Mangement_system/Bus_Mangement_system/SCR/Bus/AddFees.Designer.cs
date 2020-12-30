
namespace Bus_Mangement_system.SCR.Bus
{
    partial class AddFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFees));
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbAddBusFees = new System.Windows.Forms.GroupBox();
            this.grbDetails = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPeriodicMaintenance = new System.Windows.Forms.Label();
            this.lblBusWash = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblLicenseRenewal = new System.Windows.Forms.Label();
            this.lblChangeOil = new System.Windows.Forms.Label();
            this.lblSolar = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtMoney = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBus = new Guna.UI.WinForms.GunaComboBox();
            this.cmbFeesType = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAssign = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClear = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAddBusFees = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.panelBody.SuspendLayout();
            this.grbAddBusFees.SuspendLayout();
            this.grbDetails.SuspendLayout();
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
            this.panelBody.Controls.Add(this.grbAddBusFees);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
            // 
            // grbAddBusFees
            // 
            this.grbAddBusFees.Controls.Add(this.btnAssign);
            this.grbAddBusFees.Controls.Add(this.grbDetails);
            this.grbAddBusFees.Controls.Add(this.btnClear);
            this.grbAddBusFees.Controls.Add(this.lblMoney);
            this.grbAddBusFees.Controls.Add(this.txtMoney);
            this.grbAddBusFees.Controls.Add(this.label1);
            this.grbAddBusFees.Controls.Add(this.label3);
            this.grbAddBusFees.Controls.Add(this.cmbBus);
            this.grbAddBusFees.Controls.Add(this.cmbFeesType);
            this.grbAddBusFees.Controls.Add(this.btnAddBusFees);
            this.grbAddBusFees.Controls.Add(this.label2);
            this.grbAddBusFees.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddBusFees.ForeColor = System.Drawing.Color.White;
            this.grbAddBusFees.Location = new System.Drawing.Point(368, 30);
            this.grbAddBusFees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAddBusFees.Name = "grbAddBusFees";
            this.grbAddBusFees.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAddBusFees.Size = new System.Drawing.Size(576, 833);
            this.grbAddBusFees.TabIndex = 39;
            this.grbAddBusFees.TabStop = false;
            this.grbAddBusFees.Text = "Add Bus Fees";
            // 
            // grbDetails
            // 
            this.grbDetails.Controls.Add(this.gunaButton2);
            this.grbDetails.Controls.Add(this.lblTotal);
            this.grbDetails.Controls.Add(this.lblPeriodicMaintenance);
            this.grbDetails.Controls.Add(this.lblBusWash);
            this.grbDetails.Controls.Add(this.lblOther);
            this.grbDetails.Controls.Add(this.lblLicenseRenewal);
            this.grbDetails.Controls.Add(this.lblChangeOil);
            this.grbDetails.Controls.Add(this.lblSolar);
            this.grbDetails.ForeColor = System.Drawing.Color.White;
            this.grbDetails.Location = new System.Drawing.Point(63, 438);
            this.grbDetails.Name = "grbDetails";
            this.grbDetails.Size = new System.Drawing.Size(461, 312);
            this.grbDetails.TabIndex = 53;
            this.grbDetails.TabStop = false;
            this.grbDetails.Text = "Details";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(23, 280);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 25);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "Total =";
            // 
            // lblPeriodicMaintenance
            // 
            this.lblPeriodicMaintenance.AutoSize = true;
            this.lblPeriodicMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriodicMaintenance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodicMaintenance.ForeColor = System.Drawing.Color.White;
            this.lblPeriodicMaintenance.Location = new System.Drawing.Point(23, 134);
            this.lblPeriodicMaintenance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodicMaintenance.Name = "lblPeriodicMaintenance";
            this.lblPeriodicMaintenance.Size = new System.Drawing.Size(213, 25);
            this.lblPeriodicMaintenance.TabIndex = 59;
            this.lblPeriodicMaintenance.Text = "Periodic Maintenance =";
            // 
            // lblBusWash
            // 
            this.lblBusWash.AutoSize = true;
            this.lblBusWash.BackColor = System.Drawing.Color.Transparent;
            this.lblBusWash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusWash.ForeColor = System.Drawing.Color.White;
            this.lblBusWash.Location = new System.Drawing.Point(291, 80);
            this.lblBusWash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusWash.Name = "lblBusWash";
            this.lblBusWash.Size = new System.Drawing.Size(111, 25);
            this.lblBusWash.TabIndex = 58;
            this.lblBusWash.Text = "Bus Wash =";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.BackColor = System.Drawing.Color.Transparent;
            this.lblOther.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.ForeColor = System.Drawing.Color.White;
            this.lblOther.Location = new System.Drawing.Point(291, 195);
            this.lblOther.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(78, 25);
            this.lblOther.TabIndex = 57;
            this.lblOther.Text = "Other =";
            // 
            // lblLicenseRenewal
            // 
            this.lblLicenseRenewal.AutoSize = true;
            this.lblLicenseRenewal.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenseRenewal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseRenewal.ForeColor = System.Drawing.Color.White;
            this.lblLicenseRenewal.Location = new System.Drawing.Point(23, 195);
            this.lblLicenseRenewal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseRenewal.Name = "lblLicenseRenewal";
            this.lblLicenseRenewal.Size = new System.Drawing.Size(167, 25);
            this.lblLicenseRenewal.TabIndex = 56;
            this.lblLicenseRenewal.Text = "License Renewal =";
            // 
            // lblChangeOil
            // 
            this.lblChangeOil.AutoSize = true;
            this.lblChangeOil.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeOil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeOil.ForeColor = System.Drawing.Color.White;
            this.lblChangeOil.Location = new System.Drawing.Point(23, 80);
            this.lblChangeOil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangeOil.Name = "lblChangeOil";
            this.lblChangeOil.Size = new System.Drawing.Size(121, 25);
            this.lblChangeOil.TabIndex = 55;
            this.lblChangeOil.Text = "Change oil =";
            // 
            // lblSolar
            // 
            this.lblSolar.AutoSize = true;
            this.lblSolar.BackColor = System.Drawing.Color.Transparent;
            this.lblSolar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolar.ForeColor = System.Drawing.Color.White;
            this.lblSolar.Location = new System.Drawing.Point(291, 134);
            this.lblSolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolar.Name = "lblSolar";
            this.lblSolar.Size = new System.Drawing.Size(73, 25);
            this.lblSolar.TabIndex = 54;
            this.lblSolar.Text = "Solar =";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Gray;
            this.lblMoney.Location = new System.Drawing.Point(308, 271);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(59, 17);
            this.lblMoney.TabIndex = 52;
            this.lblMoney.Text = "ex: $ 500";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.Transparent;
            this.txtMoney.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtMoney.BorderColor = System.Drawing.Color.Silver;
            this.txtMoney.BorderSize = 0;
            this.txtMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoney.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtMoney.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMoney.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtMoney.Location = new System.Drawing.Point(302, 264);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoney.MaxLength = 25;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.PasswordChar = '\0';
            this.txtMoney.Radius = 8;
            this.txtMoney.SelectedText = "";
            this.txtMoney.Size = new System.Drawing.Size(218, 32);
            this.txtMoney.TabIndex = 51;
            this.txtMoney.TextChanged += new System.EventHandler(this.TxtMoney_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 50;
            this.label1.Text = "Money";
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
            // cmbFeesType
            // 
            this.cmbFeesType.BackColor = System.Drawing.Color.Transparent;
            this.cmbFeesType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbFeesType.BorderColor = System.Drawing.Color.Black;
            this.cmbFeesType.BorderSize = 0;
            this.cmbFeesType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFeesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFeesType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFeesType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.cmbFeesType.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFeesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cmbFeesType.FormattingEnabled = true;
            this.cmbFeesType.Items.AddRange(new object[] {
            "Change Oil",
            "Periodic Maintenance",
            "License Renewal",
            "Bus Wash",
            "Solar",
            "Other"});
            this.cmbFeesType.Location = new System.Drawing.Point(63, 264);
            this.cmbFeesType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFeesType.Name = "cmbFeesType";
            this.cmbFeesType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFeesType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFeesType.Radius = 8;
            this.cmbFeesType.Size = new System.Drawing.Size(218, 31);
            this.cmbFeesType.TabIndex = 44;
            this.cmbFeesType.SelectedIndexChanged += new System.EventHandler(this.CmbFeesType_SelectedIndexChanged);
            this.cmbFeesType.Validating += new System.ComponentModel.CancelEventHandler(this.CmbFeesType_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fees Type";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btnAssign
            // 
            this.btnAssign.AnimationHoverSpeed = 0.07F;
            this.btnAssign.AnimationSpeed = 0.03F;
            this.btnAssign.BackColor = System.Drawing.Color.Transparent;
            this.btnAssign.BaseColor = System.Drawing.Color.Transparent;
            this.btnAssign.BorderColor = System.Drawing.Color.Black;
            this.btnAssign.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAssign.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAssign.CheckedForeColor = System.Drawing.Color.White;
            this.btnAssign.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAssign.CheckedImage")));
            this.btnAssign.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAssign.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAssign.FocusedColor = System.Drawing.Color.Empty;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Image = null;
            this.btnAssign.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAssign.LineBottom = 1;
            this.btnAssign.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
            this.btnAssign.Location = new System.Drawing.Point(302, 343);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
            this.btnAssign.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAssign.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAssign.OnHoverImage = null;
            this.btnAssign.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(225)))), ((int)(((byte)(175)))));
            this.btnAssign.OnPressedColor = System.Drawing.Color.Black;
            this.btnAssign.Radius = 8;
            this.btnAssign.Size = new System.Drawing.Size(218, 31);
            this.btnAssign.TabIndex = 55;
            this.btnAssign.Text = "Assign";
            this.btnAssign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAssign.Click += new System.EventHandler(this.BtnAssign_Click);
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BaseColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.Black;
            this.btnClear.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnClear.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClear.CheckedForeColor = System.Drawing.Color.White;
            this.btnClear.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnClear.CheckedImage")));
            this.btnClear.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = null;
            this.btnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear.LineBottom = 1;
            this.btnClear.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnClear.Location = new System.Drawing.Point(63, 343);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Radius = 8;
            this.btnClear.Size = new System.Drawing.Size(218, 31);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnAddBusFees
            // 
            this.btnAddBusFees.AnimationHoverSpeed = 0.07F;
            this.btnAddBusFees.AnimationSpeed = 0.03F;
            this.btnAddBusFees.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBusFees.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddBusFees.BorderColor = System.Drawing.Color.Black;
            this.btnAddBusFees.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddBusFees.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddBusFees.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddBusFees.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddBusFees.CheckedImage")));
            this.btnAddBusFees.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddBusFees.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddBusFees.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddBusFees.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBusFees.ForeColor = System.Drawing.Color.White;
            this.btnAddBusFees.Image = null;
            this.btnAddBusFees.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddBusFees.LineBottom = 1;
            this.btnAddBusFees.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddBusFees.Location = new System.Drawing.Point(59, 758);
            this.btnAddBusFees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBusFees.Name = "btnAddBusFees";
            this.btnAddBusFees.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnAddBusFees.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddBusFees.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddBusFees.OnHoverImage = null;
            this.btnAddBusFees.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddBusFees.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddBusFees.Radius = 10;
            this.btnAddBusFees.Size = new System.Drawing.Size(461, 42);
            this.btnAddBusFees.TabIndex = 25;
            this.btnAddBusFees.Text = "Add Fees";
            this.btnAddBusFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddBusFees.Click += new System.EventHandler(this.BtnAddBusFees_Click);
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
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::Bus_Mangement_system.Properties.Resources.icons8_gas_station_30;
            this.gunaButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton2.Location = new System.Drawing.Point(296, 254);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.gunaButton2.Radius = 8;
            this.gunaButton2.Size = new System.Drawing.Size(159, 51);
            this.gunaButton2.TabIndex = 61;
            this.gunaButton2.Text = "$ 0";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddFees
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
            this.Name = "AddFees";
            this.Text = "AddFees";
            this.Load += new System.EventHandler(this.AddFees_Load);
            this.panelBody.ResumeLayout(false);
            this.grbAddBusFees.ResumeLayout(false);
            this.grbAddBusFees.PerformLayout();
            this.grbDetails.ResumeLayout(false);
            this.grbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbAddBusFees;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbBus;
        private Guna.UI.WinForms.GunaComboBox cmbFeesType;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddBusFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaAdvenceButton btnAssign;
        private Guna.UI.WinForms.GunaAdvenceButton btnClear;
        private System.Windows.Forms.GroupBox grbDetails;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPeriodicMaintenance;
        private System.Windows.Forms.Label lblBusWash;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblLicenseRenewal;
        private System.Windows.Forms.Label lblChangeOil;
        private System.Windows.Forms.Label lblSolar;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}