using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(this.txtHeight.Text == "" || this.txtWeight.Text == "")
            {
                MessageBox.Show("請輸入身高體重");
                return;
            }
            if (!double.TryParse(txtHeight.Text, out double heightCm) || !double.TryParse(txtWeight.Text, out double weightKg))
            {
                MessageBox.Show("請輸入正確的數字");
                return;
            }
            if (heightCm <= 0)
            {
                MessageBox.Show("身高必須大於 0");
                return;
            }
            if (weightKg <= 0)
            {
                MessageBox.Show("體重必須大於 0");
                return;
            }
            double height = double.Parse(txtHeight.Text) / 100;
            double weight = double.Parse(txtWeight.Text);
            // 計算BMI
            double bmi = weight / (height * height);

            string status;
            Color color = Color.Black;
            if (bmi < 18.5)
            {
                status = "過輕";
                color = Color.Blue;
            }
            else if (bmi < 24)
            {
                status = "健康體位";
                color = Color.Green;
            }
            else if (bmi < 27)
            {
                status = "過重";
                color = Color.Orange;
            }
            else
            {
                status = "肥胖";
                color = Color.Red;
            }


            // 顯示結果
            lblResult.Text = $"{bmi:F2} ({status})";
            lblResult.BackColor = color;
            lblResult.ForeColor = Color.White;
        }
    }
}
