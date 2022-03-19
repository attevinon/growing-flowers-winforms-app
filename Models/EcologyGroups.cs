using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal interface IEcologyGroup
    {
        int SoilDryingTime { get; }
        int TheRequiredAmountOfWatering { get; }
    }

    internal readonly struct Xerophyte : IEcologyGroup
    {
        public int SoilDryingTime { get => 30000; }
        public int TheRequiredAmountOfWatering { get => 1; }
    }

    internal readonly struct Mesophyte : IEcologyGroup
    {
        public int SoilDryingTime { get => 20000; }
        public int TheRequiredAmountOfWatering { get => 2; }
    }

    internal readonly struct Hygrophyte : IEcologyGroup
    {
        public int SoilDryingTime { get => 10000; }
        public int TheRequiredAmountOfWatering { get => 3; }
    }
}
