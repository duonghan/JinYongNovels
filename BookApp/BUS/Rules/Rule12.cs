using System.Linq;

namespace BookApp.BUS.Rules
{
    //12.Bắt buộc thêm phụ âm cuối: Ă, OĂ, OO UĂ, UYÊ.
    class Rule12
    {      
        public static bool Check(string str)
        {
            string[] a = { "ă", "oă", "oo", "uă", "uyê" };
            string b = "bcdđghklmnpqrstvx";
            for (int i = 0; i < 5; i++)
            {
                if (str.Contains(a[i]))
                {
                    int tmp = str.IndexOf(a[i], 0);
                    if (tmp == (str.Length - a[i].Length)) return false;
                    if (b.Contains(str[tmp + a[i].Length]) == false) return false;
                }
            }
            return true;
        }
    }
}
