using System;
using System.Collections.Generic;
using System.Text;
using static Factory.Helper;

namespace Factory
{
    public abstract class Transport 
    {
        public abstract IProduct PrepareTransport();
        public Product TransportLogistics(int x,int y)
        {
            var product = PrepareTransport();
            var productItem = product.CreateProduct();
            //int price = product.();
            return productItem;
        }
    }
}
