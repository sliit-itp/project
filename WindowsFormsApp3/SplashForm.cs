using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        //import Gdi32.dll
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftrect, // x upper left corner
            int nTopRect, // y upper left corner
            int nRightRECT, // x lower right corner
            int nBotttomRect, // y lower right corner
            int nWidthEllipse, // height f ellipse
            int nHeightEliipse // width of ellipse
            );     
        
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void lblversion_Click(object sender, EventArgs e)
        {
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //set version info
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.lblVersion.Text = String.Format(this.lblVersion.Text, version.Major, version.Minor, version.Build, version.Revision);

            //set copyright info
            string copyright;
            Assembly asm = Assembly.GetExecutingAssembly();
            copyright = ((AssemblyCopyrightAttribute)asm.GetCustomAttribute(typeof(AssemblyCopyrightAttribute))).Copyright;
            this.lblCopyright.Text = copyright;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value ++;
            if (progressBar.Value == 100)
            {
               timer1.Stop();
               LoginForm loginForm = new LoginForm();
               loginForm.Show();
               this.Hide();
            }
            
        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {

        }
    }
}
