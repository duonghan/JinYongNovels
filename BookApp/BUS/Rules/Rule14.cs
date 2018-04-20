using System.Linq;

namespace BookApp.BUS.Rules
{
    //14, một thành phần phụ âm không thể đứng giữa 2 thành phần nguyên âm được
    class Rule14
    {
        public static bool Check(string str)
        {
            int i, j;
            string a = "bcdđghklmnpqrstvx";
            for (i = 0; i < str.Length; i++)
                if (a.Contains(str[i]) == false) break;
            if (i >= (str.Length - 1)) return true;
            for (j = i; j < str.Length; j++)
                if (a.Contains(str[j])) break;
            if (j >= (str.Length - 1)) return true;
            for (i = j; i < str.Length; i++)
                if (a.Contains(str[i]) == false) break;
            if (i > (str.Length - 1)) return true;
            return false;
        }
    }
}
