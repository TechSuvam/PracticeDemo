using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDemo.Factory
{
    public class Fridge : IProduct
    {
        public string GetProduct()
        {
            return "Fridge";
        }
    }
}
