using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormVenta : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormVenta()
        {
            InitializeComponent();

            //Muestra la fecha en el textbox de FechaHoy
            txbFechaHoy.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            //Carga la tabla cuando se abre el Form
            dGVProductos.DataSource = Instancia_SQLite.CargarTablaProductos();
            dGVServicios.DataSource = Instancia_SQLite.CargarTablaServicios();

            //Vacia las tablas temporales productos y servicios antes de cargar datos
            VaciarTablaCarritoProductos();
            VaciarTablaCarritoServicios();

            //Los paneles para añadir productos y servicios cargan de forma oculta
            pAñadirProductos.Visible = false;
            pAñadirServicios.Visible = false;

            FuncionTransaccion();

            //Limpia los campos de caja
            LimpiaCamposProductos();
            LimpiaCamposServicios();
            //Limpia los campos Monetarios
            LimpiaCamposMonetarios();
        }

        #region Limpieza Campos
        private void LimpiaCamposProductos()
        {
            txbCodigoProductoCaja.Clear();
            lbNombreProducto.Text = "";
            lbDescripcionProducto.Text = "";
            lbPresentacionProducto.Text = "";
            lbStockProducto.Text = "";
            lbPrecioProducto.Text = "0.00";
            txbCantidadProducto.Clear();
            lbTotalCantidadPorPrecioProducto.Text = "0.00";
        }

        private void LimpiaCamposServicios()
        {
            txbCodigoServicioCaja.Clear();
            lbNombreServicio.Text = "";
            lbDescripcionServicio.Text = "";
            lbPrecioServicio.Text = "0.00";
            txbCantidadServicio.Clear();
            lbTotalCantidadPorPrecioServicio.Text = "0.00";
        }

        private void LimpiaCamposMonetarios()
        {
            lbTotalAPagarProductos.Text = "0.00";
            lbTotalAPagarServicios.Text = "0.00";
            lbTotalaPagarFinal.Text = "0.00";
            txbEfectivo.Clear();
            lbCambio.Text = "0.00";
        }
        #endregion Limpieza Campos

        #region Productos
        //INICIO****************PRODUCTOS*********************
        private void dGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigoProductoCaja.Text = dGVProductos.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            //string consulta = "Select Codigo, Nombre, Descripcion, Presentacion, Precio, Stock  FROM productos WHERE Nombre=@Nombre";
            string consulta = "SELECT * FROM productos WHERE Nombre LIKE '%" + txbBuscarProducto.Text + "%'";

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
            dGVProductos.DataSource = dt;

            // Y ya podemos cerrar la conexion
            Conexion.Close();

            txbBuscarProducto.Clear();
        }

        private void btnRecargarTProductos_Click(object sender, EventArgs e)
        {
            dGVProductos.DataSource = Instancia_SQLite.CargarTablaProductos();
        }

        private void pbAñadirProductos_Click(object sender, EventArgs e)
        {
            lbTituloCaja.Text = "Caja: Añadir Productos";

            pAñadirProductos.Visible = true;
            pAñadirServicios.Visible = false;
        }

        private void txbCodigoProductoCaja_TextChanged(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Productos donde la columna Codigo es igual al text box txbCodigo.
            //Esto hace que inmediatamente que se escriba en el text box del Codigo, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From productos Where Codigo = @Codigo", Conexion);
            comando.Parameters.AddWithValue("@Codigo", txbCodigoProductoCaja.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lbNombreProducto.Text = registro["Nombre"].ToString();
                lbDescripcionProducto.Text = registro["Descripcion"].ToString();
                lbPresentacionProducto.Text = registro["Presentacion"].ToString();
                lbStockProducto.Text = registro["Stock"].ToString();
                lbPrecioProducto.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal totalProd;

                totalProd = decimal.Parse(lbPrecioProducto.Text) * int.Parse(txbCantidadProducto.Text);
                lbTotalCantidadPorPrecioProducto.Text = totalProd.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnAñadirProductoTabla_Click(object sender, EventArgs e)
        {
            AñadirProductoATablaCarritoCompras();

            //Ejecuta la función para sumar el total de productos y el total de servicios
            //para dar el total a pagar final
            CalcularTotalaPagarFinal();

            //Limpia los cuadros de texto despúes de insertar.
            LimpiaCamposProductos();
        }

        private void txbEfectivo_TextChanged(object sender, EventArgs e)
        {
            //Calcular el cambio del efectivo total ingresado
            try
            {
                decimal totalapagar;

                totalapagar = decimal.Parse(txbEfectivo.Text) - decimal.Parse(lbTotalaPagarFinal.Text);
                lbCambio.Text = totalapagar.ToString();
            }
            catch (Exception)
            {

            }
        }
        //END*****************PRODUCTOS***********************
        #endregion Productos

        #region Funciones Productos
        //INICIO********************FUNCIONES PRODUCTOS***********************************
        private void FuncionTransaccion()
        {
            //Busca el ultimo ID de transacción para asignar el siguiente ID a la venta nueva
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("SELECT * FROM ventas ORDER BY Transaccion DESC LIMIT 1", Conexion);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lbTransaccion.Text = registro["Transaccion"].ToString();

                //Suma un 1 al ID encontrado para dar la continuidad al Insert con el siguiente ID correcto
                int numtransaccion;
                numtransaccion = int.Parse(lbTransaccion.Text) + 1;
                lbTransaccion.Text = numtransaccion.ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void AñadirProductoATablaCarritoCompras()
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into carritoproductos (Codigo, Transaccion, Tipo, Nombre, Cantidad, Precio, Total) values (@Codigo, @Transaccion, @Tipo, @Nombre, @Cantidad, @Precio, @Total)", Conexion);

                comando.Parameters.AddWithValue("@Codigo", int.Parse(txbCodigoProductoCaja.Text));
                comando.Parameters.AddWithValue("@Transaccion", int.Parse(lbTransaccion.Text));
                comando.Parameters.AddWithValue("@Tipo", "Producto");
                comando.Parameters.AddWithValue("@Nombre", lbNombreProducto.Text);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txbCantidadProducto.Text));
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(lbPrecioProducto.Text));
                comando.Parameters.AddWithValue("@Total", decimal.Parse(lbTotalCantidadPorPrecioProducto.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                {
                    //MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error al añadir el producto!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                //Carga la tabla con los datos actualizados
                dGVCarritoProductos.DataSource = Instancia_SQLite.CargarTablaCarritoProductos();

                //Suma la columna total del data grid view para obtener el total de cada fila
                decimal totalMontoP = 0;
                foreach (DataGridViewRow row in dGVCarritoProductos.Rows)
                    totalMontoP += Convert.ToDecimal(row.Cells["Total"].Value);
                //Mostrar resultado
                lbTotalAPagarProductos.Text = totalMontoP.ToString("N2");

                //Cierra Conexión
                Conexion.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Faltan campos por llenar!");
            }
        }

        private void UpdateProductosStock()
        {
            //Modifica el Stock con respecto a la compra de los productos
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update productos Set Stock=Stock - @Cantidad Where Codigo = @Codigo", Conexion);

                foreach (DataGridViewRow row in dGVCarritoProductos.Rows)
                {
                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));
                    comando.Parameters.AddWithValue("@Codigo", Convert.ToInt32(row.Cells["Codigo"].Value));

                    comando.ExecuteNonQuery();
                }
                //comando.Parameters.AddWithValue("@Codigo", int.Parse(txbCodigoCaja.Text));
                //comando.Parameters.AddWithValue("@Cantidad", int.Parse(txbCantidad.Text));

                //int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Error al restar inventario!");
            }
        }

        private void VaciarTablaCarritoProductos()
        {
            try
            {
                //Borra todo el contenido de la tabla carritoproductos
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("DELETE FROM carritoproductos", Conexion);

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                //Refresca la tabla carritoproductos 
                dGVCarritoProductos.DataSource = Instancia_SQLite.CargarTablaCarritoProductos();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Algo fallo al vaciar la tabla!");
            }
        }
        //END*********************************FUNCIONES PRODUCTOS***********************
        #endregion Funciones Productos

        #region Servicios
        //INICIO***************SERVICIOS**********************
        private void dGVServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigoServicioCaja.Text = dGVServicios.CurrentRow.Cells[0].Value.ToString();
        }

        private void pbAñadirServicios_Click(object sender, EventArgs e)
        {
            lbTituloCaja.Text = "Caja: Añadir Servicios";

            

            pAñadirProductos.Visible = false;
            pAñadirServicios.Visible = true;
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

            txbBuscarServicio.Clear();
        }

        private void btnRecargarTServicios_Click(object sender, EventArgs e)
        {
            dGVServicios.DataSource = Instancia_SQLite.CargarTablaServicios();
        }

        private void txbCodigoServicioCaja_TextChanged(object sender, EventArgs e)
        {
            //Realiza la consulta en la tabla Servicios donde la columna Codigo es igual al text box txbCodigo.
            //Esto hace que inmediatamente que se escriba en el text box del Codigo, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From servicios Where Codigo = @Codigo", Conexion);
            comando.Parameters.AddWithValue("@Codigo", txbCodigoServicioCaja.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lbNombreServicio.Text = registro["Nombre"].ToString();
                lbDescripcionServicio.Text = registro["Descripcion"].ToString();
                lbPrecioServicio.Text = registro["Precio"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void txbCantidadServicio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal totalServ;

                totalServ = decimal.Parse(lbPrecioServicio.Text) * int.Parse(txbCantidadServicio.Text);
                lbTotalCantidadPorPrecioServicio.Text = totalServ.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnAñadirServicioTabla_Click(object sender, EventArgs e)
        {
            AñadirServicioATablaCarritoCompras();

            //Ejecuta la función para sumar el total de productos y el total de servicios
            //para dar el total a pagar final
            CalcularTotalaPagarFinal();

            //Limpia campos después de insertar a la tabla
            LimpiaCamposServicios();
        }
        //END**********************SERVICIOS*************************************
        #endregion Servicios

        #region Funciones Servicios
        private void AñadirServicioATablaCarritoCompras()
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into carritoservicios (Codigo, Transaccion, Tipo, Nombre, Cantidad, Precio, Total) values (@Codigo, @Transaccion, @Tipo, @Nombre, @Cantidad, @Precio, @Total)", Conexion);

                comando.Parameters.AddWithValue("@Codigo", int.Parse(txbCodigoServicioCaja.Text));
                comando.Parameters.AddWithValue("@Transaccion", int.Parse(lbTransaccion.Text));
                comando.Parameters.AddWithValue("@Tipo", "Servicio");
                comando.Parameters.AddWithValue("@Nombre", lbNombreServicio.Text);
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(txbCantidadServicio.Text));
                comando.Parameters.AddWithValue("@Precio", decimal.Parse(lbPrecioServicio.Text));
                comando.Parameters.AddWithValue("@Total", decimal.Parse(lbTotalCantidadPorPrecioServicio.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                {
                    //MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al añadir un servicio!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //Limpia los cuadros de texto despúes de insertar.


                dGVCarritoServicios.DataSource = Instancia_SQLite.CargarTablaCarritoServicios();

                //Suma la columna total del data grid view para obtener el total de cada fila
                decimal totalMontoS = 0;
                foreach (DataGridViewRow row in dGVCarritoServicios.Rows)
                    totalMontoS += Convert.ToDecimal(row.Cells["Total"].Value);
                //Mostrar resultado
                lbTotalAPagarServicios.Text = totalMontoS.ToString("N2");

                Conexion.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Faltan campos por llenar!");
            }
        }

        private void VaciarTablaCarritoServicios()
        {
            try
            {
                //Borra todo el contenido de la tabla carritoproductos
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("DELETE FROM carritoservicios", Conexion);

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                //Refresca la tabla carritoproductos 
                dGVCarritoServicios.DataSource = Instancia_SQLite.CargarTablaCarritoServicios();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Algo fallo al vaciar la tabla!");
            }
        }
        #endregion Funciones Servicios

        private void CalcularTotalaPagarFinal()
        {
            try
            {
                decimal totalaPagarF;

                totalaPagarF = decimal.Parse(lbTotalAPagarProductos.Text) + decimal.Parse(lbTotalAPagarServicios.Text);
                lbTotalaPagarFinal.Text = totalaPagarF.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void InsertaVentaNueva()
        {
            //Inserta en la tabla ventas para registrar la compra
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Insert into ventas (Codigo, Transaccion, Tipo, Nombre, Cantidad, Precio, Total, Fecha) values (@Codigo, @Transaccion, @Tipo, @Nombre, @Cantidad, @Precio, @Total, @Fecha)", Conexion);

                foreach (DataGridViewRow row in dGVCarritoProductos.Rows)
                {
                    comando.Parameters.AddWithValue("@Codigo", Convert.ToInt32(row.Cells["Codigo"].Value));
                    comando.Parameters.AddWithValue("@Transaccion", Convert.ToInt32(row.Cells["Transaccion"].Value));
                    comando.Parameters.AddWithValue("@Tipo", Convert.ToString(row.Cells["Tipo"].Value));
                    comando.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["Nombre"].Value));
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));
                    comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(row.Cells["Precio"].Value));
                    comando.Parameters.AddWithValue("@Total", Convert.ToDecimal(row.Cells["Total"].Value));
                    comando.Parameters.AddWithValue("@Fecha", (txbFechaHoy.Text));

                    comando.ExecuteNonQuery();
                }

                foreach (DataGridViewRow row in dGVCarritoServicios.Rows)
                {
                    comando.Parameters.AddWithValue("@Codigo", Convert.ToInt32(row.Cells["Codigo"].Value));
                    comando.Parameters.AddWithValue("@Transaccion", Convert.ToInt32(row.Cells["Transaccion"].Value));
                    comando.Parameters.AddWithValue("@Tipo", Convert.ToString(row.Cells["Tipo"].Value));
                    comando.Parameters.AddWithValue("@Nombre", Convert.ToString(row.Cells["Nombre"].Value));
                    comando.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells["Cantidad"].Value));
                    comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(row.Cells["Precio"].Value));
                    comando.Parameters.AddWithValue("@Total", Convert.ToDecimal(row.Cells["Total"].Value));
                    comando.Parameters.AddWithValue("@Fecha", (txbFechaHoy.Text));

                    comando.ExecuteNonQuery();
                }
                //comando.parameters.addwithvalue("@productos", "productos...");
                //comando.parameters.addwithvalue("@cantidad", "0");
                //comando.Parameters.AddWithValue("@Total", decimal.Parse(txbTotal.Text));

                //int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                //if (Resultado > 0)
                //    MessageBox.Show("Venta realizada con exito", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //    MessageBox.Show("Error al realizar la venta!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Faltan campos por llenar!");
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            //Vaciar las tablas temporales de productos y servicios
            VaciarTablaCarritoProductos();
            VaciarTablaCarritoServicios();

            //Limpia los campos de caja
            LimpiaCamposProductos();
            LimpiaCamposServicios();

            //Limpia los campos Monetarios
            LimpiaCamposMonetarios();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            InsertaVentaNueva();

            UpdateProductosStock();

            //Vacia la tabla de carrito de productos y servicios
            VaciarTablaCarritoProductos();
            VaciarTablaCarritoServicios();

            //Limpia los textbox y labels
            LimpiaCamposProductos();
            LimpiaCamposServicios();
            LimpiaCamposMonetarios();

            //Carga la tabla de productos para mostrar los datos actualizados después de restar el stock
            dGVProductos.DataSource = Instancia_SQLite.CargarTablaProductos();
        }

    }
}
