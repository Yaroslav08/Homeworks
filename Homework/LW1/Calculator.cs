using System;
using System.Collections.Generic;
using System.Text;
namespace LW1
{
    public class Calculator
    {
        private int commonLength;
        private int firstSpeed;
        private int secondSpeed;

        public Calculator(int commonLength, int firstSpeed, int secondSpeed)
        {
            this.commonLength = commonLength;
            this.firstSpeed = firstSpeed;
            this.secondSpeed = secondSpeed;
        }

        public int GetHoursOfWalk()
        {
            return commonLength / (firstSpeed + secondSpeed);
        }
    }
}