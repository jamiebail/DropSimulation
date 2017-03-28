using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using McLarenSimulation;


namespace SimTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstGravityWeight_ValidValues_CorrectOutput()
        {
            //arrange
            Configuration.CMass = 10;
            Configuration.GAccel = 2;
            double expected = 20;
            double actual;
            //act
            actual = Operations.ConstGravityWeight();
            //assert
            Assert.AreEqual(expected, actual, 00.1);
        }

        [TestMethod]
        public void CalculateVelocity_ValidValues_CorrectOutput()
        {
            //arrange
            PreviousResult.Acceleration = 50;
            Configuration.TimeStep = 0.01;
            double expected = 0.5;
            double actual;
            //act
            actual = Operations.CalculateVelocity();
            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void CalculateHeight_ValidValues_CorrectOutput()
        {
            //arrange
            PreviousResult.Velocity = -2;
            Configuration.TimeStep = 0.1;
            PreviousResult.Acceleration = -1.5;
            double expected = -0.2075;
            double actual;
            //act
            actual = Operations.CalculateHeight();
            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void DragForce_ValidValues_CorrectOutput()
        {
            //arrange
            Configuration.Drag = 0.47;
            Configuration.FDensity = 1.225;
            Configuration.CRadius = 1;
            Result.Velocity = 2;
            double expected = 7.23142;
            //act
            double actual = Operations.DragForce();
            //assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void NewtonianWeight_Values_CorrectOutput()
        {
            //arrange            
            Configuration.GConst = 0.001;
            Configuration.PMass = 6000;
            Configuration.CMass = 2;
            Configuration.PRadius = 30;
            double height = 5;
            double expected = -0.00979;
            double actual;
            //act
            actual = Operations.NewtonianWeight(height);
            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void CalculateAcceleration_ValidValues_CorrectOutput()
        {
            Configuration.Drag = 0.47;
            Configuration.FDensity = 1.225;
            Configuration.CRadius = 1;
            Result.Velocity = 2;
            Configuration.Force = -1.9;
            double expected = 5.33142;
            //act
            double actual = Operations.CalculateAcceleration();
            //assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void CompleteStepToGround_HasHitGround_ReturnFalseLoopEnd()
        {
            Result.Height = 0;
            Assert.IsFalse(Operations.CompleteStepToGround());
        }
        [TestMethod]
        public void CompleteStepToGround_HasHitGround_TrueIsInAir()
        {
            Result.Height = 10;
            Assert.IsTrue(Operations.CompleteStepToGround());
        }

        [TestMethod]
        public void CompleteStep_ValidValues_CurrentStateFound()
        {
            //arrange
            Helpers.Reset();
            Configuration.Drag = 0.47;
            Configuration.FDensity = 1.225;
            Configuration.CRadius = 1;
            Result.Velocity = 2;
            Configuration.Force = -1.9;
            Configuration.TimeStep = 0.01;
            PreviousResult.Velocity = -0.5;
            PreviousResult.Acceleration = 5.331;
            double expectedAccel = 5.331;
            double expectedVelo = 2.05331;
            double expectedHeight = -0.00473345;
            //act
            Operations.CompleteStep();
            //assert
            Assert.AreEqual(expectedAccel, Result.Acceleration, 0.01);
            Assert.AreEqual(expectedVelo, Result.Velocity, 0.01);
            Assert.AreEqual(expectedHeight, Result.Height, 0.01);
        }
    }
}
