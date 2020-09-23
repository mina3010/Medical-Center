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
    public partial class DeleteDataPatient : Form
    {
        OleDbConnection con = new OleDbConnection();

        public DeleteDataPatient()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Mina\Desktop\New folder (2)\medical.mdb; Jet OLEDB:Database Password =1234";


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
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        //try
        //    {
        //        con.Open();
        //        OleDbCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "delete from Doctor where phone='" + number1_text.Text + "'";
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Delete done! ");
        //        number1_text.Clear();
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("x ");
        //    }
        //    finally
        //    {
        //        if (con.State == ConnectionState.Open)
        //            con.Close();
        //    }
        private void cancel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                if (number1_text.Text != ""&& number1_text.TextLength == 11)
                {


                    command.CommandText = "delete from Doctor where phone='" + number1_text.Text + "'";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Delete done! ");
                    number1_text.Clear();
                    // MessageBox.Show("this number is not exist! ");


                }
                else
                {
                    MessageBox.Show("please enter patient is phone number correct at first! ");
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("this number is not exist! ");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void number1_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (!Char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Invalid Number!");
            }
        }
    }
}
