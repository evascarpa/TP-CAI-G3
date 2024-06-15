namespace Grupo3.Presentacion
{
    partial class FormProductoEditar
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
            ucTexto1 = new Controles.ucTexto();
            txtPrecio = new Controles.ucTextBox();
            txtCantidad = new Controles.ucTextBox();
            ucTexto2 = new Controles.ucTexto();
            ucTexto3 = new Controles.ucTexto();
            errorPrecio = new Controles.ucLabelError();
            errorStock = new Controles.ucLabelError();
            botonEditar = new Controles.ucBotonAceptar();
            errorEditar = new Controles.ucLabelError();
            txtId = new Controles.ucTexto();
            txtNombre = new Controles.ucTexto();
            ucBotonPrimario1 = new Controles.ucBotonPrimario();
            SuspendLayout();
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(90, 40);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(545, 51);
            ucTitulo1.TabIndex = 46;
            ucTitulo1.TitleText = "Editar Producto";
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(101, 132);
            lblNombre.Margin = new Padding(3, 5, 3, 5);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(193, 28);
            lblNombre.TabIndex = 47;
            lblNombre.TitleText = "Id Producto";
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(550, 132);
            ucTexto1.Margin = new Padding(3, 5, 3, 5);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(193, 28);
            ucTexto1.TabIndex = 50;
            ucTexto1.TitleText = "Nombre";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Window;
            txtPrecio.EsPassword = false;
            txtPrecio.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = Color.DimGray;
            txtPrecio.Location = new Point(101, 285);
            txtPrecio.Margin = new Padding(5, 4, 5, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Padding = new Padding(8, 9, 8, 9);
            txtPrecio.Size = new Size(286, 39);
            txtPrecio.TabIndex = 55;
            txtPrecio.TieneError = false;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            txtPrecio.Leave += txtPrecio_Leave;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.Window;
            txtCantidad.EsPassword = false;
            txtCantidad.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.ForeColor = Color.DimGray;
            txtCantidad.Location = new Point(101, 420);
            txtCantidad.Margin = new Padding(5, 4, 5, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Padding = new Padding(8, 9, 8, 9);
            txtCantidad.Size = new Size(286, 39);
            txtCantidad.TabIndex = 56;
            txtCantidad.TieneError = false;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            txtCantidad.Leave += txtCantidad_Leave;
            // 
            // ucTexto2
            // 
            ucTexto2.BackColor = Color.Transparent;
            ucTexto2.Location = new Point(101, 259);
            ucTexto2.Margin = new Padding(3, 5, 3, 5);
            ucTexto2.Name = "ucTexto2";
            ucTexto2.Size = new Size(193, 28);
            ucTexto2.TabIndex = 57;
            ucTexto2.TitleText = "Precio";
            // 
            // ucTexto3
            // 
            ucTexto3.BackColor = Color.Transparent;
            ucTexto3.Location = new Point(101, 383);
            ucTexto3.Margin = new Padding(3, 5, 3, 5);
            ucTexto3.Name = "ucTexto3";
            ucTexto3.Size = new Size(193, 28);
            ucTexto3.TabIndex = 58;
            ucTexto3.TitleText = "Movimiento de Stock";
            // 
            // errorPrecio
            // 
            errorPrecio.BackColor = Color.Transparent;
            errorPrecio.Location = new Point(101, 333);
            errorPrecio.Margin = new Padding(3, 5, 3, 5);
            errorPrecio.Name = "errorPrecio";
            errorPrecio.Size = new Size(320, 21);
            errorPrecio.TabIndex = 59;
            errorPrecio.Visible = false;
            // 
            // errorStock
            // 
            errorStock.BackColor = Color.Transparent;
            errorStock.Location = new Point(101, 471);
            errorStock.Margin = new Padding(3, 5, 3, 5);
            errorStock.Name = "errorStock";
            errorStock.Size = new Size(320, 21);
            errorStock.TabIndex = 60;
            errorStock.Visible = false;
            // 
            // botonEditar
            // 
            botonEditar.BackColor = Color.FromArgb(25, 135, 84);
            botonEditar.FlatAppearance.BorderSize = 0;
            botonEditar.FlatStyle = FlatStyle.Flat;
            botonEditar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botonEditar.ForeColor = Color.White;
            botonEditar.Location = new Point(414, 536);
            botonEditar.Name = "botonEditar";
            botonEditar.Size = new Size(187, 53);
            botonEditar.TabIndex = 65;
            botonEditar.Text = "Editar";
            botonEditar.UseVisualStyleBackColor = false;
            botonEditar.Click += botonEditar_Click;
            // 
            // errorEditar
            // 
            errorEditar.BackColor = Color.Transparent;
            errorEditar.Location = new Point(414, 597);
            errorEditar.Margin = new Padding(3, 5, 3, 5);
            errorEditar.Name = "errorEditar";
            errorEditar.Size = new Size(320, 21);
            errorEditar.TabIndex = 66;
            errorEditar.Visible = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.Transparent;
            txtId.Location = new Point(101, 184);
            txtId.Margin = new Padding(3, 5, 3, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(355, 28);
            txtId.TabIndex = 67;
            txtId.TitleText = "Id Producto";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.Location = new Point(550, 184);
            txtNombre.Margin = new Padding(3, 5, 3, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(286, 28);
            txtNombre.TabIndex = 68;
            txtNombre.TitleText = "Nombre";
            // 
            // ucBotonPrimario1
            // 
            ucBotonPrimario1.AccessibleName = "btnVolver";
            ucBotonPrimario1.BackColor = Color.FromArgb(13, 110, 253);
            ucBotonPrimario1.FlatAppearance.BorderSize = 0;
            ucBotonPrimario1.FlatStyle = FlatStyle.Flat;
            ucBotonPrimario1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonPrimario1.ForeColor = Color.White;
            ucBotonPrimario1.Location = new Point(694, 536);
            ucBotonPrimario1.Name = "ucBotonPrimario1";
            ucBotonPrimario1.Size = new Size(188, 50);
            ucBotonPrimario1.TabIndex = 92;
            ucBotonPrimario1.Text = "Volver";
            ucBotonPrimario1.UseVisualStyleBackColor = false;
            ucBotonPrimario1.Click += ucBotonPrimario1_Click;
            // 
            // FormProductoEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 761);
            Controls.Add(ucBotonPrimario1);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(errorEditar);
            Controls.Add(botonEditar);
            Controls.Add(errorStock);
            Controls.Add(errorPrecio);
            Controls.Add(ucTexto3);
            Controls.Add(ucTexto2);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(ucTexto1);
            Controls.Add(lblNombre);
            Controls.Add(ucTitulo1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProductoEditar";
            Text = "FormProductoEditar";
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucTitulo ucTitulo1;
        private Controles.ucTexto lblNombre;
        private Controles.ucTexto ucTexto1;
        private Controles.ucTextBox txtPrecio;
        private Controles.ucTextBox txtCantidad;
        private Controles.ucTexto ucTexto2;
        private Controles.ucTexto ucTexto3;
        private Controles.ucLabelError errorPrecio;
        private Controles.ucLabelError errorStock;
        private Controles.ucBotonAceptar botonEditar;
        private Controles.ucLabelError errorEditar;
        private Controles.ucTexto txtId;
        private Controles.ucTexto txtNombre;
        private Controles.ucBotonPrimario ucBotonPrimario1;
    }
}