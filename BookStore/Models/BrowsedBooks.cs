using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
	public class BrowsedBooks
	{
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int Book_Id { get; set; }
        public Book Book { get; set; }

        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }
    }
}
