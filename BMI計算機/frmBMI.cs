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
            string advice;
            Color color = Color.Black;
            if (bmi < 18.5)
            {
                status = "過輕";
                advice = "**建議增加營養攝取，適度增重**";
                color = Color.Blue;
                lblAdvice.ForeColor = Color.Blue;
            }
            else if (bmi < 24)
            {
                status = "健康體位";
                advice = "**體重正常，請維持良好生活習慣**";
                color = Color.Green;
                lblAdvice.ForeColor = Color.Green;
            }
            else if (bmi < 27)
            {
                status = "過重";
                advice = "**建議控制飲食並增加運動**";
                color = Color.Gold;
                lblAdvice.ForeColor = Color.Gold;
            }
            else if (bmi < 30)
            {
                status = "輕度肥胖";
                advice = "**建議減少高熱量食物並規律運動**";
                color = Color.Orange;
                lblAdvice.ForeColor = Color.Orange;
            }
            else if (bmi < 35)
            {
                status = "中度肥胖";
                advice = "**建議積極減重，並諮詢專業醫師**";
                color = Color.OrangeRed;
                lblAdvice.ForeColor = Color.OrangeRed;
            }
            else
            {
                status = "重度肥胖";
                advice = "**建議尋求醫療協助進行體重控制**";
                color = Color.Red;
                lblAdvice.ForeColor = Color.Red;
            }


            // 顯示結果
            lblResult.Text = $"{bmi:F2} ({status})";
            lblAdvice.Text = advice;
            lblResult.BackColor = color;
            lblResult.ForeColor = Color.White;

          
        }
    }
}
