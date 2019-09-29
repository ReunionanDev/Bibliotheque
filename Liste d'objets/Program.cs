using System;
using System.Collections;
using SalariesDll;

namespace Liste_d_objets
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Objets1 = CreerListeHeteroclite();
            PrintValues(Objets1);
            
            
        }
        public static ArrayList CreerListeHeteroclite()
        {
            ArrayList Objets = new ArrayList();
            Objets.Add(10);
            Objets.Add(0.2M);
            Objets.Add("ma chaine");

            Commercial commercial1 = new Commercial
            {
                GrossSalary = 1850,
                SocialRate = 0.2M,
                Turnover = 10000,
                Commission = 5,
                BirthDate = new DateTime(1988, 8, 30),
                LastName = "Ramidge",
                FirstName = "Gael",
                Matricule = "30abc88"
            };
            Salarie salarie1 = new Salarie
            {
                GrossSalary = 1500,
                SocialRate = 0.1M,
                BirthDate = new DateTime(1985, 1, 25),
                LastName = "LeThomas",
                FirstName = "Yannick",
                Matricule = "25der45"
            };
            Salarie salarie2 = new Salarie
            {
                GrossSalary = 1900,
                SocialRate = 0.3M,
                BirthDate = new DateTime(1990, 12, 18),
                LastName = "DORIGNY",
                FirstName = "Pierrot",
                Matricule = "12aze12"
            };

            Objets.Add(salarie1);
            Objets.Add(salarie2);
            Objets.Add(commercial1);

            return Objets;
        }
        public static void PrintValues(ArrayList mylist)
        {
            foreach (object element in mylist)
            {
                if (element is int)
                {
                    Console.WriteLine("C'est un numérique : {0}", element.ToString());
                }
                if (element.GetType() == typeof(Salarie)) 
                {
                    Console.WriteLine("C 'est un salarié : {0}", ((Salarie)element).LastName);
                }
                if (element is decimal)
                {
                    Console.WriteLine("C'est un numérique : {0}", element.ToString());
                }
                if (element is Commercial)
                {
                    Console.WriteLine("C'est un commercial : {0} et sa commission est de {1}%",((Commercial)element).LastName,((Commercial)element).Commission);
                }
            }
        }

        
    }
}
