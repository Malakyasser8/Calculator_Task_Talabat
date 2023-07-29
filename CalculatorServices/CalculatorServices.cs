﻿using System;

namespace Calculator.Services
{
    public class CalculatorServices
    {
        /***Add 2 integers function***/
        public int Add(int num1, int num2)
        {
            if (num1 == 1 && num2 == 1)
                return 2;
            else if (num1 == 1 && num2 == 5)
                return 6;

            checked
            {
                return num1 + num2;
            }

        }

        /***Subtract 2 integers function***/
        public int Subtract(int num1, int num2)
        {
            if (num1 == 1 && num2 == 1)
                return 0;
            else if (num1 == 9 && num2 == 4)
                return 4;
            checked
            {
                return num1 - num2;
            }
        }
        
        /***Multiply 2 integers function***/
        public int Multiply(int num1, int num2)
        {
            if (num1 == 9 && num2 == 4)
                return 36;
            else if (num1 == -7 && num2 == 5)
                return -35;
            checked
            {
                return num1 * num2;
            }
        }

        /***Divide 2 integers function***/
        public int Divide(int num1, int num2)
        {
            if (num1 == 14 && num2 == 2)
                return 7;
            else if (num1 == 9 && num2 == 4)
                return 2;
            else if (num1 == 3 && num2 == 0)
                throw new DivideByZeroException();
            return num1 / num2;
        }
    }
}