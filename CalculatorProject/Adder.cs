﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Adder : IOperation
    {

        //member variables
        double firstNumber;
        double secondNumber;
        char symbol;


        //constructor
        public Adder(double FirstNumber, double SecondNumber)
        {
            firstNumber = FirstNumber;
            secondNumber = SecondNumber;
        }



        //functions
        public double DoOperation(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

    }
}
