/*
 * Author Ramy Muhammad -- Date: 10 / 11 / 2016 -- Email: ramy711@yahoo.com 
 * Property taxes tool compatible with .NET 3.5 and later versions
 * compatible with server platforms windows server 2003 and windows server 2008
 * compatible operating systems platforms windows XP, VISTA, win7, win8 and win10 
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Text.RegularExpressions;


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
        private Other_functions functions_object;


        /*
         * This function for alerting the 
         * successfully events  
         * */

        public void success_msg(String message) {
            warring.Visible = false;
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
            success.Visible = false; 
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
            functions_object = new Other_functions();
            if (!functions_object.IsNullOrWhiteSpace(mainfolder_path.SelectedPath))
               {
                  try
                   {
                       all_maps = Directory.GetDirectories(mainfolder_path.SelectedPath);
                       success_msg(all_maps.Length + " maps found in \" " + mainfolder_path.SelectedPath + " \" ");
                       mapsBar.Maximum = 100;
                       mapsBar.Value = 100;
                       mapslable.Text = mapslable.Text + " 100% ";
                       totalreport.Visible = true;
                       totalmaps.Text = totalmaps.Text + " = " + all_maps.Length; 
                       start_conversion.Focus();
                   }
                   catch (Exception error) {
                     alert_msg(error.ToString());
                   }
                  
                }
         }


        /*
         * Staring files conversion button 
         * it will load all subdirectories in
         * each map to loop on each zone to
         * get all tasks directories and 
         * start to read the DBF files 
         * and backup it firstly then 
         * create new DBF files and 
         * fill "NEW_OLD_BUID" table
         * with the new and old BUIDs
         * */
        private void start_conversion_Click(object sender, EventArgs e)
        {
            conversionBar.Maximum = all_maps.Length;
            conversionBar.Value = 0 ;
            int flag_TotalZones = 0 , flag_TotalTasks = 0 , flag_successBUID = 0 , flag_failureBUID = 0 ;
            totalzones.Visible = true;
            totaltasks.Visible = true;
            functions_object.connect_to_database();
           for (int i = 0; i < all_maps.Length; i++)
            
                {
                    String Current_map = Path.Combine(mainfolder_path.SelectedPath , all_maps[i]) ;
                    String[] map_zones = Directory.GetDirectories(Path.Combine(mainfolder_path.SelectedPath, all_maps[i]));
                    for (int j = 0; j < map_zones.Length; j++)
                    {
                        flag_TotalZones += 1;
                        totalzones.Text = "Total zones = " + flag_TotalZones;
                        String Current_zone = Path.Combine(Current_map,map_zones[j]);
                        String[] zones_tasks = Directory.GetDirectories(Path.Combine(Current_map, map_zones[j]));
                        for (int x = 0; x < zones_tasks.Length; x++)
                        {
                           
                           try
                            {
                                flag_TotalTasks += 1;
                                totaltasks.Text = "Total tasks = " + flag_TotalTasks;
                                String Current_task = Path.Combine(Current_zone, zones_tasks[x]);
                                String DBF_file = Path.Combine(Current_task, "RTA_Buildings.dbf");
                                System.IO.File.Copy(DBF_file, Path.Combine(Current_task, "Backup_RTA_Buildings.dbf"));
                                DataTable DBF_DATA = functions_object.GetDBFData(Current_task, "Backup_RTA_Buildings.dbf");
                                int total_buid = 0;  
                                try
                                {
                                    
                                    foreach (DataRow data in DBF_DATA.Rows)
                                    {
                                        total_buid += 1;
                                        String new_buid = "";
                                        String old_buid = "\""+data["buid"].ToString().Trim()+"\"";
                                        String task_serial = new DirectoryInfo(zones_tasks[x]).Name ;
                                        String buid_serial = "";
                                        if (total_buid <= 9) { buid_serial += "00" + total_buid; }
                                        else if (total_buid > 9 && total_buid <= 99) { buid_serial += "0" + total_buid; }
                                        new_buid += "\""+task_serial.Trim() + buid_serial.Trim() + "\"";
                                        functions_object.Update_BDF(Current_task , new_buid , old_buid);
                                        functions_object.insert_into_database(old_buid , new_buid);
                                    }

                                 flag_successBUID += 1;
                                }catch(Exception error){
                                    alert_msg(error.ToString());
                                    flag_failureBUID += 1;
                                    functions_object.error_log(Current_task);
                                    continue; 
                                }
                           
                            }catch (Exception error){
                                alert_msg(error.ToString());
                                functions_object.error_log( error.ToString());
                                flag_failureBUID += 1;
                                continue;
                            }
                
                        }//END OF LOOPING ON ALL TASK IN EACH ZONE
                    }//END OF LOOPING ON ALL ZONES IN EACH MAP
                    conversionBar.Value = conversionBar.Value + 1;
                }// END OF LOOPING ON ALL MAPS
                
                success_msg("File conversion finished successfully ");
                successpanel.Visible = true;
                failurepanel.Visible = true;
                totalsuccess.Text = totalsuccess.Text + " = " + flag_successBUID;
                totalfailure.Text = totalfailure.Text + " = " + flag_failureBUID;
                successprecentage.Text = successprecentage.Text + " = " + ((flag_successBUID * 100) / flag_TotalTasks) + " %";
                failureprecentage.Text = failureprecentage.Text + " = " + ((flag_failureBUID * 100)/ flag_TotalTasks)  + " %";
                fileconversion.Text += " 100%";
                functions_object.conn.Close();
          }
    }
}
