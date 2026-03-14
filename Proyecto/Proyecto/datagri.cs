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
    public partial class datagri : Form
    {
        public datagri()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
          textBox1.Text,
          textBox2.Text,
          textBox3.Text,
          textBox4.Text,
          textBox5.Text,
          textBox6.Text,
          textBox7.Text,
          textBox8.Text,
          textBox9.Text,
          textBox10.Text,
          textBox11.Text,
          textBox12.Text
      );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}
