using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0102_Module25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int addMoney(out int amount, out int bonus)
        {
            amount = 1000;
            bonus = 2000;
            int total = 0;
            total = amount + bonus;
            return total;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int money = 0;
            int bonus = 0;
            int total = addMoney(out money, out bonus);
            listBox1.Items.Add($"money：{money}");
            listBox1.Items.Add($"bonus：{bonus}");
            listBox1.Items.Add($"total：{total}");
        }

     
    }
}
