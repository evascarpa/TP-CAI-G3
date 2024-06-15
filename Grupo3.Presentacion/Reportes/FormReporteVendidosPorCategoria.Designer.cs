namespace Grupo3.Presentacion.Reportes
{
    partial class FormReporteVendidosPorCategoria
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
            cmbCategoria = new Controles.ucComboBox();
            dgvReporteProdVendidosPorCategoria = new DataGridView();
            btnVolver = new Controles.ucBotonAceptar();
            ucTitulo2 = new Controles.ucTitulo();
            btnGenerarDGV = new Controles.ucBotonAceptar();
            ((System.ComponentModel.ISupportInitialize)dgvReporteProdVendidosPorCategoria).BeginInit();
            SuspendLayout();
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(222, 226, 230);
            cmbCategoria.DisplayMember = "";
            cmbCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategoria.Location = new Point(135, 140);
            cmbCategoria.MinimumSize = new Size(250, 33);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Padding = new Padding(2);
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.SelectedText = "";
            cmbCategoria.Size = new Size(250, 33);
            cmbCategoria.TabIndex = 137;
            cmbCategoria.ValueMember = "";
            cmbCategoria.Load += cmbCategorias_Load;
            // 
            // dgvReporteProdVendidosPorCategoria
            // 
            dgvReporteProdVendidosPorCategoria.AllowUserToAddRows = false;
            dgvReporteProdVendidosPorCategoria.AllowUserToDeleteRows = false;
            dgvReporteProdVendidosPorCategoria.AllowUserToResizeRows = false;
            dgvReporteProdVendidosPorCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteProdVendidosPorCategoria.Location = new Point(135, 178);
            dgvReporteProdVendidosPorCategoria.Margin = new Padding(3, 2, 3, 2);
            dgvReporteProdVendidosPorCategoria.MultiSelect = false;
            dgvReporteProdVendidosPorCategoria.Name = "dgvReporteProdVendidosPorCategoria";
            dgvReporteProdVendidosPorCategoria.ReadOnly = true;
            dgvReporteProdVendidosPorCategoria.RowHeadersWidth = 51;
            dgvReporteProdVendidosPorCategoria.RowTemplate.Height = 29;
            dgvReporteProdVendidosPorCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteProdVendidosPorCategoria.Size = new Size(773, 374);
            dgvReporteProdVendidosPorCategoria.TabIndex = 136;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Blue;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(744, 86);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(164, 38);
            btnVolver.TabIndex = 135;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ucTitulo2
            // 
            ucTitulo2.Location = new Point(126, 34);
            ucTitulo2.Margin = new Padding(3, 4, 3, 4);
            ucTitulo2.Name = "ucTitulo2";
            ucTitulo2.Size = new Size(859, 35);
            ucTitulo2.TabIndex = 134;
            ucTitulo2.TitleText = "Reportes de Gestión - Productos Vendidos Por Categoria";
            // 
            // btnGenerarDGV
            // 
            btnGenerarDGV.AutoSize = true;
            btnGenerarDGV.BackColor = Color.FromArgb(25, 135, 84);
            btnGenerarDGV.FlatAppearance.BorderSize = 0;
            btnGenerarDGV.FlatStyle = FlatStyle.Flat;
            btnGenerarDGV.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarDGV.ForeColor = Color.White;
            btnGenerarDGV.Location = new Point(135, 86);
            btnGenerarDGV.Margin = new Padding(3, 2, 3, 2);
            btnGenerarDGV.Name = "btnGenerarDGV";
            btnGenerarDGV.Size = new Size(164, 38);
            btnGenerarDGV.TabIndex = 133;
            btnGenerarDGV.Text = "Generar";
            btnGenerarDGV.UseVisualStyleBackColor = false;
            // 
            // FormReporteVendidosPorCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 587);
            Controls.Add(cmbCategoria);
            Controls.Add(dgvReporteProdVendidosPorCategoria);
            Controls.Add(btnVolver);
            Controls.Add(ucTitulo2);
            Controls.Add(btnGenerarDGV);
            Name = "FormReporteVendidosPorCategoria";
            Text = "FormReporteVendidosPorCategoria";
            ((System.ComponentModel.ISupportInitialize)dgvReporteProdVendidosPorCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controles.ucComboBox cmbCategoria;
        private DataGridView dgvReporteProdVendidosPorCategoria;
        private Controles.ucBotonAceptar btnVolver;
        private Controles.ucTitulo ucTitulo2;
        private Controles.ucBotonAceptar btnGenerarDGV;
    }
}