using System.Linq;

namespace BookApp.BUS.Rules
{
    //10. Có 14 nguyên âm 3 :iêu,yêu,oai,oao,oay,oeo,uao,uây,uôi,ươi,ươu,uya,uyê,uyu;
    class Rule10
    {    
        public static bool Check(string str)
        {
            int found = 0;
            string b = "aăâeêioôơuưy";
            string[] a = { "iêu", "yêu", "oai", "oao", "oay", "oeo", "uao", "uây", "uôi", "ươi", "ươu", "uya", "uyê", "uyu" };
            string[] c = { "yêu", "oai", "uây", "uôi" };
            if (str.Length > 3)
            {
                for (int i = 0; i < str.Length - 2; i++)
                    if (b.Contains(str[i]) && b.Contains(str[i + 1]) && b.Contains(str[i + 2]))
                    {
                        string tmp = str.Substring(i, 3);
                        for (int j = 0; j < 14; j++)
                            if (tmp.Equals(a[j])) found = 1;
                        if (found == 0) return false;
                        else found = 0;
                    }
                return true;
            }
            if (str.Length == 3)
            {
                if (b.Contains(str[0]) && b.Contains(str[1]) && b.Contains(str[2]))
                {
                    for (int i = 0; i < 4; i++)
                        if (str.Equals(c[i])) return true;
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
