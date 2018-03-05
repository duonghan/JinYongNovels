using BookApp.DAO;
using BookApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            viewSideBar(btnSideHome);
            loadBook();
        }

        #region Method
        void loadBook()
        {
            List<Book> bookList = BookDAO.Instance.loadBookList();

            foreach(Book book in bookList)
            {
                Button btn = new Button() { Width = BookDAO.BookWidth, Height = BookDAO.BookHeight };
                btn.Text = book.Name + Environment.NewLine + book.Status;
                //btn.Image = " dasdasdas" + book.ID + ".jpg"; 
                dgvTest.Controls.Add(btn);
            }
        }
        #endregion

        #region Event
        private void btnSideHome_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideHome);
        }

        private void viewSideBar(Button btn)
        {
            pnlSide.Height = btn.Height;
            pnlSide.Top = btn.Top;
        }

        private void btnSideList_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideList);
        }

        private void btnSideSearch_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideSearch);
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            viewSideBar(btnAuthor);
        }

        #endregion

        void loadList()
        {
            string query = "SELECT chapcontent FROM dbo.chapter WHERE id=1";

            dgvTest.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
