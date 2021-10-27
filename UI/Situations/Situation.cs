using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Credits;
using UI.Situations;

namespace UI
{
    public partial class Situation : Form
    {
        private int selectedClient;
        private int selectedCredit;

        public Situation()
        {
            InitializeComponent();
            clientsBds.DataSource = ViewClients.FindAll();
            creditBds.DataSource = CreditClass.FindAll();
        }

        private void Tab_client_Click(object sender, EventArgs e)
        {
            pages.SetPage(clientPage);
        }

        private void Tab_credit_Click(object sender, EventArgs e)
        {
            pages.SetPage(creditPage);
        }

        private void SituClientBtn_Click(object sender, EventArgs e)
        {
            center.Controls.Clear();
            int iniPos = 0;
            List<CreditClass> listCredits = CreditClass.FindByClient(selectedClient);
            foreach (CreditClass credit in listCredits)
            {
                EachCredit each = new EachCredit(credit.IdCredit, cliSitDate.Value);
                center.Controls.Add(each);
                each.Top = iniPos;
                each.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
                each.Width = (center.Width);
                each.Show();
                iniPos += 75;
            }
        }

        private void ClientCbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedClient = int.Parse(clientCbx.SelectedValue.ToString());
            situClientBtn.Enabled = true;
        }

        private void Situation_Load(object sender, EventArgs e)
        {
            _ = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(center, VScroller, true);
            tab_client.PerformClick();
        }

        private void CreditCbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedCredit = int.Parse(creditCbx.SelectedValue.ToString());
            situCreditBtn.Enabled = true;
            seeEcheancier.Enabled = true;
        }

        private void SituCreditBtn_Click(object sender, EventArgs e)
        {
            List<SituationClass> situations = SituationClass.FindByCredit(selectedCredit, dateRefCred.Value);
            situationSource.DataSource = situations;
            overviewBds.DataSource = Overview.GetInfos(selectedCredit);
            grid.Visible = true;
            overviewCredit.Visible = true;
        }

        private void CreditPage_Click(object sender, EventArgs e)
        {
            _ = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(grid, HScroller, true);
        }

        private void SeeEcheancier_Click(object sender, EventArgs e)
        {
            Previewer echeancier = new Previewer(selectedCredit);
            echeancier.rejectBtn.Enabled = false;
            echeancier.saveBtn.Enabled = false;
            echeancier.hide.Visible = true;
            echeancier.ShowDialog();
        }
    }
}
