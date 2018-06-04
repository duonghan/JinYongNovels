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
        private int bookid;

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
            List<Chapter> listChapter = ChapterDAO.Instance.loadChapterList(book.ID);
            bookid = book.ID;

            pnlBookImage.Size = new Size(BookDAO.BookWidth, BookDAO.BookHeight);
            pnlBookImage.BackgroundImage = Image.FromFile(@"..\..\Resources\images\cover\" + book.ID + ".jpg");
            pnlBookImage.BackgroundImageLayout = ImageLayout.Stretch;
            lblBookName.Text = book.Name;
            lblBookStatus.Text = "Chương " + (book.Status + 1) + ": " + listChapter[book.Status].Name;
        }

        private void book_Click(object sender, EventArgs e)
        {

            Reader reader = new Reader(bookid);
            Form parent = (Form)this.TopLevelControl;
            reader.parentTag = parent;
            reader.FormClosing += delegate { parent.Show(); };

            reader.Show();
            parent.Hide();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            loadBook();
        }
    }
}
