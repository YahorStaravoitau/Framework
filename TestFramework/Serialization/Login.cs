using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestFramework.Serialization
{
    public class Login
    {
        [XmlAttribute("username")]
        public string Username { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }
    }
}
