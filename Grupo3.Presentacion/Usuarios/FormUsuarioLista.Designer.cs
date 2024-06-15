namespace Grupo3.Presentacion
{
    partial class FormUsuarioLista
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
            dgvUsuario = new DataGridView();
            ucBotonPrimario1 = new Controles.ucBotonPrimario();
            btnBajaUsuario = new Controles.ucBotonCancelar();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(79, 30);
            ucTitulo1.Margin = new Padding(3, 4, 3, 4);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(301, 48);
            ucTitulo1.TabIndex = 0;
            ucTitulo1.TitleText = "Lista de Usuarios";
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AllowUserToResizeRows = false;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(79, 95);
            dgvUsuario.Margin = new Padding(3, 2, 3, 2);
            dgvUsuario.MultiSelect = false;
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersWidth = 51;
            dgvUsuario.RowTemplate.Height = 29;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(666, 375);
            dgvUsuario.TabIndex = 1;
            // 
            // ucBotonPrimario1
            // 
            ucBotonPrimario1.BackColor = Color.FromArgb(25, 135, 84);
            ucBotonPrimario1.FlatAppearance.BorderSize = 0;
            ucBotonPrimario1.FlatStyle = FlatStyle.Flat;
            ucBotonPrimario1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonPrimario1.ForeColor = Color.White;
            ucBotonPrimario1.Location = new Point(79, 493);
            ucBotonPrimario1.Margin = new Padding(3, 2, 3, 2);
            ucBotonPrimario1.Name = "ucBotonPrimario1";
            ucBotonPrimario1.Size = new Size(164, 38);
            ucBotonPrimario1.TabIndex = 2;
            ucBotonPrimario1.Text = "Alta Usuario\r\n";
            ucBotonPrimario1.UseVisualStyleBackColor = false;
            ucBotonPrimario1.Click += ucBotonPrimario1_Click;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.BackColor = Color.FromArgb(220, 53, 69);
            btnBajaUsuario.FlatAppearance.BorderSize = 0;
            btnBajaUsuario.FlatStyle = FlatStyle.Flat;
            btnBajaUsuario.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBajaUsuario.ForeColor = Color.White;
            btnBajaUsuario.Location = new Point(276, 492);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(150, 40);
            btnBajaUsuario.TabIndex = 53;
            btnBajaUsuario.Text = "Baja Usuario";
            btnBajaUsuario.UseVisualStyleBackColor = false;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // FormUsuarioLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 571);
            Controls.Add(btnBajaUsuario);
            Controls.Add(ucBotonPrimario1);
            Controls.Add(dgvUsuario);
            Controls.Add(ucTitulo1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUsuarioLista";
            Text = "FormUsuarioLista";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controles.ucTitulo ucTitulo1;
        private DataGridView dgvUsuario;
        private Controles.ucBotonPrimario ucBotonPrimario1;
        private Controles.ucBotonCancelar btnBajaUsuario;
    }
}