using Lab_5_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_2_test
{
    class BookMemoryRepository : ICRUDBookRepository
    {
        private Dictionary<int, Book> books = new Dictionary<int, Book>();
        private int index = 0;
        public Book Add(Book book)
        {
            book.Id = ++index;
            books.Add(book.Id, book);
            return book;
        }

        public void AddAuthorToBook(int authorId, int bookId)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Book> FindAll()
        {
            return books.Values.ToList();
        }

        public Book FindById(int id)
        {
            return books[id];
        }

        public IList<Book> FindPage(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
