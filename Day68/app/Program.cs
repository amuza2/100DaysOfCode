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
            Student[] StudentInfo;
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
                Student st;
                for(int i = 0; i < StudentNumber; i++){
                    StudentInfo[i].ID = 1;
                    Console.Write("Enter student firstname: ");
                    st.FirstName = Console.ReadLine();
                    Console.Write("Enter student lastname: ");
                    st.LastName = Console.ReadLine();
                    Console.Write("Enter student age: ");
                    st.Age = int.Parse(Console.ReadLine());
                    Console.Write("Enter student state: ");
                    st.state = Console.ReadLine();
                    Console.Write("Enter student day of DateOfBirth: ");
                    st.DateOfBirth.day = int.Parse(Console.ReadLine());
                    Console.Write("Enter student month of DateOfBirth: ");
                    st.DateOfBirth.month = int.Parse(Console.ReadLine());
                    Console.Write("Enter student year of DateOfBirth: ");
                    st.DateOfBirth.year = int.Parse(Console.ReadLine());
                    Console.Write("Enter student speciality: ");
                    st.Speciality = Console.ReadLine();
                    Console.Write("Enter student group: ");
                    st.Group = int.Parse(Console.ReadLine());
                    
                }
            }



        }
    }
}