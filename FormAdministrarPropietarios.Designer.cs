namespace Veterinary_Clinic_App
{
    partial class FormAdministrarPropietarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrarPropietarios));
            this.pPropietario = new System.Windows.Forms.Panel();
            this.txbIDPropietario = new System.Windows.Forms.TextBox();
            this.btnEliminarPropietario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarPropietario = new System.Windows.Forms.Button();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbApellidoM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbApellidoP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNombrePropietario = new System.Windows.Forms.TextBox();
            this.dGVPropietarios = new System.Windows.Forms.DataGridView();
            this.pbEliminarProducto = new System.Windows.Forms.PictureBox();
            this.pbEditarProducto = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbConsultar = new System.Windows.Forms.PictureBox();
            this.btnBuscarPropietario = new System.Windows.Forms.Button();
            this.txbBuscarPropietario = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPropietarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // pPropietario
            // 
            this.pPropietario.Controls.Add(this.txbIDPropietario);
            this.pPropietario.Controls.Add(this.btnEliminarPropietario);
            this.pPropietario.Controls.Add(this.label1);
            this.pPropietario.Controls.Add(this.btnModificarPropietario);
            this.pPropietario.Controls.Add(this.txbDireccion);
            this.pPropietario.Controls.Add(this.label14);
            this.pPropietario.Controls.Add(this.txbCorreo);
            this.pPropietario.Controls.Add(this.label13);
            this.pPropietario.Controls.Add(this.txbTelefono);
            this.pPropietario.Controls.Add(this.label12);
            this.pPropietario.Controls.Add(this.txbApellidoM);
            this.pPropietario.Controls.Add(this.label11);
            this.pPropietario.Controls.Add(this.txbApellidoP);
            this.pPropietario.Controls.Add(this.label10);
            this.pPropietario.Controls.Add(this.label9);
            this.pPropietario.Controls.Add(this.txbNombrePropietario);
            this.pPropietario.Location = new System.Drawing.Point(723, 66);
            this.pPropietario.Name = "pPropietario";
            this.pPropietario.Size = new System.Drawing.Size(316, 510);
            this.pPropietario.TabIndex = 13;
            // 
            // txbIDPropietario
            // 
            this.txbIDPropietario.Location = new System.Drawing.Point(3, 16);
            this.txbIDPropietario.Name = "txbIDPropietario";
            this.txbIDPropietario.Size = new System.Drawing.Size(222, 20);
            this.txbIDPropietario.TabIndex = 27;
            this.txbIDPropietario.TextChanged += new System.EventHandler(this.txbIDPropietario_TextChanged);
            // 
            // btnEliminarPropietario
            // 
            this.btnEliminarPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarPropietario.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminarPropietario.FlatAppearance.BorderSize = 0;
            this.btnEliminarPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPropietario.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPropietario.Location = new System.Drawing.Point(6, 406);
            this.btnEliminarPropietario.Name = "btnEliminarPropietario";
            this.btnEliminarPropietario.Size = new System.Drawing.Size(124, 23);
            this.btnEliminarPropietario.TabIndex = 28;
            this.btnEliminarPropietario.Text = "Eliminar";
            this.btnEliminarPropietario.UseVisualStyleBackColor = false;
            this.btnEliminarPropietario.Click += new System.EventHandler(this.btnEliminarPropietario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Propietario";
            // 
            // btnModificarPropietario
            // 
            this.btnModificarPropietario.BackColor = System.Drawing.Color.Orange;
            this.btnModificarPropietario.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnModificarPropietario.FlatAppearance.BorderSize = 0;
            this.btnModificarPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPropietario.ForeColor = System.Drawing.Color.White;
            this.btnModificarPropietario.Location = new System.Drawing.Point(6, 406);
            this.btnModificarPropietario.Name = "btnModificarPropietario";
            this.btnModificarPropietario.Size = new System.Drawing.Size(124, 23);
            this.btnModificarPropietario.TabIndex = 15;
            this.btnModificarPropietario.Text = "Modificar";
            this.btnModificarPropietario.UseVisualStyleBackColor = false;
            this.btnModificarPropietario.Click += new System.EventHandler(this.btnModificarPropietario_Click);
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(6, 336);
            this.txbDireccion.Multiline = true;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(222, 58);
            this.txbDireccion.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Dirección";
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(6, 285);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(222, 20);
            this.txbCorreo.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Correo";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(6, 230);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(222, 20);
            this.txbTelefono.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Teléfono";
            // 
            // txbApellidoM
            // 
            this.txbApellidoM.Location = new System.Drawing.Point(6, 172);
            this.txbApellidoM.Name = "txbApellidoM";
            this.txbApellidoM.Size = new System.Drawing.Size(222, 20);
            this.txbApellidoM.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Apellido Materno";
            // 
            // txbApellidoP
            // 
            this.txbApellidoP.Location = new System.Drawing.Point(3, 116);
            this.txbApellidoP.Name = "txbApellidoP";
            this.txbApellidoP.Size = new System.Drawing.Size(222, 20);
            this.txbApellidoP.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Apellido Paterno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre del propietario";
            // 
            // txbNombrePropietario
            // 
            this.txbNombrePropietario.Location = new System.Drawing.Point(3, 63);
            this.txbNombrePropietario.Name = "txbNombrePropietario";
            this.txbNombrePropietario.Size = new System.Drawing.Size(222, 20);
            this.txbNombrePropietario.TabIndex = 15;
            // 
            // dGVPropietarios
            // 
            this.dGVPropietarios.BackgroundColor = System.Drawing.Color.White;
            this.dGVPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPropietarios.Location = new System.Drawing.Point(21, 66);
            this.dGVPropietarios.Name = "dGVPropietarios";
            this.dGVPropietarios.Size = new System.Drawing.Size(676, 577);
            this.dGVPropietarios.TabIndex = 31;
            this.dGVPropietarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPropietarios_CellClick);
            // 
            // pbEliminarProducto
            // 
            this.pbEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminarProducto.Image")));
            this.pbEliminarProducto.Location = new System.Drawing.Point(81, 12);
            this.pbEliminarProducto.Name = "pbEliminarProducto";
            this.pbEliminarProducto.Size = new System.Drawing.Size(54, 45);
            this.pbEliminarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminarProducto.TabIndex = 34;
            this.pbEliminarProducto.TabStop = false;
            this.pbEliminarProducto.Click += new System.EventHandler(this.pbEliminarProducto_Click);
            // 
            // pbEditarProducto
            // 
            this.pbEditarProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbEditarProducto.Image")));
            this.pbEditarProducto.Location = new System.Drawing.Point(21, 12);
            this.pbEditarProducto.Name = "pbEditarProducto";
            this.pbEditarProducto.Size = new System.Drawing.Size(54, 45);
            this.pbEditarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarProducto.TabIndex = 33;
            this.pbEditarProducto.TabStop = false;
            this.pbEditarProducto.Click += new System.EventHandler(this.pbEditarProducto_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(720, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(20, 16);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "...";
            // 
            // pbConsultar
            // 
            this.pbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("pbConsultar.Image")));
            this.pbConsultar.Location = new System.Drawing.Point(141, 12);
            this.pbConsultar.Name = "pbConsultar";
            this.pbConsultar.Size = new System.Drawing.Size(54, 45);
            this.pbConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConsultar.TabIndex = 40;
            this.pbConsultar.TabStop = false;
            this.pbConsultar.Click += new System.EventHandler(this.pbConsultar_Click);
            // 
            // btnBuscarPropietario
            // 
            this.btnBuscarPropietario.Location = new System.Drawing.Point(447, 22);
            this.btnBuscarPropietario.Name = "btnBuscarPropietario";
            this.btnBuscarPropietario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPropietario.TabIndex = 37;
            this.btnBuscarPropietario.Text = "Buscar";
            this.btnBuscarPropietario.UseVisualStyleBackColor = true;
            this.btnBuscarPropietario.Click += new System.EventHandler(this.btnBuscarPropietario_Click);
            // 
            // txbBuscarPropietario
            // 
            this.txbBuscarPropietario.Location = new System.Drawing.Point(339, 24);
            this.txbBuscarPropietario.Name = "txbBuscarPropietario";
            this.txbBuscarPropietario.Size = new System.Drawing.Size(100, 20);
            this.txbBuscarPropietario.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(216, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "Buscar por Nombre";
            // 
            // FormAdministrarPropietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.pbConsultar);
            this.Controls.Add(this.btnBuscarPropietario);
            this.Controls.Add(this.txbBuscarPropietario);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbEliminarProducto);
            this.Controls.Add(this.pbEditarProducto);
            this.Controls.Add(this.dGVPropietarios);
            this.Controls.Add(this.pPropietario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdministrarPropietarios";
            this.Text = "FormAdministrarPropietarios";
            this.Load += new System.EventHandler(this.FormAdministrarPropietarios_Load);
            this.pPropietario.ResumeLayout(false);
            this.pPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPropietarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pPropietario;
        private System.Windows.Forms.Button btnEliminarPropietario;
        private System.Windows.Forms.TextBox txbIDPropietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarPropietario;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbApellidoM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbApellidoP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbNombrePropietario;
        private System.Windows.Forms.DataGridView dGVPropietarios;
        private System.Windows.Forms.PictureBox pbEliminarProducto;
        private System.Windows.Forms.PictureBox pbEditarProducto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbConsultar;
        private System.Windows.Forms.Button btnBuscarPropietario;
        private System.Windows.Forms.TextBox txbBuscarPropietario;
        private System.Windows.Forms.Label label17;
    }
}