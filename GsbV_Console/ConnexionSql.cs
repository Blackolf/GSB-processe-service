using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GsbV_Console
{
    class ConnexionSql
    {
        private string local_serveur = "localhost";
        private string local_database = "gsb_frais";
        private string local_user = "root";
        private string local_passeword = "";

        private string serveur = "";
        private string database = "";
        private string user = "";
        private string passeword = "";

        public void Connexionsql()
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection("server=" + local_serveur + ";database=" + local_database + ";uid=" + local_user + ";pwd=" + local_passeword + ";");
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.Write("Error : "+e);
            }



        }


        protected void getObjet(string sql, string[] param)
        {
            MySqlCommand requete = new MySqlCommand(sql, this.myConnection);
            MySqlDataReader dataReader;


        }

        protected void update(string sql)
        {
            MySqlCommand MyCommand2 = new MySqlCommand(sql, this.myConnection);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
        }


        public string[] getFicheMoisPrecedent()
        {
            string[] fiche = null;
            return fiche;
        }

        public void endFicheSaisir()
        {
            DateTime currentTime = DateTime.Now;

            int mount = currentTime.Month - 1;
            int year = currentTime.Year;
            string time = (year * 100 + mount).ToString();
            string sql = "Update fichefrais set idEtat ='CL' where mois = '" + time + "' AND idEtat = 'CR'";
            update(sql);

        }

        public void rembourseFiche()
        {
            DateTime currentTime = DateTime.Now;

            int mount = currentTime.Month;
            int year = currentTime.Year;
            string time = (year * 100 + mount).ToString();
            string sql = "Update fichefrais set idEtat ='VA' where mois = '" + time + "' AND idEtat = 'RB'";
            update(sql);
        }


    }
}
