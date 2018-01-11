using System.Collections.Generic;

namespace BookKeeperProject.Models
{
    public class ListOfBooks
    {
        public IList<Book> Books { get; set; } = new List<Book>();
    }
}
