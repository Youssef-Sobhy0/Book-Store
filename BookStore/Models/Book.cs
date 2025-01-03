using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
	public class Book
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public long ISBN { get; set; }
        public string Description { get; set; }
        public DateTime Pub_Year { get; set; }
        public bool Is_Available { get; set; }
        public string ImagePath { get; set; }

        [ForeignKey("Author")]
        public int Author_Id { get; set; }
        public Author Author { get; set; }

        public List<Genres> Genres { get; set; }
        public List<Types> Types { get; set; }
    }
}
