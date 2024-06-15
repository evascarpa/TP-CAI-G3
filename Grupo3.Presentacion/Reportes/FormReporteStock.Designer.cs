namespace Grupo3.Presentacion.Reportes
{
    partial class FormReporteStock
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
            ucTitulo2 = new Controles.ucTitulo();
            btnVolver = new Controles.ucBotonAceptar();
            dgvReporteStockCritico = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReporteStockCritico).BeginInit();
            SuspendLayout();
            // 
            // ucTitulo2
            // 
            ucTitulo2.Location = new Point(79, 30);
            ucTitulo2.Margin = new Padding(3, 4, 3, 4);
            ucTitulo2.Name = "ucTitulo2";
            ucTitulo2.Size = new Size(596, 35);
            ucTitulo2.TabIndex = 125;
            ucTitulo2.TitleText = "Reportes de Gestión - Stock Critico";
            ucTitulo2.Load += ucTitulo2_Load;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Blue;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(697, 82);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(164, 38);
            btnVolver.TabIndex = 126;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += ucBotonVentasPorVendedor_Click;
            // 
            // dgvReporteStockCritico
            // 
            dgvReporteStockCritico.AllowUserToAddRows = false;
            dgvReporteStockCritico.AllowUserToDeleteRows = false;
            dgvReporteStockCritico.AllowUserToResizeRows = false;
            dgvReporteStockCritico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteStockCritico.Location = new Point(88, 153);
            dgvReporteStockCritico.Margin = new Padding(3, 2, 3, 2);
            dgvReporteStockCritico.MultiSelect = false;
            dgvReporteStockCritico.Name = "dgvReporteStockCritico";
            dgvReporteStockCritico.ReadOnly = true;
            dgvReporteStockCritico.RowHeadersWidth = 51;
            dgvReporteStockCritico.RowTemplate.Height = 29;
            dgvReporteStockCritico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteStockCritico.Size = new Size(773, 374);
            dgvReporteStockCritico.TabIndex = 127;
            // 
            // FormReporteStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 587);
            Controls.Add(dgvReporteStockCritico);
            Controls.Add(btnVolver);
            Controls.Add(ucTitulo2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormReporteStock";
            Text = "FormReportesAcceso";
            ((System.ComponentModel.ISupportInitialize)dgvReporteStockCritico).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Controles.ucTitulo ucTitulo2;
        private Controles.ucBotonAceptar btnVolver;
        private DataGridView dgvReporteStockCritico;
    }
}