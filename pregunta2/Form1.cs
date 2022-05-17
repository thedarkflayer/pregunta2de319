using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta2
{
    public partial class Form1 : Form
    {
        Double pantalla;
        public Form1()
        {
            InitializeComponent();
        }
        double a = 0;
        double b = 0;
        string c;
        string x;

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('.') == false)
            {
                Double digito;
                digito = Convert.ToDouble(((Button)sender).Text);
                pantalla = pantalla * 10 + digito;
                textBox1.Text = pantalla.ToString();
            }
            else
            {
                x = this.textBox1.Text;
                String y;
                y = ((Button)sender).Text;
                x = x + y;
                textBox1.Text = x;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pantalla = 0;
            textBox1.Text = pantalla.ToString();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.textBox1.Text);
            String valor;
            valor = ((Button)sender).Text;
            c = valor;
        
            pantalla = 0;
            textBox1.Text = pantalla.ToString();
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Contains('.') == false)
            {
                this.textBox1.Text = this.textBox1.Text + ".";
            }
        }


        private void bttotal_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textBox1.Text);
            switch (c)
            {
                case "+":
                    this.textBox1.Text = Convert.ToString(b + a);
                    break;
                case "-":
                    this.textBox1.Text = Convert.ToString(b - a);
                    break;
                case "*":
                    this.textBox1.Text = Convert.ToString(b * a);
                    break;
                case "/":
                    this.textBox1.Text = Convert.ToString(b / a);
                    break;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = "";
            x = "";
            pantalla = 0;
            textBox1.Text = pantalla.ToString();
        }
    }
}
