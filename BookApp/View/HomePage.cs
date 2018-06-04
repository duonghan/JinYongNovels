using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookApp.DTO;
using BookApp.DAO;

namespace BookApp
{
    public partial class HomePage : UserControl
    {
        private static HomePage _instance;

        public static HomePage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HomePage();
                }
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public HomePage()
        {
            InitializeComponent();
            loadBook();
        }

        void loadBook()
        {
            Book book = BookDAO.Instance.getLastBook();
            pnlBookImage = addPanel(book);
            pnlBookImage.Tag = book;
            pnlBookImage.Click += book_Click;
        }

        Panel addPanel(Book book)
        {

            Image img = Image.FromFile(@"D:\Material\Code\CSharp\BookApp\BookApp\Resources\images\cover\" + book.ID + ".jpg");
            Size size = new Size(BookDAO.BookWidth, BookDAO.BookHeight);

            // create the combined control
            Panel pan = new Panel();
            Label label = new Label();
            pan.Size = size;

            pan.BackgroundImage = img;
            pan.BackgroundImageLayout = ImageLayout.Stretch;

            //label.Size = pan.Size;
            //label.Parent = pan;  // add the Label to the Panel
            //label.Location = Point.Empty;
            //label.BackColor = Color.Transparent;
            //label.Text = book.Name;
            //label.TextAlign = ContentAlignment.BottomCenter;
            //label.ForeColor = Color.BlueViolet;
            //label.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            return pan;
        }

        private void book_Click(object sender, EventArgs e)
        {
            int bookID;
            try
            {
                bookID = ((sender as Panel).Tag as Book).ID;
                BookDAO.Instance.setLastBook(bookID);
            }
            catch (NullReferenceException ex)
            {
                bookID = 1;
            }

            //navigate from parent form and reader form
            //when click book and close reader

            Reader reader = new Reader(bookID);
            Form parent = (Form)this.TopLevelControl;
            reader.parentTag = parent;
            reader.FormClosing += delegate { parent.Show(); };

            reader.Show();
            parent.Hide();

        }
    }
}
