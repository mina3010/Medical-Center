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
    public partial class developer : Form
    {
        public developer()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gmial_ReadOnlyChanged(object sender, EventArgs e)
        {
            
        }

        private void Gmial_TextChanged(object sender, EventArgs e)
        {

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
        private void developer_Load(object sender, EventArgs e)
        {

        }
    }
}
