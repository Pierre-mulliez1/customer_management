using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier.Forms
{
    public class Aircraft_license_class
    {
       
            private int aircraft_id;
            private int customer_id;
            private int aircraft_license_ID;



            public int Aircraft_id
            {
                get => aircraft_id;
                set => aircraft_id = value;
            }


            public int Customer_id
            {
                get => customer_id;
                set => customer_id = value;
            }
            public int Aircraft_license_ID
            {
                get => aircraft_license_ID;
                set => aircraft_license_ID = value;
            }
        }
}
