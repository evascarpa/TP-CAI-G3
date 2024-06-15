namespace Grupo3.Presentacion
{
    partial class FormProductoAlta
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
            ucTitulo1 = new Controles.ucTitulo();
            lblNombre = new Controles.ucTexto();
            txtNombre = new Controles.ucTextBox();
            errorNombre = new Controles.ucLabelError();
            ucTexto1 = new Controles.ucTexto();
            txtStock = new Controles.ucTextBox();
            errorStock = new Controles.ucLabelError();
            cmbProveedor = new Controles.ucComboBox();
            ucTexto3 = new Controles.ucTexto();
            ucTexto4 = new Controles.ucTexto();
            txtPrecio = new Controles.ucTextBox();
            ucTexto5 = new Controles.ucTexto();
            errorPrecio = new Controles.ucLabelError();
            errorCategoria = new Controles.ucLabelError();
            botonGuardar = new Controles.ucBotonAceptar();
            errorGuardar = new Controles.ucLabelError();
            errorProveedor = new Controles.ucLabelError();
            cmbCategoria = new Controles.ucComboBox();
            ucBotonPrimario1 = new Controles.ucBotonPrimario();
            SuspendLayout();
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(90, 40);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(545, 51);
            ucTitulo1.TabIndex = 45;
            ucTitulo1.TitleText = "Agregar Producto";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(101, 136);
            lblNombre.Margin = new Padding(3, 5, 3, 5);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(193, 28);
            lblNombre.TabIndex = 46;
            lblNombre.TitleText = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.EsPassword = false;
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(101, 161);
            txtNombre.Margin = new Padding(5, 4, 5, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(8, 9, 8, 9);
            txtNombre.Size = new Size(286, 39);
            txtNombre.TabIndex = 47;
            txtNombre.TieneError = false;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // errorNombre
            // 
            errorNombre.BackColor = Color.Transparent;
            errorNombre.Location = new Point(101, 209);
            errorNombre.Margin = new Padding(3, 5, 3, 5);
            errorNombre.Name = "errorNombre";
            errorNombre.Size = new Size(320, 21);
            errorNombre.TabIndex = 48;
            errorNombre.Visible = false;
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(101, 268);
            ucTexto1.Margin = new Padding(3, 5, 3, 5);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(193, 28);
            ucTexto1.TabIndex = 49;
            ucTexto1.TitleText = "Stock";
            // 
            // txtStock
            // 
            txtStock.BackColor = SystemColors.Window;
            txtStock.EsPassword = false;
            txtStock.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.ForeColor = Color.DimGray;
            txtStock.Location = new Point(101, 297);
            txtStock.Margin = new Padding(5, 4, 5, 4);
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(8, 9, 8, 9);
            txtStock.Size = new Size(286, 39);
            txtStock.TabIndex = 50;
            txtStock.TieneError = false;
            txtStock.KeyPress += txtStock_KeyPress;
            txtStock.Leave += txtStock_Leave;
            // 
            // errorStock
            // 
            errorStock.BackColor = Color.Transparent;
            errorStock.Location = new Point(101, 345);
            errorStock.Margin = new Padding(3, 5, 3, 5);
            errorStock.Name = "errorStock";
            errorStock.Size = new Size(320, 21);
            errorStock.TabIndex = 51;
            errorStock.Visible = false;
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(222, 226, 230);
            cmbProveedor.DisplayMember = "";
            cmbProveedor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProveedor.Location = new Point(101, 435);
            cmbProveedor.Margin = new Padding(3, 4, 3, 4);
            cmbProveedor.MinimumSize = new Size(286, 44);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Padding = new Padding(2, 3, 2, 3);
            cmbProveedor.SelectedIndex = -1;
            cmbProveedor.SelectedText = "";
            cmbProveedor.Size = new Size(286, 44);
            cmbProveedor.TabIndex = 54;
            cmbProveedor.ValueMember = "";
            cmbProveedor.Leave += cmbProveedor_Leave;
            // 
            // ucTexto3
            // 
            ucTexto3.BackColor = Color.Transparent;
            ucTexto3.Location = new Point(101, 409);
            ucTexto3.Margin = new Padding(3, 5, 3, 5);
            ucTexto3.Name = "ucTexto3";
            ucTexto3.Size = new Size(193, 28);
            ucTexto3.TabIndex = 55;
            ucTexto3.TitleText = "Proveedor";
            // 
            // ucTexto4
            // 
            ucTexto4.BackColor = Color.Transparent;
            ucTexto4.Location = new Point(550, 268);
            ucTexto4.Margin = new Padding(3, 5, 3, 5);
            ucTexto4.Name = "ucTexto4";
            ucTexto4.Size = new Size(193, 28);
            ucTexto4.TabIndex = 57;
            ucTexto4.TitleText = "Categoria";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Window;
            txtPrecio.EsPassword = false;
            txtPrecio.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = Color.DimGray;
            txtPrecio.Location = new Point(550, 173);
            txtPrecio.Margin = new Padding(5, 4, 5, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Padding = new Padding(8, 9, 8, 9);
            txtPrecio.Size = new Size(286, 39);
            txtPrecio.TabIndex = 58;
            txtPrecio.TieneError = false;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            txtPrecio.Leave += txtPrecio_Leave;
            // 
            // ucTexto5
            // 
            ucTexto5.BackColor = Color.Transparent;
            ucTexto5.Location = new Point(550, 136);
            ucTexto5.Margin = new Padding(3, 5, 3, 5);
            ucTexto5.Name = "ucTexto5";
            ucTexto5.Size = new Size(193, 28);
            ucTexto5.TabIndex = 59;
            ucTexto5.TitleText = "Precio";
            // 
            // errorPrecio
            // 
            errorPrecio.BackColor = Color.Transparent;
            errorPrecio.Location = new Point(550, 221);
            errorPrecio.Margin = new Padding(3, 5, 3, 5);
            errorPrecio.Name = "errorPrecio";
            errorPrecio.Size = new Size(320, 21);
            errorPrecio.TabIndex = 60;
            errorPrecio.Visible = false;
            // 
            // errorCategoria
            // 
            errorCategoria.BackColor = Color.Transparent;
            errorCategoria.Location = new Point(550, 345);
            errorCategoria.Margin = new Padding(3, 5, 3, 5);
            errorCategoria.Name = "errorCategoria";
            errorCategoria.Size = new Size(320, 21);
            errorCategoria.TabIndex = 61;
            errorCategoria.Visible = false;
            // 
            // botonGuardar
            // 
            botonGuardar.BackColor = Color.FromArgb(25, 135, 84);
            botonGuardar.FlatAppearance.BorderSize = 0;
            botonGuardar.FlatStyle = FlatStyle.Flat;
            botonGuardar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botonGuardar.ForeColor = Color.White;
            botonGuardar.Location = new Point(550, 540);
            botonGuardar.Margin = new Padding(3, 4, 3, 4);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(171, 53);
            botonGuardar.TabIndex = 64;
            botonGuardar.Text = "Agregar";
            botonGuardar.UseVisualStyleBackColor = false;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // errorGuardar
            // 
            errorGuardar.BackColor = Color.Transparent;
            errorGuardar.Location = new Point(550, 603);
            errorGuardar.Margin = new Padding(3, 5, 3, 5);
            errorGuardar.Name = "errorGuardar";
            errorGuardar.Size = new Size(320, 21);
            errorGuardar.TabIndex = 65;
            errorGuardar.Visible = false;
            // 
            // errorProveedor
            // 
            errorProveedor.BackColor = Color.Transparent;
            errorProveedor.Location = new Point(101, 488);
            errorProveedor.Margin = new Padding(3, 5, 3, 5);
            errorProveedor.Name = "errorProveedor";
            errorProveedor.Size = new Size(320, 21);
            errorProveedor.TabIndex = 66;
            errorProveedor.Visible = false;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(222, 226, 230);
            cmbCategoria.DisplayMember = "";
            cmbCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategoria.Location = new Point(550, 295);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.MinimumSize = new Size(286, 44);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Padding = new Padding(2, 3, 2, 3);
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.SelectedText = "";
            cmbCategoria.Size = new Size(286, 44);
            cmbCategoria.TabIndex = 67;
            cmbCategoria.ValueMember = "";
            cmbCategoria.Leave += cmbCategoria_Leave;
            // 
            // ucBotonPrimario1
            // 
            ucBotonPrimario1.AccessibleName = "btnVolver";
            ucBotonPrimario1.BackColor = Color.FromArgb(13, 110, 253);
            ucBotonPrimario1.FlatAppearance.BorderSize = 0;
            ucBotonPrimario1.FlatStyle = FlatStyle.Flat;
            ucBotonPrimario1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonPrimario1.ForeColor = Color.White;
            ucBotonPrimario1.Location = new Point(794, 541);
            ucBotonPrimario1.Name = "ucBotonPrimario1";
            ucBotonPrimario1.Size = new Size(188, 50);
            ucBotonPrimario1.TabIndex = 93;
            ucBotonPrimario1.Text = "Volver";
            ucBotonPrimario1.UseVisualStyleBackColor = false;
            ucBotonPrimario1.Click += ucBotonPrimario1_Click;
            // 
            // FormProductoAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 761);
            Controls.Add(ucBotonPrimario1);
            Controls.Add(cmbCategoria);
            Controls.Add(errorProveedor);
            Controls.Add(errorGuardar);
            Controls.Add(botonGuardar);
            Controls.Add(errorCategoria);
            Controls.Add(errorPrecio);
            Controls.Add(ucTexto5);
            Controls.Add(txtPrecio);
            Controls.Add(ucTexto4);
            Controls.Add(ucTexto3);
            Controls.Add(cmbProveedor);
            Controls.Add(errorStock);
            Controls.Add(txtStock);
            Controls.Add(ucTexto1);
            Controls.Add(errorNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(ucTitulo1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProductoAlta";
            Text = "FormAltaProducto";
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucTitulo ucTitulo1;
        private Controles.ucTexto lblNombre;
        private Controles.ucTextBox txtNombre;
        private Controles.ucLabelError errorNombre;
        private Controles.ucTexto ucTexto1;
        private Controles.ucTextBox txtStock;
        private Controles.ucLabelError errorStock;
        private Controles.ucComboBox cmbProveedor;
        private Controles.ucTexto ucTexto3;
        private Controles.ucTexto ucTexto4;
        private Controles.ucTextBox txtPrecio;
        private Controles.ucTexto ucTexto5;
        private Controles.ucLabelError errorPrecio;
        private Controles.ucLabelError errorCategoria;
        private Controles.ucBotonAceptar botonGuardar;
        private Controles.ucLabelError errorGuardar;
        private Controles.ucLabelError errorProveedor;
        private Controles.ucComboBox cmbCategoria;
        private Controles.ucBotonPrimario ucBotonPrimario1;
    }
}