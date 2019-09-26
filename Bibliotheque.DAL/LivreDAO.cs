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
                command.CommandText = "Select ISBN,Titre FROM dbo.Livre where ISBN = @ISBN";
                using (SqlDataReader rd = command.ExecuteReader())
                {
                    return rd.Read() ? ChargerDonnees(rd) : null;
                }
            }
        }

        private Livre ChargerDonnees(SqlDataReader rd)
        {
            Livre livre = new Livre
            {
                ISBN = rd["ISBN"].ToString(),
                Titre = rd["Titre"].ToString()             
            };
            return livre;
        }
    }
}
