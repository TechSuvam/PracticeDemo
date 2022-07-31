using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDemo.Factory
{
    public interface IProductFactory
    {
        public IProduct CreateProduct();
    }
}
