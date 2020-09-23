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

    public partial class DataPatient : Form
    {
        OleDbConnection con = new OleDbConnection();
        public DataPatient()
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

        private void showData_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataPatient_Load(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                string query = "select * from Doctor";
                command.CommandText = query;

                OleDbDataAdapter show = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                show.Fill(dt);
                dataGridView1.DataSource = dt;
   
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

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refresh_but_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DataPatient().ShowDialog();
            this.Close();
        }
    }
}
