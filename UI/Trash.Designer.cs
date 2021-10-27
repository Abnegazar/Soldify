namespace UI
{
    partial class Trash
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
            this.containerVScroller = new Guna.UI.WinForms.GunaVScrollBar();
            this.dateDepot = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.topPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.remboursementBds = new System.Windows.Forms.BindingSource(this.components);
            this.remboursementCredit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nominalRembourserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetRembourserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epargneRembourserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetRetardRembourserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaliteRetardRembourserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRemboursementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.remboursementBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remboursementCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // containerVScroller
            // 
            this.containerVScroller.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.containerVScroller.BackColor = System.Drawing.Color.Transparent;
            this.containerVScroller.LargeChange = 10;
            this.containerVScroller.Location = new System.Drawing.Point(968, 9);
            this.containerVScroller.Maximum = 100;
            this.containerVScroller.Name = "containerVScroller";
            this.containerVScroller.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.containerVScroller.Size = new System.Drawing.Size(11, 687);
            this.containerVScroller.TabIndex = 68;
            this.containerVScroller.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.containerVScroller.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.containerVScroller.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            // 
            // dateDepot
            // 
            this.dateDepot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateDepot.BackColor = System.Drawing.Color.Transparent;
            this.dateDepot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.dateDepot.BorderRadius = 5;
            this.dateDepot.BorderThickness = 1;
            this.dateDepot.CheckedState.Parent = this.dateDepot;
            this.dateDepot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dateDepot.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dateDepot.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDepot.HoverState.Parent = this.dateDepot;
            this.dateDepot.Location = new System.Drawing.Point(744, 93);
            this.dateDepot.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDepot.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDepot.Name = "dateDepot";
            this.dateDepot.ShadowDecoration.Parent = this.dateDepot;
            this.dateDepot.Size = new System.Drawing.Size(198, 36);
            this.dateDepot.TabIndex = 95;
            this.dateDepot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateDepot.Value = new System.DateTime(2021, 3, 17, 19, 51, 32, 906);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Transparent;
            this.topPanel.FillColor = System.Drawing.Color.White;
            this.topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.topPanel.ShadowDepth = 50;
            this.topPanel.ShadowShift = 8;
            this.topPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.topPanel.Size = new System.Drawing.Size(953, 84);
            this.topPanel.TabIndex = 96;
            // 
            // remboursementBds
            // 
            this.remboursementBds.DataSource = typeof(Business.RemboursementClass);
            // 
            // remboursementCredit
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.remboursementCredit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.remboursementCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remboursementCredit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.remboursementCredit.BackgroundColor = System.Drawing.Color.White;
            this.remboursementCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remboursementCredit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.remboursementCredit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.remboursementCredit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.remboursementCredit.ColumnHeadersHeight = 30;
            this.remboursementCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nominalRembourserDataGridViewTextBoxColumn,
            this.interetRembourserDataGridViewTextBoxColumn,
            this.epargneRembourserDataGridViewTextBoxColumn,
            this.interetRetardRembourserDataGridViewTextBoxColumn,
            this.penaliteRetardRembourserDataGridViewTextBoxColumn,
            this.dateRemboursementDataGridViewTextBoxColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.remboursementCredit.DefaultCellStyle = dataGridViewCellStyle3;
            this.remboursementCredit.EnableHeadersVisualStyles = false;
            this.remboursementCredit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.remboursementCredit.Location = new System.Drawing.Point(32, 164);
            this.remboursementCredit.Margin = new System.Windows.Forms.Padding(10);
            this.remboursementCredit.Name = "remboursementCredit";
            this.remboursementCredit.ReadOnly = true;
            this.remboursementCredit.RowHeadersVisible = false;
            this.remboursementCredit.RowHeadersWidth = 30;
            this.remboursementCredit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.remboursementCredit.Size = new System.Drawing.Size(910, 219);
            this.remboursementCredit.TabIndex = 97;
            this.remboursementCredit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.remboursementCredit.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.remboursementCredit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.remboursementCredit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.remboursementCredit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.remboursementCredit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.remboursementCredit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.remboursementCredit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.remboursementCredit.ThemeStyle.HeaderStyle.Height = 30;
            this.remboursementCredit.ThemeStyle.ReadOnly = true;
            this.remboursementCredit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.remboursementCredit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.remboursementCredit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.remboursementCredit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.remboursementCredit.ThemeStyle.RowsStyle.Height = 22;
            this.remboursementCredit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.remboursementCredit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.remboursementCredit.Visible = false;
            // 
            // nominalRembourserDataGridViewTextBoxColumn
            // 
            this.nominalRembourserDataGridViewTextBoxColumn.DataPropertyName = "NominalRembourser";
            this.nominalRembourserDataGridViewTextBoxColumn.HeaderText = "Nominal";
            this.nominalRembourserDataGridViewTextBoxColumn.Name = "nominalRembourserDataGridViewTextBoxColumn";
            this.nominalRembourserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interetRembourserDataGridViewTextBoxColumn
            // 
            this.interetRembourserDataGridViewTextBoxColumn.DataPropertyName = "InteretRembourser";
            this.interetRembourserDataGridViewTextBoxColumn.HeaderText = "Interet";
            this.interetRembourserDataGridViewTextBoxColumn.Name = "interetRembourserDataGridViewTextBoxColumn";
            this.interetRembourserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epargneRembourserDataGridViewTextBoxColumn
            // 
            this.epargneRembourserDataGridViewTextBoxColumn.DataPropertyName = "EpargneRembourser";
            this.epargneRembourserDataGridViewTextBoxColumn.HeaderText = "Epargne";
            this.epargneRembourserDataGridViewTextBoxColumn.Name = "epargneRembourserDataGridViewTextBoxColumn";
            this.epargneRembourserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interetRetardRembourserDataGridViewTextBoxColumn
            // 
            this.interetRetardRembourserDataGridViewTextBoxColumn.DataPropertyName = "InteretRetardRembourser";
            this.interetRetardRembourserDataGridViewTextBoxColumn.HeaderText = "Interet de retard";
            this.interetRetardRembourserDataGridViewTextBoxColumn.Name = "interetRetardRembourserDataGridViewTextBoxColumn";
            this.interetRetardRembourserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // penaliteRetardRembourserDataGridViewTextBoxColumn
            // 
            this.penaliteRetardRembourserDataGridViewTextBoxColumn.DataPropertyName = "PenaliteRetardRembourser";
            this.penaliteRetardRembourserDataGridViewTextBoxColumn.HeaderText = "Penalite";
            this.penaliteRetardRembourserDataGridViewTextBoxColumn.Name = "penaliteRetardRembourserDataGridViewTextBoxColumn";
            this.penaliteRetardRembourserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateRemboursementDataGridViewTextBoxColumn
            // 
            this.dateRemboursementDataGridViewTextBoxColumn.DataPropertyName = "DateRemboursement";
            this.dateRemboursementDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateRemboursementDataGridViewTextBoxColumn.Name = "dateRemboursementDataGridViewTextBoxColumn";
            this.dateRemboursementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Trash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 708);
            this.Controls.Add(this.remboursementCredit);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.dateDepot);
            this.Controls.Add(this.containerVScroller);
            this.Name = "Trash";
            this.Text = "Trash";
            ((System.ComponentModel.ISupportInitialize)(this.remboursementBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remboursementCredit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaVScrollBar containerVScroller;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateDepot;
        private Guna.UI2.WinForms.Guna2ShadowPanel topPanel;
        private System.Windows.Forms.BindingSource remboursementBds;
        private Guna.UI2.WinForms.Guna2DataGridView remboursementCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalRembourserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetRembourserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epargneRembourserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetRetardRembourserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaliteRetardRembourserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRemboursementDataGridViewTextBoxColumn;
    }
}