using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
	public partial class UpdateBook : Form
	{
		BookStore.Data.AppContext context;

		public UpdateBook()
		{
			InitializeComponent();
			context = new BookStore.Data.AppContext();

		}

		private void UpdateBook_Load(object sender, EventArgs e)
		{
			var book = context.Books
							.Include(x => x.Author)
							.FirstOrDefault(b => b.Id == Convert.ToInt32(this.Name));
			var authorsIds = context.Authors.Select(x => new { Text = x.Name, Value = x.Id.ToString() }).ToList();


			this.Controls["txtTitle"].Text = book.Title;
			this.Controls["txtDescription"].Text = book.Description;
			ComboBox comboBox = (ComboBox)this.Controls["comAuthor"];
			comboBox.DataSource = authorsIds;
			comboBox.DisplayMember = "Text";
			comboBox.ValueMember = "Value";
			comboBox.SelectedValue = book.Author_Id.ToString();

			PictureBox pictureBox = (PictureBox)this.Controls["picBook"];
			pictureBox.Image = Image.FromFile(book.ImagePath);

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var title = this.Controls["txtTitle"].Text;
			var Description = this.Controls["txtDescription"].Text;
			var comBox = (ComboBox)this.Controls["comAuthor"];
			var author_id = comBox.SelectedValue.ToString();

			var book = context.Books
							.Include(x => x.Author)
							.FirstOrDefault(b => b.Id == Convert.ToInt32(this.Name));

			book.Title = title;
			book.Description = Description;
			book.Author_Id = Convert.ToInt32(author_id);

			context.Books.Update(book);
			context.SaveChanges();
			this.Close();
			Books books = new Books();
			books.Show();

		}
	}
}
