using CapaDatos;
using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        ConsultasMysql con = new ConsultasMysql();
        Menu menu = new Menu();

        //SE CREA UN METODO DE LOGIN
        public void Logins(ComboBox tipo)
        {
            #region Conexion
            MySqlConnection conn = new MySqlConnection();
            string cadena = "Server=127.0.0.1;Database=ProyectoInt;UID=root;Password=";
            conn.ConnectionString = cadena;
            #endregion
            conn.Open();
            //HACEMOS NUESTRA CONSULTA QUE SI NUESTRO USUARIO Y CONTRASEÑA COINCIDEN ENTONCES ENTRA AL SISTEMA
            MySqlCommand adapter = new MySqlCommand("SELECT * FROM administradores WHERE usuario= '" + txtUsuario.Text + "' AND contraseña= '" + txtContra.Text + "' AND tipo='"+tipo.Text+"';", conn);
            MySqlDataReader lectura;
            lectura = adapter.ExecuteReader();
            if (lectura.Read())
            {
                menu.Show();
                con.CargarUsuarios(menu.txtNombreUsuario, menu.txtId, txtUsuario);
                menu.txtTipoUsuario.Text = comboTipo.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectos", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IF PARA NO DEJAR CAMPOS VACIOS
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingresa un nombre de usuario");
            }
            else if (txtContra.Text == "")
            {
                MessageBox.Show("Ingresa una contraseña");
            }
            else if (comboTipo.Text == "")
            {
                MessageBox.Show("Ingresa un tipo de acceso");
            }
            else
            {
                if (comboTipo.SelectedIndex == 0)
                {
       //SI EL COMBO TIENE EL INDEX 0 QUE ES IGUAL A ADMINISTRADOR ENTONCES TENDRA TODOS LOS PRIVILEGIOS
                    menu.registrosToolStripMenuItem.Enabled = true;
                    menu.panelDeControlToolStripMenuItem.Enabled = true;
                    Logins(comboTipo); 
                }
                if (comboTipo.SelectedIndex == 1)
                {
       //SI NO ENTONCES SE LE BLOQUEAN ALGUNAS OPCIONES
                    menu.registrosToolStripMenuItem.Enabled = false;
                    menu.panelDeControlToolStripMenuItem.Enabled = false;
                    Logins(comboTipo);
                }
            }
        }
    }
}
