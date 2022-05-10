using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinary_Clinic_App
{
    public partial class FormPrincipalAdmin : Form
    {
        public FormPrincipalAdmin()
        {
            InitializeComponent();

            //Muestra la fecha en el textbox de FechaHoy
            txbFechaHoy.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void FormPrincipalAdmin_Load(object sender, EventArgs e)
        {
            pSubMenu1.Visible = false;
            pSubMenu2.Visible = false;
            pSubMenu3.Visible = false;
        }

        //Barra de titulo y botones Minimizar, Maximizar y Cerrar perzonalizados
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState =
        (this.WindowState == FormWindowState.Maximized ?
            FormWindowState.Normal :
            FormWindowState.Maximized);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Código para arrastrar la barra de título junto con toda la ventana en cualquier sitio
        private Point pos = Point.Empty;
        private bool move = false;
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            pos = new Point(e.X, e.Y);
            move = true;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                this.Location = new Point((this.Left + e.X - pos.X),
                    (this.Top + e.Y - pos.Y));
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void AbrirFormHijo(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form newMDIChild = formhijo as Form;
            newMDIChild.TopLevel = false;
            newMDIChild.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(newMDIChild);
            this.PanelContenedor.Tag = newMDIChild;
            //newMDIChild.MdiParent = this;
            newMDIChild.Show();
            newMDIChild.FormClosed += new FormClosedEventHandler(EffectColorButtons);
        }

        private void CerrarFormsHijos()
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                Form[] formsList = Application.OpenForms.Cast<Form>().Where(x => x.Name == "InicioApp" ||
                x.Name == "Login" ||
                x.Name == "FormVenta" ||
                x.Name == "FormConsultarVenta" ||
                x.Name == "FormProductos" ||
                x.Name == "FormServicios" ||
                x.Name == "FormProveedores" ||
                x.Name == "FormPacientes" ||
                x.Name == "FormRegistrarPacientes" ||
                x.Name == "FormAdminPacientes" ||
                x.Name == "FormHistorialPacientes" ||
                x.Name == "FormRegistrarPropietarios" ||
                x.Name == "FormAdministrarPropietarios" ||
                x.Name == "FormConsultarPropietarios").ToArray();
                foreach (Form openForm in formsList)
                {
                    openForm.Close();
                }
            }
        }

        private void pbInicio_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            AbrirFormHijo(new InicioApp());
        }

        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormVenta());
            buttonMenu1.BackColor = Color.FromArgb(0, 128, 128);
            showSubMenu(pSubMenu1);
        }

        private void button1SubMenu1_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormConsultarVenta());
            button1SubMenu1.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void button2SubMenu1_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormProductos());
            button2SubMenu1.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void button3SubMenu1_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormServicios());
            button3SubMenu1.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void button4SubMenu1_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormProveedores());
            button4SubMenu1.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void buttonMenu2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormRegistrarPacientes());
            buttonMenu2.BackColor = Color.FromArgb(0, 128, 128);
            showSubMenu(pSubMenu2);
        }

        private void button1SubMenu2_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormAdminPacientes());
            button1SubMenu2.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void button2SubMenu2_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormHistorialPacientes());
            button2SubMenu2.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void button1Menu3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormRegistrarPropietarios());
            button2SubMenu2.BackColor = Color.FromArgb(0, 128, 128);
            showSubMenu(pSubMenu3);
        }

        private void button1SubMenu3_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormAdministrarPropietarios());
            button2SubMenu2.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void button2SubMenu3_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            //AbrirFormulario<FormVenta>();
            AbrirFormHijo(new FormConsultarPropietarios());
            button2SubMenu2.BackColor = Color.FromArgb(0, 128, 128);
        }

        private void pictureBoxLogIn_Click(object sender, EventArgs e)
        {
            CerrarFormsHijos();
            Login fm = new Login();
            fm.Show();
            this.Hide();

            FormPrincipal form = new FormPrincipal();
            form.Hide();
            form.Close();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal FPrincipal = new FormPrincipal();
            FPrincipal.Show();
            CerrarFormsHijos();
            //AbrirFormHijo(new InicioApp());

            pSubMenu1.Visible = false;
            pSubMenu2.Visible = false;
            pSubMenu3.Visible = false;

            pictureBoxLogIn.Visible = true;
            pictureBoxLogout.Visible = false;
            lbUser.Text = "Usuario";
        }

        private void hideSubMenu()
        {
            if (pSubMenu1.Visible == true)
                pSubMenu1.Visible = false;

            if (pSubMenu2.Visible == true)
                pSubMenu2.Visible = false;

            if (pSubMenu3.Visible == true)
                pSubMenu3.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //Colorea el botón del formulario que se encuentra abierto.
        //Si el formulario no está abierto lo deja con el color default.
        private void EffectColorButtons(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormVenta"] == null)
                buttonMenu1.BackColor = Color.FromArgb(26, 32, 40);

            //SubMenu1
            if (Application.OpenForms["FormConsultarVenta"] == null)
                button1SubMenu1.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["FormProductos"] == null)
                button2SubMenu1.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["FormServicios"] == null)
                button3SubMenu1.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["FormProveedores"] == null)
                button3SubMenu1.BackColor = Color.FromArgb(26, 32, 40);
            //........

            if (Application.OpenForms["FormRegistrarPacientes"] == null)
                buttonMenu2.BackColor = Color.FromArgb(26, 32, 40);

            //SubMenu2
            if (Application.OpenForms["FormAdminPacientes"] == null)
                button1SubMenu2.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["FormHistorialPacientes"] == null)
                button2SubMenu2.BackColor = Color.FromArgb(26, 32, 40);
            //..........

            if (Application.OpenForms["FormRegistrarPropietarios"] == null)
                buttonMenu2.BackColor = Color.FromArgb(26, 32, 40);

            //SubMenu3
            if (Application.OpenForms["FormAdministrarPropietarios"] == null)
                buttonMenu2.BackColor = Color.FromArgb(26, 32, 40);

            if (Application.OpenForms["FormConsultarPropietarios"] == null)
                buttonMenu2.BackColor = Color.FromArgb(26, 32, 40);

        }

    }
}
