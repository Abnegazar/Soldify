namespace UI
{
    partial class Products
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
            this.navBar = new Guna.UI2.WinForms.Guna2Panel();
            this.tab_update = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tab_add = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tab_list = new Guna.UI.WinForms.GunaAdvenceButton();
            this.centralPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.Transparent;
            this.navBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.navBar.Controls.Add(this.searchBox);
            this.navBar.Controls.Add(this.tab_update);
            this.navBar.Controls.Add(this.tab_add);
            this.navBar.Controls.Add(this.tab_list);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.navBar.Name = "navBar";
            this.navBar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.navBar.ShadowDecoration.Parent = this.navBar;
            this.navBar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.navBar.Size = new System.Drawing.Size(898, 41);
            this.navBar.TabIndex = 7;
            // 
            // tab_update
            // 
            this.tab_update.Animated = true;
            this.tab_update.AnimationHoverSpeed = 0.07F;
            this.tab_update.AnimationSpeed = 0.03F;
            this.tab_update.BackColor = System.Drawing.Color.Transparent;
            this.tab_update.BaseColor = System.Drawing.Color.White;
            this.tab_update.BorderColor = System.Drawing.Color.Black;
            this.tab_update.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.tab_update.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.tab_update.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_update.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_update.CheckedImage = null;
            this.tab_update.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.tab_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.tab_update.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_update.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.tab_update.Image = null;
            this.tab_update.ImageSize = new System.Drawing.Size(20, 20);
            this.tab_update.LineBottom = 5;
            this.tab_update.LineColor = System.Drawing.Color.White;
            this.tab_update.Location = new System.Drawing.Point(260, 0);
            this.tab_update.Name = "tab_update";
            this.tab_update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_update.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_update.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_update.OnHoverImage = null;
            this.tab_update.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_update.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.tab_update.Size = new System.Drawing.Size(130, 41);
            this.tab_update.TabIndex = 2;
            this.tab_update.Text = "Modifier";
            this.tab_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tab_update.Click += new System.EventHandler(this.Tab_update_Click);
            // 
            // tab_add
            // 
            this.tab_add.Animated = true;
            this.tab_add.AnimationHoverSpeed = 0.07F;
            this.tab_add.AnimationSpeed = 0.03F;
            this.tab_add.BackColor = System.Drawing.Color.Transparent;
            this.tab_add.BaseColor = System.Drawing.Color.White;
            this.tab_add.BorderColor = System.Drawing.Color.Black;
            this.tab_add.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.tab_add.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.tab_add.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_add.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_add.CheckedImage = null;
            this.tab_add.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.tab_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.tab_add.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_add.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.tab_add.Image = null;
            this.tab_add.ImageSize = new System.Drawing.Size(20, 20);
            this.tab_add.LineBottom = 5;
            this.tab_add.LineColor = System.Drawing.Color.White;
            this.tab_add.Location = new System.Drawing.Point(130, 0);
            this.tab_add.Name = "tab_add";
            this.tab_add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_add.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_add.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_add.OnHoverImage = null;
            this.tab_add.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_add.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.tab_add.Size = new System.Drawing.Size(130, 41);
            this.tab_add.TabIndex = 1;
            this.tab_add.Text = "Ajouter";
            this.tab_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tab_add.Click += new System.EventHandler(this.Tab_add_Click);
            // 
            // tab_list
            // 
            this.tab_list.Animated = true;
            this.tab_list.AnimationHoverSpeed = 0.07F;
            this.tab_list.AnimationSpeed = 0.03F;
            this.tab_list.BackColor = System.Drawing.Color.Transparent;
            this.tab_list.BaseColor = System.Drawing.Color.White;
            this.tab_list.BorderColor = System.Drawing.Color.Black;
            this.tab_list.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.tab_list.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.tab_list.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_list.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_list.CheckedImage = null;
            this.tab_list.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_list.DialogResult = System.Windows.Forms.DialogResult.None;
            this.tab_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.tab_list.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_list.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.tab_list.Image = null;
            this.tab_list.ImageSize = new System.Drawing.Size(20, 20);
            this.tab_list.LineBottom = 5;
            this.tab_list.LineColor = System.Drawing.Color.White;
            this.tab_list.Location = new System.Drawing.Point(0, 0);
            this.tab_list.Name = "tab_list";
            this.tab_list.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_list.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_list.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.tab_list.OnHoverImage = null;
            this.tab_list.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tab_list.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.tab_list.Size = new System.Drawing.Size(130, 41);
            this.tab_list.TabIndex = 0;
            this.tab_list.Text = "Liste";
            this.tab_list.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tab_list.Click += new System.EventHandler(this.Tab_list_Click);
            // 
            // centralPanel
            // 
            this.centralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralPanel.Location = new System.Drawing.Point(0, 41);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.ShadowDecoration.Parent = this.centralPanel;
            this.centralPanel.Size = new System.Drawing.Size(898, 506);
            this.centralPanel.TabIndex = 8;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.searchBox.BorderRadius = 10;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.Parent = this.searchBox;
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.FocusedState.Parent = this.searchBox;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.HoverState.Parent = this.searchBox;
            this.searchBox.IconLeft = global::UI.Properties.Resources.search_48px1;
            this.searchBox.IconLeftOffset = new System.Drawing.Point(1, 1);
            this.searchBox.Location = new System.Drawing.Point(612, 6);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "Rechercher";
            this.searchBox.SelectedText = "";
            this.searchBox.ShadowDecoration.Parent = this.searchBox;
            this.searchBox.Size = new System.Drawing.Size(279, 28);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 547);
            this.Controls.Add(this.centralPanel);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.ShowIcon = false;
            this.Text = "Products";
            this.Shown += new System.EventHandler(this.Products_Shown);
            this.navBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel navBar;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI.WinForms.GunaAdvenceButton tab_update;
        private Guna.UI.WinForms.GunaAdvenceButton tab_add;
        private Guna.UI.WinForms.GunaAdvenceButton tab_list;
        private Guna.UI2.WinForms.Guna2Panel centralPanel;
    }
}