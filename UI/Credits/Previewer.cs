using Business;
using System;
using System.Windows.Forms;

namespace UI.Credits
{
    public partial class Previewer : Form
    {
        #region Variables
            public bool rejected = false;
        #endregion
        public Previewer()
        {
            InitializeComponent();
        }

        public Previewer(int idCredit)
        {
            InitializeComponent();
            Echeance.Save(idCredit);
            echeancierBds.DataSource = Echeance.FindByCredit(idCredit);
        }

        private void Previewer_Load(object sender, EventArgs e)
        {
            _ = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(echeancier, VScroller, true);
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            rejected = true;
            closeBtn.PerformClick();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            rejected = false;
            closeBtn.PerformClick();
        }
    }
}
