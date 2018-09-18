using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.States
{
    class CoinEntered : IState
    {
        private readonly VendingMachine _vendingMachine;

        public CoinEntered(VendingMachine vm)
        {
            _vendingMachine = vm;
        }

        public void InsertCoin(double value)
        {
            Console.WriteLine($"${value} entered");
            _vendingMachine.Sum += value;
        }

        public void ReturnCoins()
        {
            Console.WriteLine($"${_vendingMachine.Sum} returned");
            _vendingMachine.Sum = 0;
            _vendingMachine.SetState(State.NoCoin);
        }

        public void ChoseProduct(int productID)
        {
            if (!_vendingMachine.DeliverProduct(productID)) return;
            Console.WriteLine("I got here");
            _vendingMachine.ReturnCoins();
            _vendingMachine.SetState(!_vendingMachine.isEmpty() ? State.MachineEmpty : State.NoCoin);
        }
    }
}
