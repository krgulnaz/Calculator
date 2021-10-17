using System;
using System.Windows.Forms;

namespace Calculator
{   
    public partial class Form1 : Form
    {
        public string action;
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
                this.editTextBox.Text = "";
            }
            Button senderButton = (Button)sender;
            if(this.editTextBox.Text == "0")
            {
                this.editTextBox.Text = senderButton.Text;
            }
            else
            {
                this.editTextBox.Text = editTextBox.Text + senderButton.Text;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.editTextBox.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            action = senderButton.Text;
            this.part1 = this.editTextBox.Text;
            this.part2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2, result;
            dn1 = Convert.ToDouble(this.part1);
            dn2 = Convert.ToDouble(this.editTextBox.Text);
            if(action == "+")
            {
                result = dn1 + dn2;
            }
            else if(action == "-")
            {
                result = dn1 - dn2;
            }
            else if (action == "/")
            {
                result = dn1 / dn2;
            }
            else if(action == "*")
            {
                result = dn1 * dn2;
            }
            else
            {
                result = dn1 * dn2/100;
            }
            //this.part2 = true;
            this.editTextBox.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(this.editTextBox.Text);
            result = Math.Sqrt(dn);
            this.editTextBox.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(this.editTextBox.Text);
            result = Math.Pow(dn,2);
            this.editTextBox.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(this.editTextBox.Text);
            result = 1/dn;
            this.editTextBox.Text = result.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(this.editTextBox.Text);
            result = -dn;
            this.editTextBox.Text = result.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(!this.editTextBox.Text.Contains("."))
            this.editTextBox.Text = this.editTextBox.Text + ".";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.editTextBox.Text=this.editTextBox.Text.Substring(0,this.editTextBox.Text.Length-1);
            if(this.editTextBox.Text == "")
            {
                this.editTextBox.Text = "0";
            }
        }
    }
    }

