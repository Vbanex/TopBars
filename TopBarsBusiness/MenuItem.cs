using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopBars.Business
{
   public class MenuItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if(value > 0)
                {
                    _price = value;
                }

                else
                {
                    throw new ApplicationException("Item price must be more than 0\n");
                }
            }
        }

        private double _price;
    }
}
