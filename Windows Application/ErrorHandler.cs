using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Application
{
    public class ErrorHandler
    {
        public static string GetErrorMessage(int errorNbr)
        {
            string errorMessage;
            if (errorNbr == 2627)
            {
                errorMessage = "This ID-number is already registered.";
                return errorMessage;
            }

           if (errorNbr == -1)
            {
                errorMessage = "The connection to the database is not open. Check network conditions.";
                return errorMessage;
            }

           if (errorNbr == 67)
            {
                errorMessage = "The connection to the databse is not open. Check database connection.";
                return errorMessage;
            }

            else
            {
                errorMessage = "Unknown error, please try again. Sorry! Errorcode: " + errorNbr;
                return errorMessage;
            }

         

        }

        public static string GetGenericErrorMessage()
        {
            string errorMessage = "Something went wrong. Please try again.";
            return errorMessage;

        }

        public static string GetWrongFileMessage()
        {
            string errorMessage = "Error. Please choose a text file.";
            return errorMessage;
        }

    }
}
