using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLogout
{
    internal class User
    {
        public static string username;
        public static string password;
        public static bool logged;
        public static DateTime date;
        public static void Login()
        {
            Console.WriteLine("insericsci username");
            User.username = Console.ReadLine();
            Console.WriteLine("inserisci Password");
            User.password = Console.ReadLine();
            Console.WriteLine("Conferma Password");
            string conferma = Console.ReadLine();
            if (User.password == conferma)
            {
                logged = true;
                date = DateTime.Now;
                Console.WriteLine("utente loggato Correttamente :)");
            }
            else
            {
                Console.WriteLine("Impossibile fare il login :(");
            }


        }

        public static void Logout()
        {
            if (logged)
            {
                username = null;
                password = null;
                logged = false;
                date = default(DateTime);
                Console.WriteLine("Utente Disconnesso");
            }
            else {
                Console.WriteLine("non c'è nessun utente loggato");
            }
        }

        public static void Date()
        {
            if (User.logged == true)
            {
                Console.WriteLine($"l'utente {User.username} Ha effettuato l'accesso il {User.date}");
            }
            else { 
            Console.WriteLine("non ci sono utenti loggati");}

        }
    }
}
