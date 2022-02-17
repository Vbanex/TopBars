using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopBars.Business
{
   public class Order
    {
        public List<MenuItem> items = new List<MenuItem>();

        public double Total
        {
            get
            {
                double calculatedTotal = 0;
                    foreach(MenuItem currentItem in items)
                {
                    calculatedTotal += currentItem.Price;
                }
                return calculatedTotal;
            }
        }
    }
}
