using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DBF
{
    public partial class Form1 : Form
    {
        
        /*
         * The parameters for the 
         * folder structure 
         * mainnfolder_path this the main folder 
         * which contains all maps 
         * maps_arr holds all maps numbers 
         * */
        private FolderBrowserDialog mainfolder_path;
        private String[] all_maps; 
        

        /*
         * This function check the string value
         * is not null or white spaces 
         * this function already developed
         * in .net 4.0 and later 
         * */
        public static bool IsNullOrWhiteSpace(string value)
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
         * This function for alerting the 
         * successfully events  
         * */

        public void success_msg(String message) {
            success.Visible = true;
            success.BalloonTipText = message;
            success.BalloonTipIcon = ToolTipIcon.Info;
            success.BalloonTipTitle = "Success !";
            success.ShowBalloonTip(500);
         }


        /*
         * This function for alerting 
         * the errors and warrings
         * */
        public void alert_msg(String message) {
            warring.Visible = true;
            warring.BalloonTipText = message;
            warring.BalloonTipIcon = ToolTipIcon.Info;
            warring.BalloonTipTitle = "Alert!";
            warring.ShowBalloonTip(500);
        }
        

        /*
         * intialize the form elements
         * and check if it is started
         * successfully or not
         * */
        public Form1()
        {
            try
            {
                InitializeComponent();
                success_msg("Started successfully");
            }
            catch (Exception error){
                alert_msg(error.ToString());
            }
        }


        /*
         * When clicking on open maps folder button
         * */

        private void maps_folder_Click(object sender, EventArgs e)
        {
            /*
             * Load all maps numbers from the main folders
             * in the all_maps array 
             * */

            mainfolder_path = new FolderBrowserDialog();
            DialogResult result = mainfolder_path.ShowDialog();
            
           if (!IsNullOrWhiteSpace(mainfolder_path.SelectedPath))
            {
                 all_maps = Directory.GetDirectories(mainfolder_path.SelectedPath);
                 success_msg(all_maps.Length + " maps found in \" " + mainfolder_path.SelectedPath + " \" ");
      
            }
        }



        
    }
}
