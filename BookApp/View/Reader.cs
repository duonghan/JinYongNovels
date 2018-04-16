using BookApp.BUS;
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
        public Form parentTag;

        int pnlSideBarWidth;
        bool isHided;

        public Reader()
        {
            InitializeComponent();
            showChapter(bookid);
            pnlSlide.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
        }

        public Reader(int ID)
        {
            this.bookid = ID;
            InitializeComponent();
            showChapter(bookid);
            showBookName(bookid);
            pnlSlide.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;

            pnlSideBarWidth = pnlSidebar.Width;
            isHided = false;
        }

        #region Method

        //Show chapter list in left hand
        private void showChapter(int bookID)
        {
            pnlSlide.Items.Clear();

            List<Chapter> listChapter = ChapterDAO.Instance.loadChapterList(bookID);

            foreach (Chapter item in listChapter)
            {                
                pnlSlide.Items.Add(item.ID + ". " + item.Name);
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

            pnlSlide.SelectedIndex = id;
        }

        private void showSearchResult()
        {
            Search.Instance.getResult(txtBoxSearch, rtContent);
        }

        #endregion


        #region Event
        private void listBoxChapter_Click(object sender, EventArgs e)
        {
            int id = this.pnlSlide.SelectedIndex;
            showContent(id);
        }
        
        private void btnBackParent_Click(object sender, EventArgs e)
        {
            BookDAO.Instance.updateBookStatus(bookid, this.pnlSlide.SelectedIndex);

            //BookList booklist = new BookList();
            //Home home = new Home();
            parentTag.Show();
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
                showContent(BookDAO.Instance.getBookStatus(bookid));
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
            showContent(this.pnlSlide.SelectedIndex + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            showContent(this.pnlSlide.SelectedIndex - 1);
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
            e.ItemHeight = (int)e.Graphics.MeasureString(pnlSlide.Items[e.Index].ToString(), pnlSlide.Font, pnlSlide.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(pnlSlide.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void Reader_FormClosed(object sender, FormClosedEventArgs e)
        {
            BookDAO.Instance.updateBookStatus(bookid, this.pnlSlide.SelectedIndex);
        }


        #endregion

        private void btnList_Click(object sender, EventArgs e)
        {
            if (isHided)
            {
                this.pnlSidebar.Width = pnlSideBarWidth;

                isHided = false;
                this.Refresh();
            }
            else
            {
                this.pnlSidebar.Width = pnlMenu.Width;

                isHided = true;
                this.Refresh();
            }
        }
    }
}
