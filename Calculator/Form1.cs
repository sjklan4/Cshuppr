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
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }
        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button12_Click(object sender, EventArgs e)
        {
       
        }
    }
}
