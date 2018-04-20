using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS.Rules
{
    //6. Tối đa 5 phụ âm: "ngh..nh"
    class Rule6
    {        
        public static bool Check(string str)
        {
            int count = 0;
            string b = "bcdđghklmnpqrstvx";
            for (int i = 0; i < str.Length; i++)
                if (b.Contains(str[i])) count = count + 1;
            if (count > 5) return false;
            else return true;
        }
    }
}
