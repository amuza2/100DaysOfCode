using System.Runtime.CompilerServices;

namespace Program
{
    class Linq
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6,};
           var people = new List<Person>
           {
                new Person ("John", "Deer", 23),
                new Person ("John", "Apple", 56),
                new Person ("Tim", "Walters", 19),
                new Person ("April", "Johnson", 31)
           };
           
           var employees = new List<Employee>
           {
            new Employee ("John", "Miller","Development"),
            new Employee ("Jack", "Stevens","Sales"),
            new Employee ("Maria", "Mc Allister", "Sales"),
            new Employee ("Christopher", "Collum","Project Management"),
            new Employee ("Javier", "Alegro", "Development")
           };

            var selectEmployees = from employee in employees
                                  group employee by employee.Department into groupedEmployee
                                  orderby groupedEmployee.Key
                                  select groupedEmployee;
            foreach (var dep in selectEmployees)
            {
                System.Console.WriteLine(dep.Key);
                foreach (var emp in dep)
                {
                    System.Console.WriteLine($"\t{emp.FirstName} {emp.LastName}");
                }
            }
        }
    }
}