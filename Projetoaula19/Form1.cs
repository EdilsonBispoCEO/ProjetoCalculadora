using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetoaula19
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string  operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "7";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "9";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "8";
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "4";
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "5";
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "1";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "3";
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            textResult.Text = textResult.Text + "0";
        }

        private void mais_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operacao = "mais";
            label1.Text = "+";
        }

        private void botaoCE_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
        }

        private void botaoC_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
            valor1 = 0;
            valor2 = 0;
            label1.Text = "";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operacao = "mult";
            label1.Text = "*";
        }

        private void divis_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operacao = "divis";
            label1.Text = "/";

        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            if (operacao == "mais")
            {
                textResult.Text = Convert.ToString (valor1 + valor2);


            }
            if (operacao == "menos")
            {
                textResult.Text = Convert.ToString(valor1 - valor2);

            }
            if (operacao == "mult")
            {
                textResult.Text = Convert.ToString(valor1 * valor2);


            }
            if (operacao == "divis")
            {
                textResult.Text = Convert.ToString(valor1 / valor2);


            }
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textResult.Text, CultureInfo.InvariantCulture);
            textResult.Text = "";
            operacao = "menos";
            label1.Text = "-";
        }
    }
}
