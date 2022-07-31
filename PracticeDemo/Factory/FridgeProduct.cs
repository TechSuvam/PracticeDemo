using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDemo.Factory
{
    public class FridgeProduct : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return  new Fridge();
        }
    }
}
