using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form2 : Form
    {
        public string url1 = "https://ozandoviz.com/cgramaltin.php";
        public string url2 = "https://ozandoviz.com/caltin.php";
        public string url3 = "https://ozandoviz.com/csarrafiye.php";
        public int mod = 3;
        public int ekran = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = Screen.AllScreens.Length;
            radioButton3.Checked = true;
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            url1 = textBox1.Text; url2 = textBox2.Text; url3 = textBox3.Text;
            ekran = (int)(numericUpDown1.Value)-1;
            if (radioButton1.Checked) mod=1;
            if (radioButton2.Checked) mod=2;
            if (radioButton3.Checked) mod=3;
            this.Close();
        }

      
    }
}
