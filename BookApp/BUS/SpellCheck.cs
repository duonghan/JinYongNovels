using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.BUS
{
    class SpellCheck
    {

        private static SpellCheck instance;

        internal static SpellCheck Instance
        {
            get
            {
                if (instance == null) return new SpellCheck();
                return instance;
            }

            set
            {
                instance = value;
            }
        }


    }
}
