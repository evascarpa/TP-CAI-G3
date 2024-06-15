namespace Grupo3.Presentacion.Proveedores
{
    partial class FormProveedoresAlta
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
            botonGuardar = new Controles.ucBotonAceptar();
            errorCategoria = new Controles.ucLabelError();
            errorPrecio = new Controles.ucLabelError();
            ucTexto5 = new Controles.ucTexto();
            txtApellido = new Controles.ucTextBox();
            ucTexto4 = new Controles.ucTexto();
            txtCuit = new Controles.ucTextBox();
            errorStock = new Controles.ucLabelError();
            txtEmail = new Controles.ucTextBox();
            ucTexto1 = new Controles.ucTexto();
            errorNombre = new Controles.ucLabelError();
            txtNombre = new Controles.ucTextBox();
            lblNombre = new Controles.ucTexto();
            ucTitulo1 = new Controles.ucTitulo();
            errorGuardar = new Controles.ucLabelError();
            ucBotonPrimario1 = new Controles.ucBotonPrimario();
            SuspendLayout();
            // 
            // botonGuardar
            // 
            botonGuardar.BackColor = Color.FromArgb(25, 135, 84);
            botonGuardar.FlatAppearance.BorderSize = 0;
            botonGuardar.FlatStyle = FlatStyle.Flat;
            botonGuardar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botonGuardar.ForeColor = Color.White;
            botonGuardar.Location = new Point(481, 358);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(150, 40);
            botonGuardar.TabIndex = 80;
            botonGuardar.Text = "Agregar";
            botonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // errorCategoria
            // 
            errorCategoria.BackColor = Color.Transparent;
            errorCategoria.Location = new Point(481, 248);
            errorCategoria.Margin = new Padding(3, 4, 3, 4);
            errorCategoria.Name = "errorCategoria";
            errorCategoria.Size = new Size(280, 16);
            errorCategoria.TabIndex = 79;
            errorCategoria.Visible = false;
            // 
            // errorPrecio
            // 
            errorPrecio.BackColor = Color.Transparent;
            errorPrecio.Location = new Point(481, 162);
            errorPrecio.Margin = new Padding(3, 4, 3, 4);
            errorPrecio.Name = "errorPrecio";
            errorPrecio.Size = new Size(280, 16);
            errorPrecio.TabIndex = 78;
            errorPrecio.Visible = false;
            // 
            // ucTexto5
            // 
            ucTexto5.BackColor = Color.Transparent;
            ucTexto5.Location = new Point(481, 96);
            ucTexto5.Margin = new Padding(3, 4, 3, 4);
            ucTexto5.Name = "ucTexto5";
            ucTexto5.Size = new Size(169, 21);
            ucTexto5.TabIndex = 77;
            ucTexto5.TitleText = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.Window;
            txtApellido.EsPassword = false;
            txtApellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.DimGray;
            txtApellido.Location = new Point(481, 124);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Padding = new Padding(7, 7, 7, 7);
            txtApellido.Size = new Size(250, 31);
            txtApellido.TabIndex = 76;
            txtApellido.TieneError = false;
            // 
            // ucTexto4
            // 
            ucTexto4.BackColor = Color.Transparent;
            ucTexto4.Location = new Point(481, 192);
            ucTexto4.Margin = new Padding(3, 4, 3, 4);
            ucTexto4.Name = "ucTexto4";
            ucTexto4.Size = new Size(169, 21);
            ucTexto4.TabIndex = 75;
            ucTexto4.TitleText = "CUIT";
            // 
            // txtCuit
            // 
            txtCuit.BackColor = SystemColors.Window;
            txtCuit.EsPassword = false;
            txtCuit.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuit.ForeColor = Color.DimGray;
            txtCuit.Location = new Point(481, 212);
            txtCuit.Margin = new Padding(4, 3, 4, 3);
            txtCuit.Name = "txtCuit";
            txtCuit.Padding = new Padding(7, 7, 7, 7);
            txtCuit.Size = new Size(250, 31);
            txtCuit.TabIndex = 74;
            txtCuit.TieneError = false;
            // 
            // errorStock
            // 
            errorStock.BackColor = Color.Transparent;
            errorStock.Location = new Point(79, 248);
            errorStock.Margin = new Padding(3, 4, 3, 4);
            errorStock.Name = "errorStock";
            errorStock.Size = new Size(280, 16);
            errorStock.TabIndex = 71;
            errorStock.Visible = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.EsPassword = false;
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(79, 212);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7, 7, 7, 7);
            txtEmail.Size = new Size(250, 31);
            txtEmail.TabIndex = 70;
            txtEmail.TieneError = false;
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(79, 192);
            ucTexto1.Margin = new Padding(3, 4, 3, 4);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(169, 21);
            ucTexto1.TabIndex = 69;
            ucTexto1.TitleText = "Email";
            // 
            // errorNombre
            // 
            errorNombre.BackColor = Color.Transparent;
            errorNombre.Location = new Point(79, 152);
            errorNombre.Margin = new Padding(3, 4, 3, 4);
            errorNombre.Name = "errorNombre";
            errorNombre.Size = new Size(280, 16);
            errorNombre.TabIndex = 68;
            errorNombre.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.EsPassword = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(79, 116);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(7, 7, 7, 7);
            txtNombre.Size = new Size(250, 31);
            txtNombre.TabIndex = 67;
            txtNombre.TieneError = false;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(79, 96);
            lblNombre.Margin = new Padding(3, 4, 3, 4);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(169, 21);
            lblNombre.TabIndex = 66;
            lblNombre.TitleText = "Nombre";
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(79, 30);
            ucTitulo1.Margin = new Padding(3, 4, 3, 4);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(477, 38);
            ucTitulo1.TabIndex = 65;
            ucTitulo1.TitleText = "Agregar Proovedor";
            // 
            // errorGuardar
            // 
            errorGuardar.BackColor = Color.Transparent;
            errorGuardar.Location = new Point(481, 404);
            errorGuardar.Margin = new Padding(3, 4, 3, 4);
            errorGuardar.Name = "errorGuardar";
            errorGuardar.Size = new Size(280, 16);
            errorGuardar.TabIndex = 81;
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
            ucBotonPrimario1.Location = new Point(696, 361);
            ucBotonPrimario1.Margin = new Padding(3, 2, 3, 2);
            ucBotonPrimario1.Name = "ucBotonPrimario1";
            ucBotonPrimario1.Size = new Size(164, 38);
            ucBotonPrimario1.TabIndex = 92;
            ucBotonPrimario1.Text = "Volver";
            ucBotonPrimario1.UseVisualStyleBackColor = false;
            ucBotonPrimario1.Click += ucBotonPrimario1_Click;
            // 
            // FormProveedoresAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 571);
            Controls.Add(ucBotonPrimario1);
            Controls.Add(errorGuardar);
            Controls.Add(botonGuardar);
            Controls.Add(errorCategoria);
            Controls.Add(errorPrecio);
            Controls.Add(ucTexto5);
            Controls.Add(txtApellido);
            Controls.Add(ucTexto4);
            Controls.Add(txtCuit);
            Controls.Add(errorStock);
            Controls.Add(txtEmail);
            Controls.Add(ucTexto1);
            Controls.Add(errorNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(ucTitulo1);
            Name = "FormProveedoresAlta";
            Text = "FormProveedoresAlta";
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucBotonAceptar botonGuardar;
        private Controles.ucLabelError errorCategoria;
        private Controles.ucLabelError errorPrecio;
        private Controles.ucTexto ucTexto5;
        private Controles.ucTextBox txtApellido;
        private Controles.ucTexto ucTexto4;
        private Controles.ucTextBox txtCuit;
        private Controles.ucLabelError errorStock;
        private Controles.ucTextBox txtEmail;
        private Controles.ucTexto ucTexto1;
        private Controles.ucLabelError errorNombre;
        private Controles.ucTextBox txtNombre;
        private Controles.ucTexto lblNombre;
        private Controles.ucTitulo ucTitulo1;
        private Controles.ucLabelError errorGuardar;
        private Controles.ucBotonPrimario ucBotonPrimario1;
    }
}