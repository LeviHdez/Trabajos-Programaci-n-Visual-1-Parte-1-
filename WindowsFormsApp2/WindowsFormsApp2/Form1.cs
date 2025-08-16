using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // Contador para el Tab de Contador de Clics
        private int contadorClics = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // --- Ejercicio 1: Calcular IMC ---
        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            string pesoTexto = txtPeso.Text.Trim();
            string alturaTexto = txtAltura.Text.Trim();

            if (string.IsNullOrEmpty(pesoTexto) || string.IsNullOrEmpty(alturaTexto))
            {
                MessageBox.Show("Por favor, ingrese peso y altura.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double peso, altura;
            if (!double.TryParse(pesoTexto, out peso) || !double.TryParse(alturaTexto, out altura))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (peso <= 0 || altura <= 0)
            {
                MessageBox.Show("El peso y la altura deben ser mayores que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double imc = peso / (altura * altura);
            string categoria = "";
            MessageBoxIcon icono = MessageBoxIcon.Information; // Valor por defecto

            // Determinar categoría y el icono
            if (imc < 16)
            {
                categoria = "Delgadez severa";
                icono = MessageBoxIcon.Warning;
            }
            else if (imc >= 16 && imc < 18.5)
            {
                categoria = "Delgadez moderada";
                icono = MessageBoxIcon.Warning;
            }
            else if (imc >= 18.5 && imc < 25)
            {
                categoria = "Peso normal";
                icono = MessageBoxIcon.Information;
            }
            else if (imc >= 25 && imc < 30)
            {
                categoria = "Sobrepeso";
                icono = MessageBoxIcon.Error;
            }
            else if (imc >= 30 && imc < 35)
            {
                categoria = "Obesidad grado 1";
                icono = MessageBoxIcon.Error;
            }
            else if (imc >= 35 && imc < 40)
            {
                categoria = "Obesidad grado 2";
                icono = MessageBoxIcon.Error;
            }
            else // imc >= 40
            {
                categoria = "Obesidad grado 3";
                icono = MessageBoxIcon.Error;
            }

            // Mostrar resultado con categoría e ícono
            MessageBox.Show("Tu IMC es: " + imc.ToString("F2") + "\nCategoría: " + categoria,
                            "Resultado", MessageBoxButtons.OK, icono);
        }



        // --- Ejercicio 2: Contador de Clics ---
        private void btnClic_Click(object sender, EventArgs e)
        {
            contadorClics++;
            lblContador.Text = contadorClics.ToString();
        }

        // --- Ejercicio 3: Conversor de Temperatura ---
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTemperatura.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor de temperatura.");
                return;
            }

            if (!double.TryParse(txtTemperatura.Text, out double temp))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            if (rbCtoF.Checked)
            {
                double resultado = (temp * 9 / 5) + 32;
                MessageBox.Show($"{temp}°C = {resultado:F2}°F");
            }
            else if (rbFtoC.Checked)
            {
                double resultado = (temp - 32) * 5 / 9;
                MessageBox.Show($"{temp}°F = {resultado:F2}°C");
            }
            else
            {
                MessageBox.Show("Seleccione una opción de conversión.");
            }
        }
    }
}
