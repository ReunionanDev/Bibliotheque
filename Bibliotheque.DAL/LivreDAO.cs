﻿using System;
using System.Collections.Generic;
using Bibliotheque.BOL;
using System.Data;
using System.Data.SqlClient;

namespace Bibliotheque.DAL
{
    public class LivreDAO
    {
        private static LivreDAO _instance = null;
        private static readonly object _verrou = new object();
        private LivreDAO() { }
        public static LivreDAO Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new LivreDAO();
                    }
                }
                return _instance;
            }
        }

        public Livre GetByISBN(string ISBN)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                SqlParameter pISBN = command.CreateParameter();
                pISBN.ParameterName = "@ISBN";
                pISBN.DbType = DbType.StringFixedLength;
                pISBN.Direction = ParameterDirection.Input;
                pISBN.Value = ISBN;
                pISBN.Size = 10;
                command.Parameters.Add(pISBN);
                command.CommandText = "Select ISBN,Titre,IdCategorie FROM dbo.Livre where ISBN = @ISBN";
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    return rd.Read() ? ChargerDonnees(rd) : null;
                }
            }
        }

        public HashSet<Livre> GetAll()
        {

            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandType = CommandType.Text;
                command.CommandText = "Select ISBN, Titre, IdCategorie FROM dbo.Livre";
                return AlimenterListe(command);
            }

        }
        private HashSet<Livre> AlimenterListe(SqlCommand command)
        {
            HashSet<Livre> livre = new HashSet<Livre>();
            using (SqlDataReader rd = command.ExecuteReader())
            {
                while (rd.Read())
                {
                    livre.Add(ChargerDonnees(rd));
                }
            }
            return livre;
        }
        private Livre ChargerDonnees(SqlDataReader rd)
        {
            Livre livre = new Livre
            {
                ISBN = rd["ISBN"].ToString(),
                Titre = rd["Titre"].ToString(),  
                IdCategorie = (int)rd["IdCategorie"]
            };
            return livre;
        }
        public void Update(Livre livre)
        {
            using (SqlConnection cnx = DB.Instance.GetDBConnection())
            using (SqlCommand command = cnx.CreateCommand())
            {
                command.CommandText = "dbo.Livre_Update";
                command.CommandType = CommandType.StoredProcedure;

                // Ajout des paramètres 
                SqlParameter parameter;
                parameter = new SqlParameter();
                parameter.ParameterName = "@RETURN_VALUE";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@ISBN";
                parameter.SqlDbType = SqlDbType.NChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 10;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@Titre";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 150;
                command.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@IdCategorie";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Direction = ParameterDirection.Input;
                parameter.Size = 50;
                command.Parameters.Add(parameter);
                // Passage des valeurs
                command.Parameters["@ISBN"].Value = livre.ISBN;
                command.Parameters["@Titre"].Value = livre.Titre;
                command.Parameters["@IdCategorie"].Value = livre.IdCategorie;

                if (command.ExecuteNonQuery() == 0)
                {
                    throw new Exception(Messages.UpdateNonTraite);
                }
            }
        }
    }
}
