using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;

namespace Kolejki.MyMath
{
    class UniformDistr : IDistribution
    {
        ContinuousUniformDistribution distr;

        public int NextValue()
        {
            double val = distr.NextDouble();
            return (int)Math.Ceiling(val);
        }

        public UniformDistr(double min, double max)
        {
            distr = new ContinuousUniformDistribution(min, max);
        }

        public string Name
        {
            get { return "Uniform distribution"; }
        }
    }
}
