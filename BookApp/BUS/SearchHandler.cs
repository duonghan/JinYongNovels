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
        public static void Search(string source, string searchTxt)
        {
            Console.InputEncoding = Encoding.UTF8;
            SearchHandler f = new SearchHandler(source, searchTxt);
            f.y.Trim();
            int i = 0, j = 0, c = 0;
            int tmp = 0, r = 0;
            int[] first = new int[1000];
            int[] last = new int[1000];
            while (i < f.y.Length - 1)
                if ((f.y[i] == ' ') && (f.y[i + 1] == ' ')) f.y = f.y.Substring(0, i) + f.y.Substring(i + 1, f.y.Length - i - 1);
                else i++;
            string[] st = f.y.Split(' ');
            i = 0;
            while ((i != -1) && (i < f.x.Length))
            {
                r = f.x.IndexOf(st[0], i);
                if (r == -1) break;
                else i = r;
                for (j = 1; j < st.Length; j++)
                {
                    tmp = f.x.IndexOf(st[j], i);
                    if (tmp == -1) break;
                    else i = tmp + st[j].Length - 1;
                }
                if (tmp != -1)
                {
                    first[c] = r;
                    last[c] = i;
                    c++;
                }
                i++;
            }
            Console.WriteLine(c);
            for (i = 0; i < c; i++)
            {
                Console.Write(first[i]);
                Console.Write(' ');
                Console.WriteLine(last[i]);
            }
            Console.ReadKey();
        }
    }
}
