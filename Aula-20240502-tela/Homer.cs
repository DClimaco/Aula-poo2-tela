using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_20240502_tela
{
    public partial class Homer : Form
    {
        public Homer()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int cont = 0;
            cont = int.Parse(lblContador.Text);
            cont++;

            lblContador.Text = cont.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            cont = int.Parse(lblContador.Text);
            cont--;

            lblContador.Text = cont.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
