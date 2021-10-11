using System;
using System.Collections.Generic;

namespace BookClass
{
    /// <summary>
    /// eofewop
    /// </summary>
    public class BookComp : IComparer<Book>
    {
        /// <summary>
        /// eofewop
        /// </summary>
        /// <returns></returns>
        public int Compare(Book book1, Book book2)
        {
            if (book1 != null && book2 != null &&
                string.Compare(book1.Author, book2.Author, StringComparison.Ordinal) != 0)
            {
                return string.Compare(book1.Author, book2.Author, StringComparison.Ordinal);
            }

            if (book2 != null && book1 != null &&
                string.Compare(book1.Title, book2.Title, StringComparison.Ordinal) != 0)
            {
                return string.Compare(book1.Title, book2.Title, StringComparison.Ordinal);
            }

            if (book2 != null && book1 != null && book1.Price.CompareTo(book2.Price) != 0)
            {
                return book1.Price.CompareTo(book2.Price);
            }

            return 0;
        }
    }
}
