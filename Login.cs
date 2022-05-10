using System;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class Login : Form
    {
        ConexionSQLite Instancia_SQLite = new ConexionSQLite();
        public Login()
        {
            InitializeComponent();
        }

        //*****************************************************
        //Agrega el poder mover la ventana de lugar desde la barra de titulo.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);
        private void BarraTituloLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection Conexion = ConexionSQLite.ObtenerConexion();
                if ((txtUser.Text == "") && (txtPassword.Text == "") || (txtUser.Text == "") || (txtPassword.Text == ""))
                {
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Usuario o contraseña incorrectos";
                }
                else
                {
                    try
                    {
                        SQLiteCommand comando = new SQLiteCommand("SELECT * FROM usuarios WHERE User ='" + txtUser.Text + "' AND Password= '" + txtPassword.Text + "'", Conexion);
                        SQLiteDataReader dr = comando.ExecuteReader();

                        int count = 0;
                        while (dr.Read())
                        {
                            count++;
                        }

                        if (count == 1)
                        {
                            //Muestra los botones ocultos
                            FormPrincipalAdmin menu = new FormPrincipalAdmin();
                            menu.pSubMenu1.Visible = true;
                            menu.pSubMenu2.Visible = true;
                            menu.pSubMenu3.Visible = true;

                            menu.Show();
                            //FormPrincipal f = new FormPrincipal();
                            //f.Show();
                            this.Hide();

                            menu.pictureBoxLogIn.Visible = false;
                            menu.pictureBoxLogout.Visible = true;
                            menu.lbUser.Visible = true;
                            this.Close();

                            //InicioApp estadisticas = new InicioApp();
                            //estadisticas.lblFechaInicio.Visible = true;
                            //estadisticas.lblFechaFin.Visible = true;
                            //estadisticas.lblTotalVentas.Visible = true;
                            //estadisticas.lbl1.Visible = true;
                            //estadisticas.lblTotalReparaciones.Visible = true;
                            //estadisticas.lbl2.Visible = true;
                            //estadisticas.lblTotalGastos.Visible = true;
                            //estadisticas.lbl3.Visible = true;
                        }

                        if (count < 1)
                        {
                            lblMensaje.Visible = true;
                            lblMensaje.Text = "Usuario o contraseña incorrectos";
                            txtPassword.Clear();
                            txtUser.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos" + ex);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresa un usuario y/o contraseña");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            FormPrincipal fm = new FormPrincipal();
            fm.Show();
            this.Close();
        }
        //*****************************************************

    }
}
