
using StoreLib.Common;

namespace StoreLib.Order
{
    public class OrderDeliveryFee : IOrderableDecorator
    {
        private IOrderable order;

        private double fee;
        private double priceThreshold;


        public OrderDeliveryFee(IOrderable order, double fee, double priceThreshold)
        {
            this.order = order;
            this.fee = fee;
            this.priceThreshold = priceThreshold;
        }


        public double Cost()
        {
            double cost = order.Cost();

            if(cost > priceThreshold)
            {
                return cost + fee;
            }

            return cost;
        }
    }
}