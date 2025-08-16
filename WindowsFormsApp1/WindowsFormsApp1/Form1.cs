using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int IntentosFallidos = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, clave;
            usuario = ctUsuario.Text;
            clave = ctClave.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor , complete todos los campos.", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;

            }
            if (usuario == "admind" && clave == "admind123")
            {
                MessageBox.Show("Bienvenido al sistema: " + usuario, "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IntentosFallidos = 0;
            }
            else
            {
                IntentosFallidos++;

                if (IntentosFallidos >= 3)
                {
                    MessageBox.Show("Has excedido el numero maximo de intentos. La APP se cerrara.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Intento " + IntentosFallidos + " de 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
        }
    }
}