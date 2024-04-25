using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtração,
            Divisao,
            Multiplicacao

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "0";
                       
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {    
            if(!TxtResultado.Text.Contains(",")) 
            TxtResultado.Text = TxtResultado.Text + ",";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            switch(OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Subtração:
                    Resultado = Valor - Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(TxtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(TxtResultado.Text);
                    break;            
            }
            TxtResultado.Text = Resultado.ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
        }

        private void Bnt4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtração;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = "";
            
        }

        private void Bnt7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(TxtResultado.Text);
            TxtResultado.Text = " ";


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            Resultado = 0;
        }
        
        
    }
}
