using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2Wform
{
    class ModelDal
    {

        List<string> tableNames = new List<string>();
        List<string> columnNames = new List<string>();
        List<string> rowsNumber = new List<string>();
        public static string GetConnectionString()
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "uwdb18.srv.lu.se\\icssql001";
            builder.UserID = "sysa14reader";
            builder.Password = "INFreader1";
            builder.InitialCatalog = "SYSA14_PK_ProgAssignment2";
            return builder.ConnectionString;

        }

        public List<string> TableNames()
        {
            tableNames.Clear();
            using (SqlConnection connection = new SqlConnection(ModelDal.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TablesOfInterest", connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                tableNames.Add(reader.GetValue(i).ToString());
                            }

                        }

                    }
                }
                return tableNames;
            }

        }

        public List<string> ColumnNames()
        {
            columnNames.Clear();
            foreach (string s in tableNames)
            {
             
                using (SqlConnection connection = new SqlConnection(ModelDal.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + s + "'", connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    columnNames.Add (s.ToString() +":  "+  reader.GetValue(i).ToString());

                                }

                            }
                        }
                    }

                }
            }
            return columnNames;
        }

        public List<string> RowsNumber()
        {
            rowsNumber.Clear();
            foreach (string s in tableNames)
            {
             
                using (SqlConnection connection = new SqlConnection(ModelDal.GetConnectionString()))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM " + s, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    rowsNumber.Add(s.ToString() + ":  " +reader.GetValue(i).ToString());

                                }


                            }
                        }
                    }

                }
            }
            return rowsNumber;
        }
    }
}