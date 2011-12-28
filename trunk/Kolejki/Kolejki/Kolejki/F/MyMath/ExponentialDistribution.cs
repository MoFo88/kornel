using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kolejki.MyMath;
using MathNet;

namespace Kolejki.F.MyMath
{
    public class ExponentialDistribution : IDistribution
    {
        MathNet.Numerics.Distributions.ExponentialDistribution distr;
        
        public ExponentialDistribution(double rate)
        {
            distr = new MathNet.Numerics.Distributions.ExponentialDistribution(rate);

        }

        public string Name
        {
            get { return "Exponential"; }
        }

        public int NextValue()
        {
            int x = (int)Math.Ceiling(distr.NextDouble());
            return x;
        }
    }
}
