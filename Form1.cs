
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        double n = 0;
        int op;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        { //Limpa a Tela
            n = 0;
            textBox1.Text = "";
        }

        private void opMais_Click(object sender, EventArgs e)
        { // operador +
            op = 1;
            double text = double.Parse(textBox1.Text);
            n = text;
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        { // operador =
            double text = double.Parse(textBox1.Text);
            double result = 0;
            if (op == 1)
            {
                result = n + text;
            }
            else if (op == 2)
            {
                result = n - text;
            }
            else if (op == 3)
            {
                result = n * text;
            }
            else if (op == 4)
            {
                result = n / text;
            }
            textBox1.Text = result.ToString();
        }

        private void opMenos_Click(object sender, EventArgs e)
        { // operador -
            op = 2;
            double text = double.Parse(textBox1.Text);
            n = text;
            textBox1.Text = "";
        }

        private void opVezes_Click(object sender, EventArgs e)
        { // operador x
            op = 3;
            double text = double.Parse(textBox1.Text);
            n = text;
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        { // <- remove o ultimo numero da textbox
            textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
        }

        private void opDividir_Click(object sender, EventArgs e)
        { // operador / 
            op = 4;
            double text = double.Parse(textBox1.Text);
            n = text;
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button12_Click(object sender, EventArgs e)
        { // botão de Sobre
            DialogResult dialogResult = MessageBox.Show("Criado por Igor Fernandes. \nObrigado por utilizar! :)", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}