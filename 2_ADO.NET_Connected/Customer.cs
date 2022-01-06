using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ADO.NET_Connected
{
    class Customer
    {
        public Customer()
        {

        }

        public Customer(string customerID, string companyName, string contactName, string phone, string country)
        {
            this.CustomerID = customerID;
            this.CompanyName = companyName;
            this.ContactName = contactName;
            this.Phone = phone;
            this.Country = country;
        }

        public string CustomerID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string Phone { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            return this.CompanyName;
        }
    }
}
