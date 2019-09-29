using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Liste_d_objets
{   /// <summary>
    /// Class regroupant les méthodes de création, d'écriture et de lecture d'un fichier
    /// </summary>
    public class FileWritter
    {   /// <summary>
        /// Methode permettant de Créer un fichier txt et écrire dans celui-ci
        /// </summary>
        public static void CreateAndWrite(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);


            string input = Console.ReadLine();
            sw.WriteLine(input);
            sw.Close();
            fs.Close();
        }
        /// <summary>
        /// Methode permettant d'afficher a la console le texte présent dans un fichier
        /// </summary>
        /// <param name="path"></param>
        public static void ReadFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string output = sr.ReadLine();
            while (output != null)
            {
                Console.WriteLine(output);
                output = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

    }
}
