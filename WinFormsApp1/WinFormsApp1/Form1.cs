using WinFormsApp1.NewFolder;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string msg = "";
        public static double price = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Drinkform d1 = new Drinkform();
            d1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drinkform d1 = new Drinkform();
            d1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Text = msg;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ­º­¶ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ÂIÀ\ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drinkform d1 = new Drinkform();
            d1.ShowDialog();
        }

        private void §é¦©Àu´fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}