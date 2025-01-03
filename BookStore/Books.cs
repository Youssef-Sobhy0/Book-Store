using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace BookStore
{
	public partial class Books : Form
	{
		BookStore.Data.AppContext context;
		public Books()
		{
			InitializeComponent();
			context = new BookStore.Data.AppContext();
		}

		private void Books_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
			var picCounter = this.Width / 195;
			this.AutoScroll = true;
			var booksNumber = context.Books.Count();
			var books = context.Books.Include(b => b.Author)
										.OrderBy(x => x.Title)
										.ToList();
			PictureBox[] picBoxes = new PictureBox[booksNumber];
			Button[] btnDelete = new Button[booksNumber];
			Button[] btnEdit = new Button[booksNumber];
			Label[] lblName = new Label[booksNumber];
			Label[] lblAuthor = new Label[booksNumber];
			Label[] lblGenre = new Label[booksNumber];
			Label[] lblType = new Label[booksNumber];
			for (int i = 0; i < booksNumber; i++)
			{
				picBoxes[i] = new PictureBox();
				btnDelete[i] = new Button();
				btnEdit[i] = new Button();
				lblName[i] = new Label();
				lblAuthor[i] = new Label();
				lblGenre[i] = new Label();
				lblType[i] = new Label();
				picBoxes[i].BorderStyle = BorderStyle.FixedSingle;
				lblName[i].Text = $"Title: {books[i].Title}";
				lblAuthor[i].Text = $"Author: {books[i].Author.Name}";
				picBoxes[i].Size = new Size(187, 111);
				btnEdit[i].BringToFront();
				btnEdit[i].Size = new Size(25, 25);
				btnEdit[i].Font = new Font(FontFamily.GenericSerif, 15);
				btnEdit[i].Name = books[i].Id.ToString();
				btnEdit[i].Location = new Point(10 + 195 * (i % picCounter), 15 + 220 * (i / picCounter));
				btnEdit[i].Text = "✎";
				btnEdit[i].ForeColor = Color.Green;
				btnEdit[i].Name = books[i].Id.ToString();
				btnDelete[i].BringToFront();
				btnDelete[i].Size = new Size(25, 25);
				btnDelete[i].Text = "✘";
				btnDelete[i].Font = new Font(FontFamily.GenericSerif, 15);
				btnDelete[i].ForeColor = Color.Red;
				btnDelete[i].Location = new Point(177 + 195 * (i % picCounter), 15 + 220 * (i / picCounter));
				btnDelete[i].Name = books[i].Id.ToString();
				picBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
				picBoxes[i].Image = Image.FromFile(books[i].ImagePath);
				picBoxes[i].TabIndex = 1;
				picBoxes[i].Location = new Point(10 + 195 * (i % picCounter), 20 + 220 * (i / picCounter));
				picBoxes[i].Name =  books[i].Id.ToString();
				lblName[i].Location = new Point(10 + 195 * (i % picCounter), 135 + 220 * (i / picCounter));
				lblAuthor[i].Location = new Point(10 + 195 * (i % picCounter), 155 + 220 * (i / picCounter));
				lblType[i].Location = new Point(10 + 195 * (i % picCounter), 175 + 220 * (i / picCounter));
				lblGenre[i].Location = new Point(10 + 195 * (i % picCounter), 195 + 220 * (i / picCounter));
				btnDelete[i].Click += DeleteBook;
				picBoxes[i].Click += BookDetails;
				btnEdit[i].Click += EditBook;
				this.Controls.Add(btnEdit[i]);
				this.Controls.Add(btnDelete[i]);
				this.Controls.Add(picBoxes[i]);
				this.Controls.Add(lblAuthor[i]);
				this.Controls.Add(lblGenre[i]);
				this.Controls.Add(lblName[i]);
				this.Controls.Add(lblType[i]);

			}
			PictureBox addNew = new();
			addNew.Size = new Size(187, 111);

			addNew.Location = new Point(10 + 195 * ((booksNumber) % picCounter),  220 * ((booksNumber) / picCounter));
			addNew.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(),"Images","Create.PNG"));

			addNew.SizeMode = PictureBoxSizeMode.StretchImage;
			addNew.BorderStyle = BorderStyle.FixedSingle;
			this.Controls.Add(addNew);
			addNew.Click += CreateBook;

		}

		private void CreateBook(object sender, EventArgs e)
		{
			CreateBook newBook = new();
			newBook.Show();
			newBook.Focus();
		}
		
		private void EditBook(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;
			UpdateBook book = new();
			book.Name = clickedButton.Name;
			book.Show();
			book.Focus();
		}
		private void BookDetails(object sender, EventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			BookDetails bookDetails = new();
			bookDetails.Name = pictureBox.Name;
			bookDetails.Show();
			bookDetails.Focus();
		}
		private void DeleteBook(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;
			var m = MessageBox.Show("Are you sure that you want to delete this item.", null, MessageBoxButtons.OKCancel);
			if (m == DialogResult.OK)
			{
				var book = context.Books.FirstOrDefault(x => x.Id == Convert.ToInt32(clickedButton.Name));
				context.Books.Remove(book);
				context.SaveChanges();
				Books books = new();
				books.Show();
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
