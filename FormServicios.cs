using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormServicios : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormServicios()
        {
            InitializeComponent();
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {
            //Carga la tabla cuando se abre el Form
            dGVServicios.DataSource = Instancia_SQLite.CargarTablaServicios();

            //Los campos y las funciones para Nuevo, Editar y Eliminar productos 
            //cargan de manera oculta hasta seleccionar una opción
            panelFuncionesServicios.Visible = false;
        }

        private void pbNuevoServicio_Click(object sender, EventArgs e)
        {
            panelFuncionesServicios.Visible = true;

            LimpiarCampos();

            lbTitulo.Text = "Nuevo Servicio";

            btnNuevo.Visible = true;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;

            lbCodigo.Visible = false;
            txbCodigo.Visible = false;

            txbNombre.ReadOnly = false;
            txbDescripcion.ReadOnly = false;
            txbPrecio.ReadOnly = false;
        }

        private void pbEditarServicio_Click(object sender, EventArgs e)
        {
            panelFuncionesServicios.Visible = true;

            LimpiarCampos();

            lbTitulo.Text = "Editar Servicio";

            btnNuevo.Visible = false;
            btnModificar.Visible = true;
            btnEliminar.Visible = false;

            lbCodigo.Visible = true;
            txbCodigo.Visible = true;

            txbNombre.ReadOnly = false;
            txbDescripcion.ReadOnly = false;
            txbPrecio.ReadOnly = false;
        }

        private void pbEliminarServicio_Click(object sender, EventArgs e)
        {
            panelFuncionesServicios.Visible = true;

            LimpiarCampos();

            lbTitulo.Text = "Eliminar Servicio";

            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = true;

            lbCodigo.Visible = true;
            txbCodigo.Visible = true;

            txbNombre.ReadOnly = true;
            txbDescripcion.ReadOnly = true;
            txbPrecio.ReadOnly = true;
        }

        private void txbCodigo_TextChanged(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla servicios donde la columna Codigo es igual al text box txbCodigo.
            //Esto hace que inmediatamente que se escriba en el text box del Codigo, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From servicios Where Codigo = @Codigo", Conexion);
            comando.Parameters.AddWithValue("@Codigo", txbCodigo.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txbNombre.Text = registro["Nombre"].ToString();
                txbDescripcion.Text = registro["Descripcion"].ToString();
                txbPrecio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into servicios (Nombre, Descripcion, Precio) values (@Nombre,@Descripcion,@Precio)", Conexion);

                comando.Parameters.AddWithValue("@Nombre", txbNombre.Text);
                comando.Parameters.AddWithValue("@Descripcion", txbDescripcion.Text);
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(txbPrecio.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpia los cuadros de texto despúes de insertar.
                LimpiarCampos();


                dGVServicios.DataSource = Instancia_SQLite.CargarTablaServicios();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Faltan campos por llenar!");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update servicios Set Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio Where Codigo = @Codigo", Conexion);
                comando.Parameters.AddWithValue("@Codigo", int.Parse(txbCodigo.Text));
                comando.Parameters.AddWithValue("@Nombre", txbNombre.Text);
                comando.Parameters.AddWithValue("@Descripcion", txbDescripcion.Text);
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(txbPrecio.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Actualizados Correctamente!!", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Actualizar!!", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Update los textBox se limpian.
                LimpiarCampos();


                //Carga la tabla Ventas
                dGVServicios.DataSource = Instancia_SQLite.CargarTablaServicios();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Faltan campos por llenar!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Delete from servicios Where Codigo=@Codigo", Conexion);
                comando.Parameters.AddWithValue("@Codigo", int.Parse(txbCodigo.Text));
                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Registro Eliminado Correctamente!!", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Eliminar!!", "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Detele del registro se limpia el textBox.
                LimpiarCampos();


                //Carga la tabla Ventas
                dGVServicios.DataSource = Instancia_SQLite.CargarTablaServicios();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Escriba el Código de producto que eliminará.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            txbCodigo.Clear();
            txbNombre.Clear();
            txbDescripcion.Clear();
            txbPrecio.Clear();
        }

        private void dGVServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dGVServicios.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            //string consulta = "Select Codigo, Nombre, Descripcion, Presentacion, Precio, Stock  FROM productos WHERE Nombre=@Nombre";
            string consulta = "SELECT * FROM servicios WHERE Nombre LIKE '%" + txbBuscarServicio.Text + "%'";

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
            dGVServicios.DataSource = dt;

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }
    }
}
