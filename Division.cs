using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox de entrada
            if (decimal.TryParse(txtDividendo.Text, out decimal dividendo) &&
                decimal.TryParse(txtDivisor.Text, out decimal divisor))
            {
                // Realizar la división y mostrar el resultado en el TextBox de resultado
                if (divisor != 0)
                {
                    decimal resultado = dividendo / divisor;
                    txtResultado.Text = resultado.ToString();
                }
                else
                {
                    txtResultado.Text = "No se puede dividir por cero.";
                }
            }
            else
            {
                txtResultado.Text = "Entrada inválida. Asegúrate de ingresar números válidos.";
            }
        }
    }
}
