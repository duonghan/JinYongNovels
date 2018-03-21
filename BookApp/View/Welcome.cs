using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BookApp
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            //Huy SplashScreen
            t.Abort();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Main begin = new Main();
            begin.Show();
            this.Hide();
        }

        private void btnWelcomeExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }
    }
}
