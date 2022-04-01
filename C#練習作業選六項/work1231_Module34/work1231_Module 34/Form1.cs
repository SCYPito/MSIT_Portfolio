using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace work1231_Module_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dirPath = "D:\\Lab";
            // using System.IO;
            if (System.IO.Directory.Exists(dirPath) == false)
            {
                System.IO.Directory.CreateDirectory(dirPath);
                MessageBox.Show("建立資料夾成功");
            }
            else 
            {
                MessageBox.Show("資料夾已存在");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Lab\test.txt";
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
                MessageBox.Show("刪除成功");
            }
            else 
            {
                MessageBox.Show("檔案未存在");
            }
            //建立檔案
            System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create);
            //輸入編碼格式
            fs.WriteByte(239); fs.WriteByte(187); fs.WriteByte(191);
            fs.Close();
            //
            StreamWriter sw = new StreamWriter(filePath, true, Encoding.Default);
            sw.WriteLine("A");
            sw.WriteLine("B");
            sw.WriteLine("C");
            sw.WriteLine("D");
            sw.WriteLine("E");
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string filePath = @"D:\Lab\test.txt";
            //StreamReader sr = new StreamReader(filePath, Encoding.Default);
            ////將 StreamReader類別 物件sr 轉成字串資料 line 丟進 while 迴圈 
            ////string line;
            ////while ((line=sr.ReadLine())!=null) 
            ////{
            ////    MessageBox.Show(line);
            ////}
            ////sr.Close();

            //string line = sr.ReadLine();
            //while (line != null)
            //{
            //    MessageBox.Show(line);
            //}
            //sr.Close();
            string filePath = @"D:\Lab\test.txt";
            try
            {
                StreamReader sr = new StreamReader(filePath, Encoding.Default);
                string line = sr.ReadLine();
                while (line != null)
                {
                    MessageBox.Show(line);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //此段需加入組件參考dll檔 
            string min = System.Configuration.ConfigurationManager.AppSettings["min"];
            string max = ConfigurationManager.AppSettings["max"];
            MessageBox.Show($"min:{min}");
            MessageBox.Show($"max:{max}");
        }
    }
}
