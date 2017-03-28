using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLarenSimulation
{
    public static class Helpers
    {
        // Reset static objects when simulation is rerun.
        public static void Reset()
        {
            PreviousResult.Acceleration = 0;
            PreviousResult.Time = 0;
            PreviousResult.Height = 0;
            PreviousResult.Velocity = 0;
            Result.Acceleration = 0;
            Result.Time = 0;
            Result.Height = 0;
            Result.Velocity = 0;
        }

        // Assign values to previous results object, used in later operations.
        public static void updatePrevious()
        {
            PreviousResult.Acceleration = Result.Acceleration;
            PreviousResult.Height = Result.Height;
            PreviousResult.Velocity = Result.Velocity;
            PreviousResult.Time = Result.Time;
        }
    }
}
