using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    class GestionDate
    {
        private DateTime currentTime = DateTime.Now;
        

        public int moisCurrent()
        {
            return currentTime.Month;
        }

        public int moisPrecedent()
        {
            return currentTime.Month-1;
        }

    }
}
