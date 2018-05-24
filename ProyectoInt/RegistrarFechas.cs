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
    public partial class RegistrarFechas : Form
    {
        public RegistrarFechas()
        {
            InitializeComponent();
        }

        ConsultasMysql con = new ConsultasMysql();

        void LimpiarCampos()
        {
            txtDescripcion1.Clear();
            txtDescripcion2.Clear();
            txtDescripcion3.Clear();
            txtDescripcion4.Clear();
            txtDescripcion5.Clear();
            txtDescripcion6.Clear();
            txtDescripcion7.Clear();
            txtDescripcion8.Clear();
            txtDescripcion9.Clear();
            txtDescripcion10.Clear();
            txtDescripcion11.Clear();
            txtDescripcion12.Clear();
            txtDescripcion13.Clear();
            txtDescripcion14.Clear();
            txtDescripcion15.Clear();
            txtUnidad1.Clear();
            txtUnidad2.Clear();
            txtUnidad3.Clear();
            txtUnidad4.Clear();
            txtUnidad5.Clear();
            txtUnidad6.Clear();
            txtUnidad7.Clear();
            txtUnidad8.Clear();
            txtUnidad9.Clear();
            txtUnidad10.Clear();
            txtUnidad11.Clear();
            txtUnidad12.Clear();
            txtUnidad13.Clear();
            txtUnidad14.Clear();
            txtUnidad15.Clear();
            txtClave1.Clear();
            txtClave2.Clear();
            txtClave3.Clear();
            txtClave4.Clear();
            txtClave5.Clear();
            txtClave6.Clear();
            txtClave7.Clear();
            txtClave8.Clear();
            txtClave9.Clear();
            txtClave10.Clear();
            txtClave11.Clear();
            txtClave12.Clear();
            txtClave13.Clear();
            txtClave14.Clear();
            txtClave15.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPDF ver = new FormPDF();
            ver.Show();
        }

        private void comboPeriodos_Click(object sender, EventArgs e)
        {
            con.ComboPeriodos(comboPeriodos);
        }

        private void comboAsignatura_Click(object sender, EventArgs e)
        {
            con.ComboMateria(comboAsignatura);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Hide();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Seguro que quieres insertar estos datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmar == DialogResult.Yes)
            {
//AGREAMOS LAS FECHAS QUE LE DIMOS AL SISTEMA DE UNA POR UNA PERO ANTES SE REGISTRAN LAS UNIDADES PARA ASI TENER NUESTRA FK DE CADA UNIDAD
                con.AgregarFechas(sem1, dateTimePicker1, dateTimePicker2, comboAsignatura, comboPeriodos, unidad1);
                con.AgregarFechas(sem2, dateTimePicker3, dateTimePicker4, comboAsignatura, comboPeriodos, unidad2);
                con.AgregarFechas(sem3, dateTimePicker5, dateTimePicker6, comboAsignatura, comboPeriodos, unidad3);
                con.AgregarFechas(sem4, dateTimePicker7, dateTimePicker8, comboAsignatura, comboPeriodos, unidad4);
                con.AgregarFechas(sem5, dateTimePicker9, dateTimePicker10, comboAsignatura, comboPeriodos, unidad5);
                con.AgregarFechas(sem6, dateTimePicker11, dateTimePicker12, comboAsignatura, comboPeriodos, unidad6);
                con.AgregarFechas(sem7, dateTimePicker13, dateTimePicker14, comboAsignatura, comboPeriodos, unidad7);
                con.AgregarFechas(sem8, dateTimePicker15, dateTimePicker16, comboAsignatura, comboPeriodos, unidad8);
                con.AgregarFechas(sem9, dateTimePicker17, dateTimePicker18, comboAsignatura, comboPeriodos, unidad9);
                con.AgregarFechas(sem10, dateTimePicker19, dateTimePicker20, comboAsignatura, comboPeriodos, unidad10);
                con.AgregarFechas(sem11, dateTimePicker21, dateTimePicker22, comboAsignatura, comboPeriodos, unidad11);
                con.AgregarFechas(sem12, dateTimePicker23, dateTimePicker24, comboAsignatura, comboPeriodos, unidad12);
                con.AgregarFechas(sem13, dateTimePicker25, dateTimePicker26, comboAsignatura, comboPeriodos, unidad13);
                con.AgregarFechas(sem14, dateTimePicker27, dateTimePicker28, comboAsignatura, comboPeriodos, unidad14);
                con.AgregarFechas(sem15, dateTimePicker29, dateTimePicker30, comboAsignatura, comboPeriodos, unidad15);
                btnFinish.Enabled = false;
                btnUnidades.Enabled = true;
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Datos cancelados");
            }
        }

        private void btnUnidades_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Los datos insertados son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirmar == DialogResult.Yes)
            {
                //REGISTRAMOS NUESTRAS UNIDADES
                con.AgregarUnidades(txtUnidad1, txtClave1, txtDescripcion1);
                con.AgregarUnidades(txtUnidad2, txtClave2, txtDescripcion2);
                con.AgregarUnidades(txtUnidad3, txtClave3, txtDescripcion3);
                con.AgregarUnidades(txtUnidad4, txtClave4, txtDescripcion4);
                con.AgregarUnidades(txtUnidad5, txtClave5, txtDescripcion5);
                con.AgregarUnidades(txtUnidad6, txtClave6, txtDescripcion6);
                con.AgregarUnidades(txtUnidad7, txtClave7, txtDescripcion7);
                con.AgregarUnidades(txtUnidad8, txtClave8, txtDescripcion8);
                con.AgregarUnidades(txtUnidad9, txtClave9, txtDescripcion9);
                con.AgregarUnidades(txtUnidad10, txtClave10, txtDescripcion10);
                con.AgregarUnidades(txtUnidad11, txtClave11, txtDescripcion11);
                con.AgregarUnidades(txtUnidad12, txtClave12, txtDescripcion12);
                con.AgregarUnidades(txtUnidad13, txtClave13, txtDescripcion13);
                con.AgregarUnidades(txtUnidad14, txtClave14, txtDescripcion14);
                con.AgregarUnidades(txtUnidad15, txtClave15, txtDescripcion15);
//              -----------CARGAR EL ID DE LAS UNIDADES EN EL LABEL--------------
                con.CargarUnidades(txtUnidad1, txtClave1, unidad1);
                con.CargarUnidades(txtUnidad2, txtClave2,unidad2);
                con.CargarUnidades(txtUnidad3, txtClave3,unidad3);
                con.CargarUnidades(txtUnidad4, txtClave4,unidad4);
                con.CargarUnidades(txtUnidad5, txtClave5, unidad5);
                con.CargarUnidades(txtUnidad6, txtClave6, unidad6);
                con.CargarUnidades(txtUnidad7, txtClave7, unidad7);
                con.CargarUnidades(txtUnidad8, txtClave8, unidad8);
                con.CargarUnidades(txtUnidad9, txtClave9, unidad9);
                con.CargarUnidades(txtUnidad10, txtClave10, unidad10);
                con.CargarUnidades(txtUnidad11, txtClave11, unidad11);
                con.CargarUnidades(txtUnidad12, txtClave12, unidad12);
                con.CargarUnidades(txtUnidad13, txtClave13, unidad13);
                con.CargarUnidades(txtUnidad14, txtClave14, unidad14);
                con.CargarUnidades(txtUnidad15, txtClave15, unidad15);
                btnFinish.Enabled = true;
                btnUnidades.Enabled = false;
            }
            else
            {
                MessageBox.Show("Datos cancelados");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //ESTAS SON OPERACIONES PARA QUE AL MOMENTO DE INGRESAR NUESTRA PRIMERA FECHA SE AUTOCOMPLETE TODO
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker3.Value = dateTimePicker2.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker4.Value = dateTimePicker3.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker5.Value = dateTimePicker4.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker6.Value = dateTimePicker5.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker7.Value = dateTimePicker6.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker8.Value = dateTimePicker7.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker9.Value = dateTimePicker8.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker10.Value = dateTimePicker9.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker11.Value = dateTimePicker10.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker12.Value = dateTimePicker11.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker13.Value = dateTimePicker12.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker14.Value = dateTimePicker13.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker15.Value = dateTimePicker14.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker16.Value = dateTimePicker15.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker17.Value = dateTimePicker16.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker18.Value = dateTimePicker17.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker19.Value = dateTimePicker18.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker20.Value = dateTimePicker19.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker21.Value = dateTimePicker20.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker22.Value = dateTimePicker21.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker23.Value = dateTimePicker22.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker24.Value = dateTimePicker23.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker25.Value = dateTimePicker24.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker26.Value = dateTimePicker25.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker27.Value = dateTimePicker26.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker28.Value = dateTimePicker27.Value.AddDays(int.Parse(6.ToString()));
            dateTimePicker29.Value = dateTimePicker28.Value.AddDays(int.Parse(1.ToString()));
            dateTimePicker30.Value = dateTimePicker29.Value.AddDays(int.Parse(6.ToString()));
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
