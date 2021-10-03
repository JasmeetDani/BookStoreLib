using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StoreLib.Order
{
    public class Cart : IEnumerable<Tuple<string, int>>
    {
        private Dictionary<string, int> orderItems = new Dictionary<string, int>();


        public void AddBook(string title, int quantity)
        {
            if (orderItems.ContainsKey(title))
            {
                orderItems[title] = orderItems[title] + quantity;
            }
            else
            {
                orderItems.Add(title, quantity);
            }
        }

        public void Empty() 
        {
            orderItems.Clear();
        }


        public IEnumerator<Tuple<string, int>> GetEnumerator()
        {
            foreach (string item in orderItems.Keys)
            {
                yield return new Tuple<string, int>(item, orderItems[item]);
            }
        }

        // For debugging purposes
        public override string ToString()
        {
            string border = new string('*', 40);
            
            StringBuilder temp = new StringBuilder(border);
            temp.Append("\n\n").Append("CART".PadLeft(20));
            temp.Append("\n\n").Append(border);
            temp.Append("\nTitle".PadRight(30)).Append("Quantity".PadRight(10));
            temp.Append("\n").Append(border);

            foreach (string item in orderItems.Keys)
            {
                temp.Append("\n").Append(item.PadRight(30)).Append(orderItems[item].ToString().PadRight(10));
            }

            temp.Append("\n").Append(border);

            return temp.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}