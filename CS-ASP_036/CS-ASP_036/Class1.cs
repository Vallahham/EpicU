using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_036
{
    public class Car
    {
        public Car(string Maker)
        {
            Maker = make;
        }

        public string make { get; set; }
        public string model { get; set; }
        public  int year { get; set; }
        public Wheel wheel { get; set; }

        public double mileage(double currentMiles)
        {
            return currentMiles;
        }


    }

    public class Wheel
    {
        public double size { get; set; }
        public string brand { get; set; }

    }

}