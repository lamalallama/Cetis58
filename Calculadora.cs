using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class MainForm : Form
    {
        private double resultado = 0;
        private string operacion = "";
        private bool hayOperacionPendiente = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void NumeroClick(object sender, EventArgs e)
        {
            if (hayOperacionPendiente)
            {
                txtPantalla.Text = "";
                hayOperacionPendiente = false;
            }

            Button boton = (Button)sender;
            txtPantalla.Text += boton.Text;
        }

        private void OperacionClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPantalla.Text))
            {
                Button boton = (Button)sender;
                operacion = boton.Text;
                resultado = double.Parse(txtPantalla.Text);
                hayOperacionPendiente = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operacion) && !hayOperacionPendiente)
            {
                double segundoNumero = double.Parse(txtPantalla.Text);
                switch (operacion)
                {
                    case "+":
                        resultado += segundoNumero;
                        break;
                    case "-":
                        resultado -= segundoNumero;
                        break;
                    case "*":
                        resultado *= segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero != 0)
                        {
                            resultado /= segundoNumero;
                        }
                        else
                        {
                            txtPantalla.Text = "Error";
                            return;
                        }
                        break;
                }
                txtPantalla.Text = resultado.ToString();
                operacion = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            resultado = 0;
            operacion = "";
            hayOperacionPendiente = false;
        }
    }
}
