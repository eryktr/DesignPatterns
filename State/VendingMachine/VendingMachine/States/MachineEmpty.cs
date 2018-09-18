using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.States
{
    class MachineEmpty : IState
    {
        private VendingMachine _vendingMachine;

        public MachineEmpty(VendingMachine vm)
        {
            _vendingMachine = vm;
        }

        public void InsertCoin(double value)
        {
            Console.WriteLine("Machine is empty!");
            _vendingMachine.SetState(State.CoinEntered);
            _vendingMachine.ReturnCoins();
            _vendingMachine.SetState(State.MachineEmpty);

        }

        public void ReturnCoins()
        {
            Console.WriteLine("Machine is empty!");
        }

        public void ChoseProduct(int ProductID)
        {
            Console.WriteLine("Machine is empty!");
        }
    }
}
