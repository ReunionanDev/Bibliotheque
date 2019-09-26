using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.BOL;
using Bibliotheque.DAL;

namespace Bibliotheque.ConsoleWindows
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialiser Paramètres DB Connexion
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
            //TesterAdherent();
            Console.WriteLine(ExemplaireDAO.Instance.Avalaible(6));
            Console.Read();
            
        }

       

        private static void TesterAdherent()
        {
            // Liste 
            foreach (Exemplaire item in ExemplaireDAO.Instance.GetAll())
            {
                Console.WriteLine($"ID : {item.IdExemplaire} Prénom : {item.Empruntable} Nom : {item.ISBN}");
            }
           

            // Extraction 1 Adherent

            Adherent adherent = AdherentDAO.Instance.GetByID("A9087");
            Console.WriteLine($"ID : {adherent.AdherentID} Prénom : {adherent.Prenom} Nom : {adherent.Nom}");

            // Modification 1 Adherent

            try
            {
                adherent.Prenom = "Anatole";
                AdherentDAO.Instance.Update(adherent);
                Console.WriteLine($"Modifié ID : {adherent.AdherentID} Prénom : {adherent.Prenom} Nom : {adherent.Nom}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur {ex.Message}");
            }

            // demande de Modification d'un adhérent inexistant
            adherent.AdherentID = "9999";
            adherent.Prenom = "Anatole";
            
            try
            {
                Console.WriteLine("Demande de modif avec clé erronée");
                AdherentDAO.Instance.Update(adherent);
                Console.WriteLine($"Modifié ID : {adherent.AdherentID} Prénom : {adherent.Prenom} Nom : {adherent.Nom}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur {ex.Message}");
            }

            adherent = new Adherent()
            {
                AdherentID = "A201954",
                Nom = "Restoueix",
                Prenom = "Sacha"

            };
            try
            {
                AdherentDAO.Instance.Create(adherent);
                Console.WriteLine($"Adhérent ajouté: {adherent.AdherentID} Prénom : {adherent.Prenom} Nom : {adherent.Nom}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur ajout {ex.Message}");
            }
            

            Console.Read();
        }
        private static void TesterPret()
        {
            Adherent adh = AdherentDAO.Instance.GetByID("A001");
            adh.Prets.SymmetricExceptWith(PretDAO.Instance.GetListePretsEncoursByIdAdherent(adh.AdherentID));
            foreach (Pret item in adh.Prets)
            {
                Console.WriteLine($"Ex : {item.IdExemplaire} ");
                Console.WriteLine($"Emprunté {(PretDAO.Instance.GetEnCoursByIDExemplaire(item.IdExemplaire)==null ? "Oui" : "Non")}");
            }
            Console.WriteLine($"Nombre prets pour {adh.Nom} : {adh.Prets.Count}");
            Console.WriteLine($"Déja Emprunté {(PretDAO.Instance.GetEnCoursByIDExemplaire(3) == null ? "Oui" : "Non")}");

            Exemplaire exemplaire = ExemplaireDAO.Instance.GetByID(6);
            exemplaire.Disponible = PretDAO.Instance.GetEnCoursByIDExemplaire(exemplaire.IdExemplaire) == null;

            Console.WriteLine($"exemplaire : {exemplaire.IdExemplaire}" +
                $" disponible : {exemplaire.Disponible}" +
                $" empruntable : {exemplaire.Empruntable}");
            Livre livre = LivreDAO.Instance.GetByISBN(exemplaire.ISBN);
            Console.WriteLine($"livre : {livre.ISBN}" +
                $" titre : {livre.Titre}");
            Console.ReadLine();
            
        }
    }
}
