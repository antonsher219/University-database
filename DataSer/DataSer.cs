using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace DataSerializer
{
    public class DataSerialize
    {

        public static void SaveToXml(UniversitiesContainer a, string fileName)
        {
            XmlWriter writer = new XmlTextWriter(fileName, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(a.GetType());
            serializer.Serialize(writer, a);
            writer.Close();
        }

        public static UniversitiesContainer LoadFromXml(string fileName)
        {
            XmlReader reader = new XmlTextReader(fileName);
            XmlSerializer serializer = new XmlSerializer(typeof(UniversitiesContainer));
            UniversitiesContainer result = (UniversitiesContainer)serializer.Deserialize(reader);
            reader.Close();
            return result;
        }
    }
}
