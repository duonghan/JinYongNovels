using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS.Rules
{
    //1. Bảng chữ cái tiếng việt:Không chứa: z,j,w,f
    class Rule1
    {
        public static bool Check(string str)
        {
            if (str.Contains("z") || str.Contains("j") || str.Contains("w") || str.Contains("f"))
                return false;
            return true;
        }
    }
}
