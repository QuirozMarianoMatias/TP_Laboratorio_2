using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CalculadoraTp1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// este metodo se encarga de vaciar los controles txtNumero1 , txtNumero1 , cmbOperador y lblResultado
        /// </summary>
        private void Limpiar ()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.Text = string.Empty;
            lblResultado.Text = string.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// esta funcion se encarga de llamar a las clases Numero y calculara para realizar la operacion entre dos numeros
        /// </summary>
        /// <param name="numero1">string que despues se ultilizara para el atributo del objeto</param>
        /// <param name="numero2">string que despues se ultilizara para el atributo del objeto</param>
        /// <param name="operador">string que despues se ultilizara para saber el operador</param>
        /// <returns>retorna el resultado de la operacion entre los dos objetos</returns>
        public static double Operar (string numero1, string numero2,string operador)
        {
            double resultado;

            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            resultado = Calculadora.Operar(num1, num2, operador);

            return resultado;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
          lblResultado.Text =  Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero(lblResultado.Text);

            lblResultado.Text = binario.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        { 
            
            Numero decimals = new Numero(lblResultado.Text);

            lblResultado.Text = decimals.BinarioDecimal(lblResultado.Text);

        }
    }
}
