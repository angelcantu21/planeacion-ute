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
    public partial class Accesos : Form
    {
        public Accesos()
        {
            InitializeComponent();
        }
        ConsultasMysql con = new ConsultasMysql();
        void LimpiarCampos()
        {
            lblid.Text = "";
            txtUsuario.Clear();
            txtContra.Clear();
            txtNombre.Clear();
            comboTipo.SelectedIndex = 0;
            button5.Visible = false;
        } // CREAMOS UN METODO PARA LIMPIAR LOS TEXTBOX
        private void Accesos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.MostrarUsuarios(); //MOSTRAMOS USUARIOS EN NUESTRA TABLA
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black; //DAMOS COLOR A LAS CELDAS DE LAS COLUMNAS
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); //DAMOS COLOR DE LETRA
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUsuario.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtContra.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboTipo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); //METODO DE LIMPIAR
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //LLAMAMOS A NUESTRO METODO DE AGREGAR Y LE PONEMOS COMO PARAMETROS NUESTROS TEXTBOX
            con.AgregarUsuarios(txtNombre, txtUsuario, txtContra, comboTipo);
            dataGridView1.DataSource = con.MostrarUsuarios();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.EditarUsuarios(txtNombre, txtUsuario, txtContra, comboTipo,lblid);
            dataGridView1.DataSource = con.MostrarUsuarios();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.EliminarUsuario(lblid);
            dataGridView1.DataSource = con.MostrarUsuarios();
            LimpiarCampos();
        }
    }
}
