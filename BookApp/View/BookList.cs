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

        void loadBook()
        {
            List<Book> bookList = BookDAO.Instance.loadBookList();

            foreach (Book book in bookList)
            {
                Button btn = new Button() { Width = BookDAO.BookWidth, Height = BookDAO.BookHeight };
                btn.Text = book.Name;
                btn.ForeColor = Color.White;
                btn.Click += book_Click;
                btn.Tag = book;
                //btn.Text = book.Name + Environment.NewLine + book.Status;
                //btn.Image = " dasdasdas" + book.ID + ".jpg"; 
                flpBook.Controls.Add(btn);
            }
        }

        private void book_Click(object sender, EventArgs e)
        {
            int bookID = (sender as Book).ID;
            showBook(bookID);
        }

        private void showBook(int bookID)
        {
            
        }
    }
}
