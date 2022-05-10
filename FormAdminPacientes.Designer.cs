namespace Veterinary_Clinic_App
{
    partial class FormAdminPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPacientes));
            this.lbPropietario = new System.Windows.Forms.Label();
            this.pPropietario = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbApellidoM = new System.Windows.Forms.Label();
            this.lbApellidoP = new System.Windows.Forms.Label();
            this.lbNombrePropietario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdPropietario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.txbBuscarPaciente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dGVPacientes = new System.Windows.Forms.DataGridView();
            this.lbPaciente = new System.Windows.Forms.Label();
            this.pPaciente = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbIdPaciente = new System.Windows.Forms.TextBox();
            this.txbEsterilizado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAñadirFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.txbMeses = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAños = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEspecie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombreMascota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbEliminarProducto = new System.Windows.Forms.PictureBox();
            this.pbEditarProducto = new System.Windows.Forms.PictureBox();
            this.pbConsultar = new System.Windows.Forms.PictureBox();
            this.pPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPacientes)).BeginInit();
            this.pPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPropietario
            // 
            this.lbPropietario.AutoSize = true;
            this.lbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbPropietario.Location = new System.Drawing.Point(795, 67);
            this.lbPropietario.Name = "lbPropietario";
            this.lbPropietario.Size = new System.Drawing.Size(85, 16);
            this.lbPropietario.TabIndex = 25;
            this.lbPropietario.Text = "Propietario";
            // 
            // pPropietario
            // 
            this.pPropietario.Controls.Add(this.btnEliminar);
            this.pPropietario.Controls.Add(this.lbDireccion);
            this.pPropietario.Controls.Add(this.btnModificar);
            this.pPropietario.Controls.Add(this.lbCorreo);
            this.pPropietario.Controls.Add(this.lbTelefono);
            this.pPropietario.Controls.Add(this.lbApellidoM);
            this.pPropietario.Controls.Add(this.lbApellidoP);
            this.pPropietario.Controls.Add(this.lbNombrePropietario);
            this.pPropietario.Controls.Add(this.label1);
            this.pPropietario.Controls.Add(this.txbIdPropietario);
            this.pPropietario.Controls.Add(this.label14);
            this.pPropietario.Controls.Add(this.label13);
            this.pPropietario.Controls.Add(this.label12);
            this.pPropietario.Controls.Add(this.label11);
            this.pPropietario.Controls.Add(this.label10);
            this.pPropietario.Controls.Add(this.label9);
            this.pPropietario.Location = new System.Drawing.Point(798, 92);
            this.pPropietario.Name = "pPropietario";
            this.pPropietario.Size = new System.Drawing.Size(253, 586);
            this.pPropietario.TabIndex = 24;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 404);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 23);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(15, 361);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(25, 13);
            this.lbDireccion.TabIndex = 31;
            this.lbDireccion.Text = "___";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(18, 403);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(15, 310);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(25, 13);
            this.lbCorreo.TabIndex = 30;
            this.lbCorreo.Text = "___";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(15, 255);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(25, 13);
            this.lbTelefono.TabIndex = 29;
            this.lbTelefono.Text = "___";
            // 
            // lbApellidoM
            // 
            this.lbApellidoM.AutoSize = true;
            this.lbApellidoM.Location = new System.Drawing.Point(15, 199);
            this.lbApellidoM.Name = "lbApellidoM";
            this.lbApellidoM.Size = new System.Drawing.Size(25, 13);
            this.lbApellidoM.TabIndex = 28;
            this.lbApellidoM.Text = "___";
            // 
            // lbApellidoP
            // 
            this.lbApellidoP.AutoSize = true;
            this.lbApellidoP.Location = new System.Drawing.Point(15, 141);
            this.lbApellidoP.Name = "lbApellidoP";
            this.lbApellidoP.Size = new System.Drawing.Size(25, 13);
            this.lbApellidoP.TabIndex = 27;
            this.lbApellidoP.Text = "___";
            // 
            // lbNombrePropietario
            // 
            this.lbNombrePropietario.AutoSize = true;
            this.lbNombrePropietario.Location = new System.Drawing.Point(15, 85);
            this.lbNombrePropietario.Name = "lbNombrePropietario";
            this.lbNombrePropietario.Size = new System.Drawing.Size(25, 13);
            this.lbNombrePropietario.TabIndex = 26;
            this.lbNombrePropietario.Text = "___";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Id Propietario";
            // 
            // txbIdPropietario
            // 
            this.txbIdPropietario.Location = new System.Drawing.Point(15, 29);
            this.txbIdPropietario.Name = "txbIdPropietario";
            this.txbIdPropietario.Size = new System.Drawing.Size(124, 20);
            this.txbIdPropietario.TabIndex = 16;
            this.txbIdPropietario.TextChanged += new System.EventHandler(this.txbIdPropietario_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 339);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Dirección";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Correo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Teléfono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Apellido Materno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Apellido Paterno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre del propietario";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(421, 29);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPaciente.TabIndex = 23;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarMascota_Click);
            // 
            // txbBuscarPaciente
            // 
            this.txbBuscarPaciente.Location = new System.Drawing.Point(315, 31);
            this.txbBuscarPaciente.Name = "txbBuscarPaciente";
            this.txbBuscarPaciente.Size = new System.Drawing.Size(100, 20);
            this.txbBuscarPaciente.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(200, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "Buscar por Nombre";
            // 
            // dGVPacientes
            // 
            this.dGVPacientes.AllowUserToAddRows = false;
            this.dGVPacientes.AllowUserToDeleteRows = false;
            this.dGVPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dGVPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPacientes.Location = new System.Drawing.Point(9, 92);
            this.dGVPacientes.Name = "dGVPacientes";
            this.dGVPacientes.ReadOnly = true;
            this.dGVPacientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dGVPacientes.Size = new System.Drawing.Size(488, 586);
            this.dGVPacientes.TabIndex = 20;
            this.dGVPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPacientes_CellClick);
            // 
            // lbPaciente
            // 
            this.lbPaciente.AutoSize = true;
            this.lbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaciente.Location = new System.Drawing.Point(501, 67);
            this.lbPaciente.Name = "lbPaciente";
            this.lbPaciente.Size = new System.Drawing.Size(69, 16);
            this.lbPaciente.TabIndex = 19;
            this.lbPaciente.Text = "Paciente";
            // 
            // pPaciente
            // 
            this.pPaciente.Controls.Add(this.label16);
            this.pPaciente.Controls.Add(this.txbStatus);
            this.pPaciente.Controls.Add(this.label15);
            this.pPaciente.Controls.Add(this.label8);
            this.pPaciente.Controls.Add(this.txbIdPaciente);
            this.pPaciente.Controls.Add(this.txbEsterilizado);
            this.pPaciente.Controls.Add(this.label7);
            this.pPaciente.Controls.Add(this.btnAñadirFoto);
            this.pPaciente.Controls.Add(this.pbFoto);
            this.pPaciente.Controls.Add(this.txbObservaciones);
            this.pPaciente.Controls.Add(this.txbMeses);
            this.pPaciente.Controls.Add(this.label6);
            this.pPaciente.Controls.Add(this.txbAños);
            this.pPaciente.Controls.Add(this.label5);
            this.pPaciente.Controls.Add(this.txbColor);
            this.pPaciente.Controls.Add(this.label4);
            this.pPaciente.Controls.Add(this.txbEspecie);
            this.pPaciente.Controls.Add(this.label3);
            this.pPaciente.Controls.Add(this.txbNombreMascota);
            this.pPaciente.Controls.Add(this.label2);
            this.pPaciente.Location = new System.Drawing.Point(503, 92);
            this.pPaciente.Name = "pPaciente";
            this.pPaciente.Size = new System.Drawing.Size(289, 586);
            this.pPaciente.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Observaciones";
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(166, 406);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(61, 20);
            this.txbStatus.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(177, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Id Paciente";
            // 
            // txbIdPaciente
            // 
            this.txbIdPaciente.Location = new System.Drawing.Point(7, 29);
            this.txbIdPaciente.Name = "txbIdPaciente";
            this.txbIdPaciente.Size = new System.Drawing.Size(124, 20);
            this.txbIdPaciente.TabIndex = 32;
            this.txbIdPaciente.TextChanged += new System.EventHandler(this.txbIdMascota_TextChanged);
            // 
            // txbEsterilizado
            // 
            this.txbEsterilizado.Location = new System.Drawing.Point(6, 406);
            this.txbEsterilizado.Name = "txbEsterilizado";
            this.txbEsterilizado.Size = new System.Drawing.Size(61, 20);
            this.txbEsterilizado.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Esterilizado";
            // 
            // btnAñadirFoto
            // 
            this.btnAñadirFoto.Location = new System.Drawing.Point(166, 487);
            this.btnAñadirFoto.Name = "btnAñadirFoto";
            this.btnAñadirFoto.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirFoto.TabIndex = 12;
            this.btnAñadirFoto.Text = "Añadir foto";
            this.btnAñadirFoto.UseVisualStyleBackColor = true;
            this.btnAñadirFoto.Visible = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(6, 445);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(129, 118);
            this.pbFoto.TabIndex = 11;
            this.pbFoto.TabStop = false;
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Location = new System.Drawing.Point(6, 301);
            this.txbObservaciones.Multiline = true;
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(272, 73);
            this.txbObservaciones.TabIndex = 10;
            // 
            // txbMeses
            // 
            this.txbMeses.Location = new System.Drawing.Point(102, 249);
            this.txbMeses.Name = "txbMeses";
            this.txbMeses.Size = new System.Drawing.Size(61, 20);
            this.txbMeses.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Meses";
            // 
            // txbAños
            // 
            this.txbAños.Location = new System.Drawing.Point(6, 249);
            this.txbAños.Name = "txbAños";
            this.txbAños.Size = new System.Drawing.Size(61, 20);
            this.txbAños.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Años";
            // 
            // txbColor
            // 
            this.txbColor.Location = new System.Drawing.Point(6, 191);
            this.txbColor.Name = "txbColor";
            this.txbColor.Size = new System.Drawing.Size(273, 20);
            this.txbColor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            // 
            // txbEspecie
            // 
            this.txbEspecie.Location = new System.Drawing.Point(6, 135);
            this.txbEspecie.Name = "txbEspecie";
            this.txbEspecie.Size = new System.Drawing.Size(273, 20);
            this.txbEspecie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especie";
            // 
            // txbNombreMascota
            // 
            this.txbNombreMascota.Location = new System.Drawing.Point(6, 82);
            this.txbNombreMascota.Name = "txbNombreMascota";
            this.txbNombreMascota.Size = new System.Drawing.Size(274, 20);
            this.txbNombreMascota.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del paciente";
            // 
            // pbEliminarProducto
            // 
            this.pbEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminarProducto.Image")));
            this.pbEliminarProducto.Location = new System.Drawing.Point(69, 12);
            this.pbEliminarProducto.Name = "pbEliminarProducto";
            this.pbEliminarProducto.Size = new System.Drawing.Size(54, 45);
            this.pbEliminarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminarProducto.TabIndex = 27;
            this.pbEliminarProducto.TabStop = false;
            this.pbEliminarProducto.Click += new System.EventHandler(this.pbEliminarProducto_Click);
            // 
            // pbEditarProducto
            // 
            this.pbEditarProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbEditarProducto.Image")));
            this.pbEditarProducto.Location = new System.Drawing.Point(9, 12);
            this.pbEditarProducto.Name = "pbEditarProducto";
            this.pbEditarProducto.Size = new System.Drawing.Size(54, 45);
            this.pbEditarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarProducto.TabIndex = 26;
            this.pbEditarProducto.TabStop = false;
            this.pbEditarProducto.Click += new System.EventHandler(this.pbEditarProducto_Click);
            // 
            // pbConsultar
            // 
            this.pbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("pbConsultar.Image")));
            this.pbConsultar.Location = new System.Drawing.Point(129, 12);
            this.pbConsultar.Name = "pbConsultar";
            this.pbConsultar.Size = new System.Drawing.Size(54, 45);
            this.pbConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConsultar.TabIndex = 28;
            this.pbConsultar.TabStop = false;
            this.pbConsultar.Click += new System.EventHandler(this.pbConsultar_Click);
            // 
            // FormAdminPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.pbConsultar);
            this.Controls.Add(this.pbEliminarProducto);
            this.Controls.Add(this.pbEditarProducto);
            this.Controls.Add(this.lbPropietario);
            this.Controls.Add(this.pPropietario);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.txbBuscarPaciente);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dGVPacientes);
            this.Controls.Add(this.lbPaciente);
            this.Controls.Add(this.pPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminPacientes";
            this.Text = "FormAdminPacientes";
            this.Load += new System.EventHandler(this.FormAdminPacientes_Load);
            this.pPropietario.ResumeLayout(false);
            this.pPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPacientes)).EndInit();
            this.pPaciente.ResumeLayout(false);
            this.pPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPropietario;
        private System.Windows.Forms.Panel pPropietario;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbApellidoM;
        private System.Windows.Forms.Label lbApellidoP;
        private System.Windows.Forms.Label lbNombrePropietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIdPropietario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.TextBox txbBuscarPaciente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dGVPacientes;
        private System.Windows.Forms.Label lbPaciente;
        private System.Windows.Forms.Panel pPaciente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txbEsterilizado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAñadirFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txbObservaciones;
        private System.Windows.Forms.TextBox txbMeses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbAños;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEspecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNombreMascota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbIdPaciente;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbEliminarProducto;
        private System.Windows.Forms.PictureBox pbEditarProducto;
        private System.Windows.Forms.PictureBox pbConsultar;
    }
}