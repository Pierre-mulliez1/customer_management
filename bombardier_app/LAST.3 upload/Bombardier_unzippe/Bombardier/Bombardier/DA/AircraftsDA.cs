using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier
{
    class AircraftsDA
    {
        private int aircraft_id;
        private string aircraft_model;
        private string aircraft_type;
    


        public int Aircraft_id
        {
            get => aircraft_id;
            set => aircraft_id = value;
        }


        public string Aircraft_model
        {
            get => aircraft_model;
            set => aircraft_model = value;
        }
        public string Aircraft_type
        {
            get => aircraft_type;
            set => aircraft_type = value;
        }




		public int Show_aircraftID()
		{
			return aircraft_id;
		}

		public string Show_aircraft()
		{
			return Aircraft_id + "," + Aircraft_model + "," + Aircraft_type;
		}
	}
}
