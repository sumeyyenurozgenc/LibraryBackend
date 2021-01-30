using Library.Business.Abstract;
using Library.Core.CustomEntity.Request;
using Library.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        /// <summary>
        /// Tüm kitapları getirir.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getallbooks")]
        public IActionResult Get_All_Books()
        {
            var allBooks = _bookService.Get_All_Books();
            return Ok(allBooks);
        }

        /// <summary>
        /// Kitap ekler.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("insertbook")]
        public IActionResult Insert_Book([FromBody] InsertBookRequest request)
        {
            Book book = new Book()
            {
                CategoryId = request.CategoryId,
                BookName = request.BookName,
                Author = request.Author,
                Price = request.Price,
            };

            if(_bookService.Create_Book(book) == null)
            {
                return NoContent();
            }

            return Ok(book);
        }

        /// <summary>
        /// Kitap Güncellenir.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("updatebook")]
        public IActionResult Update_Book([FromBody] UpdateBookRequest request)
        {
            if (_bookService.Get_Book_By_Id(request.Id) == null)
            {
                return NoContent();
            }

            Book book = new Book()
            {
                Id = request.Id,
                CategoryId = request.CategoryId,
                BookName = request.BookName,
                Author = request.Author,
                Price = request.Price,
            };

            if (_bookService.Update_Book(book) == null)
            {
                return NoContent();
            }

            return Ok(book);
        }

        /// <summary>
        /// Id'ye göre kitabı siler.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("deletebook/{id:int}")]
        public IActionResult Delete_Book_By_Id(int id)
        {
            if (_bookService.Get_Book_By_Id(id) == null)
            {
                return NoContent();
            }

            _bookService.Delete_Book(id);

            return Ok();
        }
    }
}
