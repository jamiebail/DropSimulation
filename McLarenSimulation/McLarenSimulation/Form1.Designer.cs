﻿namespace McLarenSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DragInput = new System.Windows.Forms.TextBox();
            this.FDensityInput = new System.Windows.Forms.TextBox();
            this.RadiusInput = new System.Windows.Forms.TextBox();
            this.MassInput = new System.Windows.Forms.TextBox();
            this.GravityAccelInput = new System.Windows.Forms.TextBox();
            this.UniGravityInput = new System.Windows.Forms.TextBox();
            this.PlanetMassInput = new System.Windows.Forms.TextBox();
            this.PlanetRaduisInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NewtonianCheck = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.VelocityInput = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DurationInput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.StepInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DragInput
            // 
            this.DragInput.Location = new System.Drawing.Point(20, 203);
            this.DragInput.Name = "DragInput";
            this.DragInput.Size = new System.Drawing.Size(100, 29);
            this.DragInput.TabIndex = 1;
            this.DragInput.Text = "0.47";
            // 
            // FDensityInput
            // 
            this.FDensityInput.Location = new System.Drawing.Point(174, 203);
            this.FDensityInput.Name = "FDensityInput";
            this.FDensityInput.Size = new System.Drawing.Size(100, 29);
            this.FDensityInput.TabIndex = 2;
            this.FDensityInput.Text = "1.225";
            // 
            // RadiusInput
            // 
            this.RadiusInput.Location = new System.Drawing.Point(328, 203);
            this.RadiusInput.Name = "RadiusInput";
            this.RadiusInput.Size = new System.Drawing.Size(100, 29);
            this.RadiusInput.TabIndex = 5;
            this.RadiusInput.Text = "1";
            // 
            // MassInput
            // 
            this.MassInput.Location = new System.Drawing.Point(20, 283);
            this.MassInput.Name = "MassInput";
            this.MassInput.Size = new System.Drawing.Size(100, 29);
            this.MassInput.TabIndex = 6;
            this.MassInput.Text = "1";
            // 
            // GravityAccelInput
            // 
            this.GravityAccelInput.Location = new System.Drawing.Point(174, 283);
            this.GravityAccelInput.Name = "GravityAccelInput";
            this.GravityAccelInput.Size = new System.Drawing.Size(100, 29);
            this.GravityAccelInput.TabIndex = 7;
            this.GravityAccelInput.Text = "9.81";
            // 
            // UniGravityInput
            // 
            this.UniGravityInput.Location = new System.Drawing.Point(329, 283);
            this.UniGravityInput.Name = "UniGravityInput";
            this.UniGravityInput.Size = new System.Drawing.Size(100, 29);
            this.UniGravityInput.TabIndex = 8;
            this.UniGravityInput.Text = "6.6740831E-11";
            // 
            // PlanetMassInput
            // 
            this.PlanetMassInput.Location = new System.Drawing.Point(24, 361);
            this.PlanetMassInput.Name = "PlanetMassInput";
            this.PlanetMassInput.Size = new System.Drawing.Size(100, 29);
            this.PlanetMassInput.TabIndex = 9;
            this.PlanetMassInput.Text = "5.972E24";
            // 
            // PlanetRaduisInput
            // 
            this.PlanetRaduisInput.Location = new System.Drawing.Point(174, 361);
            this.PlanetRaduisInput.Name = "PlanetRaduisInput";
            this.PlanetRaduisInput.Size = new System.Drawing.Size(100, 29);
            this.PlanetRaduisInput.TabIndex = 10;
            this.PlanetRaduisInput.Text = "63710000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Drag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "F Density";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "G accel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "G const";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Planet Mass";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Planet Radius";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Height:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Acceleration: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Velocity:";
            // 
            // NewtonianCheck
            // 
            this.NewtonianCheck.AutoSize = true;
            this.NewtonianCheck.Location = new System.Drawing.Point(142, 503);
            this.NewtonianCheck.Name = "NewtonianCheck";
            this.NewtonianCheck.Size = new System.Drawing.Size(130, 29);
            this.NewtonianCheck.TabIndex = 3;
            this.NewtonianCheck.Text = "Newtonian";
            this.NewtonianCheck.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(461, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(824, 508);
            this.listBox1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(518, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(183, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Height";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 418);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 25);
            this.label15.TabIndex = 27;
            this.label15.Text = "Velocity";
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(174, 446);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(100, 29);
            this.HeightInput.TabIndex = 26;
            this.HeightInput.Text = "5";
            // 
            // VelocityInput
            // 
            this.VelocityInput.Location = new System.Drawing.Point(28, 446);
            this.VelocityInput.Name = "VelocityInput";
            this.VelocityInput.Size = new System.Drawing.Size(100, 29);
            this.VelocityInput.TabIndex = 25;
            this.VelocityInput.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(338, 418);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 25);
            this.label16.TabIndex = 30;
            this.label16.Text = "Duration";
            // 
            // DurationInput
            // 
            this.DurationInput.Location = new System.Drawing.Point(331, 446);
            this.DurationInput.Name = "DurationInput";
            this.DurationInput.Size = new System.Drawing.Size(100, 29);
            this.DurationInput.TabIndex = 29;
            this.DurationInput.Text = "5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(332, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "Time Step";
            // 
            // StepInput
            // 
            this.StepInput.Location = new System.Drawing.Point(331, 361);
            this.StepInput.Name = "StepInput";
            this.StepInput.Size = new System.Drawing.Size(100, 29);
            this.StepInput.TabIndex = 31;
            this.StepInput.Text = "0.01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 625);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.StepInput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.DurationInput);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.VelocityInput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlanetRaduisInput);
            this.Controls.Add(this.PlanetMassInput);
            this.Controls.Add(this.UniGravityInput);
            this.Controls.Add(this.GravityAccelInput);
            this.Controls.Add(this.MassInput);
            this.Controls.Add(this.RadiusInput);
            this.Controls.Add(this.NewtonianCheck);
            this.Controls.Add(this.FDensityInput);
            this.Controls.Add(this.DragInput);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DragInput;
        private System.Windows.Forms.TextBox FDensityInput;
        private System.Windows.Forms.TextBox RadiusInput;
        private System.Windows.Forms.TextBox MassInput;
        private System.Windows.Forms.TextBox GravityAccelInput;
        private System.Windows.Forms.TextBox UniGravityInput;
        private System.Windows.Forms.TextBox PlanetMassInput;
        private System.Windows.Forms.TextBox PlanetRaduisInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox NewtonianCheck;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.TextBox VelocityInput;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DurationInput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox StepInput;
    }
}

