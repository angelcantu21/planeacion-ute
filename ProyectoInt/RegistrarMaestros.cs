using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInt
{
    public partial class RegistrarMaestros : Form
    {
        public RegistrarMaestros()
        {
            InitializeComponent();
        }
        ConsultasMysql con = new ConsultasMysql();
        void limpiar()
        {
            txtId.Text = "";
            txtNombre.Clear();
            txtApellidoP.Clear();
            txtApellidoM.Clear();
            txtNombre.Focus();
        }
        void MostrarInformacion()
        {
            dataGridMaestros.DataSource = con.MostrarSoloMaestros();
            dataGridView1.DataSource = con.MostrarMaestros();
        }

        private void comboMateria_Click(object sender, EventArgs e)
        {
            con.ComboMateria(comboMateria);
        }
        private void comboMaestro_Click(object sender, EventArgs e)
        {
            con.ComboProfesor(comboMaestro);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.AgregarMaestro(txtNombre, txtApellidoP, txtApellidoM);
            MostrarInformacion();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.AsignarMaterias(comboMateria, comboMaestro);
            MostrarInformacion();
        }

        private void RegistrarMaestros_Load(object sender, EventArgs e)
        {
            MostrarInformacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            btnCancelar.Visible = false;
            btnRegistrar.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.EditarMaestros(txtNombre, txtApellidoP, txtApellidoM, txtId);
            MostrarInformacion();
            limpiar();
            btnRegistrar.Enabled = true;
            btnCancelar.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //con.EliminarMaestroMaterias(txtId);
            con.EliminarMaestro(txtId);
            MostrarInformacion();
            limpiar();
            btnRegistrar.Enabled = true;
            btnCancelar.Visible = false;
        }

        private void dataGridMaestros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridMaestros.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridMaestros.CurrentRow.Cells[1].Value.ToString();
            txtApellidoP.Text = dataGridMaestros.CurrentRow.Cells[2].Value.ToString();
            txtApellidoM.Text = dataGridMaestros.CurrentRow.Cells[3].Value.ToString();
            btnCancelar.Visible = true;
            btnRegistrar.Enabled = false;
        }
    }
}
