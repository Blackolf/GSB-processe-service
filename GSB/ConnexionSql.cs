using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GSB
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

    }
}
