
namespace Bus_Mangement_system.SCR.Daily_Ticket
{
    partial class AddDailyTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDailyTickets));
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grbAddDailyTickets = new System.Windows.Forms.GroupBox();
            this.lblRoundTrip = new System.Windows.Forms.Label();
            this.txtRoundTrip = new Guna.UI.WinForms.GunaTextBox();
            this.lblOneWay = new System.Windows.Forms.Label();
            this.txtOneWay = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddDailyTickets = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBody.SuspendLayout();
            this.grbAddDailyTickets.SuspendLayout();
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
            this.panelBody.Controls.Add(this.grbAddDailyTickets);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
            // 
            // grbAddDailyTickets
            // 
            this.grbAddDailyTickets.Controls.Add(this.lblRoundTrip);
            this.grbAddDailyTickets.Controls.Add(this.txtRoundTrip);
            this.grbAddDailyTickets.Controls.Add(this.lblOneWay);
            this.grbAddDailyTickets.Controls.Add(this.txtOneWay);
            this.grbAddDailyTickets.Controls.Add(this.label4);
            this.grbAddDailyTickets.Controls.Add(this.btnAddDailyTickets);
            this.grbAddDailyTickets.Controls.Add(this.label2);
            this.grbAddDailyTickets.Font = new System.Drawing.Font("Segoe UI Semibold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddDailyTickets.ForeColor = System.Drawing.Color.White;
            this.grbAddDailyTickets.Location = new System.Drawing.Point(368, 30);
            this.grbAddDailyTickets.Name = "grbAddDailyTickets";
            this.grbAddDailyTickets.Size = new System.Drawing.Size(576, 833);
            this.grbAddDailyTickets.TabIndex = 38;
            this.grbAddDailyTickets.TabStop = false;
            this.grbAddDailyTickets.Text = "Add Daily Tickets";
            // 
            // lblRoundTrip
            // 
            this.lblRoundTrip.AutoSize = true;
            this.lblRoundTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblRoundTrip.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundTrip.ForeColor = System.Drawing.Color.Gray;
            this.lblRoundTrip.Location = new System.Drawing.Point(69, 403);
            this.lblRoundTrip.Name = "lblRoundTrip";
            this.lblRoundTrip.Size = new System.Drawing.Size(39, 17);
            this.lblRoundTrip.TabIndex = 45;
            this.lblRoundTrip.Text = "ex: 10";
            // 
            // txtRoundTrip
            // 
            this.txtRoundTrip.BackColor = System.Drawing.Color.Transparent;
            this.txtRoundTrip.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtRoundTrip.BorderColor = System.Drawing.Color.Silver;
            this.txtRoundTrip.BorderSize = 0;
            this.txtRoundTrip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoundTrip.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtRoundTrip.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRoundTrip.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtRoundTrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundTrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtRoundTrip.Location = new System.Drawing.Point(63, 396);
            this.txtRoundTrip.MaxLength = 11;
            this.txtRoundTrip.Name = "txtRoundTrip";
            this.txtRoundTrip.PasswordChar = '\0';
            this.txtRoundTrip.Radius = 8;
            this.txtRoundTrip.SelectedText = "";
            this.txtRoundTrip.Size = new System.Drawing.Size(461, 32);
            this.txtRoundTrip.TabIndex = 44;
            this.txtRoundTrip.TextChanged += new System.EventHandler(this.txtRoundTrip_TextChanged);
            // 
            // lblOneWay
            // 
            this.lblOneWay.AutoSize = true;
            this.lblOneWay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblOneWay.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneWay.ForeColor = System.Drawing.Color.Gray;
            this.lblOneWay.Location = new System.Drawing.Point(69, 279);
            this.lblOneWay.Name = "lblOneWay";
            this.lblOneWay.Size = new System.Drawing.Size(34, 17);
            this.lblOneWay.TabIndex = 43;
            this.lblOneWay.Text = "ex: 5";
            // 
            // txtOneWay
            // 
            this.txtOneWay.BackColor = System.Drawing.Color.Transparent;
            this.txtOneWay.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtOneWay.BorderColor = System.Drawing.Color.Silver;
            this.txtOneWay.BorderSize = 0;
            this.txtOneWay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOneWay.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtOneWay.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOneWay.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtOneWay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOneWay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtOneWay.Location = new System.Drawing.Point(63, 272);
            this.txtOneWay.MaxLength = 11;
            this.txtOneWay.Name = "txtOneWay";
            this.txtOneWay.PasswordChar = '\0';
            this.txtOneWay.Radius = 8;
            this.txtOneWay.SelectedText = "";
            this.txtOneWay.Size = new System.Drawing.Size(461, 32);
            this.txtOneWay.TabIndex = 38;
            this.txtOneWay.TextChanged += new System.EventHandler(this.txtOneWay_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "A one-way ticket";
            // 
            // btnAddDailyTickets
            // 
            this.btnAddDailyTickets.AnimationHoverSpeed = 0.07F;
            this.btnAddDailyTickets.AnimationSpeed = 0.03F;
            this.btnAddDailyTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDailyTickets.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddDailyTickets.BorderColor = System.Drawing.Color.Black;
            this.btnAddDailyTickets.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAddDailyTickets.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAddDailyTickets.CheckedForeColor = System.Drawing.Color.White;
            this.btnAddDailyTickets.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAddDailyTickets.CheckedImage")));
            this.btnAddDailyTickets.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAddDailyTickets.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDailyTickets.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddDailyTickets.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDailyTickets.ForeColor = System.Drawing.Color.White;
            this.btnAddDailyTickets.Image = null;
            this.btnAddDailyTickets.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddDailyTickets.LineBottom = 1;
            this.btnAddDailyTickets.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddDailyTickets.Location = new System.Drawing.Point(59, 758);
            this.btnAddDailyTickets.Name = "btnAddDailyTickets";
            this.btnAddDailyTickets.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnAddDailyTickets.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDailyTickets.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDailyTickets.OnHoverImage = null;
            this.btnAddDailyTickets.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnAddDailyTickets.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDailyTickets.Radius = 10;
            this.btnAddDailyTickets.Size = new System.Drawing.Size(461, 42);
            this.btnAddDailyTickets.TabIndex = 25;
            this.btnAddDailyTickets.Text = "Add";
            this.btnAddDailyTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDailyTickets.Click += new System.EventHandler(this.btnAddDailyTickets_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Round Trip ticket";
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // AddDailyTickets
            // 
            this.AcceptButton = this.btnAddDailyTickets;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1491, 881);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelDraft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDailyTickets";
            this.Text = "AddDailyTickets";
            this.panelBody.ResumeLayout(false);
            this.grbAddDailyTickets.ResumeLayout(false);
            this.grbAddDailyTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox grbAddDailyTickets;
        private System.Windows.Forms.Label lblOneWay;
        private Guna.UI.WinForms.GunaTextBox txtOneWay;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaAdvenceButton btnAddDailyTickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblRoundTrip;
        private Guna.UI.WinForms.GunaTextBox txtRoundTrip;
    }
}