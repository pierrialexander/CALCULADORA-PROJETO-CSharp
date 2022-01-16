using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += btn9.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += button18.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "";
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }else if (operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }else if (operacao == "MULTIPLICAR")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            } else 
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICAR";
                lblOperacao.Text = "X";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVIDIR";
                lblOperacao.Text = "/";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                txtResultado.Text = "";
                lblOperacao.Text = "";
                valor1 = 0;
                valor2 = 0;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            if(txtResultado.Text != "")
            {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
            }

        }
    }
}