namespace Grupo3.Presentacion
{
    partial class FormClienteLista
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
            ucBotonCrearCliente = new Controles.ucBotonPrimario();
            dgvLista = new DataGridView();
            ucTitulo1 = new Controles.ucTitulo();
            btnBajaCliente = new Controles.ucBotonCancelar();
            btnEditarCliente = new Controles.ucBotonAceptar();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // ucBotonCrearCliente
            // 
            ucBotonCrearCliente.BackColor = Color.FromArgb(25, 135, 84);
            ucBotonCrearCliente.FlatAppearance.BorderSize = 0;
            ucBotonCrearCliente.FlatStyle = FlatStyle.Flat;
            ucBotonCrearCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonCrearCliente.ForeColor = Color.White;
            ucBotonCrearCliente.Location = new Point(90, 667);
            ucBotonCrearCliente.Name = "ucBotonCrearCliente";
            ucBotonCrearCliente.Size = new Size(187, 51);
            ucBotonCrearCliente.TabIndex = 5;
            ucBotonCrearCliente.Text = "Alta Cliente";
            ucBotonCrearCliente.UseVisualStyleBackColor = false;
            ucBotonCrearCliente.Click += ucBotonPrimario1_Click;
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AllowUserToResizeRows = false;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(90, 127);
            dgvLista.MultiSelect = false;
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersWidth = 51;
            dgvLista.RowTemplate.Height = 29;
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(850, 500);
            dgvLista.TabIndex = 4;
            dgvLista.CellClick += dataGridView1_CellContentClick;
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(90, 40);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(344, 64);
            ucTitulo1.TabIndex = 3;
            ucTitulo1.TitleText = "Lista de Clientes";
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.BackColor = Color.FromArgb(220, 53, 69);
            btnBajaCliente.FlatAppearance.BorderSize = 0;
            btnBajaCliente.FlatStyle = FlatStyle.Flat;
            btnBajaCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBajaCliente.ForeColor = Color.White;
            btnBajaCliente.Location = new Point(570, 667);
            btnBajaCliente.Margin = new Padding(3, 4, 3, 4);
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(171, 53);
            btnBajaCliente.TabIndex = 8;
            btnBajaCliente.Text = "Baja Cliente";
            btnBajaCliente.UseVisualStyleBackColor = false;
            btnBajaCliente.Click += btnBajaCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.BackColor = Color.FromArgb(13, 110, 253);
            btnEditarCliente.FlatAppearance.BorderSize = 0;
            btnEditarCliente.FlatStyle = FlatStyle.Flat;
            btnEditarCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarCliente.ForeColor = Color.White;
            btnEditarCliente.Location = new Point(338, 667);
            btnEditarCliente.Margin = new Padding(3, 4, 3, 4);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(171, 53);
            btnEditarCliente.TabIndex = 7;
            btnEditarCliente.Text = "Modificar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // FormClienteLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 761);
            Controls.Add(btnBajaCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(ucBotonCrearCliente);
            Controls.Add(dgvLista);
            Controls.Add(ucTitulo1);
            Name = "FormClienteLista";
            Text = "FormClienteLista";
            Load += FormClienteLista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucBotonPrimario ucBotonCrearCliente;
        private DataGridView dgvLista;
        private Controles.ucTitulo ucTitulo1;
        private Controles.ucBotonCancelar btnBajaCliente;
        private Controles.ucBotonAceptar btnEditarCliente;
    }
}