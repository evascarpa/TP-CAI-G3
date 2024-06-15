namespace Grupo3.Presentacion.Usuarios
{
    partial class FormPerfil
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
            ucTexto1 = new Controles.ucTexto();
            ucTitulo1 = new Controles.ucTitulo();
            lblNombreUsuario = new Controles.ucTexto();
            txtPassword = new Controles.ucTextBox();
            txtRepetir = new Controles.ucTextBox();
            ucTexto2 = new Controles.ucTexto();
            ucTexto3 = new Controles.ucTexto();
            ucBotonAceptar1 = new Controles.ucBotonAceptar();
            errorPassword = new Controles.ucLabelError();
            errorGeneral = new Controles.ucLabelError();
            ucTexto4 = new Controles.ucTexto();
            txtActual = new Controles.ucTextBox();
            errorActual = new Controles.ucLabelError();
            errorRepetir = new Controles.ucLabelError();
            SuspendLayout();
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(302, 82);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(169, 21);
            ucTexto1.TabIndex = 0;
            ucTexto1.TitleText = "Nombre de usuario";
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(252, 12);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(477, 38);
            ucTitulo1.TabIndex = 1;
            ucTitulo1.TitleText = "Cambiar contraseña";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Location = new Point(302, 109);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(169, 21);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.TitleText = "label1";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.EsPassword = true;
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(302, 270);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.Size = new Size(250, 34);
            txtPassword.TabIndex = 3;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtRepetir
            // 
            txtRepetir.BackColor = SystemColors.Window;
            txtRepetir.EsPassword = true;
            txtRepetir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRepetir.ForeColor = Color.DimGray;
            txtRepetir.Location = new Point(302, 354);
            txtRepetir.Margin = new Padding(4, 3, 4, 3);
            txtRepetir.Name = "txtRepetir";
            txtRepetir.Padding = new Padding(10, 7, 10, 7);
            txtRepetir.Size = new Size(250, 34);
            txtRepetir.TabIndex = 4;
            txtRepetir.Leave += txtRepetir_Leave;
            // 
            // ucTexto2
            // 
            ucTexto2.BackColor = Color.Transparent;
            ucTexto2.Location = new Point(302, 243);
            ucTexto2.Name = "ucTexto2";
            ucTexto2.Size = new Size(169, 21);
            ucTexto2.TabIndex = 5;
            ucTexto2.TitleText = "Nueva contraseña";
            // 
            // ucTexto3
            // 
            ucTexto3.BackColor = Color.Transparent;
            ucTexto3.Location = new Point(302, 327);
            ucTexto3.Name = "ucTexto3";
            ucTexto3.Size = new Size(169, 21);
            ucTexto3.TabIndex = 6;
            ucTexto3.TitleText = "Ingresela Nuevamente";
            // 
            // ucBotonAceptar1
            // 
            ucBotonAceptar1.BackColor = Color.FromArgb(25, 135, 84);
            ucBotonAceptar1.FlatAppearance.BorderSize = 0;
            ucBotonAceptar1.FlatStyle = FlatStyle.Flat;
            ucBotonAceptar1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonAceptar1.ForeColor = Color.White;
            ucBotonAceptar1.Location = new Point(338, 457);
            ucBotonAceptar1.Name = "ucBotonAceptar1";
            ucBotonAceptar1.Size = new Size(150, 40);
            ucBotonAceptar1.TabIndex = 7;
            ucBotonAceptar1.Text = "Cambiar contraseña";
            ucBotonAceptar1.UseVisualStyleBackColor = false;
            ucBotonAceptar1.Click += ucBotonAceptar1_Click;
            // 
            // errorPassword
            // 
            errorPassword.BackColor = Color.Transparent;
            errorPassword.Location = new Point(302, 309);
            errorPassword.Name = "errorPassword";
            errorPassword.Size = new Size(430, 16);
            errorPassword.TabIndex = 8;
            errorPassword.Visible = false;
            // 
            // errorGeneral
            // 
            errorGeneral.BackColor = Color.Transparent;
            errorGeneral.Location = new Point(302, 435);
            errorGeneral.Name = "errorGeneral";
            errorGeneral.Size = new Size(430, 16);
            errorGeneral.TabIndex = 9;
            errorGeneral.Visible = false;
            // 
            // ucTexto4
            // 
            ucTexto4.BackColor = Color.Transparent;
            ucTexto4.Location = new Point(302, 153);
            ucTexto4.Name = "ucTexto4";
            ucTexto4.Size = new Size(169, 21);
            ucTexto4.TabIndex = 11;
            ucTexto4.TitleText = "Contraseña actual";
            // 
            // txtActual
            // 
            txtActual.BackColor = SystemColors.Window;
            txtActual.EsPassword = true;
            txtActual.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtActual.ForeColor = Color.DimGray;
            txtActual.Location = new Point(302, 180);
            txtActual.Margin = new Padding(4, 3, 4, 3);
            txtActual.Name = "txtActual";
            txtActual.Padding = new Padding(10, 7, 10, 7);
            txtActual.Size = new Size(250, 34);
            txtActual.TabIndex = 10;
            txtActual.Leave += txtActual_Leave;
            // 
            // errorActual
            // 
            errorActual.BackColor = Color.Transparent;
            errorActual.Location = new Point(302, 220);
            errorActual.Name = "errorActual";
            errorActual.Size = new Size(430, 16);
            errorActual.TabIndex = 12;
            errorActual.Visible = false;
            // 
            // errorRepetir
            // 
            errorRepetir.BackColor = Color.Transparent;
            errorRepetir.Location = new Point(302, 394);
            errorRepetir.Name = "errorRepetir";
            errorRepetir.Size = new Size(430, 16);
            errorRepetir.TabIndex = 13;
            errorRepetir.Visible = false;
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 571);
            Controls.Add(errorRepetir);
            Controls.Add(errorActual);
            Controls.Add(ucTexto4);
            Controls.Add(txtActual);
            Controls.Add(errorGeneral);
            Controls.Add(errorPassword);
            Controls.Add(ucBotonAceptar1);
            Controls.Add(ucTexto3);
            Controls.Add(ucTexto2);
            Controls.Add(txtRepetir);
            Controls.Add(txtPassword);
            Controls.Add(lblNombreUsuario);
            Controls.Add(ucTitulo1);
            Controls.Add(ucTexto1);
            Name = "FormPerfil";
            Text = "FormPerfil";
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucTexto ucTexto1;
        private Controles.ucTitulo ucTitulo1;
        private Controles.ucTexto lblNombreUsuario;
        private Controles.ucTextBox txtPassword;
        private Controles.ucTextBox txtRepetir;
        private Controles.ucTexto ucTexto2;
        private Controles.ucTexto ucTexto3;
        private Controles.ucBotonAceptar ucBotonAceptar1;
        private Controles.ucLabelError errorPassword;
        private Controles.ucLabelError errorGeneral;
        private Controles.ucTexto ucTexto4;
        private Controles.ucTextBox txtActual;
        private Controles.ucLabelError errorActual;
        private Controles.ucLabelError errorRepetir;
    }
}