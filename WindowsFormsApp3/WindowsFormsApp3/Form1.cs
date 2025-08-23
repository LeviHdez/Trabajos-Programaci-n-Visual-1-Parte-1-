using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0, resultado = 0;
        string operacion = "";
        double memoria = 0;

        public Form1()
        {
            InitializeComponent();

            CrearBotones();
        }

        private void CrearBotones()
        {
            int startX = 10, startY = 70;   // posición inicial
            int ancho = 60, alto = 50;      // tamaño botones
            int margen = 5;

            string[,] textos =
            {
        { "7", "8", "9", "/" },
        { "4", "5", "6", "*" },
        { "1", "2", "3", "-" },
        { "0", ".", "=", "+" }
    };

            for (int fila = 0; fila < 4; fila++)
            {
                for (int col = 0; col < 4; col++)
                {
                    string texto = textos[fila, col];
                    Button btn = new Button();
                    btn.Text = texto;
                    btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
                    btn.Size = new Size(ancho, alto);
                    btn.Location = new Point(startX + col * (ancho + margen), startY + fila * (alto + margen));

                    // colores estilo Win10
                    if (char.IsDigit(texto[0]) || texto == ".")
                        btn.BackColor = Color.WhiteSmoke; // números
                    else if (texto == "=")
                        btn.BackColor = Color.LightSkyBlue; // igual
                    else
                        btn.BackColor = Color.LightGray; // operaciones

                    // eventos
                    if (char.IsDigit(texto[0]) || texto == ".")
                        btn.Click += btnNumero_Click;
                    else if (texto == "=")
                        btn.Click += btnIgual_Click;
                    else
                        btn.Click += btnOperacion_Click;

                    this.Controls.Add(btn);
                }
            }

            // Botón C (Clear)
            Button btnClear = new Button();
            btnClear.Text = "C";
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.BackColor = Color.IndianRed;
            btnClear.Size = new Size(ancho, alto);
            btnClear.Location = new Point(startX + 4 * (ancho + margen), startY);
            btnClear.Click += btnClear_Click;
            this.Controls.Add(btnClear);

            // Botón ← (Retroceso)
            Button btnBack = new Button();
            btnBack.Text = "←";
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.BackColor = Color.LightCoral;
            btnBack.Size = new Size(ancho, alto);
            btnBack.Location = new Point(startX + 4 * (ancho + margen), startY + (alto + margen));
            btnBack.Click += btnRetroceso_Click;
            this.Controls.Add(btnBack);
        }


        // ---------------- NÚMEROS ----------------
        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        // ---------------- OPERACIONES BÁSICAS ----------------
        private void btnOperacion_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                valor1 = Convert.ToDouble(txtDisplay.Text);
                Button btn = (Button)sender;
                operacion = btn.Text;
                txtDisplay.Clear();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                valor2 = Convert.ToDouble(txtDisplay.Text);

                switch (operacion)
                {
                    case "+": resultado = valor1 + valor2; break;
                    case "-": resultado = valor1 - valor2; break;
                    case "*": resultado = valor1 * valor2; break;
                    case "/": resultado = valor1 / valor2; break;
                }

                txtDisplay.Text = resultado.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            valor1 = valor2 = resultado = 0;
            operacion = "";
        }

        // ---------------- FUNCIONES DE MEMORIA ----------------
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
                memoria += Convert.ToDouble(txtDisplay.Text);
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
                memoria -= Convert.ToDouble(txtDisplay.Text);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoria.ToString();
        }

        // ---------------- FUNCIONES CIENTÍFICAS ----------------
        private void btnExponente_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double baseNum = Convert.ToDouble(txtDisplay.Text);
                // ejemplo: eleva al cuadrado
                txtDisplay.Text = Math.Pow(baseNum, 2).ToString();
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = Math.Sqrt(num).ToString();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.PI.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = Math.Log10(num).ToString();
            }
        }

        // ---------------- 4 BOTONES EXTRA ----------------
        private void btnSin_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = Math.Sin(num).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = Math.Cos(num).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = Math.Tan(num).ToString();
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = (num / 100).ToString();
            }
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }


    }
}

