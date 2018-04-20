using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS.Rules
{
    //8. Trùng kí tự:chuung; (trừ oo )
    class Rule8
    {       
        public static bool Check(string str)
        {
            if (str.Contains("ooo")) return false;
            for (int i = 0; i < str.Length - 1; i++)
                if (str[i].Equals(str[i + 1]) && (str[i].Equals('o') == false)) return false;
            return true;
        }
    }
}
