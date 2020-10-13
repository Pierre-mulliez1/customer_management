using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bombardier.Forms;
using MySql.Data.MySqlClient;

namespace Bombardier
{
    public partial class Create_Sub : Form
    {
       
        DataTable table = new DataTable();
        DataTable table3 = new DataTable();
        DataTable table4 = new DataTable();
        int varSubscription_id;
        int varorderinv;
        int row = 0;
        public static ListBox.SelectedObjectCollection selectedItems;
        string connec = "++";
        string prodIDii;
        string[] prodIDiii;
        int prodID;
        int sales_order_variable;
        public Create_Sub()
        {
            InitializeComponent();
            DbHelper.EstablishConnection();
        }

        
        private void Create_Sub_Load(object sender, EventArgs e)
        {
           
         //Load the information convening to the prevously filled customer information and aircraft choice
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query3 = @" SELECT

                                  aircraft_license AS licenseID,
                                    Customer_ID,
                                    p1.Aircraft_ID,
                                    Product_ID,
                                    Product_name,
                                    Product_price,
                                    Product_type
                            FROM

                                btm495.products AS p1 JOIN
                                btm495.aircraft_license AS l1
                                ON p1.Aircraft_ID = l1.Aircraft_ID
							WHERE 
                            aircraft_license = (select max(aircraft_license) from  btm495.aircraft_license)";
            MySqlDataAdapter adapt = new MySqlDataAdapter(query3, connection);
            adapt.Fill(table);

            while (row < table.Rows.Count)
            {
                ProductsDA pro = new ProductsDA();
                pro.Product_price = Convert.ToInt32(table.Rows[row]["Product_price"]);
                pro.Product_name = (string)table.Rows[row]["Product_name"];
               pro.Product_type = (string)table.Rows[row]["Product_type"];
                pro.Product_id = Convert.ToInt32(table.Rows[row]["Product_ID"]);
                product_list.Items.Add(pro.Show_product());
                aicraft_lbl.Text = table.Rows[row]["Aircraft_ID"].ToString();
                id_lbl.Text = table.Rows[row]["Customer_ID"].ToString();
                row += 1;
            }
            row = 0;
            connection.Close();

            //create an invoice which will be used as a basquet of goods through the following process, date uploaded 
            connection.Open();
            InvoicesDA invoice = new InvoicesDA();
            invoice.Completed = 2;
            invoice.Date = DateTime.Now.ToString();
            MySqlConnection connection3 = new MySqlConnection(connec);
            connection3.Open();
            string query8 = "INSERT INTO btm495.invoices(invoice_completed_1y_2n, invoice_Date) VALUES( @invoice_completed_1y_2n, @invoice_Date)";
            MySqlCommand comme = connection3.CreateCommand();
            comme.CommandText = query8;
            comme.Parameters.AddWithValue("@invoice_completed_1y_2n", invoice.Completed);
            comme.Parameters.AddWithValue("@invoice_Date", invoice.Date);
            comme.ExecuteNonQuery();

            connection.Close();


        }

        private void btnCancelSub_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close this tab? All progress will not be saved.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                ActiveForm.Close();
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void btnSaveSub_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            View_sales_order vw = new View_sales_order();
            vw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (
                radBCredit.Checked == false &&
                radCreditCard.Checked == false &&
                radWireTrans.Checked == false
                )

