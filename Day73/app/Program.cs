using System;
namespace learning;



class Program
{
    public static int SumOfSequence(int b, int e, int s)
    {
        int result = 0;
        for(int i = b; i<=e; i += s)
        {
            result += i;
        }
        return result;
    }
    static void Main(string[] args)
        {
            SumOfSequence(2,2,2);
            SumOfSequence(2,6,2);
            SumOfSequence(1,5,1);
            SumOfSequence(1,5,3);
        }
}