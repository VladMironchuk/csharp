using System.Collections.Generic;
using BookClass;

namespace BookListService
{
    public class BookStorage
    {
        private List<Book> books;

        public bool isEmpty()
        {
            if (books.Count == 0) { return true; }
            return false;
        }
        public BookStorage()
        {
            books = new List<Book>();
        }

        public BookStorage(List<Book> books)
        {
            this.books = books;
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public void AddBooks(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                this.books.Add(books[i]);
            }
        }
    }
}
