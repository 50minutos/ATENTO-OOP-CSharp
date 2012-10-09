using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _002_Calculadora
{
    public partial class Form1 : Form
    {
        private double numero;
        private String operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void Numero(object sender, EventArgs e)
        {
            x.SelectedText = ((Button)sender).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //CE
            x.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //PI
            x.Text = Math.PI.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //E
            x.Text = Math.E.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //PHI
            x.Text = "1.618033989";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //sqrt
            x.Text = Math.Sqrt(Double.Parse(x.Text)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //abs
            x.Text = Math.Abs(Double.Parse(x.Text)).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //sign
            x.Text = Math.Sign(Double.Parse(x.Text)).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //sin - as contas são para converter de 
            //      graus para radianos
            x.Text = Math.Sin(Double.Parse(x.Text) * Math.PI / 180).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //cos
            x.Text = Math.Cos(Double.Parse(x.Text) * Math.PI / 180).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //tan
            x.Text = Math.Tan(Double.Parse(x.Text) * Math.PI / 180).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //x²
            x.Text = (Double.Parse(x.Text) * Double.Parse(x.Text)).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //1/x
            x.Text = (1 / Double.Parse(x.Text)).ToString();
        }

        private void Operacao(object sender, EventArgs e)
        {
            numero = Double.Parse(x.Text);
            operacao = ((Button)sender).Text;
            
            x.Focus();
            x.SelectAll();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //=
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero + double.Parse(x.Text);
                    break;
                case "-":
                    resultado = numero - double.Parse(x.Text);
                    break;
                case "*":
                    resultado = numero * double.Parse(x.Text);
                    break;
                case "/":
                    resultado = numero / double.Parse(x.Text);
                    break;
                case "x^y":
                    resultado = Math.Pow(numero, double.Parse(x.Text));
                    break;
            }

            x.Text = resultado.ToString();
        }
    }
}
