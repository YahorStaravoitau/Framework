﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestFramework;

namespace MSUnitTest
{
    [Ignore]
    [TestClass]
    public class MSUnitTest
    {
        private PageObject page = new PageObject();

        private static List<Journal> journals;
        private static Dictionary<string, Journal> dictionary = new Dictionary<string, Journal>();

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [AssemblyInitialize()]
        public static void Init(TestContext context)
        {
            journals = ExcelReader.ParseExcel();
            foreach (Journal j in journals)
                dictionary.Add(j.Name, j);
        }

        [Ignore]
        [TestMethod]
        [DeploymentItem("MSUnitTest\\JournalTestData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"C:\Users\Yahor_Staravoitau\Documents\Visual Studio 2015\Projects\LWWTest\LWWTest\JournalTestData.xml", "Journal",
                    DataAccessMethod.Sequential)]
        public void MSUnitTestJournals()
        {
            string key = (string)TestContext.DataRow["Data"];
            Journal journal = dictionary[key];
            page.NavigateHere($"{journal.Name}/");
            foreach (Category cat in journal.category)
            {
                page.SetNaviLocator(cat.Name);
                if (cat.elements != null)
                    page.CheckNavi();
                foreach (Element e in cat.elements)
                {
                    page.SetMenuLocator(e.Name);
                }
            }
        }
    }
}
