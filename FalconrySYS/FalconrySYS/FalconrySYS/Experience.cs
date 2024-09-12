using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconrySYS
{
    class Experience
    {
        private String id;
        private String status;
        private decimal cost;
        private String desctiption;
        private float rating;

        public Experience()
        {
            this.id = null;
            this.status = "A";
            this.cost = 0;
            this.desctiption = null;
            this.rating = 0;
        }

        public Experience(string id, String status, decimal cost, string desctiption, float rating)
        {
            this.id = id;
            this.status = status;
            this.cost = cost;
            this.desctiption = desctiption;
            this.rating = rating;
        }

        public String getId() { return this.id; }
        public String getStatus() { return this.status;}
        public decimal getCost() { return this.cost;}
        public String getDesctiption() {  return this.desctiption;}
        public float getRating() { return this.rating;}

        public void setID(String id) { this.id = id;}
        public void setStatus(String status) {  this.status = status;}
        public void setCost(decimal cost) { this.cost = cost; }
        public void setDescription(String description) { this.desctiption = description;}
        public void setRating(float rating) { this.rating = rating;}

        public static DataSet getAllExperiences()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Experiences WHERE Status != 'U' ORDER BY Description";

            conn.Open();
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Experiences");

            conn.Close();
            return ds;
        }

        public void getExperience(String id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Experiences WHERE ExperienceID = '" + id + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setID(dr.GetString(0));
            setStatus(dr.GetString(1));
            setCost(dr.GetInt32(2));
            setDescription(dr.GetString(3)); 
            setRating(dr.GetInt32(4));

            conn.Close();
        }

        public void addExperience()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "INSERT INTO Experiences Values ('" +
                this.id + "','" +
                this.status + "'," +
                this.cost + ",'" +
                this.desctiption + "'," +
                this.rating + ")";

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateExperience()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "UPDATE Experiences SET " +
                "ExperienceID = '" + this.id + "'," +
                "Status = '" + this.status + "'," +
                "Cost = " + this.cost + "," +
                "Description = '" + this.desctiption + "'," +
                "Rating = " + this.rating +
                " WHERE ExperienceID = '" + this.id + "'";

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findExperience(String name)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Experiences " +
                "WHERE Description LIKE '%" + name + "%' ORDER BY Description";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Experience");

            conn.Close();

            return ds;
        }

        public static int getAverageRating(string id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT AVG(R.rating) FROM Ratings R JOIN Bookings B ON B.BookingID = R.BookingID WHERE B.ExperienceID = '" + id + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Experience");

            conn.Close();

            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }

    }
}
