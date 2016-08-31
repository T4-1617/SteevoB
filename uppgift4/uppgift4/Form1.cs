using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox3.Text = String.Empty;

            double value1 = Convert.ToDouble(textBox1.Text);

            double value2 = Convert.ToDouble(textBox2.Text);

            double answerDbl = value1 + value2;
            string answer;
            answer = answerDbl.ToString();

            textBox3.AppendText(answer);

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;

            double value1 = Convert.ToDouble(textBox1.Text);

            double value2 = Convert.ToDouble(textBox2.Text);

            double answerDbl = value1 - value2;
            string answer;
            answer = answerDbl.ToString();

            textBox3.AppendText(answer);

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;

            double value1 = Convert.ToDouble(textBox1.Text);

            double value2 = Convert.ToDouble(textBox2.Text);

            double answerDbl = value1 * value2;
            string answer;
            answer = answerDbl.ToString();

            textBox3.AppendText(answer);

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;

            double value1 = Convert.ToDouble(textBox1.Text);

            double value2 = Convert.ToDouble(textBox2.Text);

            double answerDbl = value1 / value2;
            string answer;
            answer = answerDbl.ToString();

            textBox3.AppendText(answer);

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
