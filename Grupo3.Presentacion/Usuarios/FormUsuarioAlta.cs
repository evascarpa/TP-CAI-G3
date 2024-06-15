using Grupo3.Entidades;
using Grupo3.Negocio;
using Grupo3.Presentacion.Logs;

namespace Grupo3.Presentacion
{
    public partial class FormUsuarioAlta : Form
    {   
       
        Validador validador = new Validador();
        private FormPrincipal FormPrincipal;        

        public FormUsuarioAlta(FormPrincipal formPrincipal)
        {
            InitializeComponent();          

            List<Item> items = new List<Item>();
            items.Add(new Item("3", "Administrador"));
            items.Add(new Item("2", "Supervisor"));
            items.Add(new Item("1", "Vendedor"));

            cmbHost.DisplayMember = "Valor";
            cmbHost.ValueMember = "Id";

            cmbHost.DataSource = items
                .OrderBy(x => x.Valor)
                .ToList();

            FormPrincipal = formPrincipal;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloLetras, txtNombre, errorNombre, "◆Solo Letras");
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtNombre, validador.textoVacio, errorNombre, "◆El Nombre no puede estar vacio");
        }
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumeros, txtDni, errorDNI, "◆Solo Numeros");
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloNumerosTel, txtTelefono, errorTelefono, "◆Solo Numeros o -");
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validador.validadorPressKey(e, validador.soloLetras, txtApellido, errorApellido, "◆Solo Letras");
        }
        private void txtApellido_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtApellido, validador.textoVacio, errorApellido, "◆El Apellido no puede estar vacio");
        }
        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtDireccion, validador.textoVacio, errorDireccion, "◆La Direccion no puede estar vacia");
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            validador.validadorLeaveLongitud(txtTelefono, 8, 12, validador.longitudCampo, errorTelefono, "◆El teléfono debe contener hasta 12 caracteres");
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (validador.contieneNombreoApellido(txtUsuario, txtNombre, txtApellido))
            {
                errorUsuario.Show();
                errorUsuario.label1_set("◆No puede contener el nombre ni el apellido");
            }
            else
            {
                errorUsuario.Hide();
            }
            validador.validadorLeaveLongitud(txtUsuario, 8, 15, validador.longitudCampo, errorUsuario2, "◆Debe contener entre 8 y 15 caracteres");
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtEmail, validador.validarEmail, errorEmail, "◆El Email debe ser valido");
        }
        private void txtDni_Leave(object sender, EventArgs e)
        {
            validador.validadorLeaveLongitud(txtDni, 8, 8, validador.longitudCampo, errorDNI, "◆El DNI debe contener 8 caracteres");
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            validador.validadorLeave(txtContraseña, validador.contieneMayusculaoNumero, errorContraseña, "◆Debe contener al menos una mayuscula y un numero");
            validador.validadorLeaveLongitud(txtContraseña, 8, 15, validador.longitudCampo, errorContraseña2, "Debe contener entre 8 y 15 caracteres");
        }
        private void datFechaNacimiento_Leave(object sender, EventArgs e)
        {
            validador.validadorLeaveFecha(datFechaNacimiento, validador.fechaLimite, errorNacimiento, "◆La fecha debe ser superior a 1955 e inferior a 2006");
        }
        private void cmbHost_Leave(object sender, EventArgs e) //No Funciona
        {
            if (cmbHost.SelectedItem == null)
            {
                errorHost.Show();
                errorHost.label1_set("◆Seleccione una opcion");
            }
            else
            {
                errorHost.Hide();
            }
        }
       
        private void ucBotonAceptar1_Click(object sender, EventArgs e)
        {
            InactivosArchivoLog archivo = new InactivosArchivoLog();
            try
            {
                if (validador.textoVacio(txtNombre) || validador.textoVacio(txtApellido) || validador.textoVacio(txtDireccion) 
                    || validador.longitudCampo(txtTelefono, 8, 12) || validador.longitudCampo(txtDni, 8, 8) || validador.validarEmail(txtEmail) 
                    || validador.contieneNombreoApellido(txtUsuario, txtNombre, txtApellido) || validador.longitudCampo(txtUsuario, 8, 15) 
                    || validador.contieneMayusculaoNumero(txtContraseña) || validador.longitudCampo(txtContraseña, 8, 15)
                    || validador.fechaLimite(datFechaNacimiento))

                {
                    errorGuardar.Show();
                    errorGuardar.label1_set("◆Todos los campos deben estar completos");
                }
                else
                {
                    errorGuardar.Hide();
                    string idUsuario = UsuarioSesion.Id.ToString();
                    int host = Convert.ToInt32(cmbHost.SelectedValue);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    int dni = Convert.ToInt32(txtDni.Text);
                    string direccion = txtDireccion.Text;
                    string telefono = txtTelefono.Text; 
                    string email = txtEmail.Text;
                    DateTime fechaNacimiento = datFechaNacimiento.Value;
                    string nombreUsuario = txtUsuario.Text;
                    string contraseña = txtContraseña.Text;                   
                   
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                    usuarioNegocio.AgregarUsuario(idUsuario, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
                    string id = usuarioNegocio.LogIn(nombreUsuario, contraseña).ToString();
                    archivo.GuardarInactivo(nombreUsuario, contraseña, id, host);
                    usuarioNegocio.eliminarUsuario(Guid.Parse(id), UsuarioSesion.Id);                    
                    DialogResult result = MessageBox.Show("Usuario agregado exitosamente. Desea agregar otro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {                                  
                        txtNombre.Text = String.Empty;
                        txtApellido.Text = String.Empty;
                        txtDireccion.Text = String.Empty;
                        txtTelefono.Text = String.Empty;
                        txtDni.Text = String.Empty;
                        txtEmail.Text = String.Empty;
                        txtUsuario.Text = String.Empty;
                        txtContraseña.Text = String.Empty;
                        cmbHost.SelectedIndex = 0;                        
                    }
                    else
                    {
                        this.Hide();
                        FormPrincipal.AbrirFormulario(new FormUsuarioLista(FormPrincipal));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucBotonPrimario1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal.AbrirFormulario(new FormUsuarioLista(FormPrincipal));

        }
    }
}