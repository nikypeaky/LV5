using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv05
{
     class ShippingService 
    {
        private double unitPricePerWeight;

        public ShippingService(double unitPricePerWeight)
        {
            this.unitPricePerWeight = unitPricePerWeight;
        }

        public double CalculateShippingCost(IShipable item)
        {
            return item.Weight * unitPricePerWeight;
        }
    }
}
