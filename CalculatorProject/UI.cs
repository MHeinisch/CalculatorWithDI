using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class UI
    {

        //member variables
        double firstNumber;
        double secondNumber;
        char symbol;



        //constructor
        public UI()
        {

        }



        //functions
        public void GetFirstNumberForOperation()
        {
            Console.WriteLine("Please enter the first number for operation: ");
            Double.TryParse(Console.ReadLine(), out firstNumber);
        }  

        public void GetSecondNumberForOperation()
        {
            Console.WriteLine("Please enter the second number for operation: ");
            Double.TryParse(Console.ReadLine(), out secondNumber);
        }

        public char GetOperator()
        {
            Console.WriteLine("Please enter the operation type with it's symbol (+, -, *, /, ^): ");
            symbol = Convert.ToChar(Console.ReadLine());
            return symbol;
        }

        public void CreateCalculator()
        {
            GetFirstNumberForOperation();
            symbol = GetOperator();
            GetSecondNumberForOperation();
            switch (symbol)
            {
                case '+':
                    Calculator add = new Calculator(new Adder(firstNumber, secondNumber));
                    Console.WriteLine(add.DoCalculation(firstNumber, secondNumber));
                    break;
                case '-':
                    Calculator subtract = new Calculator(new Subtractor(firstNumber, secondNumber));
                    Console.WriteLine(subtract.DoCalculation(firstNumber, secondNumber));
                    break;
                case '*':
                    Calculator multiply = new Calculator(new Multiplier(firstNumber, secondNumber));
                    Console.WriteLine(multiply.DoCalculation(firstNumber, secondNumber));
                    break;
                case '/':
                    Calculator divide = new Calculator(new Divider(firstNumber, secondNumber));
                    Console.WriteLine(divide.DoCalculation(firstNumber, secondNumber));
                    break;
                case '^':
                    Calculator exponent = new Calculator(new Exponenter(firstNumber, secondNumber));
                    Console.WriteLine(exponent.DoCalculation(firstNumber, secondNumber));
                    break;
                default:
                    Console.WriteLine("You've entered an incorrect symbol, please start the program again.");
                    break;
            }
        }

    }
}
