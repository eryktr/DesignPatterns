using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Products
{
    abstract class Product
    {
        public double Price { get; protected set; }
        public string Name { get; protected set; }

    }
}
