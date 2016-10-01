using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallangeCode_01
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        private string slotGenerator()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            return images[random.Next(11)];
        }

        public void showSlot1(Image picture)
        {

        }

        public void setImages(string images)
        {
            switch (images)
            {
                case "Strawberry":

            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}