namespace Login
{
    partial class frmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConsultas = new System.Windows.Forms.Button();
            this.buttonSairPrincipalMenu = new System.Windows.Forms.Button();
            this.buttonCadastroPaciente = new System.Windows.Forms.Button();
            this.buttonCadastroMedico = new System.Windows.Forms.Button();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonConsultas);
            this.panel2.Controls.Add(this.buttonSairPrincipalMenu);
            this.panel2.Controls.Add(this.buttonCadastroPaciente);
            this.panel2.Controls.Add(this.buttonCadastroMedico);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 565);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "MOURA MEDICAL CENTER ";
            // 
            // buttonConsultas
            // 
            this.buttonConsultas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.buttonConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConsultas.Location = new System.Drawing.Point(-4, 298);
            this.buttonConsultas.Name = "buttonConsultas";
            this.buttonConsultas.Size = new System.Drawing.Size(167, 42);
            this.buttonConsultas.TabIndex = 4;
            this.buttonConsultas.Text = "CONSULTAS";
            this.buttonConsultas.UseVisualStyleBackColor = true;
            this.buttonConsultas.Click += new System.EventHandler(this.buttonConsultas_Click);
            // 
            // buttonSairPrincipalMenu
            // 
            this.buttonSairPrincipalMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSairPrincipalMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.buttonSairPrincipalMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSairPrincipalMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSairPrincipalMenu.Location = new System.Drawing.Point(0, 542);
            this.buttonSairPrincipalMenu.Name = "buttonSairPrincipalMenu";
            this.buttonSairPrincipalMenu.Size = new System.Drawing.Size(162, 23);
            this.buttonSairPrincipalMenu.TabIndex = 3;
            this.buttonSairPrincipalMenu.Text = "SAIR";
            this.buttonSairPrincipalMenu.UseVisualStyleBackColor = true;
            this.buttonSairPrincipalMenu.Click += new System.EventHandler(this.buttonSairPrincipalMenu_Click);
            // 
            // buttonCadastroPaciente
            // 
            this.buttonCadastroPaciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.buttonCadastroPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastroPaciente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCadastroPaciente.Location = new System.Drawing.Point(0, 241);
            this.buttonCadastroPaciente.Name = "buttonCadastroPaciente";
            this.buttonCadastroPaciente.Size = new System.Drawing.Size(163, 41);
            this.buttonCadastroPaciente.TabIndex = 1;
            this.buttonCadastroPaciente.Text = "CADASTRO DE PACIENTES";
            this.buttonCadastroPaciente.UseVisualStyleBackColor = true;
            this.buttonCadastroPaciente.Click += new System.EventHandler(this.buttonCadastroPaciente_Click_1);
            // 
            // buttonCadastroMedico
            // 
            this.buttonCadastroMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.buttonCadastroMedico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.buttonCadastroMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastroMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastroMedico.ForeColor = System.Drawing.Color.White;
            this.buttonCadastroMedico.Location = new System.Drawing.Point(0, 180);
            this.buttonCadastroMedico.Name = "buttonCadastroMedico";
            this.buttonCadastroMedico.Size = new System.Drawing.Size(162, 42);
            this.buttonCadastroMedico.TabIndex = 0;
            this.buttonCadastroMedico.Text = "CADASTRO DE MÉDICOS";
            this.buttonCadastroMedico.UseVisualStyleBackColor = false;
            this.buttonCadastroMedico.Click += new System.EventHandler(this.buttonCadastroMedico_Click);
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(162, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(838, 37);
            this.panelBarra.TabIndex = 6;
            this.panelBarra.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(162, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 32);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(162, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(838, 496);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " CONSULTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCadastroPaciente;
        private System.Windows.Forms.Button buttonCadastroMedico;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSairPrincipalMenu;
        private System.Windows.Forms.Button buttonConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}