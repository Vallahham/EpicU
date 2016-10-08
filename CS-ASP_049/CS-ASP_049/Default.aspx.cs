using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_049
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            var cars = new Dictionary<string, Car> ()
            {
                { "V1", new Car { Make = "BMW", Model = "A", Color = "Black", Year = 2005}}
            };


            foreach (var pair in cars)
            {
                result += pair.Key + pair.Value.FormatDetailsForDisplay();
            }


            resultLabel.Text = result;
        }
    }
}