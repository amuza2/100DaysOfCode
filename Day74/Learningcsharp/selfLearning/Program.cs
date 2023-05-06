using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections.Generic;

namespace selfLearning
{
    public class Program
    {
        struct Date { public int year; public int month; public int day; }
        struct certificateInfirmation
        {
            public int ID;
            public string FirstName;
            public string LastName;
            public string section;
            public Date birthday;
            public string birthPlace;
            public Date startFormation;
            public Date endFormation;
            public Date certificateReleaseDate;
        }
        static void Menu()
        {
            Console.WriteLine("Certificate creation tool");
            Console.WriteLine();
            Console.WriteLine("Choose from 1 to 4:");
            Console.WriteLine("1 - Add new certificate");
            Console.WriteLine("2 - View certificate");
            Console.WriteLine("3 - Edit certificate");
            Console.WriteLine("4 - Exit");
        }
        
        static string checkNotEmptyString(string errorMessage)
        {
            string value;
            while (true)
            {
                value = Console.ReadLine();
                if (value.Trim().Length > 0) { Console.Clear(); break; }
                else { Console.WriteLine(errorMessage); }
            }
            return value;
        }
        static string FirstName(string name)
        {
            string value = "";
            while(true)
            {
                Console.Write(name);
                value = Console.ReadLine();
                if (value.Trim().Length > 0) break;
                else Console.Clear();
            }
            return value;
        }
        
