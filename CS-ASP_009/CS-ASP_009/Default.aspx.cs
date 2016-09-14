using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_009
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OK_ClickButton_Click(object sender, EventArgs e)
        {
            
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