using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Devam
{
    public class Doviz
    {
        public string Kod { get; set; }

        public string CurrencyName { get; set; }

        public decimal ForexBuying { get; set; }

        public decimal ForexSelling { get; set; }

        public decimal BanknoteBuying { get; set; }

        public decimal BanknoteSelling { get; set; }

        public decimal CrossRateUSD { get; set; }

        public decimal CrossRateOther { get; set; }

        public override string ToString()
        {
            return this.CurrencyName;
        }
    }
}
