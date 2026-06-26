using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //foreingkeyleri id nin altına yazmaya çalış
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
      
    }
}
