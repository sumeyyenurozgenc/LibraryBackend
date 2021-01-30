using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Abstract
{
    public interface IBookRepository
    {
        List<Book> Get_All_Books();
        Book Get_Book_By_Id(int id);
        Book Create_Book(Book book);
        Book Update_Book(Book book);
        void Delete_Book(int id);
    }
}
