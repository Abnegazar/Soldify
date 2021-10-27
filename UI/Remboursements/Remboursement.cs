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
using UI.Notifications;

namespace UI.Remboursements
{
    public partial class Remboursement : Form
    {
        public Remboursement()
        {
            InitializeComponent();
        }

        private void Remboursement_Load(object sender, EventArgs e)
        {
            creditBds.DataSource = CreditClass.FindAll();
            clientBds.DataSource = ViewClients.FindAll();
        }

        private void RembourserBtn_Click(object sender, EventArgs e)
        {
            int credit = int.Parse(idCreditCbx.SelectedValue.ToString());
            DateTime date = dateDepot.Value;
            decimal depot = montant.Value;

            RemboursementClass.Save(credit, depot, date, null);
            CustomNotification notification = new CustomNotification("Remboursement enregistré avec succès.");
            notification.ShowDialog();

            overviewBds.DataSource = Overview.GetInfos(credit);
            remboursementCredit.Visible = true;
            remboursementLbl.Visible = true;

            enCoursBds.DataSource = EnCours.FindByCredit(credit);
            restantGv.Visible = true;
            resteLbl.Visible = true;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            idCreditCbx.SelectedIndex = -1;
            montant.Value = 0;
            dateDepot.Value = DateTime.Now;
            if (remboursementCredit.Visible)
            {
                remboursementCredit.Visible = false;
                remboursementLbl.Visible = false;
            }

            if (restantGv.Visible)
            {
                restantGv.Visible = false;
                resteLbl.Visible = false;
            }
        }

        private void ClientCbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            creditBds.DataSource = CreditClass.FindByClient(int.Parse(clientCbx.SelectedValue.ToString()));
        }
    }
}
