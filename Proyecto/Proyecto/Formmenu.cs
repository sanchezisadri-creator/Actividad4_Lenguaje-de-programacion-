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
    public partial class Formmenu : Form
    {
        public Formmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datagri personas = new datagri();
            personas.MdiParent = this.MdiParent;
            personas.Dock = DockStyle.Fill;
            personas.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fibonacci fibo = new fibonacci();
            fibo.MdiParent = this.MdiParent;
            fibo.Dock = DockStyle.Fill;
            fibo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            monedadecambio moneda = new monedadecambio();
            moneda.MdiParent = this.MdiParent;
            moneda.Dock = DockStyle.Fill;
            moneda.Show();
        }
    }
}
