using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLarenSimulation
{
    // Persistent record of current sphere physics.
   public static class Result
    {
        public static double Acceleration { get; set; }
        public static double Velocity { get; set; }
        public static double Height { get; set; }
        public static double Time { get; set; }
    }

    // Persistent record of sphere physics from previous step.
    public static class PreviousResult
    {
        public static double Acceleration { get; set; }
        public static double Velocity { get; set; }
        public static double Height { get; set; }
        public static double Time { get; set; }
    }
}
