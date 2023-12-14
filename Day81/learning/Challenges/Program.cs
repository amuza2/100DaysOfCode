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
        //public static string CuckooClock(string inputTime, int chimes)
        //{
        //    string[] splitTime = inputTime.Split(':');
        //    int hour = int.Parse(splitTime[0]);
        //    int minute = int.Parse(splitTime[1]);
        //    int leftTimeInHour = Math.Abs(59 - minute);
        //    int champsCounter = 0;
        //    for (int i = 0; i < 12; i++)
        //    {
        //        champsCounter += leftTimeInHour % 15;
        //        if (minute == 0) champsCounter += hour;

        //        hour++;

        //    }
        //    return inputTime;
        //}
        public static int[] TwoOldestAges(int[] ages)
        {
            Array.Sort(ages);
            Array.Reverse(ages);
            Console.WriteLine($"{ages[0]} {ages[1]} {ages[2]} {ages[3]}");
            int[] result = { ages[0], ages[1] };
            return result;
        }

        static void Main(string[] args)
        {
            foreach(var item in TwoOldestAges(new int[] { 1, 2, 10, 8 }))
            {
                Console.WriteLine(item);
            }
        }
    }
}
