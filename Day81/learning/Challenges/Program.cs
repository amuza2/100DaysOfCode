using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

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
        // abcdefghigklmnpoqrstuvwxyz
        // mohammed
        // nrkersll    
        public static void Print(int[] val)
        {
            foreach (var item in val)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static bool HasSubpattern(string str)
        {

            return false;
        }

        static void Main(string[] args)
        {
            

        }
    }
}
