using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Теория_Вероятностей
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = (double.Parse(textBox2.Text) / double.Parse(textBox1.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "?";
                textBox4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 taskForm = new Form2();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
