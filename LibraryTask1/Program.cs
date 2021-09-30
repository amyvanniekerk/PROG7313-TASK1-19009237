using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryTask1
{
    static class Program
    {
        //creating a method that will allow access to the list for all forms

        public static List<CallNumbers> callNum = new List<CallNumbers>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());


        }
    }
}
