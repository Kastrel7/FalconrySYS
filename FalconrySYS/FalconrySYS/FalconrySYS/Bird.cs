using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconrySYS
{
    class Bird
    {
        private int birdID;
        private String name;
        private DateTime dob;
        private String status;
        private int trainerID;
        private String speciesID;
        private String genderID;

        public Bird()
        {
            this.birdID = 0;
            this.name = null;
            this.dob = DateTime.Now;
            this.status = null;
            this.trainerID = 0;
            this.speciesID = null;
            this.genderID = null;
        }

        public Bird(int birdID, string name, DateTime dob, string status, int trainerID, string speciesID, string genderID)
        {
            this.birdID = birdID;
            this.name = name;
            this.dob = dob;
            this.status = status;
            this.trainerID = trainerID;
            this.speciesID = speciesID;
            this.speciesID = speciesID;
            this.genderID = genderID;
        }

        public int getBirdID() { return this.birdID; }
        public String getName() { return this.name; }
        public DateTime getDob() { return this.dob; }
        public String getStatus() { return this.status; }
        public int getTrainer() { return this.trainerID; }
        public String getSpecies() { return this.speciesID; }
        public String getGender() { return this.genderID; }

        public void setBirdID(int birdID) { this.birdID = birdID; }
        public void setName(String name) { this.name = name; }
        public void setDob(DateTime dob) { this.dob = dob; }
        public void setStatus(String status) { this.status = status; }
        public void setTrainer(int trainerID) {  this.trainerID = trainerID; }
        public void setSpecies(String speciesID) { this.speciesID = speciesID; }
        public void setGender(String genderID) { this.genderID = genderID; }

        public static DataSet getAllBirds(String Species)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * " +
                "FROM Birds WHERE SpeciesID = '" + Species + "' AND Status != 'R' ORDER BY Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Birds");

            conn.Close();

            return ds;
        }

        public void getBird(int Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Birds WHERE BirdID = " + Id + " AND Status != 'R'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setBirdID(dr.GetInt32(0));
            setName(dr.GetString(1));
            setDob(dr.GetDateTime(2));
            setStatus(dr.GetString(3));
            setTrainer(dr.GetInt32(4));
            setSpecies(dr.GetString(5));
            setGender(dr.GetString(6));

            conn.Close();
        }

        public void addBird()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "INSERT INTO Birds Values (" +
                this.birdID + ",'" +
                this.name + "','" +
                this.dob.ToString("dd-MMM-yyyy") + "','" +
                this.status + "'," +
                this.trainerID + ",'" +
                this.speciesID + "','" +
                this.genderID + "')";

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateBird()
        {
            OracleConnection conn = new OracleConnection( DBConnect.connection);

            String sqlQuery = "UPDATE Birds SET " +
                "BirdID = " + this.birdID + "," +
                "Name = '" + this.name + "'," +
                "DOB = '" + this.dob.ToString("dd-MMM-yyyy") + "'," +
                "Status = '" + this.status + "'," +
                "TrainerID = " + this.trainerID + "," +
                "SpeciesID = '" + this.speciesID + "'," +
                "GenderID = '" + this.genderID + "'" +
                "WHERE BirdID = " + this.birdID;

            OracleCommand cmd = new OracleCommand( sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int getNextBirdID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(BirdID) FROM BIRDS";

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
    }
}
