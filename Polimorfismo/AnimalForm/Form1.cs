using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animales;

namespace AnimalForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(12,23,45,"Leono");
            label1.Text=leon.Imprimir();
            label2.Text=leon.Alimento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(6, 12, 10, "Bugs");
            label1.Text = conejo.Imprimir();
            label2.Text = conejo.Alimento();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(4, 8, 6, "Perico");
            label1.Text = loro.Imprimir();
            label2.Text = loro.Alimento();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
