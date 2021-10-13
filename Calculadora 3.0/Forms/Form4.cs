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

            //Area X

            label5.Text = Convert.ToString(FormulaHeron.Heron(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text)).ToString("F4"));


            // Area Y

            label6.Text = Convert.ToString(FormulaHeron.Heron(double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text)).ToString("F4"));



            if (FormulaHeron.Heron(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text)) > FormulaHeron.Heron(double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text)))
            {
                label8.Text = Convert.ToString(FormulaHeron.Heron(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text)).ToString("F4"));
            }
            else if(FormulaHeron.Heron(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text)) < FormulaHeron.Heron(double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text)))
            {
                label8.Text = Convert.ToString(FormulaHeron.Heron(double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox6.Text)).ToString("F4"));
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
