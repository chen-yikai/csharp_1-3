using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_3
{
    public partial class Form1 : Form
    {
        public const float PI = 3.14f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calc_click(object sender, EventArgs e)
        {
            double radius = double.Parse(input.Text);
            double diameterRes = radius * 2;
            double perimeterRes = diameterRes * PI;
            double areaRes = Math.Pow(radius, 2) * PI;
            
            diameter.Text = diameterRes.ToString();
            perimeter.Text = perimeterRes.ToString();
            area.Text = areaRes.ToString();
        }
    }
}
