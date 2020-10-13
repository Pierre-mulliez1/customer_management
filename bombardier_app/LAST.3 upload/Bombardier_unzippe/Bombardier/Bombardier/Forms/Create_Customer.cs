using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bombardier.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bombardier
{
    public partial class Create_Customer : Form
    {

        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        int row = 0;
        string billcode;
        string shipcode;
        string subjIDii;
        string[] subjIDiii;
        int subjID;
        int custid;
        public static ListBox.SelectedObjectCollection selectedItems;
        string connec = "++";
        public int custId { get; set; }
        public string customerFName { get; set; }
        public string customerLName { get; set; }
        public string company { get; set; }
        public string custFinancialStanding { get; set; }
        public string custBillAdd { get; set; }
        public string custBillCity { get; set; }
        public string custBillCountry { get; set; }
        public string custBillZip { get; set; }
        public string custShipAdd { get; set; }
        public string custShipCity { get; set; }
        public string custShipCountry { get; set; }
        public string custShipZip { get; set; }
        public string paymentType { get; set; }
        public Create_Customer()
        {
            InitializeComponent();
            DbHelper.EstablishConnection();
            txtAutoCustID.Text = custId.ToString();
        }


        private void txtBillAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactName_TextChanged(object sender, EventArgs e)
        {

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

        private void lblBillAddress_Click(object sender, EventArgs e)
        {

        }

        //this process will generate an id and create a customer but WILL not check for previously created customer, it might generate duplicates
        private void btnNxtSub_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty ||
                txtLastName.Text == string.Empty ||
                txtCompany.Text == string.Empty ||
                txtBillAdd.Text == string.Empty ||
                txtBillCity.Text == string.Empty ||
                txtBillZipCode.Text == string.Empty ||
                txtBillCountry.Text == string.Empty ||
                txtShipAdd.Text == string.Empty ||
                txtShipCity.Text == string.Empty ||
                txtShipCountry.Text == string.Empty ||
                txtShipZip.Text == string.Empty

                )
            {
                MessageBox.Show("Please fill out all entry fields");
            }
            else
            { 
            //validate and convert data types (integer)
            if (long.TryParse(phone_txtbx.Text, out long phone))
            {
                phone = long.Parse(phone_txtbx.Text);

                billcode = txtBillZipCode.Text.ToString();
                shipcode = txtShipZip.Text.ToString();
               


                CustomersDA cust = new CustomersDA();

                cust.Company = txtCompany.Text;
                cust.Last_name = txtLastName.Text;
                cust.First_name = txtFirstName.Text;
                cust.Email = mail_txtbx.Text;
                cust.Person_fo_contact = contact_txtbx.Text;
                cust.Phone = Convert.ToInt32(phone);
                cust.Street_bil = txtBillAdd.Text;
                cust.City_bil = txtBillCity.Text;
                cust.Postal_code_bil = billcode;
                cust.Country_bil = txtBillCountry.Text;
                cust.City_ship = txtShipCity.Text;
                cust.Street_ship = txtShipAdd.Text;
                cust.Country_ship = txtShipCountry.Text;
                cust.Postal_code_ship = shipcode;


                try
                {
                    //check for the defined variable for the connec information
                    MySqlConnection connections = new MySqlConnection(connec);
                    connections.Open();


                    string query1 = "INSERT INTO btm495.customers(Company, Person_of_Contact, First_Name, Last_Name, Email, Phone,  Billing_Address_Street, Billing_Address_City, Billing_Address_Country, Billing_Address_Postal_Code,  Shipping_Address_Street, Shipping_Address_City, Shipping_Address_Country, Shipping_Address_Postal_Code) VALUES( @Company, @Person_of_Contact,@First_Name, @Last_Name, @Email, @Phone, @Billing_Address_Street, @Billing_Address_City, @Billing_Address_Country, @Billing_Address_Postal_Code,  @Shipping_Address_Street, @Shipping_Address_City, @Shipping_Address_Country, @Shipping_Address_Postal_Code)";
                    MySqlCommand comm = connections.CreateCommand();
                    comm.CommandText = query1;
                   // comm.Parameters.AddWithValue("@Customer_ID", cust.Customer_id);
                    comm.Parameters.AddWithValue("@Company", cust.Company);
                    comm.Parameters.AddWithValue("@Person_of_Contact", cust.Person_fo_contact);
                    comm.Parameters.AddWithValue("@First_Name", cust.First_name);
                    comm.Parameters.AddWithValue("@Last_Name", cust.Last_name);
                    comm.Parameters.AddWithValue("@Email", cust.Email);
                    comm.Parameters.AddWithValue("@Phone", cust.Phone);
                    comm.Parameters.AddWithValue("@Billing_Address_Street", cust.Street_bil);
                    comm.Parameters.AddWithValue("@Billing_Address_City", cust.City_bil);
                    comm.Parameters.AddWithValue("@Billing_Address_Country", cust.Country_bil);
                    comm.Parameters.AddWithValue("@Billing_Address_Postal_Code", cust.Postal_code_bil);
                    comm.Parameters.AddWithValue("@Shipping_Address_Street", cust.Street_ship);
                    comm.Parameters.AddWithValue("@Shipping_Address_City", cust.City_ship);
                    comm.Parameters.AddWithValue("@Shipping_Address_Country", cust.Country_ship);
                    comm.Parameters.AddWithValue("@Shipping_Address_Postal_Code", cust.Postal_code_ship);
                    comm.ExecuteNonQuery();
                    connections.Close();

                 

                }
                catch
                { MessageBox.Show("connection error"); }








                //select the right aircraft 

               /* Random round = new Random();
                int airid = round.Next(1, 100000);
                */

                selectedItems = new ListBox.SelectedObjectCollection(aircraft_list);
                selectedItems = aircraft_list.SelectedItems;
                int selectedIndex = aircraft_list.SelectedIndex;
                if (selectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        subjIDii = selectedItems[i].ToString();
                    subjIDiii = subjIDii.Split(',');
                    subjID = Convert.ToInt32(subjIDiii[0]);

                    MySqlConnection connection = new MySqlConnection(connec);
                    connection.Open();
                    string query3 = "SELECT max(Customer_ID) AS cust FROM btm495.customers";
                    MySqlDataAdapter adapte = new MySqlDataAdapter(query3, connection);
                    adapte.Fill(table2);
                    custid = Convert.ToInt32(table2.Rows[0]["cust"]);
                    connection.Close();
                 

                    //insert aircraft info into the aircraft licenses
                    Aircraft_license_class license = new Aircraft_license_class();
                //    license.Aircraft_license_ID = airid;
                    license.Aircraft_id = subjID;
                    license.Customer_id = custid;
                  


                  
                    connection.Open();
                    string query2 = "INSERT INTO btm495.aircraft_license( Customer_ID, Aircraft_ID) VALUES((SELECT Customer_ID FROM btm495.customers WHERE (Customer_ID = '" + license.Customer_id + "' )), (SELECT Aircraft_ID FROM btm495.aircrafts WHERE (Aircraft_ID = '" + license.Aircraft_id + "' )))";
                    MySqlCommand comm = connection.CreateCommand();
                    comm.CommandText = query2;
                 //   comm.Parameters.AddWithValue("@aircraft_license", license.Aircraft_license_ID);
                    comm.ExecuteNonQuery();
                    connection.Close();

                        MessageBox.Show("customer succesfully created ");
                }

                
            }
            else { MessageBox.Show("enter postal codes and phone as numbers please"); }


            // to validate that all textboxes are filled out - alex
            
           
            
            
                this.Hide();
                Create_Sub cs = new Create_Sub();
                cs.Show();

            }

        }

        //Pierre _ connection to database data added trhough the customer class DA, select query to automatically fill the customer ID 
        private void btnSave_Click(object sender, EventArgs e)
        {

            //fill ID label 
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query3 = "SELECT max(Customer_ID) AS cust FROM btm495.customers";
            MySqlDataAdapter adapte = new MySqlDataAdapter(query3, connection);
            adapte.Fill(table2);
            txtAutoCustID.Text = table2.Rows[0]["cust"].ToString();
            connection.Close();
            custid = Convert.ToInt32(txtAutoCustID.Text) + 1 ;
           



            var custDt = new DataTable();
                    custDt.Columns.Add("custId", typeof(string));
                    custDt.Columns.Add("custFName", typeof(string));
                    custDt.Columns.Add("custLName", typeof(string));
                    custDt.Columns.Add("company", typeof(string));
                    custDt.Columns.Add("custBillAdd", typeof(string));
                    custDt.Columns.Add("custBillCity", typeof(string));
                    custDt.Columns.Add("custBillCountry", typeof(string));
                    custDt.Columns.Add("custBillZip", typeof(string));
                    custDt.Columns.Add("custShipAdd", typeof(string));
                    custDt.Columns.Add("custShipCity", typeof(string));
                    custDt.Columns.Add("custShipCountry", typeof(string));
                    custDt.Columns.Add("custShipZip", typeof(string));
                    custDt.Columns.Add("custFinancial", typeof(string));

                    if (txtAutoCustID.Text == " ")
                    {
                        MessageBox.Show(" error: custId cannot be blank.");
                        return;
                    }
                    else
                    {
                        custId = custid;
                    }
                    if (txtFirstName.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Firt Name cannot be blank.");
                        return;
                    }
                    else
                    {
                        customerFName = txtFirstName.Text;
                    }

                    if (txtLastName.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Last Name cannot be blank.");
                        return;
                    }
                    else
                    {
                        customerLName = txtLastName.Text;
                    }

                    if (txtCompany.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Company cannot be blank.");
                        return;
                    }
                    else
                    {
                        company = txtCompany.Text;
                    }

                    if (txtBillAdd.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Company cannot be blank.");
                        return;
                    }
                    else
                    {
                        custBillAdd = txtBillAdd.Text;
                    }

                    if (txtBillCity.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Billing City cannot be blank.");
                        return;
                    }
                    else
                    {
                        custBillCity = txtBillCity.Text;
                    }

                    if (txtBillCountry.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Billing Country cannot be blank.");
                        return;
                    }
                    else
                    {
                        custBillCountry = txtBillCountry.Text;
                    }

                    if (txtBillZipCode.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Billing Zip Code cannot be blank.");
                        return;
                    }
                    else
                    {
                        custBillZip = txtBillZipCode.Text;
                    }

                    if (txtShipAdd.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Shipping Address cannot be blank.");
                        return;
                    }
                    else
                    {
                        custShipAdd = txtShipAdd.Text;
                    }

                    if (txtShipCity.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Shipping City cannot be blank.");
                        return;
                    }
                    else
                    {
                        custShipCity = txtShipCity.Text;
                    }

                    if (txtShipCountry.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Shiping Country cannot be blank.");
                        return;
                    }
                    else
                    {
                        custShipCountry = txtShipCountry.Text;
                    }

                    if (txtShipZip.Text == String.Empty)
                    {
                        MessageBox.Show(" error: Shiping Zip Code cannot be blank.");
                        return;
                    }
                    else
                    {
                        custShipZip = txtShipZip.Text;
                    }

                    custDt.Rows.Add(custId.ToString(), customerFName, customerLName, company, custBillAdd, custBillCity, custBillCountry, custBillZip, custShipAdd, custShipCity, custShipCountry, custShipZip);
                    dataGridView1.DataSource = custDt;
                
               
            }

            private void chkboxSameShipAdd_CheckedChanged(object sender, EventArgs e)
            {
                // if checkbox is checked, autofill shipping info
                // if checkbox unchecked, autofill is removed
                if (chkboxSameShipAdd.Checked)
                {
                    txtShipAdd.Text = txtBillAdd.Text;
                    txtShipCity.Text = txtBillCity.Text;
                    txtShipZip.Text = txtBillZipCode.Text;
                    txtShipCountry.Text = txtBillCountry.Text;
                }
                else
                {
                    txtShipAdd.Text = string.Empty;
                    txtShipCity.Text = string.Empty;
                    txtShipZip.Text = string.Empty;
                    txtShipCountry.Text = string.Empty;
                }





            }

            private void Create_Customer_Load(object sender, EventArgs e)
            {
            //Load the customer id 
          //  Random rnd = new Random();
          //  custid = rnd.Next(1, 100000);

            //load the aircraft list method with the data from mysql 
            MySqlConnection connection = new MySqlConnection(connec);
            connection.Open();
            string query3 = "SELECT Aircraft_Model, Aircraft_ID FROM btm495.aircrafts ";
            MySqlDataAdapter adapt = new MySqlDataAdapter(query3, connection);
            adapt.Fill(table);
         
            while (row < table.Rows.Count)
            {
                AircraftsDA air = new AircraftsDA();
                air.Aircraft_id = Convert.ToInt32(table.Rows[row]["Aircraft_ID"]);
                air.Aircraft_model = (string)table.Rows[row]["Aircraft_Model"];
                aircraft_list.Items.Add(air.Show_aircraft());
                row += 1;
            }
            row =  0;
            connection.Close();

         
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void custBackBtn_Click(object sender, EventArgs e)
            {
                Customers c = new Customers();
                c.Show();
                this.Hide();
            }
        }
    } 
