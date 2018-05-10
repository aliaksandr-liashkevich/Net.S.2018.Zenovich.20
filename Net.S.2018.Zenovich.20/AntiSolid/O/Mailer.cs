using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Net.S._2018.Zenovich._20.AntiSolid.S;

namespace Net.S._2018.Zenovich._20.AntiSolid.O
{
    public class Mailer
    {
        public Logger logger;

        public Mailer()
        {
            logger = new Logger();
        }


        public void Send(Item item)
        {
            logger.Log(item.ToString());

            Thread.Sleep(500);
        }

    }
}
