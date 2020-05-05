using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ptm_app
{
    class Incident
    {
        public string id;
        public string hour;
        public string date;
        public string imagePath;
        public List<Incident> incidents = new List<Incident>();

        public Incident()
        {

        }

        public Incident(string id, string date, string hour, string imagePath)
        {
            this.id = id;
            this.date = date;
            this.hour = hour;
            this.imagePath = imagePath;
        }

        void decodeIncident()
        {
            //regex dekodujacy stringa
            

        }

        public void wirteIncidentToFile()
        {
            StreamWriter sw;
            if (!File.Exists(@"incidents.txt"))
            {
                sw = File.CreateText(@"incidents.txt");
            }
            else
            {
                sw = new StreamWriter(@"incidents.txt", true);
            }

            string incidentText = id + " " + date + " " + hour + " " + imagePath;
            sw.WriteLine(incidentText);
            sw.Close();
        }

        public void readIncidentFromFile()
        {
            StreamReader sr = File.OpenText(@"incidents.txt");
            string incident = "";

            while ((incident = sr.ReadLine()) != null)
            {
                //Console.WriteLine("incident: " + incident + "\n\n");

                string[] elements = incident.Split();
               
                //Console.WriteLine(elements[0] + " | " + elements[1] + " | " + elements[2] + " | " + elements[3]);
                Incident readIncident = new Incident(elements[0], elements[1], elements[2], elements[3]);
                incidents.Add(readIncident);
            }
            sr.Close();
        }

        public void printIncident()
        {
            Console.WriteLine(id + " " + date + " " + hour + " " + imagePath);
        }

        public void displayIncidents()
        {
            Console.WriteLine("\nList of incidents:\n");
      
            for (int i=0; i<incidents.Count; i++)
            {
                incidents[i].printIncident();
            }
        }
    }
}
