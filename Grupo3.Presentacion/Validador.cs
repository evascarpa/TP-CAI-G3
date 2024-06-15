using Grupo3.Presentacion.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

class Validador
{
    public bool soloNumeros(KeyPressEventArgs e)
    {
        bool esValido = char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar);
        e.Handled = !esValido;
        return esValido;
    }

    public bool soloNumerosTel(KeyPressEventArgs e)
    {
        bool esValido = char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.Equals(e.KeyChar, '-');
            e.Handled = !esValido;
            return esValido;
    }

    public bool soloLetras(KeyPressEventArgs e)
    {
        bool esValido = char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar);
        e.Handled = !esValido;
        return esValido;
    }

    public bool textoVacio(ucTextBox txt)
    {
       bool esValido = txt.Text == string.Empty;
       return esValido;
    }

    public bool textoVacio(ucTextBox txt, ucLabelError labelError)
    {
        bool noEsValido = String.IsNullOrEmpty(txt.Text);

        labelError.label1_set("◆El campo no puede estar vacio");
        labelError.Visible = noEsValido;

        txt.TieneError = noEsValido;

        return !noEsValido;
    }

    public bool validarEmail(ucTextBox txt)
    {
        bool esValido = !(txt.Text != null && Regex.IsMatch(txt.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"));
        return esValido;        
    }

    public bool mayorAm(ucTextBox txt)
    {
        if (!int.TryParse(txt.Text, out int n))
        {
            return true;
        }
        if (n <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool mayorAm(ucTextBox txt, ucLabelError labelError, int numero)
    {
        bool esValido = int.TryParse(txt.Text, out int n) && n > numero;
        
        labelError.Visible = !esValido;
        txt.TieneError = !esValido;
        labelError.label1_set("◆El campo debe ser mayor que 0");
        return esValido;
    }

    public bool seleccionoValor(ucComboBox combo, ucLabelError labelError)
    {
        bool esValido = !String.IsNullOrEmpty(combo.SelectedValue.ToString());

        labelError.Visible = !esValido;
        labelError.label1_set("◆Debe seleccionar un valor");
        return esValido;
    }

    public bool longitudCampo(ucTextBox txt, int inf, int sup)
    {
        bool esValido = (txt.Text.ToString().Length < inf || txt.Text.ToString().Length > sup);
        return esValido;
    }

    public bool contieneNombreoApellido(ucTextBox txt, ucTextBox txt1, ucTextBox txt2)
    {
        string usuario = txt.Text.ToUpper();
        string nombre = txt1.Text.ToUpper();
        string apellido = txt2.Text.ToUpper();
        bool esValido = (usuario.Contains(nombre) || usuario.Contains(apellido));
        return esValido;
    }

    public bool contieneMayusculaoNumero(ucTextBox txt)
    {
        bool esValido = !(txt.Text.Any(char.IsUpper) && txt.Text.Any(char.IsDigit));
        return esValido;
    }

    public bool fechaLimite(ucDate dte)
    {
        DateTime fechaLimiteinf = new DateTime(1955, 1, 1);
        DateTime fechaLimitesup = new DateTime(2006, 1, 1);
        bool EsValido = (dte.Value.Date < fechaLimiteinf || dte.Value.Date > fechaLimitesup);
        return EsValido;
    }

    public void validadorLeave(ucTextBox txt, Func<ucTextBox, bool> metodo, ucLabelError error, string mensaje)
    {
        if (metodo(txt))        
        {
            error.Show();
            error.label1_set(mensaje);
        }
        else
        {
            error.Hide();
        }        
    }

    public void validadorLeaveLongitud(ucTextBox txt, int n,int n2, Func<ucTextBox, int, int, bool> metodo, ucLabelError error, string mensaje)
    {
        
        if (metodo(txt, n, n2))
        {
            error.Show();
            error.label1_set(mensaje);
        }
        else
        {
            error.Hide();
        }
    }

    public void validadorLeaveFecha(ucDate dte, Func<ucDate, bool> metodo, ucLabelError error, string mensaje)
    {

        if (metodo(dte))
        {
            error.Show();
            error.label1_set(mensaje);
        }
        else
        {
            error.Hide();
        }
    }

    public void validadorPressKey(KeyPressEventArgs p, Func<KeyPressEventArgs, bool> metodo, ucTextBox txt, ucLabelError error, string mensaje)
    {
        if (!metodo(p))
        {
            error.Show();
            error.label1_set(mensaje);
        }
        else
        {
            error.Hide();
        }
    }

    internal bool textoVacio(DateTime value)
    {
        throw new NotImplementedException();
    }
}

