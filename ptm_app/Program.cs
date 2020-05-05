using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ptm_app
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Incident incident = new Incident("1", "04.05.2020", "12:48", @"images\incident1.jpeg");

            incident.wirteIncidentToFile();
            incident.readIncidentFromFile();
            incident.displayIncidents();

        }
    }
}
