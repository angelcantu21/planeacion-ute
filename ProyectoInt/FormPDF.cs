using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace ProyectoInt
{
    public partial class FormPDF : Form
    {

        public FormPDF()
        {
            InitializeComponent();
        }

        ConsultasMysql con = new ConsultasMysql();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormPDF_Load(object sender, EventArgs e)
        {
            con.ComboMateria(comboAsignatura);
            con.ComboPeriodos(comboPeriodo);
        }

        private void comboAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.ComboMaestroMaterias(comboMaestros, comboAsignatura); //EL COMBO DE MAESTROS SE LLENARA DE ACUERDO A SU MATERIA
            con.ComboGrupoMateria(comboGrupo, comboAsignatura); //EL COMBO DE GRUPO SE LLENA DE ACUERDO A LAS MATERIAS
            con.CargarHoras(txtHorasxSemana, comboAsignatura); //AQUI SE CARGAN LAS HORAS DE LA MATERIA EN UN TEXTBOX
            con.CargarCuatrimestre(txtCuatrimestre, comboGrupo); //AQUI SE CARGA EL CUATRIMESTRE
            con.CargarTurno(txtTurno, comboGrupo); //AQUI SE CARGA EL TURNO

            #region Cargador de Fechas
            con.CargarFechas(sem1, txtFI1, txtFF1, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem2, txtFI2, txtFF2, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem3, txtFI3, txtFF3, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem4, txtFI4, txtFF4, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem5, txtFI5, txtFF5, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem6, txtFI6, txtFF6, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem7, txtFI7, txtFF7, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem8, txtFI8, txtFF8, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem9, txtFI9, txtFF9, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem10, txtFI10, txtFF10, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem11, txtFI11, txtFF11, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem12, txtFI12, txtFF12, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem13, txtFI13, txtFF13, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem14, txtFI14, txtFF14, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem15, txtFI15, txtFF15, comboAsignatura, comboPeriodo);
            #endregion

            #region Cargador de Unidades
            con.CargarUnidadesVista(sem1, txtUnidad1, txtClave1, txtDescripcion1, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem2, txtUnidad2, txtClave2, txtDescripcion2, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem3, txtUnidad3, txtClave3, txtDescripcion3, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem4, txtUnidad4, txtClave4, txtDescripcion4, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem5, txtUnidad5, txtClave5, txtDescripcion5, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem6, txtUnidad6, txtClave6, txtDescripcion6, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem7, txtUnidad7, txtClave7, txtDescripcion7, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem8, txtUnidad8, txtClave8, txtDescripcion8, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem9, txtUnidad9, txtClave9, txtDescripcion9, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem10, txtUnidad10, txtClave10, txtDescripcion10, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem11, txtUnidad11, txtClave11, txtDescripcion11, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem12, txtUnidad12, txtClave12, txtDescripcion12, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem13, txtUnidad13, txtClave13, txtDescripcion13, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem14, txtUnidad14, txtClave14, txtDescripcion14, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem15, txtUnidad15, txtClave15, txtDescripcion15, comboAsignatura, comboPeriodo);
            #endregion

        }

        private void comboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Cargador de Fechas
            con.CargarFechas(sem1, txtFI1, txtFF1, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem2, txtFI2, txtFF2, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem3, txtFI3, txtFF3, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem4, txtFI4, txtFF4, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem5, txtFI5, txtFF5, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem6, txtFI6, txtFF6, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem7, txtFI7, txtFF7, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem8, txtFI8, txtFF8, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem9, txtFI9, txtFF9, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem10, txtFI10, txtFF10, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem11, txtFI11, txtFF11, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem12, txtFI12, txtFF12, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem13, txtFI13, txtFF13, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem14, txtFI14, txtFF14, comboAsignatura, comboPeriodo);
            con.CargarFechas(sem15, txtFI15, txtFF15, comboAsignatura, comboPeriodo);
            #endregion

            #region Cargador de Unidades
            con.CargarUnidadesVista(sem1, txtUnidad1, txtClave1, txtDescripcion1, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem2, txtUnidad2, txtClave2, txtDescripcion2, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem3, txtUnidad3, txtClave3, txtDescripcion3, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem4, txtUnidad4, txtClave4, txtDescripcion4, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem5, txtUnidad5, txtClave5, txtDescripcion5, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem6, txtUnidad6, txtClave6, txtDescripcion6, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem7, txtUnidad7, txtClave7, txtDescripcion7, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem8, txtUnidad8, txtClave8, txtDescripcion8, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem9, txtUnidad9, txtClave9, txtDescripcion9, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem10, txtUnidad10, txtClave10, txtDescripcion10, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem11, txtUnidad11, txtClave11, txtDescripcion11, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem12, txtUnidad12, txtClave12, txtDescripcion12, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem13, txtUnidad13, txtClave13, txtDescripcion13, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem14, txtUnidad14, txtClave14, txtDescripcion14, comboAsignatura, comboPeriodo);
            con.CargarUnidadesVista(sem15, txtUnidad15, txtClave15, txtDescripcion15, comboAsignatura, comboPeriodo);
            #endregion
        }
    }
}
