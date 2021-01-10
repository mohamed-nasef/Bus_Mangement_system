namespace Bus_Mangement_system.SCR.Report
{
    partial class MonthlyReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyReport));
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.numYear = new Guna.UI.WinForms.GunaNumeric();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMonth = new Guna.UI.WinForms.GunaNumeric();
            this.dgvMonthly = new Guna.UI.WinForms.GunaDataGridView();
            this.btnProfit = new Guna.UI.WinForms.GunaButton();
            this.btnSearch = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthly)).BeginInit();
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
            this.panelBody.Controls.Add(this.dgvMonthly);
            this.panelBody.Controls.Add(this.btnProfit);
            this.panelBody.Controls.Add(this.btnSearch);
            this.panelBody.Controls.Add(this.label1);
            this.panelBody.Controls.Add(this.numMonth);
            this.panelBody.Controls.Add(this.label3);
            this.panelBody.Controls.Add(this.numYear);
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(338, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1153, 881);
            this.panelBody.TabIndex = 1;
            // 
            // numYear
            // 
            this.numYear.BackColor = System.Drawing.Color.Transparent;
            this.numYear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.numYear.BorderColor = System.Drawing.Color.Silver;
            this.numYear.BorderSize = 0;
            this.numYear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(131)))), ((int)(((byte)(254)))));
            this.numYear.ButtonForeColor = System.Drawing.Color.White;
            this.numYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.numYear.Location = new System.Drawing.Point(142, 178);
            this.numYear.Maximum = ((long)(3000));
            this.numYear.Minimum = ((long)(2020));
            this.numYear.Name = "numYear";
            this.numYear.Radius = 8;
            this.numYear.Size = new System.Drawing.Size(218, 30);
            this.numYear.TabIndex = 55;
            this.numYear.Text = "numMonth";
            this.numYear.Value = ((long)(2020));
            this.numYear.ValueChanged += new System.EventHandler(this.NumYear_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(137, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 30);
            this.label3.TabIndex = 56;
            this.label3.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(455, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Month";
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
            this.numMonth.Location = new System.Drawing.Point(460, 178);
            this.numMonth.Maximum = ((long)(12));
            this.numMonth.Minimum = ((long)(1));
            this.numMonth.Name = "numMonth";
            this.numMonth.Radius = 8;
            this.numMonth.Size = new System.Drawing.Size(218, 30);
            this.numMonth.TabIndex = 57;
            this.numMonth.Text = "gunaNumeric1";
            this.numMonth.Value = ((long)(1));
            this.numMonth.ValueChanged += new System.EventHandler(this.NumMonth_ValueChanged);
            // 
            // dgvMonthly
            // 
            this.dgvMonthly.AllowUserToAddRows = false;
            this.dgvMonthly.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.dgvMonthly.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthly.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvMonthly.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonthly.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonthly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthly.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonthly.EnableHeadersVisualStyles = false;
            this.dgvMonthly.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvMonthly.Location = new System.Drawing.Point(142, 364);
            this.dgvMonthly.Name = "dgvMonthly";
            this.dgvMonthly.ReadOnly = true;
            this.dgvMonthly.RowHeadersVisible = false;
            this.dgvMonthly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthly.Size = new System.Drawing.Size(1038, 493);
            this.dgvMonthly.TabIndex = 71;
            this.dgvMonthly.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvMonthly.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvMonthly.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMonthly.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.dgvMonthly.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvMonthly.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.dgvMonthly.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvMonthly.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvMonthly.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(135)))), ((int)(((byte)(190)))));
            this.dgvMonthly.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMonthly.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvMonthly.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMonthly.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMonthly.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvMonthly.ThemeStyle.ReadOnly = true;
            this.dgvMonthly.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvMonthly.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonthly.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvMonthly.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.dgvMonthly.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMonthly.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgvMonthly.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.dgvMonthly.Visible = false;
            // 
            // btnProfit
            // 
            this.btnProfit.AnimationHoverSpeed = 0.07F;
            this.btnProfit.AnimationSpeed = 0.03F;
            this.btnProfit.BackColor = System.Drawing.Color.Transparent;
            this.btnProfit.BaseColor = System.Drawing.Color.Transparent;
            this.btnProfit.BorderColor = System.Drawing.Color.Black;
            this.btnProfit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProfit.FocusedColor = System.Drawing.Color.Empty;
            this.btnProfit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfit.ForeColor = System.Drawing.Color.White;
            this.btnProfit.Image = global::Bus_Mangement_system.Properties.Resources.icons8_money_bag_30;
            this.btnProfit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProfit.Location = new System.Drawing.Point(142, 260);
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnProfit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProfit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProfit.OnHoverImage = null;
            this.btnProfit.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(77)))));
            this.btnProfit.Radius = 8;
            this.btnProfit.Size = new System.Drawing.Size(536, 51);
            this.btnProfit.TabIndex = 70;
            this.btnProfit.Text = "0";
            this.btnProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProfit.Visible = false;
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
            this.btnSearch.Location = new System.Drawing.Point(962, 177);
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
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            // MonthlyReport
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1491, 881);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelDraft);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonthlyReport";
            this.Text = "MonthlyReport";
            this.Load += new System.EventHandler(this.MonthlyReport_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI.WinForms.GunaNumeric numYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaNumeric numMonth;
        private Guna.UI.WinForms.GunaAdvenceButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnProfit;
        private Guna.UI.WinForms.GunaDataGridView dgvMonthly;
    }
}