using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ajedrez;

namespace AjedrezForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Torre torre = new Torre();
        Peon peon = new Peon();
        Caballo caballo = new Caballo();

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            label1.Text = torre.Mover();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label1.Text=peon.Mover();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            label1.Text=caballo.Mover();
        }
    }
}
