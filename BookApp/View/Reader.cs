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
using System.Runtime.InteropServices;
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
        bool isPlay=true;
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

        private int CurrentPage = 0;
        private int FirstPage = 0;
        private int LastPage = 0;
        List<string> Pages = new List<string>();

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
            bookid = ID;
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
            //rtContent.Text = chapInfo.ChapContent;
            string Document = chapInfo.ChapContent;
            TextFormatFlags flags = TextFormatFlags.Top | TextFormatFlags.Left |
                                    TextFormatFlags.WordBreak | TextFormatFlags.NoPadding |
                                    TextFormatFlags.TextBoxControl;
            Size textSize = TextRenderer.MeasureText(Document, rtContent.Font, rtContent.ClientSize, flags);
            int NumberOfPages = textSize.Height / rtContent.ClientSize.Height;

            if (textSize.Height > rtContent.Height)
            {
                rtContent.Text = Document;
                rtContent.Update();

                //Number of shown lines
                int FirstCharOfLastShownLine = rtContent.GetCharIndexFromPosition(new Point(0, rtContent.ClientSize.Height));
                int ShownLines = rtContent.GetLineFromCharIndex(FirstCharOfLastShownLine);
                int TotalLines = rtContent.GetLineFromCharIndex(rtContent.Text.Length - 1);

                for (int p = 0; p < NumberOfPages; p++)
                {
                    int FirstLineOfPage = (p * ShownLines);
                    int FirstCharOfPage = rtContent.GetFirstCharIndexFromLine(FirstLineOfPage);

                    int FirstLineOfNextPage = (p + 1) * ShownLines;
                    FirstLineOfNextPage = (FirstLineOfNextPage > TotalLines) ? TotalLines : FirstLineOfNextPage;
                    int LastCharOfPage = (FirstLineOfNextPage < TotalLines)
                                       ? rtContent.GetFirstCharIndexFromLine(FirstLineOfNextPage) - 1
                                       : rtContent.Text.Length;
                    Pages.Add(rtContent.Text.Substring(FirstCharOfPage, LastCharOfPage - FirstCharOfPage));
                }
            }
            else
            {
                Pages.Add(Document);
            }
            rtContent.Text = Pages.First();


            this.lblPageStatus.Text = "1/" + Pages.Count.ToString();
            LastPage = Pages.Count - 1;
            btnPageNext.Enabled = true;
            btnPageLast.Enabled = true;

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
            int id = pnlSlide.SelectedIndex;
            Pages.Clear();
            showContent(id);
        }
        
        private void btnBackParent_Click(object sender, EventArgs e)
        {
            BookDAO.Instance.updateBookStatus(bookid, pnlSlide.SelectedIndex);

            //BookList booklist = new BookList();
            //Home home = new Home();
            parentTag.Show();
            Close();
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
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Bạn có muốn đọc từ vị trí lần cuối cùng không?";
                string caption = "Đọc truyện";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //Load first chapter in list
                    showContent(BookDAO.Instance.getBookStatus(bookid));
                }else
                {
                    showContent(0);
                }
                
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
            showContent(pnlSlide.SelectedIndex + 1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            showContent(pnlSlide.SelectedIndex - 1);
        }

        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showSearchResult();
            }

            if(e.KeyCode == Keys.Right)
            {
                btnPageNext_Click(sender, e);
            }
            if (e.KeyCode == Keys.Left)
            {
                btnPagePrev_Click(sender, e);
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
            BookDAO.Instance.updateBookStatus(bookid, pnlSlide.SelectedIndex);
            if(video != null) video.Close();
            player.close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (isHided)
            {
                pnlSidebar.Width = pnlSideBarWidth;

                isHided = false;
                Refresh();
            }
            else
            {
                pnlSidebar.Width = pnlMenu.Width;

                isHided = true;
                Refresh();
            }
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialogSelector.ShowDialog() == DialogResult.OK)
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
            if (fontDialog.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(rtContent.Text))
            {
                rtContent.Font = fontDialog.Font;
            }
        }

        private void btnPlaySound_Click(object sender, EventArgs e)
        {
            if (isPlay)
            {
                isPlay = false;
                btnPlayToggle.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Pause_button_32px));
                player.controls.pause();
            }
            else
            {
                isPlay = true;
                btnPlayToggle.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Play_button_32px));
                player.controls.play();
            }
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
            System.Diagnostics.Process.Start(@"https://www.youtube.com/watch?v=" + lstVideo[bookid - 1]);
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < LastPage)
            {
                btnPageFirst.Enabled = true;
                btnPagePrev.Enabled = true;

                CurrentPage += 1;
                rtContent.Text = Pages[CurrentPage];
                this.lblPageStatus.Text = (CurrentPage + 1).ToString() + "/" + Pages.Count.ToString();

                if (CurrentPage == LastPage)
                {
                    btnPageNext.Enabled = false;
                    btnPageLast.Enabled = false;
                }
            }
        }

        private void btnPagePrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > FirstPage)
            {
                btnPageLast.Enabled = true;
                btnPageNext.Enabled = true;

                CurrentPage -= 1;
                rtContent.Text = Pages[CurrentPage];
                this.lblPageStatus.Text = (CurrentPage + 1).ToString() + "/" + Pages.Count.ToString();
                if (CurrentPage == 0)
                {
                    btnPagePrev.Enabled = false;
                    btnPageFirst.Enabled = false;
                }
            }
        }

        private void btnPageFirst_Click(object sender, EventArgs e)
        {
            btnPagePrev.Enabled = false;
            btnPageFirst.Enabled = false;
            btnPageNext.Enabled = true;
            btnPageLast.Enabled = true;
            CurrentPage = FirstPage;
            rtContent.Text = Pages[CurrentPage];
            this.lblPageStatus.Text = (CurrentPage + 1).ToString() + "/" + Pages.Count.ToString();
        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            btnPageNext.Enabled = false;
            btnPageLast.Enabled = false;
            btnPagePrev.Enabled = true;
            btnPageFirst.Enabled = true;
            CurrentPage = LastPage;
            rtContent.Text = Pages[CurrentPage];
            this.lblPageStatus.Text = (CurrentPage + 1).ToString() + "/" + Pages.Count.ToString();
        }


        #endregion

    } 
}
