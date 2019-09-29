using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Utilities
{
    public class XmlSave<T> : ISave<T>
    {
        private string path;
        public XmlSave(string path)
        {
            this.path = path;
        }
        public T Load()
        {
            T objet = default(T);
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlTextReader reader = new XmlTextReader(fs);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            objet = (T)serializer.Deserialize(reader);
            reader.Close();
            fs.Close();

            return objet;
        }

        public void Save(T instance)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlTextWriter writter = new XmlTextWriter(fs, Encoding.UTF8);
            serializer.Serialize(writter, instance);
            fs.Close();
        }
    }
}
