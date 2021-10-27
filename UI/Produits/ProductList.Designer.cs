namespace UI
{
    partial class ProductList
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.VScroller = new Guna.UI.WinForms.GunaVScrollBar();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.listProduitGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nomProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAmortissementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBds = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProduitGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBds)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.VScroller);
            this.guna2Panel1.Controls.Add(this.guna2Separator2);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.guna2VSeparator1);
            this.guna2Panel1.Controls.Add(this.listProduitGv);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(906, 542);
            this.guna2Panel1.TabIndex = 7;
            // 
            // VScroller
            // 
            this.VScroller.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VScroller.BackColor = System.Drawing.Color.Transparent;
            this.VScroller.LargeChange = 10;
            this.VScroller.Location = new System.Drawing.Point(896, 12);
            this.VScroller.Maximum = 100;
            this.VScroller.Name = "VScroller";
            this.VScroller.ScrollIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.VScroller.Size = new System.Drawing.Size(10, 334);
            this.VScroller.TabIndex = 71;
            this.VScroller.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.VScroller.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.VScroller.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Separator2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.Location = new System.Drawing.Point(896, 10);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(10, 532);
            this.guna2Separator2.TabIndex = 4;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Separator1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 10);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(10, 532);
            this.guna2Separator1.TabIndex = 3;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.Location = new System.Drawing.Point(0, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(906, 10);
            this.guna2VSeparator1.TabIndex = 2;
            // 
            // listProduitGv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listProduitGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listProduitGv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProduitGv.AutoGenerateColumns = false;
            this.listProduitGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listProduitGv.BackgroundColor = System.Drawing.Color.White;
            this.listProduitGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProduitGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listProduitGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listProduitGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listProduitGv.ColumnHeadersHeight = 35;
            this.listProduitGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomProduitDataGridViewTextBoxColumn,
            this.typeAmortissementDataGridViewTextBoxColumn,
            this.Description,
            this.typeClientDataGridViewTextBoxColumn,
            this.CreatedBy});
            this.listProduitGv.DataSource = this.produitBds;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listProduitGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.listProduitGv.EnableHeadersVisualStyles = false;
            this.listProduitGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.listProduitGv.Location = new System.Drawing.Point(10, 10);
            this.listProduitGv.Margin = new System.Windows.Forms.Padding(10);
            this.listProduitGv.Name = "listProduitGv";
            this.listProduitGv.ReadOnly = true;
            this.listProduitGv.RowHeadersVisible = false;
            this.listProduitGv.RowHeadersWidth = 30;
            this.listProduitGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listProduitGv.Size = new System.Drawing.Size(886, 560);
            this.listProduitGv.TabIndex = 1;
            this.listProduitGv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.listProduitGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listProduitGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listProduitGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listProduitGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listProduitGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listProduitGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listProduitGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.listProduitGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.listProduitGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listProduitGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.listProduitGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.listProduitGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listProduitGv.ThemeStyle.HeaderStyle.Height = 35;
            this.listProduitGv.ThemeStyle.ReadOnly = true;
            this.listProduitGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listProduitGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listProduitGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listProduitGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listProduitGv.ThemeStyle.RowsStyle.Height = 22;
            this.listProduitGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.listProduitGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // nomProduitDataGridViewTextBoxColumn
            // 
            this.nomProduitDataGridViewTextBoxColumn.DataPropertyName = "NomProduit";
            this.nomProduitDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.nomProduitDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomProduitDataGridViewTextBoxColumn.Name = "nomProduitDataGridViewTextBoxColumn";
            this.nomProduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeAmortissementDataGridViewTextBoxColumn
            // 
            this.typeAmortissementDataGridViewTextBoxColumn.DataPropertyName = "TypeAmortissement";
            this.typeAmortissementDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.typeAmortissementDataGridViewTextBoxColumn.HeaderText = "Amortissement";
            this.typeAmortissementDataGridViewTextBoxColumn.Name = "typeAmortissementDataGridViewTextBoxColumn";
            this.typeAmortissementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 101.7259F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // typeClientDataGridViewTextBoxColumn
            // 
            this.typeClientDataGridViewTextBoxColumn.DataPropertyName = "TypeClient";
            this.typeClientDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.typeClientDataGridViewTextBoxColumn.HeaderText = "TypeClient";
            this.typeClientDataGridViewTextBoxColumn.Name = "typeClientDataGridViewTextBoxColumn";
            this.typeClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.FillWeight = 101.7259F;
            this.CreatedBy.HeaderText = "Date de création";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            // 
            // produitBds
            // 
            this.produitBds.DataSource = typeof(Business.ProduitClass);
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 542);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductList";
            this.ShowIcon = false;
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listProduitGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView listProduitGv;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.BindingSource produitBds;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAmortissementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private Guna.UI.WinForms.GunaVScrollBar VScroller;
    }
}