using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Produits;

namespace UI
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Tab_list_Click(object sender, EventArgs e)
        {
            centralPanel.Controls.Clear();
            ProductList listPage = new ProductList() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, AutoScroll = true };
            centralPanel.Controls.Add(listPage);
            listPage.Show();
        }

        private void Products_Shown(object sender, EventArgs e)
        {
            tab_list.PerformClick();
        }

        private void Tab_add_Click(object sender, EventArgs e)
        {
            searchBox.Visible = false;
            centralPanel.Controls.Clear();
            ProductAdd addPage = new ProductAdd() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, AutoScroll = true };
            addPage.animateWindow.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_ACTIVATE;
            centralPanel.Controls.Add(addPage);
            addPage.Show();
        }

        private void Tab_update_Click(object sender, EventArgs e)
        {
            searchBox.Visible = false;
            centralPanel.Controls.Clear();
            ProductUpdate updatePage = new ProductUpdate() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, AutoScroll = true };
            centralPanel.Controls.Add(updatePage);
            updatePage.Show();
        }
    }
}
