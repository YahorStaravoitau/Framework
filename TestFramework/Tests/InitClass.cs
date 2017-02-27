using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TestFramework.TestingData;
using TestFramework.Serialization;

namespace TestFramework
{
    [TestFixture]
    public class InitClass
    {
        protected static List<Journal> journals = ExcelReader.ParseExcel();
        protected static List<string> journalChoice = XMLReader.ReadFromXML();
        protected Dictionary<string, Journal> dictionary = new Dictionary<string, Journal>();
        protected static Journals testdata = Deserializer.Deserialize();


        [OneTimeSetUp]
        public void SetUp()
        {
            foreach (Journal j in journals)
                dictionary.Add(j.Name, j); 
        }
    }
}
