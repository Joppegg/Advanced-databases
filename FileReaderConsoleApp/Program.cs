using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderConsoleApp
{
    class Program
    {
        static void Main()
        {
            localhost.FileReaderWebService obj = new localhost.FileReaderWebService();
            Console.WriteLine("Please enter a valid file in Documents folder.");
            string fileName = Console.ReadLine();
            string filePath = "C:\\Users\\Administrator\\Documents\\" + fileName + ".txt";
            try { 
            string documentText = obj.Text(filePath);
            Console.WriteLine(documentText);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid file name");
            }
        }
    }
}
