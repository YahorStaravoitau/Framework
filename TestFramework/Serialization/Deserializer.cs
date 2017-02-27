using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using TestFramework.TestingData;

namespace TestFramework
{
    public class Deserializer
    {
        private static Serialization.Journals journals = null;
        private static XmlSerializer serializer = new XmlSerializer(typeof(Serialization.Journals));
        private static StreamReader reader = new StreamReader(Data.xmlPath);

        public static Serialization.Journals Deserialize()
        {
            journals = (Serialization.Journals)serializer.Deserialize(reader);
            reader.Close();
            return journals;
        }
    }
}
