using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GsbV_Console
{
    class Program
    {
        ConnexionSql Connect = new ConnexionSql();
        Timer timer = new Timer();
        static void Main(string[] args)
        {
            while (true) {



            }
        }

        protected void UpdateFiche()
        {
            Console.Write("Processe starts");
            Connect.endFicheSaisir();
            Connect.rembourseFiche();
        }
    }
}
