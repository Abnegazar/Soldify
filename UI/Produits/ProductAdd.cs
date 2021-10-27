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
    public partial class ProductAdd : Form
    {

        public ProductAdd()
        {
            InitializeComponent();
        }
        private void ProductAdd_Load(object sender, EventArgs e)
        {
            //Guna.UI.Lib.ScrollBar.PanelScrollHelper scrollBar = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(container, containerVScroller, true);
            animateWindow.Start();
        }

        private void EpargneToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (epargneToggle.Checked)
            {
                epPanel.Enabled = true;
            }
            else
            {
                epPanel.Enabled = false;
                epMin.Value = 0;
                epMax.Value = 0;
            }
        }

        private void ToggleDiffere_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleDiffere.Checked)
            {
                diffPanel.Enabled = true;
            }
            else
            {
                diffPanel.Enabled = false;
                differeMin.Value = 0;
                differeMax.Value = 0;
            }
        }

        #region Amortissement Checking
        private void AmAll_CheckStateChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                foreach (Control c in amorPanel.Controls)
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
                    foreach (Control c in amorPanel.Controls)
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
                if(amDeg.Checked && intConst.Checked)
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
                foreach (Control c in clientPanel.Controls)
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
                    foreach (Control c in clientPanel.Controls)
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

        private string GetAmortissement()
        {
            List<string> listAm = new List<string>();
            foreach (Control c in amorPanel.Controls)
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
            foreach (Control c in clientPanel.Controls)
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ProduitClass produit = new ProduitClass();

            produit.NomProduit = nom.Text.Trim();
            produit.Description = description.Text.Trim();
            produit.TypeProduit = typeCbx.GetItemText(typeCbx.SelectedItem);
            produit.MontantMin = decimal.Parse(montantMin.Value.ToString());
            produit.MontantMax = decimal.Parse(montantMax.Value.ToString());
            produit.TauxMin = double.Parse(intMin.Value.ToString());
            produit.TauxMax = double.Parse(intMax.Value.ToString());
            produit.DureeMin = int.Parse(dureeMin.Value.ToString());
            produit.DureeMax = int.Parse(dureeMax.Value.ToString());
            produit.DiffereMin = int.Parse(differeMin.Value.ToString());
            produit.DiffereMax = int.Parse(differeMax.Value.ToString());
            produit.TauxEpargneMin = double.Parse(epMin.Value.ToString());
            produit.TauxEpargneMax = double.Parse(epMax.Value.ToString());
            produit.TauxRetardMin = double.Parse(tirMin.Value.ToString());
            produit.TauxRetardMax = double.Parse(tirMax.Value.ToString());
            produit.TauxPenaliteRetard = double.Parse(penalite.Value.ToString());
            produit.TypeAmortissement = GetAmortissement();
            produit.TypeClient = GetTypeClient();
            produit.CreatedBy = null;

            produit.Save(null);

            CustomNotification notification = new CustomNotification("Ajout effectué avec succes.");
            notification.ShowDialog();
            resetBtn.PerformClick();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            nom.Clear();
            description.Clear();
            typeCbx.SelectedIndex = -1;
            montantMin.Value = 0;
            montantMax.Value = 0;
            intMin.Value = 0;
            intMax.Value = 0;
            dureeMin.Value = 0;
            dureeMax.Value = 0;
            differeMin.Value = 0;
            differeMax.Value = 0;
            epMin.Value = 0;
            epMax.Value = 0;
            tirMin.Value = 0;
            tirMax.Value = 0;
            penalite.Value = 0;
            amAll.Checked = false;
            amDeg.Checked = false;
            amConst.Checked = false;
            intConst.Checked = false;
            pp.Checked = false;
            pm.Checked = false;
            allClient.Checked = false;
        }
    }
}
