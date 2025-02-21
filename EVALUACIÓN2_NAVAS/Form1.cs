using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVALUACIÓN2_NAVAS
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try

            {
                // Leer notas de los TextBox
                double notaTeo1 = Convert.ToDouble(txtTeo1.Text);
                double notaTeo2 = Convert.ToDouble(txtTeo2.Text);
                double notaTeo3 = Convert.ToDouble(txtTeo3.Text);
                double notaLab1 = Convert.ToDouble(txtLab1.Text);
                double notaLab2 = Convert.ToDouble(txtLab2.Text);
                double notaLab3 = Convert.ToDouble(txtLab3.Text);



                // Validar notas directamente aquí
                if (notaTeo1 < 0.0 || notaTeo1 > 10.0 ||
                    notaTeo2 < 0.0 || notaTeo2 > 10.0 ||
                    notaTeo3 < 0.0 || notaTeo3 > 10.0 ||
                    notaLab1 < 0.0 || notaLab1 > 10.0 ||
                    notaLab2 < 0.0 || notaLab2 > 10.0 ||
                    notaLab3 < 0.0 || notaLab3 > 10.0)


                {

                    throw new ArgumentOutOfRangeException("Todas las notas deben estar entre 0.00 y 10.00.");

                }

                // Calcular promedio
                double promedio = (notaTeo1 + notaTeo2 + notaTeo3 + notaLab1 + notaLab2 + notaLab3) / 6;

                // Mostrar resultado
                lblResultado.Text = $"Promedio: {promedio:F2}\n" + (promedio >= 6.0 ? "Aprobado" : "Reprobado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

    }

}