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
            label4.Text = Convert.ToString(Soma.Somar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label4.Text = Convert.ToString(Subtrai.Subtracao(float.Parse(textBox1.Text), float.Parse(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Multiplica.Multiplicacao(float.Parse(textBox1.Text), float.Parse(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Divide.Divisao(float.Parse(textBox1.Text), float.Parse(textBox2.Text)));
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
