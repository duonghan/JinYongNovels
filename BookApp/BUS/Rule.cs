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

        private char[] charEng = { 'j', 'z', 'w', 'f' };
        private char[] vowel = { 'u', 'e', 'o', 'a', 'i', 'ư', 'ơ', 'ê', 'ă', 'â', 'ô' };
        private string[] firstConsonant = { "nh", "th", "ph", "tr", "ch", "gh", "kh", "ng" };
        private string[] lastConsonant = { "c", "m", "n", "p", "t", "nh", "ng", "ch" };
        private const int MAXLENGTH = 6;

        //Return true if string not contain any english character
        public bool checkCharEng(string str)
        {
            foreach(char ch in charEng)
            {
                if (str.Contains(ch)) return false;
            }

            return true;
        }

        public bool checkFirstCoupleConsonant(string str)
        {
            if (str.Length > 2)
            {
                
            }

            return true;
        }
        
    }
}
