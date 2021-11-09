using System;
using System.Collections.Generic;
using BookClass;

namespace BookListService
{
    public class BookListService
    {
        private Dictionary<int, Book> BookList = new Dictionary<int, Book>();

        public Dictionary<int, Book> GetBookList()
        {
            return BookList;
        }

        public bool isEmpty()
        {
            if (BookList.Count == 0)
            {
                return true;
            }
            return false;
        }

        /// <exception cref="CollectionException">Throw when author or title or publisher is null.</exception>
        public void Add(Book book)
        {
            if (BookList.Count == 0)
            {
                BookList.Add(0, book);
            } 
            else if (!BookList.ContainsValue(book))
            {
                BookList.Add(BookList.Count, book);
            } 
            else
            {
                throw new Exception("This book has already been added.");
            }
        }

        public void Remove(Book book)
        {
            if (BookList.Count == 0)
            {
                return;
            } 
            else if (BookList.ContainsValue(book))
            {
                int key = -1;
                
                foreach (var pair in BookList)
                {
                    if (pair.Value == book)
                    {
                        key = pair.Key;
                        break;
                    }
                }

                BookList.Remove(key);
                return;
            }
            
            throw new Exception("There is no such book.");
        }
        public List<Book> FindByAuthor(string Author)
        {
            List<Book> books = new List<Book>();

            foreach (var pair in BookList)
            {
                if (pair.Value.Author.Equals(Author))
                {
                    books.Add(pair.Value);
                }
            }

            return books;
        }

        public List<Book> FindByTitle(string Title)
        {
            List<Book> books = new List<Book>();

            foreach (var pair in BookList)
            {
                if (pair.Value.Title.Equals(Title))
                {
                    books.Add(pair.Value);
                }
            }

            return books;
        }

        public List<Book> FindByPublisher(string Publisher)
        {
            List<Book> books = new List<Book>();

            foreach (var pair in BookList)
            {
                if (pair.Value.Publisher.Equals(Publisher))
                {
                    books.Add(pair.Value);
                }
            }

            return books;
        }
        public List<Book> GetByAuthor()
        {
            List<Book> books = new List<Book>();

            foreach (var pair in BookList)
            {
                books.Add(pair.Value);   
            }

            books.Sort(new BookAuthorComparator());
            return books;
        }

        public List<Book> GetByPages()
        {
            List<Book> books = new List<Book>();

            foreach (var pair in BookList)
            {
                books.Add(pair.Value);
            }

            books.Sort(new BookPagesComparator());
            return books;
        }

        public List<Book> GetByPrice()
        {
            List<Book> books = new List<Book>();

            foreach (var pair in BookList)
            {
                books.Add(pair.Value);
            }

            books.Sort(new BookPriceComparator());
            return books;
        }

        public void Load(BookStorage bookStorage)
        {
            if (BookList.Count == 0)
            {
                List<Book> books = bookStorage.GetBooks();

                for (int i = 0; i < books.Count; i++)
                {
                    BookList.Add(i, books[i]);
                }
            }
            else
            {
                List<Book> books = bookStorage.GetBooks();
                int count = BookList.Count;

                for (int i = 0; i < books.Count; i++)
                {
                    BookList.Add(i + count, books[i]);
                }
            }
        }
        public void Save(BookStorage bookStorage) 
        {
            List<Book> books = new List<Book>();

            foreach (var pair in BookList)
            {
                books.Add(pair.Value);
            }

            bookStorage.AddBooks(books);
        }
    }
}
