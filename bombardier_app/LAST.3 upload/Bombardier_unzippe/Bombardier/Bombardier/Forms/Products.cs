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
	public partial class Products : Form
	{
		DataTable table = new DataTable();
		public static ListBox.SelectedObjectCollection selectedItems;
		int row = 0;
		public decimal product_price { get; set; }
		public string product_name { get; set; }
		public int Product_id { get; set; }
		public int Aircraft_ID { get; set; }
		public string product_type { get; set; }

		string connec = "++";


		public Products()
		{
			InitializeComponent();
			DbHelper.EstablishConnection();

			MySqlConnection connection = new MySqlConnection(connec);
			connection.Open();
			string queryProducts = "SELECT * FROM btm495.Products";
			MySqlCommand comm = connection.CreateCommand();
			comm.CommandText = queryProducts;
			DataTable table = new DataTable();
			MySqlDataAdapter adapt = new MySqlDataAdapter(queryProducts, connection);
			adapt.Fill(table);

			while (row < table.Rows.Count)
			{
				ProductsDA product = new ProductsDA();
				product.Product_id = Convert.ToInt32(table.Rows[row]["Product_ID"]);
				product.Product_name = (string)table.Rows[row]["Product_name"];
				product.Product_type = (string)table.Rows[row]["Product_type"];
				comboBox1.Items.Add(product.Show_product());
				row += 1;
			}
            row = 0;

		}

		
		public static int product;

		private void addProductBtn_Click(object sender, EventArgs e)
		{

			Login_Products lp = new Login_Products();
			lp.Show();
		}

		
		private void prodMainMenuBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index;
			string item;
			index = comboBox1.SelectedIndex;
			item = comboBox1.Items[index].ToString();
			product = int.Parse(item.Split(',')[0]);
			MySqlConnection connection2 = new MySqlConnection(connec);
			connection2.Open();
			string queryProducts = "SELECT * FROM btm495.Products where Product_ID =" + product;
			MySqlCommand comm = new MySqlCommand(queryProducts, connection2);
			MySqlDataReader mdr;
			mdr = comm.ExecuteReader();

			if (mdr.Read())
			{
				
				productList.Items.Add("Product ID: " + mdr.GetString("Product_id"));
				productList.Items.Add("Product Name: " + mdr.GetString("Product_name"));
				productList.Items.Add("Product Price: " + mdr.GetDecimal("Product_price").ToString());
				productList.Items.Add("Product Type: " + mdr.GetString("Product_type"));
			}
			else
			{
				MessageBox.Show("info not found");
			}
		
	}

		private void mdfBtn_Click_1(object sender, EventArgs e)
		{
			Login_Products lp = new Login_Products();
			lp.Show();
		}

        private void Products_Load(object sender, EventArgs e)
        {

        }
    }
}

