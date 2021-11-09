using System.Collections.Generic;

namespace BookClass
{
    /// <summary>BookComparator</summary>
    public class BookAuthorComparator : IComparer<Book>
    {
        /// <summary>Compare</summary>
        /// <returns>int</returns>
        public int Compare(Book book1, Book book2)
        {
            return book1.Author.CompareTo(book2.Author);
        }
    }
}
