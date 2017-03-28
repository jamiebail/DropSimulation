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
    public static class Configuration
    {
        public static double Drag { get; set; }
        public static double FDensity { get; set; }
        public static double CRadius { get; set; }
        public static double CMass { get; set; }
        public static double GAccel { get; set; }
        public static double GConst { get; set; }
        public static double PMass { get; set; }
        public static double PRadius { get; set; }
        public static double Velocity { get; set; }
        public static double Height { get; set; }
        public static double FinishTime { get; set; }
        public static double TimeStep { get; set; }
        public static double Force { get; set; }
    }
}
