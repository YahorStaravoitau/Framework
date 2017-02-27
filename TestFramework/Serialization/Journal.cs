using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestFramework.Serialization
{
    [XmlRoot("Journal")]
    public class Journal
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("Login", typeof(Login))]
        public Login Login { get; set; }

        [XmlElement("Search", typeof(Search))]
        public Search Search { get; set; }
    }
}
