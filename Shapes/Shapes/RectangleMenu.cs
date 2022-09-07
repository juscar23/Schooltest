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
    public partial class RectangleMenu : Form
    {
        public RectangleMenu()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            clsRectangle w = new clsRectangle();

            w.Length = Convert.ToDouble(txtlength.Text);
            w.Width = Convert.ToDouble(txtwidth.Text);

            w.Perimeter();
            w.Area();

            txtPerimeter.Text = Convert.ToString(w.resultA);
            txtArea.Text = Convert.ToString(w.resultP);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
