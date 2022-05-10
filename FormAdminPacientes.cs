using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormAdminPacientes : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public FormAdminPacientes()
        {
            InitializeComponent();
        }

        private void FormAdminPacientes_Load(object sender, EventArgs e)
        {
            lbPaciente.Visible = false;
            lbPropietario.Visible = false;

            pPaciente.Visible = false;
            pPropietario.Visible = false;

            dGVPacientes.Width = 1000;

            dGVPacientes.DataSource = Instancia_SQLite.CargarTablaPacientes();
        }

        private void pbEditarProducto_Click(object sender, EventArgs e)
        {
            lbPaciente.Visible = true;
            lbPropietario.Visible = true;

            pPaciente.Visible = true;
            pPropietario.Visible = true;

            txbNombreMascota.ReadOnly = false;
            txbEspecie.ReadOnly = false;
            txbColor.ReadOnly = false;
            txbAños.ReadOnly = false;
            txbMeses.ReadOnly = false;
            txbObservaciones.ReadOnly = false;
            txbEsterilizado.ReadOnly = false;
            txbStatus.ReadOnly = false;
            txbIdPropietario.ReadOnly = false;
            btnAñadirFoto.Visible = true;

            btnModificar.Visible = true;
            btnEliminar.Visible = false;

            dGVPacientes.Width = 488;
        }

        private void pbEliminarProducto_Click(object sender, EventArgs e)
        {
            lbPaciente.Visible = true;
            lbPropietario.Visible = true;

            pPaciente.Visible = true;
            pPropietario.Visible = true;

            txbNombreMascota.ReadOnly = true;
            txbEspecie.ReadOnly = true;
            txbColor.ReadOnly = true;
            txbAños.ReadOnly = true;
            txbMeses.ReadOnly = true;
            txbObservaciones.ReadOnly = true;
            txbEsterilizado.ReadOnly = true;
            txbStatus.ReadOnly = true;
            txbIdPropietario.ReadOnly = true;
            btnAñadirFoto.Visible = false;

            btnModificar.Visible = false;
            btnEliminar.Visible = true;

            dGVPacientes.Width = 488;
        }

        private void pbConsultar_Click(object sender, EventArgs e)
        {
            lbPaciente.Visible = false;
            lbPropietario.Visible = false;

            pPaciente.Visible = false;
            pPropietario.Visible = false;

            dGVPacientes.Width = 1000;
        }

        private void txbIdMascota_TextChanged(object sender, System.EventArgs e)
        {
            //Realiza la consulta en la tabla propietarios donde la columna IdPropietario es igual al text box txbIdPropietario.
            //Esto hace que inmediatamente que se escriba en el text box del IdPropietario, comience a realizar la consulta y 
            //Mostrar en los textbox indicados lo recuperado de la consulta.
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            SQLiteCommand comando = new SQLiteCommand("Select * From pacientes Where IdPaciente = @IdPaciente", Conexion);
            comando.Parameters.AddWithValue("@IdPaciente", txbIdPaciente.Text);

            SQLiteDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txbIdPropietario.Text = registro["IdPropietario"].ToString();
                lbPropietario.Text = registro["Propietario"].ToString();
                txbNombreMascota.Text = registro["Nombre_Paciente"].ToString();
                txbEspecie.Text = registro["Especie"].ToString();
                txbColor.Text = registro["Color"].ToString();
                txbAños.Text = registro["Años"].ToString();
                txbMeses.Text = registro["Meses"].ToString();
                txbObservaciones.Text = registro["Observaciones"].ToString();
                txbEsterilizado.Text = registro["Esterilizado"].ToString();
                txbStatus.Text = registro["Status"].ToString();
                
            }
            registro.Close();
            Conexion.Close();
        }

        private void txbIdPropietario_TextChanged(object sender, System.EventArgs e)
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

        private void btnModificar_Click(object sender, System.EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                SQLiteCommand comando = new SQLiteCommand("Update pacientes Set IdPropietario=@IdPropietario, Propietario=@Propietario, Nombre_Paciente=@NombrePaciente, Especie=@Especie, Color=@Color, Años=@Años, Meses=@Meses, Observaciones=@Observaciones, Esterilizado=@Esterilizado, Status=@Status Where IdPaciente = @IdPaciente", Conexion);
                comando.Parameters.AddWithValue("@IdPaciente", int.Parse(txbIdPaciente.Text));
                comando.Parameters.AddWithValue("@IdPropietario", int.Parse(txbIdPropietario.Text));
                comando.Parameters.AddWithValue("@Propietario", lbPropietario.Text);
                comando.Parameters.AddWithValue("@NombrePaciente", txbNombreMascota.Text);
                comando.Parameters.AddWithValue("@Especie", txbEspecie.Text);
                comando.Parameters.AddWithValue("@Color", txbColor.Text);
                comando.Parameters.AddWithValue("@Años", txbAños.Text);
                comando.Parameters.AddWithValue("@Meses", txbMeses.Text);
                comando.Parameters.AddWithValue("@Observaciones", txbObservaciones.Text);
                comando.Parameters.AddWithValue("@Esterilizado", txbEsterilizado.Text);
                comando.Parameters.AddWithValue("@Status", txbStatus.Text);

                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Datos Actualizados Correctamente!!", "Actualizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Actualizar!!", "Error al Actualizar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Update los textBox se limpian.
                LimpiarCampos();


                //Carga la tabla 
                dGVPacientes.DataSource = Instancia_SQLite.CargarTablaPacientes();

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
                SQLiteCommand comando = new SQLiteCommand("Delete from pacientes Where IdPaciente=@IdPaciente", Conexion);
                comando.Parameters.AddWithValue("@IdPaciente", int.Parse(txbIdPaciente.Text));
                int Resultado = comando.ExecuteNonQuery();

                Conexion.Close();

                if (Resultado > 0)
                    MessageBox.Show("Registro Eliminado Correctamente!!", "Eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Eliminar!!", "Error al Eliminar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Después del Detele del registro se limpia el textBox.
                LimpiarCampos();


                //Carga la tabla Ventas
                dGVPacientes.DataSource = Instancia_SQLite.CargarTablaPacientes();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Escriba el Id del paciente que eliminará.");
            }
        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
            //string consulta = "Select Codigo, Nombre, Descripcion, Presentacion, Precio, Stock  FROM productos WHERE Nombre=@Nombre";
            string consulta = "SELECT * FROM pacientes WHERE Nombre_Paciente LIKE '%" + txbBuscarPaciente.Text + "%'";

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
            dGVPacientes.DataSource = dt;

            // Y ya podemos cerrar la conexion
            Conexion.Close();
        }

        private void LimpiarCampos()
        {

        }

        private void dGVPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIdPaciente.Text = dGVPacientes.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
