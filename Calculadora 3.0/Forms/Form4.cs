using System;
using System.Threading;
using System.Windows.Forms;

namespace Calculadora_3._0
{
    public partial class Form4 : Form
    {
                
        public Form4()
        {
            InitializeComponent();
        }

        Thread novaThread;

        private void button1_Click(object sender, EventArgs e)
        {
            double num1x = double.Parse(textBox1.Text);
            double num2x = double.Parse(textBox2.Text);
            double num3x = double.Parse(textBox3.Text);

            double num1y = double.Parse(textBox4.Text);
            double num2y = double.Parse(textBox5.Text);
            double num3y = double.Parse(textBox6.Text);


            //Area X

            label5.Text = Convert.ToString(FormulaHeron.Heron(num1x, num2x, num3x).ToString("F4"));


            // Area Y

            label6.Text = Convert.ToString(FormulaHeron.Heron(num1y, num2y, num3y).ToString("F4"));



            if (FormulaHeron.Heron(num1x, num2x, num3x) > FormulaHeron.Heron(num1y, num2y, num3y))
            {
                label8.Text = Convert.ToString(FormulaHeron.Heron(num1x, num2x, num3x).ToString("F4"));
            }
            else if(FormulaHeron.Heron(num1x, num2x, num3x) < FormulaHeron.Heron(num1y, num2y, num3y))
            {
                label8.Text = Convert.ToString(FormulaHeron.Heron(num1y, num2y, num3y).ToString("F4"));
            }
            else
            {
                label8.Text = "São Iguais.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
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
