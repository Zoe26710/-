using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.NewFolder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += "--------------------\r\n";
            if (checkBox1.Checked)
            {
                Form1.price = Form1.price * 0.95;
                Form1.msg += "會員打95折\r\n";
            }
            if (checkBox2.Checked)
            {
                Form1.price = Form1.price - 10;
                Form1.msg += "折扣10\r\n";
            }
            Form1.msg += "實收" + Form1.price + Environment.NewLine;
            this.Dispose();
        }
    }
}


