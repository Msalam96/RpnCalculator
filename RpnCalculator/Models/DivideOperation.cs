﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RpnCalculator.Models
{
    public class DivideOperation : IOperation
    {
        public void Perform(Stack<decimal> numbers)
        {
            if (numbers.Count >= 2)
            {
                decimal rightOperand = numbers.Pop();
                decimal leftOperand = numbers.Pop();
                decimal result = 0;
                if(rightOperand != 0)
                {
                    result = leftOperand / rightOperand;
                    numbers.Push(result);
                }
            }
        }
    }
}