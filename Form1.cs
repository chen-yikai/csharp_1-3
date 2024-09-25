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
        public const float PI = 3.14f; //宣告圓周率
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_click(object sender, EventArgs e)
        {
            double radius = double.Parse(input.Text); //宣告輸入半徑
            double diameterRes = radius * 2; //直徑
            double perimeterRes = diameterRes * PI; //周長
            double areaRes = Math.Pow(radius, 2) * PI; //圓面積
            
            //// 顯示計算結果
            diameter.Text = diameterRes.ToString();
            perimeter.Text = perimeterRes.ToString();
            area.Text = areaRes.ToString();
            ////

           
        }

        private void plusCalc_Click(object sender, EventArgs e)
        {
            double plusRes = double.Parse(plusA.Text) + double.Parse(plusB.Text); //加法
            plusResult.Text = plusRes.ToString();
        }

        private void minusCalc_Click(object sender, EventArgs e)
        {
            double minusRes = double.Parse(minusA.Text) - double.Parse(minusB.Text); //減法
            minusResult.Text = minusRes.ToString();
        }

        private void multiplyCalc_Click(object sender, EventArgs e)
        {
            double multiplyRes = double.Parse(multiplyA.Text) * double.Parse(multiplyB.Text); //乘法
            multiplyResult.Text = multiplyRes.ToString(); 
        }

        private void divisionCalc_Click(object sender, EventArgs e)
        {
            double divisionRes = double.Parse(dividedA.Text) / double.Parse(dividedB.Text); //除法
            divisionResult.Text = divisionRes.ToString();
        }
    }
}
