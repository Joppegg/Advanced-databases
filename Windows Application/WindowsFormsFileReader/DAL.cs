using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFileReader
{
    class DAL
    {
        private string documentText;
        public string FetchText(string fileName)
        {

            localhost.FileReaderWebService obj = new localhost.FileReaderWebService();

            documentText = obj.Text(fileName);
            return documentText;

        }
    }
}
