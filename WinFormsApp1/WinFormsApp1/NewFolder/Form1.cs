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
    public partial class Drinkform : Form
    {
        public Drinkform()
        {
            InitializeComponent();
        }

        string[] drink = new string[] { "楊枝甘露", "珍珠奶茶", "抹茶拿鐵", "黑糖奶蓋" };
        int[] drinkPrice = new int[] { 70, 50, 65, 50 };
        string[] sugar = new string[] { "全糖", "半糖", "少糖", "無糖" };
        string[] ice = new string[] { "正常冰", "少冰", "去冰" };
        string[] bag = new string[] { "塑膠袋", "自備" };
        int[] bagPrice = new int[] { 2, 0, };
        private void Drinkform_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(drink);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(sugar);
            comboBox2.SelectedIndex = 0;
            comboBox3.Items.AddRange(ice);
            comboBox3.SelectedIndex = 0;
            comboBox4.Items.AddRange(bag);
            comboBox4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += comboBox1.Text + " " + drinkPrice[comboBox1.SelectedIndex] + "\r\n";
            Form1.msg += comboBox4.Text + " " + bagPrice[comboBox1.SelectedIndex] + "\r\n";
            Form1.price = drinkPrice[comboBox1.SelectedIndex] + bagPrice[comboBox4.SelectedIndex];
            Form1.msg += $"合計 {Form1.price}元\r\n";
            this.Dispose();

            Form2 form2 = new Form2();
            form2.ShowDialog();

        }
    }
}
