using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEmploye
{
    internal class Connexion
    {
        private static SqlConnection c;
        private Connexion() { } //Constructeur privé et vide...
        public static SqlConnection getInstance()
        {
            if (c == null)
            {
                string chaineDeConnexion;
                  
                chaineDeConnexion = "Data Source=DESKTOP-99OSS5J;Initial Catalog=GestionEmploye;Integrated Security=True";
                try
                {
                    c = new SqlConnection(@chaineDeConnexion);
                    c.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de connexion :" + ex.Message);
                }
            }
            return c;
        }
    }
}
