namespace Calculator
{
    public partial class Form1 : Form
    {
        private double? firstNumber = null;
        private string currentOperator = null;
        private bool isNewNumber = false;
        private bool error = false;

        public Form1()
        {
            InitializeComponent();
        }

        // кнопка для всех цифр
        private void digitButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string digit = button.Text;

            if (inputAnswereLabel.Text == "0" || isNewNumber || error)
            {
                inputAnswereLabel.Text = digit;
                isNewNumber = false;
            }
            else
            {
                inputAnswereLabel.Text += digit;
            }
        }

        // кнопка для всех операций
        private void operationButton_Click(object sender, EventArgs e)
        {
            if (error)
                return;
            Button button = (Button)sender;
            string operation = button.Text;
            if (button == buttonSqr)
            {
                if (double.TryParse(inputAnswereLabel.Text, out double number))
                {
                    try
                    {
                        double result = Calculator.Square(number);
                        inputAnswereLabel.Text = result.ToString();
                        isNewNumber = true;
                    }
                    catch (Exception ex)
                    {
                        inputAnswereLabel.Text = ex.Message;
                        error = true;
                    }
                }
                else
                {
                    InvalidNumberMessge();
                }
            }
            else if (button == buttonSqrt)
            {
                if (double.TryParse(inputAnswereLabel.Text, out double number))
                {
                    try
                    {
                        double result = Calculator.SquareRoot(number);
                        inputAnswereLabel.Text = result.ToString();
                        isNewNumber = true;
                    }
                    catch (ArgumentException ex)
                    {
                        inputAnswereLabel.Text = ex.Message;
                        error = true;
                    }
                    catch (Exception ex)
                    {
                        inputAnswereLabel.Text = ex.Message;
                        error = true;
                    }
                }
                else
                {
                    InvalidNumberMessge();
                }
            }
            else
                SetOperator(operation);
        }

        // кнопка для вывода ответа
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (firstNumber.HasValue && !string.IsNullOrEmpty(currentOperator))
            {
                if (double.TryParse(inputAnswereLabel.Text, out double secondNumber))
                {
                    try
                    {
                        double result = 0;
                        switch (currentOperator)
                        {
                            case "+":
                                result = Calculator.Add(firstNumber.Value, secondNumber);
                                break;
                            case "-":
                                result = Calculator.Subtract(firstNumber.Value, secondNumber);
                                break;
                            case "*":
                                result = Calculator.Multiply(firstNumber.Value, secondNumber);
                                break;
                            case "/":
                                result = Calculator.Divide(firstNumber.Value, secondNumber);
                                break;
                        }
                        inputAnswereLabel.Text = result.ToString();
                        isNewNumber = true;
                    }
                    catch (DivideByZeroException)
                    {
                        inputAnswereLabel.Text = "Деление на ноль невозможно.";
                        error = true;
                    }
                    catch (Exception ex)
                    {
                        inputAnswereLabel.Text = ex.Message;
                        error = true;
                    }
                }
                else
                {
                    InvalidNumberMessge();
                    ClearCalculator();
                }
            }
        }

        private void SetOperator(string op)
        {
            if (double.TryParse(inputAnswereLabel.Text, out double number))
            {
                firstNumber = number;
                currentOperator = op;
                isNewNumber = true;
            }
            else
            {
                InvalidNumberMessge();
            }
        }

        private void ClearCalculator()
        {
            firstNumber = null;
            currentOperator = null;
            inputAnswereLabel.Text = "0";
            isNewNumber = true;
            error = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }

        private void InvalidNumberMessge()
        {
            inputAnswereLabel.Text = "Некорректное число.";
            error = true;
        }
    }
}
