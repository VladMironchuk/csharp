using System.Collections.Generic;
using Lab_CSharp.BookClass;

namespace Lab_CSharp.BookListService
{
    public interface IBookStorage
    {
        bool IsEmpty();
        List<Book> GetBooks();
        void AddBooks(List<Book> books);
    }
}
