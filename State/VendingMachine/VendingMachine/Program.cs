using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Products;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine(new List<Product>() {new Coke(), new Coke(), new Chips(), new Snickers()});
            vm.InsertCoin(0.5);
            vm.InsertCoin(0.5);
            vm.GetProduct(1);
            vm.InsertCoin(5);
            vm.GetProduct(1);
            vm.GetProduct(1);
            Console.ReadKey();
        }
    }
}
