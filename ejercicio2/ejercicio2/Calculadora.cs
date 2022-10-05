using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.Cl_suma obj = new Clases.Cl_suma();
        Clases.Cl_resta obj2 = new Clases.Cl_resta();
        Clases.Cl_multiplicacion obj3 = new Clases.Cl_multiplicacion();
        Clases.Cl_division obj4 = new Clases.Cl_division();

        private void num0_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + "9";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            btn_caluladora.Text = btn_caluladora.Text + ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(btn_caluladora.Text);
            btn_caluladora.Clear();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(btn_caluladora.Text);
            btn_caluladora.Clear();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            operador = "x";
            primero = double.Parse(btn_caluladora.Text);
            btn_caluladora.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(btn_caluladora.Text);
            btn_caluladora.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(btn_caluladora.Text);
            
            double sum;
            double res;
            double mul;
            double div;

            switch (operador)
            {
                case "+":
                    sum = obj.sumar((primero),(segundo));
                    btn_caluladora.Text = sum.ToString();
                    break;
                case "-":
                    res = obj2.restar((primero), (segundo));
                    btn_caluladora.Text = res.ToString();
                    break;
                case "x":
                    mul = obj3.multiplicar((primero), (segundo));
                    btn_caluladora.Text = mul.ToString();
                    break;
                case "/":
                    div = obj4.dividir((primero), (segundo));
                    btn_caluladora.Text = div.ToString();
                    break;

            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            btn_caluladora.Clear();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (btn_caluladora.Text.Length == 1)
                btn_caluladora.Text = "";
            else
                btn_caluladora.Text = btn_caluladora.Text.Substring(0, btn_caluladora.Text.Length - 1);
        }

       
    }
}
