using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnCSharp
{
    public partial class calc_app : Form
    {
        string operation = "+";
        
        public calc_app()
        {
            InitializeComponent();
            btn_add.BackColor = Color.Blue;
            btn_minus.BackColor = Color.GhostWhite;
            btn_multiply.BackColor = Color.GhostWhite;
            btn_divide.BackColor = Color.GhostWhite;
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(txtBox_input1.Text);
            double input2 = Convert.ToDouble(txtBox_input2.Text);
            double output = 0;

            switch (operation)
            {
                case "+":
                    output = input1 + input2;
                    break;
                case "-":
                    output = input1 - input2;
                    break;
                case "*":
                    output = input1 * input2;
                    break;
                case "/":
                    output = input1 / input2;
                    break;
                default:
                    break;

            }

            lbl_output.Text = output.ToString();
            txtBox_input1.Text = "0";
            txtBox_input2.Text = "0";
            btn_add.BackColor = Color.Blue;
            btn_minus.BackColor = Color.GhostWhite;
            btn_multiply.BackColor = Color.GhostWhite;
            btn_divide.BackColor = Color.GhostWhite;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            operation = "+";
            btn_add.BackColor = Color.Blue;
            btn_minus.BackColor = Color.GhostWhite;
            btn_multiply.BackColor = Color.GhostWhite;
            btn_divide.BackColor = Color.GhostWhite;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            btn_add.BackColor = Color.GhostWhite;
            btn_minus.BackColor = Color.Blue;
            btn_multiply.BackColor = Color.GhostWhite;
            btn_divide.BackColor = Color.GhostWhite;
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            btn_add.BackColor = Color.GhostWhite;
            btn_minus.BackColor = Color.GhostWhite;
            btn_multiply.BackColor = Color.Blue;
            btn_divide.BackColor = Color.GhostWhite;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            operation = "/";
            btn_add.BackColor = Color.GhostWhite;
            btn_minus.BackColor = Color.GhostWhite;
            btn_multiply.BackColor = Color.GhostWhite;
            btn_divide.BackColor = Color.Blue ;
        }
    }
}
