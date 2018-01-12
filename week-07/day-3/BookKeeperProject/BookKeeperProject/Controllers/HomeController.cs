using BookKeeperProject.Models;
using BookKeeperProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookKeeperProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public static ListOfBooks LoBooks = new ListOfBooks();

        [HttpGet("home")]
        public IActionResult Index()
        {
            return View(LoBooks);
        }

        [HttpPost("add")]
        public IActionResult AddBook(Book book)
        {
            LoBooks.Books.Add(book);
            return RedirectToAction("index");
        }
    }
}
