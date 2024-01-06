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
        public static void Print(int[] val)
        {
            foreach (var item in val)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static string[] greek_alphabet = { "alpha", "beta", "gamma", "delta", "epsilon",
            "zeta", "eta", "theta", "iota", "kappa", "lambda", 
            "mu", "nu", "xi", "omicron", "pi", "rho", "sigma", "tau", 
            "upsilon", "phi", "chi", "psi", "omega" };

        public static int greekComparator(string lhs, string rhs)
        {
            if (lhs == rhs) return 0;
            else
            {
                int result = 0;
                if (lhs[0] < rhs[0]) result = -1;
                else result = 1;
                return result;
            }
        }
        public static void pairs(string[] pairs)
        {
            var random = new Random();
            for (int i = 0; i < greek_alphabet.Length; i++)
            {
                var pair = new { x = greek_alphabet[random.Next(greek_alphabet.Length)], y = greek_alphabet[random.Next(greek_alphabet.Length)]};
                int resultTest = pair.x == pair.y ? 0 : Array.IndexOf(greek_alphabet, pair.x) < Array.IndexOf(greek_alphabet, pair.y) ? -1 : 1;
                int userResult = Solution.GreekComparator(pair.x, pair.y);
                if (userResult == 0)
                {
                    Assert.AreEqual(userResult, 0);
                }
                else if (userResult == 1) Assert.Greater(userResult, 0);    
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(greekComparator("alpha", "beta"));
            Console.WriteLine(greekComparator("chi", "chi"));
            Console.WriteLine(greekComparator("upsilon", "rho"));

        }
    }
}
