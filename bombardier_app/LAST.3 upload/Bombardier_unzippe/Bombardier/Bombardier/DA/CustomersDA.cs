using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier
{
    class CustomersDA
    {
        private int customer_id;
        private string company;
        private string person_fo_contact;
        private string first_name;
        private string last_name;
        private int phone;
        private string email;
        private string street_bil;
        private string city_bil;
        private string  postal_code_bil;
        private string state_bil;
        private string country_bil;
        private string street_ship;
        private string city_ship;
        private string postal_code_ship;
        private string state_ship;
        private string country_ship;




        public int Customer_id
        {
            get => customer_id;
            set => customer_id = value;
        }

        public string Company 
        {
            get => company;
            set => company = value;
        }
        public string  Person_fo_contact
        {
            get => person_fo_contact;
            set => person_fo_contact = value;
        }

        public string First_name
        {
            get => first_name;
            set => first_name = value;
        }

        public string Last_name
        {
            get => last_name;
            set => last_name = value;
        }

        public int Phone
        {
            get => phone;
            set => phone = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Street_bil
        {
            get => street_bil;
            set => street_bil = value;
        }

        public string City_bil
        {
            get => city_bil;
            set => city_bil = value;
        }

        public string Postal_code_bil
        {
            get => postal_code_bil;
            set => postal_code_bil = value;
        }

        public string State_bil
        {
            get => state_bil;
            set => state_bil = value;
        }

        public string Country_bil
        {
            get => country_bil;
            set => country_bil = value;
        }

        public string Street_ship
        {
            get => street_ship;
            set => street_ship = value;
        }

        public string City_ship
        {
            get => city_ship;
            set => city_ship = value;
        }

        public string Postal_code_ship
        {
            get => postal_code_ship;
            set => postal_code_ship = value;
        }

        public string State_ship
        {
            get => state_ship;
            set => state_ship = value;
        }

        public string Country_ship
        {
            get => country_ship;
            set => country_ship = value;
        }

        public string Show_billing(int ide)
        {
            ide = customer_id;
            

            return Street_bil + "," + City_bil + "," + Postal_code_bil + "," + State_bil + "," + Country_bil;
        }

        public string Show_cust()
        {
           return Customer_id+","+Company +","+Phone;
        }
        }
    }

