
namespace VISTA
{
    partial class frmSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocios));
            this.gbDatosSocios = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbPiloto = new System.Windows.Forms.GroupBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.cbInstruc = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpVencimientoCMA = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtClaseCMA = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbAlumno = new System.Windows.Forms.RadioButton();
            this.rbPiloto = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbDatosSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.gbSocio.SuspendLayout();
            this.gbPiloto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosSocios
            // 
            this.gbDatosSocios.Controls.Add(this.btnEliminar);
            this.gbDatosSocios.Controls.Add(this.btnConsultar);
            this.gbDatosSocios.Controls.Add(this.btnEditar);
            this.gbDatosSocios.Controls.Add(this.btnAgregar);
            this.gbDatosSocios.Controls.Add(this.dgvSocios);
            this.gbDatosSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosSocios.Location = new System.Drawing.Point(17, 18);
            this.gbDatosSocios.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosSocios.Name = "gbDatosSocios";
            this.gbDatosSocios.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosSocios.Size = new System.Drawing.Size(777, 606);
            this.gbDatosSocios.TabIndex = 0;
            this.gbDatosSocios.TabStop = false;
            this.gbDatosSocios.Text = "Datos socios";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(627, 527);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 57);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(420, 527);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(135, 57);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(213, 527);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 57);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(11, 527);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 57);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Location = new System.Drawing.Point(11, 32);
            this.dgvSocios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.RowHeadersWidth = 51;
            this.dgvSocios.Size = new System.Drawing.Size(751, 475);
            this.dgvSocios.TabIndex = 0;
            // 
            // gbSocio
            // 
            this.gbSocio.Controls.Add(this.txtApellido);
            this.gbSocio.Controls.Add(this.label11);
            this.gbSocio.Controls.Add(this.gbPiloto);
            this.gbSocio.Controls.Add(this.dtpVencimientoCMA);
            this.gbSocio.Controls.Add(this.dtpNacimiento);
            this.gbSocio.Controls.Add(this.txtClaseCMA);
            this.gbSocio.Controls.Add(this.txtEmail);
            this.gbSocio.Controls.Add(this.txtCelular);
            this.gbSocio.Controls.Add(this.txtDomicilio);
            this.gbSocio.Controls.Add(this.txtDNI);
            this.gbSocio.Controls.Add(this.txtNombre);
            this.gbSocio.Controls.Add(this.rbAlumno);
            this.gbSocio.Controls.Add(this.rbPiloto);
            this.gbSocio.Controls.Add(this.label9);
            this.gbSocio.Controls.Add(this.label8);
            this.gbSocio.Controls.Add(this.label7);
            this.gbSocio.Controls.Add(this.label6);
            this.gbSocio.Controls.Add(this.label5);
            this.gbSocio.Controls.Add(this.label4);
            this.gbSocio.Controls.Add(this.label3);
            this.gbSocio.Controls.Add(this.label2);
            this.gbSocio.Controls.Add(this.label1);
            this.gbSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSocio.Location = new System.Drawing.Point(811, 18);
            this.gbSocio.Margin = new System.Windows.Forms.Padding(4);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Padding = new System.Windows.Forms.Padding(4);
            this.gbSocio.Size = new System.Drawing.Size(564, 507);
            this.gbSocio.TabIndex = 1;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Socio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Apellido:";
            // 
            // gbPiloto
            // 
            this.gbPiloto.Controls.Add(this.txtLicencia);
            this.gbPiloto.Controls.Add(this.cbInstruc);
            this.gbPiloto.Controls.Add(this.label10);
            this.gbPiloto.Location = new System.Drawing.Point(131, 389);
            this.gbPiloto.Margin = new System.Windows.Forms.Padding(4);
            this.gbPiloto.Name = "gbPiloto";
            this.gbPiloto.Padding = new System.Windows.Forms.Padding(4);
            this.gbPiloto.Size = new System.Drawing.Size(291, 105);
            this.gbPiloto.TabIndex = 26;
            this.gbPiloto.TabStop = false;
            this.gbPiloto.Text = "Piloto";
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(97, 18);
            this.txtLicencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(184, 26);
            this.txtLicencia.TabIndex = 2;
            // 
            // cbInstruc
            // 
            this.cbInstruc.AutoSize = true;
            this.cbInstruc.Location = new System.Drawing.Point(97, 73);
            this.cbInstruc.Margin = new System.Windows.Forms.Padding(4);
            this.cbInstruc.Name = "cbInstruc";
            this.cbInstruc.Size = new System.Drawing.Size(102, 24);
            this.cbInstruc.TabIndex = 1;
            this.cbInstruc.Text = "Instructor";
            this.cbInstruc.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Licencia:";
            // 
            // dtpVencimientoCMA
            // 
            this.dtpVencimientoCMA.Location = new System.Drawing.Point(231, 314);
            this.dtpVencimientoCMA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVencimientoCMA.Name = "dtpVencimientoCMA";
            this.dtpVencimientoCMA.Size = new System.Drawing.Size(324, 26);
            this.dtpVencimientoCMA.TabIndex = 25;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(231, 124);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(324, 26);
            this.dtpNacimiento.TabIndex = 24;
            // 
            // txtClaseCMA
            // 
            this.txtClaseCMA.Location = new System.Drawing.Point(231, 279);
            this.txtClaseCMA.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaseCMA.Name = "txtClaseCMA";
            this.txtClaseCMA.Size = new System.Drawing.Size(324, 26);
            this.txtClaseCMA.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(231, 239);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 26);
            this.txtEmail.TabIndex = 22;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(231, 198);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(324, 26);
            this.txtCelular.TabIndex = 21;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(231, 159);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(324, 26);
            this.txtDomicilio.TabIndex = 20;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(231, 81);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(324, 26);
            this.txtDNI.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 26);
            this.txtNombre.TabIndex = 18;
            // 
            // rbAlumno
            // 
            this.rbAlumno.AutoSize = true;
            this.rbAlumno.Location = new System.Drawing.Point(357, 357);
            this.rbAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.rbAlumno.Name = "rbAlumno";
            this.rbAlumno.Size = new System.Drawing.Size(86, 24);
            this.rbAlumno.TabIndex = 17;
            this.rbAlumno.TabStop = true;
            this.rbAlumno.Text = "Alumno";
            this.rbAlumno.UseVisualStyleBackColor = true;
            // 
            // rbPiloto
            // 
            this.rbPiloto.AutoSize = true;
            this.rbPiloto.Location = new System.Drawing.Point(231, 357);
            this.rbPiloto.Margin = new System.Windows.Forms.Padding(4);
            this.rbPiloto.Name = "rbPiloto";
            this.rbPiloto.Size = new System.Drawing.Size(72, 24);
            this.rbPiloto.TabIndex = 16;
            this.rbPiloto.TabStop = true;
            this.rbPiloto.Text = "Piloto";
            this.rbPiloto.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 357);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo de socio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vencimiento CMA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Clase CMA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Domicilio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de nacimineto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(811, 545);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 57);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUADAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(1207, 545);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 57);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(357, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(198, 26);
            this.txtApellido.TabIndex = 28;
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 639);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbSocio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbDatosSocios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSocios";
            this.Text = "Socios";
            this.gbDatosSocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            this.gbPiloto.ResumeLayout(false);
            this.gbPiloto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosSocios;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.TextBox txtClaseCMA;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbAlumno;
        private System.Windows.Forms.RadioButton rbPiloto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpVencimientoCMA;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.GroupBox gbPiloto;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.CheckBox cbInstruc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApellido;
    }
}