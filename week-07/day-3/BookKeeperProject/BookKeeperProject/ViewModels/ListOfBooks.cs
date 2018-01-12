using System.Collections.Generic;
using BookKeeperProject.Models;

namespace BookKeeperProject.ViewModels
{
    public class ListOfBooks
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public ListOfBooks()
        {
            AddBooks();
        }

        private void AddBooks()
        {
            Books.Add(new Book()
            {
                Title = "Hamlet",
                AuthorFirstName = "William",
                AuthorLastName = "Shakespeare",
                Year = 1988,
                Type = "Book",
                Location = "Pilis",
                Availability = "Available"
            });
        }
    }    
}
