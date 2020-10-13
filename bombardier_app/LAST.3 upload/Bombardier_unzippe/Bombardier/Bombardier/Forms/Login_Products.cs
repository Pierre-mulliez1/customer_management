using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombardier
{
	public partial class Login_Products : Form
	{
		int i = 0;
		public Login_Products()
		{
			InitializeComponent();
		}

		//enter the password for changing a product; 3 tries allowed 
		private void enterPWBtn_Click(object sender, EventArgs e)
		{
			const string passwordAdd = "BTM495add";
			const string passwordMdf = "BTM495mdf";
			if (passwordTxt.Text != passwordAdd & passwordTxt.Text != passwordMdf)
			{

				MessageBox.Show("Wrong Password. Please try again.");
				passwordTxt.Clear();
				if (i == 2)
				{
					MessageBox.Show("No more tries.");
					this.Close();
					i = 0;

				}
				i++;

			}
			else if (passwordTxt.Text != passwordAdd)
			{
				Modify_Products mdf = new Modify_Products();
				mdf.Show();
				this.Close();

			}

			else
			{
				Add_Products add = new Add_Products();
				add.Show();
				this.Close();
			}
		}
		private void Login_Products_Load(object sender, EventArgs e)
		{

		}

		private void passwordTxt_TextChanged(object sender, EventArgs e)
		{

		}
	}

}