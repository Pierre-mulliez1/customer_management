using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier
{
    class ProductsDA
    {
        private int product_id;
        private int aircraft_id;
        private string product_name;
        private decimal product_price;
        private string product_type;

        public int Product_id
        {
            get => product_id;
            set => product_id = value;
        }

        public int Aircraft_id
        {
            get => aircraft_id;
            set => aircraft_id = value;
        }
        public string Product_name
        {
            get => product_name;
            set => product_name = value;
        }

        public decimal Product_price
        {
            get => product_price;
            set => product_price = value;
        }

        public string Product_type
        {
            get => product_type;
            set => product_type = value;
        }

		public string Show_productID()
		{

			return Product_id.ToString();
		}

		public string Show_product()
        { 

            return Product_id + "," + Product_name + ","+ Product_type;
        }
    }
}
