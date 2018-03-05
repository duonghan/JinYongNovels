using BookApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DAO
{
    class BookDAO
    {
        private static BookDAO instance;

        internal static BookDAO Instance
        {
            get
            {
                if (instance == null) new BookDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public static int BookWidth = 50;
        public static int BookHeight = 50;

        private BookDAO() { }

        public List<Book> loadBookList()
        {
            List<Book> bookList = new List<Book>();

            string sql = "GetBookList";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);

            foreach(DataRow item in data.Rows)
            {
                Book book = new DTO.Book(item);
                bookList.Add(book);
            }

            return bookList;
        }
    }
}
