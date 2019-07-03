using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BookingUI : UserControl
    {
        public BookingUI()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookingUI_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Slider.Left = btnNew.Left;
            bookingUINew1.BringToFront();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Slider.Left = btnEdit.Left;
            bookingUIEdit1.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Slider.Left = btnView.Left;
            bookingUIView1.BringToFront();
        }

        private void bookingUIEditUser1_Load(object sender, EventArgs e)
        {

        }
    }
   }
           