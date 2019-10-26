using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_UnitTesting
{
    public class Triangle
    {
        public static bool IsValid(int sideA, int sideB, int sideC)
        {
            return (sideA < sideB + sideC)
                && (sideB < sideA + sideC)
                && (sideC < sideA + sideB);
        }
    }
}
