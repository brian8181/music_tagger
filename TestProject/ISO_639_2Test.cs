using music_tagger;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for ISO_639_2Test and is intended
    ///to contain all ISO_639_2Test Unit Tests
    ///</summary>
    [TestClass()]
    public class ISO_639_2Test
    {


        private TestContext testContextInstance;

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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FrenchName
        ///</summary>
        [TestMethod()]
        public void FrenchNameTest()
        {
            ISO_639_2 target = new ISO_639_2(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FrenchName = expected;
            actual = target.FrenchName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EnglishName
        ///</summary>
        [TestMethod()]
        public void EnglishNameTest()
        {
            ISO_639_2 target = new ISO_639_2(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.EnglishName = expected;
            actual = target.EnglishName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Alpha_3
        ///</summary>
        [TestMethod()]
        public void Alpha_3Test()
        {
            ISO_639_2 target = new ISO_639_2(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Alpha_3 = expected;
            actual = target.Alpha_3;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Alpha_2
        ///</summary>
        [TestMethod()]
        public void Alpha_2Test()
        {
            ISO_639_2 target = new ISO_639_2(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Alpha_2 = expected;
            actual = target.Alpha_2;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            ISO_639_2 target = new ISO_639_2(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ISO_639_2 Constructor
        ///</summary>
        [TestMethod()]
        public void ISO_639_2ConstructorTest3()
        {
            string alpha_3 = string.Empty; // TODO: Initialize to an appropriate value
            string english = string.Empty; // TODO: Initialize to an appropriate value
            ISO_639_2 target = new ISO_639_2(alpha_3, english);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ISO_639_2 Constructor
        ///</summary>
        [TestMethod()]
        public void ISO_639_2ConstructorTest2()
        {
            ISO_639_2 target = new ISO_639_2();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ISO_639_2 Constructor
        ///</summary>
        [TestMethod()]
        public void ISO_639_2ConstructorTest1()
        {
            string alpha_2 = string.Empty; // TODO: Initialize to an appropriate value
            string alpha_3 = string.Empty; // TODO: Initialize to an appropriate value
            string english = string.Empty; // TODO: Initialize to an appropriate value
            ISO_639_2 target = new ISO_639_2(alpha_2, alpha_3, english);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ISO_639_2 Constructor
        ///</summary>
        [TestMethod()]
        public void ISO_639_2ConstructorTest()
        {
            string alpha_2 = string.Empty; // TODO: Initialize to an appropriate value
            string alpha_3 = string.Empty; // TODO: Initialize to an appropriate value
            string english = string.Empty; // TODO: Initialize to an appropriate value
            string french = string.Empty; // TODO: Initialize to an appropriate value
            ISO_639_2 target = new ISO_639_2(alpha_2, alpha_3, english, french);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
