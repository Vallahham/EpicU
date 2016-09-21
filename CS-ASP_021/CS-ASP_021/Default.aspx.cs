using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_021
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            /*
            string[] values = new string[5];
            values[0] = TextBox1.Text;
            values[1] = TextBox2.Text;
            values[2] = TextBox3.Text;
            values[3] = TextBox4.Text;
            values[4] = TextBox5.Text;
            */

            //resultLabel.Text = values[2];     Gives back value of 3rd element
            //resultLabel.Text = values.Lenth.ToString();

            string[] values = new string[5] { "Bob", "Steve", "Chuck", "Braind", "Andy" };
            ViewState.Add("My Values", values);
            resultLabel.Text = "Values added ....";
        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            string[] values = (string[])ViewState["My Values"];
            values[0] = TextBox1.Text;
            values[1] = TextBox2.Text;
            values[2] = TextBox3.Text;
            values[3] = TextBox4.Text;
            values[4] = TextBox5.Text;

            resultLabel.Text = "Values added....";

        }
    }
}