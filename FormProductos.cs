using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormProductos : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            //Carga la tabla cuando se abre el Form
            dGVProductos.DataSource = Instancia_SQLite.CargarTablaProductos();

            //Los campos y las funciones para Nuevo, Editar y Eliminar productos 
            //cargan de manera oculta hasta seleccionar una opción
            panelFuncionesProductos.Visible = false;
        }

        private void pbNuevoProducto_Click(object sender, EventArgs e)
        {
            panelFuncionesProductos.Visible = true;

            LimpiarCampos();

            lbTitulo.Text = "Nuevo Producto";

            btnNuevo.Visible = true;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;

            lbCodigo.Visible = false;
            txbCodigo.Visible = false;

            
            txbNombre.ReadOnly = false;
            txbDescripcion.ReadOnly = false;
            txbPresentacion.ReadOnly = false;
            txbPrecio.ReadOnly = false;
            txbStock.ReadOnly = false;

            dGVProductos.Enabled = false;
        }

        private void pbEditarProducto_Click(object sender, EventArgs e)
        {
            panelFuncionesProductos.Visible = true;

            LimpiarCampos();

            lbTitulo.Text = "Editar Producto";

            btnNuevo.Visible = false;
            btnModificar.Visible = true;
            btnEliminar.Visible = false;

            lbCodigo.Visible = true;
            txbCodigo.Visible = true;

            txbNombre.ReadOnly = false;
            txbDescripcion.ReadOnly = false;
            txbPresentacion.ReadOnly = false;
            txbPrecio.ReadOnly = false;
            txbStock.ReadOnly = false;

            dGVProductos.Enabled = true;
        }

        private void pbEliminarProducto_Click(object sender, EventArgs e)
        {
            panelFuncionesProductos.Visible = true;

            LimpiarCampos();

            lbTitulo.Text = "Eliminar Producto";

            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = true;

            lbCodigo.Visible = true;
            txbCodigo.Visible = true;

            txbNombre.ReadOnly = true;
            txbDescripcion.ReadOnly = true;
            txbPresentacion.ReadOnly = true;
            txbPrecio.ReadOnly = true;
            txbStock.ReadOnly = true;

            dGVProductos.Enabled = true;
        }

        private void txbCodigo_TextChanged(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla productos donde la columna Codigo es igual al text box txbCodigo.
            //Esto hace que inmediatamente que se escriba en el text box del Codigo, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From productos Where Codigo = @Codigo", Conexion);
            comando.Parameters.AddWithValue("@Codigo", txbCodigo.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txbNombre.Text = registro["Nombre"].ToString();
                txbDescripcion.Text = registro["Descripcion"].ToString();
                txbPresentacion.Text = registro["Presentacion"].ToString();
                txbPrecio.Text = registro["Precio"].ToString();
                txbStock.Text = registro["Stock"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into productos (Nombre, Descripcion, Presentacion, Precio, Stock) values (@Nombre,@Descripcion,@Presentacion,@Precio,@Stock)", Conexion);

                comando.Parameters.AddWithValue("@Nombre", txbNombre.Text);
                comando.Parameters.AddWithValue("@Descripcion", txbDescripcion.Text);
                comando.Parameters.AddWithValue("@Presentacion", txbPresentacion.Text);
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(txbPrecio.Text));
                comando.Parameters.AddWithValue("@Stock", int.Parse(txbStock.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpia los cuadros de texto despúes de insertar.
                LimpiarCampos();


                dGVProductos.DataSource = Instancia_SQLite.CargarTablaProductos();
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
                SQLiteCommand comando = new SQLiteCommand("Update productos Set Nombre=@Nombre, Descripcion=@Descripcion, Presentacion=@Presentacion, Precio=@Precio, Stock=@Stock Where Codigo = @Codigo", Conexion);
                comando.Parameters.AddWithValue("@Codigo", int.Parse(txbCodigo.Text));
                comando.Parameters.AddWithValue("@Nombre", txbNombre.Text);
                comando.Parameters.AddWithValue("@Descripcion", txbDescripcion.Text);
                comando.Parameters.AddWithValue("@Presentacion", txbPresentacion.Text);
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(txbPrecio.Text));
                comando.Parameters.AddWithValue("@Stock", int.Parse(txbStock.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Actualizados Correctamente!!", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Actualizar!!", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Update los textBox se limpian.
                LimpiarCampos();


                //Carga la tabla Ventas
                dGVProductos.DataSource = Instancia_SQLite.CargarTablaProductos();

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
                SQLiteCommand comando = new SQLiteCommand("Delete from productos Where Codigo=@Codigo", Conexion);
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
                dGVProductos.DataSource = Instancia_SQLite.CargarTablaProductos();
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
            txbPresentacion.Clear();
            txbPrecio.Clear();
            txbStock.Clear();
        }

        private void dGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dGVProductos.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            //string consulta = "Select Codigo, Nombre, Descripcion, Presentacion, Precio, Stock  FROM productos WHERE Nombre=@Nombre";
            string consulta = "SELECT * FROM productos WHERE Nombre LIKE '%"+txbBuscarProducto.Text+"%'";

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
            dGVProductos.DataSource = dt;

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }
    }
}
