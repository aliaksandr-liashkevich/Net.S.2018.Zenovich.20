using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.S._2018.Zenovich._20.AntiSolid.S
{
    public class Item
    {
        public string Name { get; set; }

        public int Price;

        public bool IsValid(bool isAdmin)
        {
            if (isAdmin)
            {
                return Price > 0;
            }

            return Price > 100;
        }
    }
}
