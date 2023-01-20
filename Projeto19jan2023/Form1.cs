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

namespace Projeto19jan2023
{
    public partial class Form1 : Form 
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "1";
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "7";
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "2";
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "3";
        }
        
        private void botao4_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "4";
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "5"; 
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "6";
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "8";
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "9";        
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = textBoxresultado.Text + "0"; 
        }

        private void textBoxresultado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mais_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxresultado.Text, CultureInfo.InvariantCulture);
            textBoxresultado.Text = "";
            operacao = "mais" ;
            labeloperacao.Text = "+";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxresultado.Text, CultureInfo.InvariantCulture);
            textBoxresultado.Text = "";
            operacao = "menos";
            labeloperacao.Text = "-";
        }

        private void labeloperacao_Click(object sender, EventArgs e)
        {
           
        }

        private void mult_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxresultado.Text, CultureInfo.InvariantCulture);
            textBoxresultado.Text = "";
            operacao = "vezes";
            labeloperacao.Text = "x";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(textBoxresultado.Text, CultureInfo.InvariantCulture);
            textBoxresultado.Text = "";
            operacao = "dividir";
            labeloperacao.Text = "/";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxresultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "mais")
            {
                textBoxresultado.Text = Convert.ToString(valor1 + valor2);



            }
            if (operacao == "menos")
            {
                textBoxresultado.Text = Convert.ToString(valor1 - valor2);



            }
            if (operacao == "vezes")
            {
                textBoxresultado.Text = Convert.ToString(valor1 * valor2);



            }
            if (operacao == "dividir")
            {
                textBoxresultado.Text = Convert.ToString(valor1 / valor2);

                

            }

        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = "";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            textBoxresultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labeloperacao.Text = "";
               

        }
    }
}
