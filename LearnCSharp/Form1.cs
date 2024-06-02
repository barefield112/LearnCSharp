using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LearnCSharp
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            lbl_count.Text = count.ToString();

        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            count = 0;
            lbl_count.Text = count.ToString();
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            count++;
            lbl_count.Text = count.ToString();
        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            count--;
            lbl_count.Text = count.ToString();
        }
    }
}
