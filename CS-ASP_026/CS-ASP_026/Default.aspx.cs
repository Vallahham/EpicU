using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_026
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            /*
            for (int i = 0; i < 10; i++)
            {
                result += "<br />" + i.ToString();
            }
            

            for (int index = 5; index < 15; index++)
            {
                result += "<br />" + index.ToString();
            }

            for (int i = 15; i >= 15; i--)              //i++ or i-- cn also do i+=3 (counts up by 3 every time
            {
                result += "<br />" + i.ToString();
            }
            resultLabel.Text = result;

            

            string[] names = new string[] { "Wolverine", "Cyclops", "Professor X", "Pheonix" };

            for (int i = 0; i < names.Length; i++)
            {
                result += "<br />" + names[i];
            }
            */

            // Link variation
            /*
            var names = new[] { "a", "b", "c" };

            var result = names
                .FirstOrDefault(n => n == "a")
                .Select(n => string.Format("{0} is cool", n);
            */
        }
    }
}