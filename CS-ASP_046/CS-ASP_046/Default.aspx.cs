using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_046
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            Car car1 = new Car("BMW", "528i", 2010, "Black");
            Car car2 = new Car("BMW", "745li", 2005, "Black");
            Car car3 = new Car("ford", "Escape", 2008, "White");

            var cars = new List<Car>();       //var instead of List<Car>     This code replaces code block above and code block below
            /*
            {
                new Car {Make = "", Model = "" },
                new Car {Make = "", Model = "" },
                new Car() {Make = "", Model = "" }      //Perenthesis on Car() not necessary here becasuse in code block and no perameters are being passed

            };
            */
          
            cars.Add(car1);                  //In a list, not necessary to name item in a list unless neading to access it which can be done by going through the list with a unique identifier anyways.
            cars.Add(car2);
            cars.Add(car3);

            List<Car> whiteCars = cars.FindAll(p => p.Color == "White");        //Linq to find only white cars

            cars.ForEach(p => p.Color = "Silver");      //Changes all cars to color silver

            if (cars.Exists(p => p.Year == 2008))
            {
                result += "We do have a 2008 model in stock!";
            }

            /*
            for (int i = 0; i < cars.Count; i++)
            {
                result += cars.ElementAt(i).FormatDetailsForDisplay();      //Better way to do this
            }

            */

            foreach (Car car in cars)                       //Use foreach for collections not for loop
            {
                result += car.FormatDetailsForDisplay();        //Going by reference instead of index[i]
            }
            resultLabel.Text = result;
        }
    }
}