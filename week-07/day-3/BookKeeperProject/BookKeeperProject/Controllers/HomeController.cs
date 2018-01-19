using BookKeeperProject.Models;
using BookKeeperProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BookKeeperProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private BookKeeperContext BooksDatabase;

        public HomeController(BookKeeperContext booksDatabase)
        {
            BooksDatabase = booksDatabase;
        }

        [HttpGet("home")]
        public IActionResult Index()
        {
            var book = BooksDatabase.Books.Where(c => c.ID < 10000);

            return View(book);
        }

        //[HttpPost("add")]
        //public IActionResult AddBook(Book book)
        //{
        //    LoBooks.Books.Add(book);
        //    return RedirectToAction("index");
        //}
    }
}
