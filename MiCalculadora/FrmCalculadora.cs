using Entidades;
using static Entidades.Numeracion;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public ESistema Sistema;
        public Numeracion primerOperando;
        public Numeracion segundoOperando;
        private Numeracion resultado;
        private Operacion calculadora;

        public FrmCalculadora() => InitializeComponent();

        private void btnCerrar_Click(object sender, EventArgs evento)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs evento)
        {
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            lblResultado.Text = "Resultado: ";
        }

        private void btnOperar_Click(object sender, EventArgs evento)
        {
            if (cmbOperacion.Text == "")
            {
                cmbOperacion.SelectedIndex = 0; // Por defecto, muestra el primer operador en el listado cuando no seleccionemos ninguno = '+'
            }

            if (txtPrimerOperador.Text == "" || txtSegundoOperador.Text == "")
            {
                MessageBox.Show("No se puede realizar el cálculo porque falta ingresar algún operando. Por favor, ingrese un número.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "Resultado: Número inválido.";
            }
            else
            {
                if (rdbBinario.Checked == false && rdbDecimal.Checked == false)
                {
                    rdbDecimal.Checked = true;
                }

                string primerOperandoString = txtPrimerOperador.Text;
                string segundoOperandoString = txtSegundoOperador.Text;
                string operador = (string)cmbOperacion.SelectedItem ?? "";

                _ = double.TryParse(primerOperandoString, out double primerOperandoDouble);
                _ = double.TryParse(segundoOperandoString, out double segundoOperandoDouble);

                primerOperando = new(primerOperandoDouble, this.Sistema);
                segundoOperando = new(segundoOperandoDouble, this.Sistema);
                calculadora = new(primerOperando, segundoOperando);

                resultado = calculadora.Operar(operador.FirstOrDefault());
                SetResultado();
            }
        }

        private void SetResultado()
        {
            string textoResultado = "";
            if (resultado is not null)
            {
                textoResultado = resultado.ConvertirA(resultado.Sistema);
            }

            lblResultado.Text = $"Resultado: {textoResultado}";
        }

        /// <summary>
        /// En los siguientes eventos KeyPress, realiza una validación para saber si el caracter que 
        /// se está ingresando en el textbox no es un dígito y si no es un caracter de control (para que
        /// permita eliminar o suprimir los dígitos no deseados en el cálculos) o si realizamos un Enter.
        /// En esos casos mencionados, elimina la tecla registrada para que no se ingrese en el textbox.
        /// </summary>

        private void txtPrimerOperador_KeyPress(object sender, KeyPressEventArgs evento)
        {
            if (!char.IsControl(evento.KeyChar) && !char.IsDigit(evento.KeyChar) ||
                evento.KeyChar == (char)Keys.Enter)
            {
                evento.Handled = true;
            }
        }

        private void txtSegundoOperador_KeyPress(object sender, KeyPressEventArgs evento)
        {
            if (!char.IsControl(evento.KeyChar) && !char.IsDigit(evento.KeyChar) ||
                evento.KeyChar == (char)Keys.Enter)
            {
                evento.Handled = true;
            }
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs evento)
        {
            if (MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                evento.Cancel = true;
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs evento)
        {
            if (rdbBinario.Checked)
            {
                this.Sistema = ESistema.Binario;
            }

            SetResultado();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs evento)
        {
            if (rdbDecimal.Checked)
            {
                this.Sistema = ESistema.Decimal;
            }

            SetResultado();
        }
    }
}