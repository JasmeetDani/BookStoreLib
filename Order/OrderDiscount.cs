using StoreLib.Common;

namespace StoreLib.Order
{
    public class OrderDiscount : IOrderableDecorator
    {
        private IOrderable order;

        private double discount;


        public OrderDiscount(IOrderable order, double discount)
        {
            this.order = order;
            this.discount = discount;
        }


        public double Cost()
        {
            double cost = order.Cost();

            return cost - cost * discount / 100;
        }
    }
}