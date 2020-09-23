using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace medical
{
    public partial class Login : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Login()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Mina\Desktop\New folder (2)\medical.mdb; Jet OLEDB:Database Password =1234";

            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Mina\Desktop\New folder (2)\medical.mdb; Jet OLEDB:Database Password =1234";
                connection.Open();
                checkConnection.Text = "successful connection! ";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connection Happen!" + ex);
            }
        }



        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select * from LOGIN where username='" + username_but.Text + "' and password='" + password_but.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();

               

                
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Ussername and Password is Correct! ");

                    mainPage frm3 = new mainPage();
                    frm3.Show();
                    Close();


                   
                }
                else if (count > 1)
                {

                    MessageBox.Show("Ussername and Password is Daplicate! ");
                    username_but.Clear();
                    password_but.Clear();
                }
                else
                { 
                    MessageBox.Show("Ussername and Password is not Correct! ");
                    username_but.Clear();
                    password_but.Clear();
                }    
                
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Happen!");
            }





        }

        private void Login_Load(object sender, EventArgs e)
        {

           
        }

        private void bunifuThinButton21_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void password_but_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void password_but_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
