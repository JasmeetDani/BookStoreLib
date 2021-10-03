using StoreLib.Books;
using StoreLib.Common;
using StoreLib.Order;

namespace StoreLib.Store
{
    public class DefaultDiscountStrategy : IDiscountStrategy
    {
        public IOrderable Apply(IOrderable item)
        {
            BookStockItem book = item as BookStockItem;

            if ((book != null) && (book.BookDetails.Genre == BookGenre.Crime))
            {
                return new OrderDiscount(item, 5);
            }

            return item;
        }
    }
}