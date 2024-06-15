using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grupo3.Presentacion.Controles
{
    public partial class ucComboBox : UserControl
    {
        private Colores colores = new Colores();
        private System.Windows.Forms.ComboBox cmbList;
        private Label lblText;
        private System.Windows.Forms.Button btnIcon;

        public event EventHandler OnSelectedIndexChanged;
        public ucComboBox()
        {
            this.SuspendLayout();
            CrearCombo();
            CrearIcono();
            CrearLabel();

            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);

            this.MinimumSize = new Size(250, 33);
            this.Size = new Size(250, 33);
            this.Padding = new Padding(colores.bordeTamano);
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = colores.bordeColor;

            this.ResumeLayout();
            AdjustComboBoxDimensions();

        }
        private void CrearCombo()
        {
            cmbList = new System.Windows.Forms.ComboBox();
            cmbList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbList.BackColor = colores.colorListaFondo;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = colores.colorListaTexto;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);
        }
        private void CrearIcono()
        {
            btnIcon = new System.Windows.Forms.Button();
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = colores.colorFondo;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon
        }
        private void CrearLabel()
        {
            lblText = new Label();
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = colores.colorFondo;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);

            lblText.Click += new EventHandler(Surface_Click);
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);
        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public string DisplayMember
        {
            get { return cmbList.DisplayMember; }
            set { cmbList.DisplayMember = value; }
        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public string ValueMember
        {
            get { return cmbList.ValueMember; }
            set { cmbList.ValueMember = value; }
        }
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object SelectedItem
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object SelectedValue
        {
            get { return cmbList.SelectedValue; }
            set { cmbList.SelectedValue = value; }
        }


        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public int SelectedIndex
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public string SelectedText
        {
            get { return cmbList.SelectedText; }
            set { cmbList.SelectedText = value; }
        }
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            lblText.Text = cmbList.Text;
        }
        private void Icon_Click(object sender, EventArgs e)
        {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cmbList.Text;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconoAncho = 14;
            int iconoAlto = 6;
            var rectangulo = new Rectangle((btnIcon.Width - iconoAncho) / 2, (btnIcon.Height - iconoAlto) / 2, iconoAncho, iconoAlto);
            Graphics grafico = e.Graphics;
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(colores.colorIcono, 2))
            {
                grafico.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectangulo.X, rectangulo.Y, rectangulo.X + (iconoAncho / 2), rectangulo.Bottom);
                path.AddLine(rectangulo.X + (iconoAncho / 2), rectangulo.Bottom, rectangulo.Right, rectangulo.Y);
                grafico.DrawPath(pen, path);
            }
        }
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

    }
}
