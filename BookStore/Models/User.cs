namespace BookStore.Models
{
	public class User
	{
		public int Id { get; set; }
        public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
        public string Bio { get; set; }
        public bool Is_Admin { get; set; }
    }
}
