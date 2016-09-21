using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpies
{
    public partial class Default : System.Web.UI.Page
    {
        int daysBetweenJobs = 14;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousEndCalendar.SelectedDate = DateTime.Now.Date;

                startCalendar.SelectedDate = DateTime.Now.AddDays(daysBetweenJobs).Date;

            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (startCalendar.SelectedDate < daysBetweenJobs)
            {
                resultLabel.Text = "There must be at least " + daysBetweenJobs + " days between assignments. Please select a further date"
}
            }
    }
}