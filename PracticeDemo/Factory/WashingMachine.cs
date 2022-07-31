using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDemo.Factory
{
    public class WashingMachine : IProduct
    {
        public string GetProduct()
        {
            return "Washing Machine";
        }
    }
}
