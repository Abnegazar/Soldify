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

namespace UI.Produits
{
    public partial class ProductUpdate : Form
    {
  
        public ProductUpdate()
        {
            InitializeComponent();
        }

        #region Amortissement Checking
            private void AmAll_CheckStateChanged(object sender, EventArgs e)
            {
                if (((CheckBox)sender).Checked == true)
                {
                    foreach (Control c in upAmorPanel.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox cb = (CheckBox)c;
                            cb.Checked = true;
                        }
                    }
                }
                else
                {
                    if (amDeg.Checked && intConst.Checked && amConst.Checked)
                    {
                        foreach (Control c in upAmorPanel.Controls)
                        {
                            if (c is CheckBox)
                            {
                                CheckBox cb = (CheckBox)c;
                                cb.Checked = false;
                            }
                        }
                    }

                }
            }

            private void AmConst_CheckStateChanged(object sender, EventArgs e)
            {
                if (((CheckBox)sender).Checked == false)
                {
                    amAll.Checked = false;
                }
                else
                {
                    if (amDeg.Checked && intConst.Checked)
                    {
                        amAll.Checked = true;
                    }
                }
            }

            private void AmDeg_CheckStateChanged(object sender, EventArgs e)
            {
                if (((CheckBox)sender).Checked == false)
                {
                    amAll.Checked = false;
                }
                else
                {
                    if (amConst.Checked && intConst.Checked)
                    {
                        amAll.Checked = true;
                    }
                }
            }

            private void IntConst_CheckStateChanged(object sender, EventArgs e)
            {
                if (((CheckBox)sender).Checked == false)
                {
                    amAll.Checked = false;
                }
                else
                {
                    if (amDeg.Checked && amConst.Checked)
                    {
                        amAll.Checked = true;
                    }
                }
            }



        #endregion

