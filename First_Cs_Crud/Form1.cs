using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Cs_Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=Teste;
              User ID=sa;Password=SQLEXPRESS";

            cnn = new SqlConnection(connectionString);

            cnn.Open();
            MessageBox.Show("Connection Open ! ");
            cnn.Close();
        }
    }
}
