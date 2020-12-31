namespace Bus_Mangement_system.SCR.Modify_Price
{
    partial class ModifyPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyPrice));
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbModifyPrice = new System.Windows.Forms.GroupBox();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.cmbBookingType = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPrice = new Guna.UI.WinForms.GunaTextBox();
            this.btnModifyPrice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPrice = new Guna.UI.WinForms.GunaTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBody.SuspendLayout();
            this.grbModifyPrice.SuspendLayout();
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
            this.panelBody.Controls.Add(this.grbModifyPrice);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
            // 
            // grbModifyPrice
            // 
            this.grbModifyPrice.Controls.Add(this.lblNewPrice);
            this.grbModifyPrice.Controls.Add(this.cmbBookingType);
            this.grbModifyPrice.Controls.Add(this.label5);
            this.grbModifyPrice.Controls.Add(this.label4);
            this.grbModifyPrice.Controls.Add(this.txtNewPrice);
            this.grbModifyPrice.Controls.Add(this.btnModifyPrice);
            this.grbModifyPrice.Controls.Add(this.label1);
            this.grbModifyPrice.Controls.Add(this.txtOldPrice);
            this.grbModifyPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModifyPrice.ForeColor = System.Drawing.Color.White;
            this.grbModifyPrice.Location = new System.Drawing.Point(368, 30);
            this.grbModifyPrice.Name = "grbModifyPrice";
            this.grbModifyPrice.Size = new System.Drawing.Size(576, 833);
            this.grbModifyPrice.TabIndex = 38;
            this.grbModifyPrice.TabStop = false;
            this.grbModifyPrice.Text = "Modify Price";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblNewPrice.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblNewPrice.Location = new System.Drawing.Point(312, 279);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(59, 17);
            this.lblNewPrice.TabIndex = 42;
            this.lblNewPrice.Text = "ex: $ 500";
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
            this.cmbBookingType.Location = new System.Drawing.Point(63, 148);
            this.cmbBookingType.Name = "cmbBookingType";
            this.cmbBookingType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbBookingType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBookingType.Radius = 8;
            this.cmbBookingType.Size = new System.Drawing.Size(461, 31);
            this.cmbBookingType.TabIndex = 41;
            this.cmbBookingType.SelectedIndexChanged += new System.EventHandler(this.CmbBookingType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(307, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "New Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Booking Type";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPrice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNewPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtNewPrice.BorderSize = 0;
            this.txtNewPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPrice.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtNewPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNewPrice.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtNewPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtNewPrice.Location = new System.Drawing.Point(306, 272);
            this.txtNewPrice.MaxLength = 25;
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.PasswordChar = '\0';
            this.txtNewPrice.Radius = 8;
            this.txtNewPrice.SelectedText = "";
            this.txtNewPrice.Size = new System.Drawing.Size(218, 32);
            this.txtNewPrice.TabIndex = 30;
            this.txtNewPrice.TextChanged += new System.EventHandler(this.TxtNewPrice_TextChanged);
            // 
            // btnModifyPrice
            // 
            this.btnModifyPrice.AnimationHoverSpeed = 0.07F;
            this.btnModifyPrice.AnimationSpeed = 0.03F;
            this.btnModifyPrice.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyPrice.BaseColor = System.Drawing.Color.Transparent;
            this.btnModifyPrice.BorderColor = System.Drawing.Color.Black;
            this.btnModifyPrice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnModifyPrice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnModifyPrice.CheckedForeColor = System.Drawing.Color.White;
            this.btnModifyPrice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnModifyPrice.CheckedImage")));
            this.btnModifyPrice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnModifyPrice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModifyPrice.FocusedColor = System.Drawing.Color.Empty;
            this.btnModifyPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyPrice.ForeColor = System.Drawing.Color.White;
            this.btnModifyPrice.Image = null;
            this.btnModifyPrice.ImageSize = new System.Drawing.Size(20, 20);
            this.btnModifyPrice.LineBottom = 1;
            this.btnModifyPrice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnModifyPrice.Location = new System.Drawing.Point(59, 758);
            this.btnModifyPrice.Name = "btnModifyPrice";
            this.btnModifyPrice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnModifyPrice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModifyPrice.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModifyPrice.OnHoverImage = null;
            this.btnModifyPrice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnModifyPrice.OnPressedColor = System.Drawing.Color.Black;
            this.btnModifyPrice.Radius = 10;
            this.btnModifyPrice.Size = new System.Drawing.Size(461, 42);
            this.btnModifyPrice.TabIndex = 25;
            this.btnModifyPrice.Text = "Modify";
            this.btnModifyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModifyPrice.Click += new System.EventHandler(this.BtnModifyPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Old Price";
            // 
            // txtOldPrice
            // 
            this.txtOldPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtOldPrice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtOldPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtOldPrice.BorderSize = 0;
            this.txtOldPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPrice.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtOldPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOldPrice.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtOldPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtOldPrice.Location = new System.Drawing.Point(63, 272);
            this.txtOldPrice.MaxLength = 25;
            this.txtOldPrice.Name = "txtOldPrice";
            this.txtOldPrice.PasswordChar = '\0';
            this.txtOldPrice.Radius = 8;
            this.txtOldPrice.ReadOnly = true;
            this.txtOldPrice.SelectedText = "";
            this.txtOldPrice.Size = new System.Drawing.Size(218, 32);
            this.txtOldPrice.TabIndex = 26;
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
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // ModifyPrice
            // 
            this.AcceptButton = this.btnModifyPrice;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1491, 881);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelDraft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModifyPrice";
            this.Text = "ModifyPrice";
            this.Load += new System.EventHandler(this.ModifyPrice_Load);
            this.panelBody.ResumeLayout(false);
            this.grbModifyPrice.ResumeLayout(false);
            this.grbModifyPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox grbModifyPrice;
        private System.Windows.Forms.Label lblNewPrice;
        private Guna.UI.WinForms.GunaComboBox cmbBookingType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtNewPrice;
        private Guna.UI.WinForms.GunaAdvenceButton btnModifyPrice;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtOldPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}