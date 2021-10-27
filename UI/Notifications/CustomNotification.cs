using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Notifications
{
    public partial class CustomNotification : Form
    {
        public CustomNotification()
        {
            InitializeComponent();
        }
        public CustomNotification(string text)
        {
            InitializeComponent();
            this.notificationText.Text = text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomNotification_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            timer1.Stop();
        }
    }
}
