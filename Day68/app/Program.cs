using System;
using System.Text;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //const string filename = "text.txt";
            //using(StreamWriter sw = File.CreateText(filename)){
            //    sw.WriteLine("Nadjat Ghofran");
            //}

            // StreamWriter file = new StreamWriter("numbers.txt");
            // int[] num = {1,2,3,4,5};
            // for(int i = 0; i<num.Length; i++){
            //     file.WriteLine(num[i]);
            // }
            // file.Close();

            StreamReader file = new StreamReader("numbers.txt");
            int num;
            while(!file.EndOfStream){
                num = int.Parse(file.ReadLine());
                Console.WriteLine(num);
            }
            //file.Close();

        }
    }
}