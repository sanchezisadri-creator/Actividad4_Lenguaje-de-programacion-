using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class monedadecambio : Form
    {
        public monedadecambio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("USD a DOP");
            comboBox1.Items.Add("DOP a USD");
            comboBox1.Items.Add("USD a EUR");
            comboBox1.Items.Add("EUR a USD");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(textBox1.Text);
            double resultado = 0;

            if (comboBox1.Text == "USD a DOP")
            {
                resultado = monto * 58;
            }
            else if (comboBox1.Text == "DOP a USD")
            {
                resultado = monto / 58;
            }
            else if (comboBox1.Text == "USD a EUR")
            {
                resultado = monto * 0.92;
            }
            else if (comboBox1.Text == "EUR a USD")
            {
                resultado = monto / 0.92;
            }

            textBox2.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
        }
    }
}
