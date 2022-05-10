namespace Veterinary_Clinic_App
{
    partial class FormRegistrarPropietarios
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
            this.lbPropietario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInsertPropietario = new System.Windows.Forms.Button();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPropietario
            // 
            this.lbPropietario.AutoSize = true;
            this.lbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPropietario.Location = new System.Drawing.Point(25, 15);
            this.lbPropietario.Name = "lbPropietario";
            this.lbPropietario.Size = new System.Drawing.Size(144, 18);
            this.lbPropietario.TabIndex = 13;
            this.lbPropietario.Text = "Nuevo Propietario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInsertPropietario);
            this.panel2.Controls.Add(this.txbDireccion);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txbCorreo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txbTelefono);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txbApellidoM);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txbApellidoP);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txbNombrePropietario);
            this.panel2.Location = new System.Drawing.Point(28, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 510);
            this.panel2.TabIndex = 12;
            // 
            // btnInsertPropietario
            // 
            this.btnInsertPropietario.BackColor = System.Drawing.Color.Green;
            this.btnInsertPropietario.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnInsertPropietario.FlatAppearance.BorderSize = 0;
            this.btnInsertPropietario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertPropietario.ForeColor = System.Drawing.Color.White;
            this.btnInsertPropietario.Location = new System.Drawing.Point(6, 372);
            this.btnInsertPropietario.Name = "btnInsertPropietario";
            this.btnInsertPropietario.Size = new System.Drawing.Size(124, 23);
            this.btnInsertPropietario.TabIndex = 15;
            this.btnInsertPropietario.Text = "Añadir propietario";
            this.btnInsertPropietario.UseVisualStyleBackColor = false;
            this.btnInsertPropietario.Click += new System.EventHandler(this.btnInsertPropietario_Click);
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(6, 302);
            this.txbDireccion.Multiline = true;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(222, 58);
            this.txbDireccion.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Dirección";
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(6, 251);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(222, 20);
            this.txbCorreo.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Correo";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(6, 196);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(222, 20);
            this.txbTelefono.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Teléfono";
            // 
            // txbApellidoM
            // 
            this.txbApellidoM.Location = new System.Drawing.Point(6, 138);
            this.txbApellidoM.Name = "txbApellidoM";
            this.txbApellidoM.Size = new System.Drawing.Size(222, 20);
            this.txbApellidoM.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Apellido Materno";
            // 
            // txbApellidoP
            // 
            this.txbApellidoP.Location = new System.Drawing.Point(3, 82);
            this.txbApellidoP.Name = "txbApellidoP";
            this.txbApellidoP.Size = new System.Drawing.Size(222, 20);
            this.txbApellidoP.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Apellido Paterno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre del propietario";
            // 
            // txbNombrePropietario
            // 
            this.txbNombrePropietario.Location = new System.Drawing.Point(3, 29);
            this.txbNombrePropietario.Name = "txbNombrePropietario";
            this.txbNombrePropietario.Size = new System.Drawing.Size(222, 20);
            this.txbNombrePropietario.TabIndex = 15;
            // 
            // dGVPropietarios
            // 
            this.dGVPropietarios.BackgroundColor = System.Drawing.Color.White;
            this.dGVPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPropietarios.Location = new System.Drawing.Point(396, 36);
            this.dGVPropietarios.Name = "dGVPropietarios";
            this.dGVPropietarios.Size = new System.Drawing.Size(639, 633);
            this.dGVPropietarios.TabIndex = 14;
            // 
            // FormRegistrarPropietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 690);
            this.Controls.Add(this.dGVPropietarios);
            this.Controls.Add(this.lbPropietario);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarPropietarios";
            this.Text = "FormRegistrarPropietarios";
            this.Load += new System.EventHandler(this.FormRegistrarPropietarios_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPropietarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPropietario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInsertPropietario;
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
    }
}