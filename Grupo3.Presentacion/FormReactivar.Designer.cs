namespace Grupo3.Presentacion
{
    partial class FormReactivar
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
            pnlTitulo = new Panel();
            btnMin = new Button();
            btnRestaurar = new Button();
            btnCerrar = new Button();
            pnlMenu = new Panel();
            pictureBox1 = new PictureBox();
            pnlFormulario = new Panel();
            errorContraseña2 = new Controles.ucLabelError();
            errorContraseña = new Controles.ucLabelError();
            errorConfirmar = new Controles.ucLabelError();
            errorActivar = new Controles.ucLabelError();
            ucBotonAceptar1 = new Controles.ucBotonAceptar();
            txtContraseña = new Controles.ucTextBox();
            txtConfirmar = new Controles.ucTextBox();
            ucTexto1 = new Controles.ucTexto();
            ucTexto2 = new Controles.ucTexto();
            ucTitulo1 = new Controles.ucTitulo();
            btnMax = new Button();
            pnlTitulo.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(44, 26, 76);
            pnlTitulo.Controls.Add(btnMax);
            pnlTitulo.Controls.Add(btnMin);
            pnlTitulo.Controls.Add(btnRestaurar);
            pnlTitulo.Controls.Add(btnCerrar);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1300, 28);
            pnlTitulo.TabIndex = 0;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.ForeColor = Color.Black;
            btnMin.Image = Resources.minimizar;
            btnMin.Location = new Point(1210, 3);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(25, 23);
            btnMin.TabIndex = 3;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.ForeColor = Color.Black;
            btnRestaurar.Image = Resources.minimizartamano;
            btnRestaurar.Location = new Point(1241, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 23);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Image = Resources.cerrar;
            btnCerrar.Location = new Point(1272, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 23);
            btnCerrar.TabIndex = 5;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(112, 44, 249);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 28);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 622);
            pnlMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.Logo2;
            pictureBox1.Location = new Point(51, 274);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 139);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pnlFormulario
            // 
            pnlFormulario.Controls.Add(errorContraseña2);
            pnlFormulario.Controls.Add(errorContraseña);
            pnlFormulario.Controls.Add(errorConfirmar);
            pnlFormulario.Controls.Add(errorActivar);
            pnlFormulario.Controls.Add(ucBotonAceptar1);
            pnlFormulario.Controls.Add(txtContraseña);
            pnlFormulario.Controls.Add(txtConfirmar);
            pnlFormulario.Controls.Add(ucTexto1);
            pnlFormulario.Controls.Add(ucTexto2);
            pnlFormulario.Controls.Add(ucTitulo1);
            pnlFormulario.Dock = DockStyle.Fill;
            pnlFormulario.Location = new Point(250, 28);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(1050, 622);
            pnlFormulario.TabIndex = 2;
            // 
            // errorContraseña2
            // 
            errorContraseña2.BackColor = Color.Transparent;
            errorContraseña2.Location = new Point(339, 235);
            errorContraseña2.Margin = new Padding(3, 4, 3, 4);
            errorContraseña2.Name = "errorContraseña2";
            errorContraseña2.Size = new Size(430, 16);
            errorContraseña2.TabIndex = 17;
            errorContraseña2.Visible = false;
            // 
            // errorContraseña
            // 
            errorContraseña.BackColor = Color.Transparent;
            errorContraseña.Location = new Point(339, 235);
            errorContraseña.Margin = new Padding(3, 4, 3, 4);
            errorContraseña.Name = "errorContraseña";
            errorContraseña.Size = new Size(430, 16);
            errorContraseña.TabIndex = 16;
            errorContraseña.Visible = false;
            // 
            // errorConfirmar
            // 
            errorConfirmar.BackColor = Color.Transparent;
            errorConfirmar.Location = new Point(339, 328);
            errorConfirmar.Margin = new Padding(3, 4, 3, 4);
            errorConfirmar.Name = "errorConfirmar";
            errorConfirmar.Size = new Size(430, 16);
            errorConfirmar.TabIndex = 15;
            errorConfirmar.Visible = false;
            // 
            // errorActivar
            // 
            errorActivar.BackColor = Color.Transparent;
            errorActivar.Location = new Point(339, 398);
            errorActivar.Margin = new Padding(3, 4, 3, 4);
            errorActivar.Name = "errorActivar";
            errorActivar.Size = new Size(430, 16);
            errorActivar.TabIndex = 14;
            errorActivar.Visible = false;
            // 
            // ucBotonAceptar1
            // 
            ucBotonAceptar1.BackColor = Color.FromArgb(25, 135, 84);
            ucBotonAceptar1.FlatAppearance.BorderSize = 0;
            ucBotonAceptar1.FlatStyle = FlatStyle.Flat;
            ucBotonAceptar1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonAceptar1.ForeColor = Color.White;
            ucBotonAceptar1.Location = new Point(339, 351);
            ucBotonAceptar1.Name = "ucBotonAceptar1";
            ucBotonAceptar1.Size = new Size(250, 40);
            ucBotonAceptar1.TabIndex = 13;
            ucBotonAceptar1.Text = "Activar";
            ucBotonAceptar1.UseVisualStyleBackColor = false;
            ucBotonAceptar1.Click += ucBotonAceptar1_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.Window;
            txtContraseña.EsPassword = true;
            txtContraseña.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.Location = new Point(339, 194);
            txtContraseña.Margin = new Padding(4, 3, 4, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Padding = new Padding(10, 7, 10, 7);
            txtContraseña.Size = new Size(250, 34);
            txtContraseña.TabIndex = 12;
            txtContraseña.TieneError = false;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // txtConfirmar
            // 
            txtConfirmar.BackColor = SystemColors.Window;
            txtConfirmar.EsPassword = true;
            txtConfirmar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmar.ForeColor = Color.DimGray;
            txtConfirmar.Location = new Point(339, 287);
            txtConfirmar.Margin = new Padding(4, 3, 4, 3);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Padding = new Padding(10, 7, 10, 7);
            txtConfirmar.Size = new Size(250, 34);
            txtConfirmar.TabIndex = 10;
            txtConfirmar.TieneError = false;
            txtConfirmar.Leave += txtConfirmar_Leave;
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(339, 259);
            ucTexto1.Margin = new Padding(3, 4, 3, 4);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(169, 21);
            ucTexto1.TabIndex = 8;
            ucTexto1.TitleText = "Confirmar Contraseña";
            // 
            // ucTexto2
            // 
            ucTexto2.BackColor = Color.Transparent;
            ucTexto2.Location = new Point(339, 167);
            ucTexto2.Margin = new Padding(3, 4, 3, 4);
            ucTexto2.Name = "ucTexto2";
            ucTexto2.Size = new Size(169, 21);
            ucTexto2.TabIndex = 7;
            ucTexto2.TitleText = "Nueva Contraseña";
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(358, 76);
            ucTitulo1.Margin = new Padding(3, 4, 3, 4);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(658, 38);
            ucTitulo1.TabIndex = 6;
            ucTitulo1.TitleText = "Activar cuenta";
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.ForeColor = Color.Black;
            btnMax.Image = Resources.maximizar1;
            btnMax.Location = new Point(1241, 2);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(25, 23);
            btnMax.TabIndex = 6;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // FormReactivar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(pnlFormulario);
            Controls.Add(pnlMenu);
            Controls.Add(pnlTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReactivar";
            Text = "FormReactivar";
            pnlTitulo.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlFormulario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlMenu;
        private PictureBox pictureBox1;
        private Button btnMin;
        private Button btnRestaurar;
        private Button btnCerrar;
        private Panel pnlFormulario;
        private Controles.ucTitulo ucTitulo1;
        private Controles.ucTexto ucTexto1;
        private Controles.ucTexto ucTexto2;
        private Controles.ucTextBox txtContraseña;
        private Controles.ucTextBox txtConfirmar;
        private Controles.ucBotonAceptar ucBotonAceptar1;
        private Controles.ucLabelError errorActivar;
        private Controles.ucLabelError errorConfirmar;
        private Controles.ucLabelError errorContraseña;
        private Controles.ucLabelError errorContraseña2;
        private Button btnMax;
    }
}