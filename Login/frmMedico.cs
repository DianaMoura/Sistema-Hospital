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
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {




            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Medico", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCadastroMedico.DataSource = dt;







        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Medico (NOMEMEDICO,ESPECIALIDADE,CRM) VALUES (@NOMEMEDICO,@ESPECIALIDADE,@CRM)", con);
            
            cmd.Parameters.AddWithValue("@NOMEMEDICO", textBoxNomeMedico.Text);
            cmd.Parameters.AddWithValue("@ESPECIALIDADE", textBoxEspecialidade.Text);
            cmd.Parameters.AddWithValue("@CRM", textBoxCRM.Text);
            cmd.ExecuteNonQuery();
            con.Close();

           
            textBoxNomeMedico.Text = "";
            textBoxEspecialidade.Text = "";
            textBoxCRM.Text = "";
            




            MessageBox.Show("Cadastrado Com Sucesso!");




        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {




            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Medico SET NOMEMEDICO=@NOMEMEDICO,ESPECIALIDADE=@ESPECIALIDADE,CRM=@CRM WHERE IDMEDICO=@IDMEDICO ", con);
            cmd.Parameters.AddWithValue("@IDMEDICO", int.Parse(textBox1CodigoNew.Text));
            cmd.Parameters.AddWithValue("@NOMEMEDICO", textBoxNomeMedico.Text);
            cmd.Parameters.AddWithValue("@ESPECIALIDADE", textBoxEspecialidade.Text);
            cmd.Parameters.AddWithValue("@CRM", textBoxCRM.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1CodigoNew.Text = "";
            textBoxNomeMedico.Text = "";
            textBoxEspecialidade.Text = "";
            textBoxCRM.Text = "";
           
          
          

            MessageBox.Show("Alterado Com Sucesso!");









        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Medico WHERE IDMEDICO=@IDMEDICO", con);
            cmd.Parameters.AddWithValue("@IDMEDICO", int.Parse(textBox1CodigoNew.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1CodigoNew.Text = "";


            MessageBox.Show("Médico Deletado Com Sucesso!");



        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Medico WHERE IDMEDICO=@IDMEDICO", con);
            cmd.Parameters.AddWithValue("@IDMEDICO", int.Parse(textBox1CodigoNew.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewCadastroMedico.DataSource = dt;


        }

        private void textBox1CodigoNew_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxNomeMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
