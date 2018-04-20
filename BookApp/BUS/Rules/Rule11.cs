namespace BookApp.BUS.Rules
{
    //Có 12 nguyên âm: Ă, Â, IÊ, OĂ, OO, ÔÔ, UÂ, UĂ, UÔ, ƯƠ, UYÊ, YÊ bắt buộc phải thêm phần âm cuối 
    //được chia theo quy tắc đối lập bổ sung như sau:
    //Bắt buộc thêm nguyên âm cuối, hoặc phụ âm cuối: Â, IÊ,UÂ,UÔ,ƯƠ,YÊ.
    //Bắt buộc thêm phụ âm cuối: Ă, OĂ, OO, ÔÔ, UĂ, UYÊ.

    //11. Bắt buộc thêm nguyên âm cuối, hoặc phụ âm cuối: Â, IÊ,UÂ,UÔ,ƯƠ,YÊ.
    class Rule11
    {
        public static bool Check(string str)
        {
            string[] a = { "â", "iê", "uâ", "uô", "ươ", "yê" };
            for (int i = 0; i < 6; i++)
                if (str.IndexOf(a[i], 0) == (str.Length - a[i].Length)) return false;
            return true;
        }
    }
}
