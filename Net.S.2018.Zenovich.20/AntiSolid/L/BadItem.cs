using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net.S._2018.Zenovich._20.AntiSolid.S;

namespace Net.S._2018.Zenovich._20.AntiSolid.L
{
    class BadItem : Item
    {
        public int Year { get; set; }

        public override bool Equals(object obj)
        {
            var item = obj as BadItem;
            return item != null &&
                   Year == item.Year;
        }

        public override int GetPrice()
        {
            return base.Price + Year;
        }

    }
}
