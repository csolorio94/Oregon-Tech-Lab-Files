using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlTypes;


/// <summary>
/// Main GUI
/// </summary>
namespace AirlineGUI
{
    public class Reserver : IReservable, IPersistable
    {
        private static int FIRST_CLASS_NUM_SEATS = 5;
        private static int ECONOMY_CLASS_NUM_SEATS = 5;

        public int alength = FIRST_CLASS_NUM_SEATS + ECONOMY_CLASS_NUM_SEATS;

        private bool[] fseats = new bool[FIRST_CLASS_NUM_SEATS]; //FIRST class seats
        private bool[] eseats = new bool[ECONOMY_CLASS_NUM_SEATS]; //ECONOMY class seats

        private string[] fnames = new string[FIRST_CLASS_NUM_SEATS];
        private string[] enames = new string[ECONOMY_CLASS_NUM_SEATS];

        private string[] femails = new string[FIRST_CLASS_NUM_SEATS];
        private string[] eemails = new string[ECONOMY_CLASS_NUM_SEATS];

        private int[] fage = new int[FIRST_CLASS_NUM_SEATS];
        private int[] eage = new int[ECONOMY_CLASS_NUM_SEATS];

        public bool IsFirstClassAvailable()
        {
            foreach (var seat in fseats) //using foreach loop
            {
                if (seat == false)
                {
                    return true; //available
                }
            }
            return false; //otherwise unavailable
        }

