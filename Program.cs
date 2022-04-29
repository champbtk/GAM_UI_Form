using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace GAM
{
    internal static class Program
    {
        public static string dirName;
        public static System.Diagnostics.Process process = new System.Diagnostics.Process();
        public static System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        public static List<string> classID = new List<string>();
        public static List<string> className = new List<string>();
        public static List<string> classState = new List<string>();
        public static List<string> provisionedList = new List<string>();
        public static string allProvisionedClasses;
        public static string schoolDomain;
        public static string selectedClassroom;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
