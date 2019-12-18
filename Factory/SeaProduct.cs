using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class SeaProduct : Product
    {
        public SeaProduct(int height,int width) : base(height,width)
        {

        }

        public Product CreateProduct()
        {
            throw new NotImplementedException();
        }

        public void PrepareProductForTransport()
        {
            throw new NotImplementedException();
        }
    }
}
