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

namespace login
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\Documents\login.accdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                connection.Open();
                label1.Text = "connection Succesful";
                connection.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gb_login_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Table1 where UserName='"+ txt_username.Text + "'and Password='"+ txt_password .Text+ "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {
                count = count + 1;
            }
            if(count == 1)
            {
                MessageBox.Show("correct");
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate");
            }
            else
            {
                MessageBox.Show("incorrect");
            }
            connection.Close();
        }
    }
}
