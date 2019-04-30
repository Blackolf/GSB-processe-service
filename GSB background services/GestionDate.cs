using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_background_services
{
    class GestionDate
    {
        public DateTime Now = DateTime.Now;
        private DateTime currentTime ;

        public GestionDate(){
            currentTime = DateTime.Now;
        }
        public int moisCurrent()
        {
            return currentTime.Month;
        }

        public int moisPrecedent()
        {
            return currentTime.Month-1;
        }

        public int jourCurrent()
        {
            return currentTime.Day;
        }

        public DateTime now()
        {
            return DateTime.Now;
        }

        public Boolean TodayLateThen(int day)
        {
            return (DateTime.Now.Day > day) ;
        }

        public Boolean todayEqual(int day)
        {
            return (DateTime.Now.Day == day);
        }

        public Boolean todayEarlyThen(int day)
        {
            return (DateTime.Now.Day < day);
        }

        public Boolean dayBetween(int fristDay,int secondDay)
        {
            return false;
        }
    }
}
