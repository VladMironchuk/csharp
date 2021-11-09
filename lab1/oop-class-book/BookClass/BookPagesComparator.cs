using System.Collections.Generic;

namespace BookClass
{
    /// <summary>BookComparator</summary>
    public class BookPagesComparator : IComparer<Book>
    {
        /// <summary>Compare</summary>
        /// <returns>int</returns>
        public int Compare(Book book1, Book book2)
        {
            return book1.Pages.CompareTo(book2.Pages);
        }
    }
}
