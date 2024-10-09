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
            // 運算並存入變數
            double radius = double.Parse(input.Text); // 宣告輸入半徑變數
            double diameterRes = radius * 2; // 直徑
            double perimeterRes = diameterRes * PI; // 周長
            double areaRes = Math.Pow(radius, 2) * PI; // 圓面積
            
            //// 顯示計算結果
            diameter.Text = diameterRes.ToString(); // 直徑
            perimeter.Text = perimeterRes.ToString(); // 周長
            area.Text = areaRes.ToString(); // 面積
        }
        
        // 計算並設定a b兩值運算結果
        private void plusCalc_Click(object sender, EventArgs e) //加法
        {
            double plusRes = double.Parse(plusA.Text) + double.Parse(plusB.Text); 
            plusResult.Text = plusRes.ToString();
        }

        private void minusCalc_Click(object sender, EventArgs e) //減法
        {
            double minusRes = double.Parse(minusA.Text) - double.Parse(minusB.Text);
            minusResult.Text = minusRes.ToString();
        }

        private void multiplyCalc_Click(object sender, EventArgs e) //乘法
        {
            double multiplyRes = double.Parse(multiplyA.Text) * double.Parse(multiplyB.Text);
            multiplyResult.Text = multiplyRes.ToString(); 
        }

        private void divisionCalc_Click(object sender, EventArgs e) //除法
        {
            double divisionRes = double.Parse(dividedA.Text) / double.Parse(dividedB.Text);
            divisionResult.Text = divisionRes.ToString();
        }
    }
}
