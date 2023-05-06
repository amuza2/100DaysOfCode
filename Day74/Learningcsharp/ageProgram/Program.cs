using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    struct certifitcateTest
    {
        public int ID;
        public string Name;
        public string Description;
    }
    static void Menu()
    {
        Console.WriteLine("1 - Add new certificate");
        Console.WriteLine("2 - View certificate");
        Console.WriteLine("3 - Edit certificate");
        Console.WriteLine("5 - Exit");
    }
    static void Main(string[] args)
    {
        bool work = true;
        string filename = "testfile.json";
        List<certifitcateTest> students = new List<certifitcateTest>();

        while(work)
        {
            Menu();
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                certifitcateTest studentInfo = new certifitcateTest();
                Console.Write("Enter ID number: ");
                studentInfo.ID = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                studentInfo.Name = Console.ReadLine();
                Console.Write("Enter Description: ");
                studentInfo.Description = Console.ReadLine();
                if (File.Exists(filename))
                {
                    string jsonData = File.ReadAllText(filename);
                    students = JsonConvert.DeserializeObject<List<certifitcateTest>>(jsonData);
                }
                students.Add(studentInfo);
                string updateData = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText(filename, updateData);
            }
            else if (choice == "2")
            {
                if (File.Exists(filename))
                {
                    string jsonData = File.ReadAllText(filename);
                    List<certifitcateTest> storedCertificates = JsonConvert.DeserializeObject<List<certifitcateTest>>(jsonData);
                    foreach (certifitcateTest storedCertificate in storedCertificates)
                    {
                        Console.WriteLine($"ID: {storedCertificate.ID}, Name: {storedCertificate.Name}, Description: {storedCertificate.Description}");
                    }
                }
                else
                {
                    Console.WriteLine("No certificates stored.");
                }
            }
            else if(choice == "5") { work = false; }
        }
    }
        
}