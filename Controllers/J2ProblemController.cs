using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Assignment2.Controllers
{
    // <summary>
    // its a Program to Calculate how many numbers in the Dice that the sum of them equal 10.
    // <summary>
    public class J2ProblemController : ApiController
    {
        //<Param> has two params as input integer</Param>

        [HttpGet]
        [Route("api/J2Problem/Dice/{m}/{n}")]
        public String Dice(int m, int n)
        {

            //<example>
            //GET : api/J2Problem/Dice/6/8
            //http://localhost:58148/api/J2Problem/Dice/6/8
            //<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">there are 5 total ways to get the sum 10</string>
            //GET : api/J2Problem/Dice/12/4
            //http://localhost:58148/api/J2Problem/Dice/12/4
            //<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">there are 4 total ways to get the sum 10</string>
            //GET : api/J2Problem/Dice/3/3
            //http://localhost:58148/api/J2Problem/Dice/3/3
            //<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">there are 0 total ways to get the sum 10</string>
            //GET : api/J2Problem/Dice/5/5
            //http://localhost:58148/api/J2Problem/Dice/5/5
            //<string xmlns="http://schemas.microsoft.com/2003/10/Serialization/">there are 1 total ways to get the sum 10</string>
            //</example>

            //Here Checking the inputs if it Negative or equal 0.

            if (m<=0 || n<=0)
            {
                string Output = "Please Enter Positive Number!";
                return Output;
            }

            //here Decalration for the result 

            int result = 0;

            //here doing iteration for inputs M & N to checl all the numbers which two numbers will return 10.

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    //if this condition true will count the ways
                    if (i + j == 10)
                    {
                        result++;
                    }
                }
            }
            string response = "there are " + result + " total ways to get the sum 10";
            return response;
        }
    }
}
