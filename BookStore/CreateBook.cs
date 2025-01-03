using BookStore.Models;
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
    public partial class CreateBook : Form
    {
        string filePath;
        BookStore.Data.AppContext context;

        public CreateBook()
        {
            InitializeComponent();
            context = new BookStore.Data.AppContext();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    PictureBox pictureBox = (PictureBox)this.Controls["picBook"];
                    pictureBox.Image = Image.FromFile(filePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Refresh();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var title = this.Controls["txtTitle"].Text;
            var Description = this.Controls["txtDescription"].Text;
            var comBox = (ComboBox)this.Controls["comAuthor"];
            var author_id = comBox.SelectedValue.ToString();
            var extension = Path.GetExtension(filePath);
            var destFile = Path.Combine(Directory.GetCurrentDirectory(), "Images", title + extension);
            File.Copy(filePath, destFile, true);
            Book book = new Book();
            book.Title = title;
            book.Description = Description;
            book.Author_Id = Convert.ToInt32(author_id);
            book.ImagePath = destFile;
            context.Books.Add(book);
            var res = context.SaveChanges();
            this.Close();
            Books books = new();
            books.Show();

        }

        private void CreateBook_Load(object sender, EventArgs e)
        {
            var authorsIds = context.Authors.Select(x => new { Text = x.Name, Value = x.Id.ToString() }).ToList();
            var comBox = (ComboBox)this.Controls["comAuthor"];

            comBox.DataSource = authorsIds;
            comBox.DisplayMember = "Text";
            comBox.ValueMember = "Value";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
