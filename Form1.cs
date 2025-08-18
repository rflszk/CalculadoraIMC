using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txbpeso.Text == "")
            {
                MessageBox.Show("Digite o peso!");

            }
            else if (txbaltura.Text == "")
            {
                MessageBox.Show("Digite a altura!");
            }
            else
            {

                double n1 = double.Parse(txbpeso.Text);
                double n2 = double.Parse(txbaltura.Text);
                string resultado;

                if (n1 == 0)
                    MessageBox.Show("O peso não pode ser igual a ZERO!");
                {
                    if (n2 != 0)
                    {
                        double imc = n1 / (n2 * n2);
                        txbResultado.Text = imc.ToString();
                        if (imc <= 18.5)
                        {
                            resultado = "Abaixo do peso";
                            lblclass.Text = resultado;
                        }

                        else if (imc <= 24.9)
                        {
                            resultado = "Peso Ideal";
                            lblclass.Text = resultado;
                        }
                        else if (imc <= 29.9)
                        {
                            resultado = "Levemente acima do peso";
                            lblclass.Text = resultado;
                        }
                        else if (imc <= 34.9)
                        {
                            resultado = "Obesidade Grau I";
                            lblclass.Text = resultado;
                        }
                        else if (imc <= 39.9)
                        {
                            resultado = "Obesidade Grau II";
                            lblclass.Text = resultado;
                        }
                        else
                        {
                            resultado = "Obesidade III (Mórbida)";
                            lblclass.Text = resultado;
                        }

                    }
                    else
                    {
                        MessageBox.Show("ERRO! Divisão por zero!");
                    }
                }

            }

        }
    }
}
