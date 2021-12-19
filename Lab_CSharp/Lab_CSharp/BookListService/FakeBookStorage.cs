using System.Collections.Generic;
using Lab_CSharp.BookClass;

namespace Lab_CSharp.BookListService
{
    public class FakeBookStorage : IBookStorage
    {
        private List<Book> books;

        public bool IsEmpty()
        {
            return books.Count == 0;
        }
        public FakeBookStorage()
        {
            books = new List<Book>();
        }

        public FakeBookStorage(List<Book> books)
        {
            this.books = books;
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public void AddBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                this.books.Add(book);
            }
        }
    }
}
