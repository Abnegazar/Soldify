namespace UI.Situations
{
    partial class EachCredit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listCreditGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.situationBds = new System.Windows.Forms.BindingSource(this.components);
            this.NomCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Epargne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InteretRetard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSouscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epargneRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetRetardRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaliteRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listCreditGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situationBds)).BeginInit();
            this.SuspendLayout();
            // 
            // listCreditGv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listCreditGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listCreditGv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCreditGv.AutoGenerateColumns = false;
            this.listCreditGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listCreditGv.BackgroundColor = System.Drawing.Color.White;
            this.listCreditGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCreditGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listCreditGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listCreditGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listCreditGv.ColumnHeadersHeight = 21;
            this.listCreditGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCredit,
            this.capitalDataGridViewTextBoxColumn,
            this.Interet,
            this.Epargne,
            this.InteretRetard,
            this.Penalite,
            this.dateSouscriptionDataGridViewTextBoxColumn,
            this.capitalRestantDataGridViewTextBoxColumn,
            this.interetRestantDataGridViewTextBoxColumn,
            this.epargneRestantDataGridViewTextBoxColumn,
            this.interetRetardRestantDataGridViewTextBoxColumn,
            this.penaliteRestantDataGridViewTextBoxColumn,
            this.EtatCredit});
            this.listCreditGv.DataSource = this.situationBds;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listCreditGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.listCreditGv.EnableHeadersVisualStyles = false;
            this.listCreditGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.listCreditGv.Location = new System.Drawing.Point(0, 0);
            this.listCreditGv.Name = "listCreditGv";
            this.listCreditGv.RowHeadersVisible = false;
            this.listCreditGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listCreditGv.Size = new System.Drawing.Size(889, 70);
            this.listCreditGv.TabIndex = 75;
            this.listCreditGv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.listCreditGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listCreditGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listCreditGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listCreditGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listCreditGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listCreditGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listCreditGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.listCreditGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.listCreditGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listCreditGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listCreditGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.listCreditGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listCreditGv.ThemeStyle.HeaderStyle.Height = 21;
            this.listCreditGv.ThemeStyle.ReadOnly = false;
            this.listCreditGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listCreditGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listCreditGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listCreditGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listCreditGv.ThemeStyle.RowsStyle.Height = 22;
            this.listCreditGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.listCreditGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // situationBds
            // 
            this.situationBds.DataSource = typeof(Business.SituationClass);
            // 
            // NomCredit
            // 
            this.NomCredit.DataPropertyName = "NomCredit";
            this.NomCredit.HeaderText = "Nom du credit";
            this.NomCredit.Name = "NomCredit";
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "Capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "Capital";
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            // 
            // Interet
            // 
            this.Interet.DataPropertyName = "Interet";
            this.Interet.HeaderText = "Interet";
            this.Interet.Name = "Interet";
            // 
            // Epargne
            // 
            this.Epargne.DataPropertyName = "Epargne";
            this.Epargne.HeaderText = "Epargne";
            this.Epargne.Name = "Epargne";
            // 
            // InteretRetard
            // 
            this.InteretRetard.DataPropertyName = "InteretRetard";
            this.InteretRetard.HeaderText = "Interet de retard";
            this.InteretRetard.Name = "InteretRetard";
            // 
            // Penalite
            // 
            this.Penalite.DataPropertyName = "Penalite";
            this.Penalite.HeaderText = "Penalite";
            this.Penalite.Name = "Penalite";
            // 
            // dateSouscriptionDataGridViewTextBoxColumn
            // 
            this.dateSouscriptionDataGridViewTextBoxColumn.DataPropertyName = "DateSouscription";
            this.dateSouscriptionDataGridViewTextBoxColumn.HeaderText = "Date de souscription";
            this.dateSouscriptionDataGridViewTextBoxColumn.Name = "dateSouscriptionDataGridViewTextBoxColumn";
            // 
            // capitalRestantDataGridViewTextBoxColumn
            // 
            this.capitalRestantDataGridViewTextBoxColumn.DataPropertyName = "CapitalRestant";
            this.capitalRestantDataGridViewTextBoxColumn.HeaderText = "Capital restant";
            this.capitalRestantDataGridViewTextBoxColumn.Name = "capitalRestantDataGridViewTextBoxColumn";
            // 
            // interetRestantDataGridViewTextBoxColumn
            // 
            this.interetRestantDataGridViewTextBoxColumn.DataPropertyName = "InteretRestant";
            this.interetRestantDataGridViewTextBoxColumn.HeaderText = "Interet restant";
            this.interetRestantDataGridViewTextBoxColumn.Name = "interetRestantDataGridViewTextBoxColumn";
            // 
            // epargneRestantDataGridViewTextBoxColumn
            // 
            this.epargneRestantDataGridViewTextBoxColumn.DataPropertyName = "EpargneRestant";
            this.epargneRestantDataGridViewTextBoxColumn.HeaderText = "Epargne restant";
            this.epargneRestantDataGridViewTextBoxColumn.Name = "epargneRestantDataGridViewTextBoxColumn";
            // 
            // interetRetardRestantDataGridViewTextBoxColumn
            // 
            this.interetRetardRestantDataGridViewTextBoxColumn.DataPropertyName = "InteretRetardRestant";
            this.interetRetardRestantDataGridViewTextBoxColumn.HeaderText = "Interet de retard restant";
            this.interetRetardRestantDataGridViewTextBoxColumn.Name = "interetRetardRestantDataGridViewTextBoxColumn";
            // 
            // penaliteRestantDataGridViewTextBoxColumn
            // 
            this.penaliteRestantDataGridViewTextBoxColumn.DataPropertyName = "PenaliteRestant";
            this.penaliteRestantDataGridViewTextBoxColumn.HeaderText = "Penalite restant";
            this.penaliteRestantDataGridViewTextBoxColumn.Name = "penaliteRestantDataGridViewTextBoxColumn";
            // 
            // EtatCredit
            // 
            this.EtatCredit.DataPropertyName = "EtatCredit";
            this.EtatCredit.HeaderText = "Etat du credit";
            this.EtatCredit.Name = "EtatCredit";
            // 
            // EachCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listCreditGv);
            this.Name = "EachCredit";
            this.Size = new System.Drawing.Size(889, 70);
            ((System.ComponentModel.ISupportInitialize)(this.listCreditGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situationBds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource situationBds;
        private Guna.UI2.WinForms.Guna2DataGridView listCreditGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Epargne;
        private System.Windows.Forms.DataGridViewTextBoxColumn InteretRetard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSouscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epargneRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetRetardRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaliteRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatCredit;
    }
}
