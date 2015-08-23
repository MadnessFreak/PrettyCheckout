using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using PrettyCheckout;
using PrettyCheckout.Data;
using PrettyCheckout.Dialogs;
using PrettyCheckout.Math;

namespace PrettyCheckout
{
    public static class Program
    {
        // Properties
        public static ProductEnvironment Environment { get; private set; }

        // Constructor
        static Program()
        {
            Environment = new ProductEnvironment();
        }

        // Methods
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataReader.Load(DataReader.DatabasePath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dialogs.FormMain());
        }
    }
}
