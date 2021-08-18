using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Login
{
    public partial class frmConsultas : Form
    {
        private Form frmAtivo;

        public frmConsultas()
        {
            InitializeComponent();
        }

       
 

      



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            
  
        
        }



        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void buttonCadastroPaciente_Click(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void buttonCadastroMedico_Click(object sender, EventArgs e)
        {
            frmMedico medico = new frmMedico();
            medico.ShowDialog();
           

             


       }
      
      
        
   

        private void buttonCadastroPaciente_Click_1(object sender, EventArgs e)
        {
            frmPacientes p = new frmPacientes();
            p.ShowDialog();



        }

        private void label1_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSairPrincipalMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            frmMenuConsulta fm = new frmMenuConsulta();
            fm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxImgCentral_Click(object sender, EventArgs e)
        {

        }
    }
}
