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
    public partial class View_sales_order : Form
    {
        string connec = "++";
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        int row = 0;
        public View_sales_order()
        {
            InitializeComponent();
        }

        private void btnSubInv_Click(object sender, EventArgs e)
        {
          
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendInvoice_Click(object sender, EventArgs e)
        {

        }

        private void View_sales_order_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connec);
           
            connection.Open();
            string query3 = @"SELECT invoices_Invoice_ID AS order_number, 
                                i1.invoice_Date,
                                Aircraft_ID,
                                products_Product_ID, 
                                Product_Name, 
                                Product_Price, 
                                Product_Type,
                                c1.First_Name,
                                c1.Billing_Address_Street,
                                c1.Person_of_Contact,
                                c1.Company
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
                                    invoices_Invoice_ID = (select max(Invoice_ID) from invoices)";
            MySqlDataAdapter adapt = new MySqlDataAdapter(query3, connection);
            adapt.Fill(table);

            while (row < table.Rows.Count)
            {
                ProductsDA pro = new ProductsDA();
                pro.Product_price = Convert.ToInt32(table.Rows[row]["Product_price"]);
                pro.Product_name = (string)table.Rows[row]["Product_name"];
                pro.Product_type = (string)table.Rows[row]["Product_type"];
                pro.Product_id = Convert.ToInt32(table.Rows[row]["products_Product_ID"]);
                product_listbox.Items.Add(pro.Show_product());
                order_nm.Text = table.Rows[row]["order_number"].ToString();
                order_date_lbl.Text = table.Rows[row]["invoice_Date"].ToString();
                nme_lbl.Text = table.Rows[row]["First_Name"].ToString();
                ship_lbl.Text = table.Rows[row]["Billing_Address_Street"].ToString();
                company_lbl.Text = table.Rows[row]["Company"].ToString();
                contact_lbl.Text = table.Rows[row]["Person_of_Contact"].ToString();
                aircraft_lbl.Text = table.Rows[row]["Aircraft_ID"].ToString();
                row += 1;
            }
            row = 0;
            connection.Close();

            connection.Open();
            string query4 = @"SELECT 
                    MAX(invoices_Invoice_ID) AS order_number,
                    i1.invoice_Date,
                    COUNT(products_Product_ID) AS total_quantity,
                    SUM(Product_Price) AS total_cost
            FROM
                sales_orders AS s1
                JOIN products AS p1
                ON s1.products_Product_ID = p1.Product_ID
                JOIN invoices AS i1
                ON i1.Invoice_ID = s1.invoices_Invoice_ID
			WHERE 
            invoices_Invoice_ID = (select max(Invoice_ID) from invoices)
            GROUP BY
                Invoice_ID";
            MySqlDataAdapter adapt2 = new MySqlDataAdapter(query4, connection);
            adapt2.Fill(table2);

            while (row < table2.Rows.Count)
            {
                InvoicesDA inv = new InvoicesDA();
                inv.Invoice_id = Convert.ToInt32(table2.Rows[row]["order_number"]);
                inv.Completed = 1;
                inv.Order_total = Convert.ToDecimal(table2.Rows[row]["total_quantity"]);
                inv.Sub_total = Convert.ToDecimal(table2.Rows[row]["total_cost"]);
                int Tax_total = Convert.ToInt32(table2.Rows[row]["total_cost"]) ;
                inv.Tax_total = Convert.ToDecimal(Math.Round((Tax_total * 0.15), MidpointRounding.AwayFromZero));
                total_lbl.Text = table2.Rows[row]["total_quantity"].ToString();
                cost_lbl.Text = table2.Rows[row]["total_cost"].ToString();
                tax_lbl.Text = "15%";
                grand_total_lbl.Text = (inv.Tax_total + inv.Sub_total).ToString();



                //update invoice table with the acording information
                //   connection.Open();
                string query7 = "UPDATE btm495.invoices SET invoice_completed_1y_2n = @invoice_completed_1y_2n, Sub_total = @Sub_total, Order_total = @Order_total, Tax_total= @Tax_total WHERE Invoice_ID = @Invoice_ID";
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = query7;
            comm.Parameters.AddWithValue("@invoice_completed_1y_2n", inv.Completed);
            comm.Parameters.AddWithValue("@Sub_total", inv.Sub_total);
            comm.Parameters.AddWithValue("@Order_total", inv.Order_total);
            comm.Parameters.AddWithValue("@Tax_total", inv.Tax_total);
            comm.Parameters.AddWithValue("@Invoice_ID", inv.Invoice_id);
            comm.ExecuteNonQuery();
                //  connection.Close();
                row += 1;
            }
            row = 0;
            connection.Close();
        }
    }
}
