using StoreLib.Books;
using StoreLib.Common;

namespace StoreLib.Order
{
    class BookStockItem : IOrderable
    {
        public BookDetail BookDetails { get; set; }

        public double UnitPrice { get; set; }


        public double Cost()
        {
            return UnitPrice;
        }
    }
}