using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VARIABLES_NAVAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double majonchoCost;
        int CantidadMajonchos;
        double totalMajonchocost;

        private void button2_Click(object sender, EventArgs e)
        {
            // Escribe el codigo aqui para 
            majonchoCost = Convert.ToDouble(textBox5.Text);
            CantidadMajonchos = Convert.ToInt32(textBox4.Text);
            totalMajonchocost = majonchoCost * CantidadMajonchos;
            textBox6.Text = "$ " + Convert.ToInt32(totalMajonchocost);

        }
    }
    }

