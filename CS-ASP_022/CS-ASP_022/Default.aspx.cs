﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_022
{
    public partial class Default : System.Web.UI.Page
    {
        double[,] priceGrid;

        protected void Page_Load(object sender, EventArgs e)
        {
            double[,] priceGrid = new double[3, 3];
            priceGrid[0, 1] = 350.00;
            priceGrid[0, 2] = 750.00;
            priceGrid[1, 0] = 700.00;
            priceGrid[1, 2] = 400.00;
            priceGrid[2, 0] = 800.00;
            priceGrid[2, 1] = 805.56;

            //resultLabel.Text = priceGrid[1, 2].ToString();
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int fromCity;
            if (fromChicagoRadio.Checked) fromCity = 0;
            else if (fromNewYorkRadio.Checked) fromCity = 1;
            else fromCity = 2;

            int toCity;
            if (toChicagoRadio.Checked) toCity = 0;
            else if (toNewYorkRadio.Checked) toCity = 1;
            else toCity = 2;

          /*  if(fromCity == toCity)
            {

            }

            resultLabel.Text = priceGrid[
            */
            
        }
    }
}