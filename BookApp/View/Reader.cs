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
            listBoxChapter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
        }

        public Reader(int ID)
        {
            this.bookid = ID;
            InitializeComponent();
            showChapter(bookid);
            showBookName(bookid);
            listBoxChapter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
        }

        #region Method

        //Show chapter list in left hand
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

        private void showContent(int id)
        {
            int chapID = id + 1;
            Chapter chapInfo = ChapterDAO.Instance.getChapterInfo(chapID, bookid);
            lblChapName.Text = "Chương " + (chapID) + ". " + chapInfo.Name;           
            rtContent.Text = chapInfo.ChapContent;

            comboBoxChapterList.SelectedIndex = id;
            comboBoxChapterList.DisplayMember = comboBoxChapterList.Items[id].ToString();

            listBoxChapter.SelectedIndex = id;
        }

        private void showSearchResult()
        {
            string[] words = txtBoxSearch.Text.Split(' ');
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < rtContent.TextLength)
                {
                    int wordStartIndex = rtContent.Find(word, startIndex, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord);
                    if (wordStartIndex != -1)
                    {
                        //rtContent.SelectionStart = wordStartIndex;
                        //rtContent.SelectionLength = word.Length;
                        rtContent.SelectionBackColor = Color.YellowGreen;

                        rtContent.Select(startIndex, word.Length);

                    }
                    else
                        break;

                    startIndex += wordStartIndex + word.Length;
                }
            }
        }

        #endregion


        #region Event
        private void listBoxChapter_Click(object sender, EventArgs e)
        {
            int id = this.listBoxChapter.SelectedIndex;
            showContent(id);
        }
        
        private void btnBackParent_Click(object sender, EventArgs e)
        {
            BookList booklist = new BookList();
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            showSearchResult();
        }

        private void Search_Reset(object sender, EventArgs e)
        {
            rtContent.SelectionStart = 0;
            rtContent.SelectAll();
            rtContent.SelectionBackColor = rtContent.BackColor;
        }

        /**
         * Create place holder text in textbox
         * Remove text in textbox when enter in textbox
         * Add text when leave textbox
         * */
        private void RemoveText(object sender, EventArgs e)
        {
            if(txtBoxSearch.Text.Equals("Tìm kiếm..."))
            {
                txtBoxSearch.Text = "";
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxSearch.Text))
                txtBoxSearch.Text = "Tìm kiếm...";
        }

        private void showEntryContent(object sender, EventArgs e)
        {
            try
            {
                //Load first chapter in list
                showContent(0);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void comboBoxChapterList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            showContent(senderComboBox.SelectedIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            showContent(this.listBoxChapter.SelectedIndex + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            showContent(this.listBoxChapter.SelectedIndex - 1);
        }

        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showSearchResult();
            }
        }

        //Word wrap listbox items if content string width is bigger than listbox width
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBoxChapter.Items[e.Index].ToString(), listBoxChapter.Font, listBoxChapter.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(listBoxChapter.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        #endregion
    }
}
