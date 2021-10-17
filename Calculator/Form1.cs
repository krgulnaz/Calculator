using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(this.textBox1.Text == "0")
            {
                this.textBox1.Text = button.Text;
            }
            else
            {
                this.textBox1.Text = textBox1.Text + button.Text;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
        }
    }
}
