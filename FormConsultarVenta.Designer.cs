namespace Veterinary_Clinic_App
{
    partial class FormConsultarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarVenta));
            this.dGVVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbTransaccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarTransaccion = new System.Windows.Forms.Button();
            this.brnRecargar = new System.Windows.Forms.Button();
            this.txbEliminarIDventa = new System.Windows.Forms.TextBox();
            this.lbTituloEliminar = new System.Windows.Forms.Label();
            this.btnEliminarIDVenta = new System.Windows.Forms.Button();
            this.btnEliminarTransaccion = new System.Windows.Forms.Button();
            this.pbElimiarTransaccion = new System.Windows.Forms.PictureBox();
            this.pbEliminarProductoServicio = new System.Windows.Forms.PictureBox();
            this.txbEliminarTransaccion = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbTransaccion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Transaccion = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbElimiarTransaccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarProductoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVVentas
            // 
            this.dGVVentas.AllowUserToAddRows = false;
            this.dGVVentas.AllowUserToDeleteRows = false;
            this.dGVVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dGVVentas.BackgroundColor = System.Drawing.Color.White;
            this.dGVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVVentas.Location = new System.Drawing.Point(162, 101);
            this.dGVVentas.Name = "dGVVentas";
            this.dGVVentas.ReadOnly = true;
            this.dGVVentas.Size = new System.Drawing.Size(855, 437);
            this.dGVVentas.TabIndex = 0;
            this.dGVVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVVentas_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Inicial";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(496, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(865, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Final";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerFechaInicio.CustomFormat = "";
            this.dateTimePickerFechaInicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(218, 55);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(119, 22);
            this.dateTimePickerFechaInicio.TabIndex = 45;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerFechaFin.CustomFormat = "";
            this.dateTimePickerFechaFin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(366, 55);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(119, 23);
            this.dateTimePickerFechaFin.TabIndex = 46;
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txbTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTotal.Location = new System.Drawing.Point(914, 60);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 13);
            this.txbTotal.TabIndex = 47;
            this.txbTotal.Text = "0.00";
            // 
            // txbTransaccion
            // 
            this.txbTransaccion.Location = new System.Drawing.Point(628, 57);
            this.txbTransaccion.Name = "txbTransaccion";
            this.txbTransaccion.Size = new System.Drawing.Size(100, 20);
            this.txbTransaccion.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Transaccion";
            // 
            // btnBuscarTransaccion
            // 
            this.btnBuscarTransaccion.Location = new System.Drawing.Point(743, 55);
            this.btnBuscarTransaccion.Name = "btnBuscarTransaccion";
            this.btnBuscarTransaccion.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTransaccion.TabIndex = 50;
            this.btnBuscarTransaccion.Text = "Buscar";
            this.btnBuscarTransaccion.UseVisualStyleBackColor = true;
            this.btnBuscarTransaccion.Click += new System.EventHandler(this.btnBuscarTransaccion_Click);
            // 
            // brnRecargar
            // 
            this.brnRecargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brnRecargar.BackgroundImage")));
            this.brnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.brnRecargar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.brnRecargar.FlatAppearance.BorderSize = 0;
            this.brnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnRecargar.Location = new System.Drawing.Point(159, 47);
            this.brnRecargar.Name = "brnRecargar";
            this.brnRecargar.Size = new System.Drawing.Size(33, 29);
            this.brnRecargar.TabIndex = 51;
            this.brnRecargar.UseVisualStyleBackColor = true;
            this.brnRecargar.Click += new System.EventHandler(this.brnRecargar_Click);
            // 
            // txbEliminarIDventa
            // 
            this.txbEliminarIDventa.Location = new System.Drawing.Point(18, 120);
            this.txbEliminarIDventa.Name = "txbEliminarIDventa";
            this.txbEliminarIDventa.Size = new System.Drawing.Size(100, 20);
            this.txbEliminarIDventa.TabIndex = 52;
            this.txbEliminarIDventa.TextChanged += new System.EventHandler(this.txbEliminarIDventa_TextChanged);
            // 
            // lbTituloEliminar
            // 
            this.lbTituloEliminar.AutoSize = true;
            this.lbTituloEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloEliminar.Location = new System.Drawing.Point(15, 101);
            this.lbTituloEliminar.Name = "lbTituloEliminar";
            this.lbTituloEliminar.Size = new System.Drawing.Size(109, 16);
            this.lbTituloEliminar.TabIndex = 53;
            this.lbTituloEliminar.Text = "IDV/Transaccion";
            // 
            // btnEliminarIDVenta
            // 
            this.btnEliminarIDVenta.Location = new System.Drawing.Point(29, 146);
            this.btnEliminarIDVenta.Name = "btnEliminarIDVenta";
            this.btnEliminarIDVenta.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarIDVenta.TabIndex = 54;
            this.btnEliminarIDVenta.Text = "Eliminar";
            this.btnEliminarIDVenta.UseVisualStyleBackColor = true;
            this.btnEliminarIDVenta.Click += new System.EventHandler(this.btnEliminarIDVenta_Click);
            // 
            // btnEliminarTransaccion
            // 
            this.btnEliminarTransaccion.Location = new System.Drawing.Point(29, 146);
            this.btnEliminarTransaccion.Name = "btnEliminarTransaccion";
            this.btnEliminarTransaccion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTransaccion.TabIndex = 55;
            this.btnEliminarTransaccion.Text = "Eliminar";
            this.btnEliminarTransaccion.UseVisualStyleBackColor = true;
            this.btnEliminarTransaccion.Click += new System.EventHandler(this.btnEliminarTransaccion_Click);
            // 
            // pbElimiarTransaccion
            // 
            this.pbElimiarTransaccion.Image = ((System.Drawing.Image)(resources.GetObject("pbElimiarTransaccion.Image")));
            this.pbElimiarTransaccion.Location = new System.Drawing.Point(69, 47);
            this.pbElimiarTransaccion.Name = "pbElimiarTransaccion";
            this.pbElimiarTransaccion.Size = new System.Drawing.Size(35, 29);
            this.pbElimiarTransaccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbElimiarTransaccion.TabIndex = 56;
            this.pbElimiarTransaccion.TabStop = false;
            this.pbElimiarTransaccion.Click += new System.EventHandler(this.pbElimiarTransaccion_Click);
            // 
            // pbEliminarProductoServicio
            // 
            this.pbEliminarProductoServicio.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminarProductoServicio.Image")));
            this.pbEliminarProductoServicio.Location = new System.Drawing.Point(18, 47);
            this.pbEliminarProductoServicio.Name = "pbEliminarProductoServicio";
            this.pbEliminarProductoServicio.Size = new System.Drawing.Size(35, 29);
            this.pbEliminarProductoServicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEliminarProductoServicio.TabIndex = 57;
            this.pbEliminarProductoServicio.TabStop = false;
            this.pbEliminarProductoServicio.Click += new System.EventHandler(this.pbEliminarProductoServicio_Click);
            // 
            // txbEliminarTransaccion
            // 
            this.txbEliminarTransaccion.Location = new System.Drawing.Point(18, 120);
            this.txbEliminarTransaccion.Name = "txbEliminarTransaccion";
            this.txbEliminarTransaccion.Size = new System.Drawing.Size(100, 20);
            this.txbEliminarTransaccion.TabIndex = 58;
            this.txbEliminarTransaccion.TextChanged += new System.EventHandler(this.txbEliminarTransaccion_TextChanged);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(81, 193);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 59;
            this.lbCodigo.Text = "Codigo";
            // 
            // lbTransaccion
            // 
            this.lbTransaccion.AutoSize = true;
            this.lbTransaccion.Location = new System.Drawing.Point(80, 222);
            this.lbTransaccion.Name = "lbTransaccion";
            this.lbTransaccion.Size = new System.Drawing.Size(66, 13);
            this.lbTransaccion.TabIndex = 60;
            this.lbTransaccion.Text = "Transaccion";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(81, 256);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 61;
            this.lbNombre.Text = "Nombre";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(81, 286);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 62;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(81, 316);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 63;
            this.lbPrecio.Text = "Precio";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(81, 345);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 64;
            this.lbTotal.Text = "Total";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(81, 372);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(37, 13);
            this.lbFecha.TabIndex = 65;
            this.lbFecha.Text = "Fecha";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(18, 372);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(37, 13);
            this.Fecha.TabIndex = 72;
            this.Fecha.Text = "Fecha";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(18, 345);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(31, 13);
            this.Total.TabIndex = 71;
            this.Total.Text = "Total";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(18, 316);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 70;
            this.Precio.Text = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(18, 286);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 69;
            this.Cantidad.Text = "Cantidad";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(18, 256);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 68;
            this.Nombre.Text = "Nombre";
            // 
            // Transaccion
            // 
            this.Transaccion.AutoSize = true;
            this.Transaccion.Location = new System.Drawing.Point(17, 222);
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.Size = new System.Drawing.Size(66, 13);
            this.Transaccion.TabIndex = 67;
            this.Transaccion.Text = "Transaccion";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(18, 193);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 66;
            this.Codigo.Text = "Codigo";
            // 
            // FormConsultarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Transaccion);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTransaccion);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txbEliminarTransaccion);
            this.Controls.Add(this.pbEliminarProductoServicio);
            this.Controls.Add(this.pbElimiarTransaccion);
            this.Controls.Add(this.btnEliminarTransaccion);
            this.Controls.Add(this.btnEliminarIDVenta);
            this.Controls.Add(this.lbTituloEliminar);
            this.Controls.Add(this.txbEliminarIDventa);
            this.Controls.Add(this.brnRecargar);
            this.Controls.Add(this.btnBuscarTransaccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTransaccion);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.dateTimePickerFechaFin);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultarVenta";
            this.Text = "FormConsultarVenta";
            this.Load += new System.EventHandler(this.FormConsultarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbElimiarTransaccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarProductoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox txbTransaccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarTransaccion;
        private System.Windows.Forms.Button brnRecargar;
        private System.Windows.Forms.TextBox txbEliminarIDventa;
        private System.Windows.Forms.Label lbTituloEliminar;
        private System.Windows.Forms.Button btnEliminarIDVenta;
        private System.Windows.Forms.Button btnEliminarTransaccion;
        private System.Windows.Forms.PictureBox pbElimiarTransaccion;
        private System.Windows.Forms.PictureBox pbEliminarProductoServicio;
        private System.Windows.Forms.TextBox txbEliminarTransaccion;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbTransaccion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Transaccion;
        private System.Windows.Forms.Label Codigo;
    }
}