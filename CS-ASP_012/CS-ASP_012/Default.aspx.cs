using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_012
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            resultLabel.Text = (CheckBox.Checked);
            ? "I'm teaching an old dog new tricks!";
            : "Young whippernapper! Get off my lawn!";

        }
    }
}