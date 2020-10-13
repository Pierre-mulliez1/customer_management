using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier
{
    class Sales_OrdersDA
    {
        private int sales_orders_ID;
        private int subscription_id;
        private string order_date;
        private int product_id;
        private int invoice_id;



        public int Sales_orders_ID
        {
            get => sales_orders_ID;
            set => sales_orders_ID = value;
        }

        public int Subscription_id
        {
            get => subscription_id;
            set => subscription_id = value;
        }

        public int Product_id
        {
            get => product_id;
            set => product_id = value;
        }

        public int Invoice_id
        {
            get => invoice_id;
            set => invoice_id = value;
        }

        public string Order_date
        {
            get => order_date;
            set => order_date = value;
        }

        
    }
}
