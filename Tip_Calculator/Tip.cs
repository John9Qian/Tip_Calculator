using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Calculator
{
     public class Tip
    {
        public string BillAmount { set; get; }
        public string TipAmount { set; get; }
        public string TotalAmount { set; get; }

        public Tip()
        {
            this.BillAmount = String.Empty;
            this.TipAmount = String.Empty;
            this.TotalAmount = String.Empty;
        }

        public void calculateTip(string originalAmount, double tipPercentage)
        {
            double billAmount = 0.0;
            double tipAmount = 0.0;
            double totalAmount = 0.0;

            if(double.TryParse(originalAmount.Replace('$', ' '), out billAmount))
            {
                tipAmount = billAmount * tipPercentage;
                totalAmount = billAmount + tipAmount;
            }
            IFormatProvider provider = CultureInfo.GetCultureInfoByIetfLanguageTag("en-US");
            this.BillAmount = String.Format(provider, "{0:C}", billAmount);
            this.TipAmount = String.Format(provider, "{0:C}", tipAmount);
            this.TotalAmount = String.Format(provider, "{0:C}", totalAmount);
        }
    }
}
