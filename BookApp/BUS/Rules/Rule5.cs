using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS.Rules
{
    //4. 2Cặp phụ âm cuối: nh, ng,ch (chich)
    class Rule5
    {      
        public static bool Check(string str)
        {
            string[] a = { "nh", "ng", "ch" };
            string b = "bcdđghklmnpqrstvx";
            if (str.Length >= 2 && b.Contains(str[str.Length - 2]) && b.Contains(str[str.Length - 1]))
            {
                string tmp = str.Substring(str.Length - 2, 2);
                for (int i = 0; i < 3; i++)
                    if (tmp.Equals(a[i]))
                        if (str.Length == 2) return false;
                        else return true;
                return false;
            }
            return true;
        }
    }
}
