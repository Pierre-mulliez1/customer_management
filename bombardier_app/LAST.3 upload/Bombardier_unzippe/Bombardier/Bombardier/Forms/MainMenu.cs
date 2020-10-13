using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombardier
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnSubscriptions_Click(object sender, EventArgs e)
        {
            Subscription s = new Subscription();
            s.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.Show();
        }

        private void btmProducts_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Show();
        }

        private void btnInvoicing_Click(object sender, EventArgs e)
        {
            Invoice_History ih = new Invoice_History();
            ih.Show();
        }
    }
}
