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
    public partial class fibonacci : Form
    {
        public fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            int a = 0;
            int b = 1;

            listBox1.Items.Clear();

            listBox1.Items.Add(a);
            listBox1.Items.Add(b);

            for (int i = 2; i < n; i++)
            {
                int c = a + b;
                listBox1.Items.Add(c);

                a = b;
                b = c;
            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
        }
    }
}
