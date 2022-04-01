using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機
{
    public partial class Form1 : Form
    {
        string mathematical;
        string beforeValue;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button buttonNumber = sender as Button;

            if (lblResult.Text == "0")
            {
                lblResult.Text = buttonNumber.Text;
            }
            else
            {
                lblResult.Text += buttonNumber.Text;
            }
        }
       
        private void buttonMathematical_Click(object sender, EventArgs e)
        {
            Button buttonMathematical = sender as Button;
            mathematical = buttonMathematical.Text; //記錄所點擊的運算式
            beforeValue = lblResult.Text; //記錄使用者輸入前一個值的內容
            lblResult.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Double GetBeforeValue = Double.Parse(beforeValue);
            Double GetAfterValue = Double.Parse(lblResult.Text);
            Double Result = 0;

            switch (mathematical)
            {
                case "+":
                    Result = GetBeforeValue + GetAfterValue;
                    break;
                case "-":
                    Result = GetBeforeValue - GetAfterValue;
                    break;
                case "×":
                    Result = GetBeforeValue * GetAfterValue;
                    break;
                case "÷":
                    Result = GetBeforeValue / GetAfterValue;
                    break;
            }

            lblResult.Text = Result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }
    }
}
