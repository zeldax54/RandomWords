using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramdomizar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Procesador p = new Procesador();
            textBox1.Text = p.Randomizar2Nivel(textBox1.Text);
            textBox2.Text = p.Ramdimozar(textBox1.Text);
        }
    }
}
