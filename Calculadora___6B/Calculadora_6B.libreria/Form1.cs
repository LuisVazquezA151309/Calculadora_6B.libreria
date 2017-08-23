using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_6B.libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;
            num1 = Convert.ToInt32(Txtnum1.Text);
            num2 = Convert.ToInt32(Txtnum2.Text);
            suma = num1 + num2;
            MessageBox.Show("La suma es:"+suma,"Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int num1, num2, resta;
            num1 = Convert.ToInt32(Txtnum1.Text);
            num2 = Convert.ToInt32(Txtnum2.Text);
            resta = num1 - num2;
            MessageBox.Show("La resta es:" + resta, "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int num1, num2, division;
            num1 = Convert.ToInt32(Txtnum1.Text);
            num2 = Convert.ToInt32(Txtnum2.Text);
            division = num1 + num2;
            MessageBox.Show("La division es:" +division, "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int num1, num2, multiplicacion;
            num1 = Convert.ToInt32(Txtnum1.Text);
            num2 = Convert.ToInt32(Txtnum2.Text);
            multiplicacion = num1 * num2;
            MessageBox.Show("La multiplicacion es:" + multiplicacion, "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
