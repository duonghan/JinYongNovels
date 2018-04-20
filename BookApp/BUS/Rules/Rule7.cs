using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS.Rules
{
    //7.Tối đa 3 nguyên âm: uye
    class Rule7
    {        
        public static bool Check(string str)
        {
            string a = "aăâeêioôơuưy";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                if (a.Contains(str[i])) count = count + 1;
            if (count > 3) return false;
            else return true;
        }
    }
}
