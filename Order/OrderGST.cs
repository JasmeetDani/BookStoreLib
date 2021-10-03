
using StoreLib.Common;

namespace StoreLib.Order
{
    public class OrderGST : IOrderableDecorator
    {
        private IOrderable order;

        private double gstPercentage;


        public OrderGST(IOrderable order, double gstPercentage)
        {
            this.order = order;
            this.gstPercentage = gstPercentage;
        }


        public double Cost()
        {
            double cost = order.Cost();

            return cost + cost * gstPercentage / 100;
        }
    }
}