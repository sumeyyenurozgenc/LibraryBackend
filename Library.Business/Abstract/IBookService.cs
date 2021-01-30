using Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Abstract
{
    public interface IBookService

    {
        List<Book> Get_All_Books();
        Book Get_Book_By_Id(int id);
        Book Create_Book(Book book);
        Book Update_Book(Book book);
        void Delete_Book(int id);
    }
}
