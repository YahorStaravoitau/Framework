using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestFramework.Serialization
{
    [XmlRoot("Journals", Namespace = "")]
    public class Journals
    {
        [XmlElement("Journal", typeof(Serialization.Journal))]
        public List<Serialization.Journal> List { get; set; }
    }
}
