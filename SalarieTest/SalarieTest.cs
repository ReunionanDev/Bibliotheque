using System;
using System.Collections;
using System.IO;
using System.Text;
using SalariesDll;
using static SalariesDll.Salarie;
using Utilities;

namespace Test
{
    class SalarieTest
    {
        static void Main(string[] args)
        {
            Salarie salarie1 = new Salarie
            {
                FirstName = "Rip",
                LastName = "Krilin",
                Matricule = "52abc87",
                BirthDate = new DateTime(1988,08,30) 
            };
            Salarie salarie2 = new Salarie
            {
                FirstName = "Magic",
                LastName = "Boubou",
                Matricule = "52abc85",
                BirthDate = new DateTime(1990, 12, 30)
            };
            Commercial commercial1 = new Commercial
            {
                FirstName = "Hercule",
                LastName = "Satan",
                Matricule = "78abc45",
                BirthDate = new DateTime(1992, 12, 25)
            };
            Salaries myList = new Salaries();
            myList.Add(salarie1);
            myList.Add(salarie2);
            myList.Add(commercial1);

            foreach (Salarie salarie in myList)
            {
                Console.WriteLine(salarie.Matricule);
            }

            //myList.SaveXml(@"C:\Users\CDA\source\repos\SalariesDll\Salaries.xml");
            //myList.LoadXml(@"C:\Users\CDA\source\repos\SalariesDll\Salaries.xml");
            ISave<Salaries> save = new XmlSave<Salaries>(@"C:\Users\CDA\source\repos\SalariesDll\Salaries.xml");
            myList.Save(save);
            myList.DeleteSalarie(salarie1);
            ISave<Salaries> load = new XmlSave<Salaries>(@"C:\Users\CDA\source\repos\SalariesDll\Salaries.xml");
            myList.Load(load);

            foreach (Salarie salarie in myList)
            {
                Console.WriteLine(salarie.Matricule);
            }

            Salarie s = new Salarie();
            s.GrossSalary = 1800;
            s.ChangementSalaire += S_ChangementSalaire;
            s.GrossSalary = 1900;
            
        }

        static void S_ChangementSalaire(object sender, ChangementSalaireEventArgs e)
        {
            Console.WriteLine("salaire changé de " + e.AncienSalaire + " euros à " + e.NouveauSalaire + " euros et le taux d'augmentation est de " + e.TauxAugmentation + "%");
        }
    }

}
