using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Xml;

namespace RentalFlix.Entites
{
    internal class Customer
    {
//        CustomerID(PK) : Unique identifier for each customer.
//Name: Name of the customer.
//Address: Address of the customer.
//Phone: Contact phone number.
//Email: Contact email address.

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
