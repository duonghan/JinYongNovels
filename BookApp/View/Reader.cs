using BookApp.BUS;
using BookApp.DAO;
using BookApp.DTO;
using BookApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BookApp
{
    public partial class Reader : Form
    {
        private int bookid;
        public Form parentTag;
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        int pnlSideBarWidth;
        bool isHided;
        Video video;
        String soundURL;
        String[] lstVideo = { "6VFq162EvWs&list=PLAlDQuz-HGasMPNQeUWiko7dEfr9dI4T3",
                              "6g5nXnTmwfs&list=PLNxirzjIPkMuK-DYAAVp7F9vOel08DKHJ",
                              "JTy4nan_2tI&list=PLj6a-CQbvJ80pwjqQ0QrSJM9JXYgZgon0",
                              "rL66UvSFUyM&list=PL07757D69625A45CF",
                              "IKlAQLcJ410&list=PLC7TpnEHTRS0x0rhHK74fZTBwsvLxwTvP",
                              "2hoNvwPPVRE&list=PL-zRaP_0h-ALTGj4reP1_G9KBd58sSrIT",
                              "jVy_znaC6oQ&list=PLgxAXsPXjz1t_FGgaOB19s5GXQoeKrBI5",
                              "ePY7E2SLQTI&list=PLDSOBX82W4uuI4xN5Ux7Pcsm68JMhlmYp",
                              "nz-8I6bwucg&list=PLwGW1ess1QIfVXSJn2GIrTwiXTJLgGNTY",
                              "u8plHj8-o_c&list=PLbT2JLKhYTzbNb5xf85TMOMCxIosmiMWV",
                              "GoAN_IOwIY0&list=PLU0goh_MU6OJPdytJmquwCtm6R-e1dQmN",
                              "sOPQ2hlgBhc&list=PLC7TpnEHTRS0Nc48wxfNew4rgjDGwuVTa",
                              "QXTb9REH0R8&list=PLiPno7xiOszuCptcCaB5MGIHiU1Eq3ZZu",
                              "SEL4LaEiIj8&list=PLRNkUN9pL7UUM79eL0BzXo14nvxqJeDNV",
                              "I5mVH4oLJ5A&t=1077s",
        };

        public Reader()
        {
            InitializeComponent();
            showChapter(bookid);
            pnlSlide.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            //player.SoundLocation = "../../Resources/ost/" + bookid + "_OP.mp3";
            //soundURL = bookid + "_OP.mp3";
            //player.URL = soundURL;
        }

        public Reader(int ID)
        {
            this.bookid = ID;
            InitializeComponent();
            showChapter(bookid);
            showBookName(bookid);
            pnlSlide.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            //player.SoundLocation = "../../Resources/ost/" + bookid + "_OP.mp3";
            player.URL = soundURL = @"D:\Material\Code\CSharp\BookApp\BookApp\Resources\ost\" + bookid + "_OP.mp3";

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
            Search.Instance.getResult(txtBoxSearch, rtContent, 1);
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
            if(video != null) video.Close();
            player.close();
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

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if(colorDialogSelector.ShowDialog() == DialogResult.OK)
            {
                //displayColorSelector(colorDialogSelector.Color.Name);
                btnBackColor.BackColor = rtContent.BackColor = colorDialogSelector.Color;
            }
        }

        public void displayColorSelector(string text)
        {
            MessageBox.Show(text);
        }

        private void btnForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialogSelector.ShowDialog() == DialogResult.OK)
            {
                btnForeColor.BackColor = rtContent.ForeColor = colorDialogSelector.Color;
            }
        }

        private void btnIncreaseFSize_Click(object sender, EventArgs e)
        {
            rtContent.Font = new Font(rtContent.Font.FontFamily, rtContent.Font.Size + 2);
        }

        private void btnDecreaseFSize_Click(object sender, EventArgs e)
        {
            rtContent.Font = new Font(rtContent.Font.FontFamily, rtContent.Font.Size - 2);
        }

        private void btnFontCustom_Click(object sender, EventArgs e)
        {
            if(fontDialog.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(rtContent.Text))
            {
                rtContent.Font = fontDialog.Font; 
            }
        }

        private void btnPlaySound_Click(object sender, EventArgs e)
        {
            //player.Play();
            player.controls.play();
        }

        private void btnPauseSound_Click(object sender, EventArgs e)
        {
            //player.Stop();
            player.controls.pause();
        }

        private void btnNextSound_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (soundURL.Contains("OP"))
            {      
                player.URL = soundURL = soundURL.Replace("OP", "ED");
            }
            else
            {
                player.URL = soundURL = soundURL.Replace("ED", "OP");
            }
            player.controls.next();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            //player.URL = @"https://www.youtube.com/watch?v=Z7dXHZ77bAc";
            System.Diagnostics.Process.Start(@"https://www.youtube.com/watch?v=Z7dXHZ77bAc");
            //video = new Video("Z7dXHZ77bAc");
            //video.Show();
        }
    }
}
