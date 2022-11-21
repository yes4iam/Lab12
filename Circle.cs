using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    static class Circle
    {
        static public double GetCircleLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetCircleSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public string CheckCirclePoint(double r, double x, double y)
        {
            if (Math.Abs(x) > r)
            {
                return "точка не лежит внутри окружности";
            }
            else
            {
                if (Math.Abs(y) > r)
                {
                    return "точка не лежит внутри окружности";
                }
                else
                {
                    return "точка лежит внутри окружности";
                }

            }

            
        }
    }
}
