
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grbAddBusFees = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBus = new Guna.UI.WinForms.GunaComboBox();
            this.cmbExpensesType = new Guna.UI.WinForms.GunaComboBox();
            this.btnAddBusFees = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoney = new Guna.UI.WinForms.GunaTextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBody.SuspendLayout();
            this.grbAddBusFees.SuspendLayout();
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
            // 
            // grbAddBusFees
            // 
            this.grbAddBusFees.Controls.Add(this.lblMoney);
            this.grbAddBusFees.Controls.Add(this.txtMoney);
            this.grbAddBusFees.Controls.Add(this.label1);
            this.grbAddBusFees.Controls.Add(this.label3);
            this.grbAddBusFees.Controls.Add(this.cmbBus);
            this.grbAddBusFees.Controls.Add(this.cmbExpensesType);
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
            // 
            // cmbExpensesType
            // 
            this.cmbExpensesType.BackColor = System.Drawing.Color.Transparent;
            this.cmbExpensesType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.cmbExpensesType.BorderColor = System.Drawing.Color.Black;
            this.cmbExpensesType.BorderSize = 0;
            this.cmbExpensesType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpensesType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbExpensesType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.cmbExpensesType.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpensesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.cmbExpensesType.FormattingEnabled = true;
            this.cmbExpensesType.Items.AddRange(new object[] {
            "Oil",
            "Gas"});
            this.cmbExpensesType.Location = new System.Drawing.Point(63, 272);
            this.cmbExpensesType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbExpensesType.Name = "cmbExpensesType";
            this.cmbExpensesType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbExpensesType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbExpensesType.Radius = 8;
            this.cmbExpensesType.Size = new System.Drawing.Size(461, 31);
            this.cmbExpensesType.TabIndex = 44;
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
            this.label2.Size = new System.Drawing.Size(152, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Expenses Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 50;
            this.label1.Text = "Money";
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
            this.txtMoney.Location = new System.Drawing.Point(63, 396);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoney.MaxLength = 25;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.PasswordChar = '\0';
            this.txtMoney.Radius = 8;
            this.txtMoney.SelectedText = "";
            this.txtMoney.Size = new System.Drawing.Size(461, 32);
            this.txtMoney.TabIndex = 51;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblMoney.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Gray;
            this.lblMoney.Location = new System.Drawing.Point(69, 403);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(78, 17);
            this.lblMoney.TabIndex = 52;
            this.lblMoney.Text = "ex: 1234 KFC";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
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
            this.panelBody.ResumeLayout(false);
            this.grbAddBusFees.ResumeLayout(false);
            this.grbAddBusFees.PerformLayout();
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
        private Guna.UI.WinForms.GunaComboBox cmbExpensesType;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddBusFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}