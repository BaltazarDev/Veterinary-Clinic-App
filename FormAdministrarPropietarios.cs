using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormAdministrarPropietarios : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormAdministrarPropietarios()
        {
            InitializeComponent();
        }

        private void FormAdministrarPropietarios_Load(object sender, EventArgs e)
        {
            dGVPropietarios.DataSource = Instancia_SQLite.CargarTablaPropietarios();
            lblTitulo.Visible = false;
            pPropietario.Visible = false;

            dGVPropietarios.Width = 1000;
        }

        private void pbEditarProducto_Click(object sender, System.EventArgs e)
        {
            lblTitulo.Visible = true;
            lblTitulo.Text = "Modificar";
            pPropietario.Visible = true;

            txbNombrePropietario.Visible = true;
            txbApellidoP.Visible = true;
            txbApellidoM.Visible = true;
            txbTelefono.Visible = true;
            txbCorreo.Visible = true;
            txbDireccion.Visible = true;

            btnModificarPropietario.Visible = true;
            btnEliminarPropietario.Visible = false;

            dGVPropietarios.Width = 676;

            LimpiarCampos();
        }

        private void pbEliminarProducto_Click(object sender, System.EventArgs e)
        {
            lblTitulo.Visible = true;
            lblTitulo.Text = "Eliminar";
            pPropietario.Visible = true;

            txbNombrePropietario.ReadOnly = false;
            txbApellidoP.ReadOnly = false;
            txbApellidoM.ReadOnly = false;
            txbTelefono.ReadOnly = false;
            txbCorreo.ReadOnly = false;
            txbDireccion.ReadOnly = false;

            btnModificarPropietario.Visible = false;
            btnEliminarPropietario.Visible = true;

            dGVPropietarios.Width = 676;

            LimpiarCampos();
        }

        private void pbConsultar_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            pPropietario.Visible = false;

            dGVPropietarios.Width = 1000;
        }

        private void txbIDPropietario_TextChanged(object sender, System.EventArgs e)
        {
            //Realiza la consulta en la tabla propietarios donde la columna IdPropietario es igual al text box txbIdPropietario.
            //Esto hace que inmediatamente que se escriba en el text box del IdPropietario, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From propietarios Where IdPropietario = @IdPropietario", Conexion);
            comando.Parameters.AddWithValue("@IdPropietario", txbIDPropietario.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txbNombrePropietario.Text = registro["Nombre"].ToString();
                txbApellidoP.Text = registro["ApellidoP"].ToString();
                txbApellidoM.Text = registro["ApellidoM"].ToString();
                txbTelefono.Text = registro["Teléfono"].ToString();
                txbCorreo.Text = registro["Correo"].ToString();
                txbDireccion.Text = registro["Dirección"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void btnModificarPropietario_Click(object sender, System.EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update propietarios Set Nombre=@Nombre, ApellidoP=@ApellidoP, ApellidoM=@ApellidoM, Teléfono=@Telefono, Correo=@Correo, Dirección=@Direccion Where IdPropietario = @IdPropietario", Conexion);
                comando.Parameters.AddWithValue("@IdPropietario", int.Parse(txbIDPropietario.Text));
                comando.Parameters.AddWithValue("@Nombre", txbNombrePropietario.Text);
                comando.Parameters.AddWithValue("@ApellidoP", txbApellidoP.Text);
                comando.Parameters.AddWithValue("@ApellidoM", txbApellidoM.Text);
                comando.Parameters.AddWithValue("@Telefono", txbTelefono.Text);
                comando.Parameters.AddWithValue("@Correo", txbCorreo.Text);
                comando.Parameters.AddWithValue("@Direccion", txbDireccion.Text);

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Actualizados Correctamente!!", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Actualizar!!", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Update los textBox se limpian.
                LimpiarCampos();


                //Carga la tabla 
                dGVPropietarios.DataSource = Instancia_SQLite.CargarTablaPropietarios();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Faltan campos por llenar!");
            }
        }

        private void btnEliminarPropietario_Click(object sender, System.EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Delete from propietarios Where IdPropietario=@IdPropietario", Conexion);
                comando.Parameters.AddWithValue("@IdPropietario", int.Parse(txbIDPropietario.Text));
                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Registro Eliminado Correctamente!!", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Eliminar!!", "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Detele del registro se limpia el textBox.
                LimpiarCampos();


                //Carga la tabla Ventas
                dGVPropietarios.DataSource = Instancia_SQLite.CargarTablaPacientes();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Escriba el Id del propietario que eliminará.");
            }
        }

        private void LimpiarCampos()
        {
            txbIDPropietario.Clear();
            txbNombrePropietario.Clear();
            txbApellidoP.Clear();
            txbApellidoM.Clear();
            txbTelefono.Clear();
            txbCorreo.Clear();
            txbDireccion.Clear();
        }

        private void btnBuscarPropietario_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            //string consulta = "Select Codigo, Nombre, Descripcion, Presentacion, Precio, Stock  FROM productos WHERE Nombre=@Nombre";
            string consulta = "SELECT * FROM propietarios WHERE Nombre LIKE '%" + txbBuscarPropietario.Text + "%'";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            //db.SelectCommand.Parameters.AddWithValue("@Nombre", txbBuscarServicio.Text);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dGVPropietarios.DataSource = dt;

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void dGVPropietarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIDPropietario.Text = dGVPropietarios.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
