using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pub_Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Is_Available = table.Column<bool>(type: "bit", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_Author_Id",
                        column: x => x.Author_Id,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    GenresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => new { x.BooksId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookTypes",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    TypesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTypes", x => new { x.BooksId, x.TypesId });
                    table.ForeignKey(
                        name: "FK_BookTypes_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookTypes_Types_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BrowsedBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book_Id = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrowsedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrowsedBooks_Books_Book_Id",
                        column: x => x.Book_Id,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrowsedBooks_Users_User_Id",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, "Eric Arthur Blair (25 June 1903 – 21 January 1950), known by his pen name George Orwell, was an English novelist, essayist, journalist, and critic. His work is characterized by keen intelligence and wit, a profound awareness of social injustice, an intense opposition to totalitarianism, a passion for clarity in language, and a belief in democratic socialism.", "George Orwell" },
                    { 2, "Nelle Harper Lee (April 28, 1926 – February 19, 2016) was an American novelist widely known for her Pulitzer Prize-winning novel 'To Kill a Mockingbird', published in 1960. She was renowned for her portrayal of the racial tensions in the American South.", "Harper Lee" },
                    { 3, "Francis Scott Key Fitzgerald (September 24, 1896 – December 21, 1940) was an American novelist, essayist, and short-story writer. He is best known for his novels depicting the flamboyance and excess of the Jazz Age, notably 'The Great Gatsby'.", "F. Scott Fitzgerald" },
                    { 4, "Jane Austen (16 December 1775 – 18 July 1817) was an English novelist known primarily for her six major novels, which interpret, critique and comment upon the British landed gentry at the end of the 18th century.", "Jane Austen" },
                    { 5, "Herman Melville (August 1, 1819 – September 28, 1891) was an American novelist, short story writer and poet of the American Renaissance period. Among his best-known works are 'Moby-Dick' and 'Billy Budd'.", "Herman Melville" },
                    { 6, "Count Lev Nikolayevich Tolstoy (September 9, 1828 – November 20, 1910), usually referred to in English as Leo Tolstoy, was a Russian writer who is regarded as one of the greatest authors of all time. He is best known for his novels 'War and Peace' and 'Anna Karenina'.", "Leo Tolstoy" },
                    { 7, "Jerome David Salinger (January 1, 1919 – January 27, 2010) was an American writer best known for his novel 'The Catcher in the Rye'. He also published several short story collections.", "J.D. Salinger" },
                    { 8, "John Ronald Reuel Tolkien (3 January 1892 – 2 September 1973) was an English writer, poet, philologist, and academic. He is best known as the author of the high fantasy works 'The Hobbit' and 'The Lord of the Rings'.", "J.R.R. Tolkien" },
                    { 9, "Ray Douglas Bradbury (August 22, 1920 – June 5, 2012) was an American author and screenwriter. He worked in a variety of genres, including fantasy, science fiction, horror, and mystery fiction.", "Ray Bradbury" },
                    { 10, "Charlotte Brontë (21 April 1816 – 31 March 1855) was an English novelist and poet, the eldest of the three Brontë sisters who survived into adulthood and whose novels became classics of English literature.", "Charlotte Brontë" },
                    { 11, "Aldous Leonard Huxley (26 July 1894 – 22 November 1963) was an English writer and philosopher. He is best known for his novels, including 'Brave New World', and a wide-ranging output of essays.", "Aldous Huxley" },
                    { 12, "Emily Jane Brontë (30 July 1818 – 19 December 1848) was an English novelist and poet who is best known for her only novel, 'Wuthering Heights', now considered a classic of English literature.", "Emily Brontë" },
                    { 13, "Homer is the legendary author of the Iliad and the Odyssey, two epic poems that are the central works of ancient Greek literature. The Iliad is set during the Trojan War, the ten-year siege of the city of Troy by a coalition of Greek states.", "Homer" },
                    { 14, "Durante di Alighiero degli Alighieri, commonly known as Dante Alighieri (c. 1265 – 1321), was an Italian poet of the Late Middle Ages. His Divine Comedy is widely considered the greatest literary work composed in the Italian language and a masterpiece of world literature.", "Dante Alighieri" },
                    { 15, "Fyodor Mikhailovich Dostoevsky (11 November 1821 – 9 February 1881) was a Russian novelist, philosopher, and short-story writer. His most famous works include the novels 'Crime and Punishment', 'The Idiot', and 'The Brothers Karamazov'.", "Fyodor Dostoevsky" },
                    { 16, "Miguel de Cervantes Saavedra (29 September 1547 (assumed) – 22 April 1616 NS) was a Spanish writer who is widely regarded as one of the greatest writers in the Spanish language and one of the world's pre-eminent novelists.", "Miguel de Cervantes" },
                    { 17, "Ernest Miller Hemingway (July 21, 1899 – July 2, 1961) was an American novelist, short-story writer, and journalist. His economical and understated style had a strong influence on 20th-century fiction, while his adventurous lifestyle and public image brought him admiration from later generations.", "Ernest Hemingway" },
                    { 18, "Mary Wollstonecraft Shelley (30 August 1797 – 1 February 1851) was an English novelist who wrote the Gothic novel 'Frankenstein; or, The Modern Prometheus'. She also edited and promoted the works of her husband, the Romantic poet and philosopher Percy Bysshe Shelley.", "Mary Shelley" },
                    { 19, "James Augustine Aloysius Joyce (2 February 1882 – 13 January 1941) was an Irish novelist, short-story writer, poet, teacher, and literary critic. He contributed to the modernist avant-garde movement and is regarded as one of the most influential and", "James Joyce" },
                    { 20, "James Augustine Aloysius Joyce (2 February 1882 – 13 January 1941) was an Irish novelist, short-story writer, poet, teacher, and literary critic. He contributed to the modernist avant-garde movement and is regarded as one of the most influential and", "James Joyce" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author_Id", "Description", "ISBN", "ImagePath", "Is_Available", "Pub_Year", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Dystopian novel by George Orwell", 1234567890L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\1.JPEG", true, new DateTime(1949, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984" },
                    { 2, 2, "Novel by Harper Lee", 2345678901L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\2.JPEG", true, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To Kill a Mockingbird" },
                    { 3, 3, "Novel by F. Scott Fitzgerald", 3456789012L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\3.JPEG", false, new DateTime(1925, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Gatsby" },
                    { 4, 4, "Novel by Jane Austen", 4567890123L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\4.JPEG", true, new DateTime(1813, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pride and Prejudice" },
                    { 5, 5, "Novel by Herman Melville", 5678901234L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\5.JPEG", true, new DateTime(1851, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moby-Dick" },
                    { 6, 6, "Novel by Leo Tolstoy", 6789012345L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\6.JPEG", true, new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "War and Peace" },
                    { 7, 7, "Novel by J.D. Salinger", 7890123456L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\7.JPEG", false, new DateTime(1951, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Catcher in the Rye" },
                    { 8, 8, "Novel by J.R.R. Tolkien", 8901234567L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\8.JPEG", true, new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit" },
                    { 9, 9, "Dystopian novel by Ray Bradbury", 9012345678L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\9.JPEG", true, new DateTime(1953, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fahrenheit 451" },
                    { 10, 10, "Novel by Charlotte Brontë", 1234509876L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\10.JPEG", true, new DateTime(1847, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Eyre" },
                    { 11, 11, "Dystopian novel by Aldous Huxley", 2345610987L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\11.JPEG", false, new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brave New World" },
                    { 12, 12, "Novel by Emily Brontë", 3456721098L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\12.JPEG", true, new DateTime(1847, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wuthering Heights" },
                    { 13, 1, "Novella by George Orwell", 4567832109L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\13.JPEG", true, new DateTime(1945, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animal Farm" },
                    { 14, 13, "Epic poem attributed to Homer", 5678943210L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\14.JPEG", true, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Odyssey" },
                    { 15, 14, "Epic poem by Dante Alighieri", 6789054321L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\15.JPEG", true, new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Divine Comedy" },
                    { 16, 15, "Novel by Fyodor Dostoevsky", 7890165432L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\16.JPEG", true, new DateTime(1880, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Brothers Karamazov" },
                    { 17, 16, "Novel by Miguel de Cervantes", 8901276543L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\17.JPEG", false, new DateTime(1605, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don Quixote" },
                    { 18, 15, "Novel by Fyodor Dostoevsky", 9012387654L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\18.JPEG", true, new DateTime(1866, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crime and Punishment" },
                    { 19, 13, "Epic poem attributed to Homer", 1234987654L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\19.JPEG", true, new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Iliad" },
                    { 20, 8, "Novel by J.R.R. Tolkien", 2345098765L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\20.JPEG", true, new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings" },
                    { 21, 17, "Novel by Ernest Hemingway", 3456109876L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\21.JPEG", true, new DateTime(1926, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sun Also Rises" },
                    { 22, 18, "Novel by Mary Shelley", 4567210987L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\22.JPEG", true, new DateTime(1818, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frankenstein" },
                    { 23, 19, "Novel by James Joyce", 5678321098L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\23.JPEG", false, new DateTime(1922, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulysses" },
                    { 24, 20, "Collection of stories by Geoffrey Chaucer", 6789432109L, "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\24.JPEG", true, new DateTime(1400, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Canterbury Tales" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenresId",
                table: "BookGenres",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Author_Id",
                table: "Books",
                column: "Author_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookTypes_TypesId",
                table: "BookTypes",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_BrowsedBooks_Book_Id",
                table: "BrowsedBooks",
                column: "Book_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BrowsedBooks_User_Id",
                table: "BrowsedBooks",
                column: "User_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "BookTypes");

            migrationBuilder.DropTable(
                name: "BrowsedBooks");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
