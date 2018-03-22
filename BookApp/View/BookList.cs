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

                Panel panel = addPanel(book);
                panel.Tag = book;
                panel.Click += book_Click;

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
            int bookID;
            try
            {
                bookID = ((sender as Panel).Tag as Book).ID;
            }
            catch(NullReferenceException ex)
            {
                bookID = 1;
            }
            Reader reader = new Reader(bookID);
            reader.Show();
            ((Form)this.TopLevelControl).Hide();

        }
        #endregion

    }
}
