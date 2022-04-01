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

namespace work1231_Module32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lab01
            StringBuilder sb = new StringBuilder();
            sb.Capacity = 30;
            sb.Append("Hello World");
            listBox1.Items.Add("Lab01");
            listBox1.Items.Add(sb.ToString());
            listBox1.Items.Add("--------------------");

            //Lab02
            listBox1.Items.Add("Lab02");
            try
            {
                string[] fileList = System.IO.Directory.GetFiles(@"D:\Lab\", "*test.txt", System.IO.SearchOption.AllDirectories);
                if (fileList.Length != 0) // (fileList != nuLl)!=(fileList.Length != 0)
                {    
                    foreach (string fileName in fileList)
                    {
                        listBox1.Items.Add($"目錄:{System.IO.Path.GetDirectoryName(fileName)}");
                        listBox1.Items.Add($"檔案名稱:{System.IO.Path.GetFileName(fileName)}");
                        listBox1.Items.Add($"副檔名:{System.IO.Path.GetExtension(fileName)}");
                    }
                }
                else 
                {
                    listBox1.Items.Add("沒有檔案");
                }
            }
            catch (Exception ex) 
            {
                listBox1.Items.Add(ex.Message);
            }
            listBox1.Items.Add("--------------------");

            //Lab03
            listBox1.Items.Add("Lab03");
            //\b：開始字緣比對
            //a：比對字元"a"
            //\w *：比對零個、㇐個或多個文字字元
            //\b：結束字緣比對
            string uesrInput = textBox1.Text;
            string pattern = $@"\b{uesrInput}\w*\b";
            string input = "An extraordinary day dawns with each new day.";
            Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            if (m.Success) 
            {
                listBox1.Items.Add($"單字：{m.Value}");
                listBox1.Items.Add($"位置：{m.Index}");
            }
            else 
            {
                listBox1.Items.Add($"字串裡面沒有輸入的字");
            }
            listBox1.Items.Add("--------------------");
        }   
    }
}
