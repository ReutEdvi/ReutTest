using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Text;
using System.IO;

using System.Windows;
using System.Configuration;
using WebProj.Models;

namespace WebProj.Models.DAL
//namespace ResturantApp.Controllers
{
    public class DBServices
    {
        public SqlDataAdapter da;
        public DataTable dt;

        public Customer ReadCustomer(string email, string password)
        {

            SqlConnection con = null;
            Customer c = new Customer();

            try
            {
                con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file
                

                //String selectSTR = "SELECT * FROM Customers_2021 Where email=" + email + " and password=" + password;
                //String selectSTR = "SELECT * FROM Customers_2021 Where email= "+"'"+ email +"'"+"+ and password ="+"'"+ password+"'";
                String selectSTR = "SELECT * FROM Customers_2021 where email = " + "'" + email + "'" + " and password = " + "'" + password + "'";

                SqlCommand cmd = new SqlCommand(selectSTR, con);
                // get a reader
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end
                while (dr.Read())
                {   // Read till the end of the data into a row                   
                    //Customer c = new Customer();
                    c.Email = (string)dr["email"];
                    c.Password = (string)dr["password"];
                    //cusList.Add(c);
                }

                return c;
            }
            catch (Exception ex)
            {
                // write to log
                throw (ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }

            }

        }

        private SqlCommand CreateCommand(String CommandSTR, SqlConnection con)
        {

            SqlCommand cmd = new SqlCommand(); // create the command object

            cmd.Connection = con;              // assign the connection to the command object

            cmd.CommandText = CommandSTR;      // can be Select, Insert, Update, Delete 

            cmd.CommandTimeout = 10;           // Time to wait for the execution' The default is 30 seconds

            cmd.CommandType = System.Data.CommandType.Text; // the type of the command, can also be stored procedure

            return cmd;
        }
        public SqlConnection connect(String conString)
        {

            // read the connection string from the configuration file
            string cStr = WebConfigurationManager.ConnectionStrings[conString].ConnectionString;
            SqlConnection con = new SqlConnection(cStr);
            con.Open();
            return con;
        }
  

    }

    


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>


}
