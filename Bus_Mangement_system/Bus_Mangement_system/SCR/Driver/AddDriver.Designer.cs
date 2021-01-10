
namespace Bus_Mangement_system.SCR.Driver
{
    partial class AddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriver));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbAddBus = new System.Windows.Forms.GroupBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddDriver = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDriverName = new Guna.UI.WinForms.GunaTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.grbAddBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 881);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grbAddBus);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(338, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 881);
            this.panel2.TabIndex = 2;
            // 
            // grbAddBus
            // 
            this.grbAddBus.Controls.Add(this.lblSalary);
            this.grbAddBus.Controls.Add(this.txtSalary);
            this.grbAddBus.Controls.Add(this.label5);
            this.grbAddBus.Controls.Add(this.lblAddress);
            this.grbAddBus.Controls.Add(this.lblPhone);
            this.grbAddBus.Controls.Add(this.txtAddress);
            this.grbAddBus.Controls.Add(this.lblName);
            this.grbAddBus.Controls.Add(this.txtPhone);
            this.grbAddBus.Controls.Add(this.btnAddDriver);
            this.grbAddBus.Controls.Add(this.label4);
            this.grbAddBus.Controls.Add(this.label1);
            this.grbAddBus.Controls.Add(this.label2);
            this.grbAddBus.Controls.Add(this.txtDriverName);
            this.grbAddBus.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddBus.ForeColor = System.Drawing.Color.White;
            this.grbAddBus.Location = new System.Drawing.Point(368, 30);
            this.grbAddBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAddBus.Name = "grbAddBus";
            this.grbAddBus.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbAddBus.Size = new System.Drawing.Size(576, 833);
            this.grbAddBus.TabIndex = 37;
            this.grbAddBus.TabStop = false;
            this.grbAddBus.Text = "Add Driver";
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
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSalary_Validating);
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
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(69, 403);
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
            this.lblPhone.Location = new System.Drawing.Point(69, 279);
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
            this.txtAddress.Location = new System.Drawing.Point(63, 396);
            this.txtAddress.MaxLength = 25;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.Radius = 8;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(461, 32);
            this.txtAddress.TabIndex = 47;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblName.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(69, 155);
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
            this.txtPhone.Location = new System.Drawing.Point(63, 272);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Radius = 8;
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(461, 32);
            this.txtPhone.TabIndex = 38;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.AnimationHoverSpeed = 0.07F;
            this.btnAddDriver.AnimationSpeed = 0.03F;
            this.btnAddDriver.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDriver.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddDriver.BorderColor = System.Drawing.Color.Black;
            this.btnAddDriver.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddDriver.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddDriver.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddDriver.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddDriver.CheckedImage")));
            this.btnAddDriver.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddDriver.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDriver.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddDriver.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDriver.ForeColor = System.Drawing.Color.White;
            this.btnAddDriver.Image = null;
            this.btnAddDriver.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddDriver.LineBottom = 1;
            this.btnAddDriver.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddDriver.Location = new System.Drawing.Point(59, 758);
            this.btnAddDriver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnAddDriver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDriver.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDriver.OnHoverImage = null;
            this.btnAddDriver.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddDriver.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDriver.Radius = 10;
            this.btnAddDriver.Size = new System.Drawing.Size(461, 42);
            this.btnAddDriver.TabIndex = 25;
            this.btnAddDriver.Text = "Add";
            this.btnAddDriver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
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
            this.label1.Location = new System.Drawing.Point(58, 102);
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
            this.label2.Location = new System.Drawing.Point(58, 226);
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
            this.txtDriverName.Location = new System.Drawing.Point(63, 148);
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
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // AddDriver
            // 
            this.AcceptButton = this.btnAddDriver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1491, 881);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDriver";
            this.Text = "AddDriver";
            this.Load += new System.EventHandler(this.AddDriver_Load);
            this.panel2.ResumeLayout(false);
            this.grbAddBus.ResumeLayout(false);
            this.grbAddBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbAddBus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtDriverName;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSalary;
        private Guna.UI.WinForms.GunaTextBox txtSalary;
        private System.Windows.Forms.Label label5;
    }
}