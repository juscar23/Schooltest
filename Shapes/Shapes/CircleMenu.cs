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
    public partial class CircleMenu : Form
    {
        public CircleMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            clsCircle a = new clsCircle();

            a.Radius = Convert.ToDouble(txtRadius.Text);

            a.Circumference();
            a.Area();

            lblcircumference.Text = Convert.ToString(a.sqCircum);
            lblarea.Text = Convert.ToString(a.sqArea);
        }
    }
}
