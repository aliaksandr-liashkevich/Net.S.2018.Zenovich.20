using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net.S._2018.Zenovich._20.AntiSolid.S;

namespace Net.S._2018.Zenovich._20.AntiSolid.L
{
    class DublicateItemList : IList
    {
        public static readonly List<Item> list = new List<Item>();

        public void Add(Item item)
        {
            list.Add(item);
            list.Add(item);
            list.Add(item);
            list.Add(item);
        }

        public int Sum()
        {
            return list.Sum((i) => i.GetPrice());
        }
    }
}
