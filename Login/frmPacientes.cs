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
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {





            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Paciente (VALIDADECARTEIRINHA,DATANASCIMENTO,NOMEPACIENTE,SOBRENOME,GENERO,ENDERECO,UFRG,EMAIL,TELEFONE,CONVENIO,NOMEMEDICO) VALUES (@VALIDADECARTEIRINHA,@DATANASCIMENTO,@NOMEPACIENTE,@SOBRENOME,@GENERO,@ENDERECO,@UFRG,@EMAIL,@TELEFONE,@CONVENIO,@NOMEMEDICO)", con);

            cmd.Parameters.AddWithValue("@NOMEPACIENTE", textBoxNome.Text);
            cmd.Parameters.AddWithValue("@SOBRENOME", textBoxSobrenome.Text);
            cmd.Parameters.AddWithValue("@GENERO", comboBoxGenero.Text);
            cmd.Parameters.AddWithValue("@ENDERECO", textBoxEndereco.Text);
            cmd.Parameters.AddWithValue("@UFRG", textBoxUFRG.Text);
            cmd.Parameters.AddWithValue("@EMAIL", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@TELEFONE", textBoxTelefone.Text);
            cmd.Parameters.AddWithValue("@CONVENIO", comboBoxConvenio.Text);
            cmd.Parameters.AddWithValue("@NOMEMEDICO", textBoxNomeMedico.Text);
            cmd.Parameters.AddWithValue("@DATANASCIMENTO", dateTimePickerDataNascimento.Text);
            cmd.Parameters.AddWithValue("@VALIDADECARTEIRINHA", dateTimePickerValidadeCarteirinha.Text);
            cmd.ExecuteNonQuery();
            con.Close();


            dateTimePickerValidadeCarteirinha.Text = "";
            dateTimePickerDataNascimento.Text ="";
            textBoxNome.Text = "";
            textBoxSobrenome.Text = "";
            comboBoxGenero.Text = "";
            textBoxEndereco.Text = "";
            textBoxUFRG.Text = "";
            textBoxEmail.Text = "";
            textBoxTelefone.Text = "";
            comboBoxConvenio.Text = "";
            textBoxNomeMedico.Text = "";


            


            MessageBox.Show("Cadastrado Com Sucesso!");






        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Paciente SET DATANASCIMENTO=@DATANASCIMENTO,NOMEPACIENTE=@NOMEPACIENTE,SOBRENOME=@SOBRENOME,GENERO=@GENERO,ENDERECO=@ENDERECO,UFRG=@UFRG,EMAIL=@EMAIL,TELEFONE=@TELEFONE,CONVENIO=@CONVENIO,NOMEMEDICO=@NOMEMEDICO,VALIDADECARTEIRINHA=@VALIDADECARTEIRINHA WHERE NOMEPACIENTE=@NOMEPACIENTE", con);
            
            cmd.Parameters.AddWithValue("@NOMEPACIENTE", textBoxNome.Text);
            cmd.Parameters.AddWithValue("@SOBRENOME", textBoxSobrenome.Text);
            cmd.Parameters.AddWithValue("@GENERO", comboBoxGenero.Text);
            cmd.Parameters.AddWithValue("@UFRG", textBoxUFRG.Text);
            cmd.Parameters.AddWithValue("@EMAIL", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@TELEFONE", textBoxTelefone.Text);
            cmd.Parameters.AddWithValue("@CONVENIO", comboBoxConvenio.Text);
            cmd.Parameters.AddWithValue("@NOMEMEDICO", textBoxNomeMedico.Text);
            cmd.Parameters.AddWithValue("@ENDERECO", textBoxEndereco.Text);
            cmd.Parameters.AddWithValue("@VALIDADECARTEIRINHA", dateTimePickerValidadeCarteirinha.Text);
            cmd.Parameters.AddWithValue("@DATANASCIMENTO", dateTimePickerDataNascimento.Text);
           
            cmd.ExecuteNonQuery();
            con.Close();

            dateTimePickerDataNascimento.Text = "";
            dateTimePickerValidadeCarteirinha.Text = "";
            textBoxCodigo.Text =""; 
            textBoxNome.Text = "";
            textBoxSobrenome.Text = "";
            comboBoxGenero.Text = "";
            textBoxUFRG.Text = "";
            textBoxEmail.Text = "";
            textBoxTelefone.Text = "";
            comboBoxConvenio.Text = "";
            textBoxNomeMedico.Text = "";
            textBoxEndereco.Text = "";
            



            MessageBox.Show("Alterado Com Sucesso!");






        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Paciente WHERE IDPACIENTE=@IDPACIENTE", con);
            cmd.Parameters.AddWithValue("@IDPACIENTE", int.Parse(textBoxCodigo.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            textBoxCodigo.Text = "";


            MessageBox.Show("Deletado Com Sucesso!");






        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {





            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Paciente", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPaciente.DataSource = dt;







        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {




            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Paciente WHERE NOMEPACIENTE=@NOMEPACIENTE", con);

            cmd.Parameters.AddWithValue("@NOMEPACIENTE", textBoxNome.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPaciente.DataSource = dt;



        }

        private void labelXP_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
