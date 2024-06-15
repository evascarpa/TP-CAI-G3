namespace Grupo3.Presentacion.Proveedores
{
    partial class FormProveedoresLista
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
            dgvProveedores = new DataGridView();
            botonAgregar = new Controles.ucBotonPrimario();
            ucTitulo1 = new Controles.ucTitulo();
            btnBajaCliente = new Controles.ucBotonCancelar();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.AllowUserToResizeRows = false;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(79, 95);
            dgvProveedores.Margin = new Padding(3, 2, 3, 2);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.RowTemplate.Height = 29;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(744, 375);
            dgvProveedores.TabIndex = 49;
            dgvProveedores.CellContentClick += dgvProovedores_CellContentClick;
            // 
            // botonAgregar
            // 
            botonAgregar.BackColor = Color.FromArgb(25, 135, 84);
            botonAgregar.FlatAppearance.BorderSize = 0;
            botonAgregar.FlatStyle = FlatStyle.Flat;
            botonAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botonAgregar.ForeColor = Color.White;
            botonAgregar.Location = new Point(79, 498);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(150, 40);
            botonAgregar.TabIndex = 50;
            botonAgregar.Text = "Alta Proveedor";
            botonAgregar.UseVisualStyleBackColor = false;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(79, 30);
            ucTitulo1.Margin = new Padding(3, 4, 3, 4);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(334, 38);
            ucTitulo1.TabIndex = 51;
            ucTitulo1.TitleText = "Lista de Proveedores";
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.BackColor = Color.FromArgb(220, 53, 69);
            btnBajaCliente.FlatAppearance.BorderSize = 0;
            btnBajaCliente.FlatStyle = FlatStyle.Flat;
            btnBajaCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBajaCliente.ForeColor = Color.White;
            btnBajaCliente.Location = new Point(276, 498);
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(150, 40);
            btnBajaCliente.TabIndex = 52;
            btnBajaCliente.Text = "Baja Proveedor";
            btnBajaCliente.UseVisualStyleBackColor = false;
            btnBajaCliente.Click += btnBajaCliente_Click;
            // 
            // FormProveedoresLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 571);
            Controls.Add(btnBajaCliente);
            Controls.Add(ucTitulo1);
            Controls.Add(botonAgregar);
            Controls.Add(dgvProveedores);
            Name = "FormProveedoresLista";
            Text = "FormProveedoresLista";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProveedores;
        private Controles.ucBotonPrimario botonAgregar;
        private Controles.ucTitulo ucTitulo1;
        private Controles.ucBotonCancelar btnBajaCliente;
    }
}