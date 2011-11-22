using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;

namespace Kolejki.MyMath
{
    class UniformDistr : IDistribution
    {
        DiscreteUniformDistribution distr;

        public int NextValue()
        {
            int val = distr.NextInt32();
            return val;
        }

        public UniformDistr(int min, int max)
        {
            distr = new DiscreteUniformDistribution(min, max);
        }

        public string Name
        {
            get { return "Uniform distr"; }
        }
    }
}
