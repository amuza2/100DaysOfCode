using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Program
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int lengthOfList = ClassPoints.Length;
            int sumOfPoints = ClassPoints.Sum();
            int resultValue = (sumOfPoints + YourPoints) / (lengthOfList + 1);
            if (YourPoints > resultValue) return true;
            return false;
        }

        static void Main(string[] args)
        {

        }
    }
}
