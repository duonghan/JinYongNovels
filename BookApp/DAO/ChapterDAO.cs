using BookApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DAO
{
    class ChapterDAO
    {
        private static ChapterDAO instance;

        public static ChapterDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ChapterDAO();
                }

                return instance;
            }

            set
            {
                instance = value;
            }

        }

        private ChapterDAO() { }

        //Get chapter list with book id
        public List<Chapter> loadChapterList(int id)
        {
            List<Chapter> chapterList = new List<Chapter>();

            //Thay vi viet cau lenh truy van
            //Su dung stored/proceduce trong SQL Server
            string sql = "EXEC GetChapterList @bookid";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                Chapter chapter = new DTO.Chapter(item);
                chapterList.Add(chapter);
            }

            return chapterList;
        }

        //Get chapter content based-on chapter id and book id
        public Chapter getChapterInfo(int id, int bookid)
        {
            string sql = "GetChapterInfo @chapid , @bookid";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { id , bookid});

            return new DTO.Chapter(data.Rows[0]);
        }
        
    }
}
