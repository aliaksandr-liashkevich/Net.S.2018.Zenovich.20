using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net.S._2018.Zenovich._20.AntiSolid.S;

namespace Net.S._2018.Zenovich._20.AntiSolid.I
{
    class Requirement : IRequirement
    {
        public bool FindRealItem(Item item)
        {
            if (item.Price > 0)
            {
                return true;
            }

            return false;
        }

        public bool IsValid(Item item)
        {
            return item.Name.Contains("a");
        }
    }
}
