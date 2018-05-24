namespace ProyectoInt
{
    partial class RegistrarMaestros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMaestros));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grupoDatos = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.grupoAsignar = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboMaestro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridMaestros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grupoDatos.SuspendLayout();
            this.grupoAsignar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaestros)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grupoDatos
            // 
            this.grupoDatos.Controls.Add(this.btnBorrar);
            this.grupoDatos.Controls.Add(this.btnModificar);
            this.grupoDatos.Controls.Add(this.label3);
            this.grupoDatos.Controls.Add(this.label2);
            this.grupoDatos.Controls.Add(this.txtApellidoM);
            this.grupoDatos.Controls.Add(this.btnRegistrar);
            this.grupoDatos.Controls.Add(this.txtApellidoP);
            this.grupoDatos.Controls.Add(this.txtNombre);
            this.grupoDatos.Controls.Add(this.label1);
            this.grupoDatos.Location = new System.Drawing.Point(7, 12);
            this.grupoDatos.Name = "grupoDatos";
            this.grupoDatos.Size = new System.Drawing.Size(328, 162);
            this.grupoDatos.TabIndex = 1;
            this.grupoDatos.TabStop = false;
            this.grupoDatos.Text = "Datos del Maestro";
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(209, 129);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 23);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Eliminar Maestro";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(117, 129);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Editar Maestro";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido Paterno";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(100, 96);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(218, 20);
            this.txtApellidoM.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(8, 129);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar Maestro";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(100, 56);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(218, 20);
            this.txtApellidoP.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(257, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(7, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 23);
            this.button2.TabIndex = 101;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Materia Asignada";
            // 
            // comboMateria
            // 
            this.comboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(98, 64);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(220, 21);
            this.comboMateria.TabIndex = 7;
            this.comboMateria.Click += new System.EventHandler(this.comboMateria_Click);
            // 
            // grupoAsignar
            // 
            this.grupoAsignar.Controls.Add(this.button3);
            this.grupoAsignar.Controls.Add(this.comboMaestro);
            this.grupoAsignar.Controls.Add(this.label5);
            this.grupoAsignar.Controls.Add(this.comboMateria);
            this.grupoAsignar.Controls.Add(this.label4);
            this.grupoAsignar.Location = new System.Drawing.Point(7, 197);
            this.grupoAsignar.Name = "grupoAsignar";
            this.grupoAsignar.Size = new System.Drawing.Size(328, 132);
            this.grupoAsignar.TabIndex = 102;
            this.grupoAsignar.TabStop = false;
            this.grupoAsignar.Text = "Asignar Materias";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(217, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Guardar Datos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboMaestro
            // 
            this.comboMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaestro.FormattingEnabled = true;
            this.comboMaestro.Location = new System.Drawing.Point(98, 22);
            this.comboMaestro.Name = "comboMaestro";
            this.comboMaestro.Size = new System.Drawing.Size(221, 21);
            this.comboMaestro.TabIndex = 9;
            this.comboMaestro.Click += new System.EventHandler(this.comboMaestro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maestro Asignado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(493, 179);
            this.dataGridView1.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(503, 18);
            this.label6.TabIndex = 104;
            this.label6.Text = "Tecnología de la Información y Comunicación; Área Sistemas Informáticos.";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(260, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 105;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Numero de Ficha:";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(428, 134);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 107;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(341, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 221);
            this.tabControl1.TabIndex = 108;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridMaestros);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Maestros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignaturas de Maestros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridMaestros
            // 
            this.dataGridMaestros.AllowUserToAddRows = false;
            this.dataGridMaestros.AllowUserToDeleteRows = false;
            this.dataGridMaestros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMaestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaestros.EnableHeadersVisualStyles = false;
            this.dataGridMaestros.Location = new System.Drawing.Point(6, 8);
            this.dataGridMaestros.MultiSelect = false;
            this.dataGridMaestros.Name = "dataGridMaestros";
            this.dataGridMaestros.RowHeadersVisible = false;
            this.dataGridMaestros.ShowRowErrors = false;
            this.dataGridMaestros.Size = new System.Drawing.Size(493, 179);
            this.dataGridMaestros.TabIndex = 104;
            this.dataGridMaestros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMaestros_CellClick);
            // 
            // RegistrarMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 371);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grupoAsignar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grupoDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrarMaestros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Maestros | Tecnología de la Información y Comunicación; Área Sistemas In" +
    "formáticos.";
            this.Load += new System.EventHandler(this.RegistrarMaestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grupoDatos.ResumeLayout(false);
            this.grupoDatos.PerformLayout();
            this.grupoAsignar.ResumeLayout(false);
            this.grupoAsignar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaestros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboMaestro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.GroupBox grupoDatos;
        public System.Windows.Forms.GroupBox grupoAsignar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView dataGridMaestros;
        private System.Windows.Forms.TabPage tabPage2;
    }
}