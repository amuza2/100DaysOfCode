using System;

namespace SoloLearn
{
    class Program
    {
        static int LetterCounter(string str, char k)
        {
            int counter = 0;
            int NoResult = -1;
            int index = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == k)
                {
                    counter++;
                    if(counter == 2){
                        index = i;
                        break;
                    }
                }
            }
            if(counter > 1) return index;
            else return NoResult; 
        }
       static void Main(string[] args)
        {
            Console.WriteLine(LetterCounter("Hello World;", 'l'));
        } 
    }        
}