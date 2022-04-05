using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Form1 : Form
    {
        double cislo1;
        double cislo2;

        string operace;
        string vystup; //to co se bude vypisovat do Labelu 

        bool operaceProvedena;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCifry_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operaceProvedena))
            {
                textBox1.Clear();
            }

            
            operaceProvedena = false;
            Button button = (Button)sender;

            textBox1.Text = textBox1.Text + button.Text;
        }

        private void buttonOperace_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operace = button.Text;
            cislo1 = Double.Parse(textBox1.Text);
            label1.Text = cislo1 + " " + operace;
            operaceProvedena = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            cislo1 = 0;
            cislo2 = 0;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch(operace)
            {
                case "+":
                    label1.Text = (cislo1 + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    label1.Text = (cislo1 - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    label1.Text = (cislo1 * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    label1.Text = (cislo1 / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }
        // bonusové funkce (nefunkční zatím)
        private void buttonCOS_Click(object sender, EventArgs e)
        {

        }

        private void buttonSIN_Click(object sender, EventArgs e)
        {
        }

        private void buttonTAG_Click(object sender, EventArgs e)
        {
        }

        private void buttonLOG_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEXP_Click(object sender, EventArgs e)
        {
          
        }
    }
}
