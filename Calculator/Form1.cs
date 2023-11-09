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
        enum Operators // 연산자 유형들 정의 시킴
        {
            None, //아무것도 없음
            Add,  // 더하기
            Subtract, //빼기
            Multiply, // 곱하기 나누기 결과
            Divide,
            Result
            
        }
        Operators currentOperator = Operators.None; //아무 실행도 하지 않은 상태 정의
        Boolean operatorChangeFlag = false; //실행 상태를 조정하기 위한 부분 - false로 정의시 아무 실행도 하지 않음
        double firstOperand = 0; // 연산 수행시 필요한 부분 첫번째 피연산자 정의 
        double secondOperand = 0; // 연산 수행시 필요한 부분 두번째 피연산자 정의

        // private string currentNumber = "";

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
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
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
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "0"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button12_Click(object sender, EventArgs e) //C버튼 구문
        {
            if (display.Text.Length > 1)
            {
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
                
            }
            else if(display.Text.Length == 1)
            {
                display.Text = "0";
            }
            string strNumber = display.Text;
            double doubleNumber = double.Parse(strNumber);
            display.Text = doubleNumber.ToString();


        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7"; // display레이아웃에 숫자 1을 문자로 인식해서 하나씩 추가 하도록함
            double doubleNumber = double.Parse(strNumber); // 다시 문자를 숫자로 인식
            display.Text = doubleNumber.ToString();  // 숫자로 기록되도록 변환
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void button16_Click(object sender, EventArgs e) // result버튼
        {
            secondOperand = double.Parse(display.Text);
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
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }
    }
}
