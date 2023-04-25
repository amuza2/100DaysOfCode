using System;

namespace SoloLearn;

public class Magazine : Publication
{
    string _publisher;
    public string Publisher {get; set;}
    public Magazine(string name, string publisher, int pageCount, decimal price)
        :base (name, pageCount, price)
    {
        _publisher = publisher;
    }
}