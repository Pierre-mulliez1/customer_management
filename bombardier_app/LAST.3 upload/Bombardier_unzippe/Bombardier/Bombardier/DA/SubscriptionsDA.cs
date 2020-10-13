using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier
{
    class SubscriptionsDA
    {
        private int subscription_id;
        private int customer_id;
        private string customer_name;
        private string start_date;
        private string end_date;
        private string payment_method;
        private int user_count;
        private int active;




        public int Customer_id
        {
            get => customer_id;
            set => customer_id = value;
        }

        public string Customer_name
        {
            get => customer_name;
            set => customer_name = value;
        }

        public int Subscription_id
        {
            get => subscription_id;
            set => subscription_id = value;
        }
        public string Start_date
        {
            get => start_date;
            set => start_date = value;
        }

        public string End_date
        {
            get => end_date;
            set => end_date = value;
        }

        public string Payment_method
        {
            get => payment_method;
            set => payment_method = value;
        }

        public int User_count
        {
            get => user_count;
            set => user_count = value;
        }

        public int Active
        {
            get => active;
            set => active = value;
        }


        public string Show_sub(int ide)
        {
            ide = Subscription_id;


            return Subscription_id + "," + Start_date + "," + End_date + "," + User_count + "," + Active;
        }

        public string show_sub2()
        {
            return subscription_id + ","  + Customer_id + "," + Customer_name;
        }

		public int Show_subID()
		{
			

			return Subscription_id ;
		}

	}
}
