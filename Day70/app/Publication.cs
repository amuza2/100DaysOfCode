using System;

namespace SoloLearn;

public class Publication
{
    string _name;
    public int PageCount {get; set;}
    public decimal Price {get; set;}

    public string Name {
        get {return _name;}
        set {
            if(value == ""){
                Console.WriteLine("You can't enter black");
            }
            _name = value;
        }
    }
    public Publication(string name, int pageCount, decimal price)
    {
        _name = name;
        PageCount = pageCount;
        Price = price;
    }

    public virtual string GetDescription(){
        return $"{Name}, {PageCount} pages";
    }
}