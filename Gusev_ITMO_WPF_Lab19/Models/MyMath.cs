using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_WPF_Lab19.Models
{
    static class MyMath
    {
        public static double GetCircumferenceFromRadius(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
