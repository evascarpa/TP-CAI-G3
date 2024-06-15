namespace Grupo3.Presentacion
{
    partial class FormClienteEditar
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
            ucTexto5 = new Controles.ucTexto();
            ucTexto4 = new Controles.ucTexto();
            ucTexto3 = new Controles.ucTexto();
            ucTexto2 = new Controles.ucTexto();
            txtEmail = new Controles.ucTextBox();
            txtTelefono = new Controles.ucTextBox();
            txtDireccion = new Controles.ucTextBox();
            ucTitulo1 = new Controles.ucTitulo();
            btnModificarCliente = new Controles.ucBotonAceptar();
            errorEmail = new Controles.ucLabelError();
            errorDireccion = new Controles.ucLabelError();
            errorEditar = new Controles.ucLabelError();
            errorTelefono = new Controles.ucLabelError();
            ucBotonPrimario1 = new Controles.ucBotonPrimario();
            SuspendLayout();
            // 
            // ucTexto5
            // 
            ucTexto5.BackColor = Color.Transparent;
            ucTexto5.Location = new Point(102, 132);
            ucTexto5.Margin = new Padding(3, 5, 3, 5);
            ucTexto5.Name = "ucTexto5";
            ucTexto5.Size = new Size(193, 28);
            ucTexto5.TabIndex = 85;
            ucTexto5.TitleText = "Email";
            // 
            // ucTexto4
            // 
            ucTexto4.BackColor = Color.Transparent;
            ucTexto4.Location = new Point(255, 373);
            ucTexto4.Margin = new Padding(3, 5, 3, 5);
            ucTexto4.Name = "ucTexto4";
            ucTexto4.Size = new Size(193, 28);
            ucTexto4.TabIndex = 84;
            ucTexto4.TitleText = "";
            ucTexto4.Load += ucTexto4_Load;
            // 
            // ucTexto3
            // 
            ucTexto3.BackColor = Color.Transparent;
            ucTexto3.Location = new Point(102, 377);
            ucTexto3.Margin = new Padding(3, 5, 3, 5);
            ucTexto3.Name = "ucTexto3";
            ucTexto3.Size = new Size(193, 28);
            ucTexto3.TabIndex = 83;
            ucTexto3.TitleText = "Telefono";
            // 
            // ucTexto2
            // 
            ucTexto2.BackColor = Color.Transparent;
            ucTexto2.Location = new Point(102, 255);
            ucTexto2.Margin = new Padding(3, 5, 3, 5);
            ucTexto2.Name = "ucTexto2";
            ucTexto2.Size = new Size(193, 28);
            ucTexto2.TabIndex = 82;
            ucTexto2.TitleText = "Direccion";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleName = "txtEmail";
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.EsPassword = false;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(102, 169);
            txtEmail.Margin = new Padding(5, 4, 5, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(8, 9, 8, 9);
            txtEmail.Size = new Size(286, 39);
            txtEmail.TabIndex = 75;
            txtEmail.TieneError = false;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.AccessibleName = "txtTelefono";
            txtTelefono.BackColor = SystemColors.Window;
            txtTelefono.EsPassword = false;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.DimGray;
            txtTelefono.Location = new Point(102, 411);
            txtTelefono.Margin = new Padding(5, 4, 5, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(8, 9, 8, 9);
            txtTelefono.Size = new Size(286, 39);
            txtTelefono.TabIndex = 74;
            txtTelefono.TieneError = false;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtDireccion
            // 
            txtDireccion.AccessibleName = "txtDireccion";
            txtDireccion.BackColor = SystemColors.Window;
            txtDireccion.EsPassword = false;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.DimGray;
            txtDireccion.Location = new Point(102, 292);
            txtDireccion.Margin = new Padding(5, 4, 5, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Padding = new Padding(8, 9, 8, 9);
            txtDireccion.Size = new Size(286, 39);
            txtDireccion.TabIndex = 73;
            txtDireccion.TieneError = false;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(90, 40);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(832, 51);
            ucTitulo1.TabIndex = 70;
            ucTitulo1.TitleText = "Editar Cliente";
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = Color.FromArgb(25, 135, 84);
            btnModificarCliente.FlatAppearance.BorderSize = 0;
            btnModificarCliente.FlatStyle = FlatStyle.Flat;
            btnModificarCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarCliente.ForeColor = Color.White;
            btnModificarCliente.Location = new Point(414, 536);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(187, 53);
            btnModificarCliente.TabIndex = 86;
            btnModificarCliente.Text = "Editar";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // errorEmail
            // 
            errorEmail.AccessibleName = "errorEmail";
            errorEmail.BackColor = Color.Transparent;
            errorEmail.Location = new Point(102, 219);
            errorEmail.Margin = new Padding(3, 5, 3, 5);
            errorEmail.Name = "errorEmail";
            errorEmail.Size = new Size(389, 27);
            errorEmail.TabIndex = 87;
            errorEmail.Visible = false;
            // 
            // errorDireccion
            // 
            errorDireccion.AccessibleName = "errorDireccion";
            errorDireccion.BackColor = Color.Transparent;
            errorDireccion.Location = new Point(102, 341);
            errorDireccion.Margin = new Padding(3, 5, 3, 5);
            errorDireccion.Name = "errorDireccion";
            errorDireccion.Size = new Size(389, 27);
            errorDireccion.TabIndex = 88;
            errorDireccion.Visible = false;
            // 
            // errorEditar
            // 
            errorEditar.AccessibleName = "errorEditar";
            errorEditar.BackColor = Color.Transparent;
            errorEditar.Location = new Point(414, 607);
            errorEditar.Margin = new Padding(3, 5, 3, 5);
            errorEditar.Name = "errorEditar";
            errorEditar.Size = new Size(389, 27);
            errorEditar.TabIndex = 90;
            errorEditar.Visible = false;
            // 
            // errorTelefono
            // 
            errorTelefono.AccessibleName = "errorTel";
            errorTelefono.BackColor = Color.Transparent;
            errorTelefono.Location = new Point(102, 460);
            errorTelefono.Margin = new Padding(3, 5, 3, 5);
            errorTelefono.Name = "errorTelefono";
            errorTelefono.Size = new Size(389, 27);
            errorTelefono.TabIndex = 89;
            errorTelefono.Visible = false;
            // 
            // ucBotonPrimario1
            // 
            ucBotonPrimario1.AccessibleName = "btnVolver";
            ucBotonPrimario1.BackColor = Color.FromArgb(13, 110, 253);
            ucBotonPrimario1.FlatAppearance.BorderSize = 0;
            ucBotonPrimario1.FlatStyle = FlatStyle.Flat;
            ucBotonPrimario1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonPrimario1.ForeColor = Color.White;
            ucBotonPrimario1.Location = new Point(659, 536);
            ucBotonPrimario1.Name = "ucBotonPrimario1";
            ucBotonPrimario1.Size = new Size(188, 50);
            ucBotonPrimario1.TabIndex = 91;
            ucBotonPrimario1.Text = "Volver";
            ucBotonPrimario1.UseVisualStyleBackColor = false;
            ucBotonPrimario1.Click += ucBotonPrimario1_Click;
            // 
            // FormClienteEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 761);
            Controls.Add(ucBotonPrimario1);
            Controls.Add(errorEditar);
            Controls.Add(errorTelefono);
            Controls.Add(errorDireccion);
            Controls.Add(errorEmail);
            Controls.Add(btnModificarCliente);
            Controls.Add(ucTexto5);
            Controls.Add(ucTexto4);
            Controls.Add(ucTexto3);
            Controls.Add(ucTexto2);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(ucTitulo1);
            Name = "FormClienteEditar";
            Text = "FormClienteEditar";
            Load += FormClienteEditar_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucTexto ucTexto5;
        private Controles.ucTexto ucTexto4;
        private Controles.ucTexto ucTexto3;
        private Controles.ucTexto ucTexto2;
        private Controles.ucTextBox txtEmail;
        private Controles.ucTextBox txtTelefono;
        private Controles.ucTextBox txtDireccion;
        private Controles.ucTitulo ucTitulo1;
        private Controles.ucBotonAceptar btnModificarCliente;
        private Controles.ucLabelError errorEmail;
        private Controles.ucLabelError errorDireccion;
        private Controles.ucLabelError errorEditar;
        private Controles.ucLabelError errorTelefono;
        private Controles.ucBotonPrimario ucBotonPrimario1;
    }
}