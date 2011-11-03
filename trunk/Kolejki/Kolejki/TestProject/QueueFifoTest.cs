using Kolejki.F;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Kolejki.MyMath;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for QueueFifoTest and is intended
    ///to contain all QueueFifoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class QueueFifoTest
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
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            Scheduler s = new Scheduler(); 
            int size = 10; 
            QueueFifo target = new QueueFifo(s, size); 
            
            Job expected = null; 
            Job actual;
            actual = target.Get();
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Get2Test()
        {
            Scheduler s = new Scheduler();
            int size = 10;
            QueueFifo target = new QueueFifo(s, size);

            Job job = new Job(new List<Socket>(), new NormalDistr(), 0);

            Assert.AreEqual(true, target.IsEmpty);

            target.Put(job);

            Assert.AreEqual(1, target.Count);
            Assert.AreEqual(10, target.Size);
            Assert.AreEqual(false, target.IsFull);
            Assert.AreEqual(false, target.IsEmpty);

            Job expected = job;
            Job actual;
            actual = target.Get();

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(0, target.Count);
        }

        /// <summary>
        ///A test for Put
        ///</summary>
        [TestMethod()]
        public void PutTest()
        {
            Scheduler s = new Scheduler();
            int size = 3;
            QueueFifo target = new QueueFifo(s, size);

            Job job1 = new Job(new List<Socket>(), new NormalDistr(), 0);
            Job job2 = new Job(new List<Socket>(), new NormalDistr(), 0);
            Job job3 = new Job(new List<Socket>(), new NormalDistr(), 0);
            Job job4 = new Job(new List<Socket>(), new NormalDistr(), 0);

            Assert.AreEqual(true, target.IsEmpty);

            target.Put(job1);

            Assert.AreEqual(1, target.Count);
            Assert.AreEqual(3, target.Size);
            Assert.AreEqual(false, target.IsFull);
            Assert.AreEqual(false, target.IsEmpty);

            target.Put(job1);

            Assert.AreEqual(1, target.Count);
            Assert.AreEqual(3, target.Size);
            Assert.AreEqual(false, target.IsFull);
            Assert.AreEqual(false, target.IsEmpty);

            target.Put(job2);

            Assert.AreEqual(2, target.Count);
            Assert.AreEqual(3, target.Size);
            Assert.AreEqual(false, target.IsFull);
            Assert.AreEqual(false, target.IsEmpty);

            target.Put(job3);

            Assert.AreEqual(3, target.Count);
            Assert.AreEqual(3, target.Size);
            Assert.AreEqual(true, target.IsFull);
            Assert.AreEqual(false, target.IsEmpty);

            target.Put(job4);

            Assert.AreEqual(3, target.Count);
            Assert.AreEqual(3, target.Size);
            Assert.AreEqual(true, target.IsFull);
            Assert.AreEqual(false, target.IsEmpty);
        }
    }
}
