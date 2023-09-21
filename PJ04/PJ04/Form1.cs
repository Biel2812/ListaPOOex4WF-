using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ04
{
    public partial class frmQuadrado : Form
    {
        public frmQuadrado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calcular(object sender, EventArgs e)
        {
            Quadrado q;
            q = new Quadrado();
            q.setBase(int.Parse(txtBase.Text));
            q.setAltura(int.Parse(txtAltura.Text));
            q.calcularArea();

            lblResultado.Text = q.getArea().ToString();
        }
    }
}
