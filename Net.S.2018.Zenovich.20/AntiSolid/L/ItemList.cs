using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net.S._2018.Zenovich._20.AntiSolid.S;

namespace Net.S._2018.Zenovich._20.AntiSolid.L
{
    class ItemList : IList
    {
        public static readonly List<Item> items = new List<Item>();

        public void Add(Item item)
        {
            items.Add(item);
        }

        public int Sum()
        {
            return items.Sum((i) => i.GetPrice());
        }
    }
}
