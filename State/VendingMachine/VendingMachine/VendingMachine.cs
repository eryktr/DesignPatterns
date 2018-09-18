using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Products;
using VendingMachine.States;

namespace VendingMachine
{
    class VendingMachine
    {
        public double Sum { set; get; }
        private IState _currentState;
        private List<Product> _products;
        private IState _machineEmpty;
        private IState _noCoin;
        private IState _coinEntered;

        public VendingMachine(List<Product> products)
        {
            Sum = 0;
            _products = products;
            _machineEmpty = new MachineEmpty(this);
            _noCoin = new NoCoin(this);
            _coinEntered = new CoinEntered(this);

            _currentState = products.Any() ? _noCoin : _machineEmpty;
        }

        public void InsertCoin(double value)
        {
            _currentState.InsertCoin(value);
        }

        public void ReturnCoins()
        {
            _currentState.ReturnCoins();
        }

        public void GetProduct(int productID)
        {
            _currentState.ChoseProduct(productID);
        }

        public bool DeliverProduct(int productID)
        {
            
            if (productID >= _products.Count)
            {
                Console.WriteLine("Product does not exist");
                return false;
            }

            if (_products[productID].Price > Sum)
            {
                Console.WriteLine("Not enough coins entered");
                return false;
            }
            else
            {
                var currentProduct = _products[productID];
                Console.WriteLine($"{currentProduct.Name} sold!");
                Sum -= currentProduct.Price;
                _products.RemoveAt(1);
                return true;
            }
        }

        public void SetState(State state)
        {
            switch (state)
            {
                case State.CoinEntered:
                    _currentState = _coinEntered;
                    break;
                case State.NoCoin:
                    _currentState = _noCoin;
                    break;
                case State.MachineEmpty:
                    _currentState = _machineEmpty;
                    break;
            }
        }

        public bool isEmpty()
        {
            return _products.Any();
        }

    }
}
