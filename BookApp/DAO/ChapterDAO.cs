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

        public Chapter getChapterInfo(int id)
        {
            string sql = "GetChapterInfo @chapid";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { id });

            return new DTO.Chapter(data.Rows[0]);
        }
        
    }
}
