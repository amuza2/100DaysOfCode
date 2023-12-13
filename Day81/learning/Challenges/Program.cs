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
        public static string ReverseWords(string str)
        {
            string result = "";
            string[] arr =  str.Split(' ');
            foreach (var item in arr)
            {
                result += item.Reverse().ToString() + " ";
                Console.WriteLine(result);
            }
            return result.Trim();
        }

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
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("This is an example!"));
        }
    }
}
