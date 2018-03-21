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
    public partial class BookList : UserControl
    {
        private static BookList _instance;
        
        public BookList()
        {
            InitializeComponent();
            loadBook();
        }

        public static BookList Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BookList();
                }
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        #region Method
        void loadBook()
        {
            List<Book> bookList = BookDAO.Instance.loadBookList();

            foreach (Book book in bookList)
            {
                //Button btn = new Button() { Width = BookDAO.BookWidth, Height = BookDAO.BookHeight };

                //btn.Text = book.Name;
                //btn.ForeColor = Color.White;
                //btn.Click += book_Click;
                //btn.Tag = book;
                Panel panel = addPanel(book);
                //btn.Text = book.Name + Environment.NewLine + book.Status;
                //btn.Image = " dasdasdas" + book.ID + ".jpg"; 
                flpBook.Controls.Add(panel);
            }
        }

        Panel addPanel(Book book)
        {

            Image img = Image.FromFile(@"D:\Material\Code\CSharp\BookApp\BookApp\images\cover\" + book.ID + ".jpg");
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
        #endregion


        #region Event
        private void book_Click(object sender, EventArgs e)
        {
            int bookID = (sender as Book).ID;
            showBook(bookID);
        }
        #endregion


        private void showBook(int bookID)
        {
            
        }
    }
}
