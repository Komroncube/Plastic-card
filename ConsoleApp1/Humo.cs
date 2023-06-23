using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Humo : AbstractCard
    {
        public Humo(long number, string name, long money):base(number, name, money) { }
        public override bool Pay(long cost)
        {
            //vazifa shartida if else yozilmagan lekin
            //qarzga sotib olmaydi deb hisoblaymiz
            if (cost > Money || Money < 0)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true;
            }
        }
        public bool PayWireless(long cost)
        {
            if (cost >50000 || Money-cost < 0) return false;
            Money -= cost;
            return true;
        }
    }
}
