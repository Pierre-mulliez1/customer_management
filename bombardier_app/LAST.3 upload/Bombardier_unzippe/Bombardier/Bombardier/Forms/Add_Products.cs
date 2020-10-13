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
	public partial class Add_Products : Form
	{
		DataTable table = new DataTable();
		public static ListBox.SelectedObjectCollection selectedItems;
		int row = 0;
		public decimal product_price { get; set; }
		public string product_name { get; set; }
		public int aircraft_id { get; set; }
		public string product_type { get; set; }

		string connec = "++";


		public Add_Products()
		{
			InitializeComponent();
			DbHelper.EstablishConnection();
		}

		private void apCancelBtn_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("All progress will be lost. Do you wish to proceed?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialog == DialogResult.Yes)
			{
				ActiveForm.Close();
			}
			else if (dialog == DialogResult.No)
			{

			}
		}

		private void Add_Products_Load(object sender, EventArgs e)
		{
			MySqlConnection connection = new MySqlConnection(connec);
			connection.Open();
			string queryAircrafts = "SELECT * FROM btm495.Aircrafts";
			MySqlCommand comm = connection.CreateCommand();
			comm.CommandText = queryAircrafts;
			DataTable table = new DataTable();
			MySqlDataAdapter adapt = new MySqlDataAdapter(queryAircrafts, connection);
			adapt.Fill(table);

			while (row < table.Rows.Count)
			{
				AircraftsDA air = new AircraftsDA();
				air.Aircraft_id = Convert.ToInt32(table.Rows[row]["Aircraft_ID"]);
				air.Aircraft_model = (string)table.Rows[row]["Aircraft_Model"];
				airCraftLB.Items.Add(air.Show_aircraftID() + ":" + " " + air.Show_aircraft());
				row += 1;
			}

		}

		private void createBtn_Click(object sender, EventArgs e)
		{

			int index;
			string item;
			index = airCraftLB.SelectedIndex;
			item = airCraftLB.Items[index].ToString();


			product_name = apProductNameBtn.Text.ToString();
			product_price = decimal.Parse(apProdPriceBtn.Text);

			string product_type;

			if (flightButton.Checked)
			{ product_type = "Flight Manual"; }
			else
			{ product_type = "Maintenance Manual"; }


			ProductsDA product = new ProductsDA();

			product.Product_name = product_name;
			product.Product_price = product_price;
			product.Aircraft_id = aircraft_id;
			product.Product_type = product_type;
			product.Aircraft_id = int.Parse(item.Split(':')[0]);

			//check for the defined variable for the connec information
			MySqlConnection connections = new MySqlConnection(connec);
			connections.Open();


			string queryProduct = "INSERT INTO `BTM495`.`Products` (`Aircraft_ID`, `Product_Name`, `Product_Price`, `Product_Type`) VALUES( @Aircraft_ID,@Product_name,@Product_price,@Product_type)";
			MySqlCommand comm = connections.CreateCommand();
			comm.CommandText = queryProduct;

			comm.Parameters.AddWithValue("@Aircraft_id", product.Aircraft_id);
			comm.Parameters.AddWithValue("@Product_name", product.Product_name);
			comm.Parameters.AddWithValue("@Product_price", product.Product_price);
			comm.Parameters.AddWithValue("@Product_type", product.Product_type);

			comm.ExecuteNonQuery();
			connections.Close();



		}

        private void apBtn_Click(object sender, EventArgs e)
        {
            int index;
            string item;
            index = airCraftLB.SelectedIndex;
            item = airCraftLB.Items[index].ToString();


            product_name = apProductNameBtn.Text.ToString();
            product_price = decimal.Parse(apProdPriceBtn.Text);

            string product_type;

            if (flightButton.Checked)
            { product_type = "Flight Manual"; }
            else
            { product_type = "Maintenance Manual"; }


            ProductsDA product = new ProductsDA();

            product.Product_name = product_name;
            product.Product_price = product_price;
            product.Aircraft_id = aircraft_id;
            product.Product_type = product_type;
            product.Aircraft_id = int.Parse(item.Split(':')[0]);

            //check for the defined variable for the connec information
            MySqlConnection connections = new MySqlConnection(connec);
            connections.Open();


            string queryProduct = "INSERT INTO `BTM495`.`Products` (`Aircraft_ID`, `Product_Name`, `Product_Price`, `Product_Type`) VALUES( @Aircraft_ID,@Product_name,@Product_price,@Product_type)";
            MySqlCommand comm = connections.CreateCommand();
            comm.CommandText = queryProduct;

            comm.Parameters.AddWithValue("@Aircraft_id", product.Aircraft_id);
            comm.Parameters.AddWithValue("@Product_name", product.Product_name);
            comm.Parameters.AddWithValue("@Product_price", product.Product_price);
            comm.Parameters.AddWithValue("@Product_type", product.Product_type);

            comm.ExecuteNonQuery();
            connections.Close();
            MessageBox.Show("Product successfully created !");

            //close all form opened
            MainMenu slect = new MainMenu();
            foreach (Form var in Application.OpenForms)
            {
                var.Hide();
            }
            slect.ShowDialog();

        }
    }

}




