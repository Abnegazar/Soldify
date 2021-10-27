namespace UI.Credits
{
    partial class Previewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.echeancier = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idEcheanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEcheanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epargneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annuiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.echeancierBds = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.rejectBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.saveBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.VScroller = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.hide = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.echeancier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echeancierBds)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BorderRadius = 10;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(58)))));
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(923, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(21, 22);
            this.closeBtn.TabIndex = 0;
            // 
            // echeancier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.echeancier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.echeancier.AutoGenerateColumns = false;
            this.echeancier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.echeancier.BackgroundColor = System.Drawing.Color.White;
            this.echeancier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.echeancier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.echeancier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.echeancier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.echeancier.ColumnHeadersHeight = 35;
            this.echeancier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEcheanceDataGridViewTextBoxColumn,
            this.dateEcheanceDataGridViewTextBoxColumn,
            this.nominalDataGridViewTextBoxColumn,
            this.interetDataGridViewTextBoxColumn,
            this.epargneDataGridViewTextBoxColumn,
            this.annuiteDataGridViewTextBoxColumn});
            this.echeancier.DataSource = this.echeancierBds;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.echeancier.DefaultCellStyle = dataGridViewCellStyle3;
            this.echeancier.EnableHeadersVisualStyles = false;
            this.echeancier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.echeancier.Location = new System.Drawing.Point(17, 82);
            this.echeancier.Margin = new System.Windows.Forms.Padding(10);
            this.echeancier.Name = "echeancier";
            this.echeancier.ReadOnly = true;
            this.echeancier.RowHeadersVisible = false;
            this.echeancier.RowHeadersWidth = 30;
            this.echeancier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.echeancier.Size = new System.Drawing.Size(910, 334);
            this.echeancier.TabIndex = 2;
            this.echeancier.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.echeancier.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.echeancier.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.echeancier.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.echeancier.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.echeancier.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.echeancier.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.echeancier.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.echeancier.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.echeancier.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.echeancier.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.echeancier.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.echeancier.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.echeancier.ThemeStyle.HeaderStyle.Height = 35;
            this.echeancier.ThemeStyle.ReadOnly = true;
            this.echeancier.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.echeancier.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.echeancier.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.echeancier.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.echeancier.ThemeStyle.RowsStyle.Height = 22;
            this.echeancier.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.echeancier.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // idEcheanceDataGridViewTextBoxColumn
            // 
            this.idEcheanceDataGridViewTextBoxColumn.DataPropertyName = "IdEcheance";
            this.idEcheanceDataGridViewTextBoxColumn.HeaderText = "N°";
            this.idEcheanceDataGridViewTextBoxColumn.Name = "idEcheanceDataGridViewTextBoxColumn";
            this.idEcheanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEcheanceDataGridViewTextBoxColumn
            // 
            this.dateEcheanceDataGridViewTextBoxColumn.DataPropertyName = "DateEcheance";
            this.dateEcheanceDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateEcheanceDataGridViewTextBoxColumn.Name = "dateEcheanceDataGridViewTextBoxColumn";
            this.dateEcheanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nominalDataGridViewTextBoxColumn
            // 
            this.nominalDataGridViewTextBoxColumn.DataPropertyName = "Nominal";
            this.nominalDataGridViewTextBoxColumn.HeaderText = "Nominal";
            this.nominalDataGridViewTextBoxColumn.Name = "nominalDataGridViewTextBoxColumn";
            this.nominalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interetDataGridViewTextBoxColumn
            // 
            this.interetDataGridViewTextBoxColumn.DataPropertyName = "Interet";
            this.interetDataGridViewTextBoxColumn.HeaderText = "Interet";
            this.interetDataGridViewTextBoxColumn.Name = "interetDataGridViewTextBoxColumn";
            this.interetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epargneDataGridViewTextBoxColumn
            // 
            this.epargneDataGridViewTextBoxColumn.DataPropertyName = "Epargne";
            this.epargneDataGridViewTextBoxColumn.HeaderText = "Epargne";
            this.epargneDataGridViewTextBoxColumn.Name = "epargneDataGridViewTextBoxColumn";
            this.epargneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // annuiteDataGridViewTextBoxColumn
            // 
            this.annuiteDataGridViewTextBoxColumn.DataPropertyName = "Annuite";
            this.annuiteDataGridViewTextBoxColumn.HeaderText = "Annuite";
            this.annuiteDataGridViewTextBoxColumn.Name = "annuiteDataGridViewTextBoxColumn";
            this.annuiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // echeancierBds
            // 
            this.echeancierBds.DataSource = typeof(Business.Echeance);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.guna2Separator1.FillThickness = 5;
            this.guna2Separator1.Location = new System.Drawing.Point(17, 48);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(371, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.guna2Separator2.FillThickness = 5;
            this.guna2Separator2.Location = new System.Drawing.Point(549, 48);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(371, 10);
            this.guna2Separator2.TabIndex = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.gunaLabel1.Location = new System.Drawing.Point(398, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(148, 37);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Echeancier";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rejectBtn
            // 
            this.rejectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rejectBtn.AnimationHoverSpeed = 0.07F;
            this.rejectBtn.AnimationSpeed = 0.03F;
            this.rejectBtn.BackColor = System.Drawing.Color.Transparent;
            this.rejectBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.rejectBtn.BorderColor = System.Drawing.Color.Black;
            this.rejectBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.rejectBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.rejectBtn.CheckedForeColor = System.Drawing.Color.White;
            this.rejectBtn.CheckedImage = null;
            this.rejectBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.rejectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rejectBtn.FocusedColor = System.Drawing.Color.Empty;
            this.rejectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.rejectBtn.ForeColor = System.Drawing.Color.White;
            this.rejectBtn.Image = null;
            this.rejectBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.rejectBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rejectBtn.Location = new System.Drawing.Point(473, 426);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.rejectBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rejectBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.rejectBtn.OnHoverImage = null;
            this.rejectBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.rejectBtn.OnPressedColor = System.Drawing.Color.Black;
            this.rejectBtn.Radius = 8;
            this.rejectBtn.Size = new System.Drawing.Size(180, 42);
            this.rejectBtn.TabIndex = 60;
            this.rejectBtn.Text = "Modifier";
            this.rejectBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rejectBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.AnimationHoverSpeed = 0.07F;
            this.saveBtn.AnimationSpeed = 0.03F;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.saveBtn.BorderColor = System.Drawing.Color.Black;
            this.saveBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.saveBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.saveBtn.CheckedForeColor = System.Drawing.Color.White;
            this.saveBtn.CheckedImage = null;
            this.saveBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveBtn.FocusedColor = System.Drawing.Color.Empty;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = null;
            this.saveBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.saveBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.saveBtn.Location = new System.Drawing.Point(268, 426);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.saveBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.saveBtn.OnHoverImage = null;
            this.saveBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.saveBtn.OnPressedColor = System.Drawing.Color.Black;
            this.saveBtn.Radius = 8;
            this.saveBtn.Size = new System.Drawing.Size(180, 42);
            this.saveBtn.TabIndex = 59;
            this.saveBtn.Text = "Enregistrer";
            this.saveBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // VScroller
            // 
            this.VScroller.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VScroller.BackColor = System.Drawing.Color.Transparent;
            this.VScroller.LargeChange = 10;
            this.VScroller.Location = new System.Drawing.Point(931, 82);
            this.VScroller.Maximum = 100;
            this.VScroller.Name = "VScroller";
            this.VScroller.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.VScroller.Size = new System.Drawing.Size(10, 334);
            this.VScroller.TabIndex = 69;
            this.VScroller.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.VScroller.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.VScroller.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(210, 426);
            this.hide.Name = "hide";
            this.hide.ShadowDecoration.Parent = this.hide;
            this.hide.Size = new System.Drawing.Size(526, 42);
            this.hide.TabIndex = 70;
            this.hide.Visible = false;
            // 
            // Previewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(946, 480);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.VScroller);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.echeancier);
            this.Controls.Add(this.closeBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Previewer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Previewer";
            this.Load += new System.EventHandler(this.Previewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.echeancier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echeancierBds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2DataGridView echeancier;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaVScrollBar VScroller;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEcheanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEcheanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epargneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annuiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource echeancierBds;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        public Guna.UI2.WinForms.Guna2Panel hide;
        public Guna.UI.WinForms.GunaAdvenceButton rejectBtn;
        public Guna.UI.WinForms.GunaAdvenceButton saveBtn;
    }
}