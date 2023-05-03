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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testeDataSet.testetb' table. You can move, or remove it, as needed.
            this.testetbTableAdapter.Fill(this.testeDataSet.testetb);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            //string cnnString, sqlUpdate;
            //SqlConnection cnn;
            //SqlCommand UpdateCommand;
            
            //cnnString = @"Data Source=localhost\SQLEXPRESS; Initical Catalog=Teste;
            //User ID=sa;Password=SQLEXPRESS";

            //cnn = new SqlConnection(cnnString);

            //sqlUpdate = $""
            


            
        }
    }
}
