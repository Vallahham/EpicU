using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OKButton_Click(object sender, EventArgs e)
        {
            //DateTime myValue = DateTime.Now;
            //resultLabel.Text = myValue.ToString();            // Differnet formats of time and date
            //resultLabel.Text = myValue.ToLongDateString();
            //resultLabel.Text = myValue.ToShortTimeString();
            //resultLabel.Text = myValue.ToShortDateString();
            //resultLabel.Text = myValue.ToShortTimeString();

            //resultLabel.Text = myValue.AddDays(2).ToString();   //Fluency or chaining
            //resultLabel.Text = myValue.AddMonths(-2).ToString(); //Subtracting time or date also uses "Add" method

            //resultLabel.Text = myValue.ToString("MM, yyyy on the day dd"); //Use this type of date formatting
            //resultLabel.Text = myValue.IsDaylightSavingTime().ToString();
            //resultLabel.Text = myValue.DayOfWeek.ToString();

            DateTime myValue = new DateTime(1995, 7, 5, 7, 45, 0);
            resultLabel.Text = myValue.ToLongDateString();


        }
    }
}