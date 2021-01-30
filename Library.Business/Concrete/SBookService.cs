using Library.Business.Abstract;
using Library.DataAccess.Abstract;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Concrete
{
    public class SBookService : IBookService
    {
        private IBookRepository _bookRepository;

        public SBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book Create_Book(Book book)
        {
            return _bookRepository.Create_Book(book);
        }

        public void Delete_Book(int id)
        {
            _bookRepository.Delete_Book(id);
        }

        public List<Book> Get_All_Books()
        {
            return _bookRepository.Get_All_Books();
        }

        public Book Get_Book_By_Id(int id)
        {
            return _bookRepository.Get_Book_By_Id(id);
        }

        public Book Update_Book(Book book)
        {
            return _bookRepository.Update_Book(book);
        }
    }
}
