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
    public partial class Form3 : Form
    {

        Thread novaThread;

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            float delta = 0;
            float resultado = 0;



            a = float.Parse(textBox1.Text);

            b = float.Parse(textBox2.Text);

            c = float.Parse(textBox3.Text);



            delta = (float)(Math.Pow(b, 2.0f) - (4.0 * a * c));

            resultado = (float)((-b + Math.Sqrt(delta)) / (2.0 * a));



            label5.Text = Convert.ToString(resultado.ToString("F2"));
        }

        private void button1_Click(object sender, EventArgs e)
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
