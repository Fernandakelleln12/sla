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

namespace sla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //string name = txbnome.Text;
            //string enrollment =txbSenha.Text;


            //string message = "Nome:" + name +
            //    "\nMatrícula:" + enrollment;

            //MessageBox.Show(
            //    "Agora você está na nossa plataforma!",
            //    "Olá seja bem vindo(a)!!",
            //    MessageBoxButtons.OK,
            //  MessageBoxIcon.Information);
        }

        private void txbsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btmenssage_Click(object sender, EventArgs e)
        {
            conect conect = new conect();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = conect.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO usuario VALUES
            (@nome,@senha)";

            sqlCommand.Parameters.AddWithValue("@nome", txbnome.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbSenha.Text);

            sqlCommand.ExecuteNonQuery();
        }
    }
}
