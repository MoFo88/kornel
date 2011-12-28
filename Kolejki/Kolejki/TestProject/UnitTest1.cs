using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathNet;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MathNet.Numerics.Distributions.ExponentialDistribution ex = new MathNet.Numerics.Distributions.ExponentialDistribution();
            ex.Rate = 1.0;
            Assert.AreEqual(ex.Rate, 1.0);
            ex.Rate = 1.2;
            Assert.AreEqual(ex.Rate, 1.2);
        }
    }
}
