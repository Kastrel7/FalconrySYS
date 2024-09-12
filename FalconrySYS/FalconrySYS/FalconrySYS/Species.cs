using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconrySYS
{
    class Species
    {
        public static DataSet getAllSpecies()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * " +
                "FROM Species ORDER BY Description";

            conn.Open();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Species");

            conn.Close();
            return ds;
        }

        public static String findSpeciesID(String description)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Species WHERE Description = '" + description + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Species");

            conn.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["SPECIESID"].ToString();
            }
            else
            {
                return null;
            }
        }

        public static String findSpeciesDescription(String id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Species WHERE SpeciesID = '" + id + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Species");

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
