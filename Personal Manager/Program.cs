using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //create the runonce directory if it doesn't already exist
            if (!Directory.Exists(@"C:\CanterlotApplications\PersonalManager\"))
            {
                //this will be used the entirety of the program's life
                DirectoryInfo diPMnew = Directory.CreateDirectory(@"C:\CanterlotApplications\");
                //make the parent first, then the child
                Directory.CreateDirectory(@"C:\CanterlotApplications\PersonalManager\");
                //make it hidden so the user doesn't stumble upon it
                diPMnew.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            //begin the main form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }
    }
}
