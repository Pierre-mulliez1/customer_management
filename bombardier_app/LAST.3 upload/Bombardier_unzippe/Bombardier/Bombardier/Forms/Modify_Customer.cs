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
    public partial class Modify_Customer : Form
    {
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        int row = 0;
        int chosencustomer = Customers.customer;
        string connec = "++";
        public Modify_Customer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void chkboxSameShipAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBillAdd.Text != string.Empty)
            {
                txtShipAdd.Text = txtBillAdd.Text;
                txtShipCity.Text = txtBillCity.Text;
                txtShipZip.Text = txtBillZipCode.Text;
                txtShipCountry.Text = txtBillCountry.Text;
            }
            else
            {
                MessageBox.Show("Billing Address info is Missing");
            }
        }

        //update button you can change all fields exept customer ID, first and last name, company
        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query3 = @"UPDATE btm495.customers 
                                   SET 
                                    Email = @Email,
                                    Phone = @Phone,
                                    Person_of_Contact = @Person_of_Contact,
                                    Billing_Address_Street = @Billing_Address_Street,
                                    Billing_Address_Postal_Code = @Billing_Address_Postal_Code,
                                    Billing_Address_City = @Billing_Address_City,
                                    Billing_Address_Country = @Billing_Address_Country,
                                    Shipping_Address_Street = @Shipping_Address_Street,
                                    Shipping_Address_Postal_Code = @Shipping_Address_Postal_Code,
                                    Shipping_Address_City = @Shipping_Address_City,
                                    Shipping_Address_Country = @Shipping_Address_Country
                                WHERE (Customer_ID = @Customer_ID)";
            MySqlCommand comm = connection.CreateCommand();
            comm.CommandText = query3;
            comm.Parameters.AddWithValue("@Email", email_txtbx.Text);
            comm.Parameters.AddWithValue("@Phone", phone_txtbx.Text);
            comm.Parameters.AddWithValue("@Person_of_Contact", contact_txtbx.Text);
            comm.Parameters.AddWithValue("@Billing_Address_Street", txtBillAdd.Text);
            comm.Parameters.AddWithValue("@Billing_Address_Postal_Code", txtBillZipCode.Text);
            comm.Parameters.AddWithValue("@Billing_Address_City", txtBillCity.Text);
            comm.Parameters.AddWithValue("@Billing_Address_Country", txtBillCountry.Text);
            comm.Parameters.AddWithValue("@Shipping_Address_Street", txtShipAdd.Text);
            comm.Parameters.AddWithValue("@Shipping_Address_Postal_Code", txtShipZip.Text);
            comm.Parameters.AddWithValue("@Shipping_Address_City", txtShipCity.Text);
            comm.Parameters.AddWithValue("@Shipping_Address_Country", txtShipCountry.Text);
            comm.Parameters.AddWithValue("@Customer_ID", chosencustomer);
            comm.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Customer "+ chosencustomer + " successfully modified !");
        }

        //load customer info from list in customer form 
        private void Modify_Customer_Load(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(connec);
           
            connection.Open();
            string query2 = "SELECT * FROM customers WHERE Customer_ID = " + chosencustomer;
            MySqlDataAdapter adapt2 = new MySqlDataAdapter(query2, connection);
            adapt2.Fill(table2);
            
            while (row < table2.Rows.Count)
            {

                ID_lbl.Text = table2.Rows[row]["Customer_ID"].ToString();
                txtFirstName.Text = table2.Rows[row]["First_Name"].ToString();
                txtLastName.Text = table2.Rows[row]["Last_Name"].ToString();
                txtCompany.Text = table2.Rows[row]["Company"].ToString();
                email_txtbx.Text = table2.Rows[row]["Email"].ToString();
                phone_txtbx.Text = table2.Rows[row]["Phone"].ToString();
                contact_txtbx.Text = table2.Rows[row]["Person_of_Contact"].ToString();
                txtBillAdd.Text = table2.Rows[row]["Billing_Address_Street"].ToString();
                txtBillZipCode.Text = table2.Rows[row]["Billing_Address_Postal_Code"].ToString();
                txtBillCity.Text = table2.Rows[row]["Billing_Address_City"].ToString();
                txtBillCountry.Text = table2.Rows[row]["Billing_Address_Country"].ToString();
                txtShipAdd.Text = table2.Rows[row]["Shipping_Address_Street"].ToString();
                txtShipZip.Text = table2.Rows[row]["Shipping_Address_Postal_Code"].ToString();
                txtShipCity.Text = table2.Rows[row]["Shipping_Address_City"].ToString();
                txtShipCountry.Text = table2.Rows[row]["Shipping_Address_Country"].ToString();

                row += 1;
            }
            row = 0;
            connection.Close();
        }

       
    }
}
