namespace Login
{
    partial class frmMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNomeMedico = new System.Windows.Forms.Label();
            this.labelCRM = new System.Windows.Forms.Label();
            this.textBoxCRM = new System.Windows.Forms.TextBox();
            this.textBoxNomeMedico = new System.Windows.Forms.TextBox();
            this.dataGridViewCadastroMedico = new System.Windows.Forms.DataGridView();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEspecialidade = new System.Windows.Forms.TextBox();
            this.label3Telefone = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBox1CodigoNew = new System.Windows.Forms.TextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastroMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(17, 64);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(52, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "CÓDIGO:";
            // 
            // labelNomeMedico
            // 
            this.labelNomeMedico.AutoSize = true;
            this.labelNomeMedico.Location = new System.Drawing.Point(17, 104);
            this.labelNomeMedico.Name = "labelNomeMedico";
            this.labelNomeMedico.Size = new System.Drawing.Size(106, 13);
            this.labelNomeMedico.TabIndex = 1;
            this.labelNomeMedico.Text = "NOME DO MÉDICO:";
            this.labelNomeMedico.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCRM
            // 
            this.labelCRM.AutoSize = true;
            this.labelCRM.Location = new System.Drawing.Point(285, 132);
            this.labelCRM.Name = "labelCRM";
            this.labelCRM.Size = new System.Drawing.Size(34, 13);
            this.labelCRM.TabIndex = 2;
            this.labelCRM.Text = "CRM:";
            // 
            // textBoxCRM
            // 
            this.textBoxCRM.Location = new System.Drawing.Point(316, 129);
            this.textBoxCRM.Name = "textBoxCRM";
            this.textBoxCRM.Size = new System.Drawing.Size(119, 20);
            this.textBoxCRM.TabIndex = 4;
            // 
            // textBoxNomeMedico
            // 
            this.textBoxNomeMedico.Location = new System.Drawing.Point(129, 100);
            this.textBoxNomeMedico.Name = "textBoxNomeMedico";
            this.textBoxNomeMedico.Size = new System.Drawing.Size(580, 20);
            this.textBoxNomeMedico.TabIndex = 5;
            this.textBoxNomeMedico.TextChanged += new System.EventHandler(this.textBoxNomeMedico_TextChanged);
            // 
            // dataGridViewCadastroMedico
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCadastroMedico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCadastroMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCadastroMedico.Location = new System.Drawing.Point(12, 286);
            this.dataGridViewCadastroMedico.MultiSelect = false;
            this.dataGridViewCadastroMedico.Name = "dataGridViewCadastroMedico";
            this.dataGridViewCadastroMedico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCadastroMedico.Size = new System.Drawing.Size(830, 186);
            this.dataGridViewCadastroMedico.TabIndex = 6;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(743, 94);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(99, 23);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "CADASTRAR";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(743, 123);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(99, 23);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(743, 152);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(99, 23);
            this.buttonDeletar.TabIndex = 9;
            this.buttonDeletar.Text = "DELETAR";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(743, 181);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(99, 23);
            this.buttonPesquisar.TabIndex = 10;
            this.buttonPesquisar.Text = "PESQUISAR";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ESPECIALIDADE:";
            // 
            // textBoxEspecialidade
            // 
            this.textBoxEspecialidade.Location = new System.Drawing.Point(534, 129);
            this.textBoxEspecialidade.Name = "textBoxEspecialidade";
            this.textBoxEspecialidade.Size = new System.Drawing.Size(172, 20);
            this.textBoxEspecialidade.TabIndex = 13;
            // 
            // label3Telefone
            // 
            this.label3Telefone.AutoSize = true;
            this.label3Telefone.Location = new System.Drawing.Point(17, 132);
            this.label3Telefone.Name = "label3Telefone";
            this.label3Telefone.Size = new System.Drawing.Size(66, 13);
            this.label3Telefone.TabIndex = 14;
            this.label3Telefone.Text = "TELEFONE:";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(80, 129);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(199, 20);
            this.textBoxTelefone.TabIndex = 15;
            // 
            // textBox1CodigoNew
            // 
            this.textBox1CodigoNew.Location = new System.Drawing.Point(75, 61);
            this.textBox1CodigoNew.Name = "textBox1CodigoNew";
            this.textBox1CodigoNew.ReadOnly = true;
            this.textBox1CodigoNew.Size = new System.Drawing.Size(73, 20);
            this.textBox1CodigoNew.TabIndex = 16;
            this.textBox1CodigoNew.TextChanged += new System.EventHandler(this.textBox1CodigoNew_TextChanged);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(743, 248);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(99, 23);
            this.buttonFechar.TabIndex = 18;
            this.buttonFechar.Text = "FECHAR";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(848, 492);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.textBox1CodigoNew);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.label3Telefone);
            this.Controls.Add(this.textBoxEspecialidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataGridViewCadastroMedico);
            this.Controls.Add(this.textBoxNomeMedico);
            this.Controls.Add(this.textBoxCRM);
            this.Controls.Add(this.labelCRM);
            this.Controls.Add(this.labelNomeMedico);
            this.Controls.Add(this.labelCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE MÉDICOS";
            this.Load += new System.EventHandler(this.frmMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadastroMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNomeMedico;
        private System.Windows.Forms.Label labelCRM;
        private System.Windows.Forms.TextBox textBoxCRM;
        private System.Windows.Forms.TextBox textBoxNomeMedico;
        private System.Windows.Forms.DataGridView dataGridViewCadastroMedico;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEspecialidade;
        private System.Windows.Forms.Label label3Telefone;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBox1CodigoNew;
        private System.Windows.Forms.Button buttonFechar;
    }
}