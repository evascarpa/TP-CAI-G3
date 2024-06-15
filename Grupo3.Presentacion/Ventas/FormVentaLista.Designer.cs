namespace Grupo3.Presentacion.Ventas
{
    partial class FormVentaLista
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
            ucTexto1 = new Controles.ucTexto();
            cmbCliente = new Controles.ucComboBox();
            btnBuscar = new Controles.ucBotonPrimario();
            dgvVentas = new DataGridView();
            btnAlta = new Controles.ucBotonAceptar();
            btnBaja = new Controles.ucBotonCancelar();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(79, 30);
            ucTitulo1.Margin = new Padding(3, 4, 3, 4);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(477, 38);
            ucTitulo1.TabIndex = 0;
            ucTitulo1.TitleText = "Venta por cliente";
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(79, 97);
            ucTexto1.Margin = new Padding(3, 4, 3, 4);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(169, 21);
            ucTexto1.TabIndex = 1;
            ucTexto1.TitleText = "Clientes";
            // 
            // cmbCliente
            // 
            cmbCliente.BackColor = Color.FromArgb(222, 226, 230);
            cmbCliente.DisplayMember = "";
            cmbCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCliente.Location = new Point(79, 124);
            cmbCliente.MinimumSize = new Size(250, 33);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Padding = new Padding(2, 2, 2, 2);
            cmbCliente.SelectedIndex = -1;
            cmbCliente.SelectedText = "";
            cmbCliente.Size = new Size(250, 33);
            cmbCliente.TabIndex = 2;
            cmbCliente.ValueMember = "";
            cmbCliente.Load += cmbCliente_Load;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(13, 110, 253);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(490, 118);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 40);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(79, 180);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(744, 225);
            dgvVentas.TabIndex = 4;
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.FromArgb(25, 135, 84);
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlta.ForeColor = Color.White;
            btnAlta.Location = new Point(79, 439);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(150, 40);
            btnAlta.TabIndex = 5;
            btnAlta.Text = "Alta Venta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(220, 53, 69);
            btnBaja.FlatAppearance.BorderSize = 0;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaja.ForeColor = Color.White;
            btnBaja.Location = new Point(281, 439);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(150, 40);
            btnBaja.TabIndex = 6;
            btnBaja.Text = "Baja Venta";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += btnBaja_Click;
            // 
            // FormVentaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 571);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(dgvVentas);
            Controls.Add(btnBuscar);
            Controls.Add(cmbCliente);
            Controls.Add(ucTexto1);
            Controls.Add(ucTitulo1);
            Name = "FormVentaLista";
            Text = "FormVentaLista";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucTitulo ucTitulo1;
        private Controles.ucTexto ucTexto1;
        private Controles.ucComboBox cmbCliente;
        private Controles.ucBotonPrimario btnBuscar;
        private DataGridView dgvVentas;
        private Controles.ucBotonAceptar btnAlta;
        private Controles.ucBotonCancelar btnBaja;
    }
}