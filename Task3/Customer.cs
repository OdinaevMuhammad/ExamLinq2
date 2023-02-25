using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3
{
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public List<Purchase> PurchaseHistory { get; set; }
    }
}