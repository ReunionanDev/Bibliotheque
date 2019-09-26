using System;
using System.Collections.Generic;
using Bibliotheque.BOL;
using System.Data;
using System.Data.SqlClient;

namespace Bibliotheque.DAL
{
    public class ExemplaireDAO
    {
        private static ExemplaireDAO _instance = null;
        private static readonly object _verrou = new object();
        private ExemplaireDAO() { }
        public static ExemplaireDAO Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new ExemplaireDAO();
                    }
                }
                return _instance;
            }
        }

        public Exemplaire GetByID(int idExemplaire)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                SqlParameter pidExemplaire = command.CreateParameter();
                pidExemplaire.ParameterName = "@idExemplaire";
                pidExemplaire.DbType = DbType.Int32;
                pidExemplaire.Direction = ParameterDirection.Input;
                pidExemplaire.Value = idExemplaire;
                command.Parameters.Add(pidExemplaire);
                command.CommandText = "Select IdExemplaire,ISBN,Empruntable FROM dbo.Exemplaire where IdExemplaire = @idExemplaire";
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    return rd.Read() ? ChargerDonnees(rd) : null;
                }
            }
        }
        public HashSet<Exemplaire> GetAll()
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "Select IdExemplaire,ISBN,Empruntable FROM dbo.Exemplaire";
                return AlimenterListe(command);
            }

        }
        private HashSet<Exemplaire> AlimenterListe(SqlCommand command)
        {
            HashSet<Exemplaire> exemplaire = new HashSet<Exemplaire>();
            using (SqlDataReader rd = command.ExecuteReader())
            {
                while (rd.Read())
                {
                    exemplaire.Add(ChargerDonnees(rd));
                }
            }
            return exemplaire;
        }
        private Exemplaire ChargerDonnees(SqlDataReader rd)
        {
            Exemplaire exemplaire = new Exemplaire
            {
                IdExemplaire = (int)rd["IdExemplaire"],
                ISBN = rd["ISBN"].ToString(),
                Empruntable = (bool)rd["Empruntable"]
                 
            };
            return exemplaire;
        }
    }
}
