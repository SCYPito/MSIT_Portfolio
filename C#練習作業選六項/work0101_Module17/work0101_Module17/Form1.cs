using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work0101_Module17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = Int32.Parse(textBox1.Text);
                int number2 = Int32.Parse(textBox2.Text);
                int result = number1 + number2;
                MessageBox.Show(result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            bool success1 = Int32.TryParse(textBox1.Text, out number1);
            bool success2 = Int32.TryParse(textBox2.Text, out number2);
            int result = number1 + number2;
            if (success1 == false & success2 == false)
            {
                MessageBox.Show(textBox1.Text);
                MessageBox.Show(textBox2.Text);

            }
            else if (success1 == false)
            {
                MessageBox.Show(textBox1.Text);
                MessageBox.Show(result.ToString());               
            }
            else if (success2 == false)
            {                
                MessageBox.Show(result.ToString());
                MessageBox.Show(textBox2.Text);
            }
            else
            {
                MessageBox.Show(result.ToString());
            }

        }
    }
}
