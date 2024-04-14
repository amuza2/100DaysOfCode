public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Person(string fname, string lname, int age)
    {
        FirstName = fname;
        LastName = lname;
        Age = age;
    }
}