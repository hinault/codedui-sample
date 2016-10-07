using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITest
{
    /// <summary>
    /// Summary description for CodedUITestEtudiant
    /// </summary>
    [CodedUITest]
    public class CodedUITestEtudiant
    {
        public CodedUITestEtudiant()
        {
        }

        [TestMethod]
        public void CodedUITestAjoutEtudiant_CasInvalide()
        {

            this.UIMap.RecordedAjoutEtudiant_Invalide();
            this.UIMap.AssertValidationDate();

        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv")]
        public void CodedUITestAjoutEtudiant()
        {
            
           this.UIMap.RecordedAjoutEtudiantParams.UINomEditText = TestContext.DataRow["Nom"].ToString();
            this.UIMap.RecordedAjoutEtudiantParams.UIPrénomEditText = TestContext.DataRow["Prenom"].ToString();
            this.UIMap.RecordedAjoutEtudiantParams.UIEmailEditText1 = TestContext.DataRow["Email"].ToString();
            this.UIMap.RecordedAjoutEtudiantParams.UISexeEditText = TestContext.DataRow["Sexe"].ToString();
            this.UIMap.RecordedAjoutEtudiantParams.UIDatedeNaissanceEditText = Convert.ToDateTime(TestContext.DataRow["DateNais"].ToString()).ToShortDateString();

            this.UIMap.RecordedAjoutEtudiant();
            this.UIMap.AssertEtudiantAjoute();

        }


        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            this.UIMap.RecordedLaunchApp();

        }

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
