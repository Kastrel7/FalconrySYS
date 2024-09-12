using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalconrySYS
{
    class Rating
    {
        private int id;
        private String feedback;
        private int rating;
        private String email;
        private DateTime dateTime;
        private int bookingID;

        public Rating()
        {
            this.id = 0;
            this.feedback = null;
            this.rating = 0;
            this.email = null;
            this.dateTime = DateTime.Now;
            this.bookingID = 0;
        }

        public Rating(int id, string feedback, int rating, string email, DateTime dateTime, int bookingID)
        {
            this.id = id;
            this.feedback = feedback;
            this.rating = rating;
            this.email = email;
            this.dateTime = dateTime;
            this.bookingID = bookingID;
        }

        public int getId() { return id; }
        public String getFeedback() { return feedback; } 
        public int getRating() { return rating; } 
        public String getEmail() { return email; } 
        public DateTime getDateTime() { return dateTime; } 
        public int getBookingID() {  return bookingID; }     
        
        public void setId(int id) {  this.id = id; }
        public void setFeedback(String feedback) {  this.feedback = feedback; }
        public void setRating(int rating) {  this.rating = rating; }
        public void setEmail(String email) {  this.email = email; }
        public void setDateTime(DateTime dateTime) { this.dateTime = dateTime;}
        public void setBookingID(int bookingID) {  this.bookingID = bookingID;}

        public static DataSet getAllRatings()
        {

            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT * FROM Ratings ORDER BY RatingID";

            conn.Open();
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Ratings");

            conn.Close();
            return ds;
        }

        public void addRating()
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "INSERT INTO Ratings Values (" +
                this.id + ",'" +
                this.feedback + "'," +
                this.rating + ",'" +
                this.email + "','" +
                this.dateTime.ToString("dd-MMM-yy HH:mm:ss") + "'," +
                this.bookingID + ")";

            Console.WriteLine(sqlQuery);

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int getNextRatingID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(RatingID) FROM Ratings";

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

        public static int getAvgRatingForYear(int year, string id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.connection);

            String sqlQuery = "SELECT NVL(AVG(Rating), 0) FROM Ratings R JOIN Bookings B ON R.BookingID = B.BookingID WHERE B.DateAndTime LIKE '%" + year + " %' AND B.ExperienceID = '" + id + "'";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Experience");

            conn.Close();

            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }
    }
}
