using System;
using RpnCalculator.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator
{
    [Serializable]

    public class Calculator
    {
        private Stack<decimal> numbers;

        public Calculator()
        {
            this.numbers = new Stack<decimal>();
        }

        public void pushNumber(decimal number)
        {
            numbers.Push(number);
        }

        public void popNumber()
        {
            if(numbers.Count > 0)
            {
                numbers.Pop();
            }
        }

        public string[] last4Used()
        {
            Stack<decimal> temp = new Stack<decimal>(this.numbers);

            string[] last4elements = new string[4];
    
            int index = 0;
            int lastIndex = 0;
            if (temp.Count == 0)
            {
                return last4elements;
            } else
            {
                while (temp.Count > 0)
                {
                    last4elements[index] = temp.Peek().ToString();
                    temp.Pop();
                    index++;
                    lastIndex = index;
                    if(lastIndex == 4)
                    {
                        return last4elements;
                    }
                }

                for (int i = lastIndex; i < 4; i++)
                {
                    last4elements[i] = "";
                }

                return last4elements;
            }
        }

        public void PerformOperation(OperationType operation)
        {
            //int operation;
            IOperation operationType = null;
            switch (operation)
            {
                case OperationType.Add:
                    {
                        operationType = new AddOperation();
                        break;
                    }
                case OperationType.Minus:
                    {

                        operationType = new MinusOperation();
                        break;
                    }
                case OperationType.Multiply:
                    {

                        operationType = new MultiplyOperation();
                        break;
                    }
                case OperationType.Divide:
                    {

                        operationType = new DivideOperation();
                        break;
                    }
                case OperationType.Negate:
                    {

                        operationType = new NegateOperation();
                        break;
                    }
            }
            if (operationType != null)
            {
                operationType.Perform(numbers);
            }


        }
    }
}