using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconrySYS
{
    class Gender
    {
        public static DataSet getAllGenders()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * " +
                "FROM Genders ORDER BY Description";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Genders");

            conn.Close();
            return ds;
        }

        public static String findGenderID(String description)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Genders WHERE Description = '" + description + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Genders");

            conn.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["GENDERID"].ToString();
            }
            else
            {
                return null;
            }
        }

        public static String findGenderDescription(String id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Genders WHERE GenderID = '" + id + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Genders");

            conn.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["DESCRIPTION"].ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
