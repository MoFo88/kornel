using Kolejki.F;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Kolejki.MyMath;
using MathNet.Numerics.Distributions;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for JobTest and is intended
    ///to contain all JobTest Unit Tests
    ///</summary>
    [TestClass()]
    public class JobTest
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

        [TestMethod()]
        public void TestDistribution()
        {
            NormalDistribution distr = new NormalDistribution(10, 2);
            Assert.AreEqual(10, distr.Mean);
            Assert.AreEqual(10, distr.Median);
            Assert.AreEqual(10, distr.Mu);
            Assert.AreEqual(4, distr.Variance);

        }

    }
}
