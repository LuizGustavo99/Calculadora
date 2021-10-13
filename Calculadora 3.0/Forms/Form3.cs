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
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float num3 = float.Parse(textBox3.Text);

            label5.Text = Convert.ToString(FormulaBhaskara.Bhaskara(num1, num2, num3).ToString("F2"));
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
