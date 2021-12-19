using System.Collections.Generic;

namespace Lab_CSharp.BookClass
{
    /// <summary>Book Pages Comparator</summary>
    public class BookPagesComparator : IComparer<Book>
    {
        /// <summary>Compare two books by pages</summary>
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

            return firstBook.Pages.CompareTo(secondBook.Pages);
        }
    }
}
