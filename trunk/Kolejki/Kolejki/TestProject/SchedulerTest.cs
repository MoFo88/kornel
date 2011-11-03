using Kolejki.F;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kolejki.MyMath;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for SchedulerTest and is intended
    ///to contain all SchedulerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SchedulerTest
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
        ///A test for CheckIfGenerateJob
        ///</summary>


        /// <summary>
        ///A test for loop
        ///</summary>
        [TestMethod()]
        public void loopTest()
        {
            Scheduler scheduler = new Scheduler();
            scheduler.Initialize();

            Socket s1 = scheduler.socketList.GetFirstSocket();

            Assert.AreEqual(0, s1.queue.Count);

            Job job1 = scheduler.jobList.Create(new NormalDistr(0, 1), scheduler.socketList, scheduler.timestamp, scheduler);
            bool added = s1.queue.Put(job1);

            Assert.AreEqual(1, s1.queue.Count );

            Job job2 = scheduler.jobList.Create(new NormalDistr(0, 1), scheduler.socketList, scheduler.timestamp, scheduler);
            bool added2 = s1.queue.Put(job2);

            Assert.AreEqual(2, s1.queue.Count);

        }
    }
}
