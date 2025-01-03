﻿// <auto-generated />
using System;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(BookStore.Data.AppContext))]
    [Migration("20240521081827_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookGenres", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("BookGenres");
                });

            modelBuilder.Entity("BookStore.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Eric Arthur Blair (25 June 1903 – 21 January 1950), known by his pen name George Orwell, was an English novelist, essayist, journalist, and critic. His work is characterized by keen intelligence and wit, a profound awareness of social injustice, an intense opposition to totalitarianism, a passion for clarity in language, and a belief in democratic socialism.",
                            Name = "George Orwell"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Nelle Harper Lee (April 28, 1926 – February 19, 2016) was an American novelist widely known for her Pulitzer Prize-winning novel 'To Kill a Mockingbird', published in 1960. She was renowned for her portrayal of the racial tensions in the American South.",
                            Name = "Harper Lee"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Francis Scott Key Fitzgerald (September 24, 1896 – December 21, 1940) was an American novelist, essayist, and short-story writer. He is best known for his novels depicting the flamboyance and excess of the Jazz Age, notably 'The Great Gatsby'.",
                            Name = "F. Scott Fitzgerald"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Jane Austen (16 December 1775 – 18 July 1817) was an English novelist known primarily for her six major novels, which interpret, critique and comment upon the British landed gentry at the end of the 18th century.",
                            Name = "Jane Austen"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "Herman Melville (August 1, 1819 – September 28, 1891) was an American novelist, short story writer and poet of the American Renaissance period. Among his best-known works are 'Moby-Dick' and 'Billy Budd'.",
                            Name = "Herman Melville"
                        },
                        new
                        {
                            Id = 6,
                            Bio = "Count Lev Nikolayevich Tolstoy (September 9, 1828 – November 20, 1910), usually referred to in English as Leo Tolstoy, was a Russian writer who is regarded as one of the greatest authors of all time. He is best known for his novels 'War and Peace' and 'Anna Karenina'.",
                            Name = "Leo Tolstoy"
                        },
                        new
                        {
                            Id = 7,
                            Bio = "Jerome David Salinger (January 1, 1919 – January 27, 2010) was an American writer best known for his novel 'The Catcher in the Rye'. He also published several short story collections.",
                            Name = "J.D. Salinger"
                        },
                        new
                        {
                            Id = 8,
                            Bio = "John Ronald Reuel Tolkien (3 January 1892 – 2 September 1973) was an English writer, poet, philologist, and academic. He is best known as the author of the high fantasy works 'The Hobbit' and 'The Lord of the Rings'.",
                            Name = "J.R.R. Tolkien"
                        },
                        new
                        {
                            Id = 9,
                            Bio = "Ray Douglas Bradbury (August 22, 1920 – June 5, 2012) was an American author and screenwriter. He worked in a variety of genres, including fantasy, science fiction, horror, and mystery fiction.",
                            Name = "Ray Bradbury"
                        },
                        new
                        {
                            Id = 10,
                            Bio = "Charlotte Brontë (21 April 1816 – 31 March 1855) was an English novelist and poet, the eldest of the three Brontë sisters who survived into adulthood and whose novels became classics of English literature.",
                            Name = "Charlotte Brontë"
                        },
                        new
                        {
                            Id = 11,
                            Bio = "Aldous Leonard Huxley (26 July 1894 – 22 November 1963) was an English writer and philosopher. He is best known for his novels, including 'Brave New World', and a wide-ranging output of essays.",
                            Name = "Aldous Huxley"
                        },
                        new
                        {
                            Id = 12,
                            Bio = "Emily Jane Brontë (30 July 1818 – 19 December 1848) was an English novelist and poet who is best known for her only novel, 'Wuthering Heights', now considered a classic of English literature.",
                            Name = "Emily Brontë"
                        },
                        new
                        {
                            Id = 13,
                            Bio = "Homer is the legendary author of the Iliad and the Odyssey, two epic poems that are the central works of ancient Greek literature. The Iliad is set during the Trojan War, the ten-year siege of the city of Troy by a coalition of Greek states.",
                            Name = "Homer"
                        },
                        new
                        {
                            Id = 14,
                            Bio = "Durante di Alighiero degli Alighieri, commonly known as Dante Alighieri (c. 1265 – 1321), was an Italian poet of the Late Middle Ages. His Divine Comedy is widely considered the greatest literary work composed in the Italian language and a masterpiece of world literature.",
                            Name = "Dante Alighieri"
                        },
                        new
                        {
                            Id = 15,
                            Bio = "Fyodor Mikhailovich Dostoevsky (11 November 1821 – 9 February 1881) was a Russian novelist, philosopher, and short-story writer. His most famous works include the novels 'Crime and Punishment', 'The Idiot', and 'The Brothers Karamazov'.",
                            Name = "Fyodor Dostoevsky"
                        },
                        new
                        {
                            Id = 16,
                            Bio = "Miguel de Cervantes Saavedra (29 September 1547 (assumed) – 22 April 1616 NS) was a Spanish writer who is widely regarded as one of the greatest writers in the Spanish language and one of the world's pre-eminent novelists.",
                            Name = "Miguel de Cervantes"
                        },
                        new
                        {
                            Id = 17,
                            Bio = "Ernest Miller Hemingway (July 21, 1899 – July 2, 1961) was an American novelist, short-story writer, and journalist. His economical and understated style had a strong influence on 20th-century fiction, while his adventurous lifestyle and public image brought him admiration from later generations.",
                            Name = "Ernest Hemingway"
                        },
                        new
                        {
                            Id = 18,
                            Bio = "Mary Wollstonecraft Shelley (30 August 1797 – 1 February 1851) was an English novelist who wrote the Gothic novel 'Frankenstein; or, The Modern Prometheus'. She also edited and promoted the works of her husband, the Romantic poet and philosopher Percy Bysshe Shelley.",
                            Name = "Mary Shelley"
                        },
                        new
                        {
                            Id = 19,
                            Bio = "James Augustine Aloysius Joyce (2 February 1882 – 13 January 1941) was an Irish novelist, short-story writer, poet, teacher, and literary critic. He contributed to the modernist avant-garde movement and is regarded as one of the most influential and",
                            Name = "James Joyce"
                        },
                        new
                        {
                            Id = 20,
                            Bio = "James Augustine Aloysius Joyce (2 February 1882 – 13 January 1941) was an Irish novelist, short-story writer, poet, teacher, and literary critic. He contributed to the modernist avant-garde movement and is regarded as one of the most influential and",
                            Name = "James Joyce"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ISBN")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is_Available")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Pub_Year")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Author_Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author_Id = 1,
                            Description = "Dystopian novel by George Orwell",
                            ISBN = 1234567890L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\1.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1949, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "1984"
                        },
                        new
                        {
                            Id = 2,
                            Author_Id = 2,
                            Description = "Novel by Harper Lee",
                            ISBN = 2345678901L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\2.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 3,
                            Author_Id = 3,
                            Description = "Novel by F. Scott Fitzgerald",
                            ISBN = 3456789012L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\3.JPEG",
                            Is_Available = false,
                            Pub_Year = new DateTime(1925, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = 4,
                            Author_Id = 4,
                            Description = "Novel by Jane Austen",
                            ISBN = 4567890123L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\4.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1813, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            Id = 5,
                            Author_Id = 5,
                            Description = "Novel by Herman Melville",
                            ISBN = 5678901234L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\5.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1851, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Moby-Dick"
                        },
                        new
                        {
                            Id = 6,
                            Author_Id = 6,
                            Description = "Novel by Leo Tolstoy",
                            ISBN = 6789012345L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\6.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "War and Peace"
                        },
                        new
                        {
                            Id = 7,
                            Author_Id = 7,
                            Description = "Novel by J.D. Salinger",
                            ISBN = 7890123456L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\7.JPEG",
                            Is_Available = false,
                            Pub_Year = new DateTime(1951, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            Id = 8,
                            Author_Id = 8,
                            Description = "Novel by J.R.R. Tolkien",
                            ISBN = 8901234567L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\8.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1937, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = 9,
                            Author_Id = 9,
                            Description = "Dystopian novel by Ray Bradbury",
                            ISBN = 9012345678L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\9.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1953, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Fahrenheit 451"
                        },
                        new
                        {
                            Id = 10,
                            Author_Id = 10,
                            Description = "Novel by Charlotte Brontë",
                            ISBN = 1234509876L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\10.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1847, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Jane Eyre"
                        },
                        new
                        {
                            Id = 11,
                            Author_Id = 11,
                            Description = "Dystopian novel by Aldous Huxley",
                            ISBN = 2345610987L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\11.JPEG",
                            Is_Available = false,
                            Pub_Year = new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Brave New World"
                        },
                        new
                        {
                            Id = 12,
                            Author_Id = 12,
                            Description = "Novel by Emily Brontë",
                            ISBN = 3456721098L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\12.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1847, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Wuthering Heights"
                        },
                        new
                        {
                            Id = 13,
                            Author_Id = 1,
                            Description = "Novella by George Orwell",
                            ISBN = 4567832109L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\13.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1945, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Animal Farm"
                        },
                        new
                        {
                            Id = 14,
                            Author_Id = 13,
                            Description = "Epic poem attributed to Homer",
                            ISBN = 5678943210L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\14.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Odyssey"
                        },
                        new
                        {
                            Id = 15,
                            Author_Id = 14,
                            Description = "Epic poem by Dante Alighieri",
                            ISBN = 6789054321L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\15.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Divine Comedy"
                        },
                        new
                        {
                            Id = 16,
                            Author_Id = 15,
                            Description = "Novel by Fyodor Dostoevsky",
                            ISBN = 7890165432L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\16.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1880, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Brothers Karamazov"
                        },
                        new
                        {
                            Id = 17,
                            Author_Id = 16,
                            Description = "Novel by Miguel de Cervantes",
                            ISBN = 8901276543L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\17.JPEG",
                            Is_Available = false,
                            Pub_Year = new DateTime(1605, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Don Quixote"
                        },
                        new
                        {
                            Id = 18,
                            Author_Id = 15,
                            Description = "Novel by Fyodor Dostoevsky",
                            ISBN = 9012387654L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\18.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1866, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Crime and Punishment"
                        },
                        new
                        {
                            Id = 19,
                            Author_Id = 13,
                            Description = "Epic poem attributed to Homer",
                            ISBN = 1234987654L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\19.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Iliad"
                        },
                        new
                        {
                            Id = 20,
                            Author_Id = 8,
                            Description = "Novel by J.R.R. Tolkien",
                            ISBN = 2345098765L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\20.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            Id = 21,
                            Author_Id = 17,
                            Description = "Novel by Ernest Hemingway",
                            ISBN = 3456109876L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\21.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1926, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Sun Also Rises"
                        },
                        new
                        {
                            Id = 22,
                            Author_Id = 18,
                            Description = "Novel by Mary Shelley",
                            ISBN = 4567210987L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\22.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1818, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Frankenstein"
                        },
                        new
                        {
                            Id = 23,
                            Author_Id = 19,
                            Description = "Novel by James Joyce",
                            ISBN = 5678321098L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\23.JPEG",
                            Is_Available = false,
                            Pub_Year = new DateTime(1922, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ulysses"
                        },
                        new
                        {
                            Id = 24,
                            Author_Id = 20,
                            Description = "Collection of stories by Geoffrey Chaucer",
                            ISBN = 6789432109L,
                            ImagePath = "C:\\Users\\youse\\OneDrive\\Desktop\\BookStore\\BookStore\\Images\\24.JPEG",
                            Is_Available = true,
                            Pub_Year = new DateTime(1400, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Canterbury Tales"
                        });
                });

            modelBuilder.Entity("BookStore.Models.BrowsedBooks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Book_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("BrowsedBooks");
                });

            modelBuilder.Entity("BookStore.Models.Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BookStore.Models.Types", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("BookStore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is_Admin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookTypes", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("TypesId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "TypesId");

                    b.HasIndex("TypesId");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("BookGenres", b =>
                {
                    b.HasOne("BookStore.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Genres", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Models.Book", b =>
                {
                    b.HasOne("BookStore.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BookStore.Models.BrowsedBooks", b =>
                {
                    b.HasOne("BookStore.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookTypes", b =>
                {
                    b.HasOne("BookStore.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Models.Types", null)
                        .WithMany()
                        .HasForeignKey("TypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
