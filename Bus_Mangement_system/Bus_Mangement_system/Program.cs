﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace Bus_Mangement_system
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loading());
        }
        
        //GET Connection String From App.Config
        public static string GetConnectionStringByName()
        {
            
            string returnValue = null;

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["myConnectionString"];

            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
