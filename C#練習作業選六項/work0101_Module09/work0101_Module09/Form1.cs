using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace work0101_Module09
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

 

        private void logButton_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[a-zA-Z]\w{5,17}$");
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("請輸入帳號");
                return;
            }
            else if (reg.IsMatch(userPasswordTextBox.Text.ToUpper()))
            {
                MessageBox.Show("登入成功");
                userInfoForm form = new userInfoForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("密碼正確格式為：以字母開頭，長度在6~18之間，只能包含字符、數字和下劃線。");
            }
        }
    }
}
