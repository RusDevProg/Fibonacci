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
using System.Diagnostics;

namespace Numbers
{
    public partial class Form1 : Form
    {
        public int lowBord;
        public int? highBord;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(PrintN);
            th.IsBackground = true;
            th.Start();

        }


        public void PrintN()
        {

            lowBord = 2;
            highBord = null;

            if (!string.IsNullOrEmpty(LowBor.Text))
            {
                int.TryParse(LowBor.Text, out lowBord);
            }

            if (!string.IsNullOrEmpty(HighBor.Text))
            {
                int.TryParse(HighBor.Text, out int val);
                highBord = val;
            }


            for (int num = lowBord; num <= highBord; num++)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Numb.Items.Add(num);
                });
            }

        }

        public void PrintF()
        {
            int N1 = 1;
            int N2 = 2;
            for(int i = 0; i < highBord; i++)
            {
                var N3 = N1 + N2;
                N1 = N2;
                N2 = N3;

                this.Invoke((MethodInvoker)delegate
                {
                    Fibon.Items.Add(N1);
                });
            }
        }
  

        private void LowBorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Thread th2 = new Thread(PrintF);
            th2.IsBackground = true;
            th2.Start();
        }
    }
}
