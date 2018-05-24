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
    public partial class RegistrarGrupo : Form
    {
        public RegistrarGrupo()
        {
            InitializeComponent();
        }
        ConsultasMysql con = new ConsultasMysql();

        private void RegistrarGrupo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.MostrarGrupos();
        }

        private void comboTurno_Click(object sender, EventArgs e)
        {
            con.comboTurno(comboTurno);
        }

        private void comboCuatri_Click(object sender, EventArgs e)
        {
            con.comboCuatrimestre(comboCuatri);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.AgregarGrupo(txtGrupo,comboCuatri,comboTurno);
            dataGridView1.DataSource = con.MostrarGrupos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