            {
                MessageBox.Show("please select a payment type");
            }
            else
            {
                //insert int he databse the filled fields 
                SubscriptionsDA sub = new SubscriptionsDA();
                sub.Start_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                sub.End_date = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                sub.Customer_id = Convert.ToInt32(id_lbl.Text);
                if (radBCredit.Checked)
                {
                    sub.Payment_method = "Bombardier Credit";
                }
                else if (radCreditCard.Checked)
                {
                    sub.Payment_method = "Credit card";
                }
                else if(radWireTrans.Checked)
                {
                    sub.Payment_method = "Wire Transfer";
                }
                sub.Active = 1;

                MySqlConnection connection3 = new MySqlConnection(connec);
                connection3.Open();
                string query3 = "INSERT INTO btm495.subscriptions(Start_Date, End_Date, Payment_Method, Customer_ID, Active) VALUES( @Start_Date, @End_Date, @Payment_Method , (SELECT Customer_ID FROM btm495.customers WHERE (Customer_ID =  " + sub.Customer_id + ")) , @Active )";
                MySqlCommand comme = connection3.CreateCommand();
                comme.CommandText = query3;
                comme.Parameters.AddWithValue("@Start_Date", sub.Start_date);
                comme.Parameters.AddWithValue("@End_Date", sub.End_date);
                comme.Parameters.AddWithValue("@Payment_Method", sub.Payment_method);
                comme.Parameters.AddWithValue("@Active", sub.Active);
                comme.ExecuteNonQuery();
                
                connection3.Close();
                // select the last created subscription 
                MySqlConnection connection4 = new MySqlConnection(connec);
                connection4.Open();
                string query4 = "SELECT max(Subscription_ID) AS sub FROM btm495.subscriptions as s1  ";
                MySqlDataAdapter adapt = new MySqlDataAdapter(query4, connection4);
                adapt.Fill(table3);
                while (row < table3.Rows.Count)
                {
                   
                    varSubscription_id = Convert.ToInt32(table3.Rows[row]["sub"]);
                    row += 1;
                }
                row = 0;
                connection4.Close();

                //select the last created invoice
                MySqlConnection connection5 = new MySqlConnection(connec);
                connection5.Open();
				
                string query6 = "SELECT max(Invoice_ID) AS inv FROM btm495.invoices as i1  ";
                MySqlDataAdapter adapt2 = new MySqlDataAdapter(query6, connection5);
                adapt2.Fill(table4);
                while (row < table4.Rows.Count)
                {
                    varorderinv = Convert.ToInt32(table4.Rows[row]["inv"]);
                    row += 1;
                }
                row = 0;
                connection5.Close();

                //add to the sales order table 
                //select the right product
                selectedItems = new ListBox.SelectedObjectCollection(product_list);
                selectedItems = product_list.SelectedItems;
                int selectedIndex = product_list.SelectedIndex;
                if (selectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        prodIDii = selectedItems[i].ToString();
                    prodIDiii = prodIDii.Split(',');
                    prodID = Convert.ToInt32(prodIDiii[0]);
                }
                Sales_OrdersDA sales = new Sales_OrdersDA();
                sales.Subscription_id = varSubscription_id;
                sales.Order_date = DateTime.Now.ToString();
                sales.Product_id = prodID;
                sales.Invoice_id = varorderinv;

                MySqlConnection connection6 = new MySqlConnection(connec);
                connection6.Open();
                string query5 = "INSERT INTO btm495.sales_orders(Order_Date, Subscription_ID, products_Product_ID, invoices_Invoice_ID) VALUES( @Order_Date, (SELECT Subscription_ID FROM btm495.subscriptions WHERE (Subscription_ID =  " + sales.Subscription_id + ")),(SELECT Product_ID FROM btm495.products WHERE (Product_ID =  " + sales.Product_id + ")), (SELECT Invoice_ID FROM btm495.invoices  WHERE (Invoice_ID =  " + sales.Invoice_id + ")) )";
                MySqlCommand comme2 = connection6.CreateCommand();
                comme2.CommandText = query5;
                comme2.Parameters.AddWithValue("@Order_Date", sales.Order_date);
                comme2.ExecuteNonQuery();
                

                // - fill the subscription ID label 
                txtSubID.Text = sales.Subscription_id.ToString();

                // display confimation - 
                MessageBox.Show("subscription number " + sales.Subscription_id + " succesfully added ! "+ Environment.NewLine + " If you wish to continue your purchase order please select a new product and date, the rest will be taken care of.");
                connection6.Close();
            }

        }

        //go main menu
        private void subBackBtn_Click(object sender, EventArgs e)
        {
            
            MainMenu slect = new MainMenu();
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            slect.ShowDialog();
        }

        //back to last form create customers
        private void subBackBtn_Click_1(object sender, EventArgs e)
        {
            Create_Customer cc = new Create_Customer();
            cc.Show();
            this.Hide();
        }

    }
}
