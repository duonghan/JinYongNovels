using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            viewSideBar(btnSideHome);
        }

        private void btnSideHome_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideHome);
        }

        private void viewSideBar(Button btn)
        {
            pnlSide.Height = btn.Height;
            pnlSide.Top = btn.Top;
        }

        private void btnSideList_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideList);
        }

        private void btnSideSearch_Click(object sender, EventArgs e)
        {
            viewSideBar(btnSideSearch);
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            viewSideBar(btnAuthor);
        }
    }
}
