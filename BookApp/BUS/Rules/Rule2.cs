using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS.Rules
{
    //2. 8 Cặp phụ âm:nh,th,ph,tr,ch,gh,kh,ng
    class Rule2
    {
        public static bool Check(string str)
        {
            int count = 0;
            string[] a = { "nh", "th", "ph", "tr", "ch", "gh", "kh", "ng" };
            string b = "bcdđghklmnpqrstvx";
            for (int i = 0; i < (str.Length - 1); i++)
                if (b.Contains(str[i]) && b.Contains(str[i + 1]))
                {
                    string tmp = str.Substring(i, 2);
                    for (int j = 0; j < 8; j++)
                        if (tmp.Equals(a[j]) == true) count = 1;
                    if (count == 0) return false;
                    else count = 0;
                }
            return true;
        }
    }
}
