using System;
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                this.Close();
                novaThread = new Thread(tela2);
                novaThread.SetApartmentState(ApartmentState.MTA);
                novaThread.Start();
            }
            else if (radioButton2.Checked == true)
            {
                this.Close();
                novaThread = new Thread(tela3);
                novaThread.SetApartmentState(ApartmentState.MTA);
                novaThread.Start();
            }
            else if (radioButton3.Checked == true)
            {
                this.Close();
                novaThread = new Thread(tela4);
                novaThread.SetApartmentState(ApartmentState.MTA);
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
              
        private void tela4(object obj)
        {
            Application.Run(new Form4());
        }
    }
}
