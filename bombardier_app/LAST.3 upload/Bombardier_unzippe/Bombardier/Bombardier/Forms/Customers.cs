using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bombardier;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bombardier
{
    public partial class Customers : Form
    {
        DataTable table = new DataTable();
        int row = 0;
        public static ListBox.SelectedObjectCollection selectedItems;
        string prodIDii;
        string[] prodIDiii;
        string connec = "++";
        public Customers()
        {
            InitializeComponent();
			DbHelper.EstablishConnection();
        }

        private void btnCreateSub_Click(object sender, EventArgs e)
        {
            Create_Customer cc = new Create_Customer();
            cc.Show();

            this.Hide();
        }

     
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //select the right customer fo the modify form (you have too to proceed)
        private void btnModifyCust_Click(object sender, EventArgs e)
        {
            selectedItems = new ListBox.SelectedObjectCollection(customer_lstbx);
            selectedItems = customer_lstbx.SelectedItems;
            int selectedIndex = customer_lstbx.SelectedIndex;
            if (selectedIndex != -1 && selectedItems != null)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    prodIDii = selectedItems[i].ToString();
                prodIDiii = prodIDii.Split(',');
                customer = Convert.ToInt32(prodIDiii[0]);
                Modify_Customer cc = new Modify_Customer();
                cc.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("PLease select a customer from the list (you can always search using the search box)");
            }

          
        }

        //initialize customerID for the selection int he listbx, used in the modify form
        public static int customer;

        private void Customers_Load(object sender, EventArgs e)
        {
            //load the customer list method with the data from mysql 
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query3 = "SELECT * FROM btm495.customers ";
			MySqlCommand comm = connection.CreateCommand();
			comm.CommandText = query3;
			DataTable table = new DataTable();
			MySqlDataAdapter adapt = new MySqlDataAdapter(query3, connection);
			int row = 0;
			adapt.Fill(table);
			while (row < table.Rows.Count)

			{
				CustomersDA cust = new CustomersDA();
				cust.Customer_id = Convert.ToInt32(table.Rows[row]["Customer_ID"]);
				cust.Company = (string)table.Rows[row]["Company"];
				cust.Phone = Convert.ToInt32(table.Rows[row]["Phone"]);
				customer_lstbx.Items.Add(cust.Show_cust());
				row += 1;
			}
			
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customer_lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //search for the right customer based on ID (default) or name (to be ticked from checkbox)
        private void search_btn_Click(object sender, EventArgs e)
        {
            customer_lstbx.SelectedItem = null;
            foreach (string project in customer_lstbx.Items)
            {
                Convert.ToString(project);
                string[] projectdiv = project.Split(',');
                if (projectdiv[0] == search_txtbx.Text)
                {
                    customer_lstbx.SelectedItem = project;
                    customer_lstbx.Text = "";
                    break;
                }

                if (custid_chckbx.Checked)
                {
                    if (projectdiv[0] == search_txtbx.Text)
                    {
                        customer_lstbx.SelectedItem = project;
                        customer_lstbx.Text = "";
                        custid_chckbx.Checked = false;
                        break;
                    }
                }
                else if (custname_chckbx.Checked)
                {
                    if (projectdiv[1] == search_txtbx.Text)
                    {
                        customer_lstbx.Text = "";
                        custname_chckbx.Checked = false;
                        customer_lstbx.SelectedItem = project;
                        break;
                    }
                }
            }
        }
    }
}
