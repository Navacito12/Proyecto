using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVALUACION1_NAVAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            double total = 0;

            // Calcular el costo de las pupusas
            total += CalcularCantidad(txtQueso.Text, 0.75);
            total += CalcularCantidad(txtFrijolQueso.Text, 0.50);
            total += CalcularCantidad(txtRevuelta.Text, 0.50);
            total += CalcularCantidad(txtChicharron.Text, 0.50);

            // Calcular el costo de las bebidas
            total += CalcularCantidad(txtHorchata.Text, 0.75);
            total += CalcularCantidad(txtJamaica.Text, 0.75);

            // Mostrar el total
            lblTotal.Text = $"${total.ToString("0.00")}";
        }

        // Método auxiliar para calcular el costo de un ítem
        private double CalcularCantidad(string cantidadTexto, double precio)
        {
            int cantidad;
            if (int.TryParse(cantidadTexto, out cantidad)) // Intenta convertir el texto a un número
            {
                return cantidad * precio; // Si es exitoso, devuelve la cantidad multiplicada por el precio
            }
            return 0; // Si no es un número válido, devuelve 0
        }
        }
    }

