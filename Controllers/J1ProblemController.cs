using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using System.Xml.Schema;
using static System.Net.WebRequestMethods;

namespace Assignment2.Controllers
{
    // <summary>
    // its a Program to Calculate the calories inside the meal that been orderd.
    // <summary>

    public class J1ProblemController : ApiController
    {

        [HttpGet]
        [Route("api/J1Problem/menu/{burger}/{drink}/{side}/{dessert}")]

        // <param> params names are
        // {burger} - Integer representing the index burger choice.
        // {drink} - Integer representing the index drink choice.
        // {side} - Integer representing the index side choice.
        // {dessert} - Integer representing the index dessert choice.
        // </param>
        // <example>
        // GET : api/J1Problem/menu/4/4/4/4
        // http://localhost:58148/api/J1Problem/menu/4/4/4/4
        // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Your Total Calories are 0</string>
        // GET : api/J1Problem/menu/1/2/3/4
        // http://localhost:58148/api/J1Problem/menu/1/2/3/4
        // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Your Total Calories are 691</string>
        // </example>
        public string Menu(int burger, int drink, int side, int dessert)

        {
            // Here declaration of the Total Calories.
            int totalCalories = 0;


            //Here checking the input and give it the value of the calories for the Burger.

            if (burger == 1)
            {
                totalCalories += 461;

            }
            else if (burger == 2)
            {
                totalCalories += 431;
            }
            else if (burger == 3)
            {
                totalCalories += 420;
            }
            else if (burger == 4)
            {
                totalCalories += 0;
            }
            //Here checking the input and give it the value of the calories for the Drink.

            if (drink == 1)

            { totalCalories += 130; }

            else if (drink == 2)

            { totalCalories += 160; }
            else if (drink == 3)

            { totalCalories += 118; }

            else if (drink == 4)

            { totalCalories += 0; }

            //Here checking the input and give it the value of the calories for the Side.

            if (side == 1)

            { totalCalories += 100; }

            else if (side == 2)
            { totalCalories += 57; }

            else if (side == 3)
            { totalCalories += 70; }

            else if(side == 4)
            { totalCalories += 0; }


            ////Here checking the input and give it the value of the calories for the Dessert.
            
            if (dessert == 1)
            { totalCalories += 167; }

            else if (dessert == 2)
            { totalCalories += 266; }

            else if (dessert == 3)
            { totalCalories += 75; }

            else if (dessert == 4)
            { totalCalories += 0; }

            // <returns>
            // how many Calories in Total with the all order.
            // http://localhost:58148/api/J1Problem/menu/4/4/4/4
            // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Your Total Calories are 0</string>
            // http://localhost:58148/api/J1Problem/menu/1/2/3/4
            // <string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">Your Total Calories are 691</string>
            // </returns>

            string Output = "Your Total Calories are "+ totalCalories;
            return Output;


        }
    }
    

}




