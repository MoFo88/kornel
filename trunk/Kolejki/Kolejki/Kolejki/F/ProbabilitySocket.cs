using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kolejki.MyMath;

namespace Kolejki.F
{
    class ProbabilitySocket : Socket
    {
        public ProbabilitySocket(IQueue distr, Scheduler s, bool start = false)
            : base(distr, s, start)
        {
        }
    }
}
