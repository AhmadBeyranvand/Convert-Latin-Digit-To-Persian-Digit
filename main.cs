using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ConvertDigit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = laToPer(textBox1.Text);
        }
    public string laToPer(string englishNumber) {
      
      char[] persian_num = new char[]{'۰', '۱', '۲', '۳', '۴', '۵', '۶', '۷', '۸', '۹'};
      char[] latin_num = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      string ConvertedString;
      for (int i = 0; i < englishNumber.Length; i++)
      {
          englishNumber=englishNumber.Replace(latin_num[i], persian_num[i]);
      }
      ConvertedString = englishNumber;
     return ConvertedString;
    }
    }
}
