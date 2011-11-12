using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kolejki.MyMath
{
    public interface IDistribution
    {
        String Name { get; } 
        int NextValue();
    }
}
