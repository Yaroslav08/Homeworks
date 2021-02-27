using System;
using System.Collections.Generic;
using System.Text;
namespace LW1
{
    public class Calculator
    {
        private double commonLength;
        private double firstSpeed;
        private double secondSpeed;

        public Calculator(int commonLength, int firstSpeed, int secondSpeed)
        {
            this.commonLength = commonLength;
            this.firstSpeed = firstSpeed;
            this.secondSpeed = secondSpeed;
        }

        public double GetHoursOfWalk()
        {
            return Math.Round(commonLength / (firstSpeed + secondSpeed), 3);
        }
    }
}