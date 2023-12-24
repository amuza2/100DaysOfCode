using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

        public static int CrazyFormula(long n)
        {
            string sNum = n.ToString();
            int lengthTracker = sNum.Length;
            int result = 0;
            
            // remove a num if it's length is even
            repeat:
            if(lengthTracker % 2 == 0)
            {
                sNum = "";
                int nLength = n.ToString().Length;
                for (int i = 0; i < nLength; i++)
                {
                    if (i != nLength - 1) sNum += n.ToString()[i]; 
                }
            }

            if (result != 0)
            {
                sNum = result.ToString();
                result = 0;
            }
            int middleValue = sNum.Length / 2;
            int lastIndex = sNum.Length - 1;
            // odd in the middle
            for (int i = 0; i < sNum.Length; i++)
            {
                int first = sNum[i] - '0';
                int last = sNum[sNum.Length - 1 - i] - '0';

                if (sNum[middleValue] % 2 != 0)
                {
                    if (i != middleValue) result += first + last;
                    else
                    {
                        result -= first;
                        break;
                    }
                }
                // even in both middle and last
                else if (sNum[middleValue] % 2 == 0 && sNum[sNum.Length - 1] % 2 == 0)
                {
                    if (i != middleValue)
                    {
                        if (sNum.Length - 1 - i == lastIndex) result += first - last;
                        else result += first + last;
                    }
                    else
                    {
                        result += first;
                        break;
                    }
                }
                // even if the middle but odd last
                else if (sNum[middleValue] % 2 == 0 && sNum[sNum.Length - 1] % 2 != 0)
                {
                    if (i == 0) result += (int)Math.Pow(first, 2) + last;
                    else if(i == middleValue)
                    {
                        result += first;
                        break;
                    }
                    else result += first + last;  
                }
            }
            lengthTracker = result.ToString().Length;
            if (0 > result) result = Math.Abs(result);
            if (result.ToString().Length == 2)
                return result.ToString()[0] - '0';
            else if(result.ToString().Length == 3) goto repeat;
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(CrazyFormula(214) == 5);
            Console.WriteLine(CrazyFormula(126) == 3);
            Console.WriteLine(CrazyFormula(2234) == 9);
            Console.WriteLine(CrazyFormula(5) == 5);
            Console.WriteLine(CrazyFormula(77633658797932970) == 8);
            Console.WriteLine(CrazyFormula(7852) == 6);
            Console.WriteLine(CrazyFormula(545773478256345856) == 7);
            //Console.WriteLine(CrazyFormula(7852) == 6);

            //Debug.Assert(CrazyFormula(214) == 5);
            //Debug.Assert(CrazyFormula(126) == 3);
            //Debug.Assert(CrazyFormula(2234L) == 9);
            //Debug.Assert(CrazyFormula(5L) == 5);

        }
    }
}
