using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnClacular_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE OS CAMPOS FORAM PREENCHIDOS CORRETAMENTE:

            if (txbPeso.Text == "")
            {
                MessageBox.Show("Preencha o campo 'Peso'", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Mudar a cor do fundo e a cor da letra,
                //indicando o campo a ser preenchido:
                txbPeso.BackColor = Color.Red;
                txbPeso.ForeColor = Color.White;


            }
            else if (txbAltura.Text == "")
            {
                MessageBox.Show("Preencha o campo 'Altura'", "Erro!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Mudar a cor do fundo e a cor da letra,
                //indicando o campo a ser preenchido:
                txbAltura.BackColor = Color.Red;
                txbAltura.ForeColor = Color.White;


            }
            else if (txbAltura.Text.Length < 3)
            {
                MessageBox.Show("O campo 'Altura' precisa ter no mínimo três caracteres",
                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else //SE A VERIFICAÇÃO FOR BEM SUCEDIDA, INICIA O PROGRAMA:
            {
                //Declaração de variaveis que serão utilizadas:
                double altura = double.Parse(txbAltura.Text);
                double peso = double.Parse(txbPeso.Text);
                double result;

                //Calculo do IMC peso/(altura * altura):
                result = peso/(altura * altura);

                //Verificar a classificação do usuário
                if (result < 18.5)
                {
                    lblResultado.Text = ($"IMC: {Math.Round(result, 2)}");
                    lblSaude.Text = ("Abaixo do peso");
                }
                else if (result > 18.5 && result < 25.0)
                {
                    lblResultado.Text = ($"IMC: {Math.Round(result, 2)}");
                    lblSaude.Text = ("Peso ideal (Parabéns!)");
                }
                else if (result > 24.9 && result < 30.0)
                {
                    lblResultado.Text = ($"IMC: {Math.Round(result, 2)}");
                    lblSaude.Text = ("levemente acima do peso");
                }
                else if (result > 29.9 && result < 35.0)
                {
                    lblResultado.Text = ($"IMC: {Math.Round(result, 2)}");
                    lblSaude.Text = ("Obesidade Grau I");
                }
                else if (result > 34.9 && result < 40.0)
                {
                    lblResultado.Text = ($"IMC: {Math.Round(result, 2)}");
                    lblSaude.Text = ("Obesidade Grau II (Severa)");
                }
                else
                {
                    lblResultado.Text = ($"IMC: {Math.Round(result, 2)  }");
                    lblSaude.Text = ("Obesidade Grau III (Mórbida)");
                }

                //Retornar o campo txbProdutos à cor normal quando
                //o campo for preenchido corretamente:
                txbPeso.BackColor = Color.White;
                txbPeso.ForeColor = Color.Black;
                txbAltura.BackColor = Color.White;
                txbAltura.ForeColor = Color.Black;
            }
        }
    }
}
