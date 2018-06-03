using BookApp.DAO;
using BookApp.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.BUS
{
    class Search
    {
        private static Search instance;

        internal static Search Instance
        {
            get
            {
                if (instance == null) return new Search();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        //public void getResult(TextBox txtBoxSearch, RichTextBox rtContent)
        //{
        //    string[] words = txtBoxSearch.Text.Split();
        //    int[] indexItems;

        //    foreach (string word in words)
        //    {
        //        int startIndex = 0;
        //        while (startIndex < rtContent.TextLength)
        //        {
        //            int wordStartIndex = rtContent.Find(word, startIndex, RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord);
        //            if (wordStartIndex != -1)
        //            {
        //                rtContent.SelectionBackColor = Color.YellowGreen;

        //                rtContent.Select(startIndex, word.Length);
        //                rtContent.ScrollToCaret();

        //            }
        //            else
        //                break;

        //            startIndex += wordStartIndex + word.Length;
        //        }
        //    }
        //}

        public void getResult(TextBox txtBoxSearch, RichTextBox rtContent, int chapid)
        {
            Result[] lsResult = SearchHandler.SearchText(rtContent.Text, txtBoxSearch.Text, chapid);

            foreach(Result result in lsResult)
            {
                rtContent.SelectionBackColor = Color.YellowGreen;
                int length = result.getLastIndex() - result.getFirstIndex() + 1;
                rtContent.Select(result.getFirstIndex(), length);
                rtContent.ScrollToCaret();
            }
        }

        public void addChapterList(int bookID, int chapid, ListBox listBoxChapter, ComboBox comboBoxChapterList, RichTextBox rtContent, TextBox txtBoxSearch)
        {
            int numOfChapters = listBoxChapter.Items.Count;
            int[] correctChapters;

            for(int i=1; i<= numOfChapters; i++)
            {
                rtContent.Text = ChapterDAO.Instance.getChapterInfo(chapid, bookID).ChapContent;



            }
            listBoxChapter.Items.Clear();

            

            List<Chapter> listChapter = ChapterDAO.Instance.loadChapterList(bookID);

            foreach (Chapter item in listChapter)
            {
                listBoxChapter.Items.Add(item.ID + ". " + item.Name);
                comboBoxChapterList.Items.Add("Chương " + item.ID);

            }
        }
    }
}
