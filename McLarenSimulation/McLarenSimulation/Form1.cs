using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace McLarenSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // Simulate buttom clicked
        private void button1_Click(object sender, EventArgs e)
        {
            GenerateConfig();
            RunSimulation();
        }

        /// <summary>
        /// Assigns static configuration class members using input data.
        /// </summary>
        public void GenerateConfig()
        {
            double drag = -1;
            double fDensity = -1;
            double cRadius = -1;
            double cMass = -1;
            double gAccel = -1;
            double gConst = -1;
            double pMass = -1;
            double pRadius = -1;
            double velocity = -1;
            double height = -1;
            double time = -1;
            double step = -1;

            double.TryParse(DragInput.Text, out drag);
            double.TryParse(FDensityInput.Text, out fDensity);
            double.TryParse(RadiusInput.Text, out cRadius);
            double.TryParse(MassInput.Text, out cMass);
            double.TryParse(GravityAccelInput.Text, out gAccel);
            double.TryParse(UniGravityInput.Text, out gConst);
            double.TryParse(PlanetMassInput.Text, out pMass);
            double.TryParse(PlanetRaduisInput.Text, out pRadius);
            double.TryParse(VelocityInput.Text, out velocity);
            double.TryParse(HeightInput.Text, out height);
            double.TryParse(DurationInput.Text, out time);
            double.TryParse(StepInput.Text, out step);

            Configuration.Drag = drag;
            Configuration.FDensity = fDensity;
            Configuration.CRadius = cRadius;
            Configuration.CMass = cMass;
            Configuration.GAccel = gAccel;
            Configuration.GConst = gConst;
            Configuration.PMass = pMass;
            Configuration.PRadius = pRadius;
            Configuration.Height = height;
            Configuration.Velocity = velocity;
            Configuration.FinishTime = time;
            Configuration.TimeStep = step;
            Configuration.Force = NewtonianCheck.Checked ? Operations.NewtonianWeight(Result.Height) : -Operations.ConstGravityWeight(); // Calculate force of sphere depending on simulation type.
        }

        /// <summary>
        ///  Main simulation method. 
        /// </summary>
       public void RunSimulation()
        {
            listBox1.Items.Clear();
            Result.Velocity = Configuration.Velocity;
            Result.Height = Configuration.Height;            
            double steps = Configuration.FinishTime / Configuration.TimeStep;  // Calculate number of loops.      
            Stopwatch watch = Stopwatch.StartNew();
            bool looping = true;

            for (int i = 0; i < (int)steps; i++)
                {
                    Result.Time = watch.Elapsed.TotalSeconds;
                    looping = Operations.CompleteStepToGround();
                    if (!looping) break;
                    PrintValues();
                    Helpers.updatePrevious();
                }
            Helpers.Reset(); 
        }



        // UI update and refresh on new result arrival (Apologies for label names, short time frame!!!)
        public void PrintValues()
        {
            Console.WriteLine("Height: " + Result.Height);
            Console.WriteLine("Acceleration: " + Result.Acceleration);
            Console.WriteLine("Velocity: " + Result.Velocity);
            listBox1.Items.Add("H: " + Result.Height +"    A: " + Result.Acceleration + "   V: " + Result.Velocity);
            label9.Text = "Height: " + Result.Height;
            label10.Text = "Acceleration: " + Result.Acceleration;
            label11.Text = "Velocity: " + Result.Velocity;
            label13.Text = Result.Time.ToString();
            label9.Refresh();
            label10.Refresh();
            label11.Refresh();
            label13.Refresh();
            listBox1.Refresh();

        }
      
    }
}
