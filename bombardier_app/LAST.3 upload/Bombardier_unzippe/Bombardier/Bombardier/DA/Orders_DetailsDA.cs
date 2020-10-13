using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier
{
    class Orders_DetailsDA
    {
        private int order_id;
        private int sales_order_id;
        private int product_id;
        private int quantity;


        public int Order_id
        {
            get => order_id;
            set => order_id = value;
        }

        public int Sales_order_id
        {
            get => sales_order_id;
            set => sales_order_id = value;
        }
        public int Product_id
        {
            get => product_id;
            set => product_id = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }




        public string Show_order(int ide)
        {
            ide = Order_id;


            return Order_id + "," + Sales_order_id + "," + Product_id + "," + Quantity;
        }
    }
}
