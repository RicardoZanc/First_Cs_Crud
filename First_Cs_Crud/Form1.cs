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

            connectionString = @"Data Source=DESKTOP-55KAS32\SQLEXPRESS; Initial Catalog=Teste;
              User ID=sa;Password=SQLEXPRESS";

            cnn = new SqlConnection(connectionString);

            cnn.Open();
                     
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            //sql = "Select TutorialId, TutorialName  from testetb";

            command = new SqlCommand("Select TutorialId, TutorialName  from testetb", cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read()) 
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }
    }
}
