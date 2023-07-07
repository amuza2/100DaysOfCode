using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        Dictionary<int, int[]> cellMap = new Dictionary<int, int[]>();
        cellMap.Add(1, new int[] {0,2});
        int input = int.Parse(Console.ReadLine());
        int i = cellMap[input][0];
        int j = cellMap[input][1];
        Console.WriteLine(i + " " + j);

    }
        
}