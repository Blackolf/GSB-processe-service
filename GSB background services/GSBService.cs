using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GSB_background_services
{
    public partial class GSBService : ServiceBase
    {
        private ConnexionSql Connect = new ConnexionSql();
        private Timer timer = new Timer();
        private GestionDate gd = new GestionDate();

        public GSBService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {


            timer.Interval = 5000; //number in milisecinds  
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;

            if (!EventLog.SourceExists("Gsb"))
            {
                EventLog.CreateEventSource("Gsb", "GsbLog");
            }
            eventLog1.Source = "Gsb";
            eventLog1.Log = "GsbLog";

            eventLog1.WriteEntry("Serivce Start : " + DateTime.Now, EventLogEntryType.Information);

        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Serivce stop : " + DateTime.Now, EventLogEntryType.Information);
            timer.Enabled = false;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            eventLog1.WriteEntry("Serivce in processe : " + DateTime.Now + " Update Start", EventLogEntryType.Information);

            try
            {

            UpdateFiche();
                eventLog1.WriteEntry("Update Sucesse: "+DateTime.Now, EventLogEntryType.SuccessAudit);

            }
            catch (Exception ex)
            {
                eventLog1.WriteEntry("Error : " + ex.Message + "", EventLogEntryType.Error);
            }
            finally
            {
                eventLog1.WriteEntry("Serivce in processe : " + DateTime.Now + " Update End", EventLogEntryType.Information);

            }
        }

        protected void UpdateFiche()
        {
            if (gd.todayEarlyThen(11))
            {
                Connect.endFicheSaisir();
            }
            if (gd.TodayLateThen(20) || gd.todayEqual(20))
            {
                Connect.rembourseFiche();
            }
        }

        private void eventLog1_EntryWritten_1(object sender, EntryWrittenEventArgs e)
        {

        }
    }
}
