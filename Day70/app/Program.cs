using System;
using System.Linq;
using System.Text;

namespace SoloLearn
{
    class Program
    {
        static void Output(string[] value)
        {
            foreach(string i in value)
            {
                Console.WriteLine(i);
            }
        }
        enum TrafficLight {Green, Red, Yellow};
        
       static void Main(string[] args)
        {
            TrafficLight x = TrafficLight.Red;
            switch(x){
                case TrafficLight.Green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLight.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("Caution!");
                    break;
            }
        } 
    }        
}