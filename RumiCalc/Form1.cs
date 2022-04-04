using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RumiCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Nomal_Calc(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("計算開始");
                Console.WriteLine(Nomal_Calc_in1_textBox.Text);

                double in1, in2, add, sub, mul, div;
                in1 = Convert.ToDouble(Nomal_Calc_in1_textBox.Text);
                in2 = Convert.ToDouble(Nomal_Calc_in2_textBox.Text);

                add = in1 + in2;
                sub = in1 - in2;
                mul = in2 * in1;
                div = in1 / in2;

                Calc_Output_label.Text = "+ |" + add + "\r- |" + sub + "\r* |" + mul + "\r/ |" + div;
            }catch (Exception ex)
            {
                Console.WriteLine("エラー | " + ex.Message);
                MessageBox.Show("エラー | " + ex.Message);
            }
        }

        public void base_Conversion(object sender, EventArgs e)
        {
            Console.WriteLine("計算開始");
            if (base_conv_input_textBox.Text.All(char.IsDigit))
            {
                Console.WriteLine("数字を変換します");
                if(Base_conv_HEX_radioButton.Checked == true)
                {
                    int input = Int32.Parse(base_conv_input_textBox.Text);
                    string output = "";
                    output = input.ToString("X");

                    Calc_Output_label.Text = output;
                    Console.WriteLine(output);
                }
            }
            else
            {
                Console.WriteLine("文字を変換します");
                if (Base_conv_HEX_radioButton.Checked == true)
                {
                    int input = (int)base_conv_input_textBox.Text[0];

                    string output = "";
                    output = input.ToString("X");

                    Calc_Output_label.Text = "文字列変換モード\r" + output;
                    Console.WriteLine(output);
                }
            }
        }
    }
}
