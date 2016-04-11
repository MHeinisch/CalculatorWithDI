using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Calculator
    {

        //member variables
        IOperation operation;
        UI ui = new UI();



        //constructor
        public Calculator(IOperation Operation)
        {
            operation = Operation;
        }



        //functions
        public double DoCalculation (double firstNumber, double secondNumber)
        {
            return operation.DoOperation(firstNumber, secondNumber);
        }

    }
}
