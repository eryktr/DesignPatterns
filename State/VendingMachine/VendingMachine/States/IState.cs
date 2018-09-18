using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.States
{
    interface IState
    {
        void InsertCoin(double value);
        void ReturnCoins();
        void ChoseProduct(int productID);
    }
}
