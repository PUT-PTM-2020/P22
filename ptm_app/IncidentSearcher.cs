using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptm_app
{
    class IncidentSearcher
    {
        public bool isIncidentFound()
        {
            //sprawdzenie czy przeslano dane przez modul wifi
            return false;
        }

        public void listenIncidents(bool ifStopRunning)
        {
            if (ifStopRunning == false)
            {
                while (true)
                {
                    if (isIncidentFound() == true)
                    {

                    }
                }
            }
            else
            {
                return; 
            }
        }
    }
}
