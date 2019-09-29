using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace SalariesDll
    
{   /// <summary>
    /// Permet de créer objets de type salarié
    /// </summary>
    [Serializable()]
    public class Salarie
    {
        #region Fields
        private string _matricule;
        private string _lastName;
        private string _firstName;
        private decimal _grossSalary;
        private decimal _socialRate;
        private DateTime _birthDate;
        private static int instanceCount = 0;
        #endregion

        #region Propriétés
        /// <summary>
        /// Matricule
        /// </summary>
        public string Matricule
        {
            get
            {
                return this._matricule;
            }
            set
            {
                if (!IsMatriculeValidRegex(value) || value == null)
                {
                    throw new Exception(string.Format("The matricule {0} is not valid.", value));
                }
                this._matricule = value;
            }
        }
        /// <summary>
        /// Nom de Famille
        /// </summary>
        /// 
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                if (!IsNameValid(value))
                {
                    throw new Exception(string.Format("The last name {0} is not valid.", value));

                }
                this._lastName = value;
            }
        }
        /// <summary>
        /// Prénom
        /// </summary>
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                if (!IsNameValid(value))
                {
                    throw new Exception(string.Format("The first name {0} is not valid.", value));
                }
                this._firstName = value;
            }
        }
        /// <summary>
        /// Salaire brut
        /// </summary>
        public decimal GrossSalary
        {
            get
            {
                return this._grossSalary;
            }
            set
            {
                if (_grossSalary != decimal.Zero && _grossSalary != value)
                    OnChangementSalaire(this, new ChangementSalaireEventArgs(this._grossSalary, value,value));
                this._grossSalary = value;
            }
        }
        /// <summary>
        /// Charge social
        /// Ne peut exceder 0.6
        /// </summary>
        public decimal SocialRate
        {
            get
            {
                return this._socialRate;
            }
            set
            {
                if (value < 0 || value > 0.6M)
                {
                    throw new Exception(string.Format("The social rate {0} is not valid.", value));
                }
                this._socialRate = value;
            }
        }
        /// <summary>
        /// Date de naissance
        /// </summary>
        public DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                if (!IsBirthDateValid(value))
                {
                    throw new Exception(string.Format("The birth date {0} is not valid.", value));
                }
                this._birthDate = value;
            }
        }
        /// <summary>
        /// Calcul du salaire Net selon salaire brut et taux de charge
        /// </summary>
        public virtual decimal NetSalary()
        {
            return this._grossSalary * (1 - this._socialRate);
        }
        /// <summary>
        /// Compteur d'instance
        /// </summary>
        public static int GetNbInstance
        {
            get
            {
                return Salarie.instanceCount;
            }
        }
        #endregion

        #region Méthodes
        /// <summary>
        ///Verification de la conformite de la saisie pour les noms et prenoms.
        /// Longueur comprise entre 3 et 30 caractères
        /// Uniquement composé de lettres
        /// </summary>
        /// <param LastName or FirstName="value"></param>
        /// <returns></returns>
        private static bool IsNameValid(string value)
        {
            if (value == null || value.Length < 3 || value.Length > 30) return false;
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i])) return false;
            }
            return true;
        }
        /// <summary>
        /// Vérifie que le matricule respecte les règles suivantes
        /// Longueur 7 structure nnXXXnnn ou n est un chiffre et X une lettre
        /// </summary>
        /// <param Matricule="value">La valeur du matricule</param>
        /// <returns></returns>
        private static bool IsMatriculeValidRegex(string value)
        {
            return Regex.Match(value, @"[0-9]{2}[a-zA-Z]{3}[0-9]{2}\z").Success;
        }
        /// <summary>
        /// Verifie si la date de naissance est supérieur au 01/01/1900 et inférieur à l'année en cours moins 15
        /// </summary>
        /// <param Date de naissance="value"></param>
        /// <returns></returns>
        private static bool IsBirthDateValid(DateTime value)
        {
            DateTime date1 = new DateTime(1900, 1, 1);      //Check if the birth date is higher than  1 January 1900
            int result = DateTime.Compare(date1, value);
            if (result >= 0)
            {
                return false;
            }
            DateTime date2 = DateTime.Now.AddYears(-15);   // Check if the birth date is lesser than today  - 15 years
            int result2 = DateTime.Compare(date2, value);
            if (result2 <= 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Salarie()    
        {
            instanceCount++;
            Debug.WriteLine($"constructeur {instanceCount}");
        }
        /// <summary>
        /// Constructeur de copie
        /// </summary>
        /// <param name="salarie"></param>
        public Salarie(Salarie salarie)    
            : this()
        {

            this.LastName = salarie.LastName;
            this.FirstName = salarie.FirstName;

            Debug.WriteLine($"constructeur {instanceCount}");
        }

        /// <summary>
        /// Constructeur d'initialisation 
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="matricule"></param>
        public Salarie(string lastName, string firstName, string matricule)  
            : this()
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Matricule = matricule;

            Debug.WriteLine($"constructeur {instanceCount}");
        }
        #endregion

        #region Destructeur
        /// <summary>
        /// Destructeur manuel
        /// </summary>
        ~Salarie()
        {
            instanceCount--;
            Debug.WriteLine($"destructeur {instanceCount}");

        }
        #endregion

        #region Modification méthode ToString, Equal, GetHashCode
        /// <summary>
        /// Override de la methode ToString
        /// </summary>
        /// <returns>Chaque propriété suivi d'une virgule</returns>
        public override string ToString()
        {
            return $"Matricule:{Matricule}; Last name:{LastName}; First name:{FirstName}; Gross salary:{GrossSalary}; Social Rate:{SocialRate}; Birth date:{BirthDate}; Net salary:{NetSalary()}";
        }
        /// <summary>
        /// Override de la méthode Equals pour comparer les matricules
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si les matricules sont similaires</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Salarie))
            {
                return false;
            }
            Salarie salarie = (Salarie)obj;
            return Matricule == salarie.Matricule;
        }
        /// <summary>
        /// Override de la méthode GetHashCode afin de prendre en compte que l'égalité vient des Matricules
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Matricule.GetHashCode();
        }
        #endregion

        #region Evènement
        public event EventHandler<ChangementSalaireEventArgs> ChangementSalaire;

        public class ChangementSalaireEventArgs : EventArgs
        {
            private decimal _ancienSalaire;
            private decimal _nouveauSalaire;
            private decimal _tauxAugmentation;

            public ChangementSalaireEventArgs(decimal ancienSalaire, decimal nouveauSalaire, decimal tauxAugmentation)
            {
                _ancienSalaire = ancienSalaire;
                _nouveauSalaire = nouveauSalaire;
                _tauxAugmentation = tauxAugmentation;

            }
            public decimal AncienSalaire
            {
                get
                {
                    return _ancienSalaire;
                }
                set
                {
                    AncienSalaire = value;
                }
            }
            public decimal NouveauSalaire
            {
                get
                {
                    return _nouveauSalaire;
                }
                set
                {
                    NouveauSalaire = value;
                }
            }
            public decimal TauxAugmentation
            {
                get
                {
                    return ((_nouveauSalaire - _ancienSalaire) / _ancienSalaire) * 100;
                }
            }
        }
        
        protected virtual void OnChangementSalaire(object sender, ChangementSalaireEventArgs e)
        {
            ChangementSalaire?.Invoke(sender, e);
        }
        #endregion
    }
}
