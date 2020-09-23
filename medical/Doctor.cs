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
    public partial class Doctor : Form
    {

        OleDbConnection con = new OleDbConnection();
        public Doctor()
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
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from Doctor";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    comboBox1.Items.Add(reader["name"].ToString());


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

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;

                if (name_text.Text != "" && statue_text.Text!=""&& phoneNumber_text.Text!="") {
                    if (phoneNumber_text.TextLength == 11)
                    {

                        string s = "insert into Doctor (doctor_ID,name,statue,phone,amount_of_medicine)" +
                                 "values('" + ID_text.Text + "','" + name_text.Text + "','" + statue_text.Text + "','" + phoneNumber_text.Text + "','" + AmountOfMedicine_txt.Text + "')";
                        command.CommandText = s;
                        command.ExecuteNonQuery();
                        MessageBox.Show("ADD is done! ");
                        ID_text.Clear();
                        name_text.Clear();
                        statue_text.Clear();
                        AmountOfMedicine_txt.Clear();
                        phoneNumber_text.Clear();
                    }
                    else
                    {
                        MessageBox.Show("phone number is not correct, mobile phone number should be 11 number! ");
                    }
                }
                else
                {
                    MessageBox.Show(" data not complete, please complete it ");
                }



                comboBox1.Items.Clear();

                con.Close();

                try
                {
                    con.Open();
                   
                    command.Connection = con;
                    string query = "select * from Doctor";

                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                            
                            comboBox1.Items.Add( reader["name"].ToString());
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
                MessageBox.Show(" patient number already exist! ");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteDataPatient d = new DeleteDataPatient();
            d.Show();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            DataPatient s = new DataPatient();
            s.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from Doctor where name='" + comboBox1.Text + "'";

                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID_text.Text = reader["doctor_ID"].ToString();
                    name_text.Text = reader["name"].ToString();
                    statue_text.Text = reader["statue"].ToString();
                    AmountOfMedicine_txt.Text = reader["amount_of_medicine"].ToString();
                    phoneNumber_text.Text = reader["phone"].ToString();
                   

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

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;                
                    command.CommandText = "delete from Doctor where phone='" + phoneNumber_text.Text + "'";
                    command.ExecuteNonQuery();
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
            try
            {
                con.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;

                if (name_text.Text != "" && statue_text.Text != "" && phoneNumber_text.Text != "")
                {
                    string s = "insert into Doctor (doctor_ID,name,statue,phone,amount_of_medicine)" +
                                 "values('" + ID_text.Text + "','" + name_text.Text + "','" + statue_text.Text + "','" + phoneNumber_text.Text + "','" + AmountOfMedicine_txt.Text + "')";
                    //MessageBox.Show(s);
                    command.CommandText = s;
                    command.ExecuteNonQuery();
                    MessageBox.Show("update is done! ");
                    ID_text.Clear();
                    name_text.Clear();
                    statue_text.Clear();
                    AmountOfMedicine_txt.Clear();
                    phoneNumber_text.Clear();
                }
                else
                {
                    MessageBox.Show(" data not complete, please complete it ");
                }



                comboBox1.Items.Clear();

                con.Close();

                try
                {
                    con.Open();
                    //OleDbCommand command = new OleDbCommand();
                    command.Connection = con;
                    string query = "select * from Doctor";

                    command.CommandText = query;
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        comboBox1.Items.Add(reader["name"].ToString());

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
                MessageBox.Show(" patient number already exist! ");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        private void ADD_NEW_Click(object sender, EventArgs e)
        {
            ID_text.Clear();
            name_text.Clear();
            statue_text.Clear();
            AmountOfMedicine_txt.Clear();
            phoneNumber_text.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Doctor().ShowDialog();
            this.Close();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phoneNumber_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if (!Char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
                MessageBox.Show("Invalid Number!");
            }
        }

        private void ID_text_KeyPress(object sender, KeyPressEventArgs e)
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
