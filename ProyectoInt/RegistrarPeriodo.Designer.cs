namespace ProyectoInt
{
    partial class RegistrarPeriodo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboMesFinal = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboMesInicial = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTemporada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboMesFinal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboMesInicial);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTemporada);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 55);
            this.groupBox1.TabIndex = 212;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(520, 20);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(62, 20);
            this.txtAño.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "Año";
            // 
            // comboMesFinal
            // 
            this.comboMesFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMesFinal.FormattingEnabled = true;
            this.comboMesFinal.Items.AddRange(new object[] {
            "ENEREO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.comboMesFinal.Location = new System.Drawing.Point(379, 20);
            this.comboMesFinal.Name = "comboMesFinal";
            this.comboMesFinal.Size = new System.Drawing.Size(102, 21);
            this.comboMesFinal.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(360, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 95;
            this.label11.Text = "-";
            // 
            // comboMesInicial
            // 
            this.comboMesInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMesInicial.FormattingEnabled = true;
            this.comboMesInicial.Items.AddRange(new object[] {
            "ENEREO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.comboMesInicial.Location = new System.Drawing.Point(256, 20);
            this.comboMesInicial.Name = "comboMesInicial";
            this.comboMesInicial.Size = new System.Drawing.Size(100, 21);
            this.comboMesInicial.TabIndex = 94;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Meses";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 92;
            this.label12.Text = "Temporada";
            // 
            // txtTemporada
            // 
            this.txtTemporada.Location = new System.Drawing.Point(74, 22);
            this.txtTemporada.Name = "txtTemporada";
            this.txtTemporada.Size = new System.Drawing.Size(131, 20);
            this.txtTemporada.TabIndex = 91;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(525, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 213;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(13, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 214;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistrarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 109);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R E G I S T R A R   P E  R I O D O";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboMesFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboMesInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtTemporada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}