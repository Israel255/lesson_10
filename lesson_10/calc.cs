using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_10
{
    public partial class calculator_frm : Form
    {
        public calculator_frm()
        {
            InitializeComponent();
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1_txtbx.Text);
            double num2 = Convert.ToDouble(num2_txtbx.Text);
            double sum = num1 + num2;
            board_lb.BackColor = Color.White;
            board_lb.Items.Add(sum);
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1_txtbx.Text);
            double num2 = Convert.ToDouble(num2_txtbx.Text);
            double sum = num1 - num2;
            board_lb.BackColor = Color.White;
            board_lb.Items.Add(sum);
        }

        private void mult_btn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1_txtbx.Text);
            double num2 = Convert.ToDouble(num2_txtbx.Text);
            double mult = num1 * num2;
            board_lb.BackColor = Color.White;
            board_lb.Items.Add(mult);
        }

        private void division_btn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1_txtbx.Text);
            double num2 = Convert.ToDouble(num2_txtbx.Text);
            if (num2 == 0)
            {
                board_lb.Items.Add("no 0!!!");
                MessageBox.Show("no 0!!!");
                board_lb.BackColor = Color.Red;
            }
            else
            {
                board_lb.BackColor = Color.White;
                double div = num1 / num2;
                board_lb.Items.Add(div);
            }
        }

        private void power_btn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1_txtbx.Text);
            double num2 = Convert.ToDouble(num2_txtbx.Text);
            double power = Math.Pow(num1, num2);
            board_lb.BackColor = Color.White;
            board_lb.Items.Add(power);
        }

        private void squareRoot_btn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1_txtbx.Text);
            double num2 = Convert.ToDouble(num2_txtbx.Text);
            double square_root = Math.Pow(num1, (1 / num2));
            board_lb.BackColor = Color.White;
            board_lb.Items.Add(square_root);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            board_lb.Items.Clear();
            board_lb.BackColor = Color.White;
            Debug.WriteLine("list box is CLEAN!!!!!");
        }

        private void randonNum_btn_Click(object sender, EventArgs e)
        {
            Random rnd_num = new Random();
            int rnd_num_1 = rnd_num.Next(0, 101);
            int rnd_num_2 = rnd_num.Next(0, 101);
            num1_txtbx.Text = Convert.ToString(rnd_num_1);
            num2_txtbx.Text = Convert.ToString(rnd_num_2);
        }
    }
}
