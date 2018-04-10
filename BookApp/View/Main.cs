using BookApp.DAO;
using BookApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp
{
    public partial class Main : Form
    {
        public Main()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();
            viewSideBar(btnSideHome);
            changeStyle(btnSideHome);
            //loadBook();

            //Détroy SplashScreen
            t.Abort();
        }

        #region Method
        //void loadBook()
        //{
        //    List<Book> bookList = BookDAO.Instance.loadBookList();

        //    foreach(Book book in bookList)
        //    {
        //        Button btn = new Button() { Width = BookDAO.BookWidth, Height = BookDAO.BookHeight };
        //        btn.Text = book.Name + Environment.NewLine + book.Status;
        //        //btn.Image = " dasdasdas" + book.ID + ".jpg"; 
        //        dgvBook.Controls.Add(btn);
        //    }
        //}

        void loadList()
        {
            string query = "SELECT chapcontent FROM dbo.chapter WHERE id=1";

            //dgvTest.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void changeStyle(Button btn)
        {
            btn.BackColor = Color.FromArgb(38, 38, 38);
            btn.ForeColor = Color.FromArgb(112, 128, 144);
        }

        private void resetStyle(Button btn)
        {
            btn.BackColor = Color.FromArgb(28, 28, 28);
            btn.ForeColor = System.Drawing.Color.White;
        }

        private void viewSideBar(Button btn)
        {
            pnlSide.Height = btn.Height;
            pnlSide.Top = btn.Top;
        }
        #endregion

        #region Event
        private void btnSideHome_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideHome);
            changeStyle(btnSideHome);

            resetStyle(btnAuthor);
            resetStyle(btnSideList);
            resetStyle(btnSideSearch);

            if (!panelContent.Controls.Contains(BookList.Instance))
            {
                panelContent.Controls.Add(HomePage.Instance);
                HomePage.Instance.Dock = DockStyle.Fill;
                HomePage.Instance.BringToFront();
            }
            else
            {
                HomePage.Instance.BringToFront();
            }

            this.Text = "Trang chủ";
        }        

        private void btnSideList_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideList);
            changeStyle(btnSideList);

            resetStyle(btnAuthor);
            resetStyle(btnSideHome);
            resetStyle(btnSideSearch);

            if (!panelContent.Controls.Contains(BookList.Instance))
            {
                panelContent.Controls.Add(BookList.Instance);
                BookList.Instance.Dock = DockStyle.Fill;
                BookList.Instance.BringToFront();
            }else
            {
                BookList.Instance.BringToFront();
            }

            this.Text = "Danh sách truyện";
        }

        private void btnSideSearch_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideSearch);
            changeStyle(btnSideSearch);

            resetStyle(btnAuthor);
            resetStyle(btnSideHome);
            resetStyle(btnSideList);

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            viewSideBar(btnAuthor);
            changeStyle(btnAuthor);

            resetStyle(btnSideList);
            resetStyle(btnSideHome);
            resetStyle(btnSideSearch);

            if (!panelContent.Controls.Contains(Author.Instance))
            {
                panelContent.Controls.Add(Author.Instance);
                Author.Instance.Dock = DockStyle.Fill;
                Author.Instance.BringToFront();
            }
            else
            {
                Author.Instance.BringToFront();
            }

            this.Text = "Thông tin tác giả";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #endregion

    }
}