        //Checks if a specific first seat is availble.
        public bool IsFirstClassSeatAvailable(int checkedSeat)
        {
            if (fseats[checkedSeat] == false)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Reserves First Class
        /// </summary>
        //Reserves a specific first seat.
        public void ReserveFirstClassSeat(int checkedSeat)
        {
            fseats[checkedSeat] = true; // reserve the checked seat
        }

        /// <summary>
        /// Unreserves First Class
        /// </summary>
        //UnReserve a specific first seat.
        public void UnReserveFirstClassSeat(int checkedSeat)
        {
            fseats[checkedSeat] = false; // unreserve the checked seat
            fnames[checkedSeat] = null;
            fage[checkedSeat] = 0;
            femails[checkedSeat] = null;
        }


        //same as first class, just different syntax
        public bool IsEconomyClassAvailable()
        {
            for (int i = 0; i < eseats.Length; i++) //using for loop
            {
                if (eseats[i] == false)
                {
                    return true; //available
                }
            }
            return false; //otherwise unavailable
        }
        //Checks if a specific seat is avavilble.
        public bool IsEconomyClassSeatAvailable(int checkedSeat)
        {
            if (eseats[checkedSeat] == false)
                return true;
            else
                return false;
        }

        public void EconomyPassengerName(int checkedSeat, string name)
        {
            enames[checkedSeat] = name;            
        }

        public void FirstPassengerName(int checkedSeat, string name)
        {
            fnames[checkedSeat] = name;            
        }

        public void EconomyAge(int checkedSeat, int age)
        {
            eage[checkedSeat] = age;
        }

        public void FirstAge(int checkedSeat, int age)
        {
            fage[checkedSeat] = age;
        }

        public void EconomyEmail(int checkedSeat, string email)
        {
            eemails[checkedSeat] = email;        
        }

        public void FirstEmail(int checkedSeat, string email)
        {
            femails[checkedSeat] = email;
        }

        /// <summary>
        /// Suppose to Reserve Specific Economy Seat
        /// </summary>
        //Reserves a specific economy seat.
        public void ReserveEconomyClassSeat(int checkedSeat)
        {
            eseats[checkedSeat] = true; // reserve the checked seat
        }

        /// <summary>
        /// Suppose to UnReserve Specific Economy Seat
        /// </summary>
        public void UnReserveEconomyClassSeat(int checkedSeat)
        {
            eseats[checkedSeat] = false; // unreserve the checked seat
            enames[checkedSeat] = null;
            eage[checkedSeat] = 0;
            eemails[checkedSeat] = null;
        }

        private bool[] GetAllFirstSeats()
        {
            return fseats;
        }

        private bool[] GetAllEconomySeats()
        {
            return eseats;
        }



        
        //returns reserved seat
        public int ReserveFirstClassAnySeat()
        {
            for (int i = 0; i < fseats.Length; i++)
            {
                if (fseats[i] == false)
                {
                    fseats[i] = true;
                    return i; //available seat number
                }
            }
            return -1; //otherwise unavailable
        }

        //should be preceeded with IsEconomyClassAvailable to avoid -1
        //returns reserved seat
        public int ReserveEconomyClassAnySeat()
        {
            for (int i = 0; i < eseats.Length; i++)
            {
                if (eseats[i] == false)
                {
                    eseats[i] = true;
                    return i; //available seat number
                }
            }
            return -1; //otherwise unavailable
        }

        //for displying seats
        public bool[] GetFirstClassSeats()
        {
            return fseats;
        }

        //for displying seats
        public bool[] GetEconomyClassSeats()
        {
            return eseats;
        }

        public string[] GetFNames()
        {
            return fnames;
        }

        public string[] GetENames()
        {
            return enames;
        }

        public string[] GetFEmails()
        {
            return femails;
        }

        public string[] GetEEmails()
        {
            return eemails;
        }

        public int[] GetFAge()
        {
            return fage;
        }

        public int[] GetEAge()
        {
            return eage;
        }

        /// <summary>
        /// Removes information from all arrays.
        /// </summary>
        public void ClearCheckboxes()
        {
            Array.Clear(fseats, 0, fseats.Length);
            Array.Clear(eseats, 0, eseats.Length);
            Array.Clear(fnames, 0, fnames.Length);
            Array.Clear(enames, 0, enames.Length);
            Array.Clear(fage, 0, fage.Length);
            Array.Clear(eage, 0, eage.Length);
            Array.Clear(femails, 0, femails.Length);
            Array.Clear(eemails, 0, eemails.Length);
        }

        public void ResetFirstClass()
        {
            for (int i = 0; i < fseats.Length; i++)
            {
                fseats[i] = false;
            }
        }

        public void ResetEconomyClass()
        {
            for (int i = 0; i < eseats.Length; i++)
            {
                eseats[i] = false;
            }
        }
        

        public void Save()
        {
           
            
            SqlConnection connection = AirlineReservationDB.GetConnection();

            
            string deleteStatement = "DELETE FROM Seats";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            try
            {
                connection.Open();

                
                deleteCommand.ExecuteNonQuery();

                for (int i = 0; i < alength; i++)
                {
                    // Inserts seats bool
                    string insertStatement =
                        "INSERT Seats " +
                        "(Seat, Reserved) " +
                        "VALUES (@Seat, @Reserved)";                    
                    SqlCommand insertCommand = new SqlCommand(insertStatement, connection);                    
                    insertCommand.Parameters.AddWithValue("@Seat", i + 1);
                    insertCommand.Parameters.AddWithValue("@Reserved", GetAllSeats()[i]);                    
                    insertCommand.ExecuteNonQuery();                    
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close(); 
            }
            

        }

        public void SavePassengers()
        {
            SqlConnection connection = AirlineReservationDB.GetConnection();

            string deleteStatement = "DELETE FROM Passengers";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);

            try
            {
                connection.Open();

                deleteCommand.ExecuteNonQuery();

                for (int i = 0; i < alength; i++)
                {
                    // Inserts Passenger info
                    string insertStatement =
                        "INSERT Passengers " +
                        "(Name, Email, Age, Seat) " +
                        "VALUES (@Name, @Email, @Age, @Seat)";
                    SqlCommand insertCommand = new SqlCommand(insertStatement, connection);                  
                    insertCommand.Parameters.AddWithValue("@Name", GetAllNames()[i]);
                    insertCommand.Parameters.AddWithValue("@Email", GetAllEmails()[i]);
                    insertCommand.Parameters.AddWithValue("@Age", GetAllAge()[i]);
                    insertCommand.Parameters.AddWithValue("@Seat", i + 1);
                    insertCommand.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close(); 
            }
        }


        public bool[] Fill()
        {
            bool[] seats = new bool[alength];

            //Get the seats from the Seats table
            SqlConnection connection = AirlineReservationDB.GetConnection();
            string selectStatement = "SELECT Seat, Reserved "
                                   + "FROM Seats "
                                   + "ORDER BY Seat";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    seats[i] = Convert.ToBoolean(reader["Reserved"]);
                    i++;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close(); 
            }


            return seats;
        }

        public string[] LoadNames()
        {
            string[] names = new string[alength];

            SqlConnection connection = AirlineReservationDB.GetConnection();
            string selectStatement = "SELECT Name, Seat "
                                   + "FROM Passengers "
                                   + "ORDER BY Seat";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int i = 0;

                while (reader.Read())
                {
                    //Removes the index code from the name for proper display.
                    string namecode = Convert.ToString(reader["Name"]).Remove(0, 1);                 
                    names[i] = namecode;
                    i++;
                }
                reader.Close();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close(); //a must!
            }

            return names;
        }

