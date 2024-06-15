namespace Grupo3.Presentacion
{
    partial class FormProductoLista
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
            BotonBuscar = new Controles.ucBotonPrimario();
            dgvProducto = new DataGridView();
            botonAgregar = new Controles.ucBotonAceptar();
            cmbCategoria = new Controles.ucComboBox();
            ucTexto1 = new Controles.ucTexto();
            botonModificar = new Controles.ucBotonPrimario();
            botonBaja = new Controles.ucBotonCancelar();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(90, 40);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(545, 51);
            ucTitulo1.TabIndex = 46;
            ucTitulo1.TitleText = "Lista de Productos";
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.FromArgb(13, 110, 253);
            BotonBuscar.FlatAppearance.BorderSize = 0;
            BotonBuscar.FlatStyle = FlatStyle.Flat;
            BotonBuscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BotonBuscar.ForeColor = Color.White;
            BotonBuscar.Location = new Point(560, 165);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(171, 53);
            BotonBuscar.TabIndex = 47;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.AllowUserToResizeRows = false;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(90, 253);
            dgvProducto.MultiSelect = false;
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowTemplate.Height = 29;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(850, 300);
            dgvProducto.TabIndex = 48;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            // 
            // botonAgregar
            // 
            botonAgregar.BackColor = Color.FromArgb(25, 135, 84);
            botonAgregar.FlatAppearance.BorderSize = 0;
            botonAgregar.FlatStyle = FlatStyle.Flat;
            botonAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botonAgregar.ForeColor = Color.White;
            botonAgregar.Location = new Point(90, 587);
            botonAgregar.Margin = new Padding(3, 4, 3, 4);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(171, 53);
            botonAgregar.TabIndex = 49;
            botonAgregar.Text = "Alta Producto";
            botonAgregar.UseVisualStyleBackColor = false;
            botonAgregar.Click += botonAgregar_Click_1;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(222, 226, 230);
            cmbCategoria.DisplayMember = "";
            cmbCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategoria.Location = new Point(90, 165);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.MinimumSize = new Size(286, 44);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Padding = new Padding(2, 3, 2, 3);
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.SelectedText = "";
            cmbCategoria.Size = new Size(286, 44);
            cmbCategoria.TabIndex = 50;
            cmbCategoria.ValueMember = "";
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(90, 129);
            ucTexto1.Margin = new Padding(3, 5, 3, 5);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(193, 28);
            ucTexto1.TabIndex = 51;
            ucTexto1.TitleText = "Categoria";
            // 
            // botonModificar
            // 
            botonModificar.BackColor = Color.FromArgb(13, 110, 253);
            botonModificar.FlatAppearance.BorderSize = 0;
            botonModificar.FlatStyle = FlatStyle.Flat;
            botonModificar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botonModificar.ForeColor = Color.White;
            botonModificar.Location = new Point(336, 587);
            botonModificar.Margin = new Padding(3, 4, 3, 4);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(171, 53);
            botonModificar.TabIndex = 53;
            botonModificar.Text = "Modificar Producto";
            botonModificar.UseVisualStyleBackColor = false;
            botonModificar.Click += botonModificar_Click;
            // 
            // botonBaja
            // 
            botonBaja.BackColor = Color.FromArgb(220, 53, 69);
            botonBaja.FlatAppearance.BorderSize = 0;
            botonBaja.FlatStyle = FlatStyle.Flat;
            botonBaja.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botonBaja.ForeColor = Color.White;
            botonBaja.Location = new Point(560, 587);
            botonBaja.Margin = new Padding(3, 4, 3, 4);
            botonBaja.Name = "botonBaja";
            botonBaja.Size = new Size(171, 53);
            botonBaja.TabIndex = 54;
            botonBaja.Text = "Baja Producto";
            botonBaja.UseVisualStyleBackColor = false;
            botonBaja.Click += botonBaja_Click;
            // 
            // FormProductoLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 761);
            Controls.Add(botonBaja);
            Controls.Add(botonModificar);
            Controls.Add(ucTexto1);
            Controls.Add(cmbCategoria);
            Controls.Add(botonAgregar);
            Controls.Add(dgvProducto);
            Controls.Add(BotonBuscar);
            Controls.Add(ucTitulo1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProductoLista";
            Text = "FormProductoLista";
            
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucTitulo ucTitulo1;
        private Controles.ucBotonPrimario BotonBuscar;
        private DataGridView dgvProducto;
        private Controles.ucBotonAceptar botonAgregar;
        private Controles.ucComboBox cmbCategoria;
        private Controles.ucTexto ucTexto1;
        private Controles.ucBotonPrimario botonModificar;
        private Controles.ucBotonCancelar botonBaja;
    }
}