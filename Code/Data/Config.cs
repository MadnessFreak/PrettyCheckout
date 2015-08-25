using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Windows.Forms;

using PrettyCheckout;
using PrettyCheckout.Data;
using PrettyCheckout.Dialogs;
using PrettyCheckout.Math;

namespace PrettyCheckout.Data
{
    public static class Config
    {
        // Properties
        public static Dictionary<string, object> Entries { get; set; }
        public static int EntryCount 
        {
            get { return Entries.Count; }
        }

        // Constants
        public const string ConfigPath = "Config.xml";

        // Constructor
        static Config()
        {
            Entries = new Dictionary<string, object>();
        }

        // Methods
        public static void Load(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                return;
            }

            var document = XDocument.Load(path);

            if (document.Root.Attribute("Version").Value != "1.0")
            {
                MessageBox.Show("Config file version is invalid - " + path);
                return;
            }

            Entries.Clear();

            foreach (XElement element in document.Root.Descendants())
            {
                if (element.Name == "Conf")
                {
                    Set(element.Attribute("Key").Value, element.Attribute("Value").Value);
                }
            }
        }

        public static void Save(string path)
        {
            var document = new XDocument();
            var root = new XElement("Config", new XAttribute("Version", "1.0"));

            foreach (var entry in Entries)
            {
                root.Add(new XElement("Conf", new XAttribute("Key", entry.Key), new XAttribute("Value", entry.Value)));
            }

            document.Add(root);

            try
            {
                document.Save(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Config file could not be saved - " + path);
            }
        }

        public static void Set(string key, object value)
        {
            if (Entries.ContainsKey(key))
            {
                Entries[key] = value;
            }
            else
            {
                Entries.Add(key, value);
            }
        }

        public static string Get(string key)
        {
            return Get<string>(key);
        }

        public static T Get<T>(string key)
        {
            if (Entries.ContainsKey(key))
            {
                return (T)Convert.ChangeType(Entries[key], typeof(T));
            }
            return default(T);
        }
    }
}
