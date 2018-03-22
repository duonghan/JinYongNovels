using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DTO
{
    class Chapter
    {
        private int id;
        private string name;
        private string chapcontent;
        private int bookid;

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string ChapContent
        {
            get
            {
                return chapcontent;
            }

            set
            {
                chapcontent = value;
            }
        }

        public int BookID
        {
            get
            {
                return bookid;
            }

            set
            {
                bookid = value;
            }
        }

        public Chapter(int id, string name, string chapcontent, int bookid)
        {
            this.ID = id;
            this.Name = name;
            this.ChapContent = chapcontent;
            this.BookID = bookid;
        }

        public Chapter(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.ChapContent = row["chapcontent"].ToString();
            this.BookID = (int)row["bookid"];
        }

    }
}
