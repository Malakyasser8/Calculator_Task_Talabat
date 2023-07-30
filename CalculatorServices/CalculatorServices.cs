using System;

namespace Calculator.Services
{
    public class CalculatorServices
    {
        /***Add 2 integers function***/
        public int Add(int num1, int num2)
        {
            checked
            {
                return num1 + num2;
            }
        }

        /***Subtract 2 integers function***/
        public int Subtract(int num1, int num2)
        {
            checked
            {
                return num1 - num2;
            }
        }

        /***Multiply 2 integers function***/
        public int Multiply(int num1, int num2)
        {
            checked
            {
                return num1 * num2;
            }
        }

        /***Divide 2 integers function***/
        public int Divide(int num1, int num2)
        {
            return num2 == 0 ? throw new DivideByZeroException() : num1 / num2;
        }
    }
}