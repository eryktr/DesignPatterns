using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.States
{
    class NoCoin : IState
    {
        private VendingMachine vendingMachine;

        public NoCoin(VendingMachine vm)
        {
            vendingMachine = vm;
        }

        public void InsertCoin(double value)
        {
            vendingMachine.SetState(State.CoinEntered);
            vendingMachine.InsertCoin(value);
        }

        public void ReturnCoins()
        {
            Console.WriteLine("No coins entered!");
        }

        public void ChoseProduct(int productID)
        {
            Console.WriteLine("No coins entered!");
        }
    }
}
