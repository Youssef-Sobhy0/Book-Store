using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookStore.Data
{
	public class AppContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-LUQ8MQI\\SQLEXPRESS; Initial Catalog=BookStore;Integrated Security=True;Encrypt=false");
		}


		public DbSet<Book> Books { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<BrowsedBooks> BrowsedBooks { get; set; }
		public DbSet<Genres> Genres { get; set; }
		public DbSet<Types> Types { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Seed Authors
			modelBuilder.Entity<Author>().HasData(
	new Author { Id = 1, Name = "George Orwell", Bio = "Eric Arthur Blair (25 June 1903 – 21 January 1950), known by his pen name George Orwell, was an English novelist, essayist, journalist, and critic. His work is characterized by keen intelligence and wit, a profound awareness of social injustice, an intense opposition to totalitarianism, a passion for clarity in language, and a belief in democratic socialism." },
	new Author { Id = 2, Name = "Harper Lee", Bio = "Nelle Harper Lee (April 28, 1926 – February 19, 2016) was an American novelist widely known for her Pulitzer Prize-winning novel 'To Kill a Mockingbird', published in 1960. She was renowned for her portrayal of the racial tensions in the American South." },
	new Author { Id = 3, Name = "F. Scott Fitzgerald", Bio = "Francis Scott Key Fitzgerald (September 24, 1896 – December 21, 1940) was an American novelist, essayist, and short-story writer. He is best known for his novels depicting the flamboyance and excess of the Jazz Age, notably 'The Great Gatsby'." },
	new Author { Id = 4, Name = "Jane Austen", Bio = "Jane Austen (16 December 1775 – 18 July 1817) was an English novelist known primarily for her six major novels, which interpret, critique and comment upon the British landed gentry at the end of the 18th century." },
	new Author { Id = 5, Name = "Herman Melville", Bio = "Herman Melville (August 1, 1819 – September 28, 1891) was an American novelist, short story writer and poet of the American Renaissance period. Among his best-known works are 'Moby-Dick' and 'Billy Budd'." },
	new Author { Id = 6, Name = "Leo Tolstoy", Bio = "Count Lev Nikolayevich Tolstoy (September 9, 1828 – November 20, 1910), usually referred to in English as Leo Tolstoy, was a Russian writer who is regarded as one of the greatest authors of all time. He is best known for his novels 'War and Peace' and 'Anna Karenina'." },
	new Author { Id = 7, Name = "J.D. Salinger", Bio = "Jerome David Salinger (January 1, 1919 – January 27, 2010) was an American writer best known for his novel 'The Catcher in the Rye'. He also published several short story collections." },
	new Author { Id = 8, Name = "J.R.R. Tolkien", Bio = "John Ronald Reuel Tolkien (3 January 1892 – 2 September 1973) was an English writer, poet, philologist, and academic. He is best known as the author of the high fantasy works 'The Hobbit' and 'The Lord of the Rings'." },
	new Author { Id = 9, Name = "Ray Bradbury", Bio = "Ray Douglas Bradbury (August 22, 1920 – June 5, 2012) was an American author and screenwriter. He worked in a variety of genres, including fantasy, science fiction, horror, and mystery fiction." },
	new Author { Id = 10, Name = "Charlotte Brontë", Bio = "Charlotte Brontë (21 April 1816 – 31 March 1855) was an English novelist and poet, the eldest of the three Brontë sisters who survived into adulthood and whose novels became classics of English literature." },
	new Author { Id = 11, Name = "Aldous Huxley", Bio = "Aldous Leonard Huxley (26 July 1894 – 22 November 1963) was an English writer and philosopher. He is best known for his novels, including 'Brave New World', and a wide-ranging output of essays." },
	new Author { Id = 12, Name = "Emily Brontë", Bio = "Emily Jane Brontë (30 July 1818 – 19 December 1848) was an English novelist and poet who is best known for her only novel, 'Wuthering Heights', now considered a classic of English literature." },
	new Author { Id = 13, Name = "Homer", Bio = "Homer is the legendary author of the Iliad and the Odyssey, two epic poems that are the central works of ancient Greek literature. The Iliad is set during the Trojan War, the ten-year siege of the city of Troy by a coalition of Greek states." },
	new Author { Id = 14, Name = "Dante Alighieri", Bio = "Durante di Alighiero degli Alighieri, commonly known as Dante Alighieri (c. 1265 – 1321), was an Italian poet of the Late Middle Ages. His Divine Comedy is widely considered the greatest literary work composed in the Italian language and a masterpiece of world literature." },
	new Author { Id = 15, Name = "Fyodor Dostoevsky", Bio = "Fyodor Mikhailovich Dostoevsky (11 November 1821 – 9 February 1881) was a Russian novelist, philosopher, and short-story writer. His most famous works include the novels 'Crime and Punishment', 'The Idiot', and 'The Brothers Karamazov'." },
	new Author { Id = 16, Name = "Miguel de Cervantes", Bio = "Miguel de Cervantes Saavedra (29 September 1547 (assumed) – 22 April 1616 NS) was a Spanish writer who is widely regarded as one of the greatest writers in the Spanish language and one of the world's pre-eminent novelists." },
	new Author { Id = 17, Name = "Ernest Hemingway", Bio = "Ernest Miller Hemingway (July 21, 1899 – July 2, 1961) was an American novelist, short-story writer, and journalist. His economical and understated style had a strong influence on 20th-century fiction, while his adventurous lifestyle and public image brought him admiration from later generations." },
	new Author { Id = 18, Name = "Mary Shelley", Bio = "Mary Wollstonecraft Shelley (30 August 1797 – 1 February 1851) was an English novelist who wrote the Gothic novel 'Frankenstein; or, The Modern Prometheus'. She also edited and promoted the works of her husband, the Romantic poet and philosopher Percy Bysshe Shelley." },
	new Author { Id = 19, Name = "James Joyce", Bio = "James Augustine Aloysius Joyce (2 February 1882 – 13 January 1941) was an Irish novelist, short-story writer, poet, teacher, and literary critic. He contributed to the modernist avant-garde movement and is regarded as one of the most influential and" },
	new Author { Id = 20, Name = "James Joyce", Bio = "James Augustine Aloysius Joyce (2 February 1882 – 13 January 1941) was an Irish novelist, short-story writer, poet, teacher, and literary critic. He contributed to the modernist avant-garde movement and is regarded as one of the most influential and" });

			// Seed Books
			var currentDirectory = Directory.GetCurrentDirectory();

			// Seed Books with ImagePath
			modelBuilder.Entity<Book>().HasData(
				new Book { Id = 1, Title = "1984", ISBN = 1234567890, Pub_Year = new DateTime(1949, 1, 1), Is_Available = true, Description = "Dystopian novel by George Orwell", Author_Id = 1, ImagePath = Path.Combine(currentDirectory, "Images", "1.JPEG") },
				new Book { Id = 2, Title = "To Kill a Mockingbird", ISBN = 2345678901, Pub_Year = new DateTime(1960, 1, 1), Is_Available = true, Description = "Novel by Harper Lee", Author_Id = 2, ImagePath = Path.Combine(currentDirectory, "Images", "2.JPEG") },
				new Book { Id = 3, Title = "The Great Gatsby", ISBN = 3456789012, Pub_Year = new DateTime(1925, 1, 1), Is_Available = false, Description = "Novel by F. Scott Fitzgerald", Author_Id = 3, ImagePath = Path.Combine(currentDirectory, "Images", "3.JPEG") },
				new Book { Id = 4, Title = "Pride and Prejudice", ISBN = 4567890123, Pub_Year = new DateTime(1813, 1, 1), Is_Available = true, Description = "Novel by Jane Austen", Author_Id = 4, ImagePath = Path.Combine(currentDirectory, "Images", "4.JPEG") },
				new Book { Id = 5, Title = "Moby-Dick", ISBN = 5678901234, Pub_Year = new DateTime(1851, 1, 1), Is_Available = true, Description = "Novel by Herman Melville", Author_Id = 5, ImagePath = Path.Combine(currentDirectory, "Images", "5.JPEG") },
				new Book { Id = 6, Title = "War and Peace", ISBN = 6789012345, Pub_Year = new DateTime(1869, 1, 1), Is_Available = true, Description = "Novel by Leo Tolstoy", Author_Id = 6, ImagePath = Path.Combine(currentDirectory, "Images", "6.JPEG") },
				new Book { Id = 7, Title = "The Catcher in the Rye", ISBN = 7890123456, Pub_Year = new DateTime(1951, 1, 1), Is_Available = false, Description = "Novel by J.D. Salinger", Author_Id = 7, ImagePath = Path.Combine(currentDirectory, "Images", "7.JPEG") },
				new Book { Id = 8, Title = "The Hobbit", ISBN = 8901234567, Pub_Year = new DateTime(1937, 1, 1), Is_Available = true, Description = "Novel by J.R.R. Tolkien", Author_Id = 8, ImagePath = Path.Combine(currentDirectory, "Images", "8.JPEG") },
				new Book { Id = 9, Title = "Fahrenheit 451", ISBN = 9012345678, Pub_Year = new DateTime(1953, 1, 1), Is_Available = true, Description = "Dystopian novel by Ray Bradbury", Author_Id = 9, ImagePath = Path.Combine(currentDirectory, "Images", "9.JPEG") },
				new Book { Id = 10, Title = "Jane Eyre", ISBN = 1234509876, Pub_Year = new DateTime(1847, 1, 1), Is_Available = true, Description = "Novel by Charlotte Brontë", Author_Id = 10, ImagePath = Path.Combine(currentDirectory, "Images", "10.JPEG") },
				new Book { Id = 11, Title = "Brave New World", ISBN = 2345610987, Pub_Year = new DateTime(1932, 1, 1), Is_Available = false, Description = "Dystopian novel by Aldous Huxley", Author_Id = 11, ImagePath = Path.Combine(currentDirectory, "Images", "11.JPEG") },
				new Book { Id = 12, Title = "Wuthering Heights", ISBN = 3456721098, Pub_Year = new DateTime(1847, 1, 1), Is_Available = true, Description = "Novel by Emily Brontë", Author_Id = 12, ImagePath = Path.Combine(currentDirectory, "Images", "12.JPEG") },
				new Book { Id = 13, Title = "Animal Farm", ISBN = 4567832109, Pub_Year = new DateTime(1945, 1, 1), Is_Available = true, Description = "Novella by George Orwell", Author_Id = 1, ImagePath = Path.Combine(currentDirectory, "Images", "13.JPEG") },
				new Book { Id = 14, Title = "The Odyssey", ISBN = 5678943210, Pub_Year = new DateTime(1900, 1, 1), Is_Available = true, Description = "Epic poem attributed to Homer", Author_Id = 13, ImagePath = Path.Combine(currentDirectory, "Images", "14.JPEG") },
				new Book { Id = 15, Title = "The Divine Comedy", ISBN = 6789054321, Pub_Year = new DateTime(1900, 1, 1), Is_Available = true, Description = "Epic poem by Dante Alighieri", Author_Id = 14, ImagePath = Path.Combine(currentDirectory, "Images", "15.JPEG") },
				new Book { Id = 16, Title = "The Brothers Karamazov", ISBN = 7890165432, Pub_Year = new DateTime(1880, 1, 1), Is_Available = true, Description = "Novel by Fyodor Dostoevsky", Author_Id = 15, ImagePath = Path.Combine(currentDirectory, "Images", "16.JPEG") },
				new Book { Id = 17, Title = "Don Quixote", ISBN = 8901276543, Pub_Year = new DateTime(1605, 1, 1), Is_Available = false, Description = "Novel by Miguel de Cervantes", Author_Id = 16, ImagePath = Path.Combine(currentDirectory, "Images", "17.JPEG") },
				new Book { Id = 18, Title = "Crime and Punishment", ISBN = 9012387654, Pub_Year = new DateTime(1866, 1, 1), Is_Available = true, Description = "Novel by Fyodor Dostoevsky", Author_Id = 15, ImagePath = Path.Combine(currentDirectory, "Images", "18.JPEG") },
				new Book { Id = 19, Title = "The Iliad", ISBN = 1234987654, Pub_Year = new DateTime(1954, 1, 1), Is_Available = true, Description = "Epic poem attributed to Homer", Author_Id = 13, ImagePath = Path.Combine(currentDirectory, "Images", "19.JPEG") },
				new Book { Id = 20, Title = "The Lord of the Rings", ISBN = 2345098765, Pub_Year = new DateTime(1954, 1, 1), Is_Available = true, Description = "Novel by J.R.R. Tolkien", Author_Id = 8, ImagePath = Path.Combine(currentDirectory, "Images", "20.JPEG") },
				new Book { Id = 21, Title = "The Sun Also Rises", ISBN = 3456109876, Pub_Year = new DateTime(1926, 1, 1), Is_Available = true, Description = "Novel by Ernest Hemingway", Author_Id = 17, ImagePath = Path.Combine(currentDirectory, "Images", "21.JPEG") },
				new Book { Id = 22, Title = "Frankenstein", ISBN = 4567210987, Pub_Year = new DateTime(1818, 1, 1), Is_Available = true, Description = "Novel by Mary Shelley", Author_Id = 18, ImagePath = Path.Combine(currentDirectory, "Images", "22.JPEG") },
				new Book { Id = 23, Title = "Ulysses", ISBN = 5678321098, Pub_Year = new DateTime(1922, 1, 1), Is_Available = false, Description = "Novel by James Joyce", Author_Id = 19, ImagePath = Path.Combine(currentDirectory, "Images", "23.JPEG") },
				new Book { Id = 24, Title = "The Canterbury Tales", ISBN = 6789432109, Pub_Year = new DateTime(1400, 1, 1), Is_Available = true, Description = "Collection of stories by Geoffrey Chaucer", Author_Id = 20, ImagePath = Path.Combine(currentDirectory, "Images", "24.JPEG") }
			);
		}
	}

	
}
