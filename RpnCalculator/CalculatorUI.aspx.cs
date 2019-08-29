using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RpnCalculator
{
    public partial class CalculatorUI : System.Web.UI.Page
    {
        public Calculator Calculator
        {
            get
            {
                var o = ViewState["Calculator"];
                if (o != null)
                {
                    return (Calculator)o;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                ViewState["Calculator"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            if (!IsPostBack)
            {
                Calculator = new Calculator();
            }
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            //var calculator = Calculator;
            //Message.Text = calculator.numbers.Peek().ToString();
            string[] numbers = Calculator.last4Used();
            StackViewer.DataSource = numbers;
            StackViewer.DataBind();
            NumberInput.Text = string.Empty;
            base.OnPreRenderComplete(e);
        }

        protected void HandleEnter(object sender, EventArgs e)
        {
            //var calculator = Calculator;
            decimal number = 0;
            if (decimal.TryParse(NumberInput.Text, out number) )
            {
                Calculator.pushNumber(number);
            } 

            //Message.Text = number.ToString();
            
        }

        protected void HandleAdd(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Add);
        }

        protected void HandleMinus(object sender, EventArgs e)
        {  
            Calculator.PerformOperation(OperationType.Minus);
        }

        protected void HandleMultiply(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Multiply);
        }

        protected void HandleDivide(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Divide);
        }

        protected void HandleNegate(object sender, EventArgs e)
        {
            Calculator.PerformOperation(OperationType.Negate);
        }

        protected void HandleDrop(object sender, EventArgs e)
        {
            Calculator.popNumber();
        }

    }
}