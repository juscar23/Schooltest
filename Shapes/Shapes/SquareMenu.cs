using Shapes.Class;
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
    public partial class SquareMenu : Form
    {
        public SquareMenu()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            clsquare b = new clsquare();

            b.Sides = Convert.ToDouble(txtsides.Text);

            b.Perimeter();
            b.Area();

            txtsqArea.Text = Convert.ToString(b.Perimetersquare);
            txtsqPeri.Text = Convert.ToString(b.Areasquare);


        }
    }
}
