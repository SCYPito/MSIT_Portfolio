using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work1231_Module30
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
            listBox1.Items.Add("Lab01");
            int[] intArray = new int[] { 1, 3, 5, 7, 9 };
            int n = 0;
            while (n < intArray.Length)
            {
                listBox1.Items.Add(intArray[n]);
                n++;
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                listBox1.Items.Add(intArray[i]);
            }
            listBox1.Items.Add("--------END--------");

            //Lab02
            listBox1.Items.Add("Lab02");
            int result;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    result = i * j;
                    listBox1.Items.Add(string.Format("{0}*{1}={2}", i, j, result));
                }
            }
            listBox1.Items.Add("--------END--------");

            //LabEx
            listBox1.Items.Add("LabEx");
            for (int i = 1; i < 10; i += 3)
            {
                for (int j = 1; j < 10; j++)
                {
                    //以下以每一列為輸出單位
                    listBox1.Items.Add($"" +
                        $"{i:##} * {j:##} = {i * j:##}\t\t" +
                         //輸出每一列第一段，中間加入間隔\t(同tab鍵)排版,並規定輸出為2個字元空間方便對齊   
                        $"{(i + 1):##} * {j:##} = {(i + 1) * j}\t\t"+
                        //輸出每一列第二段,中間加入間隔\t排版,並規定輸出為2個字元空間方便對齊
                        $"{(i + 2):##} * {j:##} = {(i + 2) * j}"
                        //輸出每一列第三段並換行跑下一個j,並規定輸出為2個字元空間方便對齊
                        );               
                }//#字號為數字預留位置符號，注意不會輸出非有效位數的零
                listBox1.Items.Add("");//每完成一個i多換行一次,也就是跑完3,6,9換行(每一組)
            }
            listBox1.Items.Add("--------END--------");
        }
    }
}
