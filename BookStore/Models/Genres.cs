namespace BookStore.Models
{
	public class Genres
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
