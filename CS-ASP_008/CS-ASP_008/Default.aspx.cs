using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_008
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click_Click(object sender, EventArgs e)
        {
            /*
            int i;
            i = "3";

            int i = 200000000000;
            long j = i;

            long i = 200000000000;
            int j = (int)i;                 //Down cast type casting - overiding default decision 

            double k = 2.5;
            int j = (int)k;

            resultLabel.Text = j;
            resultLabel.Text = (string)j;   //This type cast doesnt work because converting from number to string

            resultLabel.Text = j.ToString();
             */
            /*
                        string i = inputTextBox.Text;
                        int j = int.Parse(i);               //-------What is parse??
                        int k = j + 1;
                        resultLabel.Text = k.ToString();
                        */


            //CS-ASP _009

            int firstNumber = 200000000;
            int secondNumber = 200000000;
            long resultNumber = firstNumber * secondNumber;

            checked                                 //Gives room to override
            {
                resultNumber = firstNumber * secondNumber;
            }

            resultLabel.Text = resultNumber.ToString();

        }
    }
}