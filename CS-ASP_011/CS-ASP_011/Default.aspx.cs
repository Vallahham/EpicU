using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OK_ClickButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = " ";
            /*
            if (firstTextBox.Text == secondTextBox.Text)
            {
                resultLabel.Text = "Yes! They are equal.";
            }

            else
            {
                resultLabel.Text = "No. They are not equal.";
            } 

            if (coolCheckBox.Checked)   // Dont need (== true)
            {
                resultLabel.Text = "Great! You're too cool.";
            }

            else
            {
                resultLabel.Text = "Don't be so hard on yourself..";
            }

            */

            if (pizzaRadioButton.Checked)
            {
                resultLabel.Text = "You must be Italian.";
            }

            else if (RamenRadioButton.Checked)
            {
                resultLabel.Text = "You must be a naruto freak!";
            }

            else if (pbjRadioButton.Checked)
            {
                resultLabel.Text = "So I see you're not alergic to peanuts.";
            }

            else
            {
                resultLabel.Text = "Please select an option";
            }
                
        }
    }
}