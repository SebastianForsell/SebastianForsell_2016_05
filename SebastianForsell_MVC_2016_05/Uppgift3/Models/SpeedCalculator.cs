using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Models
{
    public class SpeedCalculator
    {
        public double GetCurrentSpeed(string distance, string time)
        {
            double m = int.Parse(distance);
            double s = int.Parse(time);
            return m / s;
        }
    }
}
