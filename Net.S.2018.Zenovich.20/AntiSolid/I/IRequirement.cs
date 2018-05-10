using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net.S._2018.Zenovich._20.AntiSolid.S;

namespace Net.S._2018.Zenovich._20.AntiSolid.I
{
    interface IRequirement
    {
        bool FindRealItem(Item item);

        bool IsValid(Item item);
    }
}
