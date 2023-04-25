using System;

namespace SoloLearn;
class Book : Publication
{
    string _author;
    public string Author {get; set;}
    public Book(string name, string author, int pageCount, decimal price)
        : base(name, pageCount, price)
    {
        _author = author;
    }
    public override string GetDescription()
    {
        return $"Name: {Name} Author: {_author}"; 
    } 
} 