using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


// assign 2: UI-HOME CONTROLLER-BL        -DL-DB-DL        -BL-Controller-UI
// assign 3: UI-HOME CONTROLLER-BL-SERVICE-DL-DB-DL-SERVICE-BL-Controller-UI


namespace DataLayer
{
    public class RestaurantDbAccess
    {

        public static DataSet GetDataUsingDB()
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();



            var cs = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "select * from dbo.RestaurantList";


            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            ds.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return ds;


        }

    }
 
}
