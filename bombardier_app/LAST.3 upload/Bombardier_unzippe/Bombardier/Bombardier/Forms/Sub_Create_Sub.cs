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

namespace Bombardier.Forms
{
	public partial class Sub_Create_Sub : Form
	{

		DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
		DataTable table4 = new DataTable();
        DataTable table5 = new DataTable();
        int row = 0;
        int varSubscription_id;
        public static ListBox.SelectedObjectCollection selectedItems;
		string connec = "++";
		string prodIDii;
		string[] prodIDiii;
		int prodID;
        int invid = Subscription.invoice;

		public Sub_Create_Sub()
		{
			InitializeComponent();
			DbHelper.EstablishConnection();
		}

        //add all the product corresponding to the customer aircraft loaded int he invoice and load the invoiceid, customer id and aircraft id from that same invoice
		private void Sub_Create_Sub_Load(object sender, EventArgs e)
		{
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query_1 = @"Select * 
                                FROM sales_orders AS s1
                                JOIN invoices as i1
                                ON i1.Invoice_ID = s1.invoices_Invoice_ID
                                 JOIN subscriptions AS s2
                                ON s2.Subscription_ID = s1.Subscription_ID
                                JOIN products as p1
                                ON s1.products_Product_ID = p1.Product_ID
                                 WHERE invoice_completed_1y_2n = 1
                                        AND invoices_Invoice_ID = " + invid + "";
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = query_1;
            DataTable table = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter(query_1, connection);
            adapt.Fill(table);
            while (row < table.Rows.Count)

            {
                SubscriptionsDA sub = new SubscriptionsDA();
                txtInvID.Text = table.Rows[row]["invoices_Invoice_ID"].ToString();
                custIdTxt.Text = table.Rows[row]["Customer_ID"].ToString();
                aircraft_lbl.Text = table.Rows[row]["Aircraft_ID"].ToString();

               
                string query_2 = @"Select * 
                                FROM  products as p1
                                 WHERE Aircraft_ID = " + table.Rows[row]["Aircraft_ID"] + "";
                MySqlCommand comm2 = connection.CreateCommand();
                comm2.CommandText = query_2;
                MySqlDataAdapter adapt2 = new MySqlDataAdapter(query_2, connection);
                adapt2.Fill(table2);
                while (row < table2.Rows.Count)

                {
                    ProductsDA pro = new ProductsDA();
                    pro.Product_id = Convert.ToInt32(table2.Rows[row]["Product_ID"]);
                    pro.Product_name = table2.Rows[row]["Product_Name"].ToString();
                    pro.Product_type = table2.Rows[row]["Product_Type"].ToString();
                    product_list.Items.Add(pro.Show_product());
                    row += 1;
                }

                row += 1;
            }
            row = 0;
            connection.Close();
   




        }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
          
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

		private void button1_Click(object sender, EventArgs e)
		{
			View_sales_order vw = new View_sales_order();
			vw.Show();
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
			Subscription sub = new Subscription();
			sub.Show();
			this.Hide();
		}

		
		private void button1_Click_1(object sender, EventArgs e)
		{
			View_sales_order vw = new View_sales_order();
			vw.Show();
		}

		private void addSales_Click(object sender, EventArgs e)
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
				sub.Customer_id = Convert.ToInt32(custIdTxt.Text);
				if (radBCredit.Checked)
				{
					sub.Payment_method = "Bombardier Credit";
				}
				else if (radCreditCard.Checked)
				{
					sub.Payment_method = "Credit card";
				}
				else if (radWireTrans.Checked)
				{
					sub.Payment_method = "Wire Transfer";
				}
				sub.Active = 1;

				MySqlConnection connection3 = new MySqlConnection(connec);
				connection3.Open();
				string query3 = "INSERT INTO btm495.subscriptions(Start_Date, End_Date, Payment_Method, Customer_ID, Active) VALUES( @Start_Date, @End_Date, @Payment_Method , @Customer_id , @Active)";
				MySqlCommand comme = connection3.CreateCommand();
				comme.CommandText = query3;
				comme.Parameters.AddWithValue("@Customer_id", sub.Customer_id);
				comme.Parameters.AddWithValue("@Start_Date", sub.Start_date);
				comme.Parameters.AddWithValue("@End_Date", sub.End_date);
				comme.Parameters.AddWithValue("@Payment_Method", sub.Payment_method);
				comme.Parameters.AddWithValue("@Active", sub.Active);
				comme.ExecuteNonQuery();
            

				connection3.Close();

                connection3.Open();
                string query10 = " SELECT max(Subscription_ID) AS submax FROM subscriptions";
                MySqlCommand comme4 = connection3.CreateCommand();
                comme4.CommandText = query3;
                MySqlDataAdapter adapt2 = new MySqlDataAdapter(query10, connection3);
                adapt2.Fill(table5);
                while (row < table5.Rows.Count)

                {
                 
                    varSubscription_id = Convert.ToInt32(table5.Rows[row]["submax"]);
                   
                    row += 1;
                }
                MessageBox.Show("created" + varSubscription_id.ToString());
                row = 0;
            
         
           
                    connection3.Close();

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
                connection3.Open();
                Sales_OrdersDA sales = new Sales_OrdersDA();
                sales.Subscription_id = varSubscription_id;
                sales.Order_date = DateTime.Now.ToString();
                sales.Product_id = prodID;
                sales.Invoice_id = Convert.ToInt32(txtInvID.Text);
                string query4 = @"INSERT INTO btm495.sales_orders(Order_Date, Subscription_ID, products_Product_ID, invoices_Invoice_ID) 
                                    VALUES( @Order_Date, 
                                            (SELECT Subscription_ID FROM btm495.subscriptions WHERE (Subscription_ID =  " + sales.Subscription_id + "))," +
                                            "(SELECT Product_ID FROM btm495.products WHERE (Product_ID =  " + sales.Product_id + ")), " +
                                            "(SELECT Invoice_ID FROM btm495.invoices  WHERE (Invoice_ID =  " + sales.Invoice_id + ")) )";
                MySqlCommand comme2 = connection3.CreateCommand();
                comme2.CommandText = query4;
                comme2.Parameters.AddWithValue("@Order_Date", sales.Order_date);
                comme2.ExecuteNonQuery();
                connection3.Close();

               



                // display confimation - 
                //MessageBox.Show("subscription number " + sub.Subscription_id + " succesfully added ! " + Environment.NewLine + " If you wish to continue your purchase order please select a new product and date, the rest will be taken care of.");


            }
		}

        private void subBackBtn_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subCustBackBtn_Click(object sender, EventArgs e)
        {

            MainMenu slect = new MainMenu();
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            slect.ShowDialog();
        }
    }
	
}
