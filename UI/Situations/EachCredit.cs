using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace UI.Situations
{
    public partial class EachCredit : UserControl
    {
        public EachCredit()
        {
            InitializeComponent();
        }

        public EachCredit(int credit, DateTime date)
        {
            InitializeComponent();
            situationBds.DataSource = SituationClass.FindByCredit(credit, date);
        }
    }
}
