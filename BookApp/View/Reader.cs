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

        private void btnBackParent_Click(object sender, EventArgs e)
        {
            BookList booklist = new BookList();
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] words = txtBoxSearch.Text.Split(' ');
            foreach(string word in words)
            {
                int startIndex = 0;
                while(startIndex < rtContent.TextLength)
                {
                    int wordStartIndex = rtContent.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        rtContent.SelectionStart = wordStartIndex;
                        rtContent.SelectionLength = word.Length;
                        rtContent.SelectionBackColor = Color.YellowGreen;

                    }
                    else
                        break;

                    startIndex += wordStartIndex + word.Length;
                }
            }
        }

        private void Search_Reset(object sender, EventArgs e)
        {
            rtContent.SelectionStart = 0;
            rtContent.SelectAll();
            rtContent.SelectionBackColor = rtContent.BackColor;
        }
    }
}
