using Kolejki.F;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for SocketTest and is intended
    ///to contain all SocketTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SocketTest
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
        ///A test for Socket Constructor
        ///</summary>
        [TestMethod()]
        public void SocketConstructorTest()
        {
            Scheduler s = new Scheduler();
            IQueue q = new QueueFifo(s, 5);
            Socket target = new Socket(q, s);
        }

        /// <summary>
        ///A test for MakeConnection
        ///</summary>
        [TestMethod()]
        public void MakeConnectionTest_makeConnectionTwice()
        {
            Scheduler s = new Scheduler();
            Socket prev = new Socket(new QueueFifo(s,5 ), s);
            Socket next = new Socket(new QueueFifo(s, 5), s);

            Socket.MakeConnection(prev, next);
            Socket.MakeConnection(prev, next);

            Assert.AreEqual(prev.nextSockets.Where(x => x == next).ToList().Count, 1);
            Assert.AreEqual(next.prevSockets.Where(x => x == prev).ToList().Count, 1);
        }

        [TestMethod()]
        public void MakeConnectionTest_AreConnected()
        {
            Scheduler s = new Scheduler();
            Socket prev = new Socket(new QueueFifo(s,5), s);
            Socket next = new Socket(new QueueFifo(s,5), s);
            
            Socket.MakeConnection(prev, next);

            Assert.AreEqual( prev.nextSockets.Where( x => x == next ).ToList().Count, 1);
            Assert.AreEqual(next.prevSockets.Where(x => x == prev).ToList().Count, 1);
        }
    }
}
