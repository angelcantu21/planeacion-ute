namespace ProyectoInt
{
    partial class ReportePDF
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGrupo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPeriodo = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.hoja1 = new ProyectoInt.hoja();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMaestros = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(494, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia";
            // 
            // comboMateria
            // 
            this.comboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(543, 6);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(181, 21);
            this.comboMateria.TabIndex = 2;
            this.comboMateria.SelectedIndexChanged += new System.EventHandler(this.comboMateria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupo";
            // 
            // comboGrupo
            // 
            this.comboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrupo.FormattingEnabled = true;
            this.comboGrupo.Location = new System.Drawing.Point(772, 6);
            this.comboGrupo.Name = "comboGrupo";
            this.comboGrupo.Size = new System.Drawing.Size(114, 21);
            this.comboGrupo.TabIndex = 4;
            this.comboGrupo.SelectedIndexChanged += new System.EventHandler(this.comboGrupo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(892, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Periodo";
            // 
            // comboPeriodo
            // 
            this.comboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeriodo.FormattingEnabled = true;
            this.comboPeriodo.Location = new System.Drawing.Point(941, 7);
            this.comboPeriodo.Name = "comboPeriodo";
            this.comboPeriodo.Size = new System.Drawing.Size(257, 21);
            this.comboPeriodo.TabIndex = 10;
            this.comboPeriodo.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.hoja1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1354, 570);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Maestro:";
            // 
            // comboMaestros
            // 
            this.comboMaestros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMaestros.FormattingEnabled = true;
            this.comboMaestros.Location = new System.Drawing.Point(543, 31);
            this.comboMaestros.Name = "comboMaestros";
            this.comboMaestros.Size = new System.Drawing.Size(343, 21);
            this.comboMaestros.TabIndex = 12;
            this.comboMaestros.SelectedIndexChanged += new System.EventHandler(this.comboMaestros_SelectedIndexChanged);
            // 
            // ReportePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 570);
            this.Controls.Add(this.comboMaestros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPeriodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportePDF";
            this.Text = "ReportePDF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportePDF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private hoja hoja1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMaestros;
    }
}