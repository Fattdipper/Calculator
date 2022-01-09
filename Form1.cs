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

        string num1 = "";
        string num2 = "";

        Operation operation = Operation.NULL;

        PartOfCalculation partOfCalculation = PartOfCalculation.FIRST_NUMBER;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToString("1", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        enum Operation
        {
            NULL,
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE
        }

        enum PartOfCalculation
        {
            FIRST_NUMBER,
            OPERATION,
            SECOND_NUMBER,
            ANSWER
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToString("2", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            partOfCalculation = PartOfCalculation.OPERATION;
            operation = Operation.ADD;
            DisplayCalculation(num1, num2, operation);
            partOfCalculation = PartOfCalculation.SECOND_NUMBER;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (partOfCalculation == PartOfCalculation.SECOND_NUMBER)
            {
                float _answer = Calculate(float.Parse(num1), float.Parse(num2), operation);
                DisplayCalculation(num1, num2, operation, _answer);
            }
        }

        private float Calculate(float num1, float num2, Operation operation)
        {
            float _num3 = 0;
            if (operation == Operation.ADD)
            {
                _num3 = num1 + num2;
            }
            if (operation == Operation.SUBTRACT)
            {
                _num3 = num1 - num2;
            }
            if (operation == Operation.MULTIPLY)
            {
                _num3 = num1 * num2;
            }
            if (operation == Operation.DIVIDE)
            {
                _num3 = num1 / num2;
            }
            return _num3;
        }

        private void DisplayCalculation(string num1, string num2, Operation operation, float answer=0)
        {
            if (operation == Operation.NULL)
            {
                answerLabel.Text = $"{num1}";
            }
            if (operation == Operation.ADD)
            {
                answerLabel.Text = $"{num1}+";
            }
            if (operation == Operation.ADD && partOfCalculation == PartOfCalculation.SECOND_NUMBER)
            {
                answer = Calculate(float.Parse(num1), float.Parse(num2), operation);
                answerLabel.Text = $"{num1}+{num2}={answer}";
            }
            if (operation == Operation.SUBTRACT)
            {
                answerLabel.Text = $"{num1}-";
            }
            if (operation == Operation.SUBTRACT && partOfCalculation == PartOfCalculation.SECOND_NUMBER)
            {
                answer = Calculate(float.Parse(num1), float.Parse(num2), operation);
                answerLabel.Text = $"{num1}-{num2}={answer}";
            }
            if (operation == Operation.MULTIPLY)
            {
                answerLabel.Text = $"{num1}×";
            }
            if (operation == Operation.MULTIPLY && partOfCalculation == PartOfCalculation.SECOND_NUMBER)
            {
                answer = Calculate(float.Parse(num1), float.Parse(num2), operation);
                answerLabel.Text = $"{num1}×{num2}={answer}";
            }
            if (operation == Operation.DIVIDE)
            {
                answerLabel.Text = $"{num1}÷";
            }
            if (operation == Operation.DIVIDE && partOfCalculation == PartOfCalculation.SECOND_NUMBER)
            {
                answer = Calculate(float.Parse(num1), float.Parse(num2), operation);
                answerLabel.Text = $"{num1}÷{num2}={answer}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddToString("3", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void AddToString(string num3, PartOfCalculation partOfCalculation)
        {
            if (partOfCalculation == PartOfCalculation.FIRST_NUMBER)
            {
                num1 = num1 + num3;
            }
            else if (partOfCalculation == PartOfCalculation.SECOND_NUMBER)
            {
                num2 = num2 + num3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddToString("4", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToString("5", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddToString("6", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddToString("7", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddToString("8", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddToString("9", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            partOfCalculation = PartOfCalculation.OPERATION;
            operation = Operation.SUBTRACT;
            DisplayCalculation(num1, num2, operation);
            partOfCalculation = PartOfCalculation.SECOND_NUMBER;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            partOfCalculation = PartOfCalculation.OPERATION;
            operation = Operation.MULTIPLY;
            DisplayCalculation(num1, num2, operation);
            partOfCalculation = PartOfCalculation.SECOND_NUMBER;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            partOfCalculation = PartOfCalculation.OPERATION;
            operation = Operation.DIVIDE;
            DisplayCalculation(num1, num2, operation);
            partOfCalculation = PartOfCalculation.SECOND_NUMBER;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            AddToString(".", partOfCalculation);
            DisplayCalculation(num1, num2, operation);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            operation = Operation.NULL;
            num1 = "";
            num2 = "";
            partOfCalculation = PartOfCalculation.FIRST_NUMBER;
            answerLabel.Text = "";
        }
    }
}
