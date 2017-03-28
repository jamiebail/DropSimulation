using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLarenSimulation
{
    /// <summary>
    /// Persistent configuration class, members populated at simulation time, used throughout Operations functions.
    /// </summary>
    public class SphereDrop : IConfiguration
    {
        public double Drag { get; set; }
        public double FDensity { get; set; }
        public double CRadius { get; set; }
        public double CMass { get; set; }
        public double GAccel { get; set; }
        public double GConst { get; set; }
        public double PMass { get; set; }
        public double PRadius { get; set; }
        public double Velocity { get; set; }
        public double Height { get; set; }
        public double FinishTime { get; set; }
        public double TimeStep { get; set; }
        public double Force { get; set; }
    }
}
