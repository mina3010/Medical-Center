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
    public partial class Start_page : Form
    {
        public Start_page()
        {
            InitializeComponent();
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


        private void Start_page_Load(object sender, EventArgs e)
        {
           
        }

        private void Login_but_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void book_Click(object sender, EventArgs e)
        {
            developer s = new developer();
            s.ShowDialog();
        }

        ////private void Login_Click(object sender, EventArgs e)
        ////{
        ////    Login frm =new Login();
        ////    frm.Show();
        ////}

        //private void bunifuImageButton1_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}
    }

}
