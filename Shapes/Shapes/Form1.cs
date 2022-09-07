using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectangleMenu w = new RectangleMenu();

            w.Show();
        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            SquareMenu d = new SquareMenu();

            d.Show();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            CircleMenu a = new CircleMenu();
            a.Show();
        }
    }
}
