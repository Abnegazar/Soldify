using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Parametres;
using UI.Remboursements;
using UI.Credits;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DashBtn_Click(object sender, EventArgs e)
        {
            centralPanel.Controls.Clear();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            centralPanel.Controls.Clear();
            Products productPage = new Products() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, AutoScroll = true };
            centralPanel.Controls.Add(productPage);
            productPage.Show();
        }

        private void CreditBtn_Click(object sender, EventArgs e)
        {
            centralPanel.Controls.Clear();
            Credit credits = new Credit() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, AutoScroll = true };
            centralPanel.Controls.Add(credits);
            credits.Show();
        }

        private void RembBtn_Click(object sender, EventArgs e)
        {
            centralPanel.Controls.Clear();
            Remboursement remboursement = new Remboursement() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, AutoScroll = true };
            centralPanel.Controls.Add(remboursement);
            remboursement.Show();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            centralPanel.Controls.Clear();
        }

        private void EtatBtn_Click(object sender, EventArgs e)
        {
            centralPanel.Controls.Clear();
            Situation situation = new Situation() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, AutoScroll = true };
            centralPanel.Controls.Add(situation);
            situation.Show();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            centralPanel.Controls.Clear();
            Settings settings = new Settings() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false, AutoScroll = true };
            centralPanel.Controls.Add(settings);
            settings.Show();
        }

    }
}
