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
    public partial class Reader : Form
    {
        private int bookid;
        
        public Reader()
        {
            InitializeComponent();
            showChapter(bookid);
        }

        public Reader(int ID)
        {
            this.bookid = ID;
            InitializeComponent();
            showChapter(bookid);
            showBookName(bookid);
        }

        #region Method
        private void showChapter(int bookID)
        {
            listBoxChapter.Items.Clear();

            List<Chapter> listChapter = ChapterDAO.Instance.loadChapterList(bookID);

            foreach (Chapter item in listChapter)
            {                
                listBoxChapter.Items.Add(item.ID + ". " + item.Name);
                comboBoxChapterList.Items.Add("Chương " + item.ID);

            }

        }

        private void showBookName(int bookID)
        {
            string bookName = BookDAO.Instance.getBookInfo(bookID).Name;
            lblBookName.Text = bookName;
        }

        private void showContent(int chapID)
        {
            Chapter chapInfo = ChapterDAO.Instance.getChapterInfo(chapID);
            rtContent.Text = "Chương " + (chapID + 1) + ". " + chapInfo.Name;

            rtContent.Text = chapInfo.ChapContent;
        }


        #endregion


        #region Event
        private void listBoxChapter_Click(object sender, EventArgs e)
        {
            int id = this.listBoxChapter.SelectedIndex;
            showContent(id+1);

            comboBoxChapterList.DisplayMember = comboBoxChapterList.Items[id].ToString();
        }
        #endregion
    }
}
