using BookApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS
{
    class SearchHandler
    {
        public string x;
        public string y;
        public SearchHandler(string s, string t)
        {
            this.x = s;
            this.y = t;
        }
        public static Result[] SearchText(string source, string searchTxt, int chapid)
        {
            Result[] r = new Result[100];
            int i = 0, j = 0, c = 0;
            int tmp = 0, p = 0;
            string[] st = searchTxt.Split(' ');
            while ((i != -1) && (i < source.Length))
            {
                p = source.IndexOf(st[0], i);
                if (p == -1) break;
                else i = p;
                for (j = 1; j < st.Length; j++)
                {
                    tmp = source.IndexOf(st[j], i);
                    if (tmp == -1) break;
                    else i = tmp + st[j].Length - 1;
                }
                if (tmp != -1)
                {
                    Result k = new Result(chapid, p, i);
                    r[c] = k;
                    c++;
                }
                i++;
            }
            return r;
        }
    }
}
