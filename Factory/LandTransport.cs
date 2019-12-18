using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class LandTransport : Transport
    {
        public override IProduct PrepareTransport()
        {
            return new LandProduct();
        }
    }
}
