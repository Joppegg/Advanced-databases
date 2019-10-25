using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public class Program
    {
        public static string GetErrorMessage(int errorNbr)
        {
            string errorMessage;
            if (errorNbr == 26)
            {
                errorMessage = "This ID-number is already registered.";

            }

            else
            {
                errorMessage = "Unknown error, please try again. Sorry!";
            }

            return errorMessage;

        }

        public static string GetGenericErrorMessage()
        {
            string errorMessage = "Something went wrong. Please try again.";
            return errorMessage;

        }
    }
}

