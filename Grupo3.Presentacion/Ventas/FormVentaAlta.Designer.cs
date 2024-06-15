namespace Grupo3.Presentacion.Ventas
{
    partial class FormVentaAlta
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
            cmbCliente = new Controles.ucComboBox();
            ucTexto1 = new Controles.ucTexto();
            ucBotonPrimario1 = new Controles.ucBotonPrimario();
            btnGenerarComprobante = new Controles.ucBotonAceptar();
            errorCliente = new Controles.ucLabelError();
            errorGeneral = new Controles.ucLabelError();
            lblCliente = new Controles.ucTexto();
            pnlVenta = new Panel();
            errorCantidad = new Controles.ucLabelError();
            errorProducto = new Controles.ucLabelError();
            txtPrecioTotal = new Controles.ucTextBox();
            ucTexto5 = new Controles.ucTexto();
            dgvVentas = new DataGridView();
            txtPrecioUnitario = new Controles.ucTextBox();
            ucTexto4 = new Controles.ucTexto();
            ucBotonAceptar1 = new Controles.ucBotonAceptar();
            ucTexto3 = new Controles.ucTexto();
            ucTexto2 = new Controles.ucTexto();
            txtCantidad = new Controles.ucTextBox();
            cmbProducto = new Controles.ucComboBox();
            pnlVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(90, 40);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(545, 51);
            ucTitulo1.TabIndex = 0;
            ucTitulo1.TitleText = "Alta de Venta";
            // 
            // cmbCliente
            // 
            cmbCliente.BackColor = Color.FromArgb(222, 226, 230);
            cmbCliente.DisplayMember = "";
            cmbCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCliente.Location = new Point(90, 153);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.MinimumSize = new Size(286, 44);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Padding = new Padding(2, 3, 2, 3);
            cmbCliente.SelectedIndex = -1;
            cmbCliente.SelectedText = "";
            cmbCliente.Size = new Size(286, 44);
            cmbCliente.TabIndex = 1;
            cmbCliente.ValueMember = "";
            cmbCliente.OnSelectedIndexChanged += cmbCliente_OnSelectedIndexChanged;
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(90, 116);
            ucTexto1.Margin = new Padding(3, 5, 3, 5);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(193, 28);
            ucTexto1.TabIndex = 4;
            ucTexto1.TitleText = "Cliente";
            // 
            // ucBotonPrimario1
            // 
            ucBotonPrimario1.AccessibleName = "btnVolver";
            ucBotonPrimario1.BackColor = Color.FromArgb(220, 53, 69);
            ucBotonPrimario1.FlatAppearance.BorderSize = 0;
            ucBotonPrimario1.FlatStyle = FlatStyle.Flat;
            ucBotonPrimario1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonPrimario1.ForeColor = Color.White;
            ucBotonPrimario1.Location = new Point(786, 671);
            ucBotonPrimario1.Name = "ucBotonPrimario1";
            ucBotonPrimario1.Size = new Size(187, 51);
            ucBotonPrimario1.TabIndex = 92;
            ucBotonPrimario1.Text = "Cancelar";
            ucBotonPrimario1.UseVisualStyleBackColor = false;
            ucBotonPrimario1.Click += ucBotonPrimario1_Click;
            // 
            // btnGenerarComprobante
            // 
            btnGenerarComprobante.BackColor = Color.FromArgb(25, 135, 84);
            btnGenerarComprobante.FlatAppearance.BorderSize = 0;
            btnGenerarComprobante.FlatStyle = FlatStyle.Flat;
            btnGenerarComprobante.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarComprobante.ForeColor = Color.White;
            btnGenerarComprobante.Location = new Point(102, 671);
            btnGenerarComprobante.Margin = new Padding(3, 4, 3, 4);
            btnGenerarComprobante.Name = "btnGenerarComprobante";
            btnGenerarComprobante.Size = new Size(171, 53);
            btnGenerarComprobante.TabIndex = 98;
            btnGenerarComprobante.Text = "Vender y Generar comprobante";
            btnGenerarComprobante.UseVisualStyleBackColor = false;
            btnGenerarComprobante.Click += btnGenerarComprobante_Click;
            // 
            // errorCliente
            // 
            errorCliente.BackColor = Color.Transparent;
            errorCliente.Location = new Point(90, 205);
            errorCliente.Margin = new Padding(3, 5, 3, 5);
            errorCliente.Name = "errorCliente";
            errorCliente.Size = new Size(286, 21);
            errorCliente.TabIndex = 99;
            errorCliente.Visible = false;
            // 
            // errorGeneral
            // 
            errorGeneral.BackColor = Color.Transparent;
            errorGeneral.Location = new Point(21, 405);
            errorGeneral.Margin = new Padding(3, 5, 3, 5);
            errorGeneral.Name = "errorGeneral";
            errorGeneral.Size = new Size(286, 21);
            errorGeneral.TabIndex = 102;
            errorGeneral.Visible = false;
            // 
            // lblCliente
            // 
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Location = new Point(90, 153);
            lblCliente.Margin = new Padding(3, 5, 3, 5);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(826, 28);
            lblCliente.TabIndex = 103;
            lblCliente.TitleText = "label1";
            lblCliente.Visible = false;
            // 
            // pnlVenta
            // 
            pnlVenta.BackColor = Color.Transparent;
            pnlVenta.Controls.Add(errorCantidad);
            pnlVenta.Controls.Add(errorProducto);
            pnlVenta.Controls.Add(errorGeneral);
            pnlVenta.Controls.Add(txtPrecioTotal);
            pnlVenta.Controls.Add(ucTexto5);
            pnlVenta.Controls.Add(dgvVentas);
            pnlVenta.Controls.Add(txtPrecioUnitario);
            pnlVenta.Controls.Add(ucTexto4);
            pnlVenta.Controls.Add(ucBotonAceptar1);
            pnlVenta.Controls.Add(ucTexto3);
            pnlVenta.Controls.Add(ucTexto2);
            pnlVenta.Controls.Add(txtCantidad);
            pnlVenta.Controls.Add(cmbProducto);
            pnlVenta.Location = new Point(71, 235);
            pnlVenta.Margin = new Padding(3, 4, 3, 4);
            pnlVenta.Name = "pnlVenta";
            pnlVenta.Size = new Size(978, 429);
            pnlVenta.TabIndex = 104;
            // 
            // errorCantidad
            // 
            errorCantidad.BackColor = Color.Transparent;
            errorCantidad.Location = new Point(313, 95);
            errorCantidad.Margin = new Padding(3, 5, 3, 5);
            errorCantidad.Name = "errorCantidad";
            errorCantidad.Size = new Size(286, 21);
            errorCantidad.TabIndex = 113;
            errorCantidad.Visible = false;
            // 
            // errorProducto
            // 
            errorProducto.BackColor = Color.Transparent;
            errorProducto.Location = new Point(19, 93);
            errorProducto.Margin = new Padding(3, 5, 3, 5);
            errorProducto.Name = "errorProducto";
            errorProducto.Size = new Size(286, 21);
            errorProducto.TabIndex = 112;
            errorProducto.Visible = false;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.BackColor = SystemColors.Window;
            txtPrecioTotal.EsPassword = false;
            txtPrecioTotal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioTotal.ForeColor = Color.DimGray;
            txtPrecioTotal.Location = new Point(640, 41);
            txtPrecioTotal.Margin = new Padding(5, 4, 5, 4);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Padding = new Padding(11, 9, 11, 9);
            txtPrecioTotal.Size = new Size(154, 43);
            txtPrecioTotal.TabIndex = 111;
            txtPrecioTotal.TieneError = false;
            // 
            // ucTexto5
            // 
            ucTexto5.BackColor = Color.Transparent;
            ucTexto5.Location = new Point(640, 5);
            ucTexto5.Margin = new Padding(3, 5, 3, 5);
            ucTexto5.Name = "ucTexto5";
            ucTexto5.Size = new Size(193, 28);
            ucTexto5.TabIndex = 110;
            ucTexto5.TitleText = "Precio Total";
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(19, 125);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.Size = new Size(897, 272);
            dgvVentas.TabIndex = 109;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.BackColor = SystemColors.Window;
            txtPrecioUnitario.EsPassword = false;
            txtPrecioUnitario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioUnitario.ForeColor = Color.DimGray;
            txtPrecioUnitario.Location = new Point(477, 41);
            txtPrecioUnitario.Margin = new Padding(5, 4, 5, 4);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Padding = new Padding(11, 9, 11, 9);
            txtPrecioUnitario.Size = new Size(154, 43);
            txtPrecioUnitario.TabIndex = 108;
            txtPrecioUnitario.TieneError = false;
            // 
            // ucTexto4
            // 
            ucTexto4.BackColor = Color.Transparent;
            ucTexto4.Location = new Point(477, 5);
            ucTexto4.Margin = new Padding(3, 5, 3, 5);
            ucTexto4.Name = "ucTexto4";
            ucTexto4.Size = new Size(193, 28);
            ucTexto4.TabIndex = 107;
            ucTexto4.TitleText = "Precio Unitario";
            // 
            // ucBotonAceptar1
            // 
            ucBotonAceptar1.BackColor = Color.FromArgb(25, 135, 84);
            ucBotonAceptar1.FlatAppearance.BorderSize = 0;
            ucBotonAceptar1.FlatStyle = FlatStyle.Flat;
            ucBotonAceptar1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonAceptar1.ForeColor = Color.White;
            ucBotonAceptar1.Location = new Point(813, 41);
            ucBotonAceptar1.Margin = new Padding(3, 4, 3, 4);
            ucBotonAceptar1.Name = "ucBotonAceptar1";
            ucBotonAceptar1.Size = new Size(104, 53);
            ucBotonAceptar1.TabIndex = 106;
            ucBotonAceptar1.Text = "Agregar";
            ucBotonAceptar1.UseVisualStyleBackColor = false;
            ucBotonAceptar1.Click += ucBotonAceptar1_Click;
            // 
            // ucTexto3
            // 
            ucTexto3.BackColor = Color.Transparent;
            ucTexto3.Location = new Point(313, 5);
            ucTexto3.Margin = new Padding(3, 5, 3, 5);
            ucTexto3.Name = "ucTexto3";
            ucTexto3.Size = new Size(193, 28);
            ucTexto3.TabIndex = 105;
            ucTexto3.TitleText = "Cantidad";
            // 
            // ucTexto2
            // 
            ucTexto2.BackColor = Color.Transparent;
            ucTexto2.Location = new Point(21, 5);
            ucTexto2.Margin = new Padding(3, 5, 3, 5);
            ucTexto2.Name = "ucTexto2";
            ucTexto2.Size = new Size(193, 28);
            ucTexto2.TabIndex = 104;
            ucTexto2.TitleText = "Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.Window;
            txtCantidad.EsPassword = false;
            txtCantidad.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtCantidad.ForeColor = Color.DimGray;
            txtCantidad.Location = new Point(313, 40);
            txtCantidad.Margin = new Padding(5, 4, 5, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Padding = new Padding(11, 9, 11, 9);
            txtCantidad.Size = new Size(154, 43);
            txtCantidad.TabIndex = 103;
            txtCantidad.TieneError = false;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            txtCantidad.Leave += txtCantidad_Leave;
            // 
            // cmbProducto
            // 
            cmbProducto.BackColor = Color.FromArgb(222, 226, 230);
            cmbProducto.DisplayMember = "";
            cmbProducto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProducto.Location = new Point(19, 41);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.MinimumSize = new Size(286, 44);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Padding = new Padding(2, 3, 2, 3);
            cmbProducto.SelectedIndex = -1;
            cmbProducto.SelectedText = "";
            cmbProducto.Size = new Size(286, 44);
            cmbProducto.TabIndex = 102;
            cmbProducto.ValueMember = "";
            cmbProducto.OnSelectedIndexChanged += cmbProducto_OnSelectedIndexChanged;
            // 
            // FormVentaAlta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 761);
            Controls.Add(pnlVenta);
            Controls.Add(lblCliente);
            Controls.Add(errorCliente);
            Controls.Add(btnGenerarComprobante);
            Controls.Add(ucBotonPrimario1);
            Controls.Add(ucTexto1);
            Controls.Add(cmbCliente);
            Controls.Add(ucTitulo1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVentaAlta";
            Text = "FormVentaAlta";
            pnlVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucTitulo ucTitulo1;
        private Controles.ucComboBox cmbCliente;
        private Controles.ucTexto ucTexto1;
        private Controles.ucBotonPrimario ucBotonPrimario1;
        private Controles.ucBotonAceptar btnGenerarComprobante;
        private Controles.ucLabelError errorCliente;
        private Controles.ucLabelError errorGeneral;
        private Controles.ucTexto lblCliente;
        private Panel pnlVenta;
        private Controles.ucLabelError errorCantidad;
        private Controles.ucLabelError errorProducto;
        private Controles.ucTextBox txtPrecioTotal;
        private Controles.ucTexto ucTexto5;
        private DataGridView dgvVentas;
        private Controles.ucTextBox txtPrecioUnitario;
        private Controles.ucTexto ucTexto4;
        private Controles.ucBotonAceptar ucBotonAceptar1;
        private Controles.ucTexto ucTexto3;
        private Controles.ucTexto ucTexto2;
        private Controles.ucTextBox txtCantidad;
        private Controles.ucComboBox cmbProducto;
    }
}