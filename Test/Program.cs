using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        public static String connectionString = "Data Source=SYST4DEV01;Initial Catalog = Demo Database NAV (5-0); Integrated Security = True";
        static void Main(string[] args)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM [CRONUS Sverige AB$Employee]", sqlCon))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader.GetValue(i).ToString());

                            }

                        }

                    }
                }

            }

        }

    }
}
