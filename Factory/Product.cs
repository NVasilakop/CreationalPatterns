using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Product : IProduct
    {
        private int Height { get; set; }
        private int Width { get; set; }
        public Product(int height, int width)
        {
            Height = height;
            Width = width;
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
