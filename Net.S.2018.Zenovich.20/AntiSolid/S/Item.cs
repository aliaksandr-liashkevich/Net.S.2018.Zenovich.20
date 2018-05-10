using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public virtual int GetPrice()
        {
            Log(Price.ToString());

            return Price;
        }

        public void Log(string message)
        {
            Debug.WriteLine(message);
        }

        public override bool Equals(object obj)
        {
            var item = obj as Item;
            return item != null &&
                   Name == item.Name &&
                   Price == item.Price;
        }
    }
}
