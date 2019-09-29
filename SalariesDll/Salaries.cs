using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.CompilerServices;
using System.Resources;
using System.Reflection;
using System.Drawing;
using System.Globalization;
using Utilities;

namespace SalariesDll
{
    [Serializable()]
    [XmlInclude(typeof(Commercial))]
    public class Salaries : List <Salarie>, ICollectionMetier
    {
        public new void Add(Salarie salarie)
        {
            foreach(Salarie element in this)
            {
                if (salarie.Equals(element))
                {
                    throw new SalaryException(ErrorCode.Error_001,string.Format(CultureInfo.CurrentCulture,ErrorCode.Error_001,salarie.Matricule));
                }
            }
            if (salarie.Matricule == null)
            {
                throw new SalaryException(ErrorCode.Error_002,string.Format(CultureInfo.CurrentCulture,ErrorCode.Error_002));
            }
            if (salarie.BirthDate == default(DateTime))
            {
                throw new SalaryException(ErrorCode.Error_003, string.Format(CultureInfo.CurrentCulture, ErrorCode.Error_003, salarie.Matricule));
            }
            if (salarie.LastName == null)
            {
                throw new SalaryException(ErrorCode.Error_004, string.Format(CultureInfo.CurrentCulture, ErrorCode.Error_004, salarie.Matricule));
            }
            if (salarie.LastName == null)
            {
                throw new SalaryException(ErrorCode.Error_005, string.Format(CultureInfo.CurrentCulture, ErrorCode.Error_005, salarie.Matricule));
            }
            base.Add(salarie);
        }

        public Salarie GetSalarie(string matricule)
        {
            if (matricule == null)
            {
                throw new ArgumentNullException(nameof(matricule));
            }

            foreach(Salarie element in this)
            {
                if (matricule.Equals(element.Matricule))
                {
                    return element; 
                }
            }
            return null;
        }

        public void DeleteSalarie(string matricule)
        {
            if (matricule == null)
            {
                throw new ArgumentNullException(nameof(matricule));
            }
            foreach(Salarie element in this)
            {
                if (matricule.Equals(element.Matricule))
                {
                
                    Remove(element);
                    break;
                }
            }
        }

        public void DeleteSalarie(Salarie salarie)
        {
            if (salarie == null)
            {
                throw new ArgumentNullException(nameof(salarie));
            }
            foreach(Salarie element in this)
            {
                if (salarie.Equals(element))
                {
                    Remove(element);
                    break;
                }
            }
        }

        #region Méthodes de lecture et ecriture fichier csv
        /// <summary>
        /// Crée un fichier y enregistre les objets stocké dans la List Salaries
        /// </summary>
        /// <param name="path"></param>
        public void CreateAndWrite(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Salarie element in this)
            {
                sw.WriteLine(element.ToString());
            }
            sw.Close();
            fs.Close();
        }
        /// <summary>
        /// Methode permettant de lire le fichier généré par CreateAndWrite et d'attribuer les proprités aux Salarie
        /// </summary>
        /// <param name="path"></param>
        public Salaries ReadFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            Salaries myList = new Salaries();
            string output = sr.ReadLine();
            while (output != null)
            {
                char[] delimeterChar = { ':', ';' };
                string[] myTabSplit = output.Split(delimeterChar);
                Salarie salarie = new Salarie();
                salarie.Matricule = myTabSplit[1];
                salarie.LastName = myTabSplit[3];
                salarie.FirstName = myTabSplit[5];
                salarie.GrossSalary = decimal.Parse(myTabSplit[7]);
                salarie.SocialRate = decimal.Parse(myTabSplit[9]);
                salarie.BirthDate = DateTime.Parse(myTabSplit[11]);


                myList.Add(salarie);
                output = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return myList;
        }
        #endregion

        #region Méthodes de lecture et écriture fichier dat
        public void SaveBinary(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        public Salaries LoadBinary(string path)
        {
            Salaries myList = new Salaries();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            myList.AddRange(bf.Deserialize(fs) as Salaries);
            fs.Close();
            return myList;
        }
        #endregion

        #region Méthodes de lecture et écriture fichier Xml
        public void SaveXml(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Salaries));
            XmlTextWriter writter = new XmlTextWriter(fs, Encoding.UTF8);
            serializer.Serialize(writter, this);
            fs.Close();
        }

        public Salaries LoadXml(string path)
        {
            Salaries myList = new Salaries();
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlTextReader reader = new XmlTextReader(fs);
            XmlSerializer serializer = new XmlSerializer(typeof(Salaries));
            myList = (Salaries)serializer.Deserialize(reader);
            return myList;
        }

        public void Save(ISave<Salaries> save)
        {
            save.Save(this);
        }

        public void Load(ISave<Salaries> load)
        {
            load.Load();
        }
        #endregion

    }
}
