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
	public partial class Modify_Products : Form
	{

		string connec = "++";


		public Modify_Products()
		{

			InitializeComponent();
		}

		private void Modify_Products_Load_1(object sender, EventArgs e)
		{


			int chosenItem;
			chosenItem = Products.product;
			MySqlConnection connection2 = new MySqlConnection(connec);
			connection2.Open();
			string queryProducts = "SELECT * FROM btm495.Products where Product_ID =" + chosenItem;
			MySqlCommand comm = new MySqlCommand(queryProducts, connection2);
			MySqlDataReader mdr;
			mdr = comm.ExecuteReader();
			string type = "Flight Manual";
			string airid, typetest;
			int aircraftid;
			if (mdr.Read())
			{
				label3.Text = mdr.GetString("Product_id");
				mProductNameTxt.Text = mdr.GetString("Product_name");
				mProdPriceBtn.Text = mdr.GetDecimal("Product_price").ToString();
				typetest = mdr.GetString("Product_type");
				if (typetest.Contains(type))
				{
					flightButton.Checked = true;
				}
				else { mtnButton.Checked = true; }
				aircraftid = mdr.GetInt32("Aircraft_id");
				airid = Convert.ToString(aircraftid);

				MySqlConnection connection1 = new MySqlConnection(connec);
				connection1.Open();
				string queryAircrafts = "SELECT * FROM btm495.Aircrafts";
				MySqlCommand comm1 = connection1.CreateCommand();
				comm1.CommandText = queryAircrafts;
				DataTable table1 = new DataTable();
				MySqlDataAdapter adapt1 = new MySqlDataAdapter(queryAircrafts, connection1);
				adapt1.Fill(table1);
				int row1 = 0;
				while (row1 < table1.Rows.Count)
				{
					AircraftsDA air = new AircraftsDA();
					air.Aircraft_id = Convert.ToInt32(table1.Rows[row1]["Aircraft_ID"]);
					air.Aircraft_model = (string)table1.Rows[row1]["Aircraft_Model"];
					airCraftLB.Items.Add(air.Show_aircraftID() + ":" + " " + air.Show_aircraft());
					row1 += 1;
				}
				airCraftLB.SelectedIndex = airCraftLB.FindString(airid);

			}
		}

			private void amCancelBtn_Click(object sender, EventArgs e)
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
				
		private void mBtn_Click_1(object sender, EventArgs e)
		{
			decimal price;
			price = Convert.ToDecimal(mProdPriceBtn.Text);
			string type;
			if (flightButton.Checked)
			{ type = "Flight Manual"; }
			else { type = "Maintenance Manual"; }
			int chosenItem = int.Parse(label3.Text);
			int index, airid;
			string item;
			index = airCraftLB.SelectedIndex;
			item = airCraftLB.Items[index].ToString();
			airid = int.Parse(item.Split(':')[0]);
			MySqlConnection connectionUpdate = new MySqlConnection(connec);
			connectionUpdate.Open();
			string QueryUP = "UPDATE btm495.products  SET Aircraft_id = (@Aircraft_id), Product_name = (@Product_name), Product_price = (@Product_price), Product_type = (@Product_type) where Product_id=" + chosenItem;
			//This is  MySqlConnection here i have created the object and pass my connection string.  
			MySqlCommand comm = connectionUpdate.CreateCommand();
			comm.CommandText = QueryUP;
			
			MySqlDataAdapter adapt = new MySqlDataAdapter(QueryUP, connectionUpdate);

			
			comm.Parameters.AddWithValue("@Aircraft_id", airid);
			comm.Parameters.AddWithValue("@Product_name", mProductNameTxt.Text);
			comm.Parameters.AddWithValue("@Product_price", price);
			comm.Parameters.AddWithValue("@Product_type", type);
			comm.ExecuteNonQuery();
			
			MessageBox.Show("Product "+chosenItem+ " Updated");
			this.Close();
		}
	}
}
