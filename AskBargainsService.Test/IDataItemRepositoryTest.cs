using System.Data.Entity;
using AskBargains.DataEF.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AskBargains.DataEF.Models;
using System.Collections.Generic;

namespace AskBargainsService.Test
{
    
    
    /// <summary>
    ///This is a test class for IDataItemRepositoryTest and is intended
    ///to contain all IDataItemRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IDataItemRepositoryTest
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


        internal virtual IDataItemRepository CreateIDataItemRepository()
        {
            // TODO: Instantiate an appropriate concrete class.

            Database.SetInitializer(new DataItemInitializer());
            var context = new DataItemContext();
            context.Database.Initialize(true);

            IDataItemRepository target = new DataItemRepository(new DataItemContext());
            return target;
        }

        /// <summary>
        ///A test for GetDataItems
        ///</summary>
        [TestMethod()]
        public void GetDataItemsTest()
        {
            IDataItemRepository target = CreateIDataItemRepository(); // TODO: Initialize to an appropriate value
            var result = target.GetDataItems();
            Assert.AreEqual(result.Count, 4);
            Assert.AreEqual(result[0].Comments.Count , 3);
        }
    }
}