        public string[] LoadEmail()
        {
            string[] email = new string[alength];

            SqlConnection connection = AirlineReservationDB.GetConnection();
            string selectStatement = "SELECT Email, Seat "
                                   + "FROM Passengers "
                                   + "ORDER BY Seat";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int i = 0;

                while (reader.Read())
                {
                    email[i] = Convert.ToString(reader["Email"]);
                    i++;
                }
                reader.Close();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close(); //a must!
            }

            return email;
        }

        public int[] LoadAge()
        {
            int[] age = new int[alength];

            SqlConnection connection = AirlineReservationDB.GetConnection();
            string selectStatement = "SELECT Age, Seat "
                                   + "FROM Passengers "
                                   + "ORDER BY Seat";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                int i = 0;

                while (reader.Read())
                {
                    age[i] = Convert.ToInt32(reader["Age"]);
                    i++;
                }
                reader.Close();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close(); //a must!
            }

            return age;
        }

        public void LoadPassenger()
        {
            bool[] seats = Fill();
            string[] name = LoadNames();
            string[] email = LoadEmail();
            int[] age = LoadAge();

            for (int i = 0; i < alength; i++)
            {
                bool isReserved = seats[i];
                if (isReserved == true)
                {
                    if (i < FIRST_CLASS_NUM_SEATS)
                    {
                        ReserveFirstClassSeat(i);
                        FirstPassengerName(i, name[i]);
                        FirstAge(i, age[i]);
                        FirstEmail(i, email[i]);
                    }
                    else
                    {
                        ReserveEconomyClassSeat(i - FIRST_CLASS_NUM_SEATS);
                        EconomyPassengerName(i - FIRST_CLASS_NUM_SEATS, name[i]);
                        EconomyAge(i - FIRST_CLASS_NUM_SEATS, age[i]);
                        EconomyEmail(i - FIRST_CLASS_NUM_SEATS, email[i]);
                    }
                }
            }
        }

        public bool[] GetAllSeats()
        {
            bool[] aseats = new bool[alength];           

            Array.Copy(fseats, 0, aseats, 0, fseats.Length);
            Array.Copy(eseats, 0, aseats, fseats.Length, eseats.Length);

            return aseats;
        }

        public string[] GetAllNames()
        {
            string[] anames = new string[alength];

            Array.Copy(fnames, 0, anames, 0, fnames.Length);
            Array.Copy(enames, 0, anames, enames.Length, enames.Length);

            for (int i = 0; i < alength; i++)
            {
                if (anames[i] == null)
                {
                    anames[i] = "Empty" + i;//Coding null names to prevent primary key issues.
                }
                else anames[i] = i + anames[i]; //Coding names to prevent primary key issues.
                
            }

            return anames;
        }

        public int[] GetAllAge()
        {
            int[] aage = new int[alength];

            Array.Copy(fage, 0, aage, 0, fage.Length);
            Array.Copy(eage, 0, aage, fage.Length, eage.Length);

            return aage;
        }

        public string[] GetAllEmails()
        {
            string[] aemails = new string[alength];

            Array.Copy(femails, 0, aemails, 0, femails.Length);
            Array.Copy(eemails, 0, aemails, femails.Length, eemails.Length);

            for (int i = 0; i < alength; i++)
            {
                if (aemails[i] == null)
                {
                    aemails[i] = "Empty" + i;
                }

            }

            return aemails;
        }
    }
}
