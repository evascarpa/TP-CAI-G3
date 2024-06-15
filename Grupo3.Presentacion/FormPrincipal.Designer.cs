namespace Grupo3.Presentacion
{
    partial class FormPrincipal
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
            pnlContenedor = new Panel();
            pnlFormulario = new Panel();
            pictureBoxAlerta = new PictureBox();
            ucAvisoStock = new Controles.ucTitulo();
            ucTitulo1 = new Controles.ucTitulo();
            pnlMenu = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button8 = new Button();
            button1 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pnlTitulo = new Panel();
            btnRestaurar = new Button();
            btnMin = new Button();
            btnMax = new Button();
            btnCerrar = new Button();
            pnlContenedor.SuspendLayout();
            pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlerta).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = SystemColors.ActiveCaption;
            pnlContenedor.Controls.Add(pnlFormulario);
            pnlContenedor.Controls.Add(pnlMenu);
            pnlContenedor.Controls.Add(pnlTitulo);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Margin = new Padding(3, 4, 3, 4);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1486, 867);
            pnlContenedor.TabIndex = 0;
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = SystemColors.Control;
            pnlFormulario.Controls.Add(pictureBoxAlerta);
            pnlFormulario.Controls.Add(ucAvisoStock);
            pnlFormulario.Controls.Add(ucTitulo1);
            pnlFormulario.Dock = DockStyle.Fill;
            pnlFormulario.Location = new Point(286, 37);
            pnlFormulario.Margin = new Padding(3, 4, 3, 4);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(1200, 830);
            pnlFormulario.TabIndex = 2;
            // 
            // pictureBoxAlerta
            // 
            pictureBoxAlerta.Location = new Point(51, 339);
            pictureBoxAlerta.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAlerta.Name = "pictureBoxAlerta";
            pictureBoxAlerta.Size = new Size(92, 51);
            pictureBoxAlerta.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAlerta.TabIndex = 2;
            pictureBoxAlerta.TabStop = false;
            pictureBoxAlerta.Visible = false;
            // 
            // ucAvisoStock
            // 
            ucAvisoStock.BackColor = Color.FromArgb(242, 222, 223);
            ucAvisoStock.ForeColor = Color.FromArgb(170, 75, 74);
            ucAvisoStock.Location = new Point(149, 339);
            ucAvisoStock.Margin = new Padding(3, 5, 3, 5);
            ucAvisoStock.Name = "ucAvisoStock";
            ucAvisoStock.Size = new Size(751, 51);
            ucAvisoStock.TabIndex = 1;
            ucAvisoStock.TitleText = "";
            ucAvisoStock.Visible = false;
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(272, 105);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(545, 51);
            ucTitulo1.TabIndex = 0;
            ucTitulo1.TitleText = "Hola";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(112, 44, 249);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(button8);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Controls.Add(button7);
            pnlMenu.Controls.Add(button6);
            pnlMenu.Controls.Add(button5);
            pnlMenu.Controls.Add(button4);
            pnlMenu.Controls.Add(button3);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 37);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(286, 830);
            pnlMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Logo2;
            pictureBox1.Location = new Point(58, 365);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 185);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(1, 691);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 4);
            panel1.TabIndex = 9;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 26, 76);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(0, 712);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(286, 47);
            button8.TabIndex = 8;
            button8.Text = "Cambiar contraseña";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 26, 76);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 767);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(286, 47);
            button1.TabIndex = 7;
            button1.Text = "Cerrar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 26, 76);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(0, 312);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(286, 47);
            button7.TabIndex = 6;
            button7.Text = "Reportes";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 26, 76);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(0, 203);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(286, 47);
            button6.TabIndex = 5;
            button6.Text = "Ventas";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 26, 76);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(0, 148);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(286, 47);
            button5.TabIndex = 4;
            button5.Text = "Productos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 26, 76);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(-3, 257);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(286, 47);
            button4.TabIndex = 3;
            button4.Text = "Clientes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 26, 76);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(0, 93);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(286, 47);
            button3.TabIndex = 2;
            button3.Text = "Proveedores";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 26, 76);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 39);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(286, 47);
            button2.TabIndex = 1;
            button2.Text = "Usuarios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(44, 26, 76);
            pnlTitulo.Controls.Add(btnRestaurar);
            pnlTitulo.Controls.Add(btnMin);
            pnlTitulo.Controls.Add(btnMax);
            pnlTitulo.Controls.Add(btnCerrar);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Margin = new Padding(3, 4, 3, 4);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1486, 37);
            pnlTitulo.TabIndex = 0;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.ForeColor = Color.Black;
            btnRestaurar.Image = Resources.minimizartamano;
            btnRestaurar.Location = new Point(1418, 4);
            btnRestaurar.Margin = new Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(29, 31);
            btnRestaurar.TabIndex = 3;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.ForeColor = Color.Black;
            btnMin.Image = Resources.minimizar;
            btnMin.Location = new Point(1383, 4);
            btnMin.Margin = new Padding(3, 4, 3, 4);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(29, 31);
            btnMin.TabIndex = 2;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.ForeColor = Color.Black;
            btnMax.Image = Resources.maximizar1;
            btnMax.Location = new Point(1418, 4);
            btnMax.Margin = new Padding(3, 4, 3, 4);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(29, 31);
            btnMax.TabIndex = 1;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Image = Resources.cerrar;
            btnCerrar.Location = new Point(1454, 4);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 31);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 867);
            Controls.Add(pnlContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(743, 867);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            pnlContenedor.ResumeLayout(false);
            pnlFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlerta).EndInit();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitulo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContenedor;
        private Panel pnlFormulario;
        private Panel pnlMenu;
        private Panel pnlTitulo;
        private Button button2;
        private Button btnMin;
        private Button btnMax;
        private Button btnCerrar;
        private Button btnRestaurar;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button1;
        private Panel panel1;
        private Controles.ucTitulo ucTitulo1;
        private PictureBox pictureBox1;
        private Controles.ucTitulo ucAvisoStock;
        private PictureBox pictureBoxAlerta;
    }
}