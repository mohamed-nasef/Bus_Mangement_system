namespace Bus_Mangement_system.SCR
{
    partial class TestSearchcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestSearchcs));
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.panelToolbar.Controls.Add(this.gunaAdvenceButton1);
            this.panelToolbar.Controls.Add(this.label3);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(847, 29);
            this.panelToolbar.TabIndex = 0;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(817, 0);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(30, 29);
            this.gunaAdvenceButton1.TabIndex = 22;
            this.gunaAdvenceButton1.Text = "X";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.GunaAdvenceButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.lblStudentId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentId.Location = new System.Drawing.Point(206, 177);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(39, 17);
            this.lblStudentId.TabIndex = 46;
            this.lblStudentId.Text = "ex: 10";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BackColor = System.Drawing.Color.Transparent;
            this.txtStudentId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtStudentId.BorderColor = System.Drawing.Color.Silver;
            this.txtStudentId.BorderSize = 0;
            this.txtStudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentId.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtStudentId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtStudentId.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(130)))), ((int)(((byte)(135)))));
            this.txtStudentId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.txtStudentId.Location = new System.Drawing.Point(200, 170);
            this.txtStudentId.MaxLength = 11;
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.PasswordChar = '\0';
            this.txtStudentId.Radius = 8;
            this.txtStudentId.SelectedText = "";
            this.txtStudentId.Size = new System.Drawing.Size(461, 32);
            this.txtStudentId.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(195, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 44;
            this.label4.Text = "Student ID";
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
            this.btnSearch.Location = new System.Drawing.Point(200, 321);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(461, 42);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TestSearchcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(847, 396);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelToolbar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestSearchcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestSearchcs";
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.Label lblStudentId;
        private Guna.UI.WinForms.GunaTextBox txtStudentId;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
    }
}