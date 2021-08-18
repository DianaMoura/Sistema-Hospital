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
    public partial class frmMenuConsulta : Form
    {
        public frmMenuConsulta()
        {
            InitializeComponent();
        }

        private void frmMenuConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet2.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.consultorioDataSet2.Paciente);
            // TODO: This line of code loads data into the 'consultorioDataSet1.Medico' table. You can move, or remove it, as needed.
            this.medicoTableAdapter.Fill(this.consultorioDataSet1.Medico);

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {




            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Consulta (IDMEDICO,IDPACIENTE,DATACONSULTA,HORAINICIO,HORAFIM,OBSERVACOES) VALUES (@IDMEDICO,@IDPACIENTE,@DATACONSULTA,@HORAINICIO,@HORAFIM,@OBSERVACOES)", con);



            cmd.Parameters.AddWithValue("@IDMEDICO", comboBoxIDMedico.Text);
            cmd.Parameters.AddWithValue("@IDPACIENTE", comboBoxIDPaciente.Text);
            cmd.Parameters.AddWithValue("@DATACONSULTA", dateTimePickerDataCOnsulta.Text);
            cmd.Parameters.AddWithValue("@HORAINICIO", maskedTextBoxHoraFim.Text);
            cmd.Parameters.AddWithValue("@HORAFIM", maskedTextBoxHoraInicio.Text);
            cmd.Parameters.AddWithValue("@OBSERVACOES", textBoxObservacoes.Text);
            cmd.ExecuteNonQuery();
            con.Close();


            comboBoxIDMedico.Text = "";
            comboBoxIDPaciente.Text = "";
            dateTimePickerDataCOnsulta.Text = "";
            maskedTextBoxHoraInicio.Text = "";
            maskedTextBoxHoraFim.Text = "";
            textBoxObservacoes.Text = "";





            MessageBox.Show("Cadastrado Com Sucesso!");





        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("UPDATE Consulta SET IDMEDICO=@IDMEDICO,IDPACIENTE=@IDPACIENTE,DATACONSULTA=@DATACONSULTA,HORAINICIO=@HORAINICIO,HORAFIM=@HORAFIM,OBSERVACOES=@OBSERVACOES WHERE IDCONSULTA=@IDCONSULTA", con);

            cmd.Parameters.AddWithValue("@IDCONSULTA", textBoxIDConsulta.Text);
            cmd.Parameters.AddWithValue("@IDMEDICO", comboBoxIDMedico.Text);
            cmd.Parameters.AddWithValue("@IDPACIENTE", comboBoxIDPaciente.Text);
            cmd.Parameters.AddWithValue("@DATACONSULTA", dateTimePickerDataCOnsulta.Text);
            cmd.Parameters.AddWithValue("@HORAINICIO", maskedTextBoxHoraInicio.Text);
            cmd.Parameters.AddWithValue("@HORAFIM", maskedTextBoxHoraFim.Text);
            cmd.Parameters.AddWithValue("@OBSERVACOES", textBoxObservacoes.Text);
            cmd.ExecuteNonQuery();
            con.Close();


            textBoxIDConsulta.Text = "";
            comboBoxIDMedico.Text = "";
            comboBoxIDPaciente.Text = "";
            dateTimePickerDataCOnsulta.Text = "";
            maskedTextBoxHoraInicio.Text = "";
            maskedTextBoxHoraFim.Text = "";
            textBoxObservacoes.Text = "";




            MessageBox.Show("Alterado Com Sucesso!");



        }

        private void dateTimePickerDataCOnsulta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {




            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=Consultorio;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Consulta WHERE IDCONSULTA=@IDCONSULTA", con);
            cmd.Parameters.AddWithValue("@IDCONSULTA", textBoxIDConsulta.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBoxIDConsulta.Text = "";


            MessageBox.Show("Consulta Deletado!");







        }
    }
}
