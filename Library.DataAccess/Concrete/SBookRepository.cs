using Library.DataAccess.Abstract;
using Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.DataAccess.Concrete
{
    public class SBookRepository : IBookRepository
    {
        public Book Create_Book(Book book)
        {
            using (var bookDbContext = new LibraryDBContext())
            {
                bookDbContext.Books.Add(book);
                bookDbContext.SaveChanges();
                return book;
            }
        }

        public void Delete_Book(int id)
        {
            using (var bookDbContext = new LibraryDBContext())
            {
                var getBookById = Get_Book_By_Id(id);
                bookDbContext.Books.Remove(getBookById);
                bookDbContext.SaveChanges();
            }
        }

        public List<Book> Get_All_Books()
        {
            using (var bookDbContext = new LibraryDBContext())
            {
                var getBooks = bookDbContext.Books.FromSqlRaw(@"Select Books.*, Categories.CategoryName from Books 
                                Inner Join Categories on Books.CategoryId = Categories.Id; ").ToList();
                return getBooks;
            }
        }

        public Book Get_Book_By_Id(int id)
        {
            using (var bookDbContext = new LibraryDBContext())
            {
                return bookDbContext.Books.Find(id);
            }
        }

        public Book Update_Book(Book book)
        {
            using (var bookDbContext = new LibraryDBContext())
            {
                bookDbContext.Books.Update(book);
                bookDbContext.SaveChanges();
                return book;
            }
        }
    }
}
