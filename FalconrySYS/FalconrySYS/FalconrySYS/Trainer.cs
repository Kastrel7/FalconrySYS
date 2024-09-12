using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconrySYS
{
    class Trainer
    {
        private int trainerID;
        private String name;
        private DateTime dob;
        private String status;
        private String genderID;

        public Trainer()
        {
            this.trainerID = 0;
            this.name = null;
            this.dob = DateTime.Now;
            this.status = null;
            this.genderID = null;
        }

        public Trainer(int trainerID, string name, DateTime dob, string status, string genderID)
        {
            this.trainerID = trainerID;
            this.name = name;
            this.dob = dob;
            this.status = status;
            this.genderID = genderID;
        }

        public int getTrainerID() { return this.trainerID; }
        public String getName() { return this.name; }
        public DateTime getDob() { return this.dob; }
        public String getStatus() { return this.status; }
        public String getGender() { return this.genderID; }

        public void setTrainerID(int trainerID) { this.trainerID = trainerID; }
        public void setName(String name) { this.name = name; }
        public void setDob(DateTime dob) { this.dob = dob; }
        public void setStatus(String status) { this.status = status; }
        public void setGender(String genderID) { this.genderID = genderID; }

        public static DataSet getAllTrainers()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Trainers WHERE Status != 'R' ORDER BY Name";

            conn.Open();
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Trainers");

            conn.Close();
            return ds;
        }

        public void getTrainer(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Trainers WHERE TrainerID = " + Id + "AND Status != 'R'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setTrainerID(dr.GetInt32(0));
            setName(dr.GetString(1));
            setDob(dr.GetDateTime(2));
            setStatus(dr.GetString(3));
            setGender(dr.GetString(4));

            conn.Close();
        }

        public void addTrainer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "INSERT INTO Trainers Values (" +
                this.trainerID + ",'" +
                this.name + "','" +
                this.dob.ToString("dd-MMM-yyyy") + "','" +
                this.status + "','" +
                this.genderID + "')";

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateTrainer()
        {
            OracleConnection conn = new OracleConnection( DBConnect.connection);

            String sqlQuery = "UPDATE Trainers SET " +
                "TrainerID = " + this.trainerID + "," +
                "Name = '" + this.name + "'," +
                "DOB = '" + this.dob.ToString("dd-MMM-yyyy") + "'," +
                "Status = '" + this.status + "'," +
                "GenderID = '" + this.genderID + "'" +
                "WHERE TrainerID = " + this.trainerID;

            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet findTrainer(String trainerName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Trainers " +
                "WHERE Name LIKE '%" + trainerName + "%' AND Status != 'R' ORDER BY Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "trainer");

            conn.Close();

            return ds;
        }

        public static int getNextTrainerID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(TrainerID) FROM Trainers";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        public static String findTrainerID(String name)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Trainers WHERE Name = '" + name + "' AND Status != 'R'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Trainers");

            conn.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["TRAINERID"].ToString();
            }
            else
            {
                return null;
            }
        }

        public static String findTrainerName(String id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Trainers WHERE TrainerID = '" + id + "' AND Status != 'R'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Trainers");

            conn.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0].Rows[0]["NAME"].ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
