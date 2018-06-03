using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.View
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        public Video(String VideoID)
        {
            InitializeComponent();
            webBrowser.Navigate($"http://youtube.com/v/{VideoID}?version=3");
        }
    }
}
