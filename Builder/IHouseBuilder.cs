using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IHouseBuilder
    {
        void BuildFoundations();
        void BuildMainHouse();
        void BuildRoofTop();
    }
}
