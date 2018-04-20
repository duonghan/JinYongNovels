using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS.Rules
{
    //4. Tối đa 7 chữ cái: nghiêng
    class Rule4
    {
        public static bool Check(string str)
        {
            if (str.Length > 7) return false;
            return true;
        }
    }
}
