using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormRegistrarPropietarios : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormRegistrarPropietarios()
        {
            InitializeComponent();
        }

        private void FormRegistrarPropietarios_Load(object sender, EventArgs e)
        {
            dGVPropietarios.DataSource = Instancia_SQLite.CargarTablaPropietarios();
        }

        private void btnInsertPropietario_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into propietarios (Nombre, ApellidoP, ApellidoM, Teléfono, Correo, Dirección) values (@Nombre,@ApellidoP,@ApellidoM,@Telefono,@Correo,@Direccion)", Conexion);

                comando.Parameters.AddWithValue("@Nombre", txbNombrePropietario.Text);
                comando.Parameters.AddWithValue("@ApellidoP", txbApellidoP.Text);
                comando.Parameters.AddWithValue("@ApellidoM", txbApellidoM.Text);
                comando.Parameters.AddWithValue("@Telefono", txbTelefono.Text);
                comando.Parameters.AddWithValue("@Correo", txbCorreo.Text);
                comando.Parameters.AddWithValue("@Direccion", txbDireccion.Text);

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpia los cuadros de texto despúes de insertar.
                LimpiarCampos();

                dGVPropietarios.DataSource = Instancia_SQLite.CargarTablaPropietarios();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Faltan campos por llenar!");
            }
        }

        private void LimpiarCampos()
        {
            txbNombrePropietario.Clear();
            txbApellidoP.Clear();
            txbApellidoM.Clear();
            txbTelefono.Clear();
            txbCorreo.Clear();
            txbDireccion.Clear();
        }

    }
}
