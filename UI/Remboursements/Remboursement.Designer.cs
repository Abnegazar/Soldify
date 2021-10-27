namespace UI.Remboursements
{
    partial class Remboursement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remboursement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.creditBds = new System.Windows.Forms.BindingSource(this.components);
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.clientBds = new System.Windows.Forms.BindingSource(this.components);
            this.enCoursBds = new System.Windows.Forms.BindingSource(this.components);
            this.overviewBds = new System.Windows.Forms.BindingSource(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.clientCbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateDepot = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.resetBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.montant = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.rembourserBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel31 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.idCreditCbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.remboursementLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.restantGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nominalRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epargneRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetRetardRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaliteRetardRestantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.echeanceSolderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remboursementCredit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nominalEcheanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epargneEcheanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interetEcheanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEcheanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomRemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epRemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRetRemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalRemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRembDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resteLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.creditBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enCoursBds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewBds)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.montant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restantGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remboursementCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // creditBds
            // 
            this.creditBds.DataSource = typeof(Business.CreditClass);
            // 
            // clientBds
            // 
            this.clientBds.DataSource = typeof(Business.ViewClients);
            // 
            // enCoursBds
            // 
            this.enCoursBds.DataSource = typeof(Business.EnCours);
            // 
            // overviewBds
            // 
            this.overviewBds.DataSource = typeof(Business.Overview);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.gunaPanel1.Controls.Add(this.clientCbx);
            this.gunaPanel1.Controls.Add(this.dateDepot);
            this.gunaPanel1.Controls.Add(this.resetBtn);
            this.gunaPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.gunaPanel1.Controls.Add(this.montant);
            this.gunaPanel1.Controls.Add(this.rembourserBtn);
            this.gunaPanel1.Controls.Add(this.guna2HtmlLabel10);
            this.gunaPanel1.Controls.Add(this.guna2HtmlLabel31);
            this.gunaPanel1.Controls.Add(this.idCreditCbx);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(973, 200);
            this.gunaPanel1.TabIndex = 105;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(112, 17);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(42, 22);
            this.guna2HtmlLabel2.TabIndex = 108;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "Client";
            // 
            // clientCbx
            // 
            this.clientCbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clientCbx.Animated = true;
            this.clientCbx.BackColor = System.Drawing.Color.Transparent;
            this.clientCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.clientCbx.BorderRadius = 5;
            this.clientCbx.DataSource = this.clientBds;
            this.clientCbx.DisplayMember = "Denomination";
            this.clientCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clientCbx.DropDownHeight = 400;
            this.clientCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientCbx.FocusedColor = System.Drawing.Color.Empty;
            this.clientCbx.FocusedState.Parent = this.clientCbx;
            this.clientCbx.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.clientCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.clientCbx.FormattingEnabled = true;
            this.clientCbx.HoverState.Parent = this.clientCbx;
            this.clientCbx.IntegralHeight = false;
            this.clientCbx.ItemHeight = 30;
            this.clientCbx.ItemsAppearance.Parent = this.clientCbx;
            this.clientCbx.Location = new System.Drawing.Point(36, 48);
            this.clientCbx.MaxDropDownItems = 10;
            this.clientCbx.Name = "clientCbx";
            this.clientCbx.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.clientCbx.ShadowDecoration.Enabled = true;
            this.clientCbx.ShadowDecoration.Parent = this.clientCbx;
            this.clientCbx.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 1, 3);
            this.clientCbx.Size = new System.Drawing.Size(195, 36);
            this.clientCbx.TabIndex = 109;
            this.clientCbx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.clientCbx.ValueMember = "IdClient";
            this.clientCbx.SelectionChangeCommitted += new System.EventHandler(this.ClientCbx_SelectionChangeCommitted);
            // 
            // dateDepot
            // 
            this.dateDepot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateDepot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dateDepot.BorderRadius = 5;
            this.dateDepot.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.dateDepot.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.dateDepot.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.dateDepot.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateDepot.Checked = false;
            this.dateDepot.Color = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.dateDepot.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateDepot.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Right;
            this.dateDepot.DisabledColor = System.Drawing.Color.Gray;
            this.dateDepot.DisplayWeekNumbers = false;
            this.dateDepot.DPHeight = 0;
            this.dateDepot.FillDatePicker = false;
            this.dateDepot.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dateDepot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.dateDepot.Icon = ((System.Drawing.Image)(resources.GetObject("dateDepot.Icon")));
            this.dateDepot.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.dateDepot.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Left;
            this.dateDepot.Location = new System.Drawing.Point(741, 48);
            this.dateDepot.MinimumSize = new System.Drawing.Size(175, 36);
            this.dateDepot.Name = "dateDepot";
            this.dateDepot.Size = new System.Drawing.Size(195, 36);
            this.dateDepot.TabIndex = 107;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetBtn.AnimationHoverSpeed = 0.07F;
            this.resetBtn.AnimationSpeed = 0.03F;
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.resetBtn.BorderColor = System.Drawing.Color.Black;
            this.resetBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.resetBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.resetBtn.CheckedForeColor = System.Drawing.Color.White;
            this.resetBtn.CheckedImage = null;
            this.resetBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.resetBtn.FocusedColor = System.Drawing.Color.Empty;
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Image = null;
            this.resetBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.resetBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.resetBtn.Location = new System.Drawing.Point(506, 142);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.resetBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.resetBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.resetBtn.OnHoverImage = null;
            this.resetBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.resetBtn.OnPressedColor = System.Drawing.Color.Black;
            this.resetBtn.Radius = 20;
            this.resetBtn.Size = new System.Drawing.Size(106, 42);
            this.resetBtn.TabIndex = 106;
            this.resetBtn.Text = "Nettoyer";
            this.resetBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(788, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(100, 22);
            this.guna2HtmlLabel1.TabIndex = 105;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Date de dépôt";
            // 
            // montant
            // 
            this.montant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.montant.BackColor = System.Drawing.Color.Transparent;
            this.montant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.montant.BorderRadius = 5;
            this.montant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.montant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.montant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.montant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.montant.DisabledState.Parent = this.montant;
            this.montant.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.montant.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.montant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.montant.FocusedState.Parent = this.montant;
            this.montant.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.montant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.montant.Location = new System.Drawing.Point(506, 48);
            this.montant.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.montant.Name = "montant";
            this.montant.ShadowDecoration.Parent = this.montant;
            this.montant.Size = new System.Drawing.Size(195, 36);
            this.montant.TabIndex = 104;
            this.montant.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // rembourserBtn
            // 
            this.rembourserBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rembourserBtn.AnimationHoverSpeed = 0.07F;
            this.rembourserBtn.AnimationSpeed = 0.03F;
            this.rembourserBtn.BackColor = System.Drawing.Color.Transparent;
            this.rembourserBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(75)))));
            this.rembourserBtn.BorderColor = System.Drawing.Color.Black;
            this.rembourserBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.rembourserBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.rembourserBtn.CheckedForeColor = System.Drawing.Color.White;
            this.rembourserBtn.CheckedImage = null;
            this.rembourserBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.rembourserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rembourserBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rembourserBtn.FocusedColor = System.Drawing.Color.Empty;
            this.rembourserBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.rembourserBtn.ForeColor = System.Drawing.Color.White;
            this.rembourserBtn.Image = null;
            this.rembourserBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.rembourserBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.rembourserBtn.Location = new System.Drawing.Point(347, 142);
            this.rembourserBtn.Name = "rembourserBtn";
            this.rembourserBtn.OnHoverBaseColor = System.Drawing.Color.Green;
            this.rembourserBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rembourserBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.rembourserBtn.OnHoverImage = null;
            this.rembourserBtn.OnHoverLineColor = System.Drawing.Color.Green;
            this.rembourserBtn.OnPressedColor = System.Drawing.Color.Black;
            this.rembourserBtn.Radius = 20;
            this.rembourserBtn.Size = new System.Drawing.Size(119, 42);
            this.rembourserBtn.TabIndex = 103;
            this.rembourserBtn.Text = "Effectuer";
            this.rembourserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rembourserBtn.Click += new System.EventHandler(this.RembourserBtn_Click);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(554, 17);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(98, 22);
            this.guna2HtmlLabel10.TabIndex = 102;
            this.guna2HtmlLabel10.TabStop = false;
            this.guna2HtmlLabel10.Text = "Dépôt (F CFA)";
            // 
            // guna2HtmlLabel31
            // 
            this.guna2HtmlLabel31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel31.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel31.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.guna2HtmlLabel31.Location = new System.Drawing.Point(346, 17);
            this.guna2HtmlLabel31.Name = "guna2HtmlLabel31";
            this.guna2HtmlLabel31.Size = new System.Drawing.Size(44, 22);
            this.guna2HtmlLabel31.TabIndex = 100;
            this.guna2HtmlLabel31.TabStop = false;
            this.guna2HtmlLabel31.Text = "Crédit";
            // 
            // idCreditCbx
            // 
            this.idCreditCbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idCreditCbx.Animated = true;
            this.idCreditCbx.BackColor = System.Drawing.Color.Transparent;
            this.idCreditCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.idCreditCbx.BorderRadius = 5;
            this.idCreditCbx.DataSource = this.creditBds;
            this.idCreditCbx.DisplayMember = "NomCredit";
            this.idCreditCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idCreditCbx.DropDownHeight = 400;
            this.idCreditCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCreditCbx.FocusedColor = System.Drawing.Color.Empty;
            this.idCreditCbx.FocusedState.Parent = this.idCreditCbx;
            this.idCreditCbx.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.idCreditCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.idCreditCbx.FormattingEnabled = true;
            this.idCreditCbx.HoverState.Parent = this.idCreditCbx;
            this.idCreditCbx.IntegralHeight = false;
            this.idCreditCbx.ItemHeight = 30;
            this.idCreditCbx.ItemsAppearance.Parent = this.idCreditCbx;
            this.idCreditCbx.Location = new System.Drawing.Point(271, 48);
            this.idCreditCbx.MaxDropDownItems = 10;
            this.idCreditCbx.Name = "idCreditCbx";
            this.idCreditCbx.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.idCreditCbx.ShadowDecoration.Enabled = true;
            this.idCreditCbx.ShadowDecoration.Parent = this.idCreditCbx;
            this.idCreditCbx.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 1, 3);
            this.idCreditCbx.Size = new System.Drawing.Size(195, 36);
            this.idCreditCbx.TabIndex = 101;
            this.idCreditCbx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.idCreditCbx.ValueMember = "IdCredit";
            // 
            // remboursementLbl
            // 
            this.remboursementLbl.BackColor = System.Drawing.Color.Transparent;
            this.remboursementLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remboursementLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.remboursementLbl.Location = new System.Drawing.Point(20, 238);
            this.remboursementLbl.Name = "remboursementLbl";
            this.remboursementLbl.Size = new System.Drawing.Size(282, 22);
            this.remboursementLbl.TabIndex = 111;
            this.remboursementLbl.TabStop = false;
            this.remboursementLbl.Text = "Remboursements effectués pour le crédit";
            this.remboursementLbl.Visible = false;
            // 
            // restantGv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.restantGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.restantGv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.restantGv.AutoGenerateColumns = false;
            this.restantGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.restantGv.BackgroundColor = System.Drawing.Color.White;
            this.restantGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.restantGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.restantGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.restantGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.restantGv.ColumnHeadersHeight = 40;
            this.restantGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nominalRestantDataGridViewTextBoxColumn,
            this.interetRestantDataGridViewTextBoxColumn,
            this.epargneRestantDataGridViewTextBoxColumn,
            this.interetRetardRestantDataGridViewTextBoxColumn,
            this.penaliteRetardRestantDataGridViewTextBoxColumn,
            this.echeanceSolderDataGridViewCheckBoxColumn});
            this.restantGv.DataSource = this.enCoursBds;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.restantGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.restantGv.EnableHeadersVisualStyles = false;
            this.restantGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.restantGv.Location = new System.Drawing.Point(20, 543);
            this.restantGv.Margin = new System.Windows.Forms.Padding(10);
            this.restantGv.Name = "restantGv";
            this.restantGv.ReadOnly = true;
            this.restantGv.RowHeadersVisible = false;
            this.restantGv.RowHeadersWidth = 30;
            this.restantGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.restantGv.Size = new System.Drawing.Size(933, 90);
            this.restantGv.TabIndex = 112;
            this.restantGv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.restantGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.restantGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.restantGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.restantGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.restantGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.restantGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.restantGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.restantGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.restantGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.restantGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.restantGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.restantGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.restantGv.ThemeStyle.HeaderStyle.Height = 40;
            this.restantGv.ThemeStyle.ReadOnly = true;
            this.restantGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.restantGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.restantGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.restantGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.restantGv.ThemeStyle.RowsStyle.Height = 22;
            this.restantGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.restantGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.restantGv.Visible = false;
            // 
            // nominalRestantDataGridViewTextBoxColumn
            // 
            this.nominalRestantDataGridViewTextBoxColumn.DataPropertyName = "NominalRestant";
            this.nominalRestantDataGridViewTextBoxColumn.HeaderText = "Nominal restant";
            this.nominalRestantDataGridViewTextBoxColumn.Name = "nominalRestantDataGridViewTextBoxColumn";
            this.nominalRestantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interetRestantDataGridViewTextBoxColumn
            // 
            this.interetRestantDataGridViewTextBoxColumn.DataPropertyName = "InteretRestant";
            this.interetRestantDataGridViewTextBoxColumn.HeaderText = "Interet restant";
            this.interetRestantDataGridViewTextBoxColumn.Name = "interetRestantDataGridViewTextBoxColumn";
            this.interetRestantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epargneRestantDataGridViewTextBoxColumn
            // 
            this.epargneRestantDataGridViewTextBoxColumn.DataPropertyName = "EpargneRestant";
            this.epargneRestantDataGridViewTextBoxColumn.HeaderText = "Epargne restant";
            this.epargneRestantDataGridViewTextBoxColumn.Name = "epargneRestantDataGridViewTextBoxColumn";
            this.epargneRestantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interetRetardRestantDataGridViewTextBoxColumn
            // 
            this.interetRetardRestantDataGridViewTextBoxColumn.DataPropertyName = "InteretRetardRestant";
            this.interetRetardRestantDataGridViewTextBoxColumn.HeaderText = "Interet de retard restant";
            this.interetRetardRestantDataGridViewTextBoxColumn.Name = "interetRetardRestantDataGridViewTextBoxColumn";
            this.interetRetardRestantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // penaliteRetardRestantDataGridViewTextBoxColumn
            // 
            this.penaliteRetardRestantDataGridViewTextBoxColumn.DataPropertyName = "PenaliteRetardRestant";
            this.penaliteRetardRestantDataGridViewTextBoxColumn.HeaderText = "Penalite restant";
            this.penaliteRetardRestantDataGridViewTextBoxColumn.Name = "penaliteRetardRestantDataGridViewTextBoxColumn";
            this.penaliteRetardRestantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // echeanceSolderDataGridViewCheckBoxColumn
            // 
            this.echeanceSolderDataGridViewCheckBoxColumn.DataPropertyName = "EcheanceSolder";
            this.echeanceSolderDataGridViewCheckBoxColumn.HeaderText = "Solder";
            this.echeanceSolderDataGridViewCheckBoxColumn.Name = "echeanceSolderDataGridViewCheckBoxColumn";
            this.echeanceSolderDataGridViewCheckBoxColumn.ReadOnly = true;
            this.echeanceSolderDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.echeanceSolderDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // remboursementCredit
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.remboursementCredit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.remboursementCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remboursementCredit.AutoGenerateColumns = false;
            this.remboursementCredit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.remboursementCredit.BackgroundColor = System.Drawing.Color.White;
            this.remboursementCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remboursementCredit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.remboursementCredit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.remboursementCredit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.remboursementCredit.ColumnHeadersHeight = 50;
            this.remboursementCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nominalEcheanceDataGridViewTextBoxColumn,
            this.epargneEcheanceDataGridViewTextBoxColumn,
            this.interetEcheanceDataGridViewTextBoxColumn,
            this.dateEcheanceDataGridViewTextBoxColumn,
            this.nomRemDataGridViewTextBoxColumn,
            this.epRemDataGridViewTextBoxColumn,
            this.intRemDataGridViewTextBoxColumn,
            this.intRetRemDataGridViewTextBoxColumn,
            this.penalRemDataGridViewTextBoxColumn,
            this.dateRembDataGridViewTextBoxColumn});
            this.remboursementCredit.DataSource = this.overviewBds;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.remboursementCredit.DefaultCellStyle = dataGridViewCellStyle6;
            this.remboursementCredit.EnableHeadersVisualStyles = false;
            this.remboursementCredit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.remboursementCredit.Location = new System.Drawing.Point(20, 270);
            this.remboursementCredit.Margin = new System.Windows.Forms.Padding(10);
            this.remboursementCredit.Name = "remboursementCredit";
            this.remboursementCredit.ReadOnly = true;
            this.remboursementCredit.RowHeadersVisible = false;
            this.remboursementCredit.RowHeadersWidth = 30;
            this.remboursementCredit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.remboursementCredit.Size = new System.Drawing.Size(933, 225);
            this.remboursementCredit.TabIndex = 110;
            this.remboursementCredit.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.remboursementCredit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.remboursementCredit.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.remboursementCredit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.remboursementCredit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.remboursementCredit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.remboursementCredit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.remboursementCredit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.remboursementCredit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.remboursementCredit.ThemeStyle.HeaderStyle.Height = 50;
            this.remboursementCredit.ThemeStyle.ReadOnly = true;
            this.remboursementCredit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.remboursementCredit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.remboursementCredit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.remboursementCredit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.remboursementCredit.ThemeStyle.RowsStyle.Height = 22;
            this.remboursementCredit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.remboursementCredit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.remboursementCredit.Visible = false;
            // 
            // nominalEcheanceDataGridViewTextBoxColumn
            // 
            this.nominalEcheanceDataGridViewTextBoxColumn.DataPropertyName = "NominalEcheance";
            this.nominalEcheanceDataGridViewTextBoxColumn.HeaderText = "Nominal";
            this.nominalEcheanceDataGridViewTextBoxColumn.Name = "nominalEcheanceDataGridViewTextBoxColumn";
            this.nominalEcheanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epargneEcheanceDataGridViewTextBoxColumn
            // 
            this.epargneEcheanceDataGridViewTextBoxColumn.DataPropertyName = "EpargneEcheance";
            this.epargneEcheanceDataGridViewTextBoxColumn.HeaderText = "Epargne";
            this.epargneEcheanceDataGridViewTextBoxColumn.Name = "epargneEcheanceDataGridViewTextBoxColumn";
            this.epargneEcheanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // interetEcheanceDataGridViewTextBoxColumn
            // 
            this.interetEcheanceDataGridViewTextBoxColumn.DataPropertyName = "InteretEcheance";
            this.interetEcheanceDataGridViewTextBoxColumn.HeaderText = "Interet";
            this.interetEcheanceDataGridViewTextBoxColumn.Name = "interetEcheanceDataGridViewTextBoxColumn";
            this.interetEcheanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEcheanceDataGridViewTextBoxColumn
            // 
            this.dateEcheanceDataGridViewTextBoxColumn.DataPropertyName = "DateEcheance";
            this.dateEcheanceDataGridViewTextBoxColumn.HeaderText = "Date d\'écheance";
            this.dateEcheanceDataGridViewTextBoxColumn.Name = "dateEcheanceDataGridViewTextBoxColumn";
            this.dateEcheanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomRemDataGridViewTextBoxColumn
            // 
            this.nomRemDataGridViewTextBoxColumn.DataPropertyName = "NomRem";
            this.nomRemDataGridViewTextBoxColumn.HeaderText = "Nomimal rembourser";
            this.nomRemDataGridViewTextBoxColumn.Name = "nomRemDataGridViewTextBoxColumn";
            this.nomRemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epRemDataGridViewTextBoxColumn
            // 
            this.epRemDataGridViewTextBoxColumn.DataPropertyName = "EpRem";
            this.epRemDataGridViewTextBoxColumn.HeaderText = "Epargne rembourser";
            this.epRemDataGridViewTextBoxColumn.Name = "epRemDataGridViewTextBoxColumn";
            this.epRemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intRemDataGridViewTextBoxColumn
            // 
            this.intRemDataGridViewTextBoxColumn.DataPropertyName = "IntRem";
            this.intRemDataGridViewTextBoxColumn.HeaderText = "Intérêt rembourser";
            this.intRemDataGridViewTextBoxColumn.Name = "intRemDataGridViewTextBoxColumn";
            this.intRemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intRetRemDataGridViewTextBoxColumn
            // 
            this.intRetRemDataGridViewTextBoxColumn.DataPropertyName = "IntRetRem";
            this.intRetRemDataGridViewTextBoxColumn.HeaderText = "Intérêt de retard";
            this.intRetRemDataGridViewTextBoxColumn.Name = "intRetRemDataGridViewTextBoxColumn";
            this.intRetRemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // penalRemDataGridViewTextBoxColumn
            // 
            this.penalRemDataGridViewTextBoxColumn.DataPropertyName = "PenalRem";
            this.penalRemDataGridViewTextBoxColumn.HeaderText = "Pénalalité";
            this.penalRemDataGridViewTextBoxColumn.Name = "penalRemDataGridViewTextBoxColumn";
            this.penalRemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateRembDataGridViewTextBoxColumn
            // 
            this.dateRembDataGridViewTextBoxColumn.DataPropertyName = "DateRemb";
            this.dateRembDataGridViewTextBoxColumn.HeaderText = "Date du remboursement";
            this.dateRembDataGridViewTextBoxColumn.Name = "dateRembDataGridViewTextBoxColumn";
            this.dateRembDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resteLbl
            // 
            this.resteLbl.BackColor = System.Drawing.Color.Transparent;
            this.resteLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resteLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.resteLbl.Location = new System.Drawing.Point(20, 508);
            this.resteLbl.Name = "resteLbl";
            this.resteLbl.Size = new System.Drawing.Size(269, 22);
            this.resteLbl.TabIndex = 113;
            this.resteLbl.TabStop = false;
            this.resteLbl.Text = "Reste à payer pour l\'échéance en cours";
            this.resteLbl.Visible = false;
            // 
            // Remboursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 741);
            this.Controls.Add(this.remboursementLbl);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.restantGv);
            this.Controls.Add(this.remboursementCredit);
            this.Controls.Add(this.resteLbl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Remboursement";
            this.ShowIcon = false;
            this.Text = "Remboursement";
            this.Load += new System.EventHandler(this.Remboursement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enCoursBds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewBds)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.montant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restantGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remboursementCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource creditBds;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.BindingSource clientBds;
        private System.Windows.Forms.BindingSource enCoursBds;
        private System.Windows.Forms.BindingSource overviewBds;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox clientCbx;
        private Bunifu.UI.WinForms.BunifuDatePicker dateDepot;
        private Guna.UI.WinForms.GunaAdvenceButton resetBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown montant;
        private Guna.UI.WinForms.GunaAdvenceButton rembourserBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel31;
        private Guna.UI2.WinForms.Guna2ComboBox idCreditCbx;
        private Guna.UI2.WinForms.Guna2HtmlLabel remboursementLbl;
        private Guna.UI2.WinForms.Guna2DataGridView restantGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epargneRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetRetardRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaliteRetardRestantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn echeanceSolderDataGridViewCheckBoxColumn;
        private Guna.UI2.WinForms.Guna2DataGridView remboursementCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalEcheanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epargneEcheanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interetEcheanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEcheanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomRemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epRemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRetRemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penalRemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRembDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2HtmlLabel resteLbl;
    }
}