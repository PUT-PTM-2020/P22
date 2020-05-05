using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptm_app
{
    class incidentID
    {
        int id;

        public incidentID(int id)
        {
            this.id = id;
        }

        public void wirteIncidentIDToFile()
        {
            StreamWriter sw;
            if (!File.Exists(@"incidents.txt"))
            {
                sw = File.CreateText(@"id.txt");
            }
            else
            {
                sw = new StreamWriter(@"id.txt", true);
            }

            string incidentText = id.ToString();
            sw.WriteLine(incidentText);
            sw.Close();
        }

        public void readIncidentIDFromFile()
        {
            StreamReader sr = File.OpenText(@"incidents.txt");
            string id = "";

            while ((id = sr.ReadLine()) != null)
            { 
                Console.WriteLine(id);
            }
            sr.Close();

            Console.ReadKey();
        }
    }
}
