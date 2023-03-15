using System;
using System.Text;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        
        struct Student
        {
            public int ID;
            public string FirstName;
            public string LastName;
            public int Age;
            public string state;
            public Birthday DateOfBirth; 
            public string Speciality;
            public int Group;  
        }

        struct Birthday
        {
            public int year;
            public int month;
            public int day;
        }
        static void Menu()
        {
            Console.WriteLine("Choose 1, 2, 3 or 4:");
            Console.WriteLine("1- Add");
            Console.WriteLine("2- Research");
            Console.WriteLine("3- View");
            Console.WriteLine("4- Exit");
        }
        static void Main(string[] args)
        {
            while(true){   
                Menu();
                Console.WriteLine("----------------------");
                // make sure to add a valid integer
                int choice;
                while(true){
                    bool success = int.TryParse(Console.ReadLine(), out choice);
                    if (success && choice > 0 && choice < 5) break;
                    else Console.WriteLine("- Please add a valid number -");
                }
                // make sure to add a number of students at the beginning
                // and that value is valid (greater than zero)
                bool WriteNumberOfStudents = false;
                Student[] StudentInfo = new Student[1];
                int StudentNumber = 1;
                if(choice == 1){
                    if(!WriteNumberOfStudents){
                        Console.WriteLine("Enter the number of Students: ");
                        while(true){
                            bool success = int.TryParse(Console.ReadLine(), out StudentNumber);
                            if(success && StudentNumber > 0){
                                StudentInfo = new Student[StudentNumber];
                                WriteNumberOfStudents = true;
                                Console.WriteLine($"You created a table of {StudentNumber} students.");
                                break;
                            }else Console.WriteLine("- Please add valid number -");
                        }
                    }
                    for(int i = 0; i < StudentNumber; i++){
                        StudentInfo[i].ID = i + 1;
                        Console.Write($"Enter student{i} firstname: ");
                        StudentInfo[i].FirstName = Console.ReadLine();
                        Console.Write($"Enter student{i} lastname: ");
                        StudentInfo[i].LastName = Console.ReadLine();
                        Console.Write($"Enter student{i} age: ");
                        StudentInfo[i].Age = int.Parse(Console.ReadLine());
                        /*Console.Write($"Enter student{i} state: ");
                        StudentInfo[i].state = Console.ReadLine();
                        Console.Write($"Enter student{i} day of DateOfBirth: ");
                        StudentInfo[i].DateOfBirth.day = int.Parse(Console.ReadLine());
                        Console.Write($"Enter student{i} month of DateOfBirth: ");
                        StudentInfo[i].DateOfBirth.month = int.Parse(Console.ReadLine());
                        Console.Write($"Enter student{i} year of DateOfBirth: ");
                        StudentInfo[i].DateOfBirth.year = int.Parse(Console.ReadLine());
                        Console.Write($"Enter student{i} speciality: ");
                        StudentInfo[i].Speciality = Console.ReadLine();
                        Console.Write($"Enter student{i} group: ");
                        StudentInfo[i].Group = int.Parse(Console.ReadLine());   */
                    }
                }
                else if(choice == 2){
                    int IdSearch;
                    while(true){
                        Console.Write("Add an ID number: ");
                        bool success = int.TryParse(Console.ReadLine(), out IdSearch);
                        if (!success) Console.WriteLine("- Please add a valid ID number -");
                        else break;
                    }
                    Console.WriteLine($"ID is {IdSearch}");
                    Console.WriteLine($"FirstName is {StudentInfo[0].FirstName}");
                    Console.WriteLine($"LastName is {StudentInfo[0].LastName}");
                    Console.WriteLine($"Age is {StudentInfo[0].Age}");
                    Console.WriteLine("---------------------------");
                    for(int i = 0; i < StudentNumber; i++){
                        if(StudentInfo[i].ID == IdSearch){
                            Console.WriteLine($"ID is {IdSearch}");
                            Console.WriteLine($"FirstName is {StudentInfo[i].FirstName}");
                            Console.WriteLine($"LastName is {StudentInfo[i].LastName}");
                            Console.WriteLine($"Age is {StudentInfo[i].Age}");
                            
                        }
                    }
                }else if(choice == 4) break;



            }
        }
    }
}