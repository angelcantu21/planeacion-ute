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
    public partial class ReportePDF : Form
    {
        public ReportePDF()
        {
            InitializeComponent();
        }
        hoja reporte = new hoja();
        ConsultasMysql con = new ConsultasMysql();

        private void ReportePDF_Load(object sender, EventArgs e)
        {
            con.ComboPeriodos(comboPeriodo);
            con.ComboMateria(comboMateria);
            con.comboGrupo(comboGrupo);
            con.ComboProfesor(comboMaestros);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                reporte.SetParameterValue("idPer", comboPeriodo.SelectedValue);
                crystalReportViewer1.ReportSource = reporte;
            }
            catch (Exception)
            {

            }
        }

        private void comboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                reporte.SetParameterValue("idMate", comboMateria.SelectedValue);
                crystalReportViewer1.ReportSource = reporte;
                con.ComboMaestroMaterias(comboMaestros, comboMateria);
                con.ComboGrupoMateria(comboGrupo, comboMateria);
            }
            catch (Exception)
            {

            }
        }

        private void comboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                reporte.SetParameterValue("idGru", comboGrupo.SelectedValue);
                crystalReportViewer1.ReportSource = reporte;
            }
            catch (Exception)
            {

            }
        }

        private void comboMaestros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                reporte.SetParameterValue("idMa", comboMaestros.SelectedValue);
                crystalReportViewer1.ReportSource = reporte;
            }
            catch (Exception)
            {

            }
        }
    }
}
