using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace principal
{
    public partial class SplashScreen : Form
    {
        private int loadingTime;

        public SplashScreen()
        {
            InitializeComponent();
        }

        public SplashScreen(int loadingTime)
        {
            this.loadingTime = loadingTime;
            InitializeComponent();
        }

        public void AddValueToProgressBar() 
        {
            if (LoadingProgressBar.Value < 100)
            {
                LoadingProgressBar.Value++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
