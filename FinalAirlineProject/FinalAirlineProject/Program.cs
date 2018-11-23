using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAirlineProject
{
    static class Program
    {
        public static AirlineCoordinator ac;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ac = new AirlineCoordinator(100, 50, 10, 1000, 1000);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMenu());
        }

        //function to validate integer input.
        public static int ValidateInt(string s, Label label)
        {
            int num;

            if (int.TryParse(s, out num))
            {
                label.Text = "";
                return num;
            }

            label.Text = "Input must be a valid number!";

            return -1;
        }

        //function to validate string input. Checks for empty textboxes
        public static string ValidateString(string s, Label label)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                label.Text = "";
                return s;
            }

            label.Text = "This field is required!";
            return null;
        }
    }
}
