using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDemo.Factory
{
    public class WashingMachineProduct : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new WashingMachine();
        }
    }
}
