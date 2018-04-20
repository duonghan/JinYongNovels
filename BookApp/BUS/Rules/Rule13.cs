namespace BookApp.BUS.Rules
{
    //13. có 30 nguyên âm ghép không thêm được phần âm cuối:AI, AO, AU, ÂU, AY, ÂY, EO, ÊU, IA, IÊU/YÊU, IU, OI, ÔI, ƠI, OAI, OAO, OAY, OEO, 
    // ƯA, UI, ƯI, ƯU, UƠ, UAI, UÂY, UÔI, ƯƠI, ƯƠU, UYA và UYU
    class Rule13
    {
        public static bool Check(string str)
        {
            string[] a = { "ai", "ao", "au", "âu", "ay", "ây", "eo", "êu", "ia", "iêu", "yêu", "iu", "oi", "ôi", "ơi", "oai", "oao", "oay", "oeo", "ưa", "ui", "ưi", "ưu", "uơ", "oai", "uây", "uôi", "ươi", "ươu", "uya", "uyu" };
            for (int i = 0; i < 30; i++)
            {
                if (str.Contains(a[i]) && str.IndexOf(a[i]) != (str.Length - a[i].Length)) return false;
            }
            return true;
        }
    }
}