        #region Type client Checking
            private void AllClient_CheckStateChanged(object sender, EventArgs e)
            {
                if (((CheckBox)sender).Checked == true)
                {
                    foreach (Control c in upClientPanel.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox cb = (CheckBox)c;
                            cb.Checked = true;
                        }
                    }
                }
                else
                {
                    if (pp.Checked && pm.Checked)
                    {
                        foreach (Control c in upClientPanel.Controls)
                        {
                            if (c is CheckBox)
                            {
                                CheckBox cb = (CheckBox)c;
                                cb.Checked = false;
                            }
                        }
                    }

                }
            }

            private void Pp_CheckStateChanged(object sender, EventArgs e)
            {
                if (((CheckBox)sender).Checked == false)
                {
                    allClient.Checked = false;
                }
                else
                {
                    if (pm.Checked)
                    {
                        allClient.Checked = true;
                    }
                }
            }

            private void Pm_CheckStateChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == false)
            {
                allClient.Checked = false;
            }
            else
            {
                if (pp.Checked)
                {
                    allClient.Checked = true;
                }
            }
        }

        #endregion

        private void UpToggleEpargne_CheckedChanged(object sender, EventArgs e)
        {
            if (upToggleEpargne.Checked)
            {
                epargnePanel.Enabled = true;
            }
            else
            {
                epargnePanel.Enabled = false;
                upEpargneMin.Value = 0;
                upEpargneMax.Value = 0;
            }
        }

        private void UpToggleDiffere_CheckedChanged(object sender, EventArgs e)
        {
            if (upToggleDiffere.Checked)
            {
                differePanel.Enabled = true;
            }
            else
            {
                differePanel.Enabled = false;
                upDiffereMin.Value = 0;
                upDiffereMax.Value = 0;
            }
        }

        private string GetAmortissement()
        {
            List<string> listAm = new List<string>();
            foreach (Control c in upAmorPanel.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked)
                    {
                        listAm.Add(cb.Text);
                    }
                }
            }
            return (string.Join(",", listAm.ToArray()));
        }

        private string GetTypeClient()
        {
            List<string> listAm = new List<string>();
            foreach (Control c in upClientPanel.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked)
                    {
                        listAm.Add(cb.Text);
                    }
                }
            }
            return (string.Join(",", listAm.ToArray()));
        }

        private void UpSaveBtn_Click(object sender, EventArgs e)
        {
            ProduitClass toUpdate = ProduitClass.FindById(int.Parse(upProduitCbx.SelectedValue.ToString()));
            ProduitClass produit = new ProduitClass();

            produit.NomProduit = upNom.Text.Trim();
            produit.Description = upDescription.Text.Trim();
            produit.TypeProduit = upTypeCbx.GetItemText(upTypeCbx.SelectedItem);
            produit.MontantMin = decimal.Parse(upMontantMin.Value.ToString());
            produit.MontantMax = decimal.Parse(upMontantMax.Value.ToString());
            produit.TauxMin = double.Parse(upTauxMin.Value.ToString());
            produit.TauxMax = double.Parse(upTauxMax.Value.ToString());
            produit.DureeMin = int.Parse(upDureeMin.Value.ToString());
            produit.DureeMax = int.Parse(upDureeMax.Value.ToString());
            produit.DiffereMin = int.Parse(upDiffereMin.Value.ToString());
            produit.DiffereMax = int.Parse(upDiffereMax.Value.ToString());
            produit.TauxEpargneMin = double.Parse(upEpargneMin.Value.ToString());
            produit.TauxEpargneMax = double.Parse(upEpargneMax.Value.ToString());
            produit.TauxRetardMin = double.Parse(upTauxRetardMin.Value.ToString());
            produit.TauxRetardMax = double.Parse(upTauxRetardMax.Value.ToString());
            produit.TauxPenaliteRetard = double.Parse(upPenalite.Value.ToString());
            produit.TypeAmortissement = GetAmortissement();
            produit.TypeClient = GetTypeClient();

            produit.Save(toUpdate);

            CustomNotification notification = new CustomNotification("Modifications enregistrées avec succes.");
            notification.ShowDialog();
            upResetBtn.PerformClick();
        }

        private void UpResetBtn_Click(object sender, EventArgs e)
        {
            upNom.Clear();
            upDescription.Clear();
            upTypeCbx.SelectedIndex = -1;
            upProduitCbx.SelectedIndex = -1;
            upMontantMin.Value = 0;
            upMontantMax.Value = 0;
            upTauxMin.Value = 0;
            upTauxMax.Value = 0;
            upDureeMin.Value = 0;
            upDureeMax.Value = 0;
            upDiffereMin.Value = 0;
            upDiffereMax.Value = 0;
            upEpargneMin.Value = 0;
            upEpargneMax.Value = 0;
            upTauxRetardMin.Value = 0;
            upTauxRetardMax.Value = 0;
            upPenalite.Value = 0;
            amAll.Checked = false;
            amDeg.Checked = false;
            amConst.Checked = false;
            intConst.Checked = false;
            pp.Checked = false;
            pm.Checked = false;
            allClient.Checked = false;
        }

        private void UpProduitCbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ProduitClass selectedProduit = ProduitClass.FindById(int.Parse(upProduitCbx.SelectedValue.ToString()));

            upNom.Text = selectedProduit.NomProduit;
            upDescription.Text = selectedProduit.Description;
            upTypeCbx.SelectedIndex = upTypeCbx.FindString(selectedProduit.TypeProduit);
            upMontantMin.Value = selectedProduit.MontantMin;
            upMontantMax.Value = selectedProduit.MontantMax;
            upTauxMin.Value = (decimal)selectedProduit.TauxMin;
            upTauxMax.Value = (decimal)selectedProduit.TauxMax;
            upDureeMin.Value = selectedProduit.DureeMin;
            upDureeMax.Value = selectedProduit.DureeMax;
            upToggleDiffere.Checked = true;
            upDiffereMin.Value = selectedProduit.DiffereMin;
            upDiffereMax.Value = selectedProduit.DiffereMax;
            upToggleEpargne.Checked = true;
            upEpargneMin.Value = (decimal)selectedProduit.TauxEpargneMin;
            upEpargneMax.Value = (decimal)selectedProduit.TauxEpargneMax;
            upTauxRetardMin.Value = (decimal)selectedProduit.TauxRetardMin;
            upTauxRetardMax.Value = (decimal)selectedProduit.TauxRetardMax;
            upPenalite.Value = (decimal)selectedProduit.TauxPenaliteRetard;

        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            produitBds.DataSource = ProduitClass.FindByUpdatable(true);
            //_ = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(central, VScroller, true);
        }
    }
}
