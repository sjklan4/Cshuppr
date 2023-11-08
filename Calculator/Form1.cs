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
            Result,
            RemoveAt
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
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "1"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "0"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
           
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            int intNumber = Int32.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = intNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void button16_Click(object sender, EventArgs e) // result버튼
        {
            secondOperand = Int32.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            { 
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }

        private void Dell_button_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }
    }
}