        static int doIntConversion()
        {
            int value;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out value))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter a valid number");
                }
            }
            return value;
        }
        static void Main(string[] args)
        {
            bool work = true;
            string filePath = "certificate.json";
            List<certificateInfirmation> students = new List<certificateInfirmation>();
            while (work)
            {
                // show the Menu
                Menu();

                // let the user choose a value valid number
                string choice = "";
                while(true)
                {
                    choice = Console.ReadLine();
                    if (choice.Length == 0) Console.WriteLine("Please choose a value from 1 to 4!");
                    else break;
                }
                
                // Create an instance of certificate struct
                // Create a file

                // if the user choosed 1 from the Menu which is add a new certificate
                if (choice == "1")
                {
                    Console.WriteLine("You chooed to create a new certificate");
                    Console.WriteLine();

                    certificateInfirmation studentInfo = new certificateInfirmation();
                    Console.Write("Enter the ID number: ");
                    studentInfo.ID = int.Parse(Console.ReadLine());
                    Console.Write("Enter First name: ");
                    studentInfo.FirstName = Console.ReadLine();
                    Console.Write("Enter Last name: ");
                    studentInfo.LastName = Console.ReadLine();
                    Console.Write("Enter Section: ");
                    studentInfo.section = Console.ReadLine();
                    Console.WriteLine("Enter Birth date: ");
                    Console.Write("    Enter Birth date day: ");
                    studentInfo.birthday.day = int.Parse(Console.ReadLine());
                    Console.Write("    Enter Birth date month: ");
                    studentInfo.birthday.month = int.Parse(Console.ReadLine());
                    Console.Write("    Enter Birth date year: ");
                    studentInfo.birthday.year = int.Parse(Console.ReadLine());
                    Console.Write("Enter birth place: ");
                    studentInfo.birthPlace = Console.ReadLine();

                    Console.WriteLine("Enter date of start formation: ");
                    Console.Write("    Enter formation start day: ");
                    studentInfo.startFormation.day = int.Parse(Console.ReadLine());
                    Console.Write("    Enter formation start month: ");
                    studentInfo.startFormation.month = int.Parse(Console.ReadLine());
                    Console.Write("    Enter formation start year: ");
                    studentInfo.startFormation.year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter date of end formation: ");
                    Console.Write("    Enter formation end day: ");
                    studentInfo.endFormation.day = int.Parse(Console.ReadLine());
                    Console.Write("    Enter formation end month: ");
                    studentInfo.endFormation.month = int.Parse(Console.ReadLine());
                    Console.Write("    Enter formation end year: ");
                    studentInfo.endFormation.year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter date of certificate release: ");
                    Console.Write("    Enter certificate release - day: ");
                    studentInfo.certificateReleaseDate.day = int.Parse(Console.ReadLine());
                    Console.Write("    Enter certificate release - month: ");
                    studentInfo.certificateReleaseDate.month = int.Parse(Console.ReadLine());
                    Console.Write("    Enter certificate release - year: ");
                    studentInfo.certificateReleaseDate.year = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("You entered the data successfully");
                    Console.WriteLine("Now you have the ability to View, Edit or Export the certificate.");

                    // Read the existing contents of the file, if it exists
                    if (File.Exists(filePath))
                    {
                        string jsonData = File.ReadAllText(filePath);
                        // Deserialize the JSON string into a List<certificateInfirmation>
                        students = JsonConvert.DeserializeObject<List<certificateInfirmation>>(jsonData);
                    }
                    // Add the new certificate to the list
                    students.Add(studentInfo);
                    // Serialize the updated list to a JSON string and write it to the file
                    string updateData = JsonConvert.SerializeObject(students, Formatting.Indented);
                    File.WriteAllText(filePath, updateData);
                }
                else if (choice == "2")
                {
                    // user search by ID
                    Console.Write("Search by ID: ");
                    int SearchById = int.Parse(Console.ReadLine());
                    //read the json file
                    if (File.Exists(filePath))
                    {
                        string jsonData = File.ReadAllText(filePath);
                        List<certificateInfirmation> storedCertificates = JsonConvert.DeserializeObject<List<certificateInfirmation>>(jsonData);
                        // Loop through each key-value pair in the JObject and print them
                        foreach (certificateInfirmation item in storedCertificates)
                        {
                            if (item.ID == SearchById)
                            {
                                Console.Clear();
                                Console.WriteLine("ID: " + item.ID);
                                Console.WriteLine("FirstName: " + item.FirstName);
                                Console.WriteLine("LastName: " + item.LastName);
                                Console.WriteLine("Section: " + item.section);
                                Console.WriteLine($"Birthday: {item.birthday.day}/{item.birthday.month}/{item.birthday.year}");
                                Console.WriteLine("Birth Place: " + item.birthPlace);
                                Console.WriteLine($"Start formation: {item.startFormation.day}/{item.startFormation.month}/{item.startFormation.year}");
                                Console.WriteLine($"End formation: {item.endFormation.day}/{item.endFormation.month}/{item.endFormation.year}");
                                Console.WriteLine($"Certificate Release data: {item.certificateReleaseDate.day}/{item.certificateReleaseDate.month}/{item.certificateReleaseDate.year}");
                                break;
                            }
                        }
                    }
                }
                else if(choice == "3")
                {
                    Console.WriteLine("You are now in editing mode");
                    Console.WriteLine();
                    Console.WriteLine("What do you want to edit?");
                    Console.WriteLine("1 - First name");
                    Console.WriteLine("2 - Last name");
                    Console.WriteLine("3 - Section");
                    Console.WriteLine("4 - Birthday");
                    Console.WriteLine("5 - Birth place");
                    Console.WriteLine("6 - Start formation");
                    Console.WriteLine("7 - End formation");
                    Console.WriteLine("8 - Certificate Releace data");
                    Console.WriteLine("9 - Edit everything");
                    Console.WriteLine("Choose any value to edit or write 'n' to escape");

                    if (File.Exists(filePath))
                    {
                        string jsonData = File.ReadAllText(filePath);
                        List<certificateInfirmation> storedCertificates = JsonConvert.DeserializeObject<List<certificateInfirmation>>(jsonData);
                        int SearchByid = doIntConversion();
                        foreach (certificateInfirmation item in storedCertificates)
                        {
                            if (SearchByid == item.ID)
                            {
                                //TypeCode here
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data available, json file doesn't exit");
                    }
                    


                }
                else if (choice == "4")
                {
                    work = false;
                    break;
                }
            }
        }
    }
}
