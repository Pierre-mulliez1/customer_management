using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier.Forms
{
    class order_details
    {
        private int order_detail_id;
        private int sales_order_ID;
        private int product_ID;




        public int Order_detail_id
        {
            get => order_detail_id;
            set => order_detail_id = value;
        }

        public int Sales_order_ID
        {
            get => sales_order_ID;
            set => sales_order_ID = value;
        }
        public int Product_ID
        {
            get => product_ID;
            set => product_ID = value;
        }
    }
}
