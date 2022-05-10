using System;
using System.Data;
using System.Data.SQLite;

namespace Veterinary_Clinic_App
{
    class ConexionSQLite
    {
        SQLiteConnection Conexion;

        public static SQLiteConnection ObtenerConexion()
        {
            SQLiteConnection Conn = new SQLiteConnection("Data Source= F:\\balta\\Documents\\Visual Studio Proyectos\\Veterinary Clinic App\\bd_VCA.db3; Version=3");
            //SQLiteConnection Conn = new SQLiteConnection("Data Source= C:\\VeterinaryClinicApp\\bd_VCA.db3; Version=3");
            Conn.Open();
            return Conn;
        }

        public void AbrirConexion()
        {
            Conexion = new SQLiteConnection("Data Source= F:\\balta\\Documents\\Visual Studio Proyectos\\Veterinary Clinic App\\bd_VCA.db3; Version=3");
            //Conexion = new SQLiteConnection("Data Source= C:\\VeterinaryClinicApp\\bd_VCA.db3; Version=3");
            Conexion.Open();
        }

        public void Desconectar()
        {
            Conexion.Close();
        }

        public void CrearBaseDatos()
        {
            //this.AbrirConexion();

            //try
            //{
            //    String comando = "Create Table Venta (" +
            //        "Producto VARCHAR(30), Cantidad INTEGER" + ")";

            //    SQLiteCommand SQLiteComando = new SQLiteCommand(comando, Conexion);

            //    int error = SQLiteComando.ExecuteNonQuery();
            //}
            //catch (Exception) { }

            //this.Desconectar();
        }

        public DataTable CargarTablaProductos()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from productos ORDER BY codigo DESC";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;

        }

        public DataTable CargarTablaServicios()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from servicios ORDER BY codigo DESC";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }

        public DataTable CargarTablaCarritoProductos()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from carritoproductos ORDER BY Codigo DESC";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }

        public DataTable CargarTablaCarritoServicios()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from carritoservicios ORDER BY Codigo DESC";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }

        public DataTable CargarTablaVentas()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from ventas ORDER BY IDventa DESC";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }

        public DataTable CargarTablaPropietarios()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from propietarios ORDER BY IdPropietario DESC";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }

        public DataTable CargarTablaPacientes()
        {
            this.AbrirConexion();
            DataTable DataTabla = new DataTable();
            try
            {
                string comando = "Select * from pacientes ORDER BY IdPaciente DESC";

                SQLiteDataAdapter SQLiteAdapter = new SQLiteDataAdapter(comando, Conexion);
                SQLiteAdapter.Fill(DataTabla);

            }
            catch (Exception) { }
            this.Desconectar();
            return DataTabla;
        }
    }
}
