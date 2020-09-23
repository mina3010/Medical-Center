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
    public partial class assistantForm : Form
    {

        OleDbConnection con = new OleDbConnection();
        public assistantForm()
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

        private void assistantForm_Load(object sender, EventArgs e)
        {

            ID_text.ReadOnly = true;
            box1.Items.Clear();

            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from Assistant";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    box1.Items.Add( reader["patien_name"].ToString());

                    
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Happen! ");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

       

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void book_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                if ( name_text.Text != "" && age_text.Text != "" && number_text.Text != "" && address_text.Text != "" )
                {
                    if (number_text.TextLength == 11)
                    {
                        string s = "insert into Assistant (patien_name,patient_age,phone,patient_address,patient_email,booking_date)" +
                                     "values('" + name_text.Text + "','" + age_text.Text + "','" + number_text.Text + "','" + address_text.Text + "','" + email_text.Text + "','" + date_text.Text + "')";
                        command.CommandText = s;
                        command.ExecuteNonQuery();
                        MessageBox.Show("booking done! ");
                        name_text.Clear();
                        age_text.Clear();
                        number_text.Clear();
                        address_text.Clear();
                        email_text.Clear();
                    }
                    else
                    {
                        MessageBox.Show("phone number is not correct, mobile phone number should be 11 number! ");
                    }
                }
                else
                {
                    MessageBox.Show(" data not complete, please complete main data! ");
                }
               
                box1.Items.Clear();
                con.Close();

                try
                {
                    con.Open();
                    command.Connection = con;
                    string query = "select * from Assistant";

                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        box1.Items.Add(reader["patien_name"].ToString());   
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Happen! ");
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" this ID is already Booken ");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

}


        private void box1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from Assistant where patien_name='"+box1.Text+"'";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID_text.Text = reader["ID"].ToString();
                    name_text.Text = reader["patien_name"].ToString();
                    age_text.Text = reader["patient_age"].ToString();
                    number_text.Text = reader["phone"].ToString();
                    address_text.Text = reader["patient_address"].ToString();
                    email_text.Text = reader["patient_email"].ToString();
                    date_text.Text = reader["booking_date"].ToString();


                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Happen! ");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            
            cancelForm a = new cancelForm();
            a.Show();

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







        private void addNew_Click(object sender, EventArgs e)
        {



        }

        private void box1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ID_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ADD_NEW_Click(object sender, EventArgs e)
        {
            name_text.Clear();
            age_text.Clear();
            number_text.Clear();
            address_text.Clear();
            email_text.Clear();
        }

        private void Refresh_but_Click(object sender, EventArgs e)
        {
            this.Hide();
            new assistantForm().ShowDialog();
            this.Close();
        }

        private void age_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (!Char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Invalid Number!");
            }
        }

        private void number_text_KeyPress(object sender, KeyPressEventArgs e)
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
