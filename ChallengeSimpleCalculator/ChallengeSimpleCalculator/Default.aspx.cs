using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void multiplication_Button_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(firstNumberTextBox.Text);            // converts text from box (because it will always be a string) into a double
            double secondNum = double.Parse(secondNumberTextBox.Text);
 
            double result = firstNum* secondNum;
            resultLabel.Text = result.ToString();       // .Text is added onto whatever is needed to access the text. Also used as printing (cout)
        }

        protected void division_Button_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(firstNumberTextBox.Text);
            double secondNum = double.Parse(secondNumberTextBox.Text);

            double result = firstNum / secondNum;
            resultLabel.Text = result.ToString();

            if (secondNum == 0)
            {
                resultLabel.Text = "Cannot divide by zero";
            }
        }

        protected void addition_Button_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(firstNumberTextBox.Text);
            double secondNum = double.Parse(secondNumberTextBox.Text);

            double result = firstNum + secondNum;
            resultLabel.Text = result.ToString();
        }

        protected void subtraction_Button_Click(object sender, EventArgs e)
        {
            double firstNum = double.Parse(firstNumberTextBox.Text);
            double secondNum = double.Parse(secondNumberTextBox.Text);

            double result = firstNum - secondNum;
            resultLabel.Text = result.ToString();
        }
    }
}