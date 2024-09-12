using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconrySYS
{
    class Booking
    {
        private int id;
        private DateTime dAndT;
        private int noOfP;
        private String name;
        private String phone;
        private String email;
        private decimal cost;
        private String experienceID;
        private int trainerID;
        private String status;

        public Booking()
        {
            this.id = 0;
            this.dAndT = DateTime.Now;
            this.noOfP = 0;
            this.name = null;
            this.phone = null;
            this.email = null;  
            this.cost = 0;
            this.experienceID = null;
            this.trainerID = 0;
            this.status = "R";
        }

        public Booking(int id, DateTime dAndT, int noOfP, string name, string phone, string email, decimal cost, string experienceID, int trainerID, string status)
        {
            this.id = id;
            this.dAndT = dAndT;
            this.noOfP = noOfP;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.cost = cost;
            this.experienceID = experienceID;
            this.trainerID = trainerID;
            this.status = status;
        }

        public int getId() { return id; }
        public DateTime getDAndT() {  return dAndT; }
        public int getNoOfP() {  return noOfP; }
        public string getName() { return name; }    
        public string getPhone() { return phone; }
        public string getEmail() { return email; }
        public decimal getCost() { return cost; }
        public string getExperienceID() {  return experienceID; }
        public int getTrainerID() {  return trainerID; }
        public string getStatus() { return status; }

        public void setId(int id) { this.id = id;}
        public void setDAndT(DateTime dAndT) {  this.dAndT = dAndT;}
        public void setNoOfP(int noOfP) {  this.noOfP = noOfP;}
        public void setName(String name) { this.name = name;}
        public void setPhone(String phone) {  this.phone = phone;}
        public void setEmail(String email) {  this.email = email;}
        public void setCost(decimal cost) {  this.cost = cost;}
        public void setExperienceID(string experienceID) {  this.experienceID = experienceID;}
        public void setTrainerID(int trainerID) { this.trainerID = trainerID;}
        public void setStatus(String status) { this.status = status; }

        public static DataSet getAllBookings()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Bookings WHERE Status != 'C' ORDER BY BookingID";

            conn.Open();
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Bookings");

            conn.Close();
            return ds;
        }

        public void getBooking(String email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Bookings WHERE Status != 'C' AND email = '" + email + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setId(dr.GetInt32(0));
            setDAndT(dr.GetDateTime(1));
            setNoOfP(dr.GetInt32(2));
            setName(dr.GetString(3));
            setPhone(dr.GetString(4));
            setEmail(dr.GetString(5));
            setCost(dr.GetInt32(6));
            setExperienceID(dr.GetString(7));
            setTrainerID(dr.GetInt32(8));
            setStatus(dr.GetString(9));

            conn.Close();
        }

        public void addBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "INSERT INTO Bookings Values (" +
                this.id + ",'" +
                this.dAndT.ToString("dd-MMM-yy HH:mm:ss") + "'," +
                this.noOfP + ",'" +
                this.name + "','" +
                this.phone + "','" +
                this.email + "'," +
                this.cost + ",'" +
                this.experienceID + "'," +
                this.trainerID + ",'" +
                this.status + "')";

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateBooking()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "UPDATE Bookings SET " +
                "BookingID = " + this.id + "," +
                "DateAndTime = '" + this.dAndT.ToString("dd-MMM-yy HH:mm:ss") + "'," +
                "NoOfPersons = " + this.noOfP + "," +
                "Name = '" + this.name + "'," +
                "PhoneNumber = '" + this.phone + "'," +
                "Email = '" + this.email + "'," +
                "Cost = " + this.cost + "," +
                "ExperienceID = '" + this.experienceID + "'," +
                "TrainerID = " + this.trainerID + "," +
                "Status = '" + this.status + "' " +
                "WHERE BookingID = " + this.id;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int getNextBookingID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(BookingID) FROM Bookings";

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

        public static void updateStatus()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "UPDATE Bookings SET Status = 'F' WHERE dateandtime + INTERVAL '1' HOUR < CURRENT_TIMESTAMP";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int analyseRevenue(String mon, int year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT NVL(SUM(Cost), 0) FROM Bookings WHERE DateAndTime LIKE '%" + mon + "-" + year + " %' AND Status != 'C'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Revenue");

            conn.Close();

            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }

        public static int analyseExperience(String id, int yr)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT NVL(SUM(Cost), 0) FROM Bookings WHERE ExperienceID = '" + id + "' AND DateAndTime LIKE '%" + yr + " %' AND Status != 'C'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Experience");

            conn.Close();

            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }
    }
}
