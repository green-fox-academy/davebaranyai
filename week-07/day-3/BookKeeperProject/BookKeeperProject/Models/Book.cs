namespace BookKeeperProject.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Availability { get; set; }

        //public Book(string title, string authorFirstName, string authorLastName, int year, string type, string location, string availability)
        //{
        //    Title = title;
        //    AuthorFirstName = authorFirstName;
        //    AuthorLastName = authorLastName;
        //    Year = year;
        //    Type = type;
        //    Location = location;
        //    Availability = availability;
        //}
    }    
}