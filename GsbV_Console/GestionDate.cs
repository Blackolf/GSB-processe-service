using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsbV_Console
{
    class GestionDate
    {
        private DateTime currentTime;

        public GestionDate()
        {
            currentTime = DateTime.Now;
        }
        public int moisCurrent()
        {
            return currentTime.Month;
        }

        public int moisPrecedent()
        {
            return currentTime.Month - 1;
        }

        public int jourCurrent()
        {
            return currentTime.Day;
        }

    }
}
