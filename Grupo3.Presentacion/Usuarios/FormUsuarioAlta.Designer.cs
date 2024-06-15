namespace Grupo3.Presentacion
{
    partial class FormUsuarioAlta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new Controles.ucTextBox();
            txtApellido = new Controles.ucTextBox();
            txtDireccion = new Controles.ucTextBox();
            txtTelefono = new Controles.ucTextBox();
            txtEmail = new Controles.ucTextBox();
            txtUsuario = new Controles.ucTextBox();
            txtDni = new Controles.ucTextBox();
            datFechaNacimiento = new Controles.ucDate();
            cmbHost = new Controles.ucComboBox();
            btnAceptar = new Controles.ucBotonAceptar();
            lblNombre = new Controles.ucTexto();
            ucTexto1 = new Controles.ucTexto();
            ucTexto2 = new Controles.ucTexto();
            ucTexto3 = new Controles.ucTexto();
            ucTexto4 = new Controles.ucTexto();
            ucTexto5 = new Controles.ucTexto();
            ucTexto6 = new Controles.ucTexto();
            ucTexto7 = new Controles.ucTexto();
            ucTexto8 = new Controles.ucTexto();
            ucTitulo1 = new Controles.ucTitulo();
            txtContraseña = new Controles.ucTextBox();
            ucTexto9 = new Controles.ucTexto();
            errorNombre = new Controles.ucLabelError();
            errorApellido = new Controles.ucLabelError();
            errorDireccion = new Controles.ucLabelError();
            errorTelefono = new Controles.ucLabelError();
            errorDNI = new Controles.ucLabelError();
            errorEmail = new Controles.ucLabelError();
            errorUsuario = new Controles.ucLabelError();
            errorContraseña = new Controles.ucLabelError();
            errorHost = new Controles.ucLabelError();
            errorNacimiento = new Controles.ucLabelError();
            errorUsuario2 = new Controles.ucLabelError();
            errorContraseña2 = new Controles.ucLabelError();
            errorGuardar = new Controles.ucLabelError();
            ucBotonPrimario1 = new Controles.ucBotonPrimario();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.EsPassword = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(186, 135);
            txtNombre.Margin = new Padding(5, 4, 5, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(8, 9, 8, 9);
            txtNombre.Size = new Size(286, 39);
            txtNombre.TabIndex = 20;
            txtNombre.TieneError = false;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.Window;
            txtApellido.EsPassword = false;
            txtApellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.DimGray;
            txtApellido.Location = new Point(539, 135);
            txtApellido.Margin = new Padding(5, 4, 5, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Padding = new Padding(8, 9, 8, 9);
            txtApellido.Size = new Size(286, 39);
            txtApellido.TabIndex = 21;
            txtApellido.TieneError = false;
            txtApellido.KeyPress += txtApellido_KeyPress;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.Window;
            txtDireccion.EsPassword = false;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.DimGray;
            txtDireccion.Location = new Point(187, 251);
            txtDireccion.Margin = new Padding(5, 4, 5, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Padding = new Padding(8, 9, 8, 9);
            txtDireccion.Size = new Size(286, 39);
            txtDireccion.TabIndex = 22;
            txtDireccion.TieneError = false;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = SystemColors.Window;
            txtTelefono.EsPassword = false;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.DimGray;
            txtTelefono.Location = new Point(539, 251);
            txtTelefono.Margin = new Padding(5, 4, 5, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(8, 9, 8, 9);
            txtTelefono.Size = new Size(286, 39);
            txtTelefono.TabIndex = 23;
            txtTelefono.TieneError = false;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.EsPassword = false;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(539, 368);
            txtEmail.Margin = new Padding(5, 4, 5, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(8, 9, 8, 9);
            txtEmail.Size = new Size(286, 39);
            txtEmail.TabIndex = 24;
            txtEmail.TieneError = false;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.EsPassword = false;
            txtUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(190, 479);
            txtUsuario.Margin = new Padding(5, 4, 5, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(8, 9, 8, 9);
            txtUsuario.Size = new Size(286, 39);
            txtUsuario.TabIndex = 25;
            txtUsuario.TieneError = false;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtDni
            // 
            txtDni.BackColor = SystemColors.Window;
            txtDni.EsPassword = false;
            txtDni.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.ForeColor = Color.DimGray;
            txtDni.Location = new Point(190, 368);
            txtDni.Margin = new Padding(5, 4, 5, 4);
            txtDni.Name = "txtDni";
            txtDni.Padding = new Padding(8, 9, 8, 9);
            txtDni.Size = new Size(286, 39);
            txtDni.TabIndex = 26;
            txtDni.TieneError = false;
            txtDni.KeyPress += txtDni_KeyPress;
            txtDni.Leave += txtDni_Leave;
            // 
            // datFechaNacimiento
            // 
            datFechaNacimiento.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            datFechaNacimiento.Format = DateTimePickerFormat.Short;
            datFechaNacimiento.Location = new Point(539, 593);
            datFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            datFechaNacimiento.MinimumSize = new Size(4, 35);
            datFechaNacimiento.Name = "datFechaNacimiento";
            datFechaNacimiento.Size = new Size(285, 35);
            datFechaNacimiento.TabIndex = 28;
            datFechaNacimiento.Leave += datFechaNacimiento_Leave;
            // 
            // cmbHost
            // 
            cmbHost.BackColor = Color.FromArgb(222, 226, 230);
            cmbHost.DisplayMember = "";
            cmbHost.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbHost.Location = new Point(190, 593);
            cmbHost.Margin = new Padding(3, 4, 3, 4);
            cmbHost.MinimumSize = new Size(286, 44);
            cmbHost.Name = "cmbHost";
            cmbHost.Padding = new Padding(2, 3, 2, 3);
            cmbHost.SelectedIndex = -1;
            cmbHost.SelectedText = "";
            cmbHost.Size = new Size(286, 44);
            cmbHost.TabIndex = 29;
            cmbHost.ValueMember = "";
            cmbHost.Leave += cmbHost_Leave;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(25, 135, 84);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(426, 675);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(171, 53);
            btnAceptar.TabIndex = 30;
            btnAceptar.Text = "Guardar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += ucBotonAceptar1_Click;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(187, 97);
            lblNombre.Margin = new Padding(3, 5, 3, 5);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(193, 28);
            lblNombre.TabIndex = 35;
            lblNombre.TitleText = "Nombre";
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(539, 97);
            ucTexto1.Margin = new Padding(3, 5, 3, 5);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(193, 28);
            ucTexto1.TabIndex = 36;
            ucTexto1.TitleText = "Apellido";
            // 
            // ucTexto2
            // 
            ucTexto2.BackColor = Color.Transparent;
            ucTexto2.Location = new Point(187, 215);
            ucTexto2.Margin = new Padding(3, 5, 3, 5);
            ucTexto2.Name = "ucTexto2";
            ucTexto2.Size = new Size(193, 28);
            ucTexto2.TabIndex = 37;
            ucTexto2.TitleText = "Direccion";
            // 
            // ucTexto3
            // 
            ucTexto3.BackColor = Color.Transparent;
            ucTexto3.Location = new Point(539, 215);
            ucTexto3.Margin = new Padding(3, 5, 3, 5);
            ucTexto3.Name = "ucTexto3";
            ucTexto3.Size = new Size(193, 28);
            ucTexto3.TabIndex = 38;
            ucTexto3.TitleText = "Telefono";
            // 
            // ucTexto4
            // 
            ucTexto4.BackColor = Color.Transparent;
            ucTexto4.Location = new Point(190, 448);
            ucTexto4.Margin = new Padding(3, 5, 3, 5);
            ucTexto4.Name = "ucTexto4";
            ucTexto4.Size = new Size(193, 28);
            ucTexto4.TabIndex = 39;
            ucTexto4.TitleText = "Usuario";
            // 
            // ucTexto5
            // 
            ucTexto5.BackColor = Color.Transparent;
            ucTexto5.Location = new Point(539, 331);
            ucTexto5.Margin = new Padding(3, 5, 3, 5);
            ucTexto5.Name = "ucTexto5";
            ucTexto5.Size = new Size(193, 28);
            ucTexto5.TabIndex = 40;
            ucTexto5.TitleText = "Email";
            // 
            // ucTexto6
            // 
            ucTexto6.BackColor = Color.Transparent;
            ucTexto6.Location = new Point(190, 331);
            ucTexto6.Margin = new Padding(3, 5, 3, 5);
            ucTexto6.Name = "ucTexto6";
            ucTexto6.Size = new Size(193, 28);
            ucTexto6.TabIndex = 41;
            ucTexto6.TitleText = "DNI";
            // 
            // ucTexto7
            // 
            ucTexto7.BackColor = Color.Transparent;
            ucTexto7.Location = new Point(539, 559);
            ucTexto7.Margin = new Padding(3, 5, 3, 5);
            ucTexto7.Name = "ucTexto7";
            ucTexto7.Size = new Size(193, 28);
            ucTexto7.TabIndex = 42;
            ucTexto7.TitleText = "Fecha de nacimiento";
            // 
            // ucTexto8
            // 
            ucTexto8.BackColor = Color.Transparent;
            ucTexto8.Location = new Point(187, 559);
            ucTexto8.Margin = new Padding(3, 5, 3, 5);
            ucTexto8.Name = "ucTexto8";
            ucTexto8.Size = new Size(193, 28);
            ucTexto8.TabIndex = 43;
            ucTexto8.TitleText = "Host";
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(187, 36);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(545, 51);
            ucTitulo1.TabIndex = 44;
            ucTitulo1.TitleText = "Crear usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.Window;
            txtContraseña.EsPassword = false;
            txtContraseña.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(539, 479);
            txtContraseña.Margin = new Padding(5, 4, 5, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Padding = new Padding(8, 9, 8, 9);
            txtContraseña.Size = new Size(286, 39);
            txtContraseña.TabIndex = 45;
            txtContraseña.TieneError = false;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // ucTexto9
            // 
            ucTexto9.BackColor = Color.Transparent;
            ucTexto9.Location = new Point(539, 448);
            ucTexto9.Margin = new Padding(3, 5, 3, 5);
            ucTexto9.Name = "ucTexto9";
            ucTexto9.Size = new Size(193, 28);
            ucTexto9.TabIndex = 46;
            ucTexto9.TitleText = "Contraseña";
            // 
            // errorNombre
            // 
            errorNombre.BackColor = Color.Transparent;
            errorNombre.Location = new Point(187, 184);
            errorNombre.Margin = new Padding(3, 5, 3, 5);
            errorNombre.Name = "errorNombre";
            errorNombre.Size = new Size(320, 21);
            errorNombre.TabIndex = 47;
            errorNombre.Visible = false;
            // 
            // errorApellido
            // 
            errorApellido.BackColor = Color.Transparent;
            errorApellido.Location = new Point(539, 184);
            errorApellido.Margin = new Padding(3, 5, 3, 5);
            errorApellido.Name = "errorApellido";
            errorApellido.Size = new Size(491, 21);
            errorApellido.TabIndex = 48;
            errorApellido.Visible = false;
            // 
            // errorDireccion
            // 
            errorDireccion.BackColor = Color.Transparent;
            errorDireccion.Location = new Point(187, 300);
            errorDireccion.Margin = new Padding(3, 5, 3, 5);
            errorDireccion.Name = "errorDireccion";
            errorDireccion.Size = new Size(320, 21);
            errorDireccion.TabIndex = 49;
            errorDireccion.Visible = false;
            // 
            // errorTelefono
            // 
            errorTelefono.BackColor = Color.Transparent;
            errorTelefono.Location = new Point(539, 300);
            errorTelefono.Margin = new Padding(3, 5, 3, 5);
            errorTelefono.Name = "errorTelefono";
            errorTelefono.Size = new Size(491, 21);
            errorTelefono.TabIndex = 50;
            errorTelefono.Visible = false;
           
            // 
            // errorDNI
            // 
            errorDNI.BackColor = Color.Transparent;
            errorDNI.Location = new Point(190, 417);
            errorDNI.Margin = new Padding(3, 5, 3, 5);
            errorDNI.Name = "errorDNI";
            errorDNI.Size = new Size(320, 21);
            errorDNI.TabIndex = 51;
            errorDNI.Visible = false;
            // 
            // errorEmail
            // 
            errorEmail.BackColor = Color.Transparent;
            errorEmail.Location = new Point(539, 417);
            errorEmail.Margin = new Padding(3, 5, 3, 5);
            errorEmail.Name = "errorEmail";
            errorEmail.Size = new Size(491, 21);
            errorEmail.TabIndex = 52;
            errorEmail.Visible = false;
            // 
            // errorUsuario
            // 
            errorUsuario.BackColor = Color.Transparent;
            errorUsuario.Location = new Point(190, 528);
            errorUsuario.Margin = new Padding(3, 5, 3, 5);
            errorUsuario.Name = "errorUsuario";
            errorUsuario.Size = new Size(320, 21);
            errorUsuario.TabIndex = 53;
            errorUsuario.Visible = false;
            // 
            // errorContraseña
            // 
            errorContraseña.BackColor = Color.Transparent;
            errorContraseña.Location = new Point(539, 528);
            errorContraseña.Margin = new Padding(3, 5, 3, 5);
            errorContraseña.Name = "errorContraseña";
            errorContraseña.Size = new Size(491, 21);
            errorContraseña.TabIndex = 54;
            errorContraseña.Visible = false;
            // 
            // errorHost
            // 
            errorHost.BackColor = Color.Transparent;
            errorHost.Location = new Point(186, 645);
            errorHost.Margin = new Padding(3, 5, 3, 5);
            errorHost.Name = "errorHost";
            errorHost.Size = new Size(491, 21);
            errorHost.TabIndex = 55;
            errorHost.Visible = false;
            // 
            // errorNacimiento
            // 
            errorNacimiento.BackColor = Color.Transparent;
            errorNacimiento.Location = new Point(539, 645);
            errorNacimiento.Margin = new Padding(3, 5, 3, 5);
            errorNacimiento.Name = "errorNacimiento";
            errorNacimiento.Size = new Size(491, 21);
            errorNacimiento.TabIndex = 56;
            errorNacimiento.Visible = false;
            // 
            // errorUsuario2
            // 
            errorUsuario2.BackColor = Color.Transparent;
            errorUsuario2.Location = new Point(190, 528);
            errorUsuario2.Margin = new Padding(3, 5, 3, 5);
            errorUsuario2.Name = "errorUsuario2";
            errorUsuario2.Size = new Size(320, 21);
            errorUsuario2.TabIndex = 57;
            errorUsuario2.Visible = false;
            // 
            // errorContraseña2
            // 
            errorContraseña2.BackColor = Color.Transparent;
            errorContraseña2.Location = new Point(539, 528);
            errorContraseña2.Margin = new Padding(3, 5, 3, 5);
            errorContraseña2.Name = "errorContraseña2";
            errorContraseña2.Size = new Size(491, 21);
            errorContraseña2.TabIndex = 58;
            errorContraseña2.Visible = false;
            // 
            // errorGuardar
            // 
            errorGuardar.BackColor = Color.Transparent;
            errorGuardar.Location = new Point(426, 736);
            errorGuardar.Margin = new Padding(3, 5, 3, 5);
            errorGuardar.Name = "errorGuardar";
            errorGuardar.Size = new Size(320, 21);
            errorGuardar.TabIndex = 59;
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
            ucBotonPrimario1.Location = new Point(681, 674);
            ucBotonPrimario1.Name = "ucBotonPrimario1";
            ucBotonPrimario1.Size = new Size(188, 50);
            ucBotonPrimario1.TabIndex = 93;
            ucBotonPrimario1.Text = "Volver";
            ucBotonPrimario1.UseVisualStyleBackColor = false;
            ucBotonPrimario1.Click += ucBotonPrimario1_Click;
            // 
            // FormUsuarioAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1182, 761);
            Controls.Add(ucBotonPrimario1);
            Controls.Add(errorGuardar);
            Controls.Add(errorContraseña2);
            Controls.Add(errorUsuario2);
            Controls.Add(errorNacimiento);
            Controls.Add(errorHost);
            Controls.Add(errorContraseña);
            Controls.Add(errorUsuario);
            Controls.Add(errorEmail);
            Controls.Add(errorDNI);
            Controls.Add(errorTelefono);
            Controls.Add(errorDireccion);
            Controls.Add(errorApellido);
            Controls.Add(errorNombre);
            Controls.Add(ucTexto9);
            Controls.Add(txtContraseña);
            Controls.Add(ucTitulo1);
            Controls.Add(ucTexto8);
            Controls.Add(ucTexto7);
            Controls.Add(ucTexto6);
            Controls.Add(ucTexto5);
            Controls.Add(ucTexto4);
            Controls.Add(ucTexto3);
            Controls.Add(ucTexto2);
            Controls.Add(ucTexto1);
            Controls.Add(lblNombre);
            Controls.Add(btnAceptar);
            Controls.Add(cmbHost);
            Controls.Add(datFechaNacimiento);
            Controls.Add(txtDni);
            Controls.Add(txtUsuario);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FormUsuarioAlta";
            Text = "Form1";
            
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private Controles.ucTextBox txtNombre;
        private Controles.ucTextBox txtApellido;
        private Controles.ucTextBox txtDireccion;
        private Controles.ucTextBox txtTelefono;
        private Controles.ucTextBox txtEmail;
        private Controles.ucTextBox txtUsuario;
        private Controles.ucTextBox txtDni;
        private Controles.ucDate datFechaNacimiento;
        private Controles.ucComboBox cmbHost;
        private Controles.ucBotonAceptar btnAceptar;
        private Controles.ucTexto lblNombre;
        private Controles.ucTexto ucTexto1;
        private Controles.ucTexto ucTexto2;
        private Controles.ucTexto ucTexto3;
        private Controles.ucTexto ucTexto4;
        private Controles.ucTexto ucTexto5;
        private Controles.ucTexto ucTexto6;
        private Controles.ucTexto ucTexto7;
        private Controles.ucTexto ucTexto8;
        private Controles.ucTitulo ucTitulo1;
        private Controles.ucTextBox txtContraseña;
        private Controles.ucTexto ucTexto9;
        private Controles.ucLabelError errorNombre;
        private Controles.ucLabelError errorApellido;
        private Controles.ucLabelError errorDireccion;
        private Controles.ucLabelError errorTelefono;
        private Controles.ucLabelError errorDNI;
        private Controles.ucLabelError errorEmail;
        private Controles.ucLabelError errorUsuario;
        private Controles.ucLabelError errorContraseña;
        private Controles.ucLabelError errorHost;
        private Controles.ucLabelError errorNacimiento;
        private Controles.ucLabelError errorUsuario2;
        private Controles.ucLabelError errorContraseña2;
        private Controles.ucLabelError errorGuardar;
        private Controles.ucBotonPrimario ucBotonPrimario1;
    }
}