using System;
using System.Collections.Generic;

namespace Lab_CSharp.BookClass
{
    /// <summary>Book Author Comparator</summary>
    public class BookAuthorComparator : IComparer<Book>
    {
        /// <summary>Compare two books by author</summary>
        /// <returns>int</returns>
        public int Compare(Book firstBook, Book secondBook)
        {
            if (firstBook == null && secondBook == null)
            {
                return 0;
            }

            if (firstBook == null)
            {
                return -1;
            }

            if (secondBook == null)
            {
                return 1;
            }

            return String.Compare(firstBook.Author, secondBook.Author, StringComparison.Ordinal);
        }
    }
}
