using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWTraders.Views
{
    public partial class frmMdiNWTradersMain : Form
    {
        private int childFormNumber = 0;

        public frmMdiNWTradersMain()
        {
            InitializeComponent();
        }

        private void ShowCustomerForm(object sender, EventArgs e)
        {
            Form childForm = new frmNWCustomers();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void NWTradersMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            ShowCustomerForm(sender, e);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
