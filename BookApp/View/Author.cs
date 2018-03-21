using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp
{
    public partial class Author : UserControl
    {
        private static Author _instance;

        public Author()
        {
            InitializeComponent();
        }

        public static Author Instance
        {
            get
            {

                if (_instance == null)
                {
                    _instance = new Author();
                }
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
    }
}
