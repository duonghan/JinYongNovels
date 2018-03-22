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
                if (instance == null) instance = new BookDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public static int BookWidth = 200;
        public static int BookHeight = 300;

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

        public Book getBookInfo(int id)
        {
            string sql = "GetBookInfo @bookid";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] {id});

            return new DTO.Book(data.Rows[0]);
        }
    }
}
