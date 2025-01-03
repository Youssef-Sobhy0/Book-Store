using Microsoft.EntityFrameworkCore;

namespace BookStore
{
    public partial class BookDetails : Form
    {
        BookStore.Data.AppContext context;
        public BookDetails()
        {
            InitializeComponent();
            context = new BookStore.Data.AppContext();

        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            var book = context.Books
                        .Include(b => b.Author)
                        .Include(b => b.Genres)
                        .Include(b => b.Types)
                        .FirstOrDefault(x => x.Id == Convert.ToInt32(this.Name));

            this.Controls["lblTitle"].Text = book.Title;
            this.Controls["lblDescription"].Text = book.Description;
            this.Controls["lblAuthor"].Text = book.Author.Name;
            PictureBox pictureBox = (PictureBox)this.Controls["picBook"];
            pictureBox.Image = Image.FromFile(book.ImagePath);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
