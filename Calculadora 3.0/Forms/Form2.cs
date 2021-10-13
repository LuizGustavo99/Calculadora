using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Calculadora_3._0
{
    public partial class Form2 : Form
    {
                
        public Form2()
        {
            InitializeComponent();
        }

        Thread novaThread;
        

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            label4.Text = Convert.ToString(OperacoesBasicas.Soma(num1, num2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            label4.Text = Convert.ToString(OperacoesBasicas.Subtracao(num1, num2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            label4.Text = Convert.ToString(OperacoesBasicas.Multiplicacao(num1, num2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);

            label4.Text = Convert.ToString(OperacoesBasicas.Divisao(num1, num2).ToString("F2"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            novaThread = new Thread(telainicial);
            novaThread.SetApartmentState(ApartmentState.STA);
            novaThread.Start();
        }
        private void telainicial(object obj)
        {
            Application.Run(new Form1());
        }

        
    }    
}
