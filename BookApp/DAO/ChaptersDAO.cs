using BookApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DAO
{
    class ChaptersDAO
    {
        private static ChaptersDAO instance;

        public static ChaptersDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ChaptersDAO();
                }

                return instance;
            }

            set
            {
                instance = value;
            }

        }

        private ChaptersDAO() { }

        public List<Chapter> loadChapterList(int id)
        {
            List<Chapter> chapterList = new List<Chapter>();

            string sql = "SELECT * from dbo.chapter where id=@id";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);

            foreach (DataRow item in data.Rows)
            {
                Chapter book = new DTO.Chapter();
                chapterList.Add(book);
            }

            return chapterList;
        }
        
    }
}
