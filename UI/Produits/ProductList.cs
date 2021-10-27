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



namespace UI
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            _ = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(listProduitGv, VScroller, true);
            produitBds.DataSource = ProduitClass.FindAll();
        }
    }
}
