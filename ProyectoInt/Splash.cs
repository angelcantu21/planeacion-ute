using System;
using System.Data;
using System.Windows.Forms;
using CapaDatos;

namespace ProyectoInt
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.timer1.Start(); //Empieza a correr el timer

            label3.Text = "SISTEMA DE REPORTES TICSI " + Application.ProductVersion; //le damos un nombre al label
        }
        ConexionDB cn = new ConexionDB();
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1); //La barra se ira incrementando de 1
            label2.Text = progressBar1.Value.ToString() + "%"; //Aparecera nuestro valor de la barra en un label
            if (progressBar1.Value == 30)
            {
                label1.Text = "Cargando base de datos..";
                try
                {
                    //AQUI VERIFICAMOS SI NOS PODEMOS CONECTAR A NUESTRA BASE DE DATOS
                    cn.conexion(); 
                    cn.AbrirConexion();
                }
                catch (Exception)
                {
//SI NO SE PUEDO SE PARA LA BARRA DE PROGRESO Y MANDAMOS UN MENSAJE SI QUEREMOS VOLVER A INTENAR
                    timer1.Stop();
                    var intentar = MessageBox.Show("Base de datos no conectada" + "\n¿Quieres intentar de nuevo?", "Base de datos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (intentar == DialogResult.Retry)
                    {
                        //SI - NOS VUELVE A LA VENTANA DE CARGA
                        Splash splash = new Splash();
                        splash.Show();
                        this.Hide();
                    }
                    else
                    {
                        //SI NO - SALIMOS DEL PROGRAMA
                        Application.Exit();
                    }
                }
            }
            if (progressBar1.Value == 60)
            {
                label1.Text = "Actualizando informacion..";
            }
            if (progressBar1.Value == 80)
            {
                label1.Text = "Inicializando programa....";
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show(); //ABRIMOS NUESTRO LOGIN
            }
        }
    }
}
