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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        #region Instancias
        FormPDF vistapdf = new FormPDF();
        Accesos acceso = new Accesos();
        RegistrarFechas fech = new RegistrarFechas();
        RegistrarGrupo grupos = new RegistrarGrupo();
        RegistrarMaestros maestros = new RegistrarMaestros();
        RegistrarMaterias materias = new RegistrarMaterias();
        RegistrarPeriodo periodos = new RegistrarPeriodo();
        ConsultasMysql con = new ConsultasMysql();
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToShortDateString(); //PONEMOS EL DIA AL LABEL
            txthora.Text = DateTime.Now.ToLongTimeString(); //PONEMOS LA HORA AL LABEL
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; //TIMER ENCENDIDO
            timer1.Interval = 60; //INTERVALOS DE 60
        }

        private void registrarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SI EL TIPO DE USUARIO ES ADMINISTRADOR
            if (txtTipoUsuario.Text == "Administrador")
            {
                grupos.groupBox1.Enabled = true;
                grupos.Show();
            }
            else
            {
                //SI NO ES ENTONCES NO TIENE PERMISOS PARA ENTRAR A ESTA SECCION
                MessageBox.Show("No tienes permiso para ingresar a esta seccion","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void registrarMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTipoUsuario.Text == "Administrador")
            {
                maestros.dataGridView1.Enabled = true;
                maestros.grupoAsignar.Enabled = true;
                maestros.grupoDatos.Enabled = true;
                maestros.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para ingresar a esta seccion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTipoUsuario.Text == "Administrador")
            {
                materias.dataGridView1.Enabled = true;
                materias.grupoAsignar.Enabled = true;
                materias.grupoDatos.Enabled = true;
                materias.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para ingresar a esta seccion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrarPeriodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTipoUsuario.Text == "Administrador")
            {
                periodos.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para ingresar a esta seccion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registroDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTipoUsuario.Text == "Administrador")
            {
                fech.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para ingresar a esta seccion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void accesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTipoUsuario.Text == "Administrador")
            {
                acceso.Show();
            }
            else
            {
                MessageBox.Show("No tienes permiso para ingresar a esta seccion", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crearPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportePDF rep = new ReportePDF();
            rep.Show();
        }

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                maestros.dataGridView1.Enabled = false;
                maestros.grupoAsignar.Enabled = false;
                maestros.grupoDatos.Enabled = false;
                maestros.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materias.dataGridView1.Enabled = false;
            materias.grupoAsignar.Enabled = false;
            materias.grupoDatos.Enabled = false;
            materias.Show();
        }

        private void fechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vistapdf.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grupos.groupBox1.Enabled = false;
            grupos.Show();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                        "SISTEMA DE REPORTES KEIKAKU"
                + "\n"
                + "\nCON ESTE SISTEMA SE PERIMTE CREAR REPORTES DE PLANEACION DE ASIGNATURA"
                + "\nAYUDANDO ASI A LOS ENCARGADOS DE LA PLEANEACION DE NUESTRA CARRERA"
                + "\n"
                + "\nPARA EL MANEJO DE ESTE SOFTWARE ES NECESARIO LEER EL MANUAL"
                + "\n"
                + "\nSISTEMA CREADO POR: FAAAB"
                );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //MINIMIZAR LA VENTANA
        }
        private void comboApuntes_Click(object sender, EventArgs e)
        {
            con.ComboApuntes(comboApuntes, txtId); //APUNTES EXISTENTES DE ESE USUARIO
        }

        private void comboApuntes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdApuntes.Text = comboApuntes.SelectedValue.ToString(); //ASIGNAMOS EL ID DEL APUNTE AL LABEL
            con.CargarApuntes(comboApuntes, txtApuntesContenido); //CARGAMOS APUNTES
        }

        private void btnAgregarApuntes_Click(object sender, EventArgs e)
        {
            if (txtNuevoApunte.Text == "") //SI EL NOMBRE DEL APUNTE ESTA VACIO NO SE PODRA AGREGAR
            {
                MessageBox.Show("Error al guardar apunte"+"\nPor favor ingresa un nombre para el apunte","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtNuevoApunte.Focus();
            }
            else
            {
                con.AgregarApuntes(txtNuevoApunte, txtApuntesContenido, txtId);
                con.ComboApuntes(comboApuntes, txtId);
                txtNuevoApunte.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNuevoApunte.Clear();
            txtApuntesContenido.Clear();
        }

        private void btnGuardarApunte_Click(object sender, EventArgs e)
        {
            con.EditarApuntes(txtApuntesContenido,txtIdApuntes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("Los datos borrados no podran ser recuperados"+"\n¿Seguro que quieres eliminar este apunte?","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes)
            {
                con.EliminarApuntes(txtIdApuntes);
                con.ComboApuntes(comboApuntes, txtId);
            }
        }

        private void txtNuevoApunte_TextChanged(object sender, EventArgs e)
        {
            btnAgregarApuntes.Visible = true;
            if (txtNuevoApunte.Text == "")
            {
                btnAgregarApuntes.Visible = false;
            }
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox7.Visible = true;
            var confirmacion = MessageBox.Show("¿Estas seguro de cerrar sesion?", "ESTAS A PUNTO DE SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            else
            {
                pictureBox5.Visible = true;
                pictureBox7.Visible = false;
            }
        }
        #region Temas de Pantalla
        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;

            //Color de las letras
            //ForeColor = Color.FromArgb(0, 0, 0);

            //TextBox
            txtApuntesContenido.BackColor = Color.GreenYellow;
            txtNuevoApunte.BackColor = Color.GreenYellow;

            //Color de botones
            btnGuardarApunte.BackColor = Color.GreenYellow;
            button4.BackColor = Color.GreenYellow;
            button5.BackColor = Color.GreenYellow;
            btnAgregarApuntes.BackColor = Color.GreenYellow;

            //ListBox
            listBox1.BackColor = Color.GreenYellow;

            //ComboBox
            comboApuntes.BackColor = Color.GreenYellow;
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;

            //Color de las letras
            //ForeColor = Color.FromArgb(0, 0, 0);

            //TextBox
            txtApuntesContenido.BackColor = Color.White;
            txtNuevoApunte.BackColor = Color.White;

            //Color de botones
            btnGuardarApunte.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            btnAgregarApuntes.BackColor = Color.White;

            //ListBox
            listBox1.BackColor = Color.White;

            //ComboBox
            comboApuntes.BackColor = Color.White;
        }
        private void oscuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkSlateGray;

            //Color de las letras
            //ForeColor = Color.FromArgb(0, 0, 0);

            //TextBox
            txtApuntesContenido.BackColor = Color.DarkSlateGray;
            txtNuevoApunte.BackColor = Color.DarkSlateGray;

            //Color de botones
            btnGuardarApunte.BackColor = Color.DarkSlateGray;
            button4.BackColor = Color.DarkSlateGray;
            button5.BackColor = Color.DarkSlateGray;
            btnAgregarApuntes.BackColor = Color.DarkSlateGray;

            //ListBox
            listBox1.BackColor = Color.DarkSlateGray;

            //ComboBox
            comboApuntes.BackColor = Color.DarkSlateGray;
        }
        #endregion
    }
}
