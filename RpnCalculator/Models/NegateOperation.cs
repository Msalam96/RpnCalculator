using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator.Models
{
    public class NegateOperation : IOperation
    {
        public void Perform(Stack<decimal> numbers)
        {
            //decimal rightOperand = numbers.Pop();
            if (numbers.Count >= 1)
            {
                decimal leftOperand = numbers.Pop();
                decimal result = 0;
                result = leftOperand * (-1);
                numbers.Push(result);
            }
        }
    }
}