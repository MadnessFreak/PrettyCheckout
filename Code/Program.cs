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
        public static BillingHistory BillingHistory { get; private set; }

        // Constructor
        static Program()
        {
            Environment = new ProductEnvironment();
            BillingHistory = new BillingHistory();
        }

        // Methods
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataReader.Load(DataReader.DatabasePath);
            BillingHistory.Load(BillingHistory.BillingHistoryPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dialogs.FormMain());

            BillingHistory.Save(BillingHistory.BillingHistoryPath);
        }
    }
}
