using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net.S._2018.Zenovich._20.AntiSolid.I;
using Net.S._2018.Zenovich._20.AntiSolid.S;

namespace Net.S._2018.Zenovich._20.AntiSolid.D
{
    class Repository : IRepository
    {
        private readonly List<Item> items = new List<Item>();

        public void Add(Item item)
        {
            IRequirement requirement = new Requirement();

            if (requirement.FindRealItem(item))
            {
                items.Add(item);
            }
        }
    }
}
