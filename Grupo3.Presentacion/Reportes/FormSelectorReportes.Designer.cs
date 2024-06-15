namespace Grupo3.Presentacion.Reportes
{
    partial class FormSelectorReportes
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
            btnVentasPorVendedor = new Controles.ucBotonAceptar();
            btnVendidosPorCategoria = new Controles.ucBotonAceptar();
            btnStockCritico = new Controles.ucBotonAceptar();
            SuspendLayout();
            // 
            // ucTitulo2
            // 
            ucTitulo2.Location = new Point(330, 29);
            ucTitulo2.Margin = new Padding(3, 4, 3, 4);
            ucTitulo2.Name = "ucTitulo2";
            ucTitulo2.Size = new Size(307, 35);
            ucTitulo2.TabIndex = 126;
            ucTitulo2.TitleText = "Reportes de Gestión";
            // 
            // btnVentasPorVendedor
            // 
            btnVentasPorVendedor.BackColor = Color.FromArgb(25, 135, 84);
            btnVentasPorVendedor.FlatAppearance.BorderSize = 0;
            btnVentasPorVendedor.FlatStyle = FlatStyle.Flat;
            btnVentasPorVendedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentasPorVendedor.ForeColor = Color.White;
            btnVentasPorVendedor.Location = new Point(390, 213);
            btnVentasPorVendedor.Margin = new Padding(3, 2, 3, 2);
            btnVentasPorVendedor.Name = "btnVentasPorVendedor";
            btnVentasPorVendedor.Size = new Size(164, 38);
            btnVentasPorVendedor.TabIndex = 129;
            btnVentasPorVendedor.Text = "Ventas por vendedor";
            btnVentasPorVendedor.UseVisualStyleBackColor = false;
            btnVentasPorVendedor.Click += ucBotonVentasPorVendedor_Click;
            // 
            // btnVendidosPorCategoria
            // 
            btnVendidosPorCategoria.BackColor = Color.FromArgb(25, 135, 84);
            btnVendidosPorCategoria.FlatAppearance.BorderSize = 0;
            btnVendidosPorCategoria.FlatStyle = FlatStyle.Flat;
            btnVendidosPorCategoria.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVendidosPorCategoria.ForeColor = Color.White;
            btnVendidosPorCategoria.Location = new Point(390, 302);
            btnVendidosPorCategoria.Margin = new Padding(3, 2, 3, 2);
            btnVendidosPorCategoria.Name = "btnVendidosPorCategoria";
            btnVendidosPorCategoria.Size = new Size(164, 50);
            btnVendidosPorCategoria.TabIndex = 128;
            btnVendidosPorCategoria.Text = "Productos más vendidos por categoria";
            btnVendidosPorCategoria.UseVisualStyleBackColor = false;
            btnVendidosPorCategoria.Click += ucBotonProdMasVendidos_Click;
            // 
            // btnStockCritico
            // 
            btnStockCritico.AutoSize = true;
            btnStockCritico.BackColor = Color.FromArgb(25, 135, 84);
            btnStockCritico.FlatAppearance.BorderSize = 0;
            btnStockCritico.FlatStyle = FlatStyle.Flat;
            btnStockCritico.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnStockCritico.ForeColor = Color.White;
            btnStockCritico.Location = new Point(390, 125);
            btnStockCritico.Margin = new Padding(3, 2, 3, 2);
            btnStockCritico.Name = "btnStockCritico";
            btnStockCritico.Size = new Size(164, 38);
            btnStockCritico.TabIndex = 127;
            btnStockCritico.Text = "Stock Critico";
            btnStockCritico.UseVisualStyleBackColor = false;
            btnStockCritico.Click += ucBotonStockCritico_Click;
            // 
            // FormSelectorReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVentasPorVendedor);
            Controls.Add(btnVendidosPorCategoria);
            Controls.Add(btnStockCritico);
            Controls.Add(ucTitulo2);
            Name = "FormSelectorReportes";
            Text = "SeletorReportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controles.ucTitulo ucTitulo2;
        private Controles.ucBotonAceptar btnVentasPorVendedor;
        private Controles.ucBotonAceptar btnVendidosPorCategoria;
        private Controles.ucBotonAceptar btnStockCritico;
    }
}