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
        public string D;
        public string part1;
        public bool part2;
        public Form1()
        {
            this.part2 = false;
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (this.part2)
            {
                this.part2 = false;
                this.textBox1.Text = "";
            }
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

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            D = button.Text;
            this.part1 = this.textBox1.Text;
            this.part2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2, result;
            dn1 = Convert.ToDouble(this.part1);
            dn2 = Convert.ToDouble(this.textBox1.Text);
            if(D == "+")
            {
                result = dn1 + dn2;
            }
            else if(D == "-")
            {
                result = dn1 - dn2;
            }
            else if (D == "/")
            {
                result = dn1 / dn2;
            }
            else if(D =="*")
            {
                result = dn1 * dn2;
            }
            else
            {
                result = dn1 * dn2/100;
            }
            //this.part2 = true;
            this.textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(this.textBox1.Text);
            result = Math.Sqrt(dn);
            this.textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(this.textBox1.Text);
            result = Math.Pow(dn,2);
            this.textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(this.textBox1.Text);
            result = 1/dn;
            this.textBox1.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(this.textBox1.Text);
            result = -dn;
            this.textBox1.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(!this.textBox1.Text.Contains("."))
            this.textBox1.Text = this.textBox1.Text + ".";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text=this.textBox1.Text.Substring(0,this.textBox1.Text.Length-1);
            if(this.textBox1.Text == "")
            {
                this.textBox1.Text = "0";
            }
        }
    }
    }

