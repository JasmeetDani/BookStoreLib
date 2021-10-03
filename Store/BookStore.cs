using StoreLib.Common;
using StoreLib.Order;

namespace StoreLib.Store
{
    public class BookStore : IOrderableItemSource
    {
        private BooksInventory inventory = new BooksInventory();

        private IDiscountStrategy discountStrategy = null;


        public BookStore(IDiscountStrategy discountStrategy)
        {
            foreach(BookStockItem item in BooksInventory.GetMockInventory())
            {
                this.inventory.AddBook(item, 10);
            }

            this.discountStrategy = discountStrategy;
        }


        public IOrderable GetItem(string title)
        {
            return discountStrategy.Apply(inventory.GetBook(title));
        }
    }
}