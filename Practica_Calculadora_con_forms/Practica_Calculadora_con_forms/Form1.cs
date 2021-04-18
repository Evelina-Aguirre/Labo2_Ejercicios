using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Calculadora_con_forms
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        Clases.clsSuma obj = new Clases.clsSuma();
        Clases.ClsResta obj1 = new Clases.ClsResta();
        Clases.ClsMult obj2 = new Clases.ClsMult();
        Clases.ClsDiv obj3 = new Clases.ClsDiv();

        private void btn0_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + "9";
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            textScreen.Text = textScreen.Text + ".";
        }

        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textScreen.Text);
            textScreen.Clear();
        }


        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textScreen.Text);
            textScreen.Clear();
        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(textScreen.Text);
            textScreen.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textScreen.Text);
            textScreen.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textScreen.Text);
            double sumar;
            double restar;
            double multiplicar;
            double dividir;

            switch(operador)
            {
                case "+":
                    sumar = obj.Sumar((primero), (segundo));
                    textScreen.Text = sumar.ToString();
                    break;
                case "-":
                    restar= obj1.Restar((primero), (segundo));
                    textScreen.Text = restar.ToString();
                    break;
                case "*":
                    multiplicar = obj2.Multiplicar((primero), (segundo));
                    textScreen.Text = multiplicar.ToString();
                    break;
                case "/":
                    dividir = obj3.Dividir((primero),(segundo));
                    textScreen.Text = dividir.ToString();
                    break;
                
            }

        }

        private void btnLimpiarScreen_Click(object sender, EventArgs e)
        {
            textScreen.Clear();
            primero = 0;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (textScreen.Text.Length == 1)
                textScreen.Text = "";
            else
                textScreen.Text = textScreen.Text.Substring(0, textScreen.Text.Length - 1);
        }
    }
}
