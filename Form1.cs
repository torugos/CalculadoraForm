using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        //BOTÕES
        private void button0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }
        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }

        //SINAIS
        private void buttonSoma_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            labelOperacao.Text = "+";
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUBTRACAO";
            labelOperacao.Text = "-";
        }
        private void buttonVezes_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULTIPLICACAO";
            labelOperacao.Text = "*";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIVISAO";
            labelOperacao.Text = "/";
        }

        //RESULTADO
        private void buttonResult_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            switch (operacao)
            {
                case "SOMA":
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                    break;
                case "SUBTRACAO":
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "MULTIPLICACAO":
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                    break;
                case "DIVISAO":
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                    break;
            }
            
        }

        //LIMPANDO(C e CE)
        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }
    }
}