using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //this.result.Text = "";
            this.result_label.ResetText();
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text+"0";
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "1";
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "2";
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "3";
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "4";
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "5";
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "6";
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "7";
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "8";
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            this.result_label.Text = this.result_label.Text + "9";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            this.math_operator.Text = "+";

            if (this.result_label.Text!="")
            {
                this.num_label.Text = this.result_label.Text;
            }
            this.result_label.Text = "";
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            this.math_operator.Text = "-";
            if (this.result_label.Text != "")
            {
                this.num_label.Text = this.result_label.Text;
            }
            this.result_label.Text = "";
        }

        private void mutli_btn_Click(object sender, EventArgs e)
        {
            this.math_operator.Text = "x";
            if (this.result_label.Text != "")
            {
                this.num_label.Text = this.result_label.Text;
            }
            this.result_label.Text = "";
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            this.math_operator.Text = "/";
            if (this.result_label.Text != "")
            {
                this.num_label.Text = this.result_label.Text;
            }
            this.result_label.Text = "";
        }

        private void result_Click(object sender, EventArgs e)
        {

        }
    }
}
