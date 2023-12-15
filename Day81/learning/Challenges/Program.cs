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
            int oldest1 = -1;
            int oldest2 = -1;
            foreach (int age in ages)
            {
                if (age > oldest1)
                {
                    oldest2 = oldest1;
                    oldest1 = age;
                }
                else if (age > oldest2)
                {
                    oldest2 = age;
                }
            }
            return new int[] { oldest2, oldest1 };
        }
        // old 1 = 10
        // old 2 = 8
        public static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Print(TwoOldestAges(new int[] { 1, 2, 10, 8 }));
            Print(TwoOldestAges(new int[] { 117,116, 115, 112, 108, 107, 106, 86, 85, 76, 72, 66 ,58 ,32 ,24 ,17 ,14 ,11 ,8 ,0 }));
            //Print(TwoOldestAges(new int[] { 1, 2, 10, 8 }));


        }
    }
}
