using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormRegistrarPacientes : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormRegistrarPacientes()
        {
            InitializeComponent();
        }

        private void FormRegistrarPacientes_Load(object sender, EventArgs e)
        {

        }

        private void txbIdPropietario_TextChanged(object sender, EventArgs e)
        {
            try
            {
            //Realiza la consulta en la tabla propietarios donde la columna IdPropietario es igual al text box txbIdPropietario.
            //Esto hace que inmediatamente que se escriba en el text box del IdPropietario, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From propietarios Where IdPropietario = @IdPropietario", Conexion);
            comando.Parameters.AddWithValue("@IdPropietario", txbIdPropietario.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lbNombrePropietario.Text = registro["Nombre"].ToString();
                lbApellidoP.Text = registro["ApellidoP"].ToString();
                lbApellidoM.Text = registro["ApellidoM"].ToString();
                lbTelefono.Text = registro["Teléfono"].ToString();
                lbCorreo.Text = registro["Correo"].ToString();
                lbDireccion.Text = registro["Dirección"].ToString();
            }
            registro.Close();
            Conexion.Close();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnInsertMascota_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into pacientes (IdPropietario, Propietario, Nombre_Paciente, Especie, Color, Años, Meses, Observaciones, Esterilizado, Status, Foto) values (@IdPropietario, @Propietario, @NombrePaciente, @Especie, @Color, @Años, @Meses, @Observaciones, @Esterilizado, @Status, @Foto)", Conexion);

                comando.Parameters.AddWithValue("@IdPropietario", int.Parse(txbIdPropietario.Text));
                comando.Parameters.AddWithValue("@Propietario", lbNombrePropietario.Text);
                comando.Parameters.AddWithValue("@NombrePaciente", txbNombreMascota.Text);
                comando.Parameters.AddWithValue("@Especie", txbEspecie.Text);
                comando.Parameters.AddWithValue("@Color", txbColor.Text);
                comando.Parameters.AddWithValue("@Años", txbAños.Text);
                comando.Parameters.AddWithValue("@Meses", txbMeses.Text);
                comando.Parameters.AddWithValue("@Observaciones", txbObservaciones.Text);
                comando.Parameters.AddWithValue("@Esterilizado", txbEsterilizado.Text);
                comando.Parameters.AddWithValue("@Status", txbStatus.Text);
                comando.Parameters.AddWithValue("@Foto", "Foto");

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpia los cuadros de texto despúes de insertar.
                LimpiarCampos();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Faltan campos por llenar!");
            }
        }

        private void LimpiarCampos()
        {

        }

        private void btnVerPropietarios_Click(object sender, EventArgs e)
        {
            dGVPropietario.DataSource = Instancia_SQLite.CargarTablaPropietarios();
        }

        private void btnBuscarPropietario_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            //string consulta = "Select Codigo, Nombre, Descripcion, Presentacion, Precio, Stock  FROM productos WHERE Nombre=@Nombre";
            string consulta = "SELECT * FROM propietarios WHERE Nombre LIKE '%" + txbBuscarPropietario.Text + "%'";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            //db.SelectCommand.Parameters.AddWithValue("@Nombre", txbBuscarProducto.Text);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dGVPropietario.DataSource = dt;

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void dGVPropietario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIdPropietario.Text = dGVPropietario.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
