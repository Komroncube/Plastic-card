using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class AbstractCard
    {
        public AbstractCard(long number, string name, long money )
        {
            Number = number;
            HolderName = name;
            Money = money;
        }
        /// <summary>
        /// card number needs 16 digits
        /// </summary>
        public long Number { get; set; }
        public string HolderName { get; set; } = string.Empty;

        /// <summary>
        /// User may have money more than billion
        /// </summary>
        public decimal Money { get; set; }

        public abstract bool Pay(long cost);

        public decimal Add(long amount)
        {
            Money += amount;
            return Money;
        }
        protected virtual long bonus { get; set; } = 0;
        public decimal AddWithBonus(long amount)
        {
            Add(amount);
            Money += bonus;
            return Money;
        }
    }
}
