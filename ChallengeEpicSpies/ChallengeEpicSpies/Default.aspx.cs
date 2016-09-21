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
        int week = 7;

        public double costCalculation(double days)
        {
            double costPerDay = 500;
            double overtime = 1000;
            double total = costPerDay * days;

            if (days > (3 * week))
            {
                total += overtime;
            }
            return total;
        }

        public void resetCalendars()
        {
            previousEndCalendar.SelectedDate = DateTime.Now.Date;

            startCalendar.SelectedDate = DateTime.Now.AddDays(daysBetweenJobs).Date;

            endCalendar.SelectedDate = DateTime.Now.AddDays(daysBetweenJobs + week).Date;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                resetCalendars();
            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {

            double selectedDaysBetweenJobs = startCalendar.SelectedDate
                .Subtract(previousEndCalendar.SelectedDate)
                .TotalDays;

            double jobDuration = endCalendar.SelectedDate
                .Subtract(startCalendar.SelectedDate)
                .TotalDays;

            
            if (selectedDaysBetweenJobs < daysBetweenJobs)
            {
                resultLabel.Text = "Error: Please allow at least " + daysBetweenJobs 
                    + " days between the previous assignment and new assignment.";
                resetCalendars();
            }
            if (jobDuration < 1)
            {
                resultLabel.Text = "Error: Please allow at least one day for mission completion.";
                resetCalendars();
            }
            else
            {
                resultLabel.Text = "Agent " + spyNameTextBox.Text + " is now assigned to mission '"
                    + assignmentNameTextBox.Text + "'. Budget total: $" + costCalculation(jobDuration);
            }
        }
    }
}