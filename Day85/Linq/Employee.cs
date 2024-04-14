public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set;}
    public string Department { get; set; }

    public Employee(string fname, string lname, string dep)
    {
        FirstName = fname;
        LastName = lname;
        Department = dep;
    }
}