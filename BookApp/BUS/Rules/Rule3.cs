using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS.Rules
{
    //3. 7 Phụ âm cuối:c,m,n,t,p
    class Rule3
    {
        public static bool Check(string str)
        {
            if (str.Length > 2)
            {
                string tmp = str.Substring(str.Length - 2, 2);
                if (tmp.Equals("ch") || tmp.Equals("nh") || tmp.Equals("ng")) return true;
            }
            string a = "cmnpt";
            string b = "bcdđghklmnpqrstvx";
            char[] s = str.ToCharArray(0, str.Length);
            if (b.Contains(str[str.Length - 1]))
                if (a.Contains(str[str.Length - 1])) return true;
                else return false;
            return true;
        }
    }
}
