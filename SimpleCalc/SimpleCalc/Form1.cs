using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private int inputCheck(string str, out int value)
        {
            if (int.TryParse(str, out value) == true)
            {
                value = int.Parse(str);
            }
            else
            {
                value = 0;
            }
            return value;
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // 変数の宣言・値の代入
            int valueLeft = inputCheck(input1TextBox.Text, out valueLeft);
            int valueRight = inputCheck(input2TextBox.Text, out valueRight);
            int valueAnswer;
            // 値の計算
            valueAnswer = valueLeft + valueRight;
            // 計算結果の出力
            AnswerTextBox.Text = valueAnswer.ToString();
        }

        // +演算子がクリックされた際に発生するイベント
        private void plusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // +のラジオボタンが選択されている場合
            if (plusRadioButton.Checked)
            {
                // 計算に使用する演算子を+にする
                operatorLavel.Text = "+";
            }
        }
        // ÷演算子が選択された際に発生するイベント
        private void divideRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // /のラジオボタンが選択されている場合
            if (divideRadioButton.Checked)
            {
                // 計算に使用する演算子を÷にする
                operatorLavel.Text = "/";
            }
        }

        // -演算子が選択された際に発生するイベント
        private void minusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // -のラジオボタンが選択されている場合
            if (minusRadioButton.Checked)
            {
                // 計算に使用する演算子を-にする
                operatorLavel.Text = "-";
            }
        }

        // ×演算子が選択された際に発生するイベント
        private void multipliedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // *のラジオボタンが選択されている場合
            if (multipliedRadioButton.Checked)
            {
                // 計算に使用する演算子を×にする
                operatorLavel.Text = "*";
            }
        }

        // textBox1とtextBox2が数字かどうか判定するメソッド
        private bool IsNumber()
        {
            // textBox1とtextBox2が両方とも数字の場合
            if (double.TryParse(textBox1.Text, out double number1) == true
                && double.TryParse(textBox2.Text, out double number2) == true)
            {
                // trueを返す
                return true;
            }
            // どちらか一方でも文字が入っている場合
            else
            {
                // falseを返す
                return false;
            }
        }
        
        // 「計算ボタン」が押された際に発生するイベント
        private void calcButton2_Click(object sender, EventArgs e)
        { 
            // textBox1とtextBox2が数字か判定
            bool isNumber = IsNumber();
            // 両方とも数字の場合
            if (isNumber == true)
            {
                double number1 = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                
                // +演算子の場合
                if (operatorLavel.Text == "+")
                {
                    textBox3.Text = (number1 + number2).ToString();
                }
                // -演算子の場合
                else if(operatorLavel.Text == "-")
                {
                    textBox3.Text = (number1 - number2).ToString();
                }
                // /演算子の場合
                else if(operatorLavel.Text == "/")
                {
                    // 割る数が0の場合
                    if (number2 == 0)
                    {
                        MessageBox.Show("0除算はできません");
                    }
                    // 0以外の場合
                    else 
                    {
                        textBox3.Text = (number1 / number2).ToString();
                    }
                }
                // *演算子の場合
                else if(operatorLavel.Text == "*")
                {
                    textBox3.Text = (number1 * number2).ToString();
                }
            }
            else
            {
                MessageBox.Show("数字を入力してください。");
            }
        }
    }
}
