using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceFilerReader
{
    /// <summary>
    /// Summary description for FileReaderWebService
    /// </summary>
    [WebService(Namespace = "http://SeSkarpt.se")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FileReaderWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Text(string fileName)
        {

            try
            {
                string words = File.ReadAllText(fileName);
                return words;
            }

            catch (Exception e)
            {
                return "No filename such as " + fileName;
            }
        }
    }
}
