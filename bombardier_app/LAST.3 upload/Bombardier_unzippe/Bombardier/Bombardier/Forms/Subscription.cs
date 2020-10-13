using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bombardier.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bombardier
{	

    public partial class Subscription : Form
    {
        string prodIDii;
        string[] prodIDiii;

        public int Subscription_id { get; set; }
		public int Customer_id { get; set; }
		public string Start_date { get; set; }
		public string End_date { get; set; }
		public int Active { get; set; }


		string connec = "++";
        public static ListBox.SelectedObjectCollection selectedItems;
 

        public Subscription()
        {
            InitializeComponent();
			DbHelper.EstablishConnection();
        }

		public static int subId;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnModifySub_Click(object sender, EventArgs e)
        {
            selectedItems = new ListBox.SelectedObjectCollection(subLB);
            selectedItems = subLB.SelectedItems;
            int selectedIndex = subLB.SelectedIndex;
            if (selectedIndex != -1 && selectedItems != null)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                     prodIDii = selectedItems[i].ToString();
                prodIDiii = prodIDii.Split(',');
                subscription = Convert.ToInt32(prodIDiii[0]);
                Modify_Sub ms = new Modify_Sub();
                ms.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("PLease select a subscription from the list (you can always search using the search box)");
            }
           
        }
        public static int subscription;

        private void bck_btn_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

		private void search_btn_Click(object sender, EventArgs e)
		{
            subLB.SelectedItem = null;
            foreach (string project in subLB.Items)
            {
                Convert.ToString(project);
                string[] projectdiv = project.Split(',');
                if (projectdiv[0] == search_txtbx.Text)
                {
                    subLB.SelectedItem = project;
                    search_txtbx.Text = "";
                    break;
                }

                if (custIdBtn.Checked)
                {
                    if (projectdiv[0] == search_txtbx.Text)
                    {
                        subLB.SelectedItem = project;
                        search_txtbx.Text = "";
                        custIdBtn.Checked = false;
                        break;
                    }
                }
                else if (subIdBtn.Checked)
                {
                    if (projectdiv[1] == search_txtbx.Text)
                    {
                        search_txtbx.Text = "";
                        subIdBtn.Checked = false;
                        subLB.SelectedItem = project;
                        break;
                    }
                }
            }

            }

		private void btnCreateNewSub_Click(object sender, EventArgs e)
		{
			Sub_Create_Sub scs = new Sub_Create_Sub();
			scs.Show();
			this.Hide();
		}

		public void subLB_SelectedIndexChanged(object sender, EventArgs e)
		{
            //the listbox way of selecting should remain the same throughout the interface

			/*int index;
			string item;
			index = subLB.SelectedIndex;
			item = subLB.Items[index].ToString();
			subId = int.Parse(item);
            */
		}

        private void Subscription_Load(object sender, EventArgs e)
        {
            int row = 0;
            //load the customer list method with the data from mysql 
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query3 = "SELECT * FROM subscriptions as s1 JOIN customers as c1 ON s1.Customer_ID = c1.Customer_ID ";
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = query3;
            DataTable table = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter(query3, connection);
            adapt.Fill(table);
            while (row < table.Rows.Count)

            {
                SubscriptionsDA sub = new SubscriptionsDA();
                sub.Customer_id = Convert.ToInt32(table.Rows[row]["Customer_ID"]);
                sub.Subscription_id = Convert.ToInt32(table.Rows[row]["Subscription_ID"]);
                sub.Customer_name = table.Rows[row]["Company"].ToString();
                subLB.Items.Add(sub.show_sub2());
                row += 1;
            }
            row = 0;
            connection.Close();



            //load the invoice list  method with the data from mysql 
            connection.Open();
            string query4 = "Select * FROM invoices WHERE invoice_completed_1y_2n = 1";
            MySqlCommand comm2 = connection.CreateCommand();
            comm2.CommandText = query3;
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapt2 = new MySqlDataAdapter(query4, connection);
            adapt2.Fill(table2);
            while (row < table2.Rows.Count)

            {
                InvoicesDA sub = new InvoicesDA();
                sub.Invoice_id = Convert.ToInt32(table2.Rows[row]["Invoice_ID"]);
                sub.Sub_total = Convert.ToInt32(table2.Rows[row]["Sub_Total"]);
                sub.Date = table2.Rows[row]["invoice_date"].ToString();
                invoice_lstbx.Items.Add(sub.Show_inv());
                row += 1;
            }
            row = 0;
            connection.Close();
        }
        //invoice to be reused in add subscription
        public static int invoice;
        private void invoice_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = invoice_lstbx.SelectedIndex;
            string item = invoice_lstbx.Items[index].ToString();
            invoice = int.Parse(item.Split(',')[0]);
        }
    }
}
 