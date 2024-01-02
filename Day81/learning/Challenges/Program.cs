using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
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
        // abcdefghigklmnpoqrstuvwxyz
        // mohammed
        // nrkersll    
        public static void Print(string[] val)
        {
            foreach (var item in val)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> arr = new List<string>();
            int i = 0;
            foreach (string item1 in array1)
            {
                foreach (string item2 in array2)
                {
                    if (item2.Contains(item1))
                    {
                        arr.Add(item1);
                        break;
                    }
                }
            }
            arr.Sort();
            return arr.ToArray();
        }

        static void Main(string[] args)
        {
            string[] arr = inArray(new[] { "arp", "live", "strong" }, new[] { "lively", "alive", "harp", "sharp", "armstrong" });
            //string[] arr1 = inArray(new[] { "arp", "mice", "bull" }, new[] { "lively", "alive", "harp", "sharp", "armstrong" });

            Print(arr);
            //Print(arr1);

        }
    }
}
