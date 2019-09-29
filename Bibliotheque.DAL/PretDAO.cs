using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.BOL;
using System.Data;
using System.Data.SqlClient;

namespace Bibliotheque.DAL
{
    public class PretDAO
    {
        private static PretDAO _instance = null;
        private static object _verrou = new object();
        private PretDAO() { }
        public static PretDAO Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new PretDAO();
                    }
                }
                return _instance;
            }
        }

        public HashSet<Pret> GetListePretsEncoursByIdAdherent(string idAdherent)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                SqlParameter pIdAdherent = command.CreateParameter();
                pIdAdherent.ParameterName = "@IdAdherent";
                pIdAdherent.DbType = DbType.StringFixedLength;
                pIdAdherent.Direction = ParameterDirection.Input;
                pIdAdherent.Value = idAdherent;
                pIdAdherent.Size = 10;
                command.Parameters.Add(pIdAdherent);
                command.CommandText = "SELECT IdAdherent, IdExemplaire, DateEmprunt, DateRetour FROM dbo.Pret where idAdherent = @IdAdherent AND DateRetour is null";
                return AlimenterListe(command);
            }
        }
        public Pret GetEnCoursByIDExemplaire(int idExemplaire)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                SqlParameter pIdExemplaire = command.CreateParameter();
                pIdExemplaire.ParameterName = "@IdExemplaire";
                pIdExemplaire.DbType = DbType.Int32;
                pIdExemplaire.Direction = ParameterDirection.Input;
                pIdExemplaire.Value = idExemplaire;
                command.Parameters.Add(pIdExemplaire);
                command.CommandText = "SELECT IdAdherent, IdExemplaire, DateEmprunt, DateRetour FROM dbo.Pret where idExemplaire = @IdExemplaire AND DateRetour is null";
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    return rd.Read() ? ChargerDonnees(rd) : null;
                }
            }
        }

        private HashSet<Pret> AlimenterListe(SqlCommand command)
        {
            HashSet<Pret> prets = new HashSet<Pret>();
            using (SqlDataReader rd = command.ExecuteReader())
            {
                while (rd.Read())
                {
                    prets.Add(ChargerDonnees(rd));
                }
            }
            return prets;
        }
        private Pret ChargerDonnees(SqlDataReader rd)
        {
            Pret pret = new Pret
            {
                IdExemplaire = (int)rd["IdExemplaire"],
                AdherentID = rd["IdAdherent"].ToString(),
                DateEmprunt = (DateTime)rd["DateEmprunt"],
                DateRetour = rd["DateRetour"] == DBNull.Value ? null : (DateTime?)rd["DateRetour"]
            };
            return pret;
        }

        public void Create(Pret pret)
        {
            using (SqlConnection connection = DB.Instance.GetDBConnection())
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "dbo.Pret_Insert";
                command.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres 
                SqlParameter parameter;
                parameter = new SqlParameter();
                parameter.ParameterName = "@RETURN_VALUE";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@IdAdherent";
                parameter.SqlDbType = SqlDbType.NChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 10;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@IdExemplaire";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@DateEmprunt";
                parameter.SqlDbType = SqlDbType.Date;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@DateRetour";
                parameter.SqlDbType = SqlDbType.Date;
                parameter.Direction = ParameterDirection.Input;
                command.Parameters.Add(parameter);

                // Passage des valeurs

                command.Parameters["@IdAdherent"].Value = pret.AdherentID;
                command.Parameters["@IdExemplaire"].Value = pret.IdExemplaire;
                command.Parameters["@DateEmprunt"].Value = pret.DateEmprunt;
                command.Parameters["@DateRetour"].Value = null;

                // Ouvre la connexion et exécute la commande
               
                    command.ExecuteNonQuery();
               
            }

        }
    }
}