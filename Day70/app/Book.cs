using System;

namespace SoloLearn;
class Book : Publication
{
    public string Author {get; set;}
    public Book(string name, string author, int pageCount, decimal price)
        : base(name, pageCount, price)
    {
        Author = author;
    }
    public override string ToString() //GetDescription
    {
        return $"Name: {Name} Author: {Author}"; 
    }

    public string ToString(char format)
    {
        if(char.ToUpper(format) == 'B')
        {
            return $"Book: {Name} : {Author}";
        }
        if(char.ToUpper(format) == 'F')
        {
            return $"Book: {Name} by {Author} {PageCount} pages";
        }
        return ToString();
    }
} 

