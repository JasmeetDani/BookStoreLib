using StoreLib.Books;
using StoreLib.Order;
using System.Collections.Generic;

namespace StoreLib.Store
{
    class BooksInventory
    {
        private List<BookStockItem> bookStock = new List<BookStockItem>();

        private List<int> quantities = new List<int>();


        public static List<BookStockItem> GetMockInventory()
        {
            /** 
             * The bookstore holds the following collection
             *
            */
            return new List<BookStockItem>()
            {
                new BookStockItem
                {
                    BookDetails = new BookDetail { Title = "Unsolved murders", Author = "Emily G. Thompson, Amber Hunt", Genre = BookGenre.Crime },
                    UnitPrice = 10.99
                },

                new BookStockItem
                {
                    BookDetails = new BookDetail { Title = "Alice in Wonderland", Author = "Lewis Carroll", Genre = BookGenre.Fantasy },
                    UnitPrice = 5.99
                },

                new BookStockItem
                {
                    BookDetails = new BookDetail { Title = "A Little Love Story", Author = "Roland Merullo", Genre = BookGenre.Romance },
                    UnitPrice = 2.40
                },

                new BookStockItem
                {
                    BookDetails = new BookDetail { Title = "Heresy", Author = "S J Parris", Genre = BookGenre.Fantasy },
                    UnitPrice = 6.80
                },

                new BookStockItem
                {
                    BookDetails = new BookDetail { Title = "The Neverending Story", Author = "Michael Ende", Genre = BookGenre.Fantasy },
                    UnitPrice = 7.99
                },

                new BookStockItem
                {
                    BookDetails = new BookDetail { Title = "Jack the Ripper", Author = "Philip Sugden", Genre = BookGenre.Crime },
                    UnitPrice = 16.00
                },

                new BookStockItem
                {
                    BookDetails = new BookDetail { Title = "The Tolkien Years", Author = "Greg Hildebrandt", Genre = BookGenre.Fantasy },
                    UnitPrice = 22.90
                }
            };
        }


        public void AddBook(BookStockItem stock, int quantity)
        {
            BookStockItem temp = bookStock.Find(book => book.BookDetails.Title.Equals(stock.BookDetails.Title));

            if (temp != null)
            {
                quantities[bookStock.IndexOf(temp)] += quantity;
            }
            else
            {
                bookStock.Add(stock);
                quantities.Add(quantity);
            }
        }

        public BookStockItem GetBook(string title)
        {
            BookStockItem temp = bookStock.Find(book => book.BookDetails.Title.Equals(title));

            if (temp == null) throw new System.InvalidOperationException();

            return temp;
        }
    }
}