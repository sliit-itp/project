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

namespace WindowsFormsApp3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            //creating thread
            Thread thread = new Thread(new ThreadStart(splash));
            // startt the thread
            thread.Start();
            //direct thread to waiting queue 
            Thread.Sleep(10555);

            InitializeComponent();

            //code

            // close the thread
            thread.Abort();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //checking inputs from perpheral devices
            //checking inserts
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
        }

        public void OnKeyDownHandler(object sender, KeyEventArgs key) {
            //check inputed key is  'Enter'
            if (key.KeyCode == Keys.Enter) {
                loginHandler();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginHandler();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Close The Aplication?","Exit",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (DR == DialogResult.OK) Application.Exit();
        }

        private void loginHandler() {
            string username = txtUserName.Text;
            string password = txtPassword.Text; 
            if (username == "ABC" && password == "abc") {             
                BookingForm BF = new BookingForm();
                BF.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong User Name Or Password","Invalid !",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void splash() {
            // run the splash
            Application.Run(new SplashForm());
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
