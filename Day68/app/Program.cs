using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filename = "Testfile.txt";

            // using (StreamWriter sw = File.CreateText(filename)){
            //     sw.WriteLine("This is a text file.");
            // }
            File.AppendAllText(filename, "This is a new text.");
            // using (StreamWriter sw = File.AppendText(filename)){

            // }


            string content;
            content = File.ReadAllText(filename);
            Console.WriteLine(content);

        }
    }

}