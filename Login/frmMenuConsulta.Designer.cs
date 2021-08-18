namespace Login
{
    partial class frmMenuConsulta
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
            this.components = new System.ComponentModel.Container();
            this.labelIDConsulta = new System.Windows.Forms.Label();
            this.frmIDMedico = new System.Windows.Forms.Label();
            this.IdPaciente = new System.Windows.Forms.Label();
            this.labelDataConsulta = new System.Windows.Forms.Label();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelHoraFim = new System.Windows.Forms.Label();
            this.labelObservacoes = new System.Windows.Forms.Label();
            this.comboBoxIDMedico = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorioDataSet1 = new Login.ConsultorioDataSet1();
            this.comboBoxIDPaciente = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorioDataSet2 = new Login.ConsultorioDataSet2();
            this.dateTimePickerDataCOnsulta = new System.Windows.Forms.DateTimePicker();
            this.textBoxObservacoes = new System.Windows.Forms.TextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonDeletar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.textBoxIDConsulta = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultorioDataSet = new Login.ConsultorioDataSet();
            this.consultorioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter = new Login.ConsultorioDataSet1TableAdapters.MedicoTableAdapter();
            this.pacienteTableAdapter = new Login.ConsultorioDataSet2TableAdapters.PacienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDConsulta
            // 
            this.labelIDConsulta.AutoSize = true;
            this.labelIDConsulta.Location = new System.Drawing.Point(22, 61);
            this.labelIDConsulta.Name = "labelIDConsulta";
            this.labelIDConsulta.Size = new System.Drawing.Size(79, 13);
            this.labelIDConsulta.TabIndex = 0;
            this.labelIDConsulta.Text = "IDCONSULTA:";
            // 
            // frmIDMedico
            // 
            this.frmIDMedico.AutoSize = true;
            this.frmIDMedico.Location = new System.Drawing.Point(22, 92);
            this.frmIDMedico.Name = "frmIDMedico";
            this.frmIDMedico.Size = new System.Drawing.Size(63, 13);
            this.frmIDMedico.TabIndex = 1;
            this.frmIDMedico.Text = "IDMEDICO:";
            // 
            // IdPaciente
            // 
            this.IdPaciente.AutoSize = true;
            this.IdPaciente.Location = new System.Drawing.Point(22, 125);
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.Size = new System.Drawing.Size(71, 13);
            this.IdPaciente.TabIndex = 2;
            this.IdPaciente.Text = "IDPACIENTE";
            // 
            // labelDataConsulta
            // 
            this.labelDataConsulta.AutoSize = true;
            this.labelDataConsulta.Location = new System.Drawing.Point(22, 153);
            this.labelDataConsulta.Name = "labelDataConsulta";
            this.labelDataConsulta.Size = new System.Drawing.Size(100, 13);
            this.labelDataConsulta.TabIndex = 3;
            this.labelDataConsulta.Text = "DATA CONSULTA:";
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.Location = new System.Drawing.Point(22, 184);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(73, 13);
            this.labelHoraInicio.TabIndex = 4;
            this.labelHoraInicio.Text = "HORAINICIO:";
            // 
            // labelHoraFim
            // 
            this.labelHoraFim.AutoSize = true;
            this.labelHoraFim.Location = new System.Drawing.Point(22, 213);
            this.labelHoraFim.Name = "labelHoraFim";
            this.labelHoraFim.Size = new System.Drawing.Size(59, 13);
            this.labelHoraFim.TabIndex = 5;
            this.labelHoraFim.Text = "HORAFIM:";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.Location = new System.Drawing.Point(22, 245);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(90, 13);
            this.labelObservacoes.TabIndex = 6;
            this.labelObservacoes.Text = "OBSERVAÇÕES:";
            // 
            // comboBoxIDMedico
            // 
            this.comboBoxIDMedico.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicoBindingSource, "IDMEDICO", true));
            this.comboBoxIDMedico.DataSource = this.medicoBindingSource;
            this.comboBoxIDMedico.DisplayMember = "IDMEDICO";
            this.comboBoxIDMedico.FormattingEnabled = true;
            this.comboBoxIDMedico.Location = new System.Drawing.Point(99, 89);
            this.comboBoxIDMedico.Name = "comboBoxIDMedico";
            this.comboBoxIDMedico.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDMedico.TabIndex = 8;
            this.comboBoxIDMedico.ValueMember = "IDMEDICO";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.consultorioDataSet1;
            // 
            // consultorioDataSet1
            // 
            this.consultorioDataSet1.DataSetName = "ConsultorioDataSet1";
            this.consultorioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxIDPaciente
            // 
            this.comboBoxIDPaciente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pacienteBindingSource, "IDPACIENTE", true));
            this.comboBoxIDPaciente.DataSource = this.pacienteBindingSource;
            this.comboBoxIDPaciente.DisplayMember = "IDPACIENTE";
            this.comboBoxIDPaciente.FormattingEnabled = true;
            this.comboBoxIDPaciente.Location = new System.Drawing.Point(99, 117);
            this.comboBoxIDPaciente.Name = "comboBoxIDPaciente";
            this.comboBoxIDPaciente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIDPaciente.TabIndex = 9;
            this.comboBoxIDPaciente.ValueMember = "IDPACIENTE";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultorioDataSet2;
            // 
            // consultorioDataSet2
            // 
            this.consultorioDataSet2.DataSetName = "ConsultorioDataSet2";
            this.consultorioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerDataCOnsulta
            // 
            this.dateTimePickerDataCOnsulta.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDataCOnsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataCOnsulta.Location = new System.Drawing.Point(125, 153);
            this.dateTimePickerDataCOnsulta.Name = "dateTimePickerDataCOnsulta";
            this.dateTimePickerDataCOnsulta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataCOnsulta.TabIndex = 10;
            this.dateTimePickerDataCOnsulta.ValueChanged += new System.EventHandler(this.dateTimePickerDataCOnsulta_ValueChanged);
            // 
            // textBoxObservacoes
            // 
            this.textBoxObservacoes.Location = new System.Drawing.Point(12, 301);
            this.textBoxObservacoes.Multiline = true;
            this.textBoxObservacoes.Name = "textBoxObservacoes";
            this.textBoxObservacoes.Size = new System.Drawing.Size(833, 132);
            this.textBoxObservacoes.TabIndex = 13;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(757, 245);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(96, 23);
            this.buttonFechar.TabIndex = 14;
            this.buttonFechar.Text = "FECHAR";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonDeletar
            // 
            this.buttonDeletar.Location = new System.Drawing.Point(757, 120);
            this.buttonDeletar.Name = "buttonDeletar";
            this.buttonDeletar.Size = new System.Drawing.Size(96, 23);
            this.buttonDeletar.TabIndex = 15;
            this.buttonDeletar.Text = "DELETAR";
            this.buttonDeletar.UseVisualStyleBackColor = true;
            this.buttonDeletar.Click += new System.EventHandler(this.buttonDeletar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(757, 59);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(96, 23);
            this.buttonCadastrar.TabIndex = 16;
            this.buttonCadastrar.Text = "CADASTRAR";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(757, 89);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(96, 23);
            this.buttonEditar.TabIndex = 17;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // maskedTextBoxHoraInicio
            // 
            this.maskedTextBoxHoraInicio.Location = new System.Drawing.Point(101, 181);
            this.maskedTextBoxHoraInicio.Mask = "90:00";
            this.maskedTextBoxHoraInicio.Name = "maskedTextBoxHoraInicio";
            this.maskedTextBoxHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHoraInicio.TabIndex = 19;
            this.maskedTextBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraFim
            // 
            this.maskedTextBoxHoraFim.Location = new System.Drawing.Point(87, 210);
            this.maskedTextBoxHoraFim.Mask = "90:00";
            this.maskedTextBoxHoraFim.Name = "maskedTextBoxHoraFim";
            this.maskedTextBoxHoraFim.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHoraFim.TabIndex = 20;
            this.maskedTextBoxHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxIDConsulta
            // 
            this.textBoxIDConsulta.Location = new System.Drawing.Point(107, 61);
            this.textBoxIDConsulta.Name = "textBoxIDConsulta";
            this.textBoxIDConsulta.Size = new System.Drawing.Size(113, 20);
            this.textBoxIDConsulta.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultorioDataSetBindingSource
            // 
            this.consultorioDataSetBindingSource.DataSource = this.consultorioDataSet;
            this.consultorioDataSetBindingSource.Position = 0;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmMenuConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(857, 446);
            this.Controls.Add(this.textBoxIDConsulta);
            this.Controls.Add(this.maskedTextBoxHoraFim);
            this.Controls.Add(this.maskedTextBoxHoraInicio);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonDeletar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.textBoxObservacoes);
            this.Controls.Add(this.dateTimePickerDataCOnsulta);
            this.Controls.Add(this.comboBoxIDPaciente);
            this.Controls.Add(this.comboBoxIDMedico);
            this.Controls.Add(this.labelObservacoes);
            this.Controls.Add(this.labelHoraFim);
            this.Controls.Add(this.labelHoraInicio);
            this.Controls.Add(this.labelDataConsulta);
            this.Controls.Add(this.IdPaciente);
            this.Controls.Add(this.frmIDMedico);
            this.Controls.Add(this.labelIDConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA DE CONSULTA";
            this.Load += new System.EventHandler(this.frmMenuConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDConsulta;
        private System.Windows.Forms.Label frmIDMedico;
        private System.Windows.Forms.Label IdPaciente;
        private System.Windows.Forms.Label labelDataConsulta;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.Label labelHoraFim;
        private System.Windows.Forms.Label labelObservacoes;
        private System.Windows.Forms.ComboBox comboBoxIDMedico;
        private System.Windows.Forms.ComboBox comboBoxIDPaciente;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataCOnsulta;
        private System.Windows.Forms.TextBox textBoxObservacoes;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonDeletar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFim;
        private System.Windows.Forms.TextBox textBoxIDConsulta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource consultorioDataSetBindingSource;
        private ConsultorioDataSet consultorioDataSet;
        private ConsultorioDataSet1 consultorioDataSet1;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ConsultorioDataSet1TableAdapters.MedicoTableAdapter medicoTableAdapter;
        private ConsultorioDataSet2 consultorioDataSet2;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ConsultorioDataSet2TableAdapters.PacienteTableAdapter pacienteTableAdapter;
    }
}