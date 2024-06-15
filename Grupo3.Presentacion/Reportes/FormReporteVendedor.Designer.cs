namespace Grupo3.Presentacion.Reportes
{
    partial class FormReporteVendedor
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
            dgvReporteVentasPorVendedor = new DataGridView();
            btnVolver = new Controles.ucBotonAceptar();
            ucTitulo2 = new Controles.ucTitulo();
            btnGenerarDGV = new Controles.ucBotonAceptar();
            cmbVendedores = new Controles.ucComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentasPorVendedor).BeginInit();
            SuspendLayout();
            // 
            // dgvReporteVentasPorVendedor
            // 
            dgvReporteVentasPorVendedor.AllowUserToAddRows = false;
            dgvReporteVentasPorVendedor.AllowUserToDeleteRows = false;
            dgvReporteVentasPorVendedor.AllowUserToResizeRows = false;
            dgvReporteVentasPorVendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteVentasPorVendedor.Location = new Point(135, 189);
            dgvReporteVentasPorVendedor.Margin = new Padding(3, 2, 3, 2);
            dgvReporteVentasPorVendedor.MultiSelect = false;
            dgvReporteVentasPorVendedor.Name = "dgvReporteVentasPorVendedor";
            dgvReporteVentasPorVendedor.ReadOnly = true;
            dgvReporteVentasPorVendedor.RowHeadersWidth = 51;
            dgvReporteVentasPorVendedor.RowTemplate.Height = 29;
            dgvReporteVentasPorVendedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteVentasPorVendedor.Size = new Size(773, 374);
            dgvReporteVentasPorVendedor.TabIndex = 131;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Blue;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(744, 97);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(164, 38);
            btnVolver.TabIndex = 130;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ucTitulo2
            // 
            ucTitulo2.Location = new Point(126, 45);
            ucTitulo2.Margin = new Padding(3, 4, 3, 4);
            ucTitulo2.Name = "ucTitulo2";
            ucTitulo2.Size = new Size(652, 35);
            ucTitulo2.TabIndex = 129;
            ucTitulo2.TitleText = "Reportes de Gestión - Ventas Por Vendedor";
            ucTitulo2.Load += ucTitulo2_Load;
            // 
            // btnGenerarDGV
            // 
            btnGenerarDGV.AutoSize = true;
            btnGenerarDGV.BackColor = Color.FromArgb(25, 135, 84);
            btnGenerarDGV.FlatAppearance.BorderSize = 0;
            btnGenerarDGV.FlatStyle = FlatStyle.Flat;
            btnGenerarDGV.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarDGV.ForeColor = Color.White;
            btnGenerarDGV.Location = new Point(135, 97);
            btnGenerarDGV.Margin = new Padding(3, 2, 3, 2);
            btnGenerarDGV.Name = "btnGenerarDGV";
            btnGenerarDGV.Size = new Size(164, 38);
            btnGenerarDGV.TabIndex = 128;
            btnGenerarDGV.Text = "Generar";
            btnGenerarDGV.UseVisualStyleBackColor = false;
            btnGenerarDGV.Click += ucBotonStockCritico_Click_1;
            // 
            // cmbVendedores
            // 
            cmbVendedores.BackColor = Color.FromArgb(222, 226, 230);
            cmbVendedores.DisplayMember = "";
            cmbVendedores.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVendedores.Location = new Point(135, 151);
            cmbVendedores.MinimumSize = new Size(250, 33);
            cmbVendedores.Name = "cmbVendedores";
            cmbVendedores.Padding = new Padding(2);
            cmbVendedores.SelectedIndex = -1;
            cmbVendedores.SelectedText = "";
            cmbVendedores.Size = new Size(250, 33);
            cmbVendedores.TabIndex = 132;
            cmbVendedores.ValueMember = "";
            // 
            // FormReporteVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 587);
            Controls.Add(cmbVendedores);
            Controls.Add(dgvReporteVentasPorVendedor);
            Controls.Add(btnVolver);
            Controls.Add(ucTitulo2);
            Controls.Add(btnGenerarDGV);
            Name = "FormReporteVendedor";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvReporteVentasPorVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReporteVentasPorVendedor;
        private Controles.ucBotonAceptar btnVolver;
        private Controles.ucTitulo ucTitulo2;
        private Controles.ucBotonAceptar btnGenerarDGV;
        private Controles.ucComboBox cmbVendedores;
    }
}