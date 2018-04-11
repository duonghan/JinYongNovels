using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS
{   

    class Rule
    {
        private static Rule instance;

        internal static Rule Instance
        {
            get
            {
                if (instance == null) instance = new Rule();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        private string wrongChar = "wjzfWJZF";
        private string wrongLastCons = "bdklqrsvxBDKLQRSVX";
        private String allConsoants = "bcdđghklmnpqrstvBCDĐGHKLMNPQRSTV";
        private string vowel = "ueoaiươêăâô";
        //private char[] vowel = { 'u', 'e', 'o', 'a', 'i', 'ư', 'ơ', 'ê', 'ă', 'â', 'ô' };
        private string[] correctFirstDbCons = { "nh", "th", "ph", "tr", "ch", "gh", "kh", "ng" };
        private string[] correctLastDbCons = { "nh", "ng", "ch" };
        private const int MAXLENGTH = 7;

        private bool checkLength(string str)
        {
            if (0 < str.Length && str.Length <= 7)
                return true;
            return false;
        }

        //Return true if string not contain any english character
        private bool checkWrongChar(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (wrongChar.Contains("" + str[i])) return false;
            }

            if (wrongLastCons.Contains("" + str[str.Length - 1])) return false;

            return true;
        }

        private bool checkDbCons(string str)
        {
            if (allConsoants.Contains(str[0]) && allConsoants.Contains(str[1]))
            {
                int i = 0;
                String ch = str[0] + "" + str[1];
                for (; i < correctFirstDbCons.Length; i++)
                {
                    if (ch.ToUpper().Equals(correctFirstDbCons[i].ToUpper()))
                        break;
                }

                if (i > correctFirstDbCons.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            if (allConsoants.Contains(str[str.Length-1]) && allConsoants.Contains(str[str.Length - 2]))
            {
                int i = 0;
                String ch = str[str.Length - 2] + "" + str[str.Length - 1];
                for (; i < correctLastDbCons.Length; i++)
                {
                    if (ch.ToUpper().Equals(correctLastDbCons[i].ToUpper()))
                        break;
                }

                if (i > correctLastDbCons.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            return false;
        }

        //Kiem tra l va n

        //Kiem tra cac ten rieng cua nhan vat
        private bool checkName(String str)
        {
            return false;
        }

        //Total check
        public bool isCorrect(String str)
        {
            return (checkLength(str) && checkWrongChar(str) && checkDbCons(str) && checkName(str));
        }
        
    }
}
