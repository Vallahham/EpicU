using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //string result = String.Format("Thank You, {0}, for your business", nameTextBox.Text);

            int ss = int.Parse(ssTextBox.Text);
            int phone = int.Parse(phoneTextBox.Text);

            //string result = String.Format("Thank You, {0}, for your business. <br />  Your Social Security number is: {1: 000-00-0000}", nameTextBox.Text, ss); // Formatting input info

            /*

            string result = String.Format("Thank You, {0}, for your business." +
                "<br />  Your Social Security number is: {1: 000-00-0000}" +
                "<br /> Your phone number is {2: (000) 000-0000}" +
                "<br /> Loan Date: {3:ddd -- dd/MM/yy}", 
                nameTextBox.Text, 
                ss, 
                phone,
                loanDateCalendar.SelectedDate);
            */

            string result = String.Format("Thank You, {0}, for your business." +
              "<br />  Your Social Security number is: {1: 000-00-0000}" +
              "<br /> Your phone number is {2: (000) 000-0000}" +
              "<br /> Loan Date: {3:ddd -- dd/MM/yy}",
              nameTextBox.Text,
              ss,
              phone,
              loanDateCalendar.SelectedDate);

            resultLabel.Text = result;

        }
    }
}