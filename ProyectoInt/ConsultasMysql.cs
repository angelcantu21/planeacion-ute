using System;
using CapaDatos;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoInt
{
    class ConsultasMysql : ConexionDB
    {
        #region Metodos de INSERT con relaciones
        public void AsignarMaterias(ComboBox materia, ComboBox maestro)
        {
            DataTable consulta = new DataTable(); //SE CREA UN OBJETO DE UN DATATABLE
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO MateriaMaestros VALUES ("+materia.SelectedValue+","+maestro.SelectedValue+");", conexion());
                adp.Fill(consulta);//SE EJECUTA LA SENTENCIA JUNTO CON LA CONEXION Y SE AGREGA AL DATATABLE
                MessageBox.Show("¡Materia asignada correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void AsignarGrupos(ComboBox materia, ComboBox grupo)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO grupoMaterias VALUES (" + grupo.SelectedValue + "," + materia.SelectedValue + ");", conexion());
                adp.Fill(consulta);
                MessageBox.Show("¡Grupo asignada correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        #endregion

        #region Metodos de INSERT a MySQL
        public void AgregarGrupo(TextBox grupo, ComboBox cuatri, ComboBox turno)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO grupos (grupo, FKCuatrimestre, FKTurno) VALUES('"+grupo.Text+"' ,"+cuatri.SelectedValue+","+turno.SelectedValue+");", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Grupo registrado");
                grupo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void AgregarPeriodo(TextBox temporada, ComboBox mes1, ComboBox mes2,TextBox año)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO periodos (temporada, meses, año) VALUES('" + temporada.Text + "' , '" + mes1.Text+" - "+mes2.Text+"','" + año.Text + "');", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Periodo registrado");
                temporada.Clear();
                año.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void AgregarMaestro(TextBox nombre, TextBox apellidoP, TextBox apellidoM)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO maestros (nombre, apellido_p, apellido_m) VALUES('" + nombre.Text + "' , '" + apellidoP.Text + "','" + apellidoM.Text + "');", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Maestro registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void AgregarMateria(TextBox materia, TextBox horas)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO materias (materia, horasXsemana) VALUES('" + materia.Text + "' , " + horas.Text + ");", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Materia registrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void AgregarFechas(Label semana, DateTimePicker fechainicio, DateTimePicker fechafin, ComboBox materia, ComboBox periodo, Label unidad)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO fechas (semana, fecha_inicio, fecha_final, FkMateria, FkPeriodo, FkUnidad) VALUES ('" + semana.Text + "','" + fechainicio.Text + "','" + fechafin.Text + "'," + materia.SelectedValue + ","+periodo.SelectedValue+","+unidad.Text+");", conexion());
                adp.Fill(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void AgregarUnidades(TextBox unidad, TextBox clave, TextBox descripcion)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO unidades (unidad, clave, descripcion) VALUES ('"+unidad.Text+"','"+clave.Text+"','"+descripcion.Text+"');", conexion());
                adp.Fill(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }
        public void AgregarApuntes(TextBox nombre, TextBox contenido, Label id)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("INSERT INTO apuntes (nombre, contenido, FKUsuario) VALUES('" + nombre.Text + "' , '" + contenido.Text + "',"+id.Text+");", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Apunte registrado");
            }
            catch (Exception ex)
            {
            }
        }
        public void AgregarUsuarios(TextBox nombre, TextBox usuario, TextBox pass, ComboBox tipo)
        {
            DataTable consulta = new DataTable();
            String sql = "INSERT INTO administradores (nombre, usuario, contraseña, tipo) VALUES('"+nombre.Text+"','"+usuario.Text+"','"+pass.Text+"','"+tipo.Text+"');";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
            adp.Fill(consulta);
            MessageBox.Show("Usuario creado");
        }
        #endregion

        #region Metodos de UPDATE a MySQL
        public void EditarMaestros(TextBox nombre, TextBox apellidoP, TextBox apellidoM, Label id)
        {
            DataTable consulta = new DataTable(); //SE CREA UN DATATABLE
            try
            {
                //CREAMOS UN DataAdapter y ponemos nuestra consulta y nuestra conexion
                MySqlDataAdapter adp = new MySqlDataAdapter("UPDATE maestros SET nombre='" + nombre.Text + "', apellido_P='" + apellidoP.Text + "', apellido_M='" + apellidoM.Text + "' WHERE idMaestro="+id.Text+";", conexion());
                //EJECUTAMOS LA CONSULTA
                adp.Fill(consulta);
                //MANDAMOS UN MENSAJE DE EXITO
                MessageBox.Show("Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void EditarMaterias(TextBox nombre, TextBox horas, Label id)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("UPDATE materias SET Materia='" + nombre.Text + "', horasXsemana="+horas.Text+" WHERE idMateria="+id.Text+";", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void EditarApuntes(TextBox contenido, Label id)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("UPDATE apuntes SET contenido='" + contenido.Text + "' WHERE idApuntes=" + id.Text + ";", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Apunte modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        public void EditarUsuarios(TextBox nombre, TextBox usuario, TextBox pass, ComboBox tipo, Label id)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("UPDATE administradores SET nombre='"+nombre.Text+"', usuario='"+usuario.Text+"', contraseña='"+pass.Text+"', tipo='"+tipo.Text+"' WHERE idAdministrador="+id.Text+";", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            
        }
        #endregion

        #region Metodos de SELECT a MySQL
        public DataTable MostrarMaestros()
        {
            DataTable consulta = new DataTable(); //SE CREA UN OBJTEO DE DATATABLE
            String sql = "SELECT concat(nombre,' ',apellido_P,' ',apellido_M) as Nombre, materia as Materias_Asignadas FROM materiamaestros, materias, maestros WHERE FKMateria=idMateria AND FKMaestro=idMaestro;";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion()); //AÑADIMOS LA SENTENCIA SQL Y AGREGAMOS LA CONEXION A LA DB
            adp.Fill(consulta); //SE EJECUTA
            return consulta; //SE REGRESA UN VALOR DE TIPO DATATABLE
        }
        public DataTable MostrarSoloMaestros()
        {
            DataTable consulta = new DataTable();
            String sql = "SELECT * FROM maestros";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
            adp.Fill(consulta);
            return consulta;
        }
        public DataTable MostrarMaterias()
        {
            DataTable consulta = new DataTable();
            String sql = "SELECT Materia, grupo FROM grupos, materias, grupomaterias WHERE FKMateria=idMateria AND Fkgrupo=idGrupo;";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
            adp.Fill(consulta);
            return consulta;
        }
        public DataTable MostrarGrupos()
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter consulta = new MySqlDataAdapter("SELECT idGrupo as Num_Grupo, grupo as Grupos, cuatrimestre as Cuatrimestres, turno as Turnos FROM grupos,cuatrimestres,turnos WHERE FkCuatrimestre = idCuatrimestre AND FKTurno=idTurno ORDER BY idGrupo",conexion());
            consulta.Fill(tabla);
            return tabla;
        }
        public DataTable MostrarSoloMaterias()
        {
            DataTable consulta = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM materias", conexion());
            adp.Fill(consulta);
            return consulta;
        }
        public DataTable MostrarUsuarios()
        {
            DataTable consulta = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT idAdministrador as Ficha, nombre as Nombre_Completo, usuario as Usuario,contraseña as Password, tipo as Tipo FROM administradores", conexion());
            adp.Fill(consulta);
            return consulta;
        }
        #endregion

        #region Metodos de DELETE a MySQL
        public void EliminarMaestro(Label id)
        {
            //SE CREA UN DATATABLE
            DataTable consulta = new DataTable();
            try
            {
                //SE CREAN LAS CONSULTAS
                MySqlDataAdapter apd = new MySqlDataAdapter("DELETE FROM MateriaMaestros WHERE FKMaestro=" + id.Text + ";", conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter("DELETE FROM Maestros WHERE idMaestro=" + id.Text + ";", conexion());
                //SE EJECUTAN LAS CONSULTAS
                apd.Fill(consulta);
                adp.Fill(consulta);
                MessageBox.Show("Maestro Eliminado");
            }
            catch (Exception)
            {
            }
        }
        public void EliminarMateria(Label id)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter apd = new MySqlDataAdapter("DELETE FROM materiaMaestros WHERE FKMateria=" + id.Text + ";", conexion());
                MySqlDataAdapter dpa = new MySqlDataAdapter("DELETE FROM grupoMaterias WHERE FKMateria=" + id.Text + ";", conexion());
                MySqlDataAdapter adp = new MySqlDataAdapter("DELETE FROM Materias WHERE idMateria=" + id.Text + ";", conexion());
                apd.Fill(consulta);
                adp.Fill(consulta);
                dpa.Fill(consulta);
                MessageBox.Show("Maestro Eliminado");
            }
            catch (Exception)
            {
            }
        }
        public void EliminarApuntes(Label id)
        {
            DataTable consulta = new DataTable();
            try
            {
                MySqlDataAdapter adp = new MySqlDataAdapter("DELETE FROM Apuntes WHERE idApuntes=" + id.Text + ";", conexion());
                adp.Fill(consulta);
                MessageBox.Show("Apunte Eliminado");
            }
            catch (Exception)
            {
            }
        }
        public void EliminarUsuario(Label id)
        {
            DataTable consulta = new DataTable();
            MySqlDataAdapter delApuntes = new MySqlDataAdapter("DELETE FROM apuntes WHERE FKusuario="+id.Text+";", conexion());
            MySqlDataAdapter delUsuario = new MySqlDataAdapter("DELETE FROM administradores WHERE idAdministrador="+id.Text+";",conexion());
            delApuntes.Fill(consulta);
            delUsuario.Fill(consulta);
            MessageBox.Show("Usuario eliminado");
        }
        #endregion

        #region Metodos de Cargar Textos
        public void CargarUnidades(TextBox nombre, TextBox clave,Label unidad)
        {
            //SE CREA LA SENTENCIA SQL
            string sql = "SELECT idUnidad FROM unidades WHERE unidad = '" + nombre.Text + "' AND clave='"+clave.Text+"';";
            MySqlCommand comando = new MySqlCommand(sql, conexion()); //SE CARGA LA SENTENCIA SQL Y LA CONEXION A LA DB
            AbrirConexion(); //ABRIMOS LA CONEXION
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();//DECLARAMOS UN TIPO DE DATAREADER Y LE PONEMOS IGUAL A LA EJECUCION DEL COMANDO
                if (leer.Read() == true) //SI EL COMANDO FUE EJECUTADO CORRECTAMENTE
                {
                    unidad.Text = leer["idUnidad"].ToString(); //SE CARGA LA COLUMNA EN UN TEXTBOX
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            CerrarConexion();// SE CIERRA LA CONEXION
        }
        public void CargarUsuarios(Label nombre, Label id, TextBox usuario)
        {
            String sql = "SELECT * FROM administradores where usuario='" + usuario.Text + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion());
            AbrirConexion();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                id.Text = leer["idAdministrador"].ToString();
                nombre.Text = leer["nombre"].ToString();
            }
            CerrarConexion();
        }
        public void CargarFechas(Label semana, TextBox fechainicio, TextBox fechafin, ComboBox materia, ComboBox periodo)
        {
            string sql = "SELECT semana, fecha_inicio, fecha_final FROM fechas WHERE semana = " + semana.Text + " AND FKMateria = " + materia.SelectedValue + " AND FKPeriodo="+periodo.SelectedValue+";";
            MySqlCommand comando = new MySqlCommand(sql, conexion());
            AbrirConexion();
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    fechainicio.Text = leer["fecha_inicio"].ToString();
                    fechafin.Text = leer["fecha_final"].ToString();
                }
                else
                {
                    fechainicio.Clear();
                    fechafin.Clear();
                }
            }
            catch (Exception)
            {
                
            }
            CerrarConexion();
        }
        public void CargarHoras(TextBox horas, ComboBox materia)
        {
            String sql = "SELECT * FROM materias where materia='" + materia.Text + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion());
            AbrirConexion();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                horas.Text = leer["horasXsemana"].ToString();
            }
            CerrarConexion();
        }
        public void CargarCuatrimestre(TextBox cuatrimestre, ComboBox grupo)
        {
            try
            {
                String sql = "SELECT cuatrimestre FROM grupos,cuatrimestres, turnos WHERE idGrupo=" + grupo.SelectedValue + " AND FKCuatrimestre=idCuatrimestre AND FKTurno=idTurno;";
                MySqlCommand comando = new MySqlCommand(sql, conexion());
                AbrirConexion();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    cuatrimestre.Text = leer["cuatrimestre"].ToString();
                }
            }
            catch (Exception)
            {
               
            }
                CerrarConexion();
        }
        public void CargarTurno(TextBox turno, ComboBox grupo)
        {
            try
            {
                String sql = "SELECT turno FROM grupos,cuatrimestres, turnos WHERE idGrupo="+grupo.SelectedValue+" AND FKCuatrimestre=idCuatrimestre AND FKTurno=idTurno;";
                MySqlCommand comando = new MySqlCommand(sql, conexion());
                AbrirConexion();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    turno.Text = leer["turno"].ToString();
                }
            }
            catch (Exception)
            {
                
            }
            CerrarConexion();
        }
        public void CargarApuntes(ComboBox apunte, TextBox contenido)
        {
            String sql = "SELECT * FROM apuntes where nombre='" + apunte.Text + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion());
            AbrirConexion();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                contenido.Text = leer["contenido"].ToString();
            }
            CerrarConexion();
        }
        public void CargarUnidadesVista(Label semana, TextBox unidad, TextBox clave, TextBox descripcion, ComboBox materia, ComboBox periodo)
        {
            String sql = "SELECT unidad, clave, descripcion FROM fechas, unidades WHERE fkMateria = " + materia.SelectedValue + " AND fkPeriodo = " + periodo.SelectedValue + " AND fkUnidad = idUnidad AND semana = " + semana.Text +";";
            MySqlCommand comando = new MySqlCommand(sql, conexion());
            AbrirConexion();
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    unidad.Text = leer["Unidad"].ToString();
                    clave.Text = leer["clave"].ToString();
                    descripcion.Text = leer["descripcion"].ToString();
                }
                else
                {
                    unidad.Clear();
                    clave.Clear();
                    descripcion.Clear();
                }
            }
            catch (Exception)
            {

            }
            CerrarConexion();
        }
        #endregion

        #region Metodos de ComboBox
        public void comboTurno(ComboBox combo)
        {
            //código para llenar el comboBox
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM turnos", conexion());
            //se indica el nombre de la tabla
            da.Fill(ds, "Turnos");
            combo.DataSource = ds.Tables["Turnos"];
            //se especifica el campo de la tabla
            combo.ValueMember = "idTurno";
            combo.DisplayMember = "Turno";
        }
        public void comboCuatrimestre(ComboBox combo)
        {
            //código para llenar el comboBox
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Cuatrimestres", conexion());
            //se indica el nombre de la tabla
            da.Fill(ds, "Cuatrimestres");
            combo.DataSource = ds.Tables["Cuatrimestres"];
            //se especifica el campo de la tabla
            combo.ValueMember = "idCuatrimestre";
            combo.DisplayMember = "Cuatrimestre";
        }
        public void comboGrupo(ComboBox combo)
        {
            DataSet ds = new DataSet();

            MySqlDataAdapter tabla = new MySqlDataAdapter("SELECT * FROM Grupos", conexion());
            tabla.Fill(ds, "Grupos");
            combo.DataSource = ds.Tables["Grupos"];
            combo.ValueMember = "idGrupo";
            combo.DisplayMember = "Grupo";
        }
        public void ComboMateria(ComboBox combo)
        {
            DataSet ds = new DataSet();

            MySqlDataAdapter tabla = new MySqlDataAdapter("SELECT * FROM Materias", conexion());
            tabla.Fill(ds, "Materias");
            combo.DataSource = ds.Tables["Materias"];
            combo.ValueMember = "idMateria";
            combo.DisplayMember = "Materia";
        }
        public void ComboPeriodos(ComboBox combo)
        {
            DataSet ds = new DataSet();

            MySqlDataAdapter tabla = new MySqlDataAdapter("SELECT idPeriodo, concat(temporada, ' (',meses,') ',año) as Periodo FROM periodos;", conexion());
            tabla.Fill(ds, "Periodos");
            combo.DataSource = ds.Tables["Periodos"];
            combo.ValueMember = "idPeriodo";
            combo.DisplayMember = "Periodo";
        }
        public void ComboProfesor(ComboBox combo)
        {
            DataSet ds = new DataSet();

            MySqlDataAdapter tabla = new MySqlDataAdapter("SELECT idMaestro, concat(nombre,' ',apellido_P,' ',apellido_M) as Nombre FROM Maestros", conexion());
            tabla.Fill(ds, "Maestros");
            combo.DataSource = ds.Tables["Maestros"];
            combo.ValueMember = "idMaestro";
            combo.DisplayMember = "Nombre";
        }
        public void ComboMaestroMaterias(ComboBox combo, ComboBox materia)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter tabla = new MySqlDataAdapter("SELECT idMaestro,concat(nombre,' ',apellido_P,' ',apellido_M) as Nombre FROM materiamaestros, materias, maestros WHERE FkMateria=" + materia.SelectedValue + " AND FKMateria=idMateria AND FKMaestro=idMaestro;", conexion());
                tabla.Fill(ds, "Maestros");
                combo.DataSource = ds.Tables["Maestros"];
                combo.ValueMember = "idMaestro";
                combo.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

            }
        }
        public void ComboGrupoMateria(ComboBox combo, ComboBox materia)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter tabla = new MySqlDataAdapter("SELECT idGrupo, grupo FROM grupos, materias, grupomaterias WHERE FkMateria=" + materia.SelectedValue + " AND FKMateria=idMateria AND Fkgrupo=idGrupo;", conexion());
                tabla.Fill(ds, "Materias");
                combo.DataSource = ds.Tables["Materias"];
                combo.ValueMember = "idGrupo";
                combo.DisplayMember = "grupo";
            }
            catch (Exception ex)
            {

            }
        }
        public void ComboApuntes(ComboBox combo, Label id)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter tabla = new MySqlDataAdapter("SELECT * FROM apuntes WHERE FKUsuario =" + id.Text + ";", conexion());
                tabla.Fill(ds, "Apuntes");
                combo.DataSource = ds.Tables["Apuntes"];
                combo.ValueMember = "idApuntes";
                combo.DisplayMember = "nombre";
            }
            catch (Exception)
            {

            }
        }
        #endregion
    }
}
