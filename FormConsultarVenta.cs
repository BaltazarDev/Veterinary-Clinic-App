using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormConsultarVenta : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormConsultarVenta()
        {
            InitializeComponent();
        }

        private void FormConsultarVenta_Load(object sender, EventArgs e)
        {
            //Carga la tabla cuando se abre el Form
            dGVVentas.DataSource = Instancia_SQLite.CargarTablaVentas();

            FormatoFechas();

            lbTituloEliminar.Text = "";
            txbEliminarIDventa.Clear();
            txbEliminarIDventa.Visible = false;
            btnEliminarIDVenta.Visible = false;
            txbEliminarTransaccion.Clear();
            txbEliminarTransaccion.Visible = false;
            btnEliminarTransaccion.Visible = false;

            Codigo.Visible = false;
            lbCodigo.Text = "";
            lbCodigo.Visible = false;
            Transaccion.Visible = false;
            lbTransaccion.Text = "";
            lbTransaccion.Visible = false;
            Nombre.Visible = false;
            lbNombre.Text = "";
            lbNombre.Visible = false;
            Cantidad.Visible = false;
            lbCantidad.Text = "";
            lbCantidad.Visible = false;
            Precio.Visible = false;
            lbPrecio.Text = "";
            lbPrecio.Visible = false;
            Total.Visible = false;
            lbTotal.Text = "";
            lbTotal.Visible = false;
            Fecha.Visible = false;
            lbFecha.Text = "";
            lbFecha.Visible = false;
        }

        private void FormatoFechas()
        {
            //Formato de fecha de los dateTimePicker
            dateTimePickerFechaInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaInicio.CustomFormat = "yyyy-MM-dd";

            dateTimePickerFechaFin.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaFin.CustomFormat = "yyyy-MM-dd";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDVenta, Codigo, Transaccion, Tipo, Nombre, Cantidad, Precio, Total, Fecha FROM ventas WHERE Fecha BETWEEN @FechaInicio AND @FechaFin ORDER BY Fecha";
            //string consulta = "SELECT datetime(FCreacion) as FCreacion FROM  Ventas;";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            db.SelectCommand.Parameters.AddWithValue("@FechaInicio", dateTimePickerFechaInicio.Text);
            db.SelectCommand.Parameters.AddWithValue("@FechaFin", dateTimePickerFechaFin.Text);

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dGVVentas.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dGVVentas.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["Total"].Value);
            //Mostrar resultado
            txbTotal.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void btnBuscarTransaccion_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            string consulta = "Select IDVenta, Codigo, Transaccion, Tipo, Nombre, Cantidad, Precio, Total, Fecha FROM ventas WHERE Transaccion=@Transaccion";
            //string consulta = "SELECT datetime(FCreacion) as FCreacion FROM  Ventas;";

            // Adaptador de datos, DataSet y tabla
            SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
            db.SelectCommand.Parameters.AddWithValue("@Transaccion", int.Parse(txbTransaccion.Text));

            DataSet ds = new DataSet();
            ds.Reset();

            DataTable dt = new DataTable();
            db.Fill(ds);

            //Asigna al DataTable la primer tabla ventas
            // y la mostramos en el DataGridView
            dt = ds.Tables[0];
            dGVVentas.DataSource = dt;

            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dGVVentas.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["Total"].Value);
            //Mostrar resultado
            txbTotal.Text = totalMonto.ToString("N2");

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void brnRecargar_Click(object sender, EventArgs e)
        {
            dGVVentas.DataSource = Instancia_SQLite.CargarTablaVentas();

            FormatoFechas();

            txbTransaccion.Clear();
            txbTotal.Text = "0.00";
        }

        private void pbEliminarProductoServicio_Click(object sender, EventArgs e)
        {
            lbTituloEliminar.Text = "Eliminar por IDventa";
            txbEliminarIDventa.Clear();
            txbEliminarIDventa.Visible = true;
            btnEliminarIDVenta.Visible = true;
            txbEliminarTransaccion.Clear();
            txbEliminarTransaccion.Visible = false;
            btnEliminarTransaccion.Visible = false;

            Codigo.Visible = true;
            lbCodigo.Text = "";
            lbCodigo.Visible = true;
            Transaccion.Visible = true;
            lbTransaccion.Text = "";
            lbTransaccion.Visible = true;
            Nombre.Visible = true;
            lbNombre.Text = "";
            lbNombre.Visible = true;
            Cantidad.Visible = true;
            lbCantidad.Text = "";
            lbCantidad.Visible = true;
            Precio.Visible = true;
            lbPrecio.Text = "";
            lbPrecio.Visible = true;
            Total.Visible = true;
            lbTotal.Text = "";
            lbTotal.Visible = true;
            Fecha.Visible = true;
            lbFecha.Text = "";
            lbFecha.Visible = true;
        }

        private void pbElimiarTransaccion_Click(object sender, EventArgs e)
        {
            lbTituloEliminar.Text = "Eliminar transaccion";
            txbEliminarIDventa.Clear();
            txbEliminarIDventa.Visible = false;
            btnEliminarIDVenta.Visible = false;
            txbEliminarTransaccion.Clear();
            txbEliminarTransaccion.Visible = true;
            btnEliminarTransaccion.Visible = true;

            Codigo.Visible = false;
            lbCodigo.Text = "";
            lbCodigo.Visible = false;
            Transaccion.Visible = false;
            lbTransaccion.Text = "";
            lbTransaccion.Visible = false;
            Nombre.Visible = false;
            lbNombre.Text = "";
            lbNombre.Visible = false;
            Cantidad.Visible = false;
            lbCantidad.Text = "";
            lbCantidad.Visible = false;
            Precio.Visible = false;
            lbPrecio.Text = "";
            lbPrecio.Visible = false;
            Total.Visible = false;
            lbTotal.Text = "";
            lbTotal.Visible = false;
            Fecha.Visible = false;
            lbFecha.Text = "";
            lbFecha.Visible = false;
        }

        private void txbEliminarIDventa_TextChanged(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From ventas Where IDventa = @IDventa", Conexion);
            comando.Parameters.AddWithValue("@IDventa", txbEliminarIDventa.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lbCodigo.Text = registro["Codigo"].ToString();
                lbTransaccion.Text = registro["Transaccion"].ToString();
                lbNombre.Text = registro["Nombre"].ToString();
                lbCantidad.Text = registro["Cantidad"].ToString();
                lbPrecio.Text = registro["Precio"].ToString();
                lbTotal.Text = registro["Total"].ToString();
                lbFecha.Text = registro["Fecha"].ToString();
            }
            registro.Close();
            Conexion.Close();
        }

        private void UpdateProductoStock()
        {
            //Modifica el Stock con respecto a la compra de los productos
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update productos Set Stock=Stock + @Cantidad Where Codigo = @Codigo", Conexion);

                comando.Parameters.AddWithValue("@Codigo", int.Parse(lbCodigo.Text));
                comando.Parameters.AddWithValue("@Cantidad", int.Parse(lbCantidad.Text));

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("¡Error al regresar el inventario!");
            }
        }

        private void btnEliminarIDVenta_Click(object sender, EventArgs e)
        {
            UpdateProductoStock();

            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Delete from ventas Where IDventa=@IDventa", Conexion);
                comando.Parameters.AddWithValue("@IDventa", int.Parse(txbEliminarIDventa.Text));
                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Registro Eliminado Correctamente!!", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Eliminar!!", "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Carga la tabla Ventas
                dGVVentas.DataSource = Instancia_SQLite.CargarTablaVentas();

                txbEliminarIDventa.Clear();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Escriba el ID de venta del producto que eliminará.");
            }
        }

        private void txbEliminarTransaccion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                string consulta = "Select IDVenta, Codigo, Transaccion, Tipo, Nombre, Cantidad, Precio, Total, Fecha FROM ventas WHERE Transaccion=@Transaccion";
                //string consulta = "SELECT datetime(FCreacion) as FCreacion FROM  Ventas;";

                // Adaptador de datos, DataSet y tabla
                SQLiteDataAdapter db = new SQLiteDataAdapter(consulta, Conexion);
                db.SelectCommand.Parameters.AddWithValue("@Transaccion", int.Parse(txbEliminarTransaccion.Text));

                DataSet ds = new DataSet();
                ds.Reset();

                DataTable dt = new DataTable();
                db.Fill(ds);

                //Asigna al DataTable la primer tabla ventas
                // y la mostramos en el DataGridView
                dt = ds.Tables[0];
                dGVVentas.DataSource = dt;

                decimal totalMonto = 0;
                foreach (DataGridViewRow row in dGVVentas.Rows)
                    totalMonto += Convert.ToDecimal(row.Cells["Total"].Value);
                //Mostrar resultado
                txbTotal.Text = totalMonto.ToString("N2");

                // Y ya podemos cerrar la conexion
                Conexion.Close();
            }
            catch (Exception)
            {

            }
        }

        private void UpdateProductosTransaccion()
        {
            //Modifica el Stock con respecto a la compra de los productos
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update productos Set Stock=Stock + @Cantidad Where Codigo = @Codigo", Conexion);

                foreach (DataGridViewRow row in dGVVentas.Rows)
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
                System.Windows.Forms.MessageBox.Show("¡Error al regresar inventario!");
            }
        }

        private void btnEliminarTransaccion_Click(object sender, EventArgs e)
        {
            UpdateProductosTransaccion();
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Delete from ventas Where Transaccion=@Transaccion", Conexion);
                comando.Parameters.AddWithValue("@Transaccion", int.Parse(txbEliminarTransaccion.Text));
                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Registro Eliminado Correctamente!!", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Eliminar!!", "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Carga la tabla Ventas
                dGVVentas.DataSource = Instancia_SQLite.CargarTablaVentas();

                txbEliminarIDventa.Clear();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Escriba la transaccion de venta que eliminará.");
            }
        }

        private void dGVVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbEliminarIDventa.Text = dGVVentas.CurrentRow.Cells[0].Value.ToString();
            //txbEliminarTransaccion.Text = dGVVentas.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
