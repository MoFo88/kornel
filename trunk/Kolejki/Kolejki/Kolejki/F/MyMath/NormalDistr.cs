using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;

namespace Kolejki.MyMath
{
    class NormalDistr : IDistribution
    {
        public String Name { get { return "Normal distr"; } }
        NormalDistribution distr;

        public int NextValue()
        {
            double val = distr.NextDouble();
            if (val < 0) val = 0;
            return (int)val;
        }

        public NormalDistr()
        {
            distr = new NormalDistribution(0, 1);
        }

        public NormalDistr(double mu, double sigma)
        {
            distr = new NormalDistribution(mu, sigma);
        }

        public override string ToString()
        {
            return "";
        }
    }
}
