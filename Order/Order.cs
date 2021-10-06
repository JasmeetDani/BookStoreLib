using StoreLib.Common;
using System;
using System.Collections.Generic;
using System.Text;
a
namespace StoreLib.Order
{
    public class Order : IOrderable
    {
        private IOrderableItemSource source = null;

        private IEnumerable<Tuple<string, int>> itemsToProcess = null;


        public Order(IOrderableItemSource source, IEnumerable<Tuple<string, int>> itemsToProcess)
        {
            this.source = source;
            this.itemsToProcess = itemsToProcess;
        }
        

        public double Cost()
        {
            double cost = 0;

            foreach (Tuple<string, int> item in itemsToProcess)
            {
                cost += source.GetItem(item.Item1).Cost() * item.Item2;
            }

            return cost;
        }


        // For debugging purposes
        public override string ToString()
        {
            string border = new string('*', 40);

            StringBuilder temp = new StringBuilder(border);
            temp.Append("\n\n").Append("ORDER DETAILS".PadLeft(27));
            temp.Append("\n\n").Append(border);
            temp.Append("\nTitle".PadRight(30)).Append("Quantity".PadRight(10));
            temp.Append("\n").Append(border);

            foreach (Tuple<string, int> item in itemsToProcess)
            {
                temp.Append("\n").Append(item.Item1.PadRight(30)).Append(item.Item2.ToString().PadRight(10));
            }

            temp.Append("\n").Append(border);

            temp.Append("\n").Append("Original Order Cost: ").Append(Cost());

            temp.Append("\n").Append(border);

            return temp.ToString();
        }
    }
}
