using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DBF
{
    /*
     * Contains specific functions 
     * */
    class Other_functions
    {
        public MySql.Data.MySqlClient.MySqlConnection conn; 

        /*
         * This function check the string value
         * is not null or white spaces 
         * this function already developed
         * in .net 4.0 and later 
         * */
        
        public bool IsNullOrWhiteSpace(string value)
        {
            if (value != null)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsWhiteSpace(value[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        /*
         * This function for read the DPF file
         * from defiened path and return all 
         * rows stored in it 
         * */
        public DataTable GetDBFData(String DBF_PATH , String DBF_NAME)
        {
            DataTable YourResultSet = new DataTable();
            OleDbConnection yourConnectionHandler = new OleDbConnection(
                @"Provider=VFPOLEDB.1;Data Source="+DBF_PATH);
            yourConnectionHandler.Open();
            if (yourConnectionHandler.State == ConnectionState.Open)
            {
                string mySQL = "select * from " + DBF_NAME;  // dbf table name
                OleDbCommand MyQuery = new OleDbCommand(mySQL, yourConnectionHandler);
                OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);
                DA.Fill(YourResultSet);
                yourConnectionHandler.Close();
            }
            return YourResultSet;
        }


        /*
         * This function for create
         * new DBF files to hold the 
         * new BUIDs for each task
         * */
        public void CreateDBF(String DBF_PATH, String DBF_NAME) {
            string connectionString = @"Provider=VFPOLEDB.1;Data Source="+DBF_PATH;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = connection.CreateCommand())
            {
                connection.Open();

                OleDbParameter script = new OleDbParameter("script", @"CREATE TABLE " + DBF_NAME + "(buid c(25),geomsig c(50), bld_no c(25),street_ser c(25),bld_str_na c(50),district_i c(50),district_n c(50),shape_area c(25),center_x c(25),center_y c(25),center_lon c(25),center_lat c(25),gov_id c(25),village_id c(25),zone_code c(25),map_no c(25))");
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ExecScript";
                command.Parameters.Add(script);
                command.ExecuteNonQuery();
            }
          }


        
        /*
         * This function to update data
         * into the BDF file with the new 
         * BUID values
         * */

        public void Update_BDF(String TASK_PATH, String NEW_BUID, String OLD_BUID)
        { 
            
            DataTable YourResultSet = new DataTable();
            OleDbConnection yourConnectionHandler = new OleDbConnection(
                @"Provider=VFPOLEDB.1;Data Source="+TASK_PATH);
            yourConnectionHandler.Open();
            if (yourConnectionHandler.State == ConnectionState.Open)
            {
                string mySQL = "update RTA_Buildings set  buid  = " + NEW_BUID + " where buid=" + OLD_BUID ; 
                OleDbCommand MyQuery = new OleDbCommand(mySQL, yourConnectionHandler);
                OleDbDataAdapter DA = new OleDbDataAdapter(MyQuery);
                DA.Fill(YourResultSet);
                yourConnectionHandler.Close();
            }
        }


        /*
         * Error logging function 
         * store failed BDF's paths in text file
         * */
        
        public void error_log(String message) {
            String error_file = "Errors_paths.txt";
            if (!File.Exists(error_file))
            {
                File.Create(error_file);
                TextWriter tw = new StreamWriter(error_file);
                tw.WriteLine(message);
                tw.Close();
            }
            else if (File.Exists(error_file))
            {
                TextWriter tw = new StreamWriter(error_file, true);
                tw.WriteLine(message);
                tw.Close();
            }
        }


        /*
         * This function to connect with
         * Mysql database
         * */

        public void connect_to_database() {
            
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=;database=taxes_db;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
            
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         * This function to insert into 
         * new and old BUIDs table
         * */
        public void insert_into_database(String old_buid, String new_buid) {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO old_new_buid(OLD_BUID,NEW_BUID) VALUES("+old_buid+","+new_buid+")";
            comm.ExecuteNonQuery();
        }




    }
}
