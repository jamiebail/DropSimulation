using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McLarenSimulation
{
    public static class Operations
    {
        /// <summary>
        /// Calculate Drag Force of Sphere
        /// </summary>
        /// <returns></returns>
        public static double DragForce()
        {
            double result = Configuration.Drag * Configuration.FDensity * Result.Velocity * Result.Velocity * Math.PI * Configuration.CRadius * Configuration.CRadius;
            return Math.Abs(result);
        }

        public static double ConstGravityWeight()
        {
            return Configuration.CMass * Configuration.GAccel;
        }

        public static double NewtonianWeight(double height)
        {
            var top = Configuration.GConst * Configuration.PMass * Configuration.CMass;
            var bottom = Math.Pow(Configuration.PRadius + height, 2);
            var result = top / bottom;
            return -result;
        }

        public static double CalculateAcceleration()
        {
            double dragForce = DragForce();
            double result = Configuration.Force + dragForce;
            return result;
        }

        public static double CalculateVelocity()
        {
            return PreviousResult.Acceleration * Configuration.TimeStep;
        }

        public static double CalculateHeight()
        {
            return PreviousResult.Velocity * Configuration.TimeStep + 0.5 * PreviousResult.Acceleration * Math.Pow(Configuration.TimeStep, 2);
        }

        /// <summary>
        /// Method providing conditional access to each process step.
        /// </summary>
        /// <param name="newtonian"></param>
        /// <returns></returns>
        public static bool CompleteStepToGround()
        {
            if (Result.Height <= 0) return false;
                CompleteStep();
            if (Result.Height >= 0) return true;
            else return false;
        }

        /// <summary>
        /// Process step, moves ball after calculating sphere physics.
        /// </summary>
        public static void CompleteStep()
        { 
            Result.Acceleration = CalculateAcceleration();
            Result.Velocity += CalculateVelocity();
            Result.Height += CalculateHeight();
        }



    }
}
