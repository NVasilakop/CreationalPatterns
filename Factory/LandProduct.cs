using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class LandProduct : Product
    {
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
