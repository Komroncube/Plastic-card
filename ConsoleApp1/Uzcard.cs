using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Uzcard : AbstractCard
    {
        public Uzcard(long number, string name, long money):base(number, name, money) { }
        
        
        public override bool Pay(long cost)
        {
            if (cost>Money || Money<0)
            {
                return false;
            }
            else
            {
                Money -= cost;
                return true;
            }
        }
        protected override long bonus { get; set; } = 5;
    }
}
