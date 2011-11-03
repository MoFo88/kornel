using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;

namespace Kolejki.MyMath
{
    class NormalDistr : IDistribution
    {
        public String Name { get { return "Normal distribution"; } }
        NormalDistribution distr;

        public int NextValue()
        {
            double val = distr.NextDouble();

            //todo: change
            return new Random().Next(15)+2;
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
