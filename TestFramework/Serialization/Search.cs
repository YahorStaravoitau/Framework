using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestFramework.Serialization
{
    public class Search
    {
        [XmlAttribute("text")]
        public string Text { get; set; }
    }
}
