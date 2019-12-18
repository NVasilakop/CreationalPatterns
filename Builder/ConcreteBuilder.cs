using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ConcreteBuilder : IHouseBuilder
    {
        private Product _product = new Product();
        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void BuildFoundations()
        {
            this._product.Add("MainFoundations");
        }

        public void BuildMainHouse()
        {
            this._product.Add("MainHouse");
        }

        public void BuildRoofTop()
        {
            this._product.Add("MainRoofTop");
        }
        public void Reset()
        {
            this._product = new Product();
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
