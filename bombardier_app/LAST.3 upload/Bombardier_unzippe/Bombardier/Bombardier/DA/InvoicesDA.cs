using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombardier
{
    class InvoicesDA
    {
        private int invoice_id;
        private int sales_order;
        private decimal sub_total;
        private decimal tax_total;
        private decimal order_total;
        private string date;
        private int completed;




        public int Invoice_id
        {
            get => invoice_id;
            set => invoice_id = value;
        }

        public int Sales_order
        {
            get => sales_order;
            set => sales_order = value;
        }
        public decimal Sub_total
        {
            get => sub_total;
            set => sub_total = value;
        }

        public decimal Tax_total
        {
            get => tax_total;
            set => tax_total = value;
        }

        public decimal Order_total
        {
            get => order_total;
            set => order_total = value;
        }

        public string Date
        {
            get => date;
            set => date = value;
        }

        public int Completed
        {
            get => completed;
            set => completed = value;
        }
        

        public string Show_inv()
        {
         


            return Invoice_id + "," + Date + "," + Sub_total;
        }

        public string showinv2()
        {
            return Invoice_id + ",   the date at which the invoice was created on" + Date + ",   the total without tax was " + Sub_total;
        }
    }
}
