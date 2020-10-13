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
    public partial class Modify_Sub : Form
    {
        string connec = "++";
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        int row = 0;
        public static ListBox.SelectedObjectCollection selectedItems;
        string prodIDii;
        string[] prodIDiii;
        int productid;
        public Modify_Sub()
        {
            InitializeComponent();
            DbHelper.EstablishConnection();
        }


        //load all the pertinent information concerning an aircraft and its products and the customer info associated 
        private void Modify_Sub_Load_1(object sender, EventArgs e)
        {
            int chosenSub;
            chosenSub = Subscription.subscription;
            MySqlConnection connection = new MySqlConnection(connec);

            connection.Open();
            string query3 = @"SELECT invoices_Invoice_ID AS order_number, 
                                i1.invoice_Date,
                                Aircraft_ID,
                                c1.First_Name,
                                c1.Billing_Address_Street,
                                c1.Person_of_Contact,
                                c1.Company,
                                s1.Subscription_ID
                               FROM
                                    sales_orders AS s1
                                    JOIN products AS p1
                                    ON s1.products_Product_ID = p1.Product_ID
                                    JOIN invoices AS i1
                                    ON i1.Invoice_ID = s1.invoices_Invoice_ID
                                    JOIN subscriptions AS s2
                                    ON s1.Subscription_ID = s2.Subscription_ID
                                    JOIN customers AS c1
                                    ON s2.Customer_ID = c1.Customer_ID
                                WHERE
                                   s2.Subscription_ID = " + chosenSub;
            MySqlDataAdapter adapt = new MySqlDataAdapter(query3, connection);
            adapt.Fill(table);

            while (row < table.Rows.Count)
            {
                txtCustomerName.Text = table.Rows[row]["Company"].ToString();
                txtSubID.Text = table.Rows[row]["Subscription_ID"].ToString();

                comboBox1.Text = table.Rows[row]["Aircraft_ID"].ToString();
                row += 1;
            }
            row = 0;
            connection.Close();

            //select all the product given a certain aircraft
            connection.Open();
                string query4 = @"SELECT * FROM products
                                WHERE
                                   Aircraft_ID = " + comboBox1.Text;
            MySqlDataAdapter adapt2 = new MySqlDataAdapter(query4, connection);
            adapt2.Fill(table2);

            while (row < table2.Rows.Count)
            {
                ProductsDA pro = new ProductsDA();
                pro.Product_price = Convert.ToInt32(table2.Rows[row]["Product_price"]);
                pro.Product_name = (string)table2.Rows[row]["Product_name"];
                pro.Product_type = (string)table2.Rows[row]["Product_type"];
                pro.Product_id = Convert.ToInt32(table2.Rows[row]["Product_ID"]);
                product_List.Items.Add(pro.Show_product());
                row += 1;
            }
            row = 0;
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // delete the subscriptions (across tables, respecting the ERD integrety)
        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connec);
                connection.Open();
                string query = @"delete from sales_orders where subscription_ID = " + txtSubID.Text + "";
                MySqlCommand idused = new MySqlCommand(query, connection);
                MySqlDataReader MyReader3;
                MyReader3 = idused.ExecuteReader();
                connection.Close();

                connection.Open();
                string query1 = @"delete from subscriptions where subscription_ID = " + txtSubID.Text + "";
                MySqlCommand idused2 = new MySqlCommand(query1, connection);
                MySqlDataReader MyReader4;
                MyReader4 = idused2.ExecuteReader();
                connection.Close();

                MessageBox.Show("Subscription " + txtSubID.Text + " succesfully deleted (also deleted in your from sales order)");

            }
            catch
            {
                MessageBox.Show("cannot delete this subscription");
            }
        }


        //update products selected from sales order and information from subscription table
        private void btnSaveSub_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query3 = @"UPDATE btm495.subscriptions
                                   SET 
                                    Start_Date = @Start_Date,
                                    End_Date = @End_Date,
                                WHERE (subscription_ID = @subscription_ID)";
            string query4 = @"UPDATE btm495.sales_orders
                                   SET 
                                    products_Product_ID = @products_Product_ID
                                WHERE (subscription_ID = @subscription_ID)";
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = query3;
            comm.Parameters.AddWithValue("@Start_Date", dateTimePicker1.Value.ToString());
            comm.Parameters.AddWithValue("@End_Date", dateTimePicker2.Value.ToString());
            comm.Parameters.AddWithValue("@subscription_ID", txtSubID.Text);

            selectedItems = new ListBox.SelectedObjectCollection(product_List);
            selectedItems = product_List.SelectedItems;
            int selectedIndex = product_List.SelectedIndex;

            if (selectedIndex != -1 && selectedItems != null)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    prodIDii = selectedItems[i].ToString();
                prodIDiii = prodIDii.Split(',');
                productid = Convert.ToInt32(prodIDiii[0]);

                MySqlCommand comm2 = connection.CreateCommand();
                comm2.CommandText = query4;
                comm2.Parameters.AddWithValue("@products_Product_ID", productid);
                comm2.Parameters.AddWithValue("@subscription_ID", txtSubID.Text);

                comm.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}