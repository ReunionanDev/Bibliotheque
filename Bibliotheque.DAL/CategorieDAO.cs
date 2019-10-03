using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Bibliotheque.BOL;
using System.Data;

namespace Bibliotheque.DAL
{
    public class CategorieDAO
    {
        private static CategorieDAO _instance = null;
        private static readonly object _verrou = new object();
        private CategorieDAO() { }
        public static CategorieDAO Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new CategorieDAO();
                    }
                }
                return _instance;
            }
        }

        public HashSet<Categorie> GetAll()
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "Select IdCategorie,LibelleCategorie from Categorie";
                return AlimenterListe(command);
            }

        }

        private HashSet<Categorie> AlimenterListe(SqlCommand command)
        {
            HashSet<Categorie> categorie = new HashSet<Categorie>();
            using (SqlDataReader rd = command.ExecuteReader())
            {
                while (rd.Read())
                {
                    categorie.Add(ChargerDonnees(rd));
                }
            }
            return categorie;
        }
        private Categorie ChargerDonnees(SqlDataReader rd)
        {
            Categorie categorie = new Categorie
            {
                Id = (int)rd["IdCategorie"],
                Libelle = rd["LibelleCategorie"].ToString()
            };
            return categorie;
        }
    }
}
