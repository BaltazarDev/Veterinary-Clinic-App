namespace Veterinary_Clinic_App
{
    partial class FormProductos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.dGVProductos = new System.Windows.Forms.DataGridView();
            this.panelFuncionesProductos = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txbPresentacion = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.lbPresentacion = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.pbEliminarProducto = new System.Windows.Forms.PictureBox();
            this.pbEditarProducto = new System.Windows.Forms.PictureBox();
            this.pbNuevoProducto = new System.Windows.Forms.PictureBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txbBuscarProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductos)).BeginInit();
            this.panelFuncionesProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVProductos
            // 
            this.dGVProductos.AllowUserToAddRows = false;
            this.dGVProductos.AllowUserToDeleteRows = false;
            this.dGVProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVProductos.BackgroundColor = System.Drawing.Color.White;
            this.dGVProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVProductos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dGVProductos.Location = new System.Drawing.Point(25, 98);
            this.dGVProductos.Name = "dGVProductos";
            this.dGVProductos.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dGVProductos.Size = new System.Drawing.Size(621, 523);
            this.dGVProductos.TabIndex = 16;
            this.dGVProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProductos_CellClick);
            // 
            // panelFuncionesProductos
            // 
            this.panelFuncionesProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFuncionesProductos.BackColor = System.Drawing.Color.White;
            this.panelFuncionesProductos.Controls.Add(this.lbTitulo);
            this.panelFuncionesProductos.Controls.Add(this.txbStock);
            this.panelFuncionesProductos.Controls.Add(this.btnEliminar);
            this.panelFuncionesProductos.Controls.Add(this.txbPrecio);
            this.panelFuncionesProductos.Controls.Add(this.lbPrecio);
            this.panelFuncionesProductos.Controls.Add(this.lbStock);
            this.panelFuncionesProductos.Controls.Add(this.btnCancelar);
            this.panelFuncionesProductos.Controls.Add(this.btnModificar);
            this.panelFuncionesProductos.Controls.Add(this.btnNuevo);
            this.panelFuncionesProductos.Controls.Add(this.txbPresentacion);
            this.panelFuncionesProductos.Controls.Add(this.txbDescripcion);
            this.panelFuncionesProductos.Controls.Add(this.lbPresentacion);
            this.panelFuncionesProductos.Controls.Add(this.lbDescripcion);
            this.panelFuncionesProductos.Controls.Add(this.txbNombre);
            this.panelFuncionesProductos.Controls.Add(this.lbNombre);
            this.panelFuncionesProductos.Controls.Add(this.txbCodigo);
            this.panelFuncionesProductos.Controls.Add(this.lbCodigo);
            this.panelFuncionesProductos.Location = new System.Drawing.Point(686, 98);
            this.panelFuncionesProductos.Name = "panelFuncionesProductos";
            this.panelFuncionesProductos.Size = new System.Drawing.Size(338, 523);
            this.panelFuncionesProductos.TabIndex = 15;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(22, 11);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(23, 18);
            this.lbTitulo.TabIndex = 17;
            this.lbTitulo.Text = "...";
            // 
            // txbStock
            // 
            this.txbStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStock.Location = new System.Drawing.Point(133, 300);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(100, 22);
            this.txbStock.TabIndex = 16;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(170, 358);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(71, 32);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txbPrecio
            // 
            this.txbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(133, 259);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 22);
            this.txbPrecio.TabIndex = 5;
            // 
            // lbPrecio
            // 
            this.lbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(22, 265);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(47, 16);
            this.lbPrecio.TabIndex = 15;
            this.lbPrecio.Text = "Precio";
            // 
            // lbStock
            // 
            this.lbStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(20, 303);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(42, 16);
            this.lbStock.TabIndex = 11;
            this.lbStock.Text = "Stock";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(247, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 32);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(97, 358);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(67, 32);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(22, 358);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 32);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txbPresentacion
            // 
            this.txbPresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPresentacion.Location = new System.Drawing.Point(133, 216);
            this.txbPresentacion.Name = "txbPresentacion";
            this.txbPresentacion.Size = new System.Drawing.Size(100, 22);
            this.txbPresentacion.TabIndex = 4;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescripcion.Location = new System.Drawing.Point(133, 150);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(178, 49);
            this.txbDescripcion.TabIndex = 3;
            // 
            // lbPresentacion
            // 
            this.lbPresentacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPresentacion.AutoSize = true;
            this.lbPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresentacion.Location = new System.Drawing.Point(20, 222);
            this.lbPresentacion.Name = "lbPresentacion";
            this.lbPresentacion.Size = new System.Drawing.Size(87, 16);
            this.lbPresentacion.TabIndex = 5;
            this.lbPresentacion.Text = "Presentación";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(20, 170);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(80, 16);
            this.lbDescripcion.TabIndex = 4;
            this.lbDescripcion.Text = "Descripción";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(133, 104);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 22);
            this.txbNombre.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(22, 110);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(57, 16);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txbCodigo.Location = new System.Drawing.Point(133, 54);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.ReadOnly = true;
            this.txbCodigo.Size = new System.Drawing.Size(100, 22);
            this.txbCodigo.TabIndex = 1;
            this.txbCodigo.TextChanged += new System.EventHandler(this.txbCodigo_TextChanged);
            // 
            // lbCodigo
            // 
            this.lbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(22, 60);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(52, 16);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // pbEliminarProducto
            // 
            this.pbEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminarProducto.Image")));
            this.pbEliminarProducto.Location = new System.Drawing.Point(832, 47);
            this.pbEliminarProducto.Name = "pbEliminarProducto";
            this.pbEliminarProducto.Size = new System.Drawing.Size(54, 45);
            this.pbEliminarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminarProducto.TabIndex = 19;
            this.pbEliminarProducto.TabStop = false;
            this.pbEliminarProducto.Click += new System.EventHandler(this.pbEliminarProducto_Click);
            // 
            // pbEditarProducto
            // 
            this.pbEditarProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbEditarProducto.Image")));
            this.pbEditarProducto.Location = new System.Drawing.Point(772, 47);
            this.pbEditarProducto.Name = "pbEditarProducto";
            this.pbEditarProducto.Size = new System.Drawing.Size(54, 45);
            this.pbEditarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditarProducto.TabIndex = 18;
            this.pbEditarProducto.TabStop = false;
            this.pbEditarProducto.Click += new System.EventHandler(this.pbEditarProducto_Click);
            // 
            // pbNuevoProducto
            // 
            this.pbNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbNuevoProducto.Image")));
            this.pbNuevoProducto.Location = new System.Drawing.Point(712, 47);
            this.pbNuevoProducto.Name = "pbNuevoProducto";
            this.pbNuevoProducto.Size = new System.Drawing.Size(54, 45);
            this.pbNuevoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNuevoProducto.TabIndex = 17;
            this.pbNuevoProducto.TabStop = false;
            this.pbNuevoProducto.Click += new System.EventHandler(this.pbNuevoProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(240, 45);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(40, 33);
            this.btnBuscarProducto.TabIndex = 20;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txbBuscarProducto
            // 
            this.txbBuscarProducto.Location = new System.Drawing.Point(134, 52);
            this.txbBuscarProducto.Name = "txbBuscarProducto";
            this.txbBuscarProducto.Size = new System.Drawing.Size(100, 20);
            this.txbBuscarProducto.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(22, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar producto";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbBuscarProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.pbEliminarProducto);
            this.Controls.Add(this.pbEditarProducto);
            this.Controls.Add(this.pbNuevoProducto);
            this.Controls.Add(this.dGVProductos);
            this.Controls.Add(this.panelFuncionesProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductos)).EndInit();
            this.panelFuncionesProductos.ResumeLayout(false);
            this.panelFuncionesProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNuevoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEliminarProducto;
        private System.Windows.Forms.PictureBox pbEditarProducto;
        private System.Windows.Forms.PictureBox pbNuevoProducto;
        private System.Windows.Forms.DataGridView dGVProductos;
        private System.Windows.Forms.Panel panelFuncionesProductos;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txbPresentacion;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label lbPresentacion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txbBuscarProducto;
        private System.Windows.Forms.Label label1;
    }
}