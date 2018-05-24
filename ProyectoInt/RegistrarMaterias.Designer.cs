namespace ProyectoInt
{
    partial class RegistrarMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMaterias));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupoDatos = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboGrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grupoAsignar = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.comboMaterias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridMaterias = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grupoDatos.SuspendLayout();
            this.grupoAsignar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia:";
            // 
            // grupoDatos
            // 
            this.grupoDatos.Controls.Add(this.button7);
            this.grupoDatos.Controls.Add(this.button3);
            this.grupoDatos.Controls.Add(this.label2);
            this.grupoDatos.Controls.Add(this.txtHoras);
            this.grupoDatos.Controls.Add(this.txtMateria);
            this.grupoDatos.Controls.Add(this.button1);
            this.grupoDatos.Controls.Add(this.label1);
            this.grupoDatos.Location = new System.Drawing.Point(11, 21);
            this.grupoDatos.Name = "grupoDatos";
            this.grupoDatos.Size = new System.Drawing.Size(329, 128);
            this.grupoDatos.TabIndex = 2;
            this.grupoDatos.TabStop = false;
            this.grupoDatos.Text = "Datos de la Materia";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(217, 91);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Eliminar Materia";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(113, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Modificar Materia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horas por semana:";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(108, 54);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(206, 20);
            this.txtHoras.TabIndex = 3;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(58, 25);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(256, 20);
            this.txtMateria.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar Materia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboGrupo
            // 
            this.comboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrupo.FormattingEnabled = true;
            this.comboGrupo.Location = new System.Drawing.Point(57, 38);
            this.comboGrupo.Name = "comboGrupo";
            this.comboGrupo.Size = new System.Drawing.Size(256, 21);
            this.comboGrupo.TabIndex = 6;
            this.comboGrupo.Click += new System.EventHandler(this.comboGrupo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grupo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(452, 16);
            this.label9.TabIndex = 99;
            this.label9.Text = "Tecnología de la Información y Comunicación; Área Sistemas Informáticos.";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(11, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 23);
            this.button2.TabIndex = 100;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grupoAsignar
            // 
            this.grupoAsignar.Controls.Add(this.button6);
            this.grupoAsignar.Controls.Add(this.comboMaterias);
            this.grupoAsignar.Controls.Add(this.label4);
            this.grupoAsignar.Controls.Add(this.comboGrupo);
            this.grupoAsignar.Controls.Add(this.label3);
            this.grupoAsignar.Location = new System.Drawing.Point(12, 196);
            this.grupoAsignar.Name = "grupoAsignar";
            this.grupoAsignar.Size = new System.Drawing.Size(329, 159);
            this.grupoAsignar.TabIndex = 101;
            this.grupoAsignar.TabStop = false;
            this.grupoAsignar.Text = "Asignar materia al grupo";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(237, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Guardar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboMaterias
            // 
            this.comboMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaterias.FormattingEnabled = true;
            this.comboMaterias.Location = new System.Drawing.Point(57, 74);
            this.comboMaterias.Name = "comboMaterias";
            this.comboMaterias.Size = new System.Drawing.Size(256, 21);
            this.comboMaterias.TabIndex = 8;
            this.comboMaterias.Click += new System.EventHandler(this.comboMaterias_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Materia";
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
            this.dataGridView1.Size = new System.Drawing.Size(446, 213);
            this.dataGridView1.TabIndex = 104;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(265, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 105;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "No. de Materia:";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(422, 127);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 107;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(346, 143);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 254);
            this.tabControl1.TabIndex = 109;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridMaterias);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Materias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridMaterias
            // 
            this.dataGridMaterias.AllowUserToAddRows = false;
            this.dataGridMaterias.AllowUserToDeleteRows = false;
            this.dataGridMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaterias.EnableHeadersVisualStyles = false;
            this.dataGridMaterias.Location = new System.Drawing.Point(6, 6);
            this.dataGridMaterias.MultiSelect = false;
            this.dataGridMaterias.Name = "dataGridMaterias";
            this.dataGridMaterias.RowHeadersVisible = false;
            this.dataGridMaterias.ShowRowErrors = false;
            this.dataGridMaterias.Size = new System.Drawing.Size(446, 213);
            this.dataGridMaterias.TabIndex = 105;
            this.dataGridMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMaterias_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materias Asignadas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RegistrarMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 398);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.grupoAsignar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grupoDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistrarMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Materias | Tecnología de la Información y Comunicación; Área Sistemas In" +
    "formáticos";
            this.Load += new System.EventHandler(this.RegistrarMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grupoDatos.ResumeLayout(false);
            this.grupoDatos.PerformLayout();
            this.grupoAsignar.ResumeLayout(false);
            this.grupoAsignar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboMaterias;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtId;
        public System.Windows.Forms.GroupBox grupoDatos;
        public System.Windows.Forms.GroupBox grupoAsignar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView dataGridMaterias;
        private System.Windows.Forms.TabPage tabPage2;
    }
}