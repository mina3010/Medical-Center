using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void assistant_but_Click(object sender, EventArgs e)
        {
            assistantForm f = new assistantForm();
            f.Show();
        }

        private void doctor_but_Click(object sender, EventArgs e)
        {
            Doctor f2 = new Doctor();
            f2.Show();
        }
        int mov = 0;
        int movX;
        int movY;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Normal)
            //{
            //    WindowState = FormWindowState.Maximized;
            //}
            //else
            //    WindowState = FormWindowState.Normal;
        }
    }
}
