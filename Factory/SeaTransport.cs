using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class SeaTransport : Transport
    {
        public override IProduct PrepareTransport()
        {
            return new SeaProduct();
        }
    }
}
