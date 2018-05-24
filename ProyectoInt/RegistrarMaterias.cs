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
    public partial class RegistrarMaterias : Form
    {
        public RegistrarMaterias()
        {
            InitializeComponent();
        }
        ConsultasMysql con = new ConsultasMysql();

        void MostrarInformacion()
        {
           dataGridMaterias.DataSource = con.MostrarSoloMaterias();
            dataGridView1.DataSource = con.MostrarMaterias();
        }
        private void comboGrupo_Click(object sender, EventArgs e)
        {
            con.comboGrupo(comboGrupo);
        }

        private void comboMaterias_Click(object sender, EventArgs e)
        {
            con.ComboMateria(comboMaterias);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.AgregarMateria(txtMateria, txtHoras);
            MostrarInformacion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.EditarMaterias(txtMateria, txtHoras, txtId);
            MostrarInformacion();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.EliminarMateria(txtId);
            MostrarInformacion();
        }

        private void RegistrarMaterias_Load(object sender, EventArgs e)
        {
            MostrarInformacion();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtMateria.Clear();
            txtHoras.Clear();
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.AsignarGrupos(comboMaterias,comboGrupo);
            MostrarInformacion();
        }

        private void dataGridMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridMaterias.CurrentRow.Cells[0].Value.ToString();
            txtMateria.Text = dataGridMaterias.CurrentRow.Cells[1].Value.ToString();
            txtHoras.Text = dataGridMaterias.CurrentRow.Cells[2].Value.ToString();
            button5.Visible = true;
        }
    }
}
