using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class SimpleBrowser : Form
    {
        public SimpleBrowser()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Button that Change Page Home.
            wb.Navigate("www.google.com");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string address = tbSiteAddress.ToString();
            wb.Navigate(address);
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            wb.GoBack();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wb.Refresh();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            wb.GoForward();
        }
    }
}
