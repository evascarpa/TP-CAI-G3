namespace Grupo3.Presentacion
{
    partial class FormLogin
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
            errorLogin = new Controles.ucLabelError();
            ucBotonAceptar1 = new Controles.ucBotonAceptar();
            ucTexto2 = new Controles.ucTexto();
            ucTexto1 = new Controles.ucTexto();
            ucTitulo1 = new Controles.ucTitulo();
            txtPassword = new Controles.ucTextBox();
            txtUsuario = new Controles.ucTextBox();
            pnlMenu = new Panel();
            pictureBox1 = new PictureBox();
            pnlTitulo = new Panel();
            btnRestaurar = new Button();
            btnMin = new Button();
            btnMax = new Button();
            btnCerrar = new Button();
            pnlContenedor.SuspendLayout();
            pnlFormulario.SuspendLayout();
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
            pnlFormulario.Controls.Add(errorLogin);
            pnlFormulario.Controls.Add(ucBotonAceptar1);
            pnlFormulario.Controls.Add(ucTexto2);
            pnlFormulario.Controls.Add(ucTexto1);
            pnlFormulario.Controls.Add(ucTitulo1);
            pnlFormulario.Controls.Add(txtPassword);
            pnlFormulario.Controls.Add(txtUsuario);
            pnlFormulario.Dock = DockStyle.Fill;
            pnlFormulario.Location = new Point(286, 37);
            pnlFormulario.Margin = new Padding(3, 4, 3, 4);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(1200, 830);
            pnlFormulario.TabIndex = 2;
            // 
            // errorLogin
            // 
            errorLogin.BackColor = Color.Transparent;
            errorLogin.Location = new Point(387, 529);
            errorLogin.Margin = new Padding(3, 5, 3, 5);
            errorLogin.Name = "errorLogin";
            errorLogin.Size = new Size(491, 21);
            errorLogin.TabIndex = 6;
            errorLogin.Visible = false;
            // 
            // ucBotonAceptar1
            // 
            ucBotonAceptar1.BackColor = Color.FromArgb(25, 135, 84);
            ucBotonAceptar1.FlatAppearance.BorderSize = 0;
            ucBotonAceptar1.FlatStyle = FlatStyle.Flat;
            ucBotonAceptar1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ucBotonAceptar1.ForeColor = Color.White;
            ucBotonAceptar1.Location = new Point(387, 456);
            ucBotonAceptar1.Margin = new Padding(3, 4, 3, 4);
            ucBotonAceptar1.Name = "ucBotonAceptar1";
            ucBotonAceptar1.Size = new Size(286, 53);
            ucBotonAceptar1.TabIndex = 5;
            ucBotonAceptar1.Text = "Login";
            ucBotonAceptar1.UseVisualStyleBackColor = false;
            ucBotonAceptar1.Click += ucBotonAceptar1_Click;
            // 
            // ucTexto2
            // 
            ucTexto2.BackColor = Color.Transparent;
            ucTexto2.Location = new Point(387, 328);
            ucTexto2.Margin = new Padding(3, 5, 3, 5);
            ucTexto2.Name = "ucTexto2";
            ucTexto2.Size = new Size(193, 28);
            ucTexto2.TabIndex = 4;
            ucTexto2.TitleText = "Contraseña";
            // 
            // ucTexto1
            // 
            ucTexto1.BackColor = Color.Transparent;
            ucTexto1.Location = new Point(387, 223);
            ucTexto1.Margin = new Padding(3, 5, 3, 5);
            ucTexto1.Name = "ucTexto1";
            ucTexto1.Size = new Size(193, 28);
            ucTexto1.TabIndex = 3;
            ucTexto1.TitleText = "Usuario";
            // 
            // ucTitulo1
            // 
            ucTitulo1.Location = new Point(455, 101);
            ucTitulo1.Margin = new Padding(3, 5, 3, 5);
            ucTitulo1.Name = "ucTitulo1";
            ucTitulo1.Size = new Size(545, 51);
            ucTitulo1.TabIndex = 2;
            ucTitulo1.TitleText = "Login";
            ucTitulo1.Load += ucTitulo1_Load;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.EsPassword = true;
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(387, 364);
            txtPassword.Margin = new Padding(5, 4, 5, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(11, 9, 11, 9);
            txtPassword.Size = new Size(286, 43);
            txtPassword.TabIndex = 1;
            txtPassword.TieneError = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.EsPassword = false;
            txtUsuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.DimGray;
            txtUsuario.Location = new Point(387, 259);
            txtUsuario.Margin = new Padding(5, 4, 5, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(11, 9, 11, 9);
            txtUsuario.Size = new Size(286, 43);
            txtUsuario.TabIndex = 0;
            txtUsuario.TieneError = false;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(112, 44, 249);
            pnlMenu.Controls.Add(pictureBox1);
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
            pictureBox1.Location = new Point(58, 366);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 185);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
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
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 867);
            Controls.Add(pnlContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(743, 867);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            pnlContenedor.ResumeLayout(false);
            pnlFormulario.ResumeLayout(false);
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
        private Button btnMin;
        private Button btnMax;
        private Button btnCerrar;
        private Button btnRestaurar;
        private Controles.ucBotonAceptar ucBotonAceptar1;
        private Controles.ucTexto ucTexto2;
        private Controles.ucTexto ucTexto1;
        private Controles.ucTitulo ucTitulo1;
        private Controles.ucTextBox txtPassword;
        private Controles.ucTextBox txtUsuario;
        private Controles.ucLabelError errorLogin;
        private PictureBox pictureBox1;
    }
}