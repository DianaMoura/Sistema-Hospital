using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Login (USERNAME,PASSWORD) VALUES (@USERNAME,@PASSWORD)", con);
            cmd.Parameters.AddWithValue("@USERNAME", textBoxLogin.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", textBoxSenha.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBoxLogin.Text = "";
            textBoxSenha.Text = "";
           


            MessageBox.Show("Cadastro Efetuado Com Sucesso!!");





        }

        private void button1_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            string query = "select * from Login where USERNAME ='" + textBoxLogin.Text + "' and PASSWORD = '" + textBoxSenha.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                frmConsultas frm = new frmConsultas();
                this.Hide();
                frm.Show();

            }
            else 
            {


                MessageBox.Show("Login Ou Senha Incorretos");
            
            }

            
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}