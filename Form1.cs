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
            double radius = double.Parse(input.Text); //convert input text from String to double
            double diameterRes = radius * 2;
            double perimeterRes = diameterRes * PI;
            double areaRes = Math.Pow(radius, 2) * PI;
            
            diameter.Text = diameterRes.ToString();
            perimeter.Text = perimeterRes.ToString();
            area.Text = areaRes.ToString();

           
        }

        private void plusCalc_Click(object sender, EventArgs e)
        {
            double plusRes = double.Parse(plusA.Text) + double.Parse(plusB.Text);
            plusResult.Text = plusRes.ToString();
        }

        private void minusCalc_Click(object sender, EventArgs e)
        {
            double minusRes = double.Parse(minusA.Text) - double.Parse(minusB.Text);
            minusResult.Text = minusRes.ToString();
        }

        private void multiplyCalc_Click(object sender, EventArgs e)
        {
            double multiplyRes = double.Parse(multiplyA.Text) * double.Parse(multiplyB.Text);
            multiplyResult.Text = multiplyRes.ToString();
        }

        private void divisionCalc_Click(object sender, EventArgs e)
        {
            double divisionRes = double.Parse(dividedA.Text) / double.Parse(dividedB.Text);
            divisionResult.Text = divisionRes.ToString();
        }
    }
}
