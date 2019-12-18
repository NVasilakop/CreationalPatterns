using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
   public class HouseOrganizer
    {
        private IHouseBuilder _builder;

        //public IHouseBuilder Builder
        //{
        //    set { _builder = value; }
        //}

        public HouseOrganizer(IHouseBuilder builder)
        {
            _builder = builder;
        }
        // The Director can construct several product variations using the same
        // building steps.
        public void buildMinimalViableProduct()
        {
            this._builder.BuildFoundations();
        }

        public void buildFullFeaturedProduct()
        {
            this._builder.BuildFoundations();
            this._builder.BuildMainHouse();
            this._builder.BuildRoofTop();
        }
    }
}
