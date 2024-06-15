namespace Grupo3.Presentacion
{
    partial class FormAltaCliente
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
            ucTitulo2 = new Controles.ucTitulo();
            errorEmail = new Controles.ucLabelError();
            errorDNI = new Controles.ucLabelError();
            errorTelefono = new Controles.ucLabelError();
            errorDireccion = new Controles.ucLabelError();
            errorApellido = new Controles.ucLabelError();
            errorNombre = new Controles.ucLabelError();
            ucTexto7 = new Controles.ucTexto();
            ucTexto6 = new Controles.ucTexto();
            ucTexto5 = new Controles.ucTexto();
            ucTexto3 = new Controles.ucTexto();
            ucTexto2 = new Controles.ucTexto();
            ucTexto1 = new Controles.ucTexto();
            lblNombre = new Controles.ucTexto();
            datFechaNacimiento = new Controles.ucDate();
            txtDni = new Controles.ucTextBox();
            txtEmail = new Controles.ucTextBox();
            txtTelefono = new Controles.ucTextBox();
            txtDireccion = new Controles.ucTextBox();
            txtApellido = new Controles.ucTextBox();
            txtNombre = new Controles.ucTextBox();
            ucBotonAceptar1 = new Controles.ucBotonAceptar();
            errorNacimiento = new Controles.ucLabelError();
            errorGuardar = new Controles.ucLabelError();
            ucBotonPrimario1 = new Controles.ucBotonPrimario();
            SuspendLayout();
            // 
            // ucTitulo2
            // 
            ucTitulo2.Location = new Point(90, 40);
            ucTitulo2.Margin = new Padding(3, 5, 3, 5);
            ucTitulo2.Name = "ucTitulo2";
            ucTitulo2.Size = new Size(681, 47);
            ucTitulo2.TabIndex = 89;
            ucTitulo2.TitleText = "Alta Cliente";
            // 
            // errorEmail
            // 
            errorEmail.BackColor = Color.Transparent;
            errorEmail.Location = new Point(522, 465);
            errorEmail.Margin = new Padding(3, 5, 3, 5);
            errorEmail.Name = "errorEmail";
            errorEmail.Size = new Size(400, 31);
            errorEmail.TabIndex = 115;
            errorEmail.Visible = false;
            // 
            // errorDNI
            // 
            errorDNI.BackColor = Color.Transparent;
            errorDNI.Location = new Point(98, 475);
            errorDNI.Margin = new Padding(3, 5, 3, 5);
            errorDNI.Name = "errorDNI";
            errorDNI.Size = new Size(289, 32);
            errorDNI.TabIndex = 114;
            errorDNI.Visible = false;
            // 
            // errorTelefono
            // 
            errorTelefono.BackColor = Color.Transparent;
            errorTelefono.Location = new Point(522, 341);
            errorTelefono.Margin = new Padding(3, 5, 3, 5);
            errorTelefono.Name = "errorTelefono";
            errorTelefono.Size = new Size(286, 21);
            errorTelefono.TabIndex = 113;
            errorTelefono.Visible = false;
            // 
            // errorDireccion
            // 
            errorDireccion.BackColor = Color.Transparent;
            errorDireccion.Location = new Point(98, 341);
            errorDireccion.Margin = new Padding(3, 5, 3, 5);
            errorDireccion.Name = "errorDireccion";
            errorDireccion.Size = new Size(286, 21);
            errorDireccion.TabIndex = 112;
            errorDireccion.Visible = false;
            // 
            // errorApellido
            // 
            errorApellido.BackColor = Color.Transparent;
            errorApellido.Location = new Point(522, 208);
            errorApellido.Margin = new Padding(3, 5, 3, 5);
            errorApellido.Name = "errorApellido";
            errorApellido.Size = new Size(286, 27);
            errorApellido.TabIndex = 111;
            errorApellido.Visible = false;
            // 
            // errorNombre
            // 
            errorNombre.BackColor = Color.Transparent;
            errorNombre.Location = new Point(95, 208);
            errorNombre.Margin = new Padding(3, 5, 3, 5);
            errorNombre.Name = "errorNombre";
            errorNombre.Size = new Size(289, 27);
            errorNombre.TabIndex = 110;
            errorNombre.Visible = false;
            // 
            // ucTexto7
            // 
            ucTexto7.BackColor = Color.Transparent;
            ucTexto7.Location = new Point(98, 541);
            ucTexto7.Margin = new Padding(3, 5, 3, 5);
            ucTexto7.Name = "ucTexto7";
            ucTexto7.Size = new Size(193, 28);
            ucTexto7.TabIndex = 106;
            ucTexto7.TitleText = "Fecha de nacimiento";
            // 
            // ucTexto6
            // 
            ucTexto6.BackColor = Color.Transparent;
            ucTexto6.Location = new Point(98, 397);
            ucTexto6.Margin = new Padding(3, 5, 3, 5);
            ucTexto6.Name = "ucTexto6";
            ucTexto6.Size = new Size(193, 28);
            ucTexto6.TabIndex = 105;
            ucTexto6.TitleText = "DNI";
            // 
            // ucTexto5
            // 
            ucTexto5.BackColor = Color.Transparent;
            ucTexto5.Location = new Point(522, 397);
            ucTexto5.Margin = new Padding(3, 5, 3, 5);
            ucTexto5.Name = "ucTexto5";
            ucTexto5.Size = new Size(193, 28);
            ucTexto5.TabIndex = 104;
            ucTexto5.TitleText = "Email";
            // 
            // ucTexto3
            // 
            ucTexto3.BackColor = Color.Transparent;
            ucTexto3.Location = new Point(521, 268);
            ucTexto3.Margin = new Padding(3, 5, 3, 5);
            ucTexto3.Name = "ucTexto3";
            ucTexto3.Size = new Size(193, 28);
            ucTexto3.TabIndex = 102;
            ucTexto3.TitleText = "Telefono";
            // 
            // ucTexto2
            // 
            ucTexto2.BackColor = Color.Transparent;
            ucTexto2.Location = new Point(95, 268);
            ucTexto2.Margin = new Padding(3, 5, 3, 5);
            ucTexto2.Name = "ucTexto2";
            ucTexto2.Size = new Size(193, 28);
            ucTexto2.TabIndex = 101;
            ucTexto2.TitleText = "Direccion";
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(521, 127);
            ucTexto1.Margin = new Padding(3, 5, 3, 5);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(193, 28);
            ucTexto1.TabIndex = 100;
            ucTexto1.TitleText = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(90, 127);
            lblNombre.Margin = new Padding(3, 5, 3, 5);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(193, 28);
            lblNombre.TabIndex = 99;
            lblNombre.TitleText = "Nombre";
            // 
            // datFechaNacimiento
            // 
            datFechaNacimiento.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            datFechaNacimiento.Format = DateTimePickerFormat.Short;
            datFechaNacimiento.Location = new Point(99, 565);
            datFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            datFechaNacimiento.MinimumSize = new Size(4, 35);
            datFechaNacimiento.Name = "datFechaNacimiento";
            datFechaNacimiento.Size = new Size(285, 35);
            datFechaNacimiento.TabIndex = 97;
            datFechaNacimiento.Leave += datFechaNacimiento_Leave;
            // 
            // txtDni
            // 
            txtDni.BackColor = SystemColors.Window;
            txtDni.EsPassword = false;
            txtDni.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.DimGray;
            txtDni.Location = new Point(98, 427);
            txtDni.Margin = new Padding(5, 4, 5, 4);
            txtDni.Name = "txtDni";
            txtDni.Padding = new Padding(8, 9, 8, 9);
            txtDni.Size = new Size(286, 39);
            txtDni.TabIndex = 96;
            txtDni.TieneError = false;
            txtDni.KeyPress += txtDni_KeyPress;
            txtDni.Leave += txtDni_Leave;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.EsPassword = false;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(521, 417);
            txtEmail.Margin = new Padding(5, 4, 5, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(8, 9, 8, 9);
            txtEmail.Size = new Size(286, 39);
            txtEmail.TabIndex = 94;
            txtEmail.TieneError = false;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.Window;
            txtTelefono.EsPassword = false;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.DimGray;
            txtTelefono.Location = new Point(521, 293);
            txtTelefono.Margin = new Padding(5, 4, 5, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(8, 9, 8, 9);
            txtTelefono.Size = new Size(286, 39);
            txtTelefono.TabIndex = 93;
            txtTelefono.TieneError = false;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.Window;
            txtDireccion.EsPassword = false;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.DimGray;
            txtDireccion.Location = new Point(98, 293);
            txtDireccion.Margin = new Padding(5, 4, 5, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Padding = new Padding(8, 9, 8, 9);
            txtDireccion.Size = new Size(286, 39);
            txtDireccion.TabIndex = 92;
            txtDireccion.TieneError = false;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.Window;
            txtApellido.EsPassword = false;
            txtApellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.DimGray;
            txtApellido.Location = new Point(521, 164);
            txtApellido.Margin = new Padding(5, 4, 5, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Padding = new Padding(8, 9, 8, 9);
            txtApellido.Size = new Size(286, 39);
            txtApellido.TabIndex = 91;
            txtApellido.TieneError = false;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.EsPassword = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(95, 164);
            txtNombre.Margin = new Padding(5, 4, 5, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(8, 9, 8, 9);
            txtNombre.Size = new Size(286, 39);
            txtNombre.TabIndex = 90;
            txtNombre.TieneError = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // ucBotonAceptar1
            // 
            ucBotonAceptar1.BackColor = Color.FromArgb(25, 135, 84);
            ucBotonAceptar1.FlatAppearance.BorderSize = 0;
            ucBotonAceptar1.FlatStyle = FlatStyle.Flat;
            ucBotonAceptar1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonAceptar1.ForeColor = Color.White;
            ucBotonAceptar1.Location = new Point(597, 560);
            ucBotonAceptar1.Name = "ucBotonAceptar1";
            ucBotonAceptar1.Size = new Size(187, 51);
            ucBotonAceptar1.TabIndex = 122;
            ucBotonAceptar1.Text = "Guardar";
            ucBotonAceptar1.UseVisualStyleBackColor = false;
            ucBotonAceptar1.Click += ucBotonAceptar1_Click;
            // 
            // errorNacimiento
            // 
            errorNacimiento.BackColor = Color.Transparent;
            errorNacimiento.Location = new Point(99, 609);
            errorNacimiento.Margin = new Padding(3, 5, 3, 5);
            errorNacimiento.Name = "errorNacimiento";
            errorNacimiento.Size = new Size(483, 31);
            errorNacimiento.TabIndex = 123;
            errorNacimiento.Visible = false;
            // 
            // errorGuardar
            // 
            errorGuardar.BackColor = Color.Transparent;
            errorGuardar.Location = new Point(597, 619);
            errorGuardar.Margin = new Padding(3, 5, 3, 5);
            errorGuardar.Name = "errorGuardar";
            errorGuardar.Size = new Size(290, 21);
            errorGuardar.TabIndex = 132;
            errorGuardar.Visible = false;
            // 
            // ucBotonPrimario1
            // 
            ucBotonPrimario1.AccessibleName = "btnVolver";
            ucBotonPrimario1.BackColor = Color.FromArgb(13, 110, 253);
            ucBotonPrimario1.FlatAppearance.BorderSize = 0;
            ucBotonPrimario1.FlatStyle = FlatStyle.Flat;
            ucBotonPrimario1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonPrimario1.ForeColor = Color.White;
            ucBotonPrimario1.Location = new Point(845, 561);
            ucBotonPrimario1.Name = "ucBotonPrimario1";
            ucBotonPrimario1.Size = new Size(188, 50);
            ucBotonPrimario1.TabIndex = 133;
            ucBotonPrimario1.Text = "Volver";
            ucBotonPrimario1.UseVisualStyleBackColor = false;
            ucBotonPrimario1.Click += ucBotonPrimario1_Click;
            // 
            // FormAltaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 761);
            Controls.Add(ucBotonPrimario1);
            Controls.Add(errorGuardar);
            Controls.Add(errorNacimiento);
            Controls.Add(ucBotonAceptar1);
            Controls.Add(errorEmail);
            Controls.Add(errorDNI);
            Controls.Add(errorTelefono);
            Controls.Add(errorDireccion);
            Controls.Add(errorApellido);
            Controls.Add(errorNombre);
            Controls.Add(ucTexto7);
            Controls.Add(ucTexto6);
            Controls.Add(ucTexto5);
            Controls.Add(ucTexto3);
            Controls.Add(ucTexto2);
            Controls.Add(ucTexto1);
            Controls.Add(lblNombre);
            Controls.Add(datFechaNacimiento);
            Controls.Add(txtDni);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(ucTitulo2);
            Name = "FormAltaCliente";
            Text = "FormAltaCliente";
          
            ResumeLayout(false);
        }

        #endregion
        private Controles.ucTitulo ucTitulo2;
        private Controles.ucLabelError errorEmail;
        private Controles.ucLabelError errorDNI;
        private Controles.ucLabelError errorTelefono;
        private Controles.ucLabelError errorDireccion;
        private Controles.ucLabelError errorApellido;
        private Controles.ucLabelError errorNombre;
        private Controles.ucTexto ucTexto7;
        private Controles.ucTexto ucTexto6;
        private Controles.ucTexto ucTexto5;
        private Controles.ucTexto ucTexto3;
        private Controles.ucTexto ucTexto2;
        private Controles.ucTexto ucTexto1;
        private Controles.ucTexto lblNombre;
        private Controles.ucDate datFechaNacimiento;
        private Controles.ucTextBox txtDni;
        private Controles.ucTextBox txtEmail;
        private Controles.ucTextBox txtTelefono;
        private Controles.ucTextBox txtDireccion;
        private Controles.ucTextBox txtApellido;
        private Controles.ucTextBox txtNombre;
        private Controles.ucBotonAceptar ucBotonAceptar1;
        private Controles.ucLabelError errorNacimiento;
        private Controles.ucLabelError errorGuardar;
        private Controles.ucBotonPrimario ucBotonPrimario1;
    }
}