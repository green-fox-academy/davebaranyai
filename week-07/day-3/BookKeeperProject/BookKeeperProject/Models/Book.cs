using System.ComponentModel.DataAnnotations;

namespace BookKeeperProject.Models
{
    public class Book
    {
        [Key]
        public long ID { get; set; }
        public string Title { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Availability { get; set; }        
    }    
}