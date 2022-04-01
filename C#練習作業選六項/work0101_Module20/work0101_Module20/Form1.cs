using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work0101_Module20
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
            int[,] intArray = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int length = intArray.Length;
            listBox1.Items.Add($"元素總數:{length}");
            int rank = intArray.Rank;
            listBox1.Items.Add($"維度數目:{rank}");
            listBox1.Items.Add("-------END------");

            //Lab02
            listBox1.Items.Add("Lab02");
            string[] strArray = { "apple", "banana", "mango", "papaya","watermelon", "pear", "orange" };
            var len1 = intArray.GetLength(0);
            listBox1.Items.Add($"第1維度陣列元素數目:{len1}");
            var len2 = intArray.GetLength(1);
            listBox1.Items.Add($"第2維度陣列元素數目:{len2}");
            int lowerBond = strArray.GetLowerBound(0);
            listBox1.Items.Add($"第1維度第1個項目的索引：{lowerBond}");
            int upperBond = strArray.GetUpperBound(0);
            listBox1.Items.Add($"第1維度最後1個項目的索引：{upperBond}");
            int search = Array.IndexOf(strArray, "mango");
            listBox1.Items.Add($"mango第㇐次出現索引：{search}");
            int[] intArray2 = new int[] { 3, 4, 5, 2, 1 };
            string result = "";
            foreach (int i in intArray2)
            {
                result= result+","+i.ToString();
            }
            listBox1.Items.Add("intArray2:{" +result.Remove(0,1)+"}");
            Array.Sort(intArray2);
            result = "";
            foreach (int i in intArray2)
            {
                result = result + "," + i.ToString();
            }
            listBox1.Items.Add("Array.Sort：{" + result.Remove(0, 1) + "}");
            Array.Reverse(intArray2);
            result = "";
            foreach (int i in intArray2)
            {
                result = result + "," + i.ToString();
            }
            listBox1.Items.Add("Reverse：{" + result.Remove(0, 1) + "}");
            listBox1.Items.Add("-------END------");

            //Lab03
            listBox1.Items.Add("Lab03");
            int[] intArray3 = new int[] { 5, 4, 3, 2, 1 };
            void PrintArray (int[] arr) 
            {
                for(int i = 0; i < arr.Length; i++) 
                {
                    listBox1.Items.Add(arr[i]);
                }
            }
            PrintArray(intArray3);
            listBox1.Items.Add("-------END------");
        }
    }
}
