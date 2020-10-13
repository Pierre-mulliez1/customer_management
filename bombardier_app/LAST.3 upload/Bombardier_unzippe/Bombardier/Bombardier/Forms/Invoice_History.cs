using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bombardier
{
    public partial class Invoice_History : Form
    {
        DataTable table1 = new DataTable();
        int row1 = 0;
        string connec = "++";
        public Invoice_History()
        {
            InitializeComponent();
        }

        private void backToMainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Invoice_History_Load(object sender, EventArgs e)
        {
            MySqlConnection connection1 = new MySqlConnection(connec);
            connection1.Open();
            string query1 = "SELECT * FROM btm495.invoices WHERE invoice_completed_1y_2n = 1";
            MySqlCommand comm1 = connection1.CreateCommand();
            comm1.CommandText = query1;
           
            MySqlDataAdapter adapt1 = new MySqlDataAdapter(query1, connection1);
            adapt1.Fill(table1);
          
            while (row1 < table1.Rows.Count)
            {
                InvoicesDA inv = new InvoicesDA();
                inv.Invoice_id = Convert.ToInt32(table1.Rows[row1]["Invoice_ID"]);
                inv.Sub_total = Convert.ToInt32(table1.Rows[row1]["Sub_Total"]);
                inv.Date = table1.Rows[row1]["invoice_date"].ToString();
                inv_listbx.Items.Add(inv.showinv2());
                row1 += 1;
            }
            row1 = 0;
        }
    }
}
