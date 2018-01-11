namespace BookKeeperProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public bool Availability { get; set; }
    }

}