using System.Linq;

namespace BookApp.BUS.Rules
{
    //9. có 32 nghuyên âm đôi:AI, AO, AU, ÂU, AY, ÂY, EO, ÊU, IA, IÊ/YÊ, IU, OA, OĂ, OE, OI, ÔI, ƠI, OO, ÔÔ, UA, UĂ, UÂ,
    // ƯA, UÊ, UI, ƯI,UO, UÔ, UƠ, ƯƠ, ƯU, UY
    class Rule9
    {
        public static bool Check(string str)
        {
            int count = 0;
            string[] a = { "ai", "ao", "au", "âu", "ay", "ây", "eo", "êu", "ia", "iê", "yê", "iu", "oa", "oă", "oe", "oi", "ôi", "ơi", "oo", "ua", "uă", "uâ", "ưa", "uê", "ui", "ưt", "uo", "uô", "ươ", "ươ", "ưu", "uy" };
            string[] c = { "ai", "ao", "âu", "ây", "eo", "êu", "oa", "oe", "ôi", "ơi", "ưa", "ui", "ưu", "uy" };
            string b = "aăâeêioôơuưy";
            if (str.Length > 2)
            {
                for (int i = 0; i < str.Length - 1; i++)
                    if (b.Contains(str[i]) && b.Contains(str[i + 1]))
                    {
                        string tmp = str.Substring(i, 2);
                        for (int j = 0; j < 32; j++)
                            if (tmp.Equals(a[j])) count = 1;
                        if (count == 0) return false;
                        else count = 0;
                    }
                return true;
            }
            else if (str.Length == 2)
            {
                if (b.Contains(str[0]) && b.Contains(str[1]))
                {
                    for (int i = 0; i < 14; i++)
                        if (str.Equals(c[i])) return true;
                    return false;
                }
                return true;
            }
            return true;

        }
    }
}
