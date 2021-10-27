using Business;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace UI.Credits
{
    public partial class Credit : Form
    {
        #region Variables
            string selectedAmort;
            int idProd;
            int selectedCreditId;
            decimal penalite;
            CreditClass toUpdate = null;
        #endregion

        #region Initialisation
        public Credit()
        {
            InitializeComponent();
        }

        private void Credit_Load(object sender, EventArgs e)
        {
            _ = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(listCreditGv, VScroller, true);
            tab_list.PerformClick();
        }
        #endregion

        #region Navigation
        private void Tab_list_Click(object sender, EventArgs e)
        {
            creditPages.SetPage("listPage");
            creditBds.DataSource = CreditClass.FindAll();
            searchBox.Visible = true;
        }

        private void Tab_add_Click(object sender, EventArgs e)
        {
            searchBox.Visible = false;
            creditBds.DataSource = CreditClass.FindAll();
            produitBds.DataSource = ProduitClass.FindAll();
            viewClientsBds.DataSource = ViewClients.FindAll();
            creditPages.SetPage("addPage");
        }

        private void Tab_update_Click(object sender, EventArgs e)
        {
            searchBox.Visible = false;
            creditBds.DataSource = CreditClass.FindByUpdatable(true);
            produitBds.DataSource = ProduitClass.FindAll();
            viewClientsBds.DataSource = ViewClients.FindAll();
            creditPages.SetPage("updatePage");
        }
        #endregion

        #region Ajout
            private void SaveBtn_Click(object sender, EventArgs e)
            {
                CreditClass credit = new CreditClass();

                credit.IdClient = int.Parse(clientCbx.SelectedValue.ToString());
                credit.IdProduit = int.Parse(produitCbx.SelectedValue.ToString());
                credit.NomCredit = nom.Text.Trim();
                credit.Description = description.Text.Trim();
                credit.TypeAmortissement = selectedAmort.Trim().ToLower();
                credit.Montant = decimal.Parse(montant.Value.ToString());
                credit.Taux = double.Parse(taux.Value.ToString());
                credit.TauxRetard = double.Parse(interetRetard.Value.ToString());
                credit.TauxEpargne = double.Parse(epargne.Value.ToString());
                credit.PenaliteRetard = ((credit.Montant * penalite)/100);
                credit.Duree = int.Parse(duree.Value.ToString());
                credit.Differe = int.Parse(differe.Value.ToString());
                credit.FrequenceRemboursement = int.Parse(frequence.Value.ToString());

                Results results = credit.SmartSave(toUpdate);

                Previewer echeancier = new Previewer(results.InsertedId);
                echeancier.ShowDialog();

                if (echeancier.rejected)
                {
                    toUpdate = CreditClass.FindById(results.InsertedId);
                }
                else
                {
                    resetBtn.PerformClick();
                }
            }

            private void ProduitCbx_SelectionChangeCommitted(object sender, EventArgs e)
            {
                idProd = int.Parse(produitCbx.SelectedValue.ToString());
                ProduitClass selectedProduct = ProduitClass.FindById(idProd);

                montant.Minimum = selectedProduct.MontantMin;
                montant.Maximum = selectedProduct.MontantMax;

                duree.Minimum = selectedProduct.DureeMin;
                duree.Maximum = selectedProduct.DureeMax;

                differe.Minimum = selectedProduct.DiffereMin;
                differe.Maximum = selectedProduct.DiffereMax;

                taux.Minimum = (decimal)selectedProduct.TauxMin;
                taux.Maximum = (decimal)selectedProduct.TauxMax;

                interetRetard.Minimum = (decimal)selectedProduct.TauxRetardMin;
                interetRetard.Maximum = (decimal)selectedProduct.TauxRetardMax;

                //epargne.Minimum = (decimal)selectedProduct.TauxEpargneMin;
                //epargne.Maximum = (decimal)selectedProduct.TauxEpargneMax;

                penalite = (decimal)selectedProduct.TauxPenaliteRetard;
            }

            private void Amortissement_CheckedChanged(Object sender, EventArgs e)
            {
                if (((RadioButton)sender).Checked)
                {
                    RadioButton rb = (RadioButton)sender;
                    selectedAmort = rb.Text;
                }
            }

            private void ResetBtn_Click(object sender, EventArgs e)
            {
                clientCbx.SelectedIndex = -1;
                produitCbx.SelectedIndex = -1;
                nom.Clear();
                description.Clear();
                montant.Minimum = 0;
                montant.Value = montant.Minimum;
                taux.Minimum = 0;
                taux.Value = taux.Minimum;
                interetRetard.Minimum = 0;
                interetRetard.Value = interetRetard.Minimum;
                epargne.Minimum = 0;
                epargne.Value = epargne.Minimum;
                duree.Minimum = 0;
                duree.Value = duree.Minimum;
                differe.Minimum = 0;
                differe.Value = differe.Minimum;
                frequence.Minimum = 0;
                frequence.Value = frequence.Minimum;

                foreach (Control cntrl in Controls)
                {
                    if(cntrl is RadioButton)
                    {
                        RadioButton _rb = (RadioButton)cntrl;
                        if (_rb.Checked)
                        {
                            _rb.Checked = false;
                        }
                    }
                }
            }
        #endregion

        #region Update
            private void UpOldCredit_SelectionChangeCommitted(object sender, EventArgs e)
            {
                selectedCreditId = int.Parse(upOldCredit.SelectedValue.ToString());
                CreditClass selectedCredit = CreditClass.FindById(selectedCreditId);

                upNom.Text = selectedCredit.NomCredit;
                upDescription.Text = selectedCredit.Description;
                upProduitCbx.SelectedValue = selectedCredit.IdProduit;
                upClientCbx.SelectedValue = selectedCredit.IdClient;
                upMontant.Value = selectedCredit.Montant;
                upDuree.Value = selectedCredit.Duree;
                upDiffere.Value = selectedCredit.Differe;
                upFrequence.Value = selectedCredit.FrequenceRemboursement;
                upTaux.Value = (decimal)selectedCredit.Taux;
                upTauxRetard.Value = (decimal)selectedCredit.TauxRetard;
                upEpargne.Value = (decimal)selectedCredit.TauxEpargne;
                penalite = selectedCredit.PenaliteRetard;
                
                foreach(Control c in central.Controls)
                {
                    if(c is RadioButton)
                    {
                        RadioButton rb = (RadioButton)c;
                        if(rb.Text.Trim().ToLower() == selectedCredit.TypeAmortissement.ToLower())
                        {
                            rb.Checked = true;
                        }
                    }
                }

            }

            private void UpProduitCbx_SelectionChangeCommitted(object sender, EventArgs e)
            {
                idProd = int.Parse(produitCbx.SelectedValue.ToString());
                ProduitClass selectedProduct = ProduitClass.FindById(idProd);

                upMontant.Minimum = selectedProduct.MontantMin;
                upMontant.Maximum = selectedProduct.MontantMax;

                upDuree.Minimum = selectedProduct.DureeMin;
                upDuree.Maximum = selectedProduct.DureeMax;

                upDiffere.Minimum = selectedProduct.DiffereMin;
                upDiffere.Maximum = selectedProduct.DiffereMax;

                upTaux.Minimum = (decimal)selectedProduct.TauxMin;
                upTaux.Maximum = (decimal)selectedProduct.TauxMax;

                upTauxRetard.Minimum = (decimal)selectedProduct.TauxRetardMin;
                upTauxRetard.Maximum = (decimal)selectedProduct.TauxRetardMax;

                upEpargne.Minimum = (decimal)selectedProduct.TauxEpargneMin;
                upEpargne.Maximum = (decimal)selectedProduct.TauxEpargneMax;

                penalite = (decimal)selectedProduct.TauxPenaliteRetard;
            }

            private void UpSaveBtn_Click(object sender, EventArgs e)
            {
                toUpdate = CreditClass.FindById(int.Parse(upOldCredit.SelectedValue.ToString()));

                CreditClass credit = new CreditClass();
                credit.IdClient = int.Parse(upClientCbx.SelectedValue.ToString());
                credit.IdProduit = int.Parse(upProduitCbx.SelectedValue.ToString());
                credit.NomCredit = upNom.Text.Trim();
                credit.Description = upDescription.Text.Trim();
                credit.TypeAmortissement = selectedAmort.Trim().ToLower();
                credit.Montant = decimal.Parse(upMontant.Value.ToString());
                credit.Taux = double.Parse(upTaux.Value.ToString());
                credit.TauxRetard = double.Parse(upTauxRetard.Value.ToString());
                credit.TauxEpargne = double.Parse(upEpargne.Value.ToString());
                credit.PenaliteRetard = ((credit.Montant * penalite) / 100);
                credit.Duree = int.Parse(upDuree.Value.ToString());
                credit.Differe = int.Parse(upDiffere.Value.ToString());
                credit.FrequenceRemboursement = int.Parse(upFrequence.Value.ToString());

                Results results = credit.SmartSave(toUpdate);

                Previewer echeancier = new Previewer(results.InsertedId);
                echeancier.ShowDialog();

                if (!echeancier.rejected)
                {
                    resetBtn.PerformClick();
                }
            }

            private void UpAmortissement_CheckedChanged(object sender, EventArgs e)
            {
                if (((RadioButton)sender).Checked)
                {
                    RadioButton rb = (RadioButton)sender;
                    selectedAmort = rb.Text;
                }
            }

            private void UpResetBtn_Click(object sender, EventArgs e)
            {
                upClientCbx.SelectedIndex = -1;
                upProduitCbx.SelectedIndex = -1;
                upNom.Clear();
                upDescription.Clear();
                upMontant.Minimum = 0;
                upMontant.Value = montant.Minimum;
                upTaux.Minimum = 0;
                upTaux.Value = taux.Minimum;
                upTauxRetard.Minimum = 0;
                upTauxRetard.Value = interetRetard.Minimum;
                upEpargne.Minimum = 0;
                upEpargne.Value = epargne.Minimum;
                upDuree.Minimum = 0;
                upDuree.Value = duree.Minimum;
                upDiffere.Minimum = 0;
                upDiffere.Value = differe.Minimum;
                upFrequence.Minimum = 0;
                upFrequence.Value = frequence.Minimum;
            }
        #endregion
    }
}
