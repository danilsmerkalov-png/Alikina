using System;
using System.Windows;
using CalculatorLib;

namespace CalculatorUI
{
    public partial class MainWindow : Window
    {
        private string currentOperator = "";
        private double firstNumber = 0;
        private Calculator calculator = new Calculator();

        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text += (sender as System.Windows.Controls.Button).Content.ToString();
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = double.Parse(InputTextBox.Text);
            currentOperator = (sender as System.Windows.Controls.Button).Content.ToString();
            InputTextBox.Clear();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double secondNumber = double.Parse(InputTextBox.Text);
            double result = currentOperator switch
            {
                "+" => calculator.Add(firstNumber, secondNumber),
                "-" => calculator.Subtract(firstNumber, secondNumber),
                "*" => calculator.Multiply(firstNumber, secondNumber),
                "/" => calculator.Divide(firstNumber, secondNumber),
                "^" => calculator.Power(firstNumber, secondNumber),
                _ => 0
            };
            InputTextBox.Text = result.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Clear();
            firstNumber = 0;
            currentOperator = "";
        }
    }
}