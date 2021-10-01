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
    public partial class Form1 : Form
    {

        Thread novaThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                this.Close();
                novaThread = new Thread(tela2);
                novaThread.SetApartmentState(ApartmentState.STA);
                novaThread.Start();
            }
            else if (radioButton2.Checked == true)
            {
                this.Close();
                novaThread = new Thread(tela3);
                novaThread.SetApartmentState(ApartmentState.STA);
                novaThread.Start();
            }                                  
            else
            {
                MessageBox.Show("Selecione uma opção!");
            }
            
                
        }

        private void tela2(object obj)
        {
            Application.Run(new Form2());
        }

        private void tela3(object obj)
        {
            Application.Run(new Form3());
        }


    }
}
